namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toPostButton_Click(object sender, EventArgs e)
        {
            Post newForm = new Post();
            newForm.Show();
        }

        private void toPutButton_Click(object sender, EventArgs e)
        {
            Put newForm = new Put();
            newForm.Show();
        }

        private void toReportButton_Click(object sender, EventArgs e)
        {
            Report newForm = new Report();
            newForm.Show();
        }

        private void editDepartment_Click(object sender, EventArgs e)
        {
            EditDepartment editDepartment = new EditDepartment();
            editDepartment.Show();
        }

        private void editDrivers_Click(object sender, EventArgs e)
        {
            EditDriver editDriver = new EditDriver();
            editDriver.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editEmployees_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee();
            editEmployee.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();
            DateTime dt = DateTime.Now;
            MessageBox.Show(dt.ToString());
            Data.CheckDevices();
        }
    }
}