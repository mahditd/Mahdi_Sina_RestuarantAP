using Sina_Mahdi_RestaurantAP;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Customer customer = new Customer("Mahdi", "mahdi006", "mahdi005@gmail.com", "mahdi", "0912", "");
            //DataWork.dataBase.Customers.Add(customer);
            //customer.ORDERS = new List<Order>() { new Order("first", 0.2, (float)0.3, "", new Restaurant(), "ingredient", PaymentMethod.Online) };
            //DataWork.dataBase.Add(customer);
            //List<Order> customers = DataWork.dataBase.Customers.FirstOrDefault(x => x.ID == 3).ORDERS;
            //DataWork.dataBase.SaveChanges();
        }

        private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}