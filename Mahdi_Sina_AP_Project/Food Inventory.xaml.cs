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
using System.Windows.Shapes;

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for Food_Inventory.xaml
    /// </summary>
    public partial class Food_Inventory : Window
    {
        public Food_Inventory()
        {
            InitializeComponent();
            List<Food> foods = new List<Food>();
            Food food1 = new Food("Kebab1",12.5,3,"",Restaurant.currentRestaurant,"  ");
            Food food2 = new Food("Kebab2",12.5,3,"",Restaurant.currentRestaurant,"  ");
            Food food3 = new Food("Kebab3",12.5,3,"",Restaurant.currentRestaurant,"  ");
            Food food4 = new Food("Kebab4",12.5,3,"",Restaurant.currentRestaurant,"  ");
            foods.Add(food1);
            foods.Add(food2);
            foods.Add(food3);
            foods.Add(food4);
            var foodNames = foods.Select(x => x.NAME);
            MyComboBox.ItemsSource = foodNames;
        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(MyComboBox.SelectedItem == "Kebab1")
            {
                MessageBox.Show(MyComboBox.SelectedItem.ToString(),"",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
