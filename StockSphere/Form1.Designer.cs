namespace StockSphere
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_Products = new System.Windows.Forms.ListView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.label_Product_Name = new System.Windows.Forms.Label();
            this.label_Product_Number = new System.Windows.Forms.Label();
            this.textBox_Product_Number = new System.Windows.Forms.TextBox();
            this.label_Product_Prize = new System.Windows.Forms.Label();
            this.textBox_Product_Prize = new System.Windows.Forms.TextBox();
            this.label_Stocks = new System.Windows.Forms.Label();
            this.textBox_Stocks = new System.Windows.Forms.TextBox();
            this.label_Sales = new System.Windows.Forms.Label();
            this.textBox_Sales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Products
            // 
            this.listView_Products.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(12, 60);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(1038, 536);
            this.listView_Products.TabIndex = 1;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(42, 602);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(324, 59);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(372, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(702, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox_Product_Name
            // 
            this.textBox_Product_Name.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Product_Name.Location = new System.Drawing.Point(12, 32);
            this.textBox_Product_Name.Name = "textBox_Product_Name";
            this.textBox_Product_Name.Size = new System.Drawing.Size(283, 23);
            this.textBox_Product_Name.TabIndex = 7;
            // 
            // label_Product_Name
            // 
            this.label_Product_Name.AutoSize = true;
            this.label_Product_Name.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product_Name.Location = new System.Drawing.Point(24, 13);
            this.label_Product_Name.Name = "label_Product_Name";
            this.label_Product_Name.Size = new System.Drawing.Size(96, 18);
            this.label_Product_Name.TabIndex = 8;
            this.label_Product_Name.Text = "Product Name";
            // 
            // label_Product_Number
            // 
            this.label_Product_Number.AutoSize = true;
            this.label_Product_Number.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product_Number.Location = new System.Drawing.Point(313, 13);
            this.label_Product_Number.Name = "label_Product_Number";
            this.label_Product_Number.Size = new System.Drawing.Size(110, 18);
            this.label_Product_Number.TabIndex = 10;
            this.label_Product_Number.Text = "Product Number";
            // 
            // textBox_Product_Number
            // 
            this.textBox_Product_Number.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Product_Number.Location = new System.Drawing.Point(301, 32);
            this.textBox_Product_Number.Name = "textBox_Product_Number";
            this.textBox_Product_Number.Size = new System.Drawing.Size(262, 23);
            this.textBox_Product_Number.TabIndex = 9;
            // 
            // label_Product_Prize
            // 
            this.label_Product_Prize.AutoSize = true;
            this.label_Product_Prize.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product_Prize.Location = new System.Drawing.Point(581, 13);
            this.label_Product_Prize.Name = "label_Product_Prize";
            this.label_Product_Prize.Size = new System.Drawing.Size(91, 18);
            this.label_Product_Prize.TabIndex = 12;
            this.label_Product_Prize.Text = "Product Price";
            // 
            // textBox_Product_Prize
            // 
            this.textBox_Product_Prize.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Product_Prize.Location = new System.Drawing.Point(569, 32);
            this.textBox_Product_Prize.Name = "textBox_Product_Prize";
            this.textBox_Product_Prize.Size = new System.Drawing.Size(164, 23);
            this.textBox_Product_Prize.TabIndex = 11;
            // 
            // label_Stocks
            // 
            this.label_Stocks.AutoSize = true;
            this.label_Stocks.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stocks.Location = new System.Drawing.Point(751, 13);
            this.label_Stocks.Name = "label_Stocks";
            this.label_Stocks.Size = new System.Drawing.Size(49, 18);
            this.label_Stocks.TabIndex = 14;
            this.label_Stocks.Text = "Stocks";
            this.label_Stocks.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Stocks
            // 
            this.textBox_Stocks.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stocks.Location = new System.Drawing.Point(739, 32);
            this.textBox_Stocks.Name = "textBox_Stocks";
            this.textBox_Stocks.Size = new System.Drawing.Size(153, 23);
            this.textBox_Stocks.TabIndex = 13;
            this.textBox_Stocks.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_Sales
            // 
            this.label_Sales.AutoSize = true;
            this.label_Sales.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sales.Location = new System.Drawing.Point(910, 13);
            this.label_Sales.Name = "label_Sales";
            this.label_Sales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Sales.Size = new System.Drawing.Size(41, 18);
            this.label_Sales.TabIndex = 16;
            this.label_Sales.Text = "Sales";
            // 
            // textBox_Sales
            // 
            this.textBox_Sales.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sales.Location = new System.Drawing.Point(898, 32);
            this.textBox_Sales.Name = "textBox_Sales";
            this.textBox_Sales.Size = new System.Drawing.Size(152, 23);
            this.textBox_Sales.TabIndex = 15;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.label_Sales);
            this.Controls.Add(this.textBox_Sales);
            this.Controls.Add(this.label_Stocks);
            this.Controls.Add(this.textBox_Stocks);
            this.Controls.Add(this.label_Product_Prize);
            this.Controls.Add(this.textBox_Product_Prize);
            this.Controls.Add(this.label_Product_Number);
            this.Controls.Add(this.textBox_Product_Number);
            this.Controls.Add(this.label_Product_Name);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Stock Sphere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.Label label_Product_Name;
        private System.Windows.Forms.Label label_Product_Number;
        private System.Windows.Forms.TextBox textBox_Product_Number;
        private System.Windows.Forms.Label label_Product_Prize;
        private System.Windows.Forms.TextBox textBox_Product_Prize;
        private System.Windows.Forms.Label label_Stocks;
        private System.Windows.Forms.TextBox textBox_Stocks;
        private System.Windows.Forms.Label label_Sales;
        private System.Windows.Forms.TextBox textBox_Sales;
    }
}

