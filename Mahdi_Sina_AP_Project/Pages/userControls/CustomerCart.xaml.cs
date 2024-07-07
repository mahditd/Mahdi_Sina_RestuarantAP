using Sina_Mahdi_RestaurantAP;
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

namespace Mahdi_Sina_AP_Project.Pages.userControls
{
    /// <summary>
    /// Interaction logic for OrderInformations.xaml
    /// </summary>
    public partial class CustomerCart : UserControl
    {
        private double cost;
        Order currentOrder;
        int onlinePay = 0;
        public double Cost
        {
            get { return cost; }
            set { 
                cost = value;
                costNum.Text =cost.ToString();
            }
        }

        public CustomerCart()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            currentOrder = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.payed == 0);
            myListBox.ItemsSource = currentOrder.Foods.Select(food => food.NAME).ToList();
            Cost = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.payed == 0).Foods.Sum(food => food.Price);
            
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (onlinePay == 1)
            {
                if (sendingEmail())
                {
                    List<Order> orders = DataWork.CurrentCustomer.ORDERS;
                    Order order = orders.FirstOrDefault(currentOrder => currentOrder.payed == 0);


                    orders.FirstOrDefault(currentOrder => currentOrder.payed == 0).payed = 1;
                    order.payed = 1;

                    //orders.FirstOrDefault(currentOrder => currentOrder.payed == 0).//change the enum
                    DataWork.CurrentCustomer.ORDERS = orders;
                    DataWork.dataBase.SaveChanges();
                    string restaurant = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.orderDateTime == order.orderDateTime).relatedRestaurant;
                    orders = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant).ORDERLIST;
                    orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).payed = 1;
                    orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).Price = Cost;
                    orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).METHOD = PaymentMethod.Online;
                    DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant).ORDERLIST = orders;
                    DataWork.dataBase.SaveChanges();
                    Restaurant restaurant1 = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant);
                    List<Food> foods = restaurant1.foodList;
                    foreach (Food food in foods)
                    {
                        foreach (Food food1 in order.Foods)
                        {
                            if (food.NAME == food1.NAME)
                            {
                                food.FOODCOUNT--;
                            }
                        }
                    }
                    restaurant1.foodList = foods;
                    DataWork.dataBase.SaveChanges();

                }
            }

            if (onlinePay == 0)
            {
                if (DataWork.CurrentCustomer.ORDERS.FirstOrDefault(currentOrder => currentOrder.payed == 0) == null)
                {
                    MessageBox.Show("no order to pay");
                    return;
                }
                MessageBox.Show("cash accepted");
                List<Order> orders = DataWork.CurrentCustomer.ORDERS;
                Order order = orders.FirstOrDefault(currentOrder => currentOrder.payed == 0);

                orders.FirstOrDefault(currentOrder => currentOrder.payed == 0).payed = 1;
                order.payed = 1;

                //orders.FirstOrDefault(currentOrder => currentOrder.payed == 0).//change the enum
                DataWork.CurrentCustomer.ORDERS = orders;
                DataWork.dataBase.SaveChanges();
                string restaurant = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.orderDateTime == order.orderDateTime).relatedRestaurant;
                orders = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant).ORDERLIST;
                orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).payed = 1;
                orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).Price = Cost;
                orders.FirstOrDefault(currentOrder => currentOrder.orderDateTime == order.orderDateTime).METHOD = PaymentMethod.OnDelivery;
                DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant).ORDERLIST = orders;
                DataWork.dataBase.SaveChanges();
                Restaurant restaurant1 = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurant);
                List<Food> foods = restaurant1.foodList;
                foreach (Food food in foods)
                {
                    foreach (Food food1 in order.Foods)
                    {
                        if (food.NAME == food1.NAME)
                        {
                            food.FOODCOUNT--;
                        }
                    }
                }
                restaurant1.foodList = foods;
                DataWork.dataBase.SaveChanges();

            }
        
        }

        private void online_Click(object sender, RoutedEventArgs e)
        {
            onlinePay = 1;
        }

        private void cash_Click(object sender, RoutedEventArgs e)
        {
            onlinePay = 0;
        }
        private bool sendingEmail()
        {
           string verificationCode = Customer.SendVerificationEmail(DataWork.CurrentCustomer.EMAIL).ToString();
            Customer.EmailConfirmed = false;
            Window verificationWindow = new Confirming_email(verificationCode, this);
            verificationWindow.ShowDialog();
            if (Customer.EmailConfirmed == true)
            {
                MessageBox.Show("payed successfully");
                return true;
            }
            return false;
        }
    }
}
