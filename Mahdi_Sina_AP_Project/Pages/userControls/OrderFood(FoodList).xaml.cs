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
    /// Interaction logic for OrderFood_FoodList_.xaml
    /// </summary>
    public partial class OrderFood_FoodList_ : UserControl
    {
        
        public OrderFood_FoodList_(string resUserName)
        {
            InitializeComponent();
            List<Food> foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == resUserName).foodList;//never will be null
            myListBox.ItemsSource = foods.Select(x => x.NAME);
        }
    }
}
