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
    /// Interaction logic for commentPlace.xaml
    /// </summary>
    public partial class commentPlace : UserControl
    {
        string Restaurant;
        string foodName;
        public commentPlace(string restaurant, string foodName)
        {
            InitializeComponent();
            Restaurant = restaurant;
            this.foodName = foodName;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList;
            Food food = foods.FirstOrDefault( x => x.NAME == foodName);
            food.comments.Add(new Comment(txtBox.Text, DataWork.CurrentCustomer.USERNAME));
            DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList = foods;
            DataWork.dataBase.SaveChanges();
        }
    }
}
