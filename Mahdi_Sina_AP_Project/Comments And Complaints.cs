using Sina_Mahdi_RestaurantAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mahdi_Sina_AP_Project
{
    public class Comment
    {
        [JsonInclude]
        public string text;
        [JsonInclude]
        public List<string> replyedTexts = new List<string>();
        [JsonInclude]
        private Food relatedFood;
        [JsonInclude]
        public Food RELATEDFOOD { get { return relatedFood; } }
        [JsonInclude]
        private Customer relatedCustomer;
        [JsonInclude]
        public Customer RELATEDCUSTOMER { get { return relatedCustomer; } }
        [JsonInclude]
        private bool isEdited;
        [JsonInclude]
        public bool ISEDITED
        {
            get { return isEdited; }

            set { isEdited = value; }
        }

        [JsonInclude]
        private DateTime createdTime;

        [JsonInclude]
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
        [JsonInclude]
        public string text;

        [JsonInclude]
        public string? replyedText;

        [JsonInclude]
        private Order relatedOrder;

        [JsonInclude]
        public Order RELATEDORDER { get { return relatedOrder; } }

        [JsonInclude]
        private Customer relatedCustomer;

        [JsonInclude]
        public Customer RELATEDCUSTOMER { get { return relatedCustomer; } }

        [JsonInclude]
        private bool isChecked;

        public bool ISCHECKED
        {
            get { return isChecked; }

            set { isChecked = value; }
        }

        [JsonInclude]
        private DateTime createdTime;

        [JsonInclude]
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
