using Microsoft.Win32;
using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace Mahdi_Sina_AP_Project.Pages.userControls
{
    /// <summary>
    /// Interaction logic for AddFood.xaml
    /// </summary>
    public partial class AddFood : UserControl
    {
        public AddFood()
        {
            InitializeComponent();
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


        private void ImportImage_Click(object sender, RoutedEventArgs e)
        {
            string Ingredients = ingradients.txtBox.Text;
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

                // Optional: Inform the user
                MessageBox.Show("Image copied to " + targetFilePath);
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            
            string Name = name.txtBox.Text;
            double Price;
            string RestaurantUsername = restaurantUserName.txtBox.Text;
            string Ingredients = ingradients.txtBox.Text;
            try
            {
                Price = double.Parse(price.txtBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter a number in the Price", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }
            if (Name == "" || ImagePath == null || RestaurantUsername == ""|| Ingredients == "")
            {
                MessageBox.Show("fill all the fields", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Restaurant restaurant = DataWork.dataBase.Restaurants.FirstOrDefault(x => x.USERNAME == RestaurantUsername);
                if (restaurant == null)
                {
                MessageBox.Show("enter a correct userN=name", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                List<Food> foods = restaurant.foodList;
                foods.Add(new Food(Name, Price, shortPath, restaurant, Ingredients));
                restaurant.foodList = foods;
                DataWork.dataBase.SaveChanges();
            }
        }


    }

}
