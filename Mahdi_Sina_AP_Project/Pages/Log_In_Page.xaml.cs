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
    /// Interaction logic for Log_In_Page.xaml
    /// </summary>
    public partial class Log_In_Page : Page
    {
        public Log_In_Page()
        {
            InitializeComponent();
            //Customer customer = new Customer("1234","qwer","12314","asfcdf","12413532","sdfwad");
            //Restaurant restaurant = new Restaurant();
            //Order order1 = new Order("aefseg",123,12,"xadsf",restaurant,"addfa",PaymentMethod.OnDelivery);
            //Order order2 = new Order("aefseg", 123, 12, "xadsf", restaurant, "addfa", PaymentMethod.OnDelivery);
            //customer.orders.Add(order1);
            //customer.orders.Add(order2);
            //DataWork.dataBase.Customers.Add(customer);
            //DataWork.dataBase.SaveChanges();
        }
        //private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        //{
        //    var ClickedButton = e.OriginalSource as NavButton2;

        //    NavigationService.Navigate(ClickedButton.NavUri);
        //    //Window signUpWindow = new SignUp();
        //    //signUpWindow.Show();
        //}



        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton2;
            NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void confirmBtn_Click_1(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton2;
            NavigationService.Navigate(ClickedButton.NavUri);

        }
    }
}
