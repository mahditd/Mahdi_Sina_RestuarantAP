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
using System.Windows.Shapes;

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Customer.AddNewCustomer(userName.txtBox.Text, password.txtBox.Text, email.txtBox.Text, name.txtBox.Text, phoneNumber.txtBox.Text, postalCode.txtBox.Text))
            {
                MessageBox.Show("successfully added the new user");
            }
            else
            {
                //more detail like regex
                MessageBox.Show("repetitious userName");
            }
        }
    }
}
