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
    /// Логика взаимодействия для окна авторизации клиента
    /// </summary>
    public partial class AuthorizationClient : Window
    {
        // Создание глобальных переменных
        int countTry;
        public double card;
        Random random = new Random();

        /// <summary>
        /// Инициализация компонентов при запуске окна авторизации клиента
        /// </summary>
        public AuthorizationClient()
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
        /// Кнопка войти для авторизации клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAuthoClient_Click(object sender, RoutedEventArgs e)
        {
            //Создание переменных для работы с данными пользователя
            string login = TextLoginClient.Text;
            string password = TextPasswordClient.Password;

            if (login == App.LoginClient && password == App.PasswordClient) //Если пользователь верно ввёл свои данные
            {
                //Начисление рандомного количества денег
                card = Math.Round(random.NextDouble()*10000.0, 2)+20000;

                //Сообщение о том, что пользователь успешно вошёл в систему
                MessageBox.Show($"Вы успешно зашли как клиент приложения\nНа вашей карте сейчас есть {card} рублей", "Оповещение");

                //Создание окна для оформления заказа
                View.CreateOrderWindow createOrderWindow = new View.CreateOrderWindow(card);

                //Получить число категорий и список названий категорий
                List<Entity.Category> listcat = App.DB.Category.ToList();
                createOrderWindow.ListCataloge.ItemsSource = listcat;
                createOrderWindow.ListCataloge.SelectedIndex = 0;

                //Показать окно для создания заказа
                createOrderWindow.Show();
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
