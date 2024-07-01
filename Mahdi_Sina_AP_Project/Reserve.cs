using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    public class Reserve
    {
        public Customer Customer;

        public Restaurant Restaurant;

        private DateTime reserveTime;

        public DateTime RESERVETIME { get {  return reserveTime; } set {  reserveTime = value; } }

        public Reserve() { }
        public Reserve(Customer customer, Restaurant restaurant, DateTime reserveTime)
        {
            Customer = customer;
            Restaurant = restaurant;
            this.reserveTime = reserveTime;
        }
    }
}
