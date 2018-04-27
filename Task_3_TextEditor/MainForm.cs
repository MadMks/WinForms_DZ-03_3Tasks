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

namespace Task_3_TextEditor
{
    public partial class MainForm : Form
    {
        EditorForm editor;


        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.buttonLoadFile.Click += ButtonLoadFile_Click;

            this.buttonEditFile.Click += ButtonEditFile_Click;
        }

        private void ButtonEditFile_Click(object sender, EventArgs e)
        {
            editor = new EditorForm(this.textBoxTextOfSelectedFile);

            editor.Show();
        }

        private void ButtonLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFD = new OpenFileDialog())
            {
                openFD.Filter
                    = "Text Files(*.txt)|*.txt||";
                openFD.FilterIndex = 0;
                openFD.InitialDirectory = Directory.GetCurrentDirectory();

                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = File.OpenText(openFD.FileName))
                    {
                        this.textBoxTextOfSelectedFile.Text = reader.ReadToEnd();
                    }

                    this.buttonEditFile.Enabled = true;
                }
            }
        }


    }
}
