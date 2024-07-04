﻿using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    public class Comment
    {
        public string text;
        
        public List<string> replyedTexts = new List<string>();


        private Food relatedFood;

        public Food RELATEDFOOD { get { return relatedFood; } }

        private Customer relatedCustomer;

        public Customer RELATEDCUSTOMER { get { return relatedCustomer; } }

        private bool isEdited;

        public bool ISEDITED
        {
            get { return isEdited; }

            set { isEdited = value; }
        }

        private DateTime createdTime;

        public DateTime CREATEDTIME { get { return createdTime; } }

        public Comment() { }
        public Comment(string Text, Food RelatedFood, Customer RelatedCustomer)
        {
            this.text = Text;
            this.relatedFood = RelatedFood;
            this.relatedCustomer = RelatedCustomer;
            createdTime = DateTime.Now;
            isEdited = false;
        }

        public void Edit(string newText)
        {
            this.text = newText;
            isEdited = true;
        }

        public void Reply(string replyText)
        {
            replyedTexts.Add(replyText);
        }


    }

    public class Complaint
    {
        public string text;

        public string? replyedText;

        private Order relatedOrder;

        public Order RELATEDORDER { get { return relatedOrder; } }

        private Customer relatedCustomer;

        public Customer RELATEDCUSTOMER { get { return relatedCustomer; } }

        private bool isChecked;

        public bool ISCHECKED
        {
            get { return isChecked; }

            set { isChecked = value; }
        }

        private DateTime createdTime;

        public DateTime CREATEDTIME { get { return createdTime; } }

        public Complaint() { }
        public Complaint(string Text, Order RelatedOrder, Customer RelatedCustomer)
        {
            this.text = Text;
            this.relatedOrder = RelatedOrder;
            this.relatedCustomer = RelatedCustomer;
            replyedText = null;
            createdTime = DateTime.Now;
            isChecked = false;
        }

        public void Check()
        {
            isChecked = true;
        }

        public void reply(string ReplyText)
        {
            this.replyedText = ReplyText;
        }






    }
}
