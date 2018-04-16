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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            this.Load += SearchForm_Load;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.buttonSelectAFolder.Click += ButtonSelectAFolder_Click;
        }

        private void ButtonSelectAFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.LocalizedResources;
            folderBrowserDialog.ShowNewFolderButton = false;
            

            folderBrowserDialog.ShowDialog();
        }
    }
}
