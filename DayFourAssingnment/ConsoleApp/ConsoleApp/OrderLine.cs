using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class OrderLine
    {
        public OrderLine(int quantity, decimal unitPrice, float discount)
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
            Discount = discount;
        }

        public int Quantity { get; }

        public decimal UnitPrice { get; }

        public float Discount { get; }

        public decimal Total
        {
            get
            {
                return Quantity * UnitPrice * (decimal)(1.0f - Discount);
            }
        }

        public OrderLine WithQuantity(int value)
        {
            return value == Quantity
                    ? this
                    : new OrderLine(value, UnitPrice, Discount);
        }

        public OrderLine WithUnitPrice(decimal value)
        {
            return value == UnitPrice
                    ? this
                    : new OrderLine(Quantity, value, Discount);
        }

        public OrderLine WithDiscount(float value)
        {
            double TOLERANCE = 0;
            return Math.Abs(value - Discount) < TOLERANCE
                    ? this
                    : new OrderLine(Quantity, UnitPrice, value);
        }
    }
}
