using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();
            Data.GetEmployeeID(employeeField.Text, employeeNameField.Text);
            Data.GetDriverID(numberField.Text);
            Data.SendingIssueRequest(DateTime.Parse(dataIssueField.Text), DateTime.Parse(dateReturnField.Text), phoneField.Text);
        }
    }
}
