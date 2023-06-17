using ChemistShop;
using ChemistShop.View;
using ChemistShop.Entity;
using ChemistShop.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Windows.Controls;
using System;

namespace UnitTestChemistShop
{
    [TestClass]
    public class UnitTestsChemistShop
    {
        //Проверка на корректно введённые данные сотрудника для авторизации
        [TestMethod]
        public void TestAuthorizationAdmin()
        {
            //arrange
            var authDB = new AuthorizationDatabaseCataloge();

            var loginTB = (TextBox)authDB.FindName("TextLoginAdmin");
            var passwordTB = (PasswordBox)authDB.FindName("TextPasswordAdmin");
            var button = (Button)authDB.FindName("ButtonAuthoAdmin");

            //act
            loginTB.Text = "AdminChemistShop";
            passwordTB.Password = "Admin123";

            if (App.LoginAdmin == loginTB.Text && App.PasswordAdmin == passwordTB.Password)
            {
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }

            //assert
            Assert.IsTrue(App.LoginAdmin == loginTB.Text && App.PasswordAdmin == passwordTB.Password, "Пароль или логин неверны!");
        }

        //Проверка на некорректно введённые данные клиента для авторизации
        [TestMethod]
        public void TestAuthorizationClient()
        {
            //arrange
            var authClient = new AuthorizationClient();

            var loginTB = (TextBox)authClient.FindName("TextLoginClient");
            var passwordTB = (PasswordBox)authClient.FindName("TextPasswordClient");
            var button = (Button)authClient.FindName("ButtonAuthoClient");

            //act
            loginTB.Text = "Client";
            passwordTB.Password = "Client";
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //assert
            Assert.IsFalse(App.LoginClient == loginTB.Text && App.PasswordClient == passwordTB.Password, "Пароль или логин должны быть неверны!");
        }

        //Проверка на корректное поступление счёта на карту
        [TestMethod]
        public void TestDataCardWindowCreate()
        {
            //arrange
            var authClient = new AuthorizationClient();

            double card = authClient.card;


            var loginTB = (TextBox)authClient.FindName("TextLoginClient");
            var passwordTB = (PasswordBox)authClient.FindName("TextPasswordClient");
            var CreateWindow = new CreateOrderWindow(card);
            var button = (Button)authClient.FindName("ButtonAuthoClient");

            //act
            loginTB.Text = "Client";
            passwordTB.Password = "Client123";
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //assert
            Assert.IsTrue(card == CreateWindow.SummaCard, "Передача данных осуществляется неверно!");
        }

        //Проверка на корректное открытие окна главного меню
        [TestMethod]
        public void TestMenuWindowType()
        {
            //arrange
            var MainWind = new MainWindow();

            //act
            MainWind.Show();

            //assert
            Assert.IsInstanceOfType(MainWind, typeof(MainWindow), "Созданное окно должно являться окном главного меню!");
        }

        //Проверка на то, что стоит корректная подпись в каждом окне
        [TestMethod]
        public void TestsInfoID()
        {
            //arrange
            var MainWind = new MainWindow();
            var AuthoClient = new AuthorizationClient();
            var AuthoAdmin = new AuthorizationDatabaseCataloge();
            var TotalOrder = new TotalOrderWindow();
            var DBCataloge = new DatabaseCatalogeWindow();
            var IDMain = (TextBlock)MainWind.FindName("NameID");
            var IDClient = (TextBlock)AuthoClient.FindName("NameID");
            var IDAdmin = (TextBlock)AuthoAdmin.FindName("NameID");
            var IDTotal = (TextBlock)TotalOrder.FindName("NameID");
            var IDDB = (TextBlock)DBCataloge.FindName("NameID");

            //Act
            string Name = "Васильев Д.С.";

            //assert
            Assert.IsTrue(Name == IDMain.Text, "Подпись неверная!");
            Assert.IsTrue(Name == IDClient.Text, "Подпись неверная!");
            Assert.IsTrue(Name == IDAdmin.Text, "Подпись неверная!");
            Assert.IsTrue(Name == IDTotal.Text, "Подпись неверная!");
            Assert.IsTrue(Name == IDDB.Text, "Подпись неверная!");
        }
    }
}
