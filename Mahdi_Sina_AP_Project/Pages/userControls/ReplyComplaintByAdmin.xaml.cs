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
    /// Interaction logic for ReplyComplaintByAdmin.xaml
    /// </summary>
    public partial class ReplyComplaintByAdmin : UserControl
    {
        string ComplaintText;
        userControls.replyedComplaint ReplyedComplaint;
        Order Order;
        public ReplyComplaintByAdmin(string complaintText, userControls.replyedComplaint replyedComplaint)
        {
            InitializeComponent();
            ComplaintText = complaintText;
            ReplyedComplaint = replyedComplaint;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            var complaints = DataWork.dataBase.Admins.ToList()[0].complaints;
            Complaint complaint = complaints.FirstOrDefault(x => x.text == ComplaintText);
            Customer relatedCustomer = complaint.RELATEDCUSTOMER;
            if (complaint.ISCHECKED == false )
            {
                complaint.replyedText = replyText.Text;
                complaint.ISCHECKED = true;
                ReplyedComplaint.Visibility = Visibility.Visible;
                DataWork.dataBase.Admins.ToList()[0].complaints = complaints;
                DataWork.dataBase.SaveChanges();
                complaints = DataWork.dataBase.Customers.FirstOrDefault(x => x.USERNAME == relatedCustomer.USERNAME).COMPLAINTS;
                complaint = complaints.FirstOrDefault(x => x.text == ComplaintText);
                complaint.ISCHECKED = true;
                complaint.replyedText = replyText.Text;
                DataWork.dataBase.Customers.FirstOrDefault(x => x.USERNAME == relatedCustomer.USERNAME).COMPLAINTS = complaints;
                DataWork.dataBase.SaveChanges();
            }
            else
            {
                MessageBox.Show("you have already answered this complaint", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
