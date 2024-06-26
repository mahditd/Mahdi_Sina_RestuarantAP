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
        private string username { get; }
        private string password { get; }
        private List<Food> foodList { get; set; }
        private bool canReserve { get; set; } //completing the get method later

        private string name { get; set; }

        private int rate { get; set; } //from 0 to 5

        private List<Order> orderList { get; set; }

        private string address { get; set; }

        private List<Reserve> ReserveList { get; set; }

        public Restaurant(string username, string password, string name, string address)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.address = address;

        }


    }
}
