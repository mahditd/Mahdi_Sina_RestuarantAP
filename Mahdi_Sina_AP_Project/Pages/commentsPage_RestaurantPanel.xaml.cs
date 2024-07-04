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
    /// Interaction logic for commentsPage_RestaurantPanel.xaml
    /// </summary>
    public partial class commentsPage_RestaurantPanel : Page
    {
        public Order ChosenOrder;

        public Comment ChosenComment;
        public commentsPage_RestaurantPanel()
        {
            InitializeComponent();
            

            myListBox2.Visibility = Visibility.Hidden;
            myListBox3.Visibility = Visibility.Hidden;
            var CommentTexts = DataWork.CurrentRestaurant.ORDERLIST.Select(x => x.NAME);
            myListBox1.ItemsSource = CommentTexts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0; i < DataWork.CurrentRestaurant.ORDERLIST.Count(); i++)
            {
                if (DataWork.CurrentRestaurant.ORDERLIST[i].NAME.Contains(myListBox1.SelectedItem.ToString()))
                {
                    ChosenOrder = DataWork.CurrentRestaurant.ORDERLIST[i];
                    myListBox2.ItemsSource = DataWork.CurrentRestaurant.ORDERLIST[i].Comments.Select(x => x.text);
                    myListBox2.Visibility=Visibility.Visible;
                   

                }
            }
        }

 
        private void myListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for(int i = 0;i < ChosenOrder.Comments.Count(); i++)
            {
                if (ChosenOrder.Comments[i].text.Contains(myListBox2.SelectedItem.ToString()))
                {
                    ChosenComment = ChosenOrder.Comments[i];
                    myListBox3.ItemsSource = ChosenOrder.Comments[i].replyedTexts.Select(x => x);
                    myListBox3.Visibility=Visibility.Visible;


                }
            }
        }

        private void myListBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Cofirm_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenComment != null)
            {
                if (TextBox.Text.Length > 0)
                {
                    ChosenComment.replyedTexts.Add(TextBox.Text.ToString());
                }
            }
            else
            {
                MessageBox.Show("Select a comment first");
            }
        }
    }
}
