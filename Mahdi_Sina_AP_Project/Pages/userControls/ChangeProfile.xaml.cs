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

namespace Mahdi_Sina_AP_Project.Pages.userControls
{
    /// <summary>
    /// Interaction logic for ChangeProfile.xaml
    /// </summary>
    public partial class ChangeProfile : UserControl
    {
        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void confirmInforamtion_Click(object sender, RoutedEventArgs e)
        {
            string userName = UserName.txtBox.Text;
            string name = Name.txtBox.Text;
            string password = Password.txtBox.Text;
            string email = Email.txtBox.Text;
            string postalCode = PostalCode.txtBox.Text;
            string phoneNumber = PhoneNumber.txtBox.Text;
            if (userName != "")
            {
                if (DataWork.dataBase.Customers.FirstOrDefault(x => x.USERNAME == userName) == null)
                {
                    DataWork.CurrentCustomer.USERNAME = userName;
                    DataWork.dataBase.SaveChanges();
                    UserName.TikVis = Visibility.Visible;
                    UserName.CrossVis = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Repetitious username", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    UserName.CrossVis = Visibility.Visible;
                    UserName.TikVis = Visibility.Hidden;
                }
            }
            else
            {
                UserName.TikVis = Visibility.Hidden;
                UserName.CrossVis = Visibility.Hidden;
            }
            if (name != "")
            {
                DataWork.CurrentCustomer.NAME = name;
                DataWork.dataBase.SaveChanges();
                Name.TikVis = Visibility.Visible;
            }
            else
            {
                Name.TikVis = Visibility.Hidden;
                Name.CrossVis = Visibility.Hidden;
            }
            if (postalCode != "")
            {
                DataWork.CurrentCustomer.POSTALCODE = postalCode;
                DataWork.dataBase.SaveChanges();
                PostalCode.TikVis = Visibility.Visible;
            }
            else
            {
                PostalCode.TikVis = Visibility.Hidden;
                PostalCode.CrossVis = Visibility.Hidden;
            }
            if (password != "")
            {
                DataWork.CurrentCustomer.PASSWORD = password;
                DataWork.dataBase.SaveChanges();
                Password.TikVis = Visibility.Visible;
            }
            else
            {
                Password.TikVis = Visibility.Hidden;
                Password.CrossVis = Visibility.Hidden;
            }
            if (phoneNumber != "")
            {
                DataWork.CurrentCustomer.PHONENUMBER = phoneNumber;
                DataWork.dataBase.SaveChanges();
                PhoneNumber.TikVis = Visibility.Visible;
            }
            else
            {
                PhoneNumber.TikVis = Visibility.Hidden;
                PhoneNumber.CrossVis = Visibility.Hidden;
            }
            if (email != "")
            {
                if (sendingEmail())
                {
                    DataWork.CurrentCustomer.EMAIL = email;
                    DataWork.dataBase.SaveChanges();
                    Email.TikVis = Visibility.Visible;
                    Email.CrossVis = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Wrong verification", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    Email.CrossVis = Visibility.Visible;
                    Email.TikVis = Visibility.Hidden;

                }
            }
            else
            {
                Email.TikVis = Visibility.Hidden;
                Email.CrossVis = Visibility.Hidden;
            }
        }

        private bool sendingEmail()
        {
            string verificationCode = Customer.SendVerificationEmail(DataWork.CurrentCustomer.EMAIL).ToString();
            Customer.EmailConfirmed = false;
            Window verificationWindow = new Confirming_email(verificationCode, this);
            verificationWindow.ShowDialog();
            if (Customer.EmailConfirmed == true)
            {
                return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
