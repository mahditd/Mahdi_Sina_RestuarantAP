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
    /// Interaction logic for respondedComplaint.xaml
    /// </summary>
    public partial class respondedComplaint : UserControl
    {
        private Visibility visibility;

        public Visibility Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                label.Visibility = visibility;
            }
        }
        Complaint Complaint;
        complaintHistory ComplaintHistory;
        public respondedComplaint(Complaint complaint, complaintHistory complaintHistory)
        {
            InitializeComponent();
            Complaint = complaint;
            ComplaintHistory = complaintHistory;
        }

        private void reply_Click(object sender, RoutedEventArgs e)
        {
            ComplaintHistory.setContentToRespond(Complaint);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = Complaint.text;
            if (Complaint.ISCHECKED)
            {
                Visibility = Visibility.Visible;
            }
            else
            {
                    Visibility = Visibility.Hidden;
            }
        }
    }
}
