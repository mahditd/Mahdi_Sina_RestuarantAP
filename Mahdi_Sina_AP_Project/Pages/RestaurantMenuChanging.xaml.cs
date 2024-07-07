using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for RestaurantMenuChanging.xaml
    /// </summary>
    public partial class RestaurantMenuChanging : Page
    {

        private string _editableText;
        public RestaurantMenuChanging()
        {
            InitializeComponent();

            var foodNames = DataWork.CurrentRestaurant.foodList.Select(x => x.NAME +SpaceMaker(x.NAME));
            myListBox.ItemsSource = foodNames;
            DataContext = this;
            if (ChosenFood != null)
            {
                EditableText = ChosenFood.FOODCOUNT.ToString();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

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



           
            int x = DataWork.CurrentRestaurant.foodList.Count;
            for (int i = 0; i < x; i++)
            {

                if (myListBox.SelectedItem.ToString().Contains(DataWork.CurrentRestaurant.foodList[i].NAME))
                {
                    ChosenFood = DataWork.CurrentRestaurant.foodList[i];
                    

                    var foodNames = DataWork.CurrentRestaurant.foodList.Select(x => x.NAME + SpaceMaker(x.NAME));
                    myListBox.ItemsSource = foodNames;
                    MyTextBox.Text = ChosenFood.FOODCOUNT.ToString();


                    break;
                }
                else
                {
                    ChosenFood = null;
                }
            }
            

        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            if(ChosenFood!= null)
            {
                int count = int.Parse(MyTextBox.Text);
                count++;
                MyTextBox.Text = count.ToString();
                ChosenFood.FOODCOUNT = count;
                ChosenFood.FOODCOUNT = count;
                for (int i = 0; i < DataWork.CurrentRestaurant.foodList.Count; i++)
                {
                    if (ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                    {
                        List<Food> foods = DataWork.CurrentRestaurant.foodList;
                        foods[i].FOODCOUNT = count;
                        DataWork.CurrentRestaurant.foodList = foods;

                    }
                }
                DataWork.dataBase.SaveChanges();
            }
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (ChosenFood != null)
            {
                
                    int count = int.Parse(MyTextBox.Text);
                if (count > 0)
                {
                    count--;
                    MyTextBox.Text = count.ToString();
                    ChosenFood.FOODCOUNT = count;
                    for (int i = 0; i < DataWork.CurrentRestaurant.foodList.Count; i++)
                    {
                        if (ChosenFood.NAME == DataWork.CurrentRestaurant.foodList[i].NAME)
                        {
                            List<Food> foods = DataWork.CurrentRestaurant.foodList;
                            foods[i].FOODCOUNT = count;
                            DataWork.CurrentRestaurant.foodList = foods;

                        }
                    }
                    DataWork.dataBase.SaveChanges();
                }
                else
                {
                    MessageBox.Show("There is no food to remove"," ",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
    }
}
