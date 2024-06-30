
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

namespace Mahdi_Sina_AP_Project.Pages
{
    /// <summary>
    /// Interaction logic for Food_Inventory.xaml
    /// </summary>
    public partial class Food_Inventory : Page
    {
        public Food_Inventory()
        {

            InitializeComponent();
            List<Food> foods = new List<Food>();
            Food food1 = new Food("pizza", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food2 = new Food("cheeseburger", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food3 = new Food("Kebab3142", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food4 = new Food("Kebab4142", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food5 = new Food("Kebab514", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food6 = new Food("Kebab412444444412", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food7 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food8 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food9 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food10 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food11 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food12 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food13 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food14 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food15 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food16 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food17 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food18 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food19 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food20 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food21 = new Food("Kebab4", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food22 = new Food("Kebab45", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            foods.Add(food1);
            foods.Add(food2);
            foods.Add(food3);
            foods.Add(food4);
            foods.Add(food5);
            foods.Add(food6);
            foods.Add(food7);
            foods.Add(food8);
            foods.Add(food9);
            foods.Add(food10);
            foods.Add(food11);
            foods.Add(food12);
            foods.Add(food13);
            foods.Add(food14);
            foods.Add(food15);
            foods.Add(food16);
            foods.Add(food17);
            foods.Add(food18);
            foods.Add(food19);
            foods.Add(food20);
            foods.Add(food21);
            foods.Add(food22);
            var foodNames = foods.Select(x => x.NAME + SpaceMaker(x.NAME) + x.Price + "$");
            myListBox.ItemsSource = foodNames;


        }

        private void SetImage(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();
            MyImage.Source = bitmap;
        }
        public string SpaceMaker(string foodName)
        {
            string spaces = "";
            int size = 45 - foodName.Length;

            for (int i = 0; i < size - foodName.Length; i++)
            {
                spaces += " ";
            }
            return spaces;
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
        Food ChosenFood;
            List<Food> Foods = new List<Food>();
            Food food1 = new Food("cheeseburger", 12.5, 3, "\\food_photos\\cheesburger.jpg", Restaurant.currentRestaurant,"  ");
            Food food2 = new Food("pizza", 12.5, 3, "\\food_photos\\chickenburger.jpg", Restaurant.currentRestaurant, "  ");
            Food food3 = new Food("hamburger", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food4 = new Food("lazania", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food5 = new Food("pasta", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food6 = new Food("pizza1", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food7 = new Food("Kebab1", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Food food8 = new Food("steak", 12.5, 3, "", Restaurant.currentRestaurant, "  ");
            Foods.Add(food1);
            Foods.Add(food2);
            Foods.Add(food3);
            Foods.Add(food4);
            Foods.Add(food5);
            Foods.Add(food6);
            Foods.Add(food7);
            Foods.Add(food8);
            Restaurant.currentRestaurant.FOODLIST.Add(food1);
            Restaurant.currentRestaurant.FOODLIST.Add(food2);
            Restaurant.currentRestaurant.FOODLIST.Add(food3);
            Restaurant.currentRestaurant.FOODLIST.Add(food4);
            Restaurant.currentRestaurant.FOODLIST.Add(food5);
            Restaurant.currentRestaurant.FOODLIST.Add(food6);
            Restaurant.currentRestaurant.FOODLIST.Add(food7);
            Restaurant.currentRestaurant.FOODLIST.Add(food8);
            string[] foodName = myListBox.SelectedItem.ToString().Split(" ");
            for(int i = 0;i < Restaurant.currentRestaurant.FOODLIST.Count; i++)
            {
                if (foodName[0] == Restaurant.currentRestaurant.FOODLIST[i].NAME)
                {
                    ChosenFood = Restaurant.currentRestaurant.FOODLIST[i];
                    SetImage(ChosenFood.IMAGEPATH);
                    break;
                }
            }
           

        }
        private void ChangeImageButton_Click(object sender, RoutedEventArgs e)
        {
            Window UploadImage = new Upload_Image();
            UploadImage.Show();
        }



    }

}
