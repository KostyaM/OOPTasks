using System;
using System.Collections.Generic;
using System.Text;

namespace Hreby1
{
    class OrderItem
    {
        private ProductItem productItem;
        private int count;

        public OrderItem(ProductItem productItem)
        {
            this.productItem = productItem;
            this.count = 1;
        }

        public ProductItem GetProductItem() {
            return productItem;
        }

        public double GetPrice() {
            return productItem.GetPrice() * count;
        }

        public void AddItem() {
            count++;
        }

        public int RemoveItem() {
            count--;
            return count;
        }

        public String GetTitle() {
            return productItem.GetName() + " (" + count + ")" + "\t $" + GetPrice();
        }

        public int GetCount()
        {
            return count;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   EqualityComparer<ProductItem>.Default.Equals(productItem, item.productItem);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(productItem);
        }
    }
}
