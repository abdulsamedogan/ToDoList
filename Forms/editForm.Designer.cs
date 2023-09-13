namespace ToDoList.Forms
{
    partial class editForm
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
            this.editDescription = new System.Windows.Forms.RichTextBox();
            this.editTitle = new System.Windows.Forms.RichTextBox();
            this.editTitleLabel = new System.Windows.Forms.Label();
            this.editDescriptionLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editDescription
            // 
            this.editDescription.Location = new System.Drawing.Point(56, 232);
            this.editDescription.Name = "editDescription";
            this.editDescription.Size = new System.Drawing.Size(519, 96);
            this.editDescription.TabIndex = 0;
            this.editDescription.Text = "";
            // 
            // editTitle
            // 
            this.editTitle.Location = new System.Drawing.Point(56, 82);
            this.editTitle.Name = "editTitle";
            this.editTitle.Size = new System.Drawing.Size(519, 96);
            this.editTitle.TabIndex = 1;
            this.editTitle.Text = "";
            this.editTitle.TextChanged += new System.EventHandler(this.editTitle_TextChanged);
            // 
            // editTitleLabel
            // 
            this.editTitleLabel.AutoSize = true;
            this.editTitleLabel.Location = new System.Drawing.Point(56, 48);
            this.editTitleLabel.Name = "editTitleLabel";
            this.editTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.editTitleLabel.TabIndex = 2;
            this.editTitleLabel.Text = "Title";
            // 
            // editDescriptionLabel
            // 
            this.editDescriptionLabel.AutoSize = true;
            this.editDescriptionLabel.Location = new System.Drawing.Point(56, 197);
            this.editDescriptionLabel.Name = "editDescriptionLabel";
            this.editDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.editDescriptionLabel.TabIndex = 3;
            this.editDescriptionLabel.Text = "Description";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(433, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(572, 364);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editDescriptionLabel);
            this.Controls.Add(this.editTitleLabel);
            this.Controls.Add(this.editTitle);
            this.Controls.Add(this.editDescription);
            this.Name = "editForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox editDescription;
        private System.Windows.Forms.RichTextBox editTitle;
        private System.Windows.Forms.Label editTitleLabel;
        private System.Windows.Forms.Label editDescriptionLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}