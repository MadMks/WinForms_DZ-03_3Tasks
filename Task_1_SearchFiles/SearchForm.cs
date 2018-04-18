using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_SearchFiles
{
    public partial class SearchForm : Form
    {
        ListBox listBox;
        string path;

        public SearchForm(ListBox _listBox)
        {
            InitializeComponent();

            this.listBox = _listBox;
            path = null;

            this.Load += SearchForm_Load;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.buttonSelectAFolder.Click += ButtonSelectAFolder_Click;

            this.buttonSearchFiles.Click += ButtonSearchFiles_Click;

            this.buttonSearchFormCancel.Click += ButtonSearchFormCancel_Click;
        }

        private void ButtonSearchFormCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            //

            //this.DialogResult = DialogResult.OK;
            if (this.path != null)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(this.path);

                this.listBox.DataSource = directoryInfo.GetFiles();

                this.listBox.DisplayMember = Text;
            }
            
            //this.listBox.ValueMember = Text;
            //MessageBox.Show((dataSource as List<string>)[0]);
            //MessageBox.Show(directoryInfo.GetFiles()[0].ToString());
            this.Close();
        }

        private void ButtonSelectAFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.RootFolder = Environment.SpecialFolder.LocalizedResources;
            folderBrowserDialog.ShowNewFolderButton = false;
            

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = folderBrowserDialog.SelectedPath;
                this.path = folderBrowserDialog.SelectedPath;
            }
        }

        


    }
}
