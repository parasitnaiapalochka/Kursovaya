using LAB_movies_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_movies.v2_
{
    public partial class MovieForm : Form
    {
        // Статический список фильмов
        private int selectedMovieIndex = -1;
        private static List<Movie> movies = new List<Movie>
        {
            new Movie("Movie 1", Category.ACTION, new Person("John Doe", "Scriptwriter"), new Person("Jane Doe", "Director"),
                      new ProductionCompany("Company A", "Address 1", new BankAccount("Bank A", "1234"), "Tax123"), 2021, 100_000,
                      new Supplier("Supplier A", "Address A", new BankAccount("Bank A", "5678"), "Supplier1")),
            new Movie("Movie 2", Category.DRAMA, new Person("Alice Smith", "Scriptwriter"), new Person("Bob Brown", "Director"),
                      new ProductionCompany("Company B", "Address 2", new BankAccount("Bank B", "2345"), "Tax456"), 2020, 150_000,
                      new Supplier("Supplier B", "Address B", new BankAccount("Bank B", "6789"), "Supplier2")),
            new Movie("Movie 3", Category.COMEDY, new Person("Charlie Johnson", "Scriptwriter"), new Person("Dave White", "Director"),
                      new ProductionCompany("Company C", "Address 3", new BankAccount("Bank C", "3456"), "Tax789"), 2022, 120_000,
                      new Supplier("Supplier C", "Address C", new BankAccount("Bank C", "1234"), "Supplier3"))
        };
     
        public MovieForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Category));
            LoadMoviesFromJson();
            DisplayMoviesInListBox();

            // Подписываемся на событие
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedMovieIndex = listBox1.SelectedIndex;
                var movie = movies[selectedMovieIndex];

                // Заполняем поля формы данными выбранного фильма
                textBox1.Text = movie.Title;
                comboBox1.SelectedItem = movie.Category;

                textBox2.Text = movie.ScriptWriter.FullName;
                textBox3.Text = movie.ScriptWriter.ContactInfo;

                textBox4.Text = movie.Director.FullName;
                textBox5.Text = movie.Director.ContactInfo;

                textBox6.Text = movie.ProductionCompany.Name;
                textBox7.Text = movie.ProductionCompany.Address;
                textBox8.Text = movie.ProductionCompany.BankAccount.BankName;
                textBox9.Text = movie.ProductionCompany.BankAccount.AccountNumber;
                textBox10.Text = movie.ProductionCompany.TaxId;

                textBox11.Text = movie.ReleaseYear.ToString();

                // Если у вас есть дополнительные поля для стоимости и поставщика, заполните их здесь
                // textBox12.Text = movie.Cost.ToString();
                // textBox13.Text = movie.Supplier.Name;
                // ...
            }
            else
            {
                selectedMovieIndex = -1;

                // Очищаем поля, если ничего не выбрано
                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                // Очищайте дополнительные поля, если они есть
            }
        }
        // Метод для отображения фильмов в ListBox
        private void DisplayMoviesInListBox()
        {
            try
            {
                listBox1.Items.Clear(); // Очищаем ListBox перед добавлением новых данных
                foreach (var movie in movies)
                {
                    listBox1.Items.Add($"{movie.Title} - {movie.Category} - {movie.ReleaseYear}"); // Отображаем фильм
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке фильмов: {ex.Message}");
            }
        }

        // Обработчик для кнопки сохранения фильма
        private void btnSaveMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string title = textBox1.Text;
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Пожалуйста, заполните поле названия фильма.");
                    return;
                }

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите категорию фильма.");
                    return;
                }

                Category category = (Category)comboBox1.SelectedItem;

                string scriptWriterName = textBox2.Text;
                string scriptWriterContact = textBox3.Text;
                Person scriptWriter = new Person(scriptWriterName, scriptWriterContact);

                string directorName = textBox4.Text;
                string directorContact = textBox5.Text;
                Person director = new Person(directorName, directorContact);

                string productionCompanyName = textBox6.Text;
                string productionCompanyAddress = textBox7.Text;
                BankAccount productionCompanyBankAccount = new BankAccount(textBox8.Text, textBox9.Text);
                string taxId = textBox7.Text;

                // Проверка ИНН на 10 цифр
                string pattern = @"^\d{10}$";
                if (!Regex.IsMatch(taxId, pattern))
                {
                    MessageBox.Show("Поле ИНН должно содержать ровно 10 цифр");
                    textBox7.Focus();
                    return;
                }

                ProductionCompany productionCompany = new ProductionCompany(productionCompanyName, productionCompanyAddress, productionCompanyBankAccount, taxId);

                if (!int.TryParse(textBox11.Text, out int releaseYear) || releaseYear < 1900 || releaseYear > 2024)
                {
                    MessageBox.Show("Пожалуйста, введите год выпуска от 1900 до 2024.");
                    return;
                }

                // Если есть поле для стоимости, используйте его. Иначе задайте по умолчанию
                double cost = 0;
                // if (!double.TryParse(textBox12.Text, out cost) || cost <= 0)
                // {
                //     MessageBox.Show("Пожалуйста, введите корректную стоимость фильма.");
                //     return;
                // }

                // Создаем объект фильма
                Movie movie = new Movie(title, category, scriptWriter, director, productionCompany, releaseYear, cost, null); // Поставщик может быть null

                if (selectedMovieIndex != -1)
                {
                    // Обновляем существующий фильм
                    movies[selectedMovieIndex] = movie;
                    MessageBox.Show("Фильм успешно обновлен!");
                }
                else
                {
                    // Добавляем новый фильм
                    movies.Add(movie);
                    MessageBox.Show("Фильм успешно добавлен!");
                }

                SaveMoviesToJson();

                // Обновляем ListBox
                DisplayMoviesInListBox();

                // Сбрасываем выбор и очищаем поля
                listBox1.ClearSelected();
                selectedMovieIndex = -1;

                textBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                // Очищайте дополнительные поля, если они есть
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении фильма: {ex.Message}");
            }
        }


        // Метод для загрузки фильмов из файла movie.json
        private void LoadMoviesFromJson()
        {
            try
            {
                if (File.Exists("movies.json"))
                {
                    string json = File.ReadAllText("movies.json");
                    movies = JsonConvert.DeserializeObject<List<Movie>>(json); // Загружаем фильмы из JSON
                    DisplayMoviesInListBox(); // Отображаем фильмы в ListBox
                }
                else
                {
                    MessageBox.Show("Файл с фильмами не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных из файла: {ex.Message}");
            }
        }

        // Метод для сохранения фильмов в файл movie.json
        private void SaveMoviesToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(movies, Formatting.Indented);
                File.WriteAllText("movies.json", json); // Сохраняем данные в файл
                MessageBox.Show("Данные фильмов успешно сохранены в файл!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных в файл: {ex.Message}");
            }
        }
        // Обработчик для кнопки обновления списка фильмов
        private void btnUpdateMovies_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMoviesFromJson();
                DisplayMoviesInListBox();
                MessageBox.Show("Список фильмов обновлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка фильмов: {ex.Message}");
            }
        }
    }
}
