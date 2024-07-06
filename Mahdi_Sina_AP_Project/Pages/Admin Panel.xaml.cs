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
    /// Interaction logic for Admin_Panel.xaml
    /// </summary>
    public partial class Admin_Panel : Page
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }


        private void Adding_Restaurant_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddRestaurant());
        }

        private void All_Restaurants_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllRestaurants_AdminPage());
        }

        private void Complaints_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComplaintAdminPage());

        }


    }
}
