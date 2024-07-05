using Microsoft.Extensions.Logging;
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
    /// Interaction logic for OrderFood.xaml
    /// </summary>
    public partial class OrderFood : UserControl
    {
        CustomerPage page;
        public OrderFood(CustomerPage _page)
        {
            InitializeComponent();
            List<string> restaurants = DataWork.dataBase.Restaurants.Select(x => x.USERNAME).ToList();
            myListBox.ItemsSource = restaurants;
            page = _page;
            comboBoxFilter.ItemsSource = new List<string> { "City Name", "Restaurant Name", "Serving Type", "Rating"};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (DataWork.CurrentCustomer.ORDERS.Where(x => x.payed == 0).ToList().Count >0)
            {
                MessageBox.Show("complete your last orders first");
            }
            else
            {
                var ClickedButton = e.OriginalSource as Button;
                string RestaurantUserName = ClickedButton.Content.ToString();
                Order order = new Order();

                Restaurant RESTAURANT = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == RestaurantUserName);//never will be null
                List<Order> orders = RESTAURANT.ORDERLIST;
                int x = orders.Count();
                order.NAME = $"order {x}";
                order.relatedRestaurant = RESTAURANT.USERNAME;
                order.relatedCustomer = DataWork.CurrentCustomer.USERNAME;
                //order.RESTAURANT = RESTAURANT;
                orders.Add(order);
                RESTAURANT.ORDERLIST = orders;
                DataWork.dataBase.SaveChanges();
                List<Order> cusOrders = DataWork.CurrentCustomer.ORDERS;
                int y = cusOrders.Count();
                order.NAME = $"order {y}";
                cusOrders.Add(order);
                DataWork.CurrentCustomer.ORDERS = cusOrders;             
                DataWork.dataBase.SaveChanges();
                //DataWork.CurrentCustomer.ORDERS = new List<Order> { order };//order must be filled
                page.NavigationToFoodList(RestaurantUserName);

            }


            

        }
        string filter;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as Button;
            txtBoxContent.Visibility = Visibility.Visible;
            filter = ClickedButton.Content.ToString();
            new List<string> { "City Name", "Restaurant Name", "Serving Type", "Rating" };
            if (filter == "City Name")
            {
                txtBoxContent.Visibility = Visibility.Visible;
                List<string> restaurants = DataWork.dataBase.Restaurants.Where(x => x.Address.Contains(txtBoxContent.Text)).Select(x => x.USERNAME).ToList();
                myListBox.ItemsSource = restaurants;
            }
            else if (filter == "Restaurant Name")
            {
                txtBoxContent.Visibility = Visibility.Visible;
                List<string> restaurants = DataWork.dataBase.Restaurants.Where(x => x.Name.Contains(txtBoxContent.Text)).Select(x => x.USERNAME).ToList();
                myListBox.ItemsSource = restaurants;
            }
            else if (filter == "Serving Type")
            {
                //not implemented
            }
            else if (filter == "Rating")
            {
                List<string> restaurants = DataWork.dataBase.Restaurants.OrderBy(x =>x.rate).Select(x => x.USERNAME).ToList();
                myListBox.ItemsSource = restaurants;
                txtBoxContent.Visibility = Visibility.Hidden;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtBoxContent.Visibility = Visibility.Hidden;
        }

        private void txtBoxContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (filter == "City Name")
            {
                List<string> restaurants = DataWork.dataBase.Restaurants.Where(x => x.Address.Contains(txtBoxContent.Text)).Select(x => x.USERNAME).ToList();
                myListBox.ItemsSource = restaurants;
            }
            else if (filter == "Restaurant Name")
            {
                List<string> restaurants = DataWork.dataBase.Restaurants.Where(x => x.Name.Contains(txtBoxContent.Text)).Select(x => x.USERNAME).ToList();
                myListBox.ItemsSource = restaurants;
            }
            else if (filter == "Serving Type")
            {
                //not implemented
            }

        }
    }
}
