using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ChemistShop
{
    /// <summary>
    /// Логика взаимодйствия с ресурсами App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Данные админа
        public static string LoginAdmin = "AdminChemistShop";
        public static string PasswordAdmin = "Admin123";

        //Данные клиента
        public static string LoginClient = "Client";
        public static string PasswordClient = "Client123"; 

        //Пути к файлам приложения
        public static string pathExe = Environment.CurrentDirectory; //к файлу exe

        //База данных
        public static Entity.DBChemistShop DB;
    }
}
