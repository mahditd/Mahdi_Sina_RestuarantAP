
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
           
            var foodNames = DataWork.CurrentRestaurant.foodList.Select(x => x.NAME + SpaceMaker(x.NAME));
            myListBox.ItemsSource = foodNames;
            DataContext = this;
            ChangeImageButton.Visibility = Visibility.Hidden;
            MyImage.Visibility = Visibility.Hidden;
            MyDeleteButton.Visibility = Visibility.Hidden;
           
            TextBox1.Visibility = Visibility.Hidden;
            TextBox2.Visibility = Visibility.Hidden;
            TextBox3.Visibility = Visibility.Hidden;
            MySaveButton.Visibility = Visibility.Hidden;
          
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
       
        public Food ChosenFood;

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
            int x = DataWork.CurrentRestaurant.foodList.Count;
            for (int i = 0;i < x; i++)
            {
                
                if (myListBox.SelectedItem.ToString().Contains(DataWork.CurrentRestaurant.foodList[i].NAME))
                {
                    ChosenFood = DataWork.CurrentRestaurant.foodList[i];
                    SetImage(ChosenFood.IMAGEPATH);
                    TextBox1.Text = DataWork.CurrentRestaurant.foodList[i].Price.ToString();
                    TextBox2.Text = DataWork.CurrentRestaurant.foodList[i].RATE.ToString();
                    TextBox3.Text = DataWork.CurrentRestaurant.foodList[i].INGREDIENTS.ToString();

                    var foodNames = DataWork.CurrentRestaurant.foodList.Select(x => x.NAME + SpaceMaker(x.NAME));
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
                MySaveButton.Visibility = Visibility.Visible;
                TextBox1.Visibility = Visibility.Visible;
                TextBox2.Visibility = Visibility.Visible;
                TextBox3.Visibility = Visibility.Visible;
               

            }
            else
            {
                ChangeImageButton.Visibility = Visibility.Hidden;
                MyImage.Visibility = Visibility.Hidden;
                MyDeleteButton.Visibility = Visibility.Hidden;
                MySaveButton.Visibility = Visibility.Hidden;
                TextBox1.Visibility = Visibility.Hidden;
                TextBox2.Visibility = Visibility.Hidden;
                TextBox3.Visibility = Visibility.Hidden;
               

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
            for (int i = 0; i <DataWork.CurrentRestaurant.foodList.Count; i++)
            {
                if(ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                {
                   MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this food?","",MessageBoxButton.YesNo,MessageBoxImage.Warning);
                    if(result == MessageBoxResult.Yes)
                    {
                        
                        List<Food> Foods = DataWork.CurrentRestaurant.foodList; 
                        Foods.RemoveAt(i);
                        DataWork.CurrentRestaurant.foodList = Foods;
                        DataWork.dataBase.SaveChanges();
                    }
                    
                }
            }
        }

        private void Comments_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new commentsPage_RestaurantPanel());
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
                
                
            }
            catch
            {
                MessageBox.Show("Invalid Entry","",MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
