using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChemistShop.Entity;
using System.Data.Entity;

namespace ChemistShop.View
{
    /// <summary>
    /// Логика взаимодействия для окна работы с каталогом
    /// </summary>
    public partial class DatabaseCatalogeWindow : Window
    {
        /// <summary>
        /// Создание классов для работы с даннными БД
        /// </summary>
        Entity.Category category = new Entity.Category();
        Entity.ManufacturersCountries countries = new ManufacturersCountries();
        Entity.Manufacturers manufacturers = new Manufacturers();
        Entity.Medicines Medicines = new Medicines();

        /// <summary>
        /// Инициализация компонентов для окна работы с каталогом
        /// </summary>
        public DatabaseCatalogeWindow()
        {
            InitializeComponent();
            this.DataContext = this; //Элементы интерфейса связать с данными
        }

        /// <summary>
        /// Очистка полей для ввода категорий
        /// </summary>
        void ClearCategory()
        {
            txtCatId.Text = "";
            txtCatName.Text = "";
        }

        /// <summary>
        /// Очистка полей для ввода стран
        /// </summary>
        void ClearCountry()
        {
            txtCountryId.Text = "";
            txtCountryName.Text = "";
        }

        /// <summary>
        /// Очистка полей для ввода производителей
        /// </summary>
        void ClearManuf()
        {
            txtManufacturerId.Text = "";
            txtManufacturerCountryId.Text = "";
            txtManufacturerName.Text = "";
        }

        /// <summary>
        /// Очистка полей для ввода лечебных препаратов/средств
        /// </summary>
        void ClearMedicine()
        {
            txtMedicineId.Text = "";
            txtMedicineManufacturId.Text = "";
            txtMedicineCategoryId.Text = "";
            txtMedicineName.Text = "";
            txtMedicineCost.Text = "";
            txtMedicineDiscount.Text = "";
            txtMedicineRank.Text = "";
            txtMedicineDateManuf.Text = "";
            txtMedicineDateExp.Text = "";
        }

        /// <summary>
        /// Кнопка возвращения в главное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            //Предупреждение о том, что пользователь вернётся в главное меню
            if (MessageBox.Show("Вы точно хотите вернуться на главное меню?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close(); //Закрытие окна
            }
        }

        /// <summary>
        /// Кнопка для добавления категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptCateg_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(txtCatId.Text);
            string newNameCat = txtCatName.Text;

            var index = App.DB.Category.Where(x => x.CategoryId == ID).Select(x => x.CategoryId).FirstOrDefault();
            var indexName = App.DB.Category.Where(x => x.CategoryName == newNameCat).Select(x => x.CategoryName).FirstOrDefault();
            
            if (indexName != null && newNameCat == indexName)
            {
                MessageBox.Show("Категория с таким названием уже есть!", "Внимание!");
                return;
            }

            if (ID == index)
            {
                MessageBox.Show("Такой код категории уже есть!", "Внимание!");
                return;
            }

            else
            {
                category.CategoryId = int.Parse(txtCatId.Text);
                category.CategoryName = txtCatName.Text.Trim();

                App.DB.Category.Add(category);
                App.DB.SaveChanges();
                DataGridCateg.ItemsSource = App.DB.Category.ToList();
            }

            ClearCategory();       
        }

        /// <summary>
        /// Кнопка для редактирования категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCateg_Click(object sender, RoutedEventArgs e)
        {

            if (txtCatId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для редактирования!", "Внимание!");
                return;
            }

            else
            {
                int ID = int.Parse(txtCatId.Text);

                var item = App.DB.Category.SingleOrDefault(x => x.CategoryId == ID);

                if (item != null)
                {
                    category.CategoryName = txtCatName.Text.Trim();
                    App.DB.Entry(item).State = EntityState.Modified;
                    App.DB.SaveChanges();
                    DataGridCateg.ItemsSource = App.DB.Category.ToList();
                }

                DataGridCateg.UnselectAllCells();
                ClearCategory();
            }
         }

        /// <summary>
        /// Кнопка для удаления категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCateg_Click(object sender, RoutedEventArgs e)
        {
            if (txtCatId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Внимание!");
                return;
            }

            else if (MessageBox.Show("Вы точно хотите удалить категорию из каталога?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ID = int.Parse(txtCatId.Text);

                var item = App.DB.Category.SingleOrDefault(x => x.CategoryId == ID);

                if (item != null)
                {
                    App.DB.Category.Remove(item);
                    App.DB.SaveChanges();
                    DataGridCateg.ItemsSource = App.DB.Category.ToList();
                }
                
                DataGridCateg.UnselectAllCells();
                ClearCategory();
            }
        }

        /// <summary>
        /// Кнопка для отмены выделенной категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCateg_Click(object sender, RoutedEventArgs e)
        {
            DataGridCateg.UnselectAllCells();
            return;
        }

        /// <summary>
        /// Кнопка для добавления стран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptCountries_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(txtCountryId.Text);
            string newNameCountry = txtCountryName.Text;

            var index = App.DB.ManufacturersCountries.Where(x => x.ManufacturerCountryId == ID).Select(x => x.ManufacturerCountryId).FirstOrDefault();
            var indexName = App.DB.ManufacturersCountries.Where(x => x.ManufacturerCountryName == newNameCountry).Select(x => x.ManufacturerCountryName).FirstOrDefault();

            if (indexName != null && newNameCountry == indexName)
            {
                MessageBox.Show("Страна с таким названием уже есть", "Внимание!");
                return;
            }

            if (ID == index)
            {
                MessageBox.Show("Такой код страны уже есть!", "Внимание!");
                return;
            }

            else
            {
                countries.ManufacturerCountryId = int.Parse(txtCountryId.Text);
                countries.ManufacturerCountryName = txtCountryName.Text.Trim();
                App.DB.ManufacturersCountries.Add(countries);
                App.DB.SaveChanges();
                DataGridCountries.ItemsSource = App.DB.ManufacturersCountries.ToList();
            }

            ClearCountry();
        }

        /// <summary>
        /// Кнопка для редактирования стран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCountries_Click(object sender, RoutedEventArgs e)
        {
            if (txtCountryId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для редактирования!", "Внимание!");
                return;
            }

            else
            {
                int ID = int.Parse(txtCountryId.Text);
                var item = App.DB.ManufacturersCountries.SingleOrDefault(x => x.ManufacturerCountryId == ID);

                if (item != null)
                {
                    countries.ManufacturerCountryName = txtCountryName.Text.Trim();
                    App.DB.Entry(item).State = EntityState.Modified;
                    App.DB.SaveChanges();
                    DataGridCountries.ItemsSource = App.DB.ManufacturersCountries.ToList();
                }

                DataGridCountries.UnselectAllCells();
                ClearCountry();
            }
        }

        /// <summary>
        /// Кнопка для удаления стран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCountries_Click(object sender, RoutedEventArgs e)
        {
            if (txtCountryId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Внимание!");
                return;
            }

            else if (MessageBox.Show("Вы точно хотите удалить страну из каталога?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                int ID = int.Parse(txtCountryId.Text);

                var item = App.DB.ManufacturersCountries.SingleOrDefault(x => x.ManufacturerCountryId == ID);

                if (item != null)
                {
                    App.DB.ManufacturersCountries.Remove(item);
                    App.DB.SaveChanges();
                    DataGridCountries.ItemsSource = App.DB.ManufacturersCountries.ToList();
                }

                DataGridCountries.UnselectAllCells();
                ClearCountry();
            }
        }

        /// <summary>
        /// Кнопка для отмены выделенной страны
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCountries_Click(object sender, RoutedEventArgs e)
        {
            DataGridCountries.UnselectAllCells();
            return;
        }

        /// <summary>
        /// Кнопка для добавления производителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptManuf_Click(object sender, RoutedEventArgs e)
        {
            int ManufID = int.Parse(txtManufacturerId.Text);
            int CountryId = int.Parse(txtManufacturerCountryId.Text);
            string newNameManuf = txtManufacturerName.Text;

            var indexManuf = App.DB.Manufacturers.Where(x => x.MedicineManufacturerId == ManufID).Select(x => x.MedicineManufacturerId).FirstOrDefault();
            var indexCountryId = App.DB.ManufacturersCountries.Where(x => x.ManufacturerCountryId == CountryId).Select(x => x.ManufacturerCountryId).FirstOrDefault();
            var indexName = App.DB.Manufacturers.Where(x => x.ManufacturerName == newNameManuf).Select(x => x.ManufacturerName).FirstOrDefault();

            if (indexName != null && newNameManuf == indexName)
            {
                MessageBox.Show("Производитель с таким названием уже есть!", "Внимание!");
                return;
            }

            if (ManufID == indexManuf)
            {
                MessageBox.Show("Такой код производителя уже есть!", "Внимание!");
                return;
            }

            else if (CountryId != indexCountryId)
            {
                MessageBox.Show("Такого кода страны не существует!", "Внимание!");
                return;
            }

            else
            {
                manufacturers.MedicineManufacturerId = int.Parse(txtManufacturerId.Text);
                manufacturers.ManufacturerCountryId = int.Parse(txtManufacturerCountryId.Text);
                manufacturers.ManufacturerName = txtManufacturerName.Text.Trim();

                App.DB.Manufacturers.Add(manufacturers);
                App.DB.SaveChanges();
                DataGridManufacturers.ItemsSource = App.DB.Manufacturers.ToList();
            }

            ClearManuf();
        }

        /// <summary>
        /// Кнопка для редактирования производителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditManuf_Click(object sender, RoutedEventArgs e)
        {
            if (txtManufacturerId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для редактирования!", "Внимание!");
                return;
            }

            else
            {
                int ManufID = int.Parse(txtManufacturerId.Text);
                int CountryId = int.Parse(txtManufacturerCountryId.Text);

                var indexCountryId = App.DB.ManufacturersCountries.Where(x => x.ManufacturerCountryId == CountryId).Select(x => x.ManufacturerCountryId).FirstOrDefault();
                var item = App.DB.Manufacturers.SingleOrDefault(x => x.MedicineManufacturerId == ManufID);

                if (item != null)
                {
                    if (indexCountryId != CountryId)
                    {
                        MessageBox.Show("Такого кода страны не существует!", "Внимание!");
                        return;
                    }

                    else
                    {
                        manufacturers.ManufacturerCountryId = int.Parse(txtManufacturerCountryId.Text);
                        manufacturers.ManufacturerName = txtManufacturerName.Text.Trim();
                        
                        App.DB.Entry(item).State = EntityState.Modified;
                        App.DB.SaveChanges();
                        DataGridManufacturers.ItemsSource = App.DB.Manufacturers.ToList();
                    }
                }

                DataGridManufacturers.UnselectAllCells();
                ClearManuf();
            }
        }

        /// <summary>
        /// Кнопка для удаления производителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteManuf_Click(object sender, RoutedEventArgs e)
        {
            if (txtManufacturerId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Внимание!");
                return;
            }

            else if (MessageBox.Show("Вы точно хотите удалить производителя из каталога?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ID = int.Parse(txtManufacturerId.Text);

                var item = App.DB.Manufacturers.SingleOrDefault(x => x.MedicineManufacturerId == ID);

                if (item != null)
                {
                    App.DB.Manufacturers.Remove(item);
                    App.DB.SaveChanges();
                    DataGridManufacturers.ItemsSource = App.DB.Manufacturers.ToList();
                }

                DataGridManufacturers.UnselectAllCells();
                ClearManuf();
            }
        }

        /// <summary>
        /// Кнопка для отмены выделенного производителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelManuf_Click(object sender, RoutedEventArgs e)
        {
            DataGridManufacturers.UnselectAllCells();
            return;
        }

        /// <summary>
        /// Кнопка для добавления лечебных препаратов/средств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptMedicine_Click(object sender, RoutedEventArgs e)
        {
            int ManufId = int.Parse(txtMedicineManufacturId.Text);
            int CategId = int.Parse(txtMedicineCategoryId.Text);
            string newNameMedicine = txtMedicineName.Text;
            double txtranks = double.Parse(txtMedicineRank.Text.ToString().Replace(".", ","));

            var indexManuf = App.DB.Manufacturers.Where(x => x.MedicineManufacturerId == ManufId).Select(x => x.MedicineManufacturerId).FirstOrDefault();
            var indexCateg = App.DB.Category.Where(x => x.CategoryId == CategId).Select(x => x.CategoryId).FirstOrDefault();
            var indexName = App.DB.Medicines.Where(x => x.MedicineName == newNameMedicine).Select(x => x.MedicineName).FirstOrDefault();

            if (indexName != null && newNameMedicine == indexName)
            {
                MessageBox.Show("Производитель с таким названием уже есть", "Внимание!");
                return;
            }

            if (ManufId != indexManuf)
            {
                MessageBox.Show("Такого кода производителя не существует!", "Внимание!");
                return;
            }

            else if(CategId != indexCateg)
            {
                MessageBox.Show("Такого кода категории не существует!", "Внимание!");
                return;
            }

            else if (1 > txtranks || txtranks > 5)
            {
                MessageBox.Show("Рейтинг должен быть больше или равно одному 1 и меньше или равно 5!", "Внимание!");
                return;
            }

            else
            {
                Medicines.MedicineManufacturerId = int.Parse(txtMedicineManufacturId.Text);
                Medicines.CategoryId = int.Parse(txtMedicineCategoryId.Text);
                Medicines.MedicineName = txtMedicineName.Text.Trim();
                Medicines.MedicineCost = int.Parse(txtMedicineCost.Text);
                Medicines.MedicineDiscount = int.Parse(txtMedicineDiscount.Text);
                Medicines.MedicineRank = double.Parse(txtMedicineRank.Text.ToString().Replace(".", ","));
                Medicines.MedicineDateManufacturing = DateTime.Parse(txtMedicineDateManuf.Text);
                Medicines.MedicineExpirationDate = int.Parse(txtMedicineDateExp.Text);

                App.DB.Medicines.Add(Medicines);
                App.DB.SaveChanges();
                DataGridMedicines.ItemsSource = App.DB.Medicines.ToList();
            }

            ClearMedicine();
        }

        /// <summary>
        /// Кнопка для редактирования лечебных препаратов/средств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMedicine_Click(object sender, RoutedEventArgs e)
        {
            if (txtMedicineId.Text == "")
            {
               MessageBox.Show("Не выбрана строка для редактирования!", "Внимание!");
               return;
            }

            else
            {
                int MedicineID = int.Parse(txtMedicineId.Text);
                int ManufId = int.Parse(txtMedicineManufacturId.Text);
                int CategId = int.Parse(txtMedicineCategoryId.Text);
                double txtranks = double.Parse(txtMedicineRank.Text.ToString().Replace(".", ","));

                var indexCategId = App.DB.Category.Where(x => x.CategoryId == CategId).Select(x => x.CategoryId).FirstOrDefault();
                var indexManufId = App.DB.Manufacturers.Where(x => x.MedicineManufacturerId == ManufId).Select(x => x.MedicineManufacturerId).FirstOrDefault();
                var item = App.DB.Medicines.SingleOrDefault(x => x.MedicineId == MedicineID);

                if (item != null)
                {
                    if (indexManufId != ManufId)
                    {
                        MessageBox.Show("Такого кода производителя не существует!", "Внимание!");
                        return;
                    }
                    else if(indexCategId != CategId)
                    {
                        MessageBox.Show("Такого кода категории не существует!", "Внимание!");
                        return;
                    }
                    else if(1 > txtranks || txtranks > 5)
                    {
                        MessageBox.Show("Рейтинг должен быть больше или равно одному 1 и меньше или равно 5!", "Внимание!");
                        return;
                    }
                    else
                    {
                        Medicines.MedicineManufacturerId = int.Parse(txtMedicineManufacturId.Text);
                        Medicines.CategoryId = int.Parse(txtMedicineCategoryId.Text);
                        Medicines.MedicineName = txtMedicineName.Text.Trim();
                        Medicines.MedicineCost = int.Parse(txtMedicineCost.Text);
                        Medicines.MedicineDiscount = int.Parse(txtMedicineDiscount.Text);
                        Medicines.MedicineRank = double.Parse(txtMedicineRank.Text.ToString().Replace(".", ","));
                        Medicines.MedicineDateManufacturing = DateTime.Parse(txtMedicineDateManuf.Text);
                        Medicines.MedicineExpirationDate = int.Parse(txtMedicineDateExp.Text);   

                        App.DB.Entry(item).State = EntityState.Modified;
                        App.DB.SaveChanges();
                        DataGridMedicines.ItemsSource = App.DB.Medicines.ToList();
                    }
                }

                DataGridMedicines.UnselectAllCells();
                ClearMedicine();
            }
        }

        /// <summary>
        /// Кнопка для удаления лечебных препаратов/средств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMedicine_Click(object sender, RoutedEventArgs e)
        {
            if (txtMedicineId.Text == "")
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Внимание!");
                return;
            }

            else if (MessageBox.Show("Вы точно хотите удалить лекарство из каталога?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ID = int.Parse(txtMedicineId.Text);

                var item = App.DB.Medicines.SingleOrDefault(x => x.MedicineId == ID);

                if (item != null)
                {
                    App.DB.Medicines.Remove(item);
                    App.DB.SaveChanges();
                    DataGridMedicines.ItemsSource = App.DB.Medicines.ToList();
                }

                DataGridMedicines.UnselectAllCells();
                ClearMedicine();
            }

        }

        /// <summary>
        /// Кнопка для отмены выделенного лечебного препарата/средства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelMedicine_Click(object sender, RoutedEventArgs e)
        {
            DataGridMedicines.UnselectAllCells();
            return;
        }

        /// <summary>
        /// Кнопка для справочной информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButInfo_Click(object sender, RoutedEventArgs e)
        {
            //Вызов справки
            MessageBox.Show("Навигация по кнопкам:\n✔ - добавить запись\n✎ - редактировать запись\n✖ - удалить запись\n🛇 - убрать выделение на записи\n" +
                "Все данные, кроме кода лекарства, вводятся вручную!", "Справка");
            return;
        }

    }
}

