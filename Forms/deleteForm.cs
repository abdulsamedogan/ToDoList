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
    public partial class deleteForm : Form
    {
        int ID;
        public deleteForm(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }
        private void deleteForm_Load(object sender, EventArgs e)
        {
            string[] values = sqlOperations.getValueByID(ID);
            deleteTitle.Text = values[0];
            deleteDescription.Text = values[1];
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            sqlOperations.DeleteDataByID(ID);
            this.Close();
        }

        
    }
}
