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

namespace Mahdi_Sina_AP_Project
{

    public enum Gender { male, female }

    public enum subscribtion { bronze, silver, gold }
    class Customer : User
    {

        private string email;

        public string EMAIL { get { return email; } set { email = value; } }

        private string name;

        public string NAME { get { return name; } set { name = value; } }


        private string phoneNumber;

        public string PHONENUMBER { get { return phoneNumber; } set { phoneNumber = value; } }

        //is optional
        private string postalCode;
        //is optional
        public string POSTALCODE { get { return postalCode; } set { postalCode = value; } }

        private List<Order> orderList = new List<Order>();

        public List<Order> OrderList { get { return orderList; } set { orderList = value; } }


        public List<Comment> comments = new List<Comment>();

        public List<Complaint> complaints = new List<Complaint>();

        public subscribtion subscribtion;
        static List<Customer> customers = new List<Customer>();

        public Customer(string username, string password, string email, string name, string phoneNumber, string postalCode) : base(username, password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.postalCode = postalCode;
            this.email = email;
            subscribtion = subscribtion.bronze;

        }
        public static int AddNewCustomer(string _username, string _password, string _email, string _name, string _phoneNumber, string _postalCode, string _confirmPassword, Window parent)
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

        public static bool EmailConfirmed { get; set; } = false;







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