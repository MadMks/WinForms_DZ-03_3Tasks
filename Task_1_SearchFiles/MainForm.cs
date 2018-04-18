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
        private SearchForm searchForm;


        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            searchForm = null;

            this.buttonSearch.Click += ButtonSearch_Click;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            searchForm = new SearchForm(this.listBoxFoundFiles);

            searchForm.Show();

            //if (this.listBoxFoundFiles.DataSource != null)
            //{
            //    MessageBox.Show("1");
            //}

            //this.listBoxFoundFiles.DataSource
        }
    }
}
