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
    /// Interaction logic for RateFoodsOfOrders.xaml
    /// </summary>
    public partial class RateFoodsOfOrders : UserControl
    {
        string Order;//name of order for the user
        string foodName;
        string restaurant;
        public RateFoodsOfOrders(string order)
        {
            InitializeComponent();
            this.Order = order;
            Order order1 = DataWork.CurrentCustomer.ORDERS.FirstOrDefault(x => x.NAME == Order);
            List<string> foods = new List<string>();
            restaurant = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == order1.relatedRestaurant).USERNAME;
            
            foreach (var food in DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == order1.relatedRestaurant).foodList)
            {

                foreach (var food1 in order1.Foods)
                {
                    if (food.NAME == food1.NAME)
                    {
                        foods.Add(food.NAME);
                    }
                }
            }
            myListBox.ItemsSource = foods;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foodName = (e.Source as Button).Content.ToString();
            messagePlace.Content = new commentPlace(restaurant, foodName);
        }
    }
}
