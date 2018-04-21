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
            this.SuspendLayout();
            // 
            // listBoxSalesList
            // 
            this.listBoxSalesList.FormattingEnabled = true;
            this.listBoxSalesList.Location = new System.Drawing.Point(13, 13);
            this.listBoxSalesList.Name = "listBoxSalesList";
            this.listBoxSalesList.Size = new System.Drawing.Size(120, 95);
            this.listBoxSalesList.TabIndex = 0;
            // 
            // comboBoxNameOfAllGoods
            // 
            this.comboBoxNameOfAllGoods.FormattingEnabled = true;
            this.comboBoxNameOfAllGoods.Location = new System.Drawing.Point(140, 13);
            this.comboBoxNameOfAllGoods.Name = "comboBoxNameOfAllGoods";
            this.comboBoxNameOfAllGoods.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameOfAllGoods.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(140, 50);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxPrice.TabIndex = 2;
            // 
            // buttonAddToSalesList
            // 
            this.buttonAddToSalesList.Location = new System.Drawing.Point(43, 229);
            this.buttonAddToSalesList.Name = "buttonAddToSalesList";
            this.buttonAddToSalesList.Size = new System.Drawing.Size(197, 23);
            this.buttonAddToSalesList.TabIndex = 3;
            this.buttonAddToSalesList.Text = "Добавить в список продаж";
            this.buttonAddToSalesList.UseVisualStyleBackColor = true;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(12, 122);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(35, 13);
            this.labelTotalCost.TabIndex = 4;
            this.labelTotalCost.Text = "label1";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(150, 111);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(124, 23);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(150, 140);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(124, 39);
            this.buttonEditProduct.TabIndex = 6;
            this.buttonEditProduct.Text = "Редактировать товар";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 264);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.buttonAddToSalesList);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxNameOfAllGoods);
            this.Controls.Add(this.listBoxSalesList);
            this.Name = "MainForm";
            this.Text = "Учет продаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSalesList;
        private System.Windows.Forms.ComboBox comboBoxNameOfAllGoods;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonAddToSalesList;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonEditProduct;
    }
}

