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
using ToDoList.Forms;
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
            Reflesh();
            
        }
        private void addListFormButton_Click(object sender, EventArgs e)

        {
            
            addListForm addListForm = new addListForm();
            addListForm.FormClosing += Form_FormClosing;
            addListForm.Show();
            Reflesh();
        }

        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            Reflesh();
            
        }

        /*private void writeToDoList(DateTime date)
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
        }*/

        public void CreateToDoPanel(DateTime date)
        {
            Panel tempPanel = new Panel();
            List<List<string>> infoList = sqlOperations.getByDate(date);
            for (int i = 0; i < infoList.Count; i++)
            {
                Panel toDo = CreateToDoItem(infoList[i]);
                toDo.AutoSize = true;
                toDo.BackColor = Color.White;
                toDo.Location = new Point(18, 0 + (i * tempPanel.Bottom) + 10);

                

                tempPanel = toDo;
                toDoListPanel.Controls.Add(toDo);
            }

            
        }
       
        private Panel CreateToDoItem(List<string> info)
        {
            Panel toDo = new Panel();


            RichTextBox titleBox = CreateRichTextBox(info[0],20,20, 100);
            CheckBox checkBox = CreateCheckBox(3);
            Button editButton = CreateButton(695);
            Button deleteButton = CreateButton(725);
            RichTextBox descriptionBox = CreateRichTextBox(info[1],40, titleBox.Bottom + 10, 80 );
            titleBox.Tag = sqlOperations.getID(monthCalendarMain.SelectionStart, info[0], info[1]);

            editButton.Click += EditButton_Click;
            deleteButton.Click += DeleteButton_Click;

            toDo.Tag = false;

            
            //toDo.MouseEnter += ToDo_MouseEnter;
            //toDo.MouseLeave += ToDo_MouseLeave;

           
           
            //editButton.Visible = false;
           // deleteButton.Visible = false;


            toDo.Controls.Add(titleBox);
            toDo.Controls.Add(checkBox);
            toDo.Controls.Add(editButton);
            toDo.Controls.Add(deleteButton);
            toDo.Controls.Add(descriptionBox);

            return toDo;
        }

        private RichTextBox CreateRichTextBox(string text, int left, int right ,int bottomLinePoint)
        {
           

            RichTextBox titleBox = new RichTextBox();
            titleBox.Location = new Point(left, right);
            titleBox.BackColor = Color.White;
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Multiline = true;
            titleBox.ReadOnly = true;
            titleBox.ScrollBars = RichTextBoxScrollBars.None;
            titleBox.MouseEnter += Element_MouseEnter;
            titleBox = AddTextToRichTextBox(text, bottomLinePoint, titleBox);
            return titleBox;
        }

        private CheckBox CreateCheckBox(int left)
        {
         
            CheckBox checkBox = new CheckBox();
            checkBox.Text = "";
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            checkBox.Location = new Point(3, 16);
            checkBox.MouseEnter += Element_MouseEnter;
            return checkBox;
        }

        private Button CreateButton(int left)
        {
            
            Button button = new Button();
            button.MouseEnter += Element_MouseEnter;
            button.Location = new Point(left, 16);
            button.Size = new Size(25, 25);
            
            button.Enabled = true;


            return button;
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
            Button editButton = (Button)sender;
            Panel parentPanel = (Panel)editButton.Parent;
            editForm editForm = new editForm(getTagID(parentPanel));
            editForm.FormClosing += Form_FormClosing;
            editForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Panel parentPanel = (Panel)deleteButton.Parent;
            deleteForm deleteForm = new deleteForm(getTagID(parentPanel));
            deleteForm.FormClosing += Form_FormClosing;
            deleteForm.Show();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            
            Panel parentPanel = (Panel)checkBox.Parent;

            if (checkBox.Checked)
            {

                sqlOperations.updateCheckBox(getTagID(parentPanel));
                Reflesh();
            }
          
        }

        private int getTagID(Panel parentPanel)
        {
            int richTextBoxID=0;

                foreach (Control control in parentPanel.Controls)
                {
                    if (control is RichTextBox richTextBox)
                    {
                        richTextBoxID= Convert.ToInt32(richTextBox.Tag);
                        
                        break; 
                    }
                }
            return richTextBoxID;
        }
        private void Element_MouseEnter(object sender, EventArgs e)
        {

            Panel panel = (Panel)((Control)sender).Parent;
            panel.Tag = true;
            UpdateButtonVisibility(panel);
        }
        private void ToDo_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            
            panel.Tag = true;
            UpdateButtonVisibility(panel);
        }

        private void ToDo_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            
            panel.Tag = false;
            UpdateButtonVisibility(panel);
        }
        private void UpdateButtonVisibility(Panel panel)
        {
            bool buttonsVisible = (bool)panel.Tag;
            foreach (Control control in panel.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = buttonsVisible;
                }
            }
        }

        

        private void Element_MouseLeave(object sender, EventArgs e)
        {
            
            Panel panel = (Panel)((Control)sender).Parent;
            panel.Tag = false;
            UpdateButtonVisibility(panel);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

            Reflesh();
        }

        public void Reflesh()
        {
            toDoListPanel.Controls.Clear();
            CreateToDoPanel(monthCalendarMain.SelectionStart);
        }

        
    }

    

}

