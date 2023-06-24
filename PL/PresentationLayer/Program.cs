using MySql.Data.MySqlClient;
using System.Data;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //Application.Run(new Post());
            // Создание таймера
            var timer = new System.Threading.Timer(
                e => CheckDevices(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromMinutes(1)); //заменить на 10


            while (true) { }

        }

        private static void CheckDevices()
        {   //MessageBox.Show("Метод запустился");
            string connectionString = "server = localhost; user=root; password=12345678; database=fleshdrivers";
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM issued_drivers", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                DateTime dateOfReturn = Convert.ToDateTime(row["date_of_return"]);
                int returnMark = Convert.ToInt32(row["mark"]);
                if (dateOfReturn < DateTime.Now && returnMark !=1)
                {
                    int employeeId = Convert.ToInt32(row["employee_id"]);
                    MessageBox.Show(employeeId.ToString());
                }
            }
            connection.Close();

        }
    }
}
