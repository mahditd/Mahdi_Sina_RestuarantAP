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
    /// Interaction logic for txtBoxWithTxtBlock.xaml
    /// </summary>
    public partial class txtBoxWithTxtBlock : UserControl
    {
        public txtBoxWithTxtBlock()
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBox.Text == "")
            {
                txtBlock.Visibility = Visibility.Visible;
            }
            else
            {
                txtBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
