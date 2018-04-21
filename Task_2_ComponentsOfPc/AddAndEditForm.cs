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
    public partial class AddAndEditForm : Form
    {
        private Product product;
        private bool isAddition;

        public AddAndEditForm() // TODO FIX
        {
            InitializeComponent();
        }

        public AddAndEditForm(Product product, bool isAddition)
        {
            InitializeComponent();

            this.isAddition = isAddition;
            this.product = product;

            this.Load += AddAndEditForm_Load;

            this.buttonAddOrEdit.Click += ButtonAddOrEdit_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddOrEdit_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text == ""
                || this.textBoxCharacteristic.Text == ""
                || this.textBoxDescription.Text == ""
                || this.textBoxPrice.Text == "")
            {
                MessageBox.Show("Нужно заполнить все поля.");
                return;
            }

            if (this.product == null)
            {
                this.product = new Product();
            }

            this.product.Name = this.textBoxName.Text;
            this.product.Characteristic = this.textBoxCharacteristic.Text;
            this.product.Description = this.textBoxDescription.Text;
            this.product.Price = Single.Parse(this.textBoxPrice.Text);

            DialogResult = DialogResult.OK;
        }

        private void AddAndEditForm_Load(object sender, EventArgs e)
        {
            if (this.isAddition == false)
            {
                this.textBoxName.Text = this.product.Name;
                this.textBoxCharacteristic.Text = this.product.Characteristic;
                this.textBoxDescription.Text = this.product.Description;
                this.textBoxPrice.Text = this.product.Price.ToString();

                this.Text = "Редактирование товара";
            }
            else if (this.isAddition == true)
            {
                this.Text = "Добавление товара";
            }
        }
    }
}
