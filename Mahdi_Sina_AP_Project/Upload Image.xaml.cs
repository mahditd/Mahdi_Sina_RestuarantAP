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
        public Upload_Image()
        {
            InitializeComponent();
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
        private void UploadImageButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void SaveImageButton_Click(object sender, RoutedEventArgs e)
        {
            if (PreviewImage.Source != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;
                    SaveImageToFile((BitmapImage)PreviewImage.Source, filePath);
                }
            }
            else
            {
                MessageBox.Show("No image to save", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

         private void SaveImageToFile(BitmapImage bitmapImage, string filePath)
        {
            BitmapEncoder encoder;
            if (filePath.EndsWith(".jpg"))
            {
                encoder = new JpegBitmapEncoder();
            }
            else if (filePath.EndsWith(".png"))
            {
                encoder = new PngBitmapEncoder();
            }
            else
            {
                throw new NotSupportedException("File extension is not supported");
            }

            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                encoder.Save(fileStream);
            }
        }
    }
}
