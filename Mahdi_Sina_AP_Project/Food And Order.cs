using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum PaymentMethod { Online, OnDelivery }


namespace Sina_Mahdi_RestaurantAP
{
    class Food
    {
        private string name;

        private double price;

        private float rate;  // from 0 to 5

        private string imagePath;

        private Restaurant restaurant;

        private string ingredients;


        public Food(string name, double price, float rate, string imagePath, Restaurant restaurant, string ingredients)
        {
            this.name = name;
            this.price = price;
            this.rate = rate;
            this.imagePath = imagePath;
            this.restaurant = restaurant;
            this.ingredients = ingredients;

        }
    }
    class Order : Food
    {
        public DateTime orderDateTime = new DateTime();

        PaymentMethod method;
        public Order(string name, double price, float rate, string imagePath, Restaurant restaurant, string ingredients, PaymentMethod method)
            : base(name, price, rate, imagePath, restaurant, ingredients)
        {
            this.orderDateTime = DateTime.Now;
            this.method = method;
        }

    }
}
