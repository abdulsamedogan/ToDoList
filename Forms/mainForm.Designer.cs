namespace ToDoList
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addListFormButton = new System.Windows.Forms.Button();
            this.toDoListPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1167, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 801);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(295, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 260);
            this.panel2.TabIndex = 2;
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.Location = new System.Drawing.Point(18, 41);
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.TabIndex = 4;
            this.monthCalendarMain.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addListFormButton
            // 
            this.addListFormButton.Location = new System.Drawing.Point(766, 12);
            this.addListFormButton.Name = "addListFormButton";
            this.addListFormButton.Size = new System.Drawing.Size(75, 23);
            this.addListFormButton.TabIndex = 6;
            this.addListFormButton.Text = "+";
            this.addListFormButton.UseVisualStyleBackColor = true;
            this.addListFormButton.Click += new System.EventHandler(this.addListFormButton_Click);
            // 
            // toDoListPanel
            // 
            this.toDoListPanel.AutoScroll = true;
            this.toDoListPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.toDoListPanel.Location = new System.Drawing.Point(295, 41);
            this.toDoListPanel.Name = "toDoListPanel";
            this.toDoListPanel.Size = new System.Drawing.Size(784, 225);
            this.toDoListPanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(295, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 260);
            this.panel3.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 854);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addListFormButton);
            this.Controls.Add(this.toDoListPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.monthCalendarMain);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addListFormButton;
        private System.Windows.Forms.Panel toDoListPanel;
        private System.Windows.Forms.Panel panel3;
    }
}

