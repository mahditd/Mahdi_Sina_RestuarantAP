using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sina_Mahdi_RestaurantAP
{
    class Restaurant
    {
        private string username;

        public string USERNAME
        {
            get { return username; }
        }
        private string password;

        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        private List<Food> foodList = new List<Food>();

        public List<Food> FOODLIST { get { return foodList; } }


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

        private List<Reserve> ReserveList = new List<Reserve>();

        public List<Reserve> RESERVELIST { get { return ReserveList; } }

        public Restaurant(string username, string password, string name, string address)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.address = address;

        }


    }
}
