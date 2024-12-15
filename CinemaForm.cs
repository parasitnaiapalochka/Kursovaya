using LAB_movies_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LAB_movies.v2_
{
    public partial class CinemaForm : Form
    {
        private List<Supplier> persons;
        private List<LegalEntity> legalEntities;

        public Cinema Cinema { get; set; }

        private List<Cinema> cinemas;

        public CinemaForm(List<Supplier> persons, List<LegalEntity> legalEntities, Cinema cinema = null)
        {
            InitializeComponent();
            this.persons = persons;
            this.legalEntities = legalEntities;

            cinemas = LoadCinemasFromJson();

            LoadPersons();
            LoadLegalEntities();

            if (cinema != null)
            {
                Cinema = cinema;
                PopulateFields(cinema);
            }

            // Подписываемся на событие выбора элемента в списке
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            // Отображаем список кинотеатров в listBox1 при загрузке формы
            UpdateCinemaList();
        }

        private List<Cinema> LoadCinemasFromJson()
        {
            try
            {
                if (File.Exists("cinemas.json"))
                {
                    string json = File.ReadAllText("cinemas.json");
                    return JsonConvert.DeserializeObject<List<Cinema>>(json);
                }
                else
                {
                    return new List<Cinema>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке кинотеатров из JSON: {ex.Message}");
                return new List<Cinema>();
            }
        }

        private void SaveCinemasToJson(List<Cinema> cinemas)
        {
            try
            {
                string json = JsonConvert.SerializeObject(cinemas, Formatting.Indented);
                File.WriteAllText("cinemas.json", json);
                MessageBox.Show("Кинотеатры сохранены в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении кинотеатров в JSON: {ex.Message}");
            }
        }

        private void LoadPersons()
        {
            cmbDirector.DisplayMember = "Name";
            cmbDirector.ValueMember = "FullName";
            cmbDirector.DataSource = persons;
        }

        private void LoadLegalEntities()
        {
            cmbOwner.DisplayMember = "taxId";
            cmbOwner.ValueMember = "Name";
            cmbOwner.DataSource = legalEntities;
        }

        private void PopulateFields(Cinema cinema)
        {
            txtCinemaName.Text = cinema.Name;
            txtAddress.Text = cinema.Address;
            txtPhoneNumber.Text = cinema.PhoneNumber;
            txtSeatCount.Text = cinema.SeatCount.ToString();
            cmbDirector.SelectedItem = cinema.Director;
            cmbOwner.SelectedItem = cinema.Owner;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cinemas = LoadCinemasFromJson();
                UpdateCinemaList();
                MessageBox.Show("Список кинотеатров обновлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка кинотеатров: {ex.Message}");
            }
        }

        // Метод для обновления отображения списка кинотеатров в ListBox
        private void UpdateCinemaList()
        {
            listBox1.Items.Clear();
            foreach (var cinema in cinemas)
            {
                listBox1.Items.Add($"{cinema.Name} - {cinema.Address} - {cinema.PhoneNumber}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < cinemas.Count)
            {
                // Получаем выбранный кинотеатр
                Cinema = cinemas[selectedIndex];

                // Заполняем поля формы данными выбранного кинотеатра
                PopulateFields(Cinema);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCinemaName.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtSeatCount.Text) ||
                    cmbDirector.SelectedItem == null || cmbOwner.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                string pattern = @"^\+7\d{10}$";
                if (!Regex.IsMatch(txtPhoneNumber.Text, pattern))
                {
                    MessageBox.Show("Введите корректный номер телефона в формате +7XXXXXXXXXX");
                    txtPhoneNumber.Focus();
                    return;
                }

                string name = txtCinemaName.Text;
                string address = txtAddress.Text;
                string phoneNumber = txtPhoneNumber.Text;
                int seatCount = int.TryParse(txtSeatCount.Text, out seatCount) ? seatCount : 0;

                if (seatCount <= 0)
                {
                    MessageBox.Show("Количество мест должно быть больше 0.");
                    return;
                }

                Person director = cmbDirector.SelectedItem as Person;
                LegalEntity owner = cmbOwner.SelectedItem as LegalEntity;

                if (Cinema != null)
                {
                    // Обновляем существующий кинотеатр
                    Cinema.Name = name;
                    Cinema.Address = address;
                    Cinema.PhoneNumber = phoneNumber;
                    Cinema.SeatCount = seatCount; Cinema.Director = director;
                    Cinema.Owner = owner;
                    MessageBox.Show("Данные кинотеатра обновлены!");
                }
                else
                {
                    // Добавляем новый кинотеатр
                    Cinema = new Cinema(name, address, new BankAccount("Default Bank", "0000"), "000", phoneNumber, seatCount, director, owner);
                    cinemas.Add(Cinema);
                    MessageBox.Show("Кинотеатр добавлен!");
                }

                SaveCinemasToJson(cinemas);
                UpdateCinemaList(); // Обновляем список в ListBox

                // Выбираем обновленный кинотеатр в списке
                int index = cinemas.IndexOf(Cinema);
                if (index >= 0)
                {
                    listBox1.SelectedIndex = index;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
    
