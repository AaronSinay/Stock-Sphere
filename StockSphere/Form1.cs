using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSphere
{
    public partial class Form_Main : Form
    {
        public class Product
        {
            public string Name { get; set; }
            public string ProductNumber { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
            public int Sales { get; set; }
        }

        public Form_Main()
        {
            InitializeComponent();
            Initialize_ListView();
        }

        private void Initialize_ListView()
        {
            listView_Products.View = View.Details;
            listView_Products.FullRowSelect = true;
            listView_Products.GridLines = true;
            listView_Products.MultiSelect = false;

            listView_Products.Columns.Clear();

            listView_Products.Columns.Add("Product Name", 225);
            listView_Products.Columns.Add("Product Number", 225);
            listView_Products.Columns.Add("Product Price", 120);
            listView_Products.Columns.Add("Stocks", 100);
            listView_Products.Columns.Add("Sales", 120);

            listView_Products.Items.Clear();
            Load_Product_Data();
        }



        // Pre-generated products.
        private List<Product> Get_Sample_Products()
        {
            return new List<Product>
            {
                new Product { Name = "Laptop", ProductNumber = "LP001", Price = 999.99m, StockQuantity = 15, Sales = 24 },
                new Product { Name = "Smartphone", ProductNumber = "SP002", Price = 699.99m, StockQuantity = 30, Sales = 42 },
                new Product { Name = "Headphones", ProductNumber = "HP003", Price = 149.99m, StockQuantity = 50, Sales = 18 }
            };
        }



        // Load Sample Products (kinda pointless but i want to add pre-generated products for formality).
        private void Load_Product_Data()
        {
            try
            {
                listView_Products.Items.Clear();

                var products = Get_Sample_Products();

                // Load Sample Product
                foreach (var product in products)
                {
                    Product preGeneratedProducts = new Product
                    {
                        Name = product.Name,
                        ProductNumber = product.ProductNumber,
                        Price = product.Price,
                        StockQuantity = product.StockQuantity,
                        Sales = product.Sales
                    };

                    Add_To_ListView(preGeneratedProducts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}", "Data Loading Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Add_To_ListView(Product newProduct)
        {
            ListViewItem item = new ListViewItem(newProduct.Name);
            item.SubItems.Add(newProduct.ProductNumber);
            item.SubItems.Add(newProduct.Price.ToString("C"));
            item.SubItems.Add(newProduct.StockQuantity.ToString());
            item.SubItems.Add(newProduct.Sales.ToString());

            listView_Products.Items.Add(item);
        }



        // Add Button Functionality
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Product_Name.Text) ||
                string.IsNullOrWhiteSpace(textBox_Product_Number.Text) ||
                string.IsNullOrWhiteSpace(textBox_Product_Price.Text) ||
                string.IsNullOrWhiteSpace(textBox_Stocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox_Product_Price.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_Stocks.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity. Please enter a whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new product (with default Sales = 0)
            Product newProduct = new Product
            {
                Name = textBox_Product_Name.Text,
                ProductNumber = textBox_Product_Number.Text,
                Price = price,
                StockQuantity = stock,
                Sales = 0
            };

            Add_To_ListView(newProduct);
            ClearTextBox();
        }



        private void ClearTextBox()
        {
            textBox_Product_Name.Clear();
            textBox_Product_Number.Clear();
            textBox_Product_Price.Clear();
            textBox_Stocks.Clear();
            textBox_Product_Name.Focus();
        }
    }
}
