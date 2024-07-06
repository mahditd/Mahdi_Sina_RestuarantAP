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

namespace Mahdi_Sina_AP_Project.Pages
{
    /// <summary>
    /// Interaction logic for OrderReserveHistoryPagexaml.xaml
    /// </summary>
    public partial class OrderReserveHistoryPagexaml : Page
    {
        string filePath = "./data.csv";

        public Order ChosenOrder;

        List<Order> OrderList = new List<Order>();
        public OrderReserveHistoryPagexaml()
        {
            InitializeComponent();
            var CommentTexts = DataWork.CurrentRestaurant.ORDERLIST.Select(x => x.NAME);
            OrderList = DataWork.CurrentRestaurant.ORDERLIST;
            myListBox.ItemsSource = CommentTexts;
            myListBox2.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < DataWork.CurrentRestaurant.ORDERLIST.Count(); i++)
            {
                if (DataWork.CurrentRestaurant.ORDERLIST[i].NAME.Contains(myListBox.SelectedItem.ToString()))
                {
                    ChosenOrder = DataWork.CurrentRestaurant.ORDERLIST[i];
                    TextBox1.Text = DataWork.CurrentRestaurant.ORDERLIST[i].METHOD.ToString();
                    TextBox2.Text = DataWork.CurrentRestaurant.ORDERLIST[i].payed.ToString();
                    myListBox2.Visibility = Visibility.Visible;
                    var foodNames = DataWork.CurrentRestaurant.ORDERLIST[i].Foods.Select(x => x.NAME);
                    myListBox2.ItemsSource = foodNames;
                }
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void myListBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if(FilterComboBox.SelectedIndex == 0)
            {
                var OrderNames = DataWork.CurrentRestaurant.ORDERLIST.Where(x => x.relatedCustomer.Contains(SearchBox.Text)).Select(x => x.NAME);
                var Orders = DataWork.CurrentRestaurant.ORDERLIST.Where(x => x.relatedCustomer.Contains(SearchBox.Text));
                myListBox.ItemsSource = OrderNames;
                OrderList = Orders.ToList();
                
            }
            else if(FilterComboBox.SelectedIndex == 1)
            {
                var OrderNames = DataWork.dataBase.Customers.Where(x => x.PHONENUMBER.Contains(SearchBox.Text)).Select(x => x.ORDERS).ToList();

                List<Order> orderTotal = new List<Order>();
                for(int i = 0;i < OrderNames.Count; i++)
                {
                   orderTotal = orderTotal.Concat(OrderNames[i]).ToList();
                }
                List<Order> names = new List<Order>();
                if (orderTotal != null)
                {
                    for (int i = 0; i < orderTotal.Count; i++)
                    {
                        for (int j = 0; j < DataWork.CurrentRestaurant.ORDERLIST.Count; j++)
                        {
                            if (DataWork.CurrentRestaurant.ORDERLIST[j].orderDateTime == orderTotal[i].orderDateTime)
                            {
                                names.Add(orderTotal[j]);
                            }
                        }
                    }
                }
                myListBox.ItemsSource = names.Select(x => x.NAME);
                OrderList = names.ToList();
            }
            else if(FilterComboBox.SelectedIndex == 2)
            {
                var OrderNames = DataWork.CurrentRestaurant.ORDERLIST.OrderBy(x => x.Price).Select(x => x.NAME);
                OrderList = DataWork.CurrentRestaurant.ORDERLIST.OrderBy(x => x.Price).ToList();
                myListBox.ItemsSource = OrderNames;
            }
            else if(FilterComboBox.SelectedIndex == 3)
            {
                var OrderNames = DataWork.CurrentRestaurant.ORDERLIST.OrderByDescending(x => x.Price).Select(x => x.NAME);
                OrderList = DataWork.CurrentRestaurant.ORDERLIST.OrderByDescending(x => x.Price).ToList();
                myListBox.ItemsSource = OrderNames;
            }
            else
            {
                MessageBox.Show("Select something on filter box first");
            }
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            double sale=0;
            int onlineCount = 0;
            int offlineCount = 0;
            double OnlinePercentage;
            int orderCounts = 0;
            List<string> CSVstring = new List<string>();
            CSVstring.Add("Name, Price, Rate, Method, CustomerUsername, OrderTime");
            for (int i = 0; i < OrderList.Count; i++)
            {
                CSVstring.Add(OrderList[i].NAME + ", " + OrderList[i].Price + ", " + OrderList[i].RATE +", " + OrderList[i].METHOD+", " + OrderList[i].relatedCustomer+", " + OrderList[i].orderDateTime.ToString());
                sale += OrderList[i].Price;
                orderCounts++;
                if (OrderList[i].METHOD == PaymentMethod.OnDelivery)
                {
                    offlineCount++;
                }
                else if (OrderList[i].METHOD == PaymentMethod.Online)
                {
                    onlineCount++;
                }
            }
            OnlinePercentage = (onlineCount / (onlineCount + offlineCount)) * 100;
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in CSVstring)
                    {
                        writer.WriteLine(line);
                    }
                    writer.WriteLine("All sale profit : "+sale+ " online payed orders percentage : "+OnlinePercentage+"% order counts : "+orderCounts);
                    MessageBox.Show("CSV file created!");
                }
            }
            catch
            {
                MessageBox.Show("Couldn't make the csv file");
            }

        }
    }
}
