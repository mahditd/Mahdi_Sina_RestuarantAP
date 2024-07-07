using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for OrderHistory.xaml
    /// </summary>
    public partial class OrderHistory : UserControl
    {
        string orderName;
        CustomerPage CustomerPage;
        public OrderHistory(CustomerPage customerPage)
        {
            InitializeComponent();
            List<string> orders = DataWork.CurrentCustomer.ORDERS.Where(order => order.payed == 1).Select(order => order.NAME).ToList();
            myListBox.ItemsSource = DataWork.CurrentCustomer.ORDERS.Where(order => order.payed == 1).Select(order => order.NAME).ToList();
            CustomerPage = customerPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            commentSpace.Visibility = Visibility.Visible;
            var ClickedOrder = e.OriginalSource as Button;
            orderName = ClickedOrder.Content.ToString();//it will never be null
            commentSpace.Visibility = Visibility.Visible;

        }
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            commentSpace.Visibility = Visibility.Hidden;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rateTxtBox.Text == "" || commentText.txtBox.Text == "" )
            {
                MessageBox.Show("please fill all the fields", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                float rate;
                try
                {
                    rate = float.Parse(rateTxtBox.Text);
                }
                catch 
                {
                    MessageBox.Show("enter a float number in the Rate box", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                Order selectedOrder = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(order => order.NAME == orderName);
                selectedOrder.RATE = rate;
                List<Order> orders = DataWork.CurrentCustomer.ORDERS;

                Comment comment = new Comment(commentText.txtBox.Text, DataWork.CurrentCustomer.USERNAME);
                selectedOrder.Comments.Add(comment);
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].NAME == selectedOrder.NAME)
                    {
                        orders[i] = selectedOrder;
                        break;
                    }

                }
                DataWork.CurrentCustomer.ORDERS = orders;
                orders = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).ORDERLIST;
                
                orders.FirstOrDefault(x => x.orderDateTime == selectedOrder.orderDateTime).Comments.Add(comment);
                orders.FirstOrDefault(x => x.orderDateTime == selectedOrder.orderDateTime).refreshRate(rate);
                List<Food> foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).foodList;
                foreach (Food food in foods)
                {
                    foreach (var food1 in orders.FirstOrDefault(x => x.orderDateTime == selectedOrder.orderDateTime).Foods)
                    {
                        if (food.NAME==food1.NAME)
                        {
                            food.refreshRate(rate);
                        }
                    }
                }
                DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).foodList = foods;
                DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).ORDERLIST = orders;
                DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).refreshRate();

                DataWork.dataBase.SaveChanges();

            }

        }

        private void rateFood_Click(object sender, RoutedEventArgs e)
        {
            CustomerPage.navigateToRateFood(orderName);
        }
    }
}
