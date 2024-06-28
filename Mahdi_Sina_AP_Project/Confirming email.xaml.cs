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
    /// Interaction logic for Confirming_email.xaml
    /// </summary>
    public partial class Confirming_email : Window
    {
        string verificationCode;
        Window parent;
        public Confirming_email(string _verificationCode, Window _parent)
        {
            verificationCode = _verificationCode;
            parent = _parent;
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxBlock.txtBox.Text == verificationCode)
            {
                Customer.EmailConfirmed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong verify code", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
