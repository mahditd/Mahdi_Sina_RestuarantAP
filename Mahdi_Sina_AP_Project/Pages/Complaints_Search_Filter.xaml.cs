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
    /// Interaction logic for Complaints_Search_Filter.xaml
    /// </summary>
    public partial class Complaints_Search_Filter : Page
    {
        public Complaints_Search_Filter()
        {
            InitializeComponent();
            var complaintNames = DataWork.CurrentAdmin.complaints.Select(x => x.text).ToList();
            myListBox.ItemsSource = complaintNames;
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FilterComboBox.SelectedIndex == 0)
                {
                    var names = DataWork.CurrentAdmin.complaints.Where(x => x.RELATEDCUSTOMER.USERNAME.Contains(SearchBox.Text)).ToList().Select(x => x.text);
                    myListBox.ItemsSource = names;
                }
                else if (FilterComboBox.SelectedIndex == 1)
                {
                    var names = DataWork.CurrentAdmin.complaints.Where(x => x.text.Contains(SearchBox.Text)).ToList().Select(x => x.text);
                    myListBox.ItemsSource = names;
                }
                else if (FilterComboBox.SelectedIndex == 2)
                {
                    var names = DataWork.CurrentAdmin.complaints.Where(x => x.RELATEDCUSTOMER.NAME.Contains(SearchBox.Text)).ToList().Select(x => x.text);
                    myListBox.ItemsSource = names;
                }
                else if (FilterComboBox.SelectedIndex == 3)
                {
                    var names = DataWork.CurrentAdmin.complaints.Where(x => x.RelateRestaurant.Name.Contains(SearchBox.Text)).ToList().Select(x => x.text);
                    myListBox.ItemsSource = names;

                }
                else if (FilterComboBox.SelectedIndex == 4)
                {
                    var names = DataWork.CurrentAdmin.complaints.Where(x => x.ISCHECKED == false).ToList().Select(x => x.text);
                    myListBox.ItemsSource = names;

                }
                else
                {
                    MessageBox.Show("Select something on filter box first");
                }
            }
            catch
            {
                MessageBox.Show("couldn't filter");
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
