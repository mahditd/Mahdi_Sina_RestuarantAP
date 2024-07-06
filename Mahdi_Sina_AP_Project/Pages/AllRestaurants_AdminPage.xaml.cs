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
    /// Interaction logic for AllRestaurants_AdminPage.xaml
    /// </summary>
    public partial class AllRestaurants_AdminPage : Page
    {
        public AllRestaurants_AdminPage()
        {
            InitializeComponent();
            var restaurantNames = DataWork.dataBase.Restaurants.Select(x => x.Name).ToList();
            myListBox.ItemsSource = restaurantNames;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Restaurant> restaurants = DataWork.dataBase.Restaurants.ToList();
            if (FilterComboBox.SelectedIndex == 0)
            {
                
                var names = DataWork.dataBase.Restaurants.Where(x => x.Address.Contains(SearchBox.Text)).ToList().Select(x => x.Name);
                myListBox.ItemsSource = names;
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                var names = DataWork.dataBase.Restaurants.Where(x => x.Name.Contains(SearchBox.Text)).Select(x => x.Name).ToList();
                myListBox.ItemsSource = names;
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                var names = DataWork.dataBase.Restaurants.OrderByDescending(x => x.rate).Select(x => x.Name).ToList();
                myListBox.ItemsSource = names;
            }
            else if (FilterComboBox.SelectedIndex == 3)
            {
                var names = DataWork.CurrentAdmin.complaints.Where(x => x.ISCHECKED == false).Select(x => x.RelateRestaurant).ToList();
                myListBox.ItemsSource = names;
                
            }
            else
            {
                MessageBox.Show("Select something on filter box first");
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
