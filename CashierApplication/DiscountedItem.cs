using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    class DiscountedItem : Item
    {
        private double ItemDiscount;
        private double DiscountedPrice;
        private double PaymentAmount;
        private double Change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            ItemDiscount = discount;
        }

        public override double GetTotalPrice()
        {
            double SubTotal = ItemPrice * ItemQuantity;
            double DiscountAmount = SubTotal * (ItemDiscount / 100);
            DiscountedPrice = SubTotal - DiscountAmount;

            return DiscountedPrice;
        }


        public override void SetPayment(double Amount)
        {
            PaymentAmount = Amount;
        }

        public double GetChange()
        {
            Change = PaymentAmount - DiscountedPrice;
            return Change;
        }
    }
}
