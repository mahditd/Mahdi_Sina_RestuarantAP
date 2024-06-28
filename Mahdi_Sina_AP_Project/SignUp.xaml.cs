﻿using System;
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

namespace Mahdi_Sina_AP_Project
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            int result = Customer.AddNewCustomer(userName.txtBox.Text, password.txtBox.Text, email.txtBox.Text, name.txtBox.Text, phoneNumber.txtBox.Text, postalCode.txtBox.Text, passwordConfirm.txtBox.Text);
            if (result == 1)
            {
                this.Close();
            }
            else if (result == 0)
            {
                //waiting for editing the informations
            }
            else 
            {
                //it is not used but let's keep it
                userName.txtBox.Text = "";
                password.txtBox.Text = "";
                passwordConfirm.txtBox.Text = "";
                email.txtBox.Text = "";
                name.txtBox.Text = "";
                phoneNumber.txtBox.Text = "";
                postalCode.txtBox.Text = "";


            }
        }
    }
}
