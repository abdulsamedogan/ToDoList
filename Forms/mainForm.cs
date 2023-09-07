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
                int bottomLinePoint = 100;
                string titleText = infoList[i][0].ToString();


                RichTextBox titleBox = new RichTextBox();

                titleBox.Location = new Point(20, 20);
                titleBox.BackColor = Color.White;
                titleBox.BorderStyle= BorderStyle.None;
                titleBox.Multiline = true;
                titleBox.ReadOnly = true;
                titleBox.ScrollBars = RichTextBoxScrollBars.None;
                
                titleBox = AddTextToRichTextBox(titleText, bottomLinePoint,titleBox);

                CheckBox checkBox = new CheckBox();
                checkBox.Text = "";
                checkBox.CheckedChanged += checkBox_CheckedChanged;
                checkBox.Location = new Point(3, 16);
                

                

                Button editButton = new Button();
                editButton.Location = new Point(695, 16);
                editButton.Size = new Size(25, 25);
                editButton.Click += EditButton_Click;

                Button deleteButton = new Button();
                deleteButton.Location = new Point(725, 16);
                deleteButton.Size = new Size(25, 25);

                bottomLinePoint = 80;

                string descriptionText = infoList[i][1].ToString();
                RichTextBox descriptionBox = new RichTextBox();
                descriptionBox.Location = new Point(40, titleBox.Bottom +10);
                descriptionBox.BackColor = Color.White;
                descriptionBox.BorderStyle = BorderStyle.None;
                descriptionBox.Multiline = true;
                descriptionBox.ReadOnly = true;
                descriptionBox.ScrollBars = RichTextBoxScrollBars.None;

                descriptionBox = AddTextToRichTextBox(descriptionText, bottomLinePoint, descriptionBox);


                
                Panel toDo = new Panel();
                toDo.AutoSize = true;
                toDo.BackColor= Color.White;
                toDo.Location = new Point(18,0 + (i * tempPanel.Bottom) +10);
                tempPanel=toDo;

                toDo.Controls.Add(titleBox);
                toDo.Controls.Add(deleteButton);
                toDo.Controls.Add(editButton);
                toDo.Controls.Add(checkBox);
                toDo.Controls.Add(descriptionBox);
                toDoListPanel.Controls.Add(toDo);
                
            }
        }
       

        private RichTextBox AddTextToRichTextBox(string text, int bottomLinePoint, RichTextBox titleBox)
        {

            int index = 0;

            while (index < text.Length)
            {
                if (index + bottomLinePoint < text.Length)
                {

                    string segment = text.Substring(index, bottomLinePoint);


                    int lastSpaceIndex = segment.LastIndexOf(' ');
                    if (lastSpaceIndex != -1)
                    {
                        titleBox.AppendText(segment.Substring(0, lastSpaceIndex));
                        titleBox.AppendText(Environment.NewLine);
                        index += lastSpaceIndex + 1;
                    }
                    else
                    {

                        titleBox.AppendText(segment);

                        index += bottomLinePoint;
                    }
                }
                else
                {

                    titleBox.AppendText(text.Substring(index));

                    break;
                }
            }
            Size textSize = TextRenderer.MeasureText(text, titleBox.Font);
            titleBox.Width = textSize.Width + 10;
            titleBox.Height = textSize.Height * (titleBox.Lines.Length + 1);
            return titleBox;


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
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
