using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_SearchFiles
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Форма поиска.
        /// </summary>
        private SearchForm searchForm;


        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }


        /// <summary>
        /// Обработчик загрузки главной формы.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            searchForm = null;

            this.buttonSearch.Click += ButtonSearch_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
        }

        /// <summary>
        /// Обработчик кнопки закрытия главного окна.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Обработчик открытия окна поиска.
        /// </summary>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            searchForm = new SearchForm(this.listBoxFoundFiles);

            searchForm.Show();
        }
    }
}
