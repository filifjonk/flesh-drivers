using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class DBconnection
    {
        static string DBconnect = "server = localhost; user=root; password=12345678; database=fleshdrivers";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myConnect;
        static public MySqlCommand msCommand;
        public static bool ConnectionDB()
        {
            try
            {
                myConnect = new MySqlConnection(DBconnect);
                myConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                //MessageBox.Show("Подключение успешно");
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения", "Error of DB", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        }
        public static void CloseDB()
        {
            myConnect.Close();
        }
        public MySqlConnection getConnection()
        {
            return myConnect;
        }
    }
}
