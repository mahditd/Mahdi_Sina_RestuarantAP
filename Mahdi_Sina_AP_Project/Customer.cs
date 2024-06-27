using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{

    public enum Gender { male , female }

    public enum subscribtion {bronze , silver , gold }
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

        public List<Order> OrderList { get {  return orderList; } set {  orderList = value; } }


        public List<Comment> comments = new List<Comment>();

        public List<Complaint> complaints = new List<Complaint>();

        public subscribtion subscribtion;
        static List<Customer> customers = new List<Customer>();
            
        public Customer(string username, string password, string email, string name, string phoneNumber, string postalCode): base(username,password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.postalCode = postalCode;
            this.email = email;
            subscribtion = subscribtion.bronze;
            
        }
        public static bool AddNewCustomer(string _username, string _password, string _email, string _name, string _phoneNumber, string _postalCode)
        {
            //checking for repetition
            if (customers.FirstOrDefault(x => x.username == _username) == null)
            {
                customers.Add(new Customer(_username, _password, _email, _name, _phoneNumber, _postalCode));
                return true;
            }
            return false;
        }






    }
}