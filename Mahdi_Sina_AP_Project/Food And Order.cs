using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
public enum PaymentMethod { Online, OnDelivery }


namespace Sina_Mahdi_RestaurantAP
{
    public class Food
    {
        [JsonInclude]

        private string name;
        [JsonInclude]

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        [JsonInclude]

        private double price;
        [JsonInclude]

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        [JsonInclude]

        private float rate;  // from 0 to 5
        [JsonInclude]

        public float RATE
        {
            get { return rate; }
            set { if (value <= 5 && value >= 0) rate = value; }
        }
        [JsonInclude]

        private string imagePath;
        [JsonInclude]

        public string IMAGEPATH
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        [JsonInclude]

        private Restaurant restaurant;
        [JsonInclude]

        public Restaurant RESTAURANT
        {
            get { return restaurant; }
            set {  restaurant = value; }
        }
        [JsonInclude]

        private string ingredients;
        [JsonInclude]

        public string INGREDIENTS
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        [JsonInclude]

        private int foodCount;
        [JsonInclude]

        public int FOODCOUNT
        {
            get { return foodCount; }
            set { foodCount = value; }
        }

        public Food() { }
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
    public class Order : Food
    {
        [JsonInclude]
        private DateTime orderDateTime = new DateTime();
        [JsonInclude]
        private PaymentMethod method;
        [JsonInclude]
        public PaymentMethod METHOD
        {
            get
            {
                return method;
            }
            set
            {
                method = value;
            }
        }
        [JsonInclude]
        public List<Comment> Comments = new List<Comment>();



        public Order() { }
        public Order(string name, double price, float rate, string imagePath, Restaurant restaurant, string ingredients, PaymentMethod method)
            : base(name, price, rate, imagePath, restaurant, ingredients)
        {
            this.orderDateTime = DateTime.Now;
            this.method = method;
        }

    }
}
