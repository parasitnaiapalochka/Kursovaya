using LAB_movies_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_movies.v2_
{
    public partial class SupplierForm : Form
    {
        // Путь к файлу для сохранения данных в JSON
        private string jsonFilePath = "suppliers.json";
        private string selectedSupplierName = null;
        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers(); // Загружаем поставщиков при запуске формы
            listBoxSuppliers.SelectedIndexChanged += new EventHandler(listBoxSuppliers_SelectedIndexChanged);
        }
        private void listBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSuppliers.SelectedIndex != -1)
            {
                // Получаем имя выбранного поставщика
                selectedSupplierName = listBoxSuppliers.SelectedItem.ToString();

                // Загружаем существующих поставщиков
                List<Supplier> suppliers = LoadSuppliersFromJson();

                // Находим выбранного поставщика по имени
                Supplier selectedSupplier = suppliers.Find(s => s.Name == selectedSupplierName);

                if (selectedSupplier != null)
                {
                    // Заполняем текстовые поля данными выбранного поставщика
                    txtName.Text = selectedSupplier.Name;
                    txtAddress.Text = selectedSupplier.Address;
                    txtBankName.Text = selectedSupplier.BankAccount.BankName;
                    txtAccountNumber.Text = selectedSupplier.BankAccount.AccountNumber;
                    txtTaxId.Text = selectedSupplier.TaxId;
                }
            }
            else
            {
                // Если ничего не выбрано, сбрасываем выбранного поставщика и очищаем поля
                selectedSupplierName = null;
                txtName.Clear();
                txtAddress.Clear();
                txtBankName.Clear();
                txtAccountNumber.Clear();
                txtTaxId.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей
                string name = txtName.Text;
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Пожалуйста, введите имя поставщика.");
                    return;
                }

                string address = txtAddress.Text;
                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Пожалуйста, введите адрес поставщика.");
                    return;
                }

                string bankName = txtBankName.Text;
                if (string.IsNullOrWhiteSpace(bankName))
                {
                    MessageBox.Show("Пожалуйста, введите название банка.");
                    return;
                }

                string accountNumber = txtAccountNumber.Text;
                if (string.IsNullOrWhiteSpace(accountNumber))
                {
                    MessageBox.Show("Пожалуйста, введите номер счета.");
                    return;
                }

                string taxId = txtTaxId.Text;
                string pattern = @"^\d{10}$";
                if (!Regex.IsMatch(taxId, pattern))
                {
                    MessageBox.Show("Поле ИНН должно содержать ровно 10 цифр");
                    return;
                }

                // Создание объекта BankAccount для поставщика
                BankAccount bankAccount = new BankAccount(bankName, accountNumber);

                // Загружаем существующих поставщиков
                List<Supplier> suppliers = LoadSuppliersFromJson();

                if (selectedSupplierName != null)
                {
                    // Редактирование существующего поставщика
                    Supplier existingSupplier = suppliers.Find(s => s.Name == selectedSupplierName);
                    if (existingSupplier != null)
                    {
                        // Обновляем данные поставщика
                        existingSupplier.Name = name;
                        existingSupplier.Address = address;
                        existingSupplier.BankAccount = bankAccount;
                        existingSupplier.TaxId = taxId;
                    }
                    else
                    {
                        MessageBox.Show("Поставщик для обновления не найден.");
                return;
            }
        }
        else
        {
            // Создание нового поставщика
            Supplier supplier = new Supplier(name, address, bankAccount, taxId);
            suppliers.Add(supplier);
        }

        // Сохраняем обновленный список в файл
        SaveSuppliersToJson(suppliers);

        // Сбрасываем выбранного поставщика
        selectedSupplierName = null;

        // Очищаем текстовые поля
        txtName.Clear();
        txtAddress.Clear();
        txtBankName.Clear();
        txtAccountNumber.Clear();
        txtTaxId.Clear();

        // Обновляем список поставщиков в ListBox
        LoadSuppliers();
       listBoxSuppliers.ClearSelected();

                // Сообщение об успешном сохранении
                MessageBox.Show("Поставщик успешно сохранен!");
    }
    catch (Exception ex)
    {
        // Логируем ошибку
        MessageBox.Show($"Произошла ошибка: {ex.Message}");
    }
}

        private void SaveSuppliersToJson(List<Supplier> suppliers)
        {
            try
            {
                // Преобразуем список поставщиков в JSON строку
                string json = JsonConvert.SerializeObject(suppliers, Formatting.Indented);

                // Сохраняем JSON строку в файл
                File.WriteAllText(jsonFilePath, json);
            }
            catch (IOException ioEx)
            {
                // Ошибка записи в файл
                MessageBox.Show($"Ошибка при сохранении файла: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                // Общая ошибка
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private List<Supplier> LoadSuppliersFromJson()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    // Чтение JSON строки из файла
                    string json = File.ReadAllText(jsonFilePath);

                    // Преобразование JSON строки обратно в список поставщиков
                    return JsonConvert.DeserializeObject<List<Supplier>>(json);
                }
                else
                {
                    // Если файл не существует, возвращаем пустой список
                    return new List<Supplier>();
                }
            }
            catch (IOException ioEx)
            {
                // Ошибка чтения файла
                MessageBox.Show($"Ошибка при чтении файла: {ioEx.Message}");
                return new List<Supplier>();
            }
            catch (JsonException jsonEx)
            {
                // Ошибка при десериализации JSON
                MessageBox.Show($"Ошибка при обработке данных: {jsonEx.Message}");
                return new List<Supplier>();
            }
            catch (Exception ex)
            {
                // Общая ошибка
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
                return new List<Supplier>();
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                // Загружаем поставщиков из файла и отображаем их в ListBox
                List<Supplier> suppliers = LoadSuppliersFromJson();

                // Очищаем ListBox перед загрузкой новых данных
                listBoxSuppliers.Items.Clear();

                foreach (var supplier in suppliers)
                {
                    listBoxSuppliers.Items.Add(supplier.Name); // Добавляем только имя поставщика в ListBox
                }

                // Сбрасываем выбранный элемент и очищаем поля
                listBoxSuppliers.ClearSelected();
                selectedSupplierName = null;
                txtName.Clear();
                txtAddress.Clear();
                txtBankName.Clear();
                txtAccountNumber.Clear();
                txtTaxId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadSuppliers(); // Загружаем поставщиков заново и отображаем их в ListBox
            MessageBox.Show("Список поставщиков обновлен!");
        }
    }
}
