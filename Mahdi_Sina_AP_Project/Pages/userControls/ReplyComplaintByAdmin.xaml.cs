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
        public ReplyComplaintByAdmin(string complaintText)
        {
            InitializeComponent();
            ComplaintText = complaintText;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
           Complaint complaint = DataWork.dataBase.Admins.ToList()[0].complaints.FirstOrDefault(x => x.text == ComplaintText);
            if (complaint.ISCHECKED == false )
            {
                complaint.replyedText = replyText.Text;
            }
            else
            {
                MessageBox.Show("you have already answered this complaint", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
