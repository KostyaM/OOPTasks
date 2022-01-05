using System;
using System.Windows.Forms;
using System.Numerics;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace Hreby1
{
    public partial class Form1 : Form
    {

        int productIndex = 0;
        private List<ProductItem> items = new List<ProductItem>();
      

        private List<OrderItem> orderItems = new List<OrderItem>();

        private int orderListIndex = -1;
        private int menuListIndex = -1;

        private string cuisineResourcesDir = Directory.GetCurrentDirectory()+"\\..\\cuisine";
        private string cuisineFile;


        public Form1()
        {
            InitializeComponent();
            SetOptions(false);
            LoadCuisines();
        }

        private void LoadCuisines()
        {
            if(!Directory.Exists(cuisineResourcesDir))
            {
                ShowMessage("Cuisine directory not found!");
                return;
            }
            CuisineItem.DropDownItems.Clear();
            foreach(string file in Directory.GetFiles(cuisineResourcesDir, "*.khm"))
            {
                var fileName = new FileInfo(file).Name;
                CuisineItem.DropDownItems.Add(fileName.Remove(fileName.Length - 4));
            }
        }

        private void CuisineItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SetAdditionalOptions(false);
            cuisineFile = cuisineResourcesDir + "\\" + e.ClickedItem.Text + ".khm";
            if(!new FileInfo(cuisineFile).Exists)
            {
                ShowMessage("Internal error! No cuisine data was found");
                SetOptions(false);
                return;
            }
            cuisineLabel.Text = e.ClickedItem.Text;
            UpdateProductList();
        }


        private void UpdateProductList() {
            checkedListBox1.Items.Clear();
            items.Clear();

            StreamReader f = new StreamReader(cuisineFile);
            var index = 0;
            while (!f.EndOfStream)
            {
                // Потому что нужен нормальный JSON а не plane text файл
                items.Add(new ProductItem(index, f.ReadLine(), 0));
                index++;
            }
            f.Close();
            foreach (ProductItem item in items)
            {
                checkedListBox1.Items.Add(item.GetName() + " $" + item.GetPrice());
            }
            SetAdditionalOptions(false);
            FileItem.Enabled = true;
            SetOptions(true);
        }

        private void SaveProductList()
        {
            StreamWriter f = new StreamWriter(cuisineFile, false);
            foreach(ProductItem item in items)
            {
                f.WriteLine(item.GetName());
            };
            f.Close();
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
            var price = Math.Round(sum, 2);
            ShowMessage("Your order was exported to " + exportOrder(price) + " directory. \nYour charged summ is: $" + price + "\nBon appetit!");
            Close();
        }

        private String exportOrder(double totalPrice)
        {
            var path = Directory.GetCurrentDirectory() + "\\..\\output\\order" + DateTime.Now.ToString("MM-dd-yyyy__HH-mm") + ".txt";
            StreamWriter f = new StreamWriter(path, false);
            f.WriteLine(cuisineLabel.Text + " Cuisine");
            foreach (OrderItem item in orderItems)
            {
                f.WriteLine(item.GetTitle() + "  " + item.GetCount() + " items  .... $"  + item.GetPrice());
            };
            f.WriteLine("Total: " + orderItems.Count + "  ....  $" + totalPrice);
            f.WriteLine("Bon appetit!!");
            f.Close();
            return path;
        }

        void СontexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            switch (item.Name) {
                case "AddDish":
                    var productItem = ShowAddDish("Add dish", "", "");
                    if (productItem != null)
                    {
                        items.Add(productItem);
                        SaveProductList();
                        UpdateProductList();
                    }
                    break;
                case "RenameDish":
                    var selectedProduct = items[menuListIndex];
                    selectedProduct = ShowAddDish("Edit" + selectedProduct.GetName(), selectedProduct.GetName(), selectedProduct.GetPrice().ToString());
                    if (selectedProduct != null)
                    {
                        items[menuListIndex] = selectedProduct;
                        SaveProductList();
                        UpdateProductList();
                    }
                    break;
                case "RemoveDish":
                    items.RemoveAt(menuListIndex);
                    if (items.Count == 0) {
                        SetAdditionalOptions(false);
                    }
                    SaveProductList();
                    UpdateProductList();
                    break;
                case "OrderDish":
                    button1_Click(null, null);
                    break;
                case "SortAZ":
                    items = items.OrderBy(o => o.GetName()).ToList();
                    SaveProductList();
                    UpdateProductList();
                    break;
                case "SortZA":
                    items = items.OrderByDescending(o => o.GetName()).ToList();
                    SaveProductList();
                    UpdateProductList();
                    break;
            }
           
        }

        private ProductItem ShowAddDish(string title, string input, string price) {
            var dialogResult = ShowInputDialog(title, ref input, ref price);
            double numPrice;
            try
            {
                numPrice = double.Parse(price, CultureInfo.InvariantCulture);
                productIndex++;
                return new ProductItem(productIndex, input, numPrice);
            }
            catch (Exception)
            {
                if (dialogResult != DialogResult.OK)
                    return null;
                ShowMessage("IncorrectPrice");
                return ShowAddDish(title, input, price);
            }
        }

        private static DialogResult ShowInputDialog(
            string title,
            ref string input, 
            ref string price
        ) {
            System.Drawing.Size size = new System.Drawing.Size(200, 150);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;

            //Dish name
            Label dishNameLabel = new Label();
            dishNameLabel.Size = new System.Drawing.Size(size.Width - 10, 23);
            dishNameLabel.Location = new System.Drawing.Point(5, 5);
            dishNameLabel.Text = "Enter new dish name";
            inputBox.Controls.Add(dishNameLabel);


            TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 28);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Dish price
            Label dishPriceLabel = new Label();
            dishPriceLabel.Size = new System.Drawing.Size(size.Width - 10, 23);
            dishPriceLabel.Location = new System.Drawing.Point(5, 56);
            dishPriceLabel.Text = "Enter new dish price";
            inputBox.Controls.Add(dishPriceLabel);


            TextBox priceBox = new TextBox();
            priceBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            priceBox.Location = new System.Drawing.Point(5, 79);
            priceBox.Text = price;   
            inputBox.Controls.Add(priceBox);




            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 117);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 117);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            price = priceBox.Text;
            return result;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuListIndex = checkedListBox1.SelectedIndex;
            SetAdditionalOptions(true);
        }

        private void SetOptions(Boolean enabled)
        {
            AddDish.Enabled = enabled;
            SortAZ.Enabled = enabled;
            SortZA.Enabled = enabled;
            if(!enabled)
                SetAdditionalOptions(enabled);
        }

        private void SetAdditionalOptions(Boolean enabled) {
            OrderDish.Enabled = enabled;
            RenameDish.Enabled = enabled;
            RemoveDish.Enabled = enabled;
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
