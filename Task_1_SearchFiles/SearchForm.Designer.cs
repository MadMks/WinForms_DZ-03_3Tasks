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
            this.buttonSearchFiles = new System.Windows.Forms.Button();
            this.buttonSearchFormCancel = new System.Windows.Forms.Button();
            this.labelSearchMask = new System.Windows.Forms.Label();
            this.textBoxShowFullPath = new System.Windows.Forms.TextBox();
            this.groupBoxSelectAFolder = new System.Windows.Forms.GroupBox();
            this.groupBoxInputMask = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectAFolder.SuspendLayout();
            this.groupBoxInputMask.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectAFolder
            // 
            this.buttonSelectAFolder.Location = new System.Drawing.Point(71, 60);
            this.buttonSelectAFolder.Name = "buttonSelectAFolder";
            this.buttonSelectAFolder.Size = new System.Drawing.Size(120, 23);
            this.buttonSelectAFolder.TabIndex = 0;
            this.buttonSelectAFolder.Text = "Выбрать папку";
            this.buttonSelectAFolder.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchMask
            // 
            this.textBoxSearchMask.Location = new System.Drawing.Point(144, 27);
            this.textBoxSearchMask.Name = "textBoxSearchMask";
            this.textBoxSearchMask.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearchMask.TabIndex = 1;
            // 
            // buttonSearchFiles
            // 
            this.buttonSearchFiles.Location = new System.Drawing.Point(39, 219);
            this.buttonSearchFiles.Name = "buttonSearchFiles";
            this.buttonSearchFiles.Size = new System.Drawing.Size(102, 23);
            this.buttonSearchFiles.TabIndex = 2;
            this.buttonSearchFiles.Text = "Найти файлы";
            this.buttonSearchFiles.UseVisualStyleBackColor = true;
            // 
            // buttonSearchFormCancel
            // 
            this.buttonSearchFormCancel.Location = new System.Drawing.Point(175, 219);
            this.buttonSearchFormCancel.Name = "buttonSearchFormCancel";
            this.buttonSearchFormCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchFormCancel.TabIndex = 3;
            this.buttonSearchFormCancel.Text = "Отмена";
            this.buttonSearchFormCancel.UseVisualStyleBackColor = true;
            // 
            // labelSearchMask
            // 
            this.labelSearchMask.AutoSize = true;
            this.labelSearchMask.Location = new System.Drawing.Point(9, 31);
            this.labelSearchMask.Name = "labelSearchMask";
            this.labelSearchMask.Size = new System.Drawing.Size(120, 13);
            this.labelSearchMask.TabIndex = 4;
            this.labelSearchMask.Text = "Введите маску поиска";
            // 
            // textBoxShowFullPath
            // 
            this.textBoxShowFullPath.Location = new System.Drawing.Point(17, 26);
            this.textBoxShowFullPath.Name = "textBoxShowFullPath";
            this.textBoxShowFullPath.ReadOnly = true;
            this.textBoxShowFullPath.Size = new System.Drawing.Size(227, 21);
            this.textBoxShowFullPath.TabIndex = 5;
            this.textBoxShowFullPath.Text = "Папка не выбрана";
            // 
            // groupBoxSelectAFolder
            // 
            this.groupBoxSelectAFolder.Controls.Add(this.buttonSelectAFolder);
            this.groupBoxSelectAFolder.Controls.Add(this.textBoxShowFullPath);
            this.groupBoxSelectAFolder.Location = new System.Drawing.Point(12, 15);
            this.groupBoxSelectAFolder.Name = "groupBoxSelectAFolder";
            this.groupBoxSelectAFolder.Size = new System.Drawing.Size(262, 100);
            this.groupBoxSelectAFolder.TabIndex = 6;
            this.groupBoxSelectAFolder.TabStop = false;
            this.groupBoxSelectAFolder.Text = "Выбор папки";
            // 
            // groupBoxInputMask
            // 
            this.groupBoxInputMask.Controls.Add(this.labelSearchMask);
            this.groupBoxInputMask.Controls.Add(this.textBoxSearchMask);
            this.groupBoxInputMask.Location = new System.Drawing.Point(12, 136);
            this.groupBoxInputMask.Name = "groupBoxInputMask";
            this.groupBoxInputMask.Size = new System.Drawing.Size(262, 62);
            this.groupBoxInputMask.TabIndex = 7;
            this.groupBoxInputMask.TabStop = false;
            this.groupBoxInputMask.Text = "Ввод маски";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 264);
            this.Controls.Add(this.groupBoxInputMask);
            this.Controls.Add(this.groupBoxSelectAFolder);
            this.Controls.Add(this.buttonSearchFormCancel);
            this.Controls.Add(this.buttonSearchFiles);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBoxSelectAFolder.ResumeLayout(false);
            this.groupBoxSelectAFolder.PerformLayout();
            this.groupBoxInputMask.ResumeLayout(false);
            this.groupBoxInputMask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectAFolder;
        private System.Windows.Forms.TextBox textBoxSearchMask;
        private System.Windows.Forms.Button buttonSearchFiles;
        private System.Windows.Forms.Button buttonSearchFormCancel;
        private System.Windows.Forms.Label labelSearchMask;
        private System.Windows.Forms.TextBox textBoxShowFullPath;
        private System.Windows.Forms.GroupBox groupBoxSelectAFolder;
        private System.Windows.Forms.GroupBox groupBoxInputMask;
    }
}