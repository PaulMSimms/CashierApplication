using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return total_price;
        }

        public void SetPayment(double amount)
        {
            
        }
    }

    class DiscountItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            discounted_price = discount;
        }

        public double GetChange()
        {
            return change;
        }
    }
}
