using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AlarmApplication
{
    static class DatabaseCommunication
    {
        //connection string for testing database. 
        static string connectionString = @"Data Source=VEISLAKT\SCHOOL;Initial Catalog=ScadaLab;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Faulty conncetion string for testing purposes. Uncomment only for testing. 
        //static string connectionString = @"Data Source=VEISLAKT\SCHOOL2;Initial Catalog=DiscGolfTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static string errorInfo = "";

        static public List<DBAlarm> GetThrowData()
        {
            List<DBAlarm> throwData = new List<DBAlarm>();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStatement = @"SELECT * FROM Throw";
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DBAlarm alarmRow = new DBAlarm();
                        alarmRow.ActivationTime = Convert.ToDateTime(reader["ActivationTime"].ToString());
                        alarmRow.AcknowledgedTime = Convert.ToDateTime(reader["AcknowledgedTime"].ToString());
                        alarmRow.AcknowledgedBy = reader["AcknowledgedBy"].ToString();
                        alarmRow.AlarmStatus = reader["AlarmStatus"].ToString();
                        alarmRow.Description = reader["Description"].ToString();
                        alarmRow.Severity = Convert.ToInt32(reader["Severity"].ToString());
                        alarmRow.AlarmType = reader["AlarmType"].ToString();
                        alarmRow.AlarmLimit = Convert.ToDouble(reader["AlarmLimit"].ToString());
                        alarmRow.AlarmAudioVisual = reader["AlarmAudioVisual"].ToString();
                        alarmRow.TagName = reader["TagName"].ToString();
                        alarmRow.Value = Convert.ToDouble(reader["Value"].ToString());
                        throwData.Add(alarmRow);
                    }
                    connection.Close();
                    cmd.Dispose();
                }
                if (throwData.Count == 0)
                {
                    errorInfo = "No throw data in the selection";
                }
            }
            catch (Exception e)
            {
                errorInfo = e.ToString();
            }

            return throwData;
        }

        static public string GetErrorInfo()
        {
            return errorInfo;
        }
    }
}
