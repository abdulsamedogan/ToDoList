using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Classes;
using ToDoList.SqlClasses;

namespace ToDoList
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            writeToDoList(monthCalendarMain.SelectionStart);
            
        }
        private void addListFormButton_Click(object sender, EventArgs e)

        {
            
            addListForm addListForm = new addListForm();
            addListForm.Show();
        }

        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            toDoListPanel.Controls.Clear();
            writeToDoList(monthCalendarMain.SelectionStart);
            
        }

        private void writeToDoList(DateTime date)
        {
            List<List<string>> infoList = sqlOperations.getFromDate(date);
            for (int i = 0; i < infoList.Count; i++)
            {


                CheckBox checkBox = new CheckBox();
                checkBox.CheckedChanged += checkBox_CheckedChanged;
                checkBox.Text = infoList[i][0].ToString();
                checkBox.Location = new Point(3, 16 + (i * 50));
                toDoListPanel.Controls.Add(checkBox);


                Label description = new Label();
                description.Text = infoList[i][1].ToString();
                description.Location = new Point(40, 40 + (i * 50));
                toDoListPanel.Controls.Add(description);

            }
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                
                MessageBox.Show("CheckBox işaretlendi.");
                
            }
            else
            {
                
                MessageBox.Show("CheckBox işareti kaldırıldı.");
                
            }
        }
       






    }
}
