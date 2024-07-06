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

    public partial class ComplaintsPage : UserControl
    {
        CustomerPage CustomerPage;
        public ComplaintsPage(CustomerPage customerPage)
        {
            InitializeComponent();
            CustomerPage = customerPage;
        }

        private void SubmitComplaint_Click(object sender, RoutedEventArgs e)
        {
            Restaurant restaurant = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == restaurantName.txtBox.Text);
            if (restaurant != null)
            {
                Complaint complaint = new Complaint(complaintText.Text, DataWork.CurrentCustomer);
                List<Complaint> complaints = DataWork.dataBase.Admins.ToList()[0].complaints;
                complaints.Add(complaint);
                DataWork.dataBase.Admins.ToList()[0].complaints = complaints;
                DataWork.dataBase.SaveChanges();
                complaints = DataWork.CurrentCustomer.COMPLAINTS;
                complaints.Add(complaint);
                DataWork.CurrentCustomer.COMPLAINTS = complaints;
                DataWork.dataBase.SaveChanges();
            }
            else
            {
                MessageBox.Show("Could not find such a username for a restaurant", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void complaintHistory_Click(object sender, RoutedEventArgs e)
        {
            CustomerPage.naviHistoryComplaint();


        }
    }
}
