namespace ToDoList
{
    partial class addListForm
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
            this.addListButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.monthCalendarAddList = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(319, 226);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(75, 23);
            this.addListButton.TabIndex = 0;
            this.addListButton.Text = "ADD";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(46, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(49, 70);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(416, 20);
            this.titleBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(49, 110);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(52, 146);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(413, 20);
            this.descriptionBox.TabIndex = 4;
            // 
            // monthCalendarAddList
            // 
            this.monthCalendarAddList.Location = new System.Drawing.Point(491, 40);
            this.monthCalendarAddList.Name = "monthCalendarAddList";
            this.monthCalendarAddList.TabIndex = 5;
            // 
            // addListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 315);
            this.Controls.Add(this.monthCalendarAddList);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addListButton);
            this.Name = "addListForm";
            this.Text = "addListForm";
            this.Load += new System.EventHandler(this.addListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addListButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.MonthCalendar monthCalendarAddList;
    }
}