using System;
using System.Collections.Generic;
using System.Text;

namespace Hreby1
{
    class ProductItem
    {
        private int id;
        private String name;
        private double price;

        public ProductItem(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public String GetName() {
            return name;
        }

        public int GetId() {
            return id;
        }

        public double GetPrice() {
            return price;
        }

        public override bool Equals(object obj)
        {
            return obj is ProductItem item &&
                   id == item.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
