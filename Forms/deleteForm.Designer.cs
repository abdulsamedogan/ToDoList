namespace ToDoList.Forms
{
    partial class deleteForm
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
            this.deleteTitle = new System.Windows.Forms.RichTextBox();
            this.deleteDescription = new System.Windows.Forms.RichTextBox();
            this.deleteTitleLabel = new System.Windows.Forms.Label();
            this.deleteDescriptionLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteTitle
            // 
            this.deleteTitle.Location = new System.Drawing.Point(38, 58);
            this.deleteTitle.Name = "deleteTitle";
            this.deleteTitle.Size = new System.Drawing.Size(445, 116);
            this.deleteTitle.TabIndex = 0;
            this.deleteTitle.Text = "";
            // 
            // deleteDescription
            // 
            this.deleteDescription.Location = new System.Drawing.Point(38, 224);
            this.deleteDescription.Name = "deleteDescription";
            this.deleteDescription.Size = new System.Drawing.Size(445, 119);
            this.deleteDescription.TabIndex = 1;
            this.deleteDescription.Text = "";
            // 
            // deleteTitleLabel
            // 
            this.deleteTitleLabel.AutoSize = true;
            this.deleteTitleLabel.Location = new System.Drawing.Point(38, 39);
            this.deleteTitleLabel.Name = "deleteTitleLabel";
            this.deleteTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.deleteTitleLabel.TabIndex = 2;
            this.deleteTitleLabel.Text = "label1";
            // 
            // deleteDescriptionLabel
            // 
            this.deleteDescriptionLabel.AutoSize = true;
            this.deleteDescriptionLabel.Location = new System.Drawing.Point(41, 205);
            this.deleteDescriptionLabel.Name = "deleteDescriptionLabel";
            this.deleteDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.deleteDescriptionLabel.TabIndex = 3;
            this.deleteDescriptionLabel.Text = "label1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(407, 376);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 375);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteDescriptionLabel);
            this.Controls.Add(this.deleteTitleLabel);
            this.Controls.Add(this.deleteDescription);
            this.Controls.Add(this.deleteTitle);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.Load += new System.EventHandler(this.deleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox deleteTitle;
        private System.Windows.Forms.RichTextBox deleteDescription;
        private System.Windows.Forms.Label deleteTitleLabel;
        private System.Windows.Forms.Label deleteDescriptionLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
    }
}