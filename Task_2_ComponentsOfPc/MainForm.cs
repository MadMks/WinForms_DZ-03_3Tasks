using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_ComponentsOfPc
{
    public partial class MainForm : Form
    {
        public List<Product> ListOfProducts { get; set; }
        public float TotalCost { get; set; }

        public Product product { get; set; }

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.comboBoxNameOfAllGoods.Items.AddRange(
                new Product[] 
                {
                    new Product
                    {
                        Name = "NVidia RX-450",
                        Characteristic = "2 Gb, GDDR4",
                        Description = "Вентиляторы Wing-Blade + радиатор",
                        Price = 1
                    },
                    new Product
                    {
                        Name = "Жесткий диск Western Digital",
                        Characteristic = "500 Gb, 5400rpm",
                        Description = "Внутренний",
                        Price = 2
                    },
                    new Product
                    {
                        Name = "Материнская плата Asus EX-B250-V7",
                        Characteristic = "s1151,Intel B250",
                        Description = "Нет встроенного RAID",
                        Price = 3
                    }
                }
            );


            this.comboBoxNameOfAllGoods.SelectedIndex = 0;
            this.textBoxPrice.Text 
                = (this.comboBoxNameOfAllGoods.SelectedItem as Product).Price.ToString();


            this.product = null;

            this.comboBoxNameOfAllGoods.SelectedIndexChanged
                += ComboBoxNameOfAllGoods_SelectedIndexChanged;


            this.buttonAddToSalesList.Click
                += ButtonAddToSalesList_Click;

            this.buttonAddProduct.Click += ButtonAddProduct_Click;
            this.buttonEditProduct.Click += ButtonEditProduct_Click;
        }

        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            int tempSelectIndex = this.comboBoxNameOfAllGoods.SelectedIndex;

            this.product = (this.comboBoxNameOfAllGoods.Items[tempSelectIndex] as Product);

            AddAndEditForm editForm = new AddAndEditForm(this.product, false);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                this.comboBoxNameOfAllGoods.Items.RemoveAt(tempSelectIndex);

                this.comboBoxNameOfAllGoods.Items.Insert(tempSelectIndex, this.product);
                this.comboBoxNameOfAllGoods.SelectedIndex = tempSelectIndex;
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            this.product = new Product();

            AddAndEditForm addForm = new AddAndEditForm(this.product, true);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                this.comboBoxNameOfAllGoods.Items.Add(this.product);
            }
        }

        private void ComboBoxNameOfAllGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPrice.Text
                = (this.comboBoxNameOfAllGoods.SelectedItem as Product).Price.ToString();
        }

        private void ButtonAddToSalesList_Click(object sender, EventArgs e)
        {
            this.listBoxSalesList.Items.Add(this.comboBoxNameOfAllGoods.SelectedItem);

            this.TotalCost
                += (this.comboBoxNameOfAllGoods.SelectedItem as Product).Price;

            this.labelTotalCost.Text = this.TotalCost.ToString();
        }


    }
}
