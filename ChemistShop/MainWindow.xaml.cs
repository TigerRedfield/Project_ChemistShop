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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChemistShop.Entity;
using ChemistShop.View;

namespace ChemistShop
{
    /// <summary>
    /// Логика взаимодействия для главного окна
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Инициализация компонентов при запуске главного окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            App.DB = new Entity.DBChemistShop(); //Создание сервера базы
        }

        /// <summary>
        /// Кнопка выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            //Предупреждение о том, что пользователь выйдет из приложения
            if (MessageBox.Show("Вы точно хотите закрыть приложение?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
               Application.Current.Shutdown(); //Полное закрытие приложения
            }
        }

        /// <summary>
        /// Кнопка для оформления заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBuy_Click(object sender, RoutedEventArgs e)
        {
            //Создание формы для авторизации клиента
            View.AuthorizationClient authorizationClient = new View.AuthorizationClient();
            this.Hide();
            authorizationClient.Show();
            this.Show();
        }

        /// <summary>
        /// Кнопка для работы с каталогом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCataloge_Click(object sender, RoutedEventArgs e)
        {
            //Создание формы для авторизации сотрудника
            View.AuthorizationDatabaseCataloge authorizationDatabaseCataloge = new View.AuthorizationDatabaseCataloge();
            this.Hide();
            authorizationDatabaseCataloge.Show();
            this.Show();
        }
    }
}
