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
    /// Interaction logic for Log_In_Page.xaml
    /// </summary>
    public partial class Log_In_Page : Page
    {
        public Log_In_Page()
        {
            InitializeComponent();
<<<<<<< HEAD
            //DataWork.dataBase.Admins.Add(new Admin("sina", "sina006"));
            //DataWork.dataBase.SaveChanges();
=======
            DataWork.dataBase.Admins.Add(new Admin("sina", "sina006"));
            DataWork.dataBase.SaveChanges();
>>>>>>> bb08d69ff1589f0518d063cde96c712c4aafe738
        }


        int chosenComboItem = 0;


        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton2;
            NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void confirmBtn_Click_1(object sender, RoutedEventArgs e)
        {
  
            string userName = UserName.txtBox.Text;
            string password = Password.password.Password;
            if (chosenComboItem == 1)
            {
                Customer testCustomer;
                try
                {
                    testCustomer = DataWork.dataBase.Customers.FirstOrDefault(x => x.USERNAME == userName);
                    if(testCustomer == null) 
                    {
                        MessageBox.Show("Enter a correct username");
                    }
                }
                catch (Exception)
                {
                    testCustomer = null;
                    MessageBox.Show("Enter a correct username");
                }
                if (testCustomer != null)
                {
                    if (testCustomer.PASSWORD == password)
                    {
                        DataWork.CurrentCustomer = testCustomer;
                        NavigationService.Navigate(new CustomerPage());
                    }
                    else
                    {
                        MessageBox.Show("Enter a correct password");

                    }
                }
            }
            else if (chosenComboItem == 2)
            {
                Restaurant testRestaurant;
                try
                {
                    testRestaurant = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == userName);
                    if(testRestaurant == null)
                    {
                        MessageBox.Show("Enter a correct username");
                    }
                }
                catch (Exception)
                {
                    testRestaurant = null;
                    MessageBox.Show("Enter a correct username");
                }
                if (testRestaurant != null)
                {
                    if (testRestaurant.PASSWORD == password)
                    {
                        DataWork.CurrentRestaurant = testRestaurant;
                        NavigationService.Navigate(new RestaurantPanel());
                    }
                    else
                    {
                    MessageBox.Show("Enter a correct password");

                    }
                }
            }
            else if (chosenComboItem == 3)
            {
                Admin testAdmin;
                try
                {
                    testAdmin = DataWork.dataBase.Admins.FirstOrDefault(x => x.USERNAME == userName);
                    if( testAdmin == null )
                    {
                        MessageBox.Show("Enter a correct username");
                    }
                }
                catch (Exception)
                {
                    testAdmin = null;
                    MessageBox.Show("Enter a correct username");
                }
                if (testAdmin != null)
                {
                    if (testAdmin.PASSWORD == password)
                    {
                        DataWork.CurrentAdmin = testAdmin;
                        NavigationService.Navigate(new Admin_Panel());
                    }
                    else
                    {
                        MessageBox.Show("Enter a correct password");

                    }
                }
            }
            else
            {
                MessageBox.Show("Choose Which User you want to enter as");
            }
        }

        private void customerCombo_Click(object sender, RoutedEventArgs e)
        {
            chosenComboItem = 1;
        }

        private void restaurantCombo_Click(object sender, RoutedEventArgs e)
        {
            chosenComboItem = 2;
        }

        private void adminCombo_Click(object sender, RoutedEventArgs e)
        {
            chosenComboItem = 3;
        }
    }
}
