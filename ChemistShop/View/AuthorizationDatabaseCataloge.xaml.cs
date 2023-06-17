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

namespace ChemistShop.View
{
    /// <summary>
    /// Логика взаимодействия для окна авторизации сотрудника
    /// </summary>
    public partial class AuthorizationDatabaseCataloge : Window
    {
        int countTry;

        /// <summary>
        ///  Инициализация компонентов при запуске окна авторизации сотрудника
        /// </summary>
        public AuthorizationDatabaseCataloge()
        {
            InitializeComponent();
            countTry = 3; //количество попыток входа
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
        /// Кнопка войти для авторизации сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAuthoAdmin_Click(object sender, RoutedEventArgs e)
        {
            //Создание переменных для работы с данными пользователя
            string login = TextLoginAdmin.Text;
            string password = TextPasswordAdmin.Password;

            if (login == App.LoginAdmin && password == App.PasswordAdmin) //Если пользователь верно ввёл свои данные
            {
                //Сообщение о том, что пользователь успешно вошёл в систему
                MessageBox.Show("Вы успешно зашли как сотрудник приложения", "Оповещение");

                //Создание окна для работы с каталогом
                View.DatabaseCatalogeWindow databaseCatalogeWindow = new View.DatabaseCatalogeWindow();

                //Помещение данных БД в DataGrid для отображения и работы с ними
                List<Entity.Category> listcat = App.DB.Category.ToList();
                databaseCatalogeWindow.DataGridCateg.ItemsSource = listcat;
                List<Entity.ManufacturersCountries> manufacturersCountries = App.DB.ManufacturersCountries.ToList();
                databaseCatalogeWindow.DataGridCountries.ItemsSource = manufacturersCountries;
                List<Entity.Manufacturers> manufacturers = App.DB.Manufacturers.ToList();
                databaseCatalogeWindow.DataGridManufacturers.ItemsSource = manufacturers;
                List<Entity.Medicines> medicines = App.DB.Medicines.ToList();
                databaseCatalogeWindow.DataGridMedicines.ItemsSource = medicines;

                //Открытие окна для работы с каталогом
                databaseCatalogeWindow.ShowDialog();
                this.Close(); //Закрытие окна авторизации
            }

            else //Если пользователь неверно ввёл свои данные
            {
                countTry--; //Вычитание одной попытки

                if (countTry == 0) //Если у пользователя не осталось попыток
                {
                    MessageBox.Show("Все попытки исчерпаны", "Внимание!");
                    this.Close();
                }

                else //Если у пользователя остались попытки
                {
                    MessageBox.Show("У вас осталось: " + countTry + " попытки", "Внимание!");
                }

            }
        }
    }
}
