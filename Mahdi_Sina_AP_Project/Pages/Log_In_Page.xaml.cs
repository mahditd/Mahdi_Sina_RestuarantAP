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
            //Customer customer = new Customer("1234","qwer","12314","asfcdf","12413532","sdfwad");
            //Restaurant restaurant = new Restaurant();
            //Order order1 = new Order("aefseg",123,12,"xadsf",restaurant,"addfa",PaymentMethod.OnDelivery);
            //Order order2 = new Order("aefseg", 123, 12, "xadsf", restaurant, "addfa", PaymentMethod.OnDelivery);
            //customer.orders.Add(order1);
            //customer.orders.Add(order2);
            //DataWork.dataBase.Customers.Add(customer);
            //DataWork.dataBase.SaveChanges();
        }
        //private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        //{
        //    var ClickedButton = e.OriginalSource as NavButton2;

        //    NavigationService.Navigate(ClickedButton.NavUri);
        //    //Window signUpWindow = new SignUp();
        //    //signUpWindow.Show();
        //}

        int chosenComboItem = 0;


        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton2;
            NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void confirmBtn_Click_1(object sender, RoutedEventArgs e)
        {
            //var ClickedButton = e.OriginalSource as NavButton2;
            //NavigationService.Navigate(ClickedButton.NavUri);
            string userName = UserName.txtBox.Text;
            string password = Password.password.Password;
            if (chosenComboItem == 1)
            {
                Customer testCustomer;
                try
                {
                    testCustomer = DataWork.dataBase.Customers.FirstOrDefault(x => x.USERNAME == userName);
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
                        NavigationService.Navigate(new Admin_Panel());
                    }
                    else
                    {
                        MessageBox.Show("Enter a correct password");

                    }
                }
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
