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
                order.NAME = "first order";

                order.RESTAURANT = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == RestaurantUserName);//never will be null
                List<Order> orders = order.RESTAURANT.ORDERLIST;
                orders.Add(order);
                order.RESTAURANT.ORDERLIST = orders;
                DataWork.dataBase.SaveChanges();
                DataWork.CurrentCustomer.ORDERS = new List<Order> { order };//order must be filled
                page.NavigationToFoodList(RestaurantUserName);

            }


            

        }
    }
}
