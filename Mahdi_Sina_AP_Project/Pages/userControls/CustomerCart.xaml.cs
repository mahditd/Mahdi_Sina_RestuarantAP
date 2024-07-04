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
    /// Interaction logic for OrderInformations.xaml
    /// </summary>
    public partial class CustomerCart : UserControl
    {
        private double cost;
        Order currentOrder;
        int onlinePay = -1;
        public double Cost
        {
            get { return cost; }
            set { 
                cost = value;
                costNum.Text =cost.ToString();
            }
        }

        public CustomerCart()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            currentOrder = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.payed == 0);
            myListBox.ItemsSource = currentOrder.Foods.Select(food => food.NAME).ToList();
            Cost = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.payed == 0).Foods.Sum(food => food.Price);
            
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (sendingEmail())
            {
                List<Order> orders = DataWork.CurrentCustomer.ORDERS;
                orders.FirstOrDefault(currentOrder => currentOrder.payed == 0).payed = 1;
                DataWork.CurrentCustomer.ORDERS = orders;
                DataWork.dataBase.SaveChanges();
            }

        }

        private void online_Click(object sender, RoutedEventArgs e)
        {
            onlinePay = 1;
        }

        private void cash_Click(object sender, RoutedEventArgs e)
        {
            onlinePay = 0;
        }
        private bool sendingEmail()
        {
           string verificationCode = Customer.SendVerificationEmail(DataWork.CurrentCustomer.EMAIL).ToString();
            Customer.EmailConfirmed = false;
            Window verificationWindow = new Confirming_email(verificationCode, this);
            verificationWindow.ShowDialog();
            if (Customer.EmailConfirmed == true)
            {
                MessageBox.Show("payed successfully");
                return true;
            }
            return false;
        }
    }
}
