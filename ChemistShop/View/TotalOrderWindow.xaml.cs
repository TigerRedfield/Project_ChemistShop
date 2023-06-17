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
using System.Diagnostics;
using System.IO;

namespace ChemistShop.View
{
    /// <summary>
    /// Логика взаимодействия для окна оформление заказа
    /// </summary>
    public partial class TotalOrderWindow : Window
    {
        //Глобальные переменные для работы с товарами
        public double lastSumOrder;
        private int count = 0;

        /// <summary>
        /// Инициализация компонентов для окна оформления заказа
        /// </summary>
        public TotalOrderWindow()
        {
            InitializeComponent();
            this.DataContext = this; //Элементы интерфейса связать с данными
        }

        /// <summary>
        /// Метод для обработки передачи данных о товарах в DataGrid, 
        /// суммы заказа и оставшихся средств с карты
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            lastSumOrder = (this.Owner as CreateOrderWindow).SummaCard - (this.Owner as CreateOrderWindow).SummaOrder;
            tbOrderLast.Text = "Остаток от заказа: " + lastSumOrder.ToString();
            dgOrder.ItemsSource = (this.Owner as CreateOrderWindow).listproductsInOrders;
        }

        /// <summary>
        /// Разделяемое событие кнопки с тремя функциями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_three_function_click(Object sender, RoutedEventArgs e)
        {
            //Создание метода для логики взаимодействия кнопок действий с товарами в DataGrid
            Button button = sender as Button;
            Classes.ProductsInOrder productsInOrder = button.DataContext as Classes.ProductsInOrder;

            //Оператор ветвления связанный с кнопками
            switch (button.Content)
            {
                //Функция увеличить количество добавленого товара
                case "+":
                    if (productsInOrder.MedicineCost + (this.Owner as CreateOrderWindow).SummaOrder <= (this.Owner as CreateOrderWindow).SummaCard) //Увеличение количества товара, если на карточке пользователя достаточно денег 
                    {
                        productsInOrder.Count++;
                        productsInOrder.Costing += productsInOrder.MedicineCost;
                        lastSumOrder -= productsInOrder.MedicineCost;
                        (this.Owner as CreateOrderWindow).SummaOrder += productsInOrder.MedicineCost;
                    }

                    else if (lastSumOrder >= 0) //Если сумма заказа начинает превышать сумму на карте пользователя 
                    {
                        MessageBox.Show("У Вас недостаточно денег на карте", "Внимание!");
                    }
                    break;

                //Функция уменшить количество добавленого товара
                case "-":
                    if (productsInOrder.Count >= 1) //Если количество товаров больше или равно 1
                    {
                        productsInOrder.Count--;
                        productsInOrder.Costing -= productsInOrder.MedicineCost;
                        lastSumOrder += productsInOrder.MedicineCost;
                        (this.Owner as CreateOrderWindow).SummaOrder -= productsInOrder.MedicineCost;
                    }

                    else //Если количество добавленого товара не осталось
                    {
                        button.Content = "x";
                        button_three_function_click(button, null);
                    }
                    break;

                //Функция удалить добавленный товар
                case "x":
                    (this.Owner as CreateOrderWindow).listproductsInOrders.Remove(productsInOrder);
                    lastSumOrder += productsInOrder.Costing;
                    (this.Owner as CreateOrderWindow).SummaOrder -= productsInOrder.Costing;
                    break;
            }

            dgOrder.Items.Refresh(); //Обновить DataGrid после добавления/удаления товаров

            //Связать сумму карты с текущем окном и с окном создания заказа
            tbOrderLast.Text = "Остаток от заказа: " + lastSumOrder.ToString();
            tb_summOrder.Text = "Сумма заказа: " + (this.Owner as CreateOrderWindow).SummaOrder;
        }

        /// <summary>
        /// Кнопка для возвращения на окно создания заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cataloge_Click(object sender, RoutedEventArgs e)
        {
            //Предупреждение о том, что пользователь вернётся в окно создания заказа
            if (MessageBox.Show("Вы точно хотите вернуться на окно создания заказа?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //Создание окна для оформления заказа с возвращением суммы на карту
                View.CreateOrderWindow createOrderWindow = new CreateOrderWindow(lastSumOrder + (this.Owner as CreateOrderWindow).SummaOrder);
                
                //Получить число категорий и список названий категорий                                                                                                                         
                List<Entity.Category> listcat = App.DB.Category.ToList(); 
                createOrderWindow.ListCataloge.ItemsSource = listcat;
                createOrderWindow.ListCataloge.SelectedIndex = 0;

                this.Hide(); //Скрыть окно
                createOrderWindow.ShowDialog(); //Показать модальное дополнительное
            } 
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
        /// Кнопка для оформления заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            count++; //Увеличение счётчика

            //Сообщение о том, что заказ успешно оформлен
            MessageBox.Show($"Поздравляем. Вы успешно оформили заказ!\nЧек талона № {count} находится в текстовом файле в папке с приложением", "Оповещение");

         
            string file = "Чек №" + count + ".txt"; //Каждый чек будет со своим номером названии

            //Процедура создания чека
            FileInfo newFile = new FileInfo(file);

            if (newFile.Exists) //Если существует
            {
                newFile.Delete(); //Удалить
                newFile = new FileInfo(file); //Перезаписать
            }

            //Процедура записи в чек
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine($"Чек талона № {count}\n");
                for (int row = 2; row <= (this.Owner as CreateOrderWindow).listproductsInOrders.Count + 1; row++)
                {
                    sw.WriteLine((this.Owner as CreateOrderWindow).listproductsInOrders[row - 2].MedicineName.ToString() + "\n" 
                                     + (this.Owner as CreateOrderWindow).listproductsInOrders[row - 2].Count.ToString() + "*" 
                                     + (this.Owner as CreateOrderWindow).listproductsInOrders[row - 2].MedicineCost.ToString() +  "=" 
                                     + (this.Owner as CreateOrderWindow).listproductsInOrders[row - 2].Costing.ToString() + " рублей");
                }
                sw.WriteLine("\nИтог=" + (this.Owner as CreateOrderWindow).SummaOrder.ToString() + " рублей");
            }

            this.Close(); //Закрытие окна
        }
    }
}
