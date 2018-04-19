using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_SearchFiles
{
    public partial class SearchForm : Form
    {
        ListBox listBox;
        string path;
        //string fileMask;

        public SearchForm(ListBox _listBox)
        {
            InitializeComponent();

            this.listBox = _listBox;
            this.path = null;
            //this.fileMask = null;

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
            this.Close();
        }

        private void ButtonSearchFiles_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();

            if (this.path != null)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(this.path);

                //string fileMaskPattern = "^" + "*.txt" + "$";
                string fileMaskPattern = null;

                if (this.textBoxSearchMask.Text != "")
                {
                    fileMaskPattern = "^" + this.textBoxSearchMask.Text + "$";
                }
                else
                {
                    fileMaskPattern = "^$";
                }


                Regex regex = new Regex(fileMaskPattern);


                foreach (FileInfo item in directoryInfo.GetFiles())
                {
                    if (regex.IsMatch(item.Name) == true)
                    {
                        this.listBox.Items.Add(item);
                    }
                    
                }

                this.listBox.DisplayMember = Text;
            }
            
            //this.Close();
        }

        private void ButtonSelectAFolder_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder 
                    = Environment.SpecialFolder.LocalizedResources;
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //this.Text = folderBrowserDialog.SelectedPath;
                    this.path = folderBrowserDialog.SelectedPath;

                    this.textBoxShowFullPath.Text = folderBrowserDialog.SelectedPath;
                }
            }

            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            //folderBrowserDialog.RootFolder = Environment.SpecialFolder.LocalizedResources;
            //folderBrowserDialog.ShowNewFolderButton = false;
            

            //if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
            //    //this.Text = folderBrowserDialog.SelectedPath;
            //    this.path = folderBrowserDialog.SelectedPath;

            //    this.textBoxShowFullPath.Text = folderBrowserDialog.SelectedPath;
            //}
        }

        


    }
}
