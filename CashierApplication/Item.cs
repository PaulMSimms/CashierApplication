using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    class Item
    {
        protected string ItemName;
        protected double ItemPrice;
        protected int ItemQuantity;
        private double TotalPrice;

        public Item(string name, double price, int quantity)
        {
            this.ItemName = name;
            this.ItemPrice = price;
            this.ItemQuantity = quantity;
        }

        public virtual double GetTotalPrice()
        {
            TotalPrice = ItemPrice * ItemQuantity;
            return TotalPrice;
        }

        public virtual void SetPayment(double amount)
        {

        }
    }
}
