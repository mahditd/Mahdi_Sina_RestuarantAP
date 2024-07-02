using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Mahdi_Sina_AP_Project
{

    public enum Gender { male, female }

    public enum Subscribtion { bronze, silver, gold }
    public class Customer : User
    {
        public static Customer currentCustomer;

        private string email;
        
        public string EMAIL { get { return email; } set { email = value; } }//dataBase

        private string name;

        public string NAME { get { return name; } set { name = value; } }//dataBase


        private string phoneNumber { get; set; } //dataBase

        public string PHONENUMBER { get { return phoneNumber; } set { phoneNumber = value; } }//dataBase

        //is optional
        private string postalCode;
        //is optional
        public string POSTALCODE { get { return postalCode; } set { postalCode = value; } }//dataBase

        public string orderlistjson { get; set; }

        [NotMapped]
        public List<Order> ORDERS { get => listConverter(orderlistjson) ; set => orderlistjson = stringConverter(value); }//changing orderlistjson
        //Methods for converting list orders to json string

        List<Order> listConverter(string orderStr)
        {
            if (orderlistjson == null || orderlistjson == "")
            {
                return new List<Order>();
            }
            return JsonSerializer.Deserialize<List<Order>>(orderStr);
        }
        string stringConverter(List<Order> list)
        {
            return JsonSerializer.Serialize(list);
        }
        //Methods for converting list comments to json string

        List<Comment> listConverterToComment(string orderStr)
        {
            if (orderlistjson == null)
            {
                return new List<Comment>();
            }
            return JsonSerializer.Deserialize<List<Comment>>(orderStr);
        }

        string stringConverterToComment(List<Comment> list)
        {
            return JsonSerializer.Serialize(list);
        }

        public string commentJson { get; set; }//dataBase
        [NotMapped]
        public List<Comment> COMMENTS { get => listConverterToComment(commentJson); set => commentJson = stringConverterToComment(value); }
        List<Complaint> listConverterToComplaint(string orderStr)
        {
            if (orderlistjson == null)
            {
                return new List<Complaint>();
            }
            return JsonSerializer.Deserialize<List<Complaint>>(orderStr);
        }

        string stringConverterToComplaint(List<Complaint> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public string complaintJson { get; set; }
        [NotMapped]
        public List<Complaint> COMPLAINTS { get => listConverterToComplaint(complaintJson); set => stringConverterToComplaint(value); }

        public int subscribtion { get; set; }//must be casted every time

        //Methods for converting list customer to json string
        static List<Customer> listConverterToCustomer(string orderStr)
        {
            if (customersJson == null)
            {
                return new List<Customer>();
            }
            return JsonSerializer.Deserialize<List<Customer>>(orderStr);
        }
       static string stringConverterToCustomer(List<Customer> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public static string customersJson { get; set; }
        [NotMapped]
        static List<Customer> customers { get => listConverterToCustomer(customersJson); set => customersJson= stringConverterToCustomer(value); }




        public Customer() { }
        public Customer(string username, string password, string email, string name, string phoneNumber, string postalCode) : base(username, password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.postalCode = postalCode;
            this.email = email;
            subscribtion = (int)(Subscribtion.bronze);
            EmailConfirmed = false;
            customersJson = "";
            orderlistjson = "";
            commentJson = "";
            complaintJson = "";

        }
        public static int AddNewCustomer(string _username, string _password, string _email, string _name, string _phoneNumber, string _postalCode, string _confirmPassword, Page parent)
        {

            //checking for repetition in username
            if (_username == "" || _password == "" || _email == "" || _name == "" || _phoneNumber == "" || _confirmPassword == "")
            {
                MessageBox.Show("fill all fields (postal code is optional)", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }


            if (customers.FirstOrDefault(x => x.username == _username) == null)
            {
                if (_password != _confirmPassword)
                {
                    MessageBox.Show("confirm password field does not match with password", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
                if (!ValidateEmail(_email))
                {
                    MessageBox.Show("Enter a valid email", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
                int verifyCode = SendVerificationEmail(_email);
                if (verifyCode != 0)//when it will be 0??
                {
                    Window window = new Confirming_email(verifyCode.ToString(), parent);
                    window.ShowDialog();
                }
                if (EmailConfirmed)
                {
                    customers.Add(new Customer(_username, _password, _email, _name, _phoneNumber, _postalCode));
                    MessageBox.Show("successfully added the new user");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Wrong verify code", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
            }

            MessageBox.Show("repetitious userName", "", MessageBoxButton.OK, MessageBoxImage.Error);
            return 0;
        }

        public static bool EmailConfirmed { get; set; }







        public static bool ValidateEmail(string Email_Address)
        {
            //I have doubt in this pattern but its ok for now
            string reg_pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(reg_pattern);
            return regex.IsMatch(Email_Address);
        }

        public static int SendVerificationEmail(string CustomerEmail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("restaurantapproject@gmail.com");
                mail.To.Add(CustomerEmail);
                mail.Subject = "Verification Code";

                Random random = new Random();
                int verifyCode = random.Next(100000, 999999);

                mail.Body = "Your Vertification Code is " + verifyCode.ToString();


                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("restaurantapproject@gmail.com", "sxzl vjzv zlmx ntnb");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return verifyCode;
            }
            catch
            {
                MessageBox.Show("couldn't send the verification", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
        }
    }
}