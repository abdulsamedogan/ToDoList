using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void addListFormButton_Click(object sender, EventArgs e)

        {
            
            addListForm addListForm = new addListForm();
            addListForm.Show();
        }

        private void monthCalendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            panel4.Controls.Clear();
            List<List<string>> infoList = sqlOperations.getFromDate(monthCalendarMain.SelectionStart);
            for(int i = 0 ; i < infoList.Count; i++)
            {
               
                //writeList.Items.Add(infoList[i][j].ToString());
                CheckBox checkBox = new CheckBox();
                checkBox.Text = infoList[i][0].ToString();
                checkBox.Location = new Point(3, 16+(i*50));
                panel4.Controls.Add(checkBox);


                Label description = new Label();
                description.Text = infoList[i][1].ToString();
                description.Location = new Point(40,40 + (i * 50));
                panel4.Controls.Add(description);
                
                
                
            }
            //this.Controls.Add(mylist);
        }
    


    }
}
