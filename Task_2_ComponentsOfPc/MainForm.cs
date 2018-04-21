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

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ListOfProducts = new List<Product>
            {
                new Product
                {
                    Name = "NVidia RX-450",
                    Characteristic = "2 Gb, GDDR4",
                    Description = "Вентиляторы Wing-Blade + радиатор",
                    Price = 10000
                },
                new Product
                {
                    Name = "Жесткий диск Western Digital",
                    Characteristic = "500 Gb, 5400rpm",
                    Description = "Внутренний",
                    Price = 1226
                },
                new Product
                {
                    Name = "Материнская плата Asus EX-B250-V7",
                    Characteristic = "s1151,Intel B250",
                    Description = "Нет встроенного RAID",
                    Price = 2599
                }
            };

            this.comboBoxNameOfAllGoods.DataSource = this.ListOfProducts;
            //this.comboBoxNameOfAllGoods.DisplayMember = this.ListOfProducts.ToString();

            this.comboBoxNameOfAllGoods.SelectedIndex = 0;
            this.textBoxPrice.Text 
                = (this.comboBoxNameOfAllGoods.SelectedItem as Product).Price.ToString();
        }
    }
}
