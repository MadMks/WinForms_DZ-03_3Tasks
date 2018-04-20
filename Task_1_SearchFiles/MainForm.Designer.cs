namespace Task_1_SearchFiles
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxFoundFiles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(13, 204);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(162, 32);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Поиск файлов";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // listBoxFoundFiles
            // 
            this.listBoxFoundFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxFoundFiles.FormattingEnabled = true;
            this.listBoxFoundFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFoundFiles.Name = "listBoxFoundFiles";
            this.listBoxFoundFiles.Size = new System.Drawing.Size(420, 186);
            this.listBoxFoundFiles.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxFoundFiles);
            this.Controls.Add(this.buttonSearch);
            this.Name = "MainForm";
            this.Text = "Список файлов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxFoundFiles;
        private System.Windows.Forms.Button button1;
    }
}

