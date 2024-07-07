using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
            var myBorder = new Border();
            grid.Children.Add(myBorder); // Assuming 'LayoutGrid' is your Grid
            myBorder.SetValue(Grid.ColumnProperty, 1); // Set the column index
            myBorder.BorderBrush = Brushes.Black; // Set the border color
            myBorder.BorderThickness = new Thickness(0, 0, 2, 0); // Set the vertical border thickness


        }

        private void UserProfile_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton3;
            NavigationService.Navigate(ClickedButton.NavUri);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void restaurants_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new userControls.OrderFood(this);

        }
        public void NavigationToFoodList(string UserName)
        {
            contentControl.Content = new userControls.OrderFood_FoodList_(UserName);
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            if (DataWork.CurrentCustomer.ORDERS.Where(x => x.payed == 0).ToList().Count != 0)
            {
                contentControl.Content = new userControls.CustomerCart();

            }
            else
            {
                MessageBox.Show("There is no order to pay");
            }
        }

        private void OrderHistory_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new userControls.OrderHistory(this);

        }

        private void Complaints_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new userControls.ComplaintsPage(this);

        }
        public void naviHistoryComplaint()
        {
            //NavigationService.Navigate(new complaintHistory());
            NavigationService.Navigate(new complaintHistory());

        }


        float oldRate;
        int count;
        public float rateChecker(float newRate)
        {
            oldRate *= count;
            count++;
            oldRate += newRate;
            return (oldRate / count);
        }

        public void navigateToRateFood(string order)
        {
            contentControl.Content = new userControls.RateFoodsOfOrders(order);
        }
        public void navigateToFoodComments()
        {

        }
    }


}
