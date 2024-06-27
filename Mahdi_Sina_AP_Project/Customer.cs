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

        private string? postalCode;

        public string? POSTALCODE { get { return postalCode; } set { postalCode = value; } }

        private List<Order> orderList = new List<Order>();

        public List<Order> OrderList { get {  return orderList; } set {  orderList = value; } }


        public List<Comment> comments = new List<Comment>();

        public List<Complaint> complaints = new List<Complaint>();

        public subscribtion subscribtion;

        public Customer(string username, string password, string email, string name, string phoneNumber, string? postalCode): base(username,password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.postalCode = postalCode;
            this.email = email;
            subscribtion = subscribtion.bronze;
            
        }






    }
}