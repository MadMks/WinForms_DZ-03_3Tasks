namespace Task_1_SearchFiles
{
    partial class SearchForm
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
            this.buttonSelectAFolder = new System.Windows.Forms.Button();
            this.textBoxSearchMask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectAFolder
            // 
            this.buttonSelectAFolder.Location = new System.Drawing.Point(30, 36);
            this.buttonSelectAFolder.Name = "buttonSelectAFolder";
            this.buttonSelectAFolder.Size = new System.Drawing.Size(120, 23);
            this.buttonSelectAFolder.TabIndex = 0;
            this.buttonSelectAFolder.Text = "Выбрать папку";
            this.buttonSelectAFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchMask
            // 
            this.textBoxSearchMask.Location = new System.Drawing.Point(40, 141);
            this.textBoxSearchMask.Name = "textBoxSearchMask";
            this.textBoxSearchMask.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearchMask.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 264);
            this.Controls.Add(this.textBoxSearchMask);
            this.Controls.Add(this.buttonSelectAFolder);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectAFolder;
        private System.Windows.Forms.TextBox textBoxSearchMask;
    }
}