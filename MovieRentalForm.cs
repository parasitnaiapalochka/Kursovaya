using LAB_movies_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LAB_movies.v2_
{
    public partial class MovieRentalForm : Form
    {
        private const string FilePath = "movieRentals.json"; // Путь к файлу JSON
        private List<MovieRental> movieRentals = new List<MovieRental>(); // Список аренд
        private int editingIndex = -1; // Индекс редактируемой записи

        public MovieRentalForm(List<Cinema> cinemas, List<Movie> movies)
        {
            InitializeComponent();
            LoadCinemas(cinemas);
            LoadMovies(movies);
            LoadRentalsFromJson();

            // Добавляем обработчик события для listBox1
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void LoadCinemas(List<Cinema> cinemas)
        {
            if (cinemas == null || cinemas.Count == 0)
            {
                MessageBox.Show("Нет доступных кинотеатров.");
                return;
            }

            cmbCinema.DisplayMember = "Name";
            cmbCinema.ValueMember = "Name";
            cmbCinema.DataSource = cinemas;
        }

        private void LoadMovies(List<Movie> movies)
        {
            if (movies == null || movies.Count == 0)
            {
                MessageBox.Show("Нет доступных фильмов.");
                return;
            }

            cmbMovie.DisplayMember = "Title";
            cmbMovie.ValueMember = "Title";
            cmbMovie.DataSource = movies;
        }

        private void LoadRentalsFromJson()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    movieRentals = JsonConvert.DeserializeObject<List<MovieRental>>(json) ?? new List<MovieRental>();
                    UpdateRentalListBox();
                }
                else
                {
                    movieRentals = new List<MovieRental>();
                }
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show($"Ошибка в формате данных JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных из файла: {ex.Message}");
            }
        }

        private void SaveRentalsToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(movieRentals, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файл: {ex.Message}");
            }
        }

        private void UpdateRentalListBox()
        {
            listBox1.Items.Clear();
            foreach (var rental in movieRentals)
            {
                listBox1.Items.Add($"{rental.Cinema.Name} - {rental.Movie.Title} - {rental.StartDate.ToShortDateString()} - {rental.EndDate.ToShortDateString()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRentalListBox();
        }

        // Обработчик события выбора записи в ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Получаем выбранную аренду
                MovieRental selectedRental = movieRentals[listBox1.SelectedIndex];

                // Заполняем поля формы данными выбранной аренды
                cmbCinema.SelectedItem = selectedRental.Cinema;
                cmbMovie.SelectedItem = selectedRental.Movie;
                dtpStartDate.Value = selectedRental.StartDate;
                dtpEndDate.Value = selectedRental.EndDate;
                txtRentalFee.Text = selectedRental.RentalFee.ToString();
                txtDeposit.Text = selectedRental.Deposit.ToString();

                // Устанавливаем индекс редактируемой записи
                editingIndex = listBox1.SelectedIndex;
            }
        }

        private void btnSaveRental_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbCinema.SelectedIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, выберите кинотеатр.");
                    return;
                }
                Cinema selectedCinema = cmbCinema.SelectedItem as Cinema;

                if (cmbMovie.SelectedIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, выберите фильм.");
                    return;
                }
                Movie selectedMovie = cmbMovie.SelectedItem as Movie;

                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                if (startDate >= endDate)
                {
                    MessageBox.Show("Дата окончания должна быть позже даты начала.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRentalFee.Text) || !decimal.TryParse(txtRentalFee.Text, out decimal rentalFee))
                {
                    MessageBox.Show("Пожалуйста, введите корректную стоимость аренды.");
                    return;
                }

                if (rentalFee < 0)
                {
                    MessageBox.Show("Стоимость аренды не может быть отрицательной.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDeposit.Text) || !decimal.TryParse(txtDeposit.Text, out decimal deposit))
                {
                    MessageBox.Show("Пожалуйста, введите корректный депозит.");
                    return;
                }

                if (deposit < 0)
                {
                    MessageBox.Show("Депозит не может быть отрицательным.");
                    return;
                }

                MovieRental rental = new MovieRental(selectedCinema, selectedMovie, startDate, endDate, rentalFee, deposit);

                if (editingIndex != -1)
                {
                    // Обновляем существующую запись
                    movieRentals[editingIndex] = rental;
                    editingIndex = -1; // Сбрасываем индекс редактирования
                }
                else
                {
                    // Добавляем новую аренду в список
                    movieRentals.Add(rental);
                }

                // Сохраняем данные в JSON
                SaveRentalsToJson();

                MessageBox.Show("Аренда фильма успешно сохранена!");

                // Обновляем ListBox
                UpdateRentalListBox();

                // Очищаем поля формы
                ClearFormFields();

                // Сбрасываем выделение в ListBox
                listBox1.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Метод для очистки полей формы
        private void ClearFormFields()
        {
            cmbCinema.SelectedIndex = -1;
            cmbMovie.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtRentalFee.Clear();
            txtDeposit.Clear();
        }
    }

    /* private List<MovieRental> GetSampleRentals()
     {
         var rentals = new List<MovieRental>
 {
     new MovieRental(
         new Cinema("Cinema 1", "Address 1", new BankAccount("Bank A", "12345678"), "123456", "555-123", 100,
                    new Person("John Doe", "Director"),
                    new Company("TechCorp", "Corporate Blvd", new BankAccount("Bank B", "987654321"), "987654321")),
         new Movie("Movie 1", Category.ACTION, new Person("John Smith", "Scriptwriter"), new Person("Jane Doe", "Director"), null, 2022, 100000, null),
         DateTime.Now.AddDays(-2), DateTime.Now.AddDays(3), 1000, 200
     ),
     new MovieRental(
         new Cinema("Cinema 2", "Address 2", new BankAccount("Bank C", "98765432"), "654321", "555-456", 150,
                    new Person("Alice Smith", "Director"),
                    new Company("MegaCorp", "Industrial Zone", new BankAccount("Bank D", "12378945"), "321654987")),
         new Movie("Movie 2", Category.DRAMA, new Person("Alice Johnson", "Scriptwriter"), new Person("Bob Brown", "Director"), null, 2021, 150000, null),
         DateTime.Now.AddDays(-5), DateTime.Now.AddDays(10), 1200, 250
     )
 };

         return rentals;
     }*/

}

