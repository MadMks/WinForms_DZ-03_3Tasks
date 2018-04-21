namespace Task_3_TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTextOfSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonEditFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTextOfSelectedFile
            // 
            this.textBoxTextOfSelectedFile.Location = new System.Drawing.Point(13, 12);
            this.textBoxTextOfSelectedFile.Multiline = true;
            this.textBoxTextOfSelectedFile.Name = "textBoxTextOfSelectedFile";
            this.textBoxTextOfSelectedFile.ReadOnly = true;
            this.textBoxTextOfSelectedFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTextOfSelectedFile.Size = new System.Drawing.Size(419, 139);
            this.textBoxTextOfSelectedFile.TabIndex = 0;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(13, 191);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(115, 23);
            this.buttonLoadFile.TabIndex = 1;
            this.buttonLoadFile.Text = "Загрузить файл";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            // 
            // buttonEditFile
            // 
            this.buttonEditFile.Enabled = false;
            this.buttonEditFile.Location = new System.Drawing.Point(154, 191);
            this.buttonEditFile.Name = "buttonEditFile";
            this.buttonEditFile.Size = new System.Drawing.Size(110, 23);
            this.buttonEditFile.TabIndex = 2;
            this.buttonEditFile.Text = "Редактировать";
            this.buttonEditFile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 243);
            this.Controls.Add(this.buttonEditFile);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.textBoxTextOfSelectedFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextOfSelectedFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonEditFile;
    }
}

