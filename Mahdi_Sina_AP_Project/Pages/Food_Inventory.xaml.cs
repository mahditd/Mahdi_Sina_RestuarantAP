
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Mahdi_Sina_AP_Project.Pages
{
    /// <summary>
    /// Interaction logic for Food_Inventory.xaml
    /// </summary>
    public partial class Food_Inventory : Page
    {
        private ImageSource imagePath;

        public ImageSource IMAGEPATH
        {
            get { return imagePath; }
            set
            {
                imagePath = value;

                Image.Source = imagePath;
            }
        }
        private string shortPath;
        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged();
                Image.Source = converter(_imagePath);
            }
        }

        public ImageSource converter(string path)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path, UriKind.Absolute); //in dahane mano servis kard
            bitmap.EndInit();
            return bitmap;
        }
        private void SetImage(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();
            IMAGEPATH = bitmap;
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
            Image.Visibility = Visibility.Hidden;
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
                    TextBox1.Text = DataWork.CurrentRestaurant.foodList[i].Price.ToString();
                    TextBox2.Text = DataWork.CurrentRestaurant.foodList[i].RATE.ToString();
                    TextBox3.Text = DataWork.CurrentRestaurant.foodList[i].INGREDIENTS.ToString();
                    SetImage(ChosenFood.IMAGEPATH);
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
                Image.Visibility = Visibility.Visible;
                MyDeleteButton.Visibility = Visibility.Visible;
                MySaveButton.Visibility = Visibility.Visible;
                TextBox1.Visibility = Visibility.Visible;
                TextBox2.Visibility = Visibility.Visible;
                TextBox3.Visibility = Visibility.Visible;
               

            }
            else
            {
                ChangeImageButton.Visibility = Visibility.Hidden;
                Image.Visibility = Visibility.Hidden;
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
            string imagePath;//it is short for the Food Inventory class
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path
                string sourceFilePath = openFileDialog.FileName;

                // Define the target folder and file name
                string targetFolder = @"C:\Users\mahditd\source\repos\Mahdi_Sina_RestuarantAP\Mahdi_Sina_AP_Project\food_photos\"; // Local must change
                string fileName = System.IO.Path.GetFileName(sourceFilePath);
                string targetFilePath = System.IO.Path.Combine(targetFolder, fileName);

                // Ensure the target folder exists
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                // Copy the selected file to the target folder
                File.Copy(sourceFilePath, targetFilePath, true);
                shortPath = "\\food_photos\\" + fileName;
                ImagePath = sourceFilePath;
                ChosenFood.IMAGEPATH = shortPath;
                List<Food> Foods = DataWork.CurrentRestaurant.foodList;
                for(int i = 0;i < Foods.Count;i++)
                {
                    if (Foods[i].NAME == ChosenFood.NAME)
                    {
                        Foods[i] = ChosenFood;
                        DataWork.CurrentRestaurant.foodList = Foods;
                        break;
                    }
                }
                

                // Optional: Inform the user
                MessageBox.Show("Image copied to " + targetFilePath);
            }
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
    }

}
