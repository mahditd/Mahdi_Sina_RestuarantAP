﻿using System;
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
        public RestaurantPanel()
        {
            InitializeComponent();
        }

        

        private void ChangeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Window ChangeMenu = new RestaurantMenuChanging();
            ChangeMenu.Show();
            this.Close();
        }

        private void FoodInventoryButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReserveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
