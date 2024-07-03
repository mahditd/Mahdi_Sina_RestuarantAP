
using Microsoft.EntityFrameworkCore;
using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private ImageSource imagePath;

        public ImageSource ImagePath
        {
            get { return imagePath; }
            set { imagePath = value;
                
                MyImage.Source = imagePath;
            }
        }

        private string _editableText;


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
            DataContext = this;
            if (ChosenFood != null)
            {
                EditableText = ChosenFood.Price.ToString();
            }
        }

        public string EditableText
        {
            get { return _editableText; }
            set
            {
                if (_editableText != value)
                {
                    _editableText = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void SetImage(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();
            ImagePath = bitmap;
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
        public Food ChosenFood;

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       

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

            DataWork.CurrentRestaurant.foodList = Foods; 
            //Restaurant.currentRestaurant.foodList = Foods;
            
            string[] foodName = myListBox.SelectedItem.ToString().Split(" ");
            int x = Foods.Count;
            for (int i = 0;i < x; i++)
            {
                
               List< Food > food = DataWork.CurrentRestaurant.foodList;
                Food food9 = food[i];
                
                if (foodName[0] == food9.NAME)
                {
                    ChosenFood = DataWork.CurrentRestaurant.foodList[i];
                    SetImage(ChosenFood.IMAGEPATH);
                    break;
                }
            }
            if (ChosenFood != null)
            {
                ChangeImageButton.Visibility = Visibility.Visible;
            }
            else
            {
                ChangeImageButton.Visibility = Visibility.Hidden;
            }
            DataWork.dataBase.SaveChanges();



        }
        private void ChangeImageButton_Click(object sender, RoutedEventArgs e)
        {
            Window UploadImage = new Upload_Image(this);
            UploadImage.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_Food_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Food_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Comments_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
