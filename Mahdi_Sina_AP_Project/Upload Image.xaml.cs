using System;
using System.IO;
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
using Microsoft.Win32;

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for Upload_Image.xaml
    /// </summary>
    public partial class Upload_Image : Window
    {
        public BitmapImage SelectedImage { get; private set; }
        Pages.Food_Inventory Food_Inventory;
        public Upload_Image(Pages.Food_Inventory foodInventory)
        {
            InitializeComponent();
            Food_Inventory = foodInventory;
        }

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(openFileDialog.FileName);
                bitmap.EndInit();
                PreviewImage.Source = bitmap;
                SelectedImage = bitmap;
            }

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void SaveImageButton_Click(object sender, RoutedEventArgs e)
        {
            if (PreviewImage.Source != null)
            {
                //SaveFileDialog saveFileDialog = new SaveFileDialog();
                //saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
                //if (saveFileDialog.ShowDialog() == true)
                //{
                //string filePath = saveFileDialog.FileName;
                //SaveImageToFile((BitmapImage)PreviewImage.Source, filePath);
                //inja bayad basheh?
                Food_Inventory.ChosenFood.IMAGEPATH = "C:/Users/mahditd/source/repos/Mahdi_Sina_RestuarantAP/Mahdi_Sina_AP_Project/food_photoschickenburger.jpg";
                Food_Inventory.ImagePath = (PreviewImage.Source);
                //}
            }
            else
            {
                MessageBox.Show("No image to save", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string ConvertImageSourceToString(ImageSource imageSource)
        {
            if (imageSource is BitmapImage bitmapImage && bitmapImage.UriSource != null)
            {
                return bitmapImage.UriSource.LocalPath;
            }
            return null;
        }
        
    }
}
