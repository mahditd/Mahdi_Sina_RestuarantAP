using Mahdi_Sina_AP_Project.Pages.userControls;
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
    /// Interaction logic for complaintHistory.xaml
    /// </summary>
    public partial class complaintHistory : Page
    {
        public complaintHistory()
        {
            InitializeComponent();
           List<Complaint> complaints = DataWork.CurrentCustomer.COMPLAINTS;
            foreach (var item in complaints)
            {
                stackPanel.Children.Add(new userControls.respondedComplaint(item,this));
            }
        }
        public void setContentToRespond(Complaint complaint)
        {
            content.Content = new ViewResponse(complaint);
        }

    }
}
