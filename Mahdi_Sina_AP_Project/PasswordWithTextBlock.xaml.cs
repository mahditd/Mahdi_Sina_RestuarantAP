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

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for PasswordWithTextBlock.xaml
    /// </summary>
    public partial class PasswordWithTextBlock : UserControl
    {
        public PasswordWithTextBlock()
        {
            InitializeComponent();
        }
        private string placeHolder;

        public string PlaceHolder
        {
            get { return placeHolder; }
            set
            {
                placeHolder = value;
                txtBlock.Text = placeHolder;
            }
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (password.Password != "")
            {
                txtBlock.Visibility = Visibility.Hidden;
            }
            else { txtBlock.Visibility = Visibility.Visible; }
        }
    }
}
