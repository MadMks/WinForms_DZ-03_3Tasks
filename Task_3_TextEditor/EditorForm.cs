using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_TextEditor
{
    public partial class EditorForm : Form
    {
        private TextBox textBoxMain;


        public EditorForm(TextBox textBox)
        {
            InitializeComponent();

            this.textBoxMain = textBox;

            this.textBoxTextForEdit.Text = textBox.Text;

            this.buttonSaveText.Click += ButtonSaveText_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSaveText_Click(object sender, EventArgs e)
        {
            this.textBoxMain.Text = this.textBoxTextForEdit.Text;
        }


    }
}
