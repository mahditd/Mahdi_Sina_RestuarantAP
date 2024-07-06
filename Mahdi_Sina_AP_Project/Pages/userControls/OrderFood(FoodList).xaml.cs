using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.IO;
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
        string FoodName;
        public OrderFood_FoodList_(string resUserName)
        {
            InitializeComponent();
            List<Food> foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == resUserName).foodList;//never will be null
            myListBox.ItemsSource = foods.Select(x => x.NAME);
            Restaurant = resUserName;
            foodInformationStack.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as Button;
            FoodName = ClickedButton.Content.ToString();
            foodInformationStack.Visibility = Visibility.Visible;
            ingredients.Content = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName).INGREDIENTS;
            Rate.Content = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName).RATE;

            string path = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName).IMAGEPATH;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path, UriKind.Relative); //in dahane mano servis kard
            bitmap.EndInit();
            foodImage.Source = bitmap;
        }
        private void AddToCart(object sender, RoutedEventArgs e)
        {
            //unique food name must be considered
            List<Food> foods = DataWork.CurrentCustomer.ORDERS[DataWork.CurrentCustomer.ORDERS.Count - 1].Foods;
            foods.Add(DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName));
            List<Order> orders = DataWork.CurrentCustomer.ORDERS;
            orders[orders.Count - 1].Foods = foods;
            DataWork.CurrentCustomer.ORDERS = orders;
            DataWork.dataBase.SaveChanges();
            foods = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST[DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST.Count - 1].Foods;
            foods.Add(DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).foodList.FirstOrDefault(x => x.NAME == FoodName));
            orders = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST;
            orders[orders.Count - 1].Foods = foods;
            DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == Restaurant).ORDERLIST = orders;
            DataWork.dataBase.SaveChanges();
        }

    }
}
