namespace Task_2_ComponentsOfPc
{
    partial class MainForm
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
            this.listBoxSalesList = new System.Windows.Forms.ListBox();
            this.comboBoxNameOfAllGoods = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonAddToSalesList = new System.Windows.Forms.Button();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.labelPriceProduct = new System.Windows.Forms.Label();
            this.groupBoxSelectionOfGoods = new System.Windows.Forms.GroupBox();
            this.groupBoxSalesList = new System.Windows.Forms.GroupBox();
            this.groupBoxChangeListOfProducts = new System.Windows.Forms.GroupBox();
            this.groupBoxPriceSelectedProduct = new System.Windows.Forms.GroupBox();
            this.groupBoxTotalCost = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectionOfGoods.SuspendLayout();
            this.groupBoxSalesList.SuspendLayout();
            this.groupBoxChangeListOfProducts.SuspendLayout();
            this.groupBoxPriceSelectedProduct.SuspendLayout();
            this.groupBoxTotalCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSalesList
            // 
            this.listBoxSalesList.FormattingEnabled = true;
            this.listBoxSalesList.Location = new System.Drawing.Point(13, 26);
            this.listBoxSalesList.Name = "listBoxSalesList";
            this.listBoxSalesList.Size = new System.Drawing.Size(576, 173);
            this.listBoxSalesList.TabIndex = 0;
            // 
            // comboBoxNameOfAllGoods
            // 
            this.comboBoxNameOfAllGoods.FormattingEnabled = true;
            this.comboBoxNameOfAllGoods.Location = new System.Drawing.Point(16, 30);
            this.comboBoxNameOfAllGoods.Name = "comboBoxNameOfAllGoods";
            this.comboBoxNameOfAllGoods.Size = new System.Drawing.Size(570, 21);
            this.comboBoxNameOfAllGoods.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(70, 44);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(98, 32);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.Text = "0";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAddToSalesList
            // 
            this.buttonAddToSalesList.Location = new System.Drawing.Point(23, 254);
            this.buttonAddToSalesList.Name = "buttonAddToSalesList";
            this.buttonAddToSalesList.Size = new System.Drawing.Size(267, 55);
            this.buttonAddToSalesList.TabIndex = 3;
            this.buttonAddToSalesList.Text = "Добавить в список продаж";
            this.buttonAddToSalesList.UseVisualStyleBackColor = true;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCost.Location = new System.Drawing.Point(21, 39);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(126, 24);
            this.labelTotalCost.TabIndex = 4;
            this.labelTotalCost.Text = "0";
            this.labelTotalCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(23, 36);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(127, 50);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(192, 36);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(124, 50);
            this.buttonEditProduct.TabIndex = 6;
            this.buttonEditProduct.Text = "Редактировать товар";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            // 
            // labelPriceProduct
            // 
            this.labelPriceProduct.AutoSize = true;
            this.labelPriceProduct.Location = new System.Drawing.Point(24, 52);
            this.labelPriceProduct.Name = "labelPriceProduct";
            this.labelPriceProduct.Size = new System.Drawing.Size(33, 13);
            this.labelPriceProduct.TabIndex = 7;
            this.labelPriceProduct.Text = "Цена";
            // 
            // groupBoxSelectionOfGoods
            // 
            this.groupBoxSelectionOfGoods.Controls.Add(this.groupBoxPriceSelectedProduct);
            this.groupBoxSelectionOfGoods.Controls.Add(this.groupBoxChangeListOfProducts);
            this.groupBoxSelectionOfGoods.Controls.Add(this.comboBoxNameOfAllGoods);
            this.groupBoxSelectionOfGoods.Location = new System.Drawing.Point(12, 336);
            this.groupBoxSelectionOfGoods.Name = "groupBoxSelectionOfGoods";
            this.groupBoxSelectionOfGoods.Size = new System.Drawing.Size(602, 191);
            this.groupBoxSelectionOfGoods.TabIndex = 8;
            this.groupBoxSelectionOfGoods.TabStop = false;
            this.groupBoxSelectionOfGoods.Text = "Выбор товара";
            // 
            // groupBoxSalesList
            // 
            this.groupBoxSalesList.Controls.Add(this.listBoxSalesList);
            this.groupBoxSalesList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSalesList.Name = "groupBoxSalesList";
            this.groupBoxSalesList.Size = new System.Drawing.Size(602, 218);
            this.groupBoxSalesList.TabIndex = 9;
            this.groupBoxSalesList.TabStop = false;
            this.groupBoxSalesList.Text = "Список продаж";
            // 
            // groupBoxChangeListOfProducts
            // 
            this.groupBoxChangeListOfProducts.Controls.Add(this.buttonAddProduct);
            this.groupBoxChangeListOfProducts.Controls.Add(this.buttonEditProduct);
            this.groupBoxChangeListOfProducts.Location = new System.Drawing.Point(248, 75);
            this.groupBoxChangeListOfProducts.Name = "groupBoxChangeListOfProducts";
            this.groupBoxChangeListOfProducts.Size = new System.Drawing.Size(338, 100);
            this.groupBoxChangeListOfProducts.TabIndex = 8;
            this.groupBoxChangeListOfProducts.TabStop = false;
            this.groupBoxChangeListOfProducts.Text = "Изиенение списка товаров";
            // 
            // groupBoxPriceSelectedProduct
            // 
            this.groupBoxPriceSelectedProduct.Controls.Add(this.labelPriceProduct);
            this.groupBoxPriceSelectedProduct.Controls.Add(this.textBoxPrice);
            this.groupBoxPriceSelectedProduct.Location = new System.Drawing.Point(16, 75);
            this.groupBoxPriceSelectedProduct.Name = "groupBoxPriceSelectedProduct";
            this.groupBoxPriceSelectedProduct.Size = new System.Drawing.Size(200, 100);
            this.groupBoxPriceSelectedProduct.TabIndex = 9;
            this.groupBoxPriceSelectedProduct.TabStop = false;
            this.groupBoxPriceSelectedProduct.Text = "Стоимость выбранного товара";
            // 
            // groupBoxTotalCost
            // 
            this.groupBoxTotalCost.Controls.Add(this.labelTotalCost);
            this.groupBoxTotalCost.Location = new System.Drawing.Point(424, 246);
            this.groupBoxTotalCost.Name = "groupBoxTotalCost";
            this.groupBoxTotalCost.Size = new System.Drawing.Size(167, 76);
            this.groupBoxTotalCost.TabIndex = 10;
            this.groupBoxTotalCost.TabStop = false;
            this.groupBoxTotalCost.Text = "Общая стоимость";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 545);
            this.Controls.Add(this.groupBoxTotalCost);
            this.Controls.Add(this.groupBoxSalesList);
            this.Controls.Add(this.groupBoxSelectionOfGoods);
            this.Controls.Add(this.buttonAddToSalesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Учет продаж";
            this.groupBoxSelectionOfGoods.ResumeLayout(false);
            this.groupBoxSalesList.ResumeLayout(false);
            this.groupBoxChangeListOfProducts.ResumeLayout(false);
            this.groupBoxPriceSelectedProduct.ResumeLayout(false);
            this.groupBoxPriceSelectedProduct.PerformLayout();
            this.groupBoxTotalCost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSalesList;
        private System.Windows.Forms.ComboBox comboBoxNameOfAllGoods;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddToSalesList;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Label labelPriceProduct;
        private System.Windows.Forms.GroupBox groupBoxSelectionOfGoods;
        private System.Windows.Forms.GroupBox groupBoxPriceSelectedProduct;
        private System.Windows.Forms.GroupBox groupBoxChangeListOfProducts;
        private System.Windows.Forms.GroupBox groupBoxSalesList;
        private System.Windows.Forms.GroupBox groupBoxTotalCost;
    }
}

