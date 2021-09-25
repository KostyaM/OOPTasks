using System;
using System.Windows.Forms;
using System.Numerics;
using System.Collections.Generic;

namespace Hreby1
{
    public partial class Form1 : Form
    {

        private ProductItem[] items = new ProductItem[]
        {
            new ProductItem(0, "Продукт 1", 10.00),
            new ProductItem(1, "Продукт 2", 12.49),
            new ProductItem(1, "Продукт 3", 20.99),
            new ProductItem(1, "Продукт 4", 10.23),
            new ProductItem(1, "Продукт 5", 5.00),
            new ProductItem(1, "Продукт 6", 2.03)
        };

        private List<OrderItem> orderItems = new List<OrderItem>();

        private int orderListIndex = -1;
        private int menuListIndex = -1;




        public Form1()
        {
            InitializeComponent();
            foreach (ProductItem item in items) {
                checkedListBox1.Items.Add(item.GetName() + " $" + item.GetPrice());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menuListIndex == -1) {
                ShowMessage("Menu element not selected!");
                return;
            }
            var selectedProduct = items[menuListIndex];
            var orderListIndex = -1;
            for (int i = 0; i < orderItems.Count; i++) {
                if (orderItems[i].GetProductItem() == selectedProduct) {
                    orderListIndex = i;
                    break;
                }
            }
            if (orderListIndex == -1)
            {
                var orderItem = new OrderItem(selectedProduct);
                orderItems.Add(orderItem);
                checkedListBox2.Items.Add(orderItem.GetTitle());
            }
            else {
                orderItems[orderListIndex].AddItem();
                checkedListBox2.Items[orderListIndex] = orderItems[orderListIndex].GetTitle();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (orderListIndex == -1 || orderItems.Count == 0) {
                ShowMessage("Element not selected");
                return;
            }

            var orderItem = orderItems[orderListIndex];
            if (orderItem.RemoveItem() == 0)
            {
                orderItems.RemoveAt(orderListIndex);
                checkedListBox2.Items.RemoveAt(orderListIndex);
            }
            else {
                checkedListBox2.Items[orderListIndex] = orderItem.GetTitle();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0) {
                ShowMessage("Order list is empty");
                return;
            }
            var sum = 0.00;
            foreach (OrderItem item in orderItems) {
                sum += item.GetPrice();
            }
            ShowMessage("Your charged summ is: $" + Math.Round(sum, 2) + "\nBon appetit!");
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuListIndex = checkedListBox1.SelectedIndex;
        }


        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderListIndex = checkedListBox2.SelectedIndex;
        }

        private void ShowMessage(String message) {

            MessageBox.Show(message, "Ресторан «Студент»",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
