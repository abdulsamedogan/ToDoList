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

namespace ToDoList.Forms
{
    public partial class editForm : Form
    {
        int ID;
        public editForm(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            string[] values = sqlOperations.getValueByID(ID);
            editTitle.Text = values[0];
            editDescription.Text = values[1];
        }

        private void editTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            sqlOperations.updateTitleAndDescription(ID,editTitle.Text,editDescription.Text);
            this.Close();
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
