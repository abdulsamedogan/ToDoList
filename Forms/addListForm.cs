using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.SqlClasses;

namespace ToDoList
{
    public partial class addListForm : Form
    {
        public addListForm()
        {
            InitializeComponent();
        }

        private void addListForm_Load(object sender, EventArgs e)
        {

        }

        private void addListButton_Click(object sender, EventArgs e)
        {
           
            sqlOperations.addListValue(DateTime.Now,titleBox.Text, descriptionBox.Text,true);
           
            this.Close();
        }
    }
}
