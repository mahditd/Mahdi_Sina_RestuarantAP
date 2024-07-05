﻿using Sina_Mahdi_RestaurantAP;
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
    /// Interaction logic for RestaurantPanel.xaml
    /// </summary>
    public partial class RestaurantPanel : Page
    {

        private bool isPressed;

        public RestaurantPanel()
        {
            InitializeComponent();
            float RateAverage = 0;
            int indexHolder = 0;
            for(int i = 0;i < DataWork.CurrentRestaurant.foodList.Count;i++)
            {
                RateAverage += DataWork.CurrentRestaurant.foodList[i].RATE;
                indexHolder = i;
            }
            RateAverage /= (indexHolder + 1);



            DataWork.CurrentRestaurant.rate = RateAverage;
           
            if(RateAverage < 4) 
            {
                DataWork.CurrentRestaurant.CanReserve = false;
                CircleButton.Content = "Reserve OFF";
                
            }

            DataWork.dataBase.SaveChanges();
            if (DataWork.CurrentRestaurant.CanReserve == true)
            {
                CircleButton.Content = "Reserve ON";
            }
            else if (DataWork.CurrentRestaurant.CanReserve == false)
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
            
            //NavigationService.GoBack();
        }


        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            Color = new SolidColorBrush(Colors.Red);
            if (DataWork.CurrentRestaurant.Rate >= 4)
            {
                if (DataWork.CurrentRestaurant.CanReserve == true)
                {
                    isPressed = false;
                }
                else if (DataWork.CurrentRestaurant.CanReserve == false)
                {
                    isPressed = true;
                }

                // var ellipse = CircleButton.Template.FindName("circleEllipse", CircleButton) as Ellipse;


                // if (ellipse != null)
                //{
                if (!isPressed)
                {
                    Color = new SolidColorBrush(Colors.White);
                    DataWork.CurrentRestaurant.CanReserve = false;
                    CircleButton.Content = "Reserve OFF";
                }
                else
                {
                    Color = new SolidColorBrush(Colors.Gold);
                    DataWork.CurrentRestaurant.CanReserve = true;
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

        private void Changing_Menu_Click(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Food_Inventory());
           
        }

        private void Food_Inventory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RestaurantMenuChanging());
        }

        private void History_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderReserveHistoryPagexaml());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
