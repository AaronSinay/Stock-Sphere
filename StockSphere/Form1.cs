using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private Timer simulationTimer;

        public Form_Main()
        {
            InitializeComponent();
            Initialize_ListView();
            StartPurchaseSimulation();

            textBox_Product_Name.TextChanged += (s, e) => Validate_Add_Button();
            textBox_Product_Number.TextChanged += (s, e) => Validate_Add_Button();
            textBox_Product_Price.TextChanged += (s, e) => Validate_Add_Button();
            textBox_Stocks.TextChanged += (s, e) => Validate_Add_Button();
            listView_Products.SelectedIndexChanged += (s, e) =>
            {
                Validate_Remove_Button();
                Validate_Edit_Button();
                Populate_TextBoxes_From_Selected_Item();
            };

            Validate_Add_Button();
            Validate_Remove_Button();
            Validate_Edit_Button();
        }



        /// <summary>
        /// Initializations
        /// </summary>
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
            Load_Sample_Product_Data();
        }



        /// <summary>
        /// Validate Functions
        /// </summary>
        private void Validate_Add_Button()
        {
            button_Add.Enabled =
                !string.IsNullOrWhiteSpace(textBox_Product_Name.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Product_Number.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Product_Price.Text) &&
                !string.IsNullOrWhiteSpace(textBox_Stocks.Text);
        }

        private void Validate_Remove_Button()
        {
            button_Remove.Enabled = listView_Products.SelectedItems.Count > 0;
        }

        private void Validate_Edit_Button()
        {
            button_Edit.Enabled = listView_Products.SelectedItems.Count > 0;
        }



        /// <summary>
        /// Product Loading and Stuffs.
        /// </summary>
        
        // Load Sample Products (kinda pointless but i want to add pre-generated products for formality).
        private void Load_Sample_Product_Data()
        {
            try
            {
                listView_Products.Items.Clear();

                var products = Get_Sample_Products();

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



        // add to listview as the name suggest bro (made to be modular for easy use lol this how you code dumb bitch)
        private void Add_To_ListView(Product newProduct)
        {
            ListViewItem item = new ListViewItem(newProduct.Name);
            item.SubItems.Add(newProduct.ProductNumber);
            item.SubItems.Add(newProduct.Price.ToString("C"));
            item.SubItems.Add(newProduct.StockQuantity.ToString());
            item.SubItems.Add(newProduct.Sales.ToString());

            listView_Products.Items.Add(item);
        }



        // Pre-generated products.
        private List<Product> Get_Sample_Products()
        {
            return new List<Product>
            {
                new Product { Name = "Lemonade", ProductNumber = "BD106", Price = 1.59m, StockQuantity = 95, Sales = 140 },
                new Product { Name = "Cold Brew Coffee", ProductNumber = "BD107", Price = 3.29m, StockQuantity = 60, Sales = 85 },
                new Product { Name = "Herbal Tea", ProductNumber = "BD108", Price = 2.49m, StockQuantity = 70, Sales = 45 },
                new Product { Name = "Apple Juice", ProductNumber = "BD109", Price = 2.29m, StockQuantity = 65, Sales = 78 },
                new Product { Name = "Flavored Water", ProductNumber = "BD110", Price = 1.19m, StockQuantity = 130, Sales = 105 },
                new Product { Name = "Sports Drink", ProductNumber = "BD111", Price = 2.89m, StockQuantity = 55, Sales = 92 },
                new Product { Name = "Coconut Water", ProductNumber = "BD112", Price = 2.69m, StockQuantity = 45, Sales = 63 },
                new Product { Name = "Milkshake", ProductNumber = "BD113", Price = 3.59m, StockQuantity = 35, Sales = 50 },
                new Product { Name = "Almond Milk", ProductNumber = "BD114", Price = 2.79m, StockQuantity = 40, Sales = 48 },
                new Product { Name = "Green Smoothie", ProductNumber = "BD115", Price = 4.19m, StockQuantity = 30, Sales = 41 },
                new Product { Name = "Protein Shake", ProductNumber = "BD116", Price = 3.99m, StockQuantity = 38, Sales = 60 },
                new Product { Name = "Iced Mocha", ProductNumber = "BD117", Price = 3.49m, StockQuantity = 42, Sales = 58 },
                new Product { Name = "Root Beer", ProductNumber = "BD118", Price = 1.69m, StockQuantity = 100, Sales = 120 },
                new Product { Name = "Fruit Punch", ProductNumber = "BD119", Price = 1.79m, StockQuantity = 85, Sales = 97 },
                new Product { Name = "Peach Tea", ProductNumber = "BD120", Price = 2.39m, StockQuantity = 72, Sales = 80 },
                new Product { Name = "Matcha Latte", ProductNumber = "BD121", Price = 4.49m, StockQuantity = 25, Sales = 33 },
                new Product { Name = "Vanilla Latte", ProductNumber = "BD122", Price = 3.79m, StockQuantity = 50, Sales = 64 },
                new Product { Name = "Sparkling Lemon Water", ProductNumber = "BD123", Price = 1.29m, StockQuantity = 110, Sales = 90 },
                new Product { Name = "Berry Smoothie", ProductNumber = "BD124", Price = 4.29m, StockQuantity = 28, Sales = 39 },
                new Product { Name = "Kombucha", ProductNumber = "BD125", Price = 3.59m, StockQuantity = 33, Sales = 52 }
            };
        }
        


        /// <summary>
        /// TextBox Functions
        /// </summary>
        private void Populate_TextBoxes_From_Selected_Item()
        {
            if (listView_Products.SelectedItems.Count == 0)
            {
                Clear_TextBox();
                return;
            }

            var selectedItem = listView_Products.SelectedItems[0];

            textBox_Product_Name.Text = selectedItem.SubItems[0].Text;
            textBox_Product_Number.Text = selectedItem.SubItems[1].Text;

            string priceText = selectedItem.SubItems[2].Text;
            if (decimal.TryParse(priceText, System.Globalization.NumberStyles.Currency, null, out decimal cleanPrice))
            {
                textBox_Product_Price.Text = cleanPrice.ToString("0.##"); // Clean decimal format
            }
            else
            {
                textBox_Product_Price.Text = string.Empty;
            }

            textBox_Stocks.Text = selectedItem.SubItems[3].Text;
        }
        private void Clear_TextBox()
        {
            textBox_Product_Name.Clear();
            textBox_Product_Number.Clear();
            textBox_Product_Price.Clear();
            textBox_Stocks.Clear();
            textBox_Product_Name.Focus();
        }

        /// <summary>
        /// Button Functions
        /// </summary>
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

            Product newProduct = new Product
            {
                Name = textBox_Product_Name.Text,
                ProductNumber = textBox_Product_Number.Text,
                Price = price,
                StockQuantity = stock,
                Sales = 0
            };

            Add_To_ListView(newProduct);
            Clear_TextBox();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listView_Products.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox_Product_Price.Text, out decimal price))
            {
                MessageBox.Show("Invalid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_Stocks.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listView_Products.SelectedItems[0];
            selectedItem.SubItems[0].Text = textBox_Product_Name.Text;
            selectedItem.SubItems[1].Text = textBox_Product_Number.Text;
            selectedItem.SubItems[2].Text = price.ToString("C");
            selectedItem.SubItems[3].Text = stock.ToString();

            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listView_Products.SelectedItems.Clear();
            Clear_TextBox();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_Products.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to remove the selected product?",
                                             "Confirm Removal",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listView_Products.Items.Remove(listView_Products.SelectedItems[0]);
                    Clear_TextBox();
                    Validate_Remove_Button();
                }
            }
        }



        /// <summary>
        /// Random Purchase Simulation
        /// </summary>
        private void SimulateRandomPurchase()
        {
            if (listView_Products.Items.Count == 0) return;

            Random rand = new Random();
            int index = rand.Next(listView_Products.Items.Count);
            ListViewItem selectedItem = listView_Products.Items[index];

            // Extract current stock and sales values
            int currentStock = int.Parse(selectedItem.SubItems[3].Text);
            int currentSales = int.Parse(selectedItem.SubItems[4].Text);

            int quantityToBuy = rand.Next(1, 6); // Randomly buy 1 to 5 items

            // Simulate the purchase (decrease stock, increase sales)
            if (currentStock > 0)
            {
                int actualPurchase = Math.Min(quantityToBuy, currentStock);
                currentStock -= actualPurchase;
                currentSales += actualPurchase;

                // Update the ListView item with new values
                selectedItem.SubItems[3].Text = currentStock.ToString(); // Update stock
                selectedItem.SubItems[4].Text = currentSales.ToString(); // Update sales
            }
        }

        private void StartPurchaseSimulation()
        {
            // Set up the timer
            simulationTimer = new Timer();
            simulationTimer.Interval = 2000; // 2000 ms = 2 seconds
            simulationTimer.Tick += (sender, e) => SimulateRandomPurchase();
            simulationTimer.Start();
        }
    }
}
