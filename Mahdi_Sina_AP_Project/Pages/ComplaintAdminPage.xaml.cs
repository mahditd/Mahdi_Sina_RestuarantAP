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
            List1 = DataWork.dataBase.Admins.ToList()[0].complaints.Select(x => x.text).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectedComplaint =  (e.OriginalSource as Button).Content.ToString();
            contentControl.Content = new userControls.ReplyComplaintByAdmin(selectedComplaint);
        }


    }
}
