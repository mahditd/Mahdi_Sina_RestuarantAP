using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RestaurantInformations.xaml
    /// </summary>
    public partial class RestaurantInformations : UserControl
    {
        public RestaurantInformations()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //checking fields to be fully completed
            string Password = password.txtBox.Text;
            string UserName = userName.txtBox.Text;
            string ConfirmPassword = confirmPassword.txtBox.Text;
            string Name = name.txtBox.Text;
            string Adress = adress.txtBox.Text;
            if (Password == "" || UserName == "" || ConfirmPassword == "" || Name == "" || Adress == "")
            {
                MessageBox.Show("fill all fields", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!ValidatePassword(Password))
            {
                MessageBox.Show("Your password should be 8 characters long and you can only use numbers", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!ValidateUsername(UserName))
            {
                MessageBox.Show("Your username should be at least 3 character long", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == UserName) == null)
                {
                    if (Password == ConfirmPassword)
                    {
                        DataWork.CurrentRestaurant = new Restaurant(UserName, Password, Name, Adress);
                        DataWork.dataBase.Restaurants.Add(DataWork.CurrentRestaurant);
                        DataWork.dataBase.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("password and the confirmation of it are not the same", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                }
                else
                {
                    MessageBox.Show("repetitious username", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^\d{8}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }

        public static bool ValidateUsername(string username)
        {
            string pattern = @".{3,}";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }
    }
}
