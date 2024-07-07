using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    public class DataWork
    {
        public static DataBase dataBase = new DataBase();

        public static Customer CurrentCustomer = new Customer();
        public static Restaurant CurrentRestaurant = new Restaurant();
        public static Admin CurrentAdmin = new Admin();
    }
}
