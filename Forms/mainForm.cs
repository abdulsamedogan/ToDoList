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
            Panel tempPanel = new Panel(); 
            List<List<string>> infoList = sqlOperations.getFromDate(date);
            for (int i = 0; i < infoList.Count; i++)
            {

                int bottomLinePoint = 50;
                Label title = new Label();
                title.Location = new Point(20, 20);
                title.Text = textParse(infoList[i][0].ToString(), bottomLinePoint);
                title.AutoSize = true;  
                
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "";
                checkBox.CheckedChanged += checkBox_CheckedChanged;
                checkBox.Location = new Point(3, 16);
                

                

                Button editButton = new Button();
                editButton.Location = new Point(325, 16);
                

                Button deleteButton = new Button();
                deleteButton.Location = new Point(400, 16);
                

                bottomLinePoint = 80;

                Label description = new Label();
                description.Text = textParse(infoList[i][1].ToString(), bottomLinePoint);
                description.AutoSize = true;
                description.Location = new Point(40, title.Bottom);
               



                Panel toDo = new Panel();
                toDo.Size = new Size(500, 200);
                toDo.BackColor= Color.White;
                toDo.Location = new Point(18,0 + (i * tempPanel.Bottom) +10);
                tempPanel=toDo;
                toDo.Controls.Add(title);
                toDo.Controls.Add(deleteButton);
                toDo.Controls.Add(editButton);
                toDo.Controls.Add(checkBox);
                toDo.Controls.Add(description);
                toDoListPanel.Controls.Add(toDo);
                
            }
        }
        
        private string textParse (string description, int bottomLinePoint)
        {
            StringBuilder segmentedDescription = new StringBuilder();
            int index = 0;

            while (index < description.Length)
            {
                if (index + bottomLinePoint < description.Length)
                {
                    
                    string segment = description.Substring(index, bottomLinePoint);

                    
                    int lastSpaceIndex = segment.LastIndexOf(' ');
                    if (lastSpaceIndex != -1)
                    {
                        segmentedDescription.AppendLine(segment.Substring(0, lastSpaceIndex));
                        index += lastSpaceIndex + 1; 
                    }
                    else
                    {
                        
                        segmentedDescription.AppendLine(segment);
                        index += bottomLinePoint;
                    }
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

        /*// MouseEnter olayı butona fare geldiğinde tetiklenir
        button.MouseEnter += Button_MouseEnter;
            // MouseLeave olayı butondan fare çıkıldığında tetiklenir
            button.MouseLeave += Button_MouseLeave;
        }

    private void Button_MouseEnter(object sender, EventArgs e)
    {
        // Butonun görünürlüğünü true yaparak görünür hale getiriyoruz
        button.Visible = true;
    }

    private void Button_MouseLeave(object sender, EventArgs e)
    {
        // Butonun görünürlüğünü false yaparak gizli hale getiriyoruz
        button.Visible = false;
    }*/

}
}
