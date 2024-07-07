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
    /// Interaction logic for txtBoxWithTxtBlock2.xaml
    /// </summary>
    public partial class txtBoxWithTxtBlock2 : UserControl
    {
        public txtBoxWithTxtBlock2()
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
        private Visibility tikVis;

        public Visibility TikVis
        {
            get { return tikVis; }
            set { tikVis = value;
                tik.Visibility = tikVis;
            }
        }
        private Visibility crossVis;

        public Visibility CrossVis
        {
            get { return crossVis; }
            set
            {
                crossVis = value;
                cross.Visibility = crossVis;
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            tik.Visibility = Visibility.Hidden;
            cross.Visibility = Visibility.Hidden;
        }
    }
}
