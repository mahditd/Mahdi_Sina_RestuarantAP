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
        string Restaurant;
        public OrderFood_FoodList_(string resUserName)
        {
            InitializeComponent();
            List<Food> foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == resUserName).foodList;//never will be null
            myListBox.ItemsSource = foods.Select(x => x.NAME);
            Restaurant = resUserName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var ClickedButton = e.OriginalSource as Button;
            string FoodName = ClickedButton.Content.ToString();//unique food name must be considered
            List<Food> foods = DataWork.CurrentCustomer.ORDERS[DataWork.CurrentCustomer.ORDERS.Count - 1].Foods;
            foods.Add(DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName));
            List<Order> orders = DataWork.CurrentCustomer.ORDERS;
            orders[orders.Count - 1].Foods = foods;
            DataWork.CurrentCustomer.ORDERS = orders;
            DataWork.dataBase.SaveChanges();
            foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST[DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST.Count -1].Foods;
            foods.Add(DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName));
            orders = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST;
            orders[orders.Count -1 ].Foods = foods;
            DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST = orders;
            DataWork.dataBase.SaveChanges();
        }
    }
}
