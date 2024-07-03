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

namespace Mahdi_Sina_AP_Project.Pages
{
    /// <summary>
    /// Interaction logic for OrderReserveHistoryPagexaml.xaml
    /// </summary>
    public partial class OrderReserveHistoryPagexaml : Page
    {
        public OrderReserveHistoryPagexaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer customer = new Customer();
            Reserve reserve1 = new Reserve(customer,DataWork.CurrentRestaurant,DateTime.Now);
            Reserve reserve2 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve3 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve4 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve5 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve6 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve7 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve8 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);
            Reserve reserve9 = new Reserve(customer, DataWork.CurrentRestaurant, DateTime.Now);

        }
    }
}
