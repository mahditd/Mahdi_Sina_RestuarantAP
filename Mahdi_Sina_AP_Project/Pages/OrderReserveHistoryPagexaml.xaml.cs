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
        public Order ChosenOrder;
        public OrderReserveHistoryPagexaml()
        {
            InitializeComponent();
            var CommentTexts = DataWork.CurrentRestaurant.ORDERLIST.Select(x => x.NAME);
            myListBox.ItemsSource = CommentTexts;
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
                }
            }
        }
    }
}
