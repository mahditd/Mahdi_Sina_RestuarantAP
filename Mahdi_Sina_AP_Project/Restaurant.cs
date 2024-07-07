using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sina_Mahdi_RestaurantAP
{
    public class Restaurant : User
    {

        public static Restaurant currentRestaurant;
        List<Food> listConverterToRestaurant(string str)
        {
            if (str == null)
            {
                return new List<Food>();
            }
            return JsonSerializer.Deserialize<List<Food>>(str);
        }

        string stringConverterToRestaurant(List<Food> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public string foodListJson { get; set; }//dataBase
        [NotMapped]
        public List<Food> foodList {
            get =>  listConverterToRestaurant(foodListJson);
            set {
                foodListJson = stringConverterToRestaurant(value); 
                var x = new Customer(); 
            }

        }
        [NotMapped]
        public string Color { get; set; }



        public bool canReserve { get; set; }//dataBase
        [NotMapped]
        public bool CanReserve
        {
            get { return canReserve; }
            set { if (rate >= 4) { canReserve = value; } else { canReserve = false; } }
        }

        public string Name { get; set; }//dataBase //changed to public may cause error?


        public float rate { get; set; } //from 0 to 5 dataBase
        [NotMapped]
        public float Rate
        {
            get { return rate; }
            set { if(value<=5 && value >= 0)  rate = value; }
        }

        List<Order> listConverterToOrder(string str)
        {
            if (str == null)
            {
                return new List<Order>();
            }
            return JsonSerializer.Deserialize<List<Order>>(str);
        }

        string stringConverterToOrder(List<Order> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public string orderList { get; set; }//dataBase
        [NotMapped]
        public List<Order> ORDERLIST { 
            get => listConverterToOrder(orderList); 
            set => orderList = stringConverterToOrder(value); }


        public string Address { get; set; }//dataBase
 
        List<Reserve> listConverterToReserve(string str)
        {
            if (str == null)
            {
                return new List<Reserve>();
            }
            return JsonSerializer.Deserialize<List<Reserve>>(str);
        }

        string stringConverterToReserve(List<Reserve> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public string reserveList { get; set; }//dataBase
        [NotMapped]
        public List<Reserve> ReserveList { get => listConverterToReserve(reserveList); set => reserveList = stringConverterToReserve(value); }

        public void refreshRate()
        {
            float RateAverage = 0;
            int indexHolder1 = 0;
            int indexHolder2 = 0;
            for (int i = 0; i < ORDERLIST.Count; i++)
            {
                RateAverage += ORDERLIST[i].RATE;
                indexHolder1 = ORDERLIST.Count;
            }
            for (int i = 0; i < foodList.Count; i++)
            {
                RateAverage += foodList[i].RATE;
                indexHolder2 = foodList.Count;
            }
            RateAverage /= (indexHolder1 + indexHolder2);
            rate = RateAverage;
           
        }

        public Restaurant() { }
        public Restaurant(string username, string password, string name, string address) : base(username, password)
        {
           
            Name = name;
            Address= address;
            CanReserve = false;
            canReserve = false;
            ORDERLIST = new List<Order>();
            ReserveList = new List<Reserve>();
            foodList = new List<Food>();
        }


    }
}
