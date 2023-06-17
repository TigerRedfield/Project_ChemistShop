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
    /// Логика взаимодействия для окна создания заказа
    /// </summary>
    public partial class CreateOrderWindow : Window
    {
        //Глобальные переменные для обработки данных карты
        public double SummaCard;
        public double SummaOrder = 0;

        //Создание окна и классов для работы с товарами
        View.TotalOrderWindow total = new TotalOrderWindow();
        List<Entity.Medicines> listmedicines;
        public List<Classes.ProductsInOrder> listproductsInOrders;

        //Глобальные переменные для работы с товарами
        string MedicineName;
        int MedicineCost;
        int MedicineDiscount;

        /// <summary>
        /// Инициализация компонентов при запуске окна авторизации клиента
        /// </summary>
        /// <param name="SummaCard"></param>
        public CreateOrderWindow(double SummaCard)
        {
            InitializeComponent();
            this.DataContext = this;			//Элементы интерфейса связать с данными
            this.SummaCard = SummaCard;         //Связать полученные данные предыдущего окна с картой      
            tbCard.Text = "Сумма на карте: " + SummaCard;  //Связать данные карты с элементом интерфейса
            listproductsInOrders = new List<Classes.ProductsInOrder>(); //Создание списка товаров в заказе
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
        /// Отображение и выбор товаров определённой категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCataloge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listmedicines = App.DB.Medicines.Where(x => x.CategoryId == (int)ListCataloge.SelectedValue).ToList(); //Свзяь категорий товаров с каталогом 
            listViewProducts.ItemsSource = null;
            if (listmedicines != null) //Отображение товаров, которые не отсутствуют в БД
            {
                listViewProducts.ItemsSource = listmedicines; //Отобразить товары
            }
        }

        /// <summary>
        /// Кнопка для оформления заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalOrder_Click(object sender, RoutedEventArgs e)
        {
            //Отображение сообщения о том, что открывается окно оформления заказа
            //с последующием отображением этого окна
            MessageBox.Show("Сейчас будет открыто окно оформления заказа!", "Внимание!");
            this.Hide();
            total.Owner = this;
            total.ShowDialog();
        }

        /// <summary>
        /// Кнопка для добавления товаров корзину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBucket_Click(object sender, RoutedEventArgs e)
        {
            //Создание классов и объектов для связи товаров с данными БД
            Classes.ProductsInOrder productInOrder = null;
            Entity.Medicines medicines = (sender as Button).DataContext as Entity.Medicines;
            MedicineName = medicines.MedicineName;
            MedicineCost = medicines.MedicineCost;
            MedicineDiscount = medicines.MedicineDiscount;

            if (SummaOrder + MedicineCost <= SummaCard) //Добавление товаров, если на карточке пользователя достаточно денег 
            {
                SummaOrder += MedicineCost; //Прибавление стоимости товаров к общей сумме заказа
                
                //Отображение суммы заказа в текущем окне и в окне оформления заказа 
                total.tb_summOrder.Text = $"Сумма заказа: {SummaOrder}";
                tbordercreate.Text = $"Сумма заказа: {SummaOrder}";

                int index = listproductsInOrders.FindIndex(x => x.MedicineName == MedicineName); //Создание индекса для связи товара с данными БД

                if (index < 0) //Если товар отсутствует в корзине
                {
                    //Создание класса и объектов для добавления товаров в корзину
                    productInOrder = new Classes.ProductsInOrder();
                    productInOrder.MedicineName = MedicineName;
                    productInOrder.MedicineCost = MedicineCost;
                    productInOrder.MedicineDiscount = int.Parse((Math.Round((double)MedicineCost * (1.0 - (double)MedicineDiscount / 100.0), 0)).ToString()); //Вычисление скидки
                    productInOrder.Count = 1;
                    productInOrder.Costing = MedicineCost;

                    //Добавление выбранных товаров в корзину в единственном числе
                    listproductsInOrders.Add(productInOrder);
                }

                else //Если товар присутствует в корзине
                {
                    //Увеличение количества выбраных товаров 
                    listproductsInOrders[index].Count++;
                    listproductsInOrders[index].Costing = listproductsInOrders[index].MedicineCost * listproductsInOrders[index].Count;
                }

            }

            else //Если сумма заказа начинает превышать сумму на карте пользователя 
            {
                //Сообщение о том, что у клиента недостаточно денег на карте
                MessageBox.Show("У Вас недостаточно денег на карте!", "Внимание!");
            }
        }
    }
}
