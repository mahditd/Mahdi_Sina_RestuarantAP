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
using System.Windows.Shapes;

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for RestaurantPanel.xaml
    /// </summary>
    public partial class RestaurantPanel : Window
    {
        private bool isPressed;

        public RestaurantPanel()
        {
            InitializeComponent();
            Restaurant.currentRestaurant = new Restaurant("", "", "", "");
            Restaurant.currentRestaurant.RATE = 5;
            Restaurant.currentRestaurant.CANRESERVE = true;

            if (Restaurant.currentRestaurant.CANRESERVE == true)
            {
                CircleButton.Content = "Reserve ON";
            }
            else if (Restaurant.currentRestaurant.CANRESERVE == false)
            {
                CircleButton.Content = "Reserve OFF";
            }

        }
        private SolidColorBrush color;

        public SolidColorBrush Color
        {
            get { return color; }
            set
            {
                color = value;
                var ellipse = CircleButton.Template.FindName("circleEllipse", CircleButton) as Ellipse;
                ellipse.Fill = color;
            }
        }




        private void ChangeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Window ChangeMenu = new RestaurantMenuChanging();
            ChangeMenu.Show();
            this.Close();
        }

        private void FoodInventoryButton_Click(object sender, RoutedEventArgs e)
        {
            Window InventoryMenu = new Food_Inventory();
            InventoryMenu.Show();
            this.Close();
        }
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            Color = new SolidColorBrush(Colors.Red);
            if (Restaurant.currentRestaurant != null && Restaurant.currentRestaurant.RATE >= 4)
            {
                if (Restaurant.currentRestaurant.CANRESERVE == true)
                {
                    isPressed = false;
                }
                else if (Restaurant.currentRestaurant.CANRESERVE == false)
                {
                    isPressed = true;
                }

               // var ellipse = CircleButton.Template.FindName("circleEllipse", CircleButton) as Ellipse;


               // if (ellipse != null)
                //{
                    if (!isPressed)
                    {
                        Color = new SolidColorBrush(Colors.White);
                        Restaurant.currentRestaurant.CANRESERVE = false;
                        CircleButton.Content = "Reserve OFF";
                    }
                    else
                    {
                        Color = new SolidColorBrush(Colors.Gold);
                        Restaurant.currentRestaurant.CANRESERVE = true;
                        CircleButton.Content = "Reserve ON";
                    }

                    isPressed = !isPressed;
               // }
            }
            else
            {
                MessageBox.Show("You can not use reservation for your restaurant because your rate is less than 4", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CircleButton_Loaded(object sender, RoutedEventArgs e)
        {
            Color = new SolidColorBrush(Colors.Gold);

        }
    }
}
