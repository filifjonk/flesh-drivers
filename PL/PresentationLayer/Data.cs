using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class Data
    {
        public static int EmployeeID;
        public static int DriverID;
        static public void GetEmployeeID(string lastName, string firstName)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT ID from employee WHERE last_name = '" + lastName + "' and first_name = '" + firstName + "'";
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    EmployeeID = Convert.ToInt32(result);
                    //MessageBox.Show(EmployeeID.ToString());
                }
                else
                {
                    MessageBox.Show("Couldn't get user ID");
                }
            }
            catch
            {
                MessageBox.Show("Request rejected");
            }
        }
        static public void GetDriverID(string serialNumber)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT ID from drivers WHERE serial_number = '" + serialNumber + "'";
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    DriverID = Convert.ToInt32(result);
                    //MessageBox.Show(DriverID.ToString());
                }
                else
                {
                    MessageBox.Show("Couldn't get driver");
                }
            }
            catch
            {
                MessageBox.Show("Request rejected");
            }
        }
        static public void SendingIssueRequest(DateTime dateIssue, DateTime dateReturn, string phoneNumber )
        {
            try
            {
                string dateIssueFormat = dateIssue.ToString("yyyy-MM-dd HH:mm:ss");
                string dateReturnFormat = dateReturn.ToString("yyyy-MM-dd HH:mm:ss");
                //dateIssueFormat = dateIssueFormat.Replace("/", "-");
                //dateReturnFormat = dateReturnFormat.Replace("/", "-");
                DBconnection.msCommand.CommandText = @"INSERT INTO issued_drivers(driver_id, employee_id, date_of_issue, date_of_return) VALUES ('" + DriverID + "', '" + EmployeeID + "', '" + dateIssueFormat + "', '" + dateReturnFormat + "')";
                DBconnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные успешно отправлены");
            }
            catch
            {
                MessageBox.Show("Request rejected");
            }
        }
        static public void PutReturnIssueRequest()
        {
            try
            {
                DateTime now = DateTime.Now;
                string currentDateFormat = now.ToString("yyyy-MM-dd HH:mm:ss");
                DBconnection.msCommand.CommandText = @"UPDATE issued_drivers SET fact_return = '" + currentDateFormat + "', mark = 1 WHERE driver_id = '" + DriverID + "' and employee_id = '" + EmployeeID + "'";
                DBconnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные успешно получены");

        }
            catch
            {
                MessageBox.Show("Request rejected");
            }
}
    }
}
