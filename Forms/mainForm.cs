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
            Label tempLabel = new Label(); 
            List<List<string>> infoList = sqlOperations.getFromDate(date);
            for (int i = 0; i < infoList.Count; i++)
            {


                CheckBox checkBox = new CheckBox();
                checkBox.CheckedChanged += checkBox_CheckedChanged;
                checkBox.Text = infoList[i][0].ToString();
                checkBox.Width = 200;
               
                checkBox.Location = new Point(3, tempLabel.Bottom+10 );
                toDoListPanel.Controls.Add(checkBox);

                int bottomLinePoint = 80;

                Label description = new Label();
                description.Text = descriptionParse(infoList[i][1].ToString(), bottomLinePoint);
                description.AutoSize = true;
                description.Location = new Point(40, checkBox.Bottom+1);
                tempLabel = description;
                toDoListPanel.Controls.Add(description);

                /*RichTextBox description = new RichTextBox();
                description.Text = infoList[i][1].ToString();
                description.Location = new Point(40, 40 + (i * 50));
                description.ReadOnly = true;
                description.Height = 100;
                description.Width = 450;
                description.BorderStyle = BorderStyle.None;
                toDoListPanel.Controls.Add(description);*/
            }
        }
        
        private string descriptionParse (string description, int bottomLinePoint)
        {
            StringBuilder segmentedDescription = new StringBuilder();
            int index = 0;

            while(index < description.Length)
            {
                if(index + bottomLinePoint < description.Length)
                {
                    segmentedDescription.AppendLine(description.Substring(index, bottomLinePoint));
                    index += bottomLinePoint;
                }
                else
                {
                    segmentedDescription.AppendLine(description.Substring(index));
                    break;
                }
                
            }
            return segmentedDescription.ToString();
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                
                
                
            }
            else
            {
                
                MessageBox.Show("CheckBox işareti kaldırıldı.");
                
            }
        }

       
    }
}
