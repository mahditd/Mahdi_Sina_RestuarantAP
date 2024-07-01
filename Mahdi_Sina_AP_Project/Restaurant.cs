using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sina_Mahdi_RestaurantAP
{
    public class Restaurant : User
    {

        public static Restaurant currentRestaurant;
        
        public List<Food> foodList = new List<Food>();
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }



        private bool canReserve;

        public bool CANRESERVE
        {
            get { return canReserve; }
            set { if (rate >= 4) { canReserve = value; }}
        }

        private string name;

        public string NAME { 
            get { return name; }
            set { name = value; }
        }

        private int rate { get; set; } //from 0 to 5

        public int RATE
        {
            get { return rate; }
            set { if(value<=5 && value >= 0)  rate = value; }
        }

        private List<Order> orderList =new List<Order>();

        public List<Order> ORDERLIST { get { return orderList; } }

        private string address;

        public string ADDRESS
        {
            get { return address; }
            set {  address = value; }
        }

        public List<Reserve> ReserveList = new List<Reserve>();


        public Restaurant() { }
        public Restaurant(string username, string password, string name, string address) : base(username, password)
        {
           
            this.name = name;
            this.address = address;

        }


    }
}
