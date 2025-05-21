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
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.textBox_Product_Name = new System.Windows.Forms.TextBox();
            this.label_Product_Name = new System.Windows.Forms.Label();
            this.label_Product_Number = new System.Windows.Forms.Label();
            this.textBox_Product_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Stocks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Product_Price = new System.Windows.Forms.TextBox();
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
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Location = new System.Drawing.Point(372, 602);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(324, 59);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(702, 602);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(324, 59);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stocks";
            // 
            // textBox_Stocks
            // 
            this.textBox_Stocks.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stocks.Location = new System.Drawing.Point(825, 31);
            this.textBox_Stocks.Name = "textBox_Stocks";
            this.textBox_Stocks.Size = new System.Drawing.Size(224, 23);
            this.textBox_Stocks.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Price";
            // 
            // textBox_Product_Price
            // 
            this.textBox_Product_Price.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Product_Price.Location = new System.Drawing.Point(569, 32);
            this.textBox_Product_Price.Name = "textBox_Product_Price";
            this.textBox_Product_Price.Size = new System.Drawing.Size(250, 23);
            this.textBox_Product_Price.TabIndex = 11;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Stocks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Product_Price);
            this.Controls.Add(this.label_Product_Number);
            this.Controls.Add(this.textBox_Product_Number);
            this.Controls.Add(this.label_Product_Name);
            this.Controls.Add(this.textBox_Product_Name);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Edit);
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
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.TextBox textBox_Product_Name;
        private System.Windows.Forms.Label label_Product_Name;
        private System.Windows.Forms.Label label_Product_Number;
        private System.Windows.Forms.TextBox textBox_Product_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Stocks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Product_Price;
    }
}

