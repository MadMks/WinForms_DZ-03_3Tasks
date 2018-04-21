namespace Task_3_TextEditor
{
    partial class EditorForm
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
            this.textBoxTextForEdit = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTextForEdit
            // 
            this.textBoxTextForEdit.Location = new System.Drawing.Point(12, 12);
            this.textBoxTextForEdit.Multiline = true;
            this.textBoxTextForEdit.Name = "textBoxTextForEdit";
            this.textBoxTextForEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTextForEdit.Size = new System.Drawing.Size(419, 139);
            this.textBoxTextForEdit.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(153, 199);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSaveText
            // 
            this.buttonSaveText.Location = new System.Drawing.Point(12, 199);
            this.buttonSaveText.Name = "buttonSaveText";
            this.buttonSaveText.Size = new System.Drawing.Size(115, 23);
            this.buttonSaveText.TabIndex = 3;
            this.buttonSaveText.Text = "Сохранить";
            this.buttonSaveText.UseVisualStyleBackColor = true;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 264);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveText);
            this.Controls.Add(this.textBoxTextForEdit);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextForEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveText;
    }
}