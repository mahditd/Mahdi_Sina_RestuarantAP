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
    /// Interaction logic for OrderHistory.xaml
    /// </summary>
    public partial class OrderHistory : UserControl
    {
        string orderName;
        public OrderHistory()
        {
            InitializeComponent();
            List<string> orders = DataWork.CurrentCustomer.ORDERS.Where(order => order.payed == 1).Select(order => order.NAME).ToList();
            myListBox.ItemsSource = DataWork.CurrentCustomer.ORDERS.Where(order => order.payed == 1).Select(order => order.NAME).ToList();
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
            Order selectedOrder = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(order => order.NAME == orderName);
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
            DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == selectedOrder.relatedRestaurant).ORDERLIST = orders;
            DataWork.dataBase.SaveChanges();
        }
    }
}
