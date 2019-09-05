using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Fixation.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(", Quantity : " + Quantity + ", Subtotal: $" + SubTotal());
            return s.ToString();
        }
    }
}
