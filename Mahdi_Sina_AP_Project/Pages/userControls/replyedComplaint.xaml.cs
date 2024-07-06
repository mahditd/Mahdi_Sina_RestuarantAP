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
    /// Interaction logic for replyedComplaint.xaml
    /// </summary>
    public partial class replyedComplaint : UserControl
    {
        Complaint Complaint ;
        Page page;
        private Visibility visibility;

        public Visibility Visibility
        {
            get { return visibility; }
            set { visibility = value;
                label.Visibility = visibility;
            }
        }

        public replyedComplaint(Complaint complaint, Page page1)
        {
            InitializeComponent();
            Complaint = complaint;
            label.Visibility = Visibility.Hidden;
            page = page1;
            if (Complaint.ISCHECKED)
            {
                label.Visibility = Visibility.Visible;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = Complaint.text;
            if (Complaint.ISCHECKED)
            {
                Visibility = Visibility.Visible;
            }
        }

        private void reply_Click(object sender, RoutedEventArgs e)
        {
            (page as ComplaintAdminPage).Button_Click(Complaint.text, this);
        }
    }
}
