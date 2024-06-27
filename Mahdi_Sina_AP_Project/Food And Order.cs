using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
public enum PaymentMethod { Online, OnDelivery }


namespace Sina_Mahdi_RestaurantAP
{
    class Food
    {
        private string name;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private float rate;  // from 0 to 5

        public float RATE
        {
            get { return rate; }
            set { if (value <= 5 && value >= 0) rate = value; }
        }

        private string imagePath;

        public string IMAGEPATH
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private Restaurant restaurant;

        public Restaurant RESTAURANT
        {
            get { return restaurant; }
            set {  restaurant = value; }
        }

        private string ingredients;

        public string INGREDIENTS
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        private int foodCount;

        public int FOODCOUNT
        {
            get { return foodCount; }
            set { foodCount = value; }
        }


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
        private DateTime orderDateTime = new DateTime();

        private PaymentMethod method;

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

        private List<Comment> Comments = new List<Comment>();

        public List<Comment> COMMENTS
        {
            get { return Comments; }
        }
        public Order(string name, double price, float rate, string imagePath, Restaurant restaurant, string ingredients, PaymentMethod method)
            : base(name, price, rate, imagePath, restaurant, ingredients)
        {
            this.orderDateTime = DateTime.Now;
            this.method = method;
        }

    }
}
