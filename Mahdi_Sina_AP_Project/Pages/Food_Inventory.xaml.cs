
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

        List<Food> foods = new List<Food>();

        public Food_Inventory()
        {

            InitializeComponent();
            Food food1 = new Food("cheeseburger", 122.5, 4, "\\food_photos\\cheesburger.jpg", Restaurant.currentRestaurant, "  ");
            Food food2 = new Food("pizza", 17, 5, "\\food_photos\\chickenburger.jpg", Restaurant.currentRestaurant, "  ");
            Food food3 = new Food("hamburger", 11, 3, "", Restaurant.currentRestaurant, "  ");
            Food food4 = new Food("lazania", 12.5, 4, "", Restaurant.currentRestaurant, "  ");
            Food food5 = new Food("pasta", 100, 5, "", Restaurant.currentRestaurant, "  ");
            Food food6 = new Food("water", 0.99, 2, "", Restaurant.currentRestaurant, "  ");
            Food food7 = new Food("delester", 12, 1, "", Restaurant.currentRestaurant, "  ");
            Food food8 = new Food("steak", 12.5, 1, "", Restaurant.currentRestaurant, "  ");
            food1.FOODCOUNT = 1;
            food2.FOODCOUNT = 112;
            food3.FOODCOUNT = 12;
            food4.FOODCOUNT = 10;
            food5.FOODCOUNT = 14;
            food6.FOODCOUNT = 18;
            food7.FOODCOUNT = 123;
            food8.FOODCOUNT = 23;
            Foods.Add(food1);
            Foods.Add(food2);
            Foods.Add(food3);
            Foods.Add(food4);
            Foods.Add(food5);
            Foods.Add(food6);
            Foods.Add(food7);
            Foods.Add(food8);
            var foodNames = Foods.Select(x => x.NAME + SpaceMaker(x.NAME));
            myListBox.ItemsSource = foodNames;
            DataContext = this;
            ChangeImageButton.Visibility = Visibility.Hidden;
            MyImage.Visibility = Visibility.Hidden;
            MyDeleteButton.Visibility = Visibility.Hidden;
            MyCommentButton.Visibility = Visibility.Hidden;
            TextBox1.Visibility = Visibility.Hidden;
            TextBox2.Visibility = Visibility.Hidden;
            TextBox3.Visibility = Visibility.Hidden;
            TextBox4.Visibility = Visibility.Hidden;
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
            int size = 35 - foodName.Length;

            for (int i = 0; i < size - foodName.Length; i++)
            {
                spaces += " ";
            }
            return spaces;
        }
        List<Food> Foods = new List<Food>();
        public Food ChosenFood;

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       

            
           

            DataWork.CurrentRestaurant.foodList = Foods; 
            //Restaurant.currentRestaurant.foodList = Foods;
            
            string[] foodName = myListBox.SelectedItem.ToString().Split(" ");
            int x = Foods.Count;
            for (int i = 0;i < x; i++)
            {
                
                List<Food> food = DataWork.CurrentRestaurant.foodList;
                Food food9 = food[i];
                
                if (foodName[0] == food9.NAME)
                {
                    ChosenFood = DataWork.CurrentRestaurant.foodList[i];
                    SetImage(ChosenFood.IMAGEPATH);
                    TextBox1.Text = food9.Price.ToString();
                    TextBox2.Text = food9.RATE.ToString();
                    TextBox3.Text = food9.INGREDIENTS.ToString();
                    TextBox4.Text = food9.FOODCOUNT.ToString();
                    var foodNames = Foods.Select(x => x.NAME + SpaceMaker(x.NAME));
                    myListBox.ItemsSource = foodNames;


                    break;
                }
                else
                {
                    ChosenFood = null;
                }
            }
            if (ChosenFood != null)
            {
                ChangeImageButton.Visibility = Visibility.Visible;
                MyImage.Visibility = Visibility.Visible;
                MyDeleteButton.Visibility = Visibility.Visible;
                MyCommentButton.Visibility = Visibility.Visible;
                TextBox1.Visibility = Visibility.Visible;
                TextBox2.Visibility = Visibility.Visible;
                TextBox3.Visibility = Visibility.Visible;
                TextBox4.Visibility = Visibility.Visible;

            }
            else
            {
                ChangeImageButton.Visibility = Visibility.Hidden;
                MyImage.Visibility = Visibility.Hidden;
                MyDeleteButton.Visibility = Visibility.Hidden;
                MyCommentButton.Visibility = Visibility.Hidden;
                TextBox1.Visibility = Visibility.Hidden;
                TextBox2.Visibility = Visibility.Hidden;
                TextBox3.Visibility = Visibility.Hidden;
                TextBox4.Visibility = Visibility.Hidden;

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
            for (int i = 0; i <Foods.Count; i++)
            {
                if(ChosenFood.NAME == Foods[i].NAME)
                {
                   MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this food?","",MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if(result == MessageBoxResult.Yes)
                    {
                        Foods.RemoveAt(i);
                    }
                    
                }
            }
        }

        private void Comments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
       {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ChosenFood != null && TextBox1.Text != "")
                {
                    ChosenFood.Price = double.Parse(TextBox1.Text);
                    for(int i = 0;i<DataWork.CurrentRestaurant.foodList.Count;i++)
                    {
                        if(ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                        {
                            List<Food> foods = DataWork.CurrentRestaurant.foodList;
                            foods[i].Price = double.Parse(TextBox1.Text);
                            DataWork.CurrentRestaurant.foodList = foods; 

                        }
                    }
                    DataWork.dataBase.SaveChanges();
                }
                if (ChosenFood != null && TextBox2.Text != "")
                {
                    ChosenFood.RATE = int.Parse(TextBox2.Text);
                    for (int i = 0; i < DataWork.CurrentRestaurant.foodList.Count; i++)
                    {
                        if (ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                        {
                            List<Food> foods = DataWork.CurrentRestaurant.foodList;
                            foods[i].RATE = int.Parse(TextBox2.Text);
                            DataWork.CurrentRestaurant.foodList = foods;

                        }
                    }
                    DataWork.dataBase.SaveChanges();
                }
                if (ChosenFood != null && TextBox3.Text != "")
                {
                    ChosenFood.INGREDIENTS = TextBox3.Text;
                    for (int i = 0; i < DataWork.CurrentRestaurant.foodList.Count; i++)
                    {
                        if (ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                        {
                            List<Food> foods = DataWork.CurrentRestaurant.foodList;
                            foods[i].INGREDIENTS = TextBox3.Text;
                            DataWork.CurrentRestaurant.foodList = foods;
                        }
                    }
                    DataWork.dataBase.SaveChanges();
                }
                if (ChosenFood != null && TextBox4.Text != "")
                {
                    ChosenFood.FOODCOUNT = int.Parse(TextBox4.Text);
                    for (int i = 0; i < DataWork.CurrentRestaurant.foodList.Count; i++)
                    {
                        if (ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                        {
                            List<Food> foods = DataWork.CurrentRestaurant.foodList;
                            foods[i].FOODCOUNT = int.Parse(TextBox4.Text);
                            DataWork.CurrentRestaurant.foodList = foods;
                        }
                    }
                    DataWork.dataBase.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Entry","",MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }

}
