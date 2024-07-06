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
    /// Interaction logic for ComplaintAdminPage.xaml
    /// </summary>
    /// 
    public partial class ComplaintAdminPage : Page
    {
        string selectedComplaint;
  


        public ComplaintAdminPage()
        {
            InitializeComponent();
            DataContext = this;
            foreach (var item in DataWork.dataBase.Admins.ToList()[0].complaints)
            {
                ComplaintsStackPanel.Children.Add(new userControls.replyedComplaint(item, this));
            }
        }

        public void Button_Click(string x, userControls.replyedComplaint replyedComplaint)
        {
            selectedComplaint = x;
            contentControl.Content = new userControls.ReplyComplaintByAdmin(selectedComplaint , replyedComplaint);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
