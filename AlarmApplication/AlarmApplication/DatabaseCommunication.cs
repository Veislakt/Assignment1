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
        public static string connectionString { get; set; }
        static string errorInfo = "";

        static public List<DBAlarm> GetAlarmData()
        {
            List<DBAlarm> DBAlarmData = new List<DBAlarm>();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStatement = @"SELECT * FROM ActiveAlarmsView";
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DBAlarm alarmRow = new DBAlarm();
                        alarmRow.AlarmId = Convert.ToInt32(reader["AlarmId"].ToString());
                        alarmRow.ActivationTime = Convert.ToDateTime(reader["ActivationTime"].ToString());
                        if (reader["AlarmStatus"].ToString() != "Unacknowledged")
                        {
                            alarmRow.AcknowledgedTime = Convert.ToDateTime(reader["AcknowledgedTime"].ToString());
                            alarmRow.AcknowledgedBy = reader["AcknowledgedBy"].ToString();
                        }
                        alarmRow.AlarmStatus = reader["AlarmStatus"].ToString();
                        alarmRow.Description = reader["Description"].ToString();
                        alarmRow.Severity = Convert.ToInt32(reader["Severity"].ToString());
                        alarmRow.AlarmType = reader["AlarmType"].ToString();
                        alarmRow.AlarmLimit = Convert.ToDouble(reader["AlarmLimit"].ToString());
                        alarmRow.AlarmAudioVisual = reader["AlarmAudioVisual"].ToString();
                        alarmRow.TagName = reader["TagName"].ToString();
                        //alarmRow.Value = Convert.ToDouble(reader["Value"].ToString());
                        DBAlarmData.Add(alarmRow);
                    }
                    connection.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception e)
            {
                errorInfo = e.ToString();
            }

            return DBAlarmData;
        }

        static public void UpdateAlarmStatus(string AcknowledgedBy, string AlarmStatus, DateTime AcknowledgedTime, int AlarmId)
        {
            string sqlStatement = @"UPDATE Alarm SET AcknowledgedBy = '";
            sqlStatement += AcknowledgedBy + "', AlarmStatus = '" + AlarmStatus + "', AcknowledgedTime = '" + AcknowledgedTime.ToString("yyyy-MM-dd HH:mm:ss");
            sqlStatement += "' WHERE AlarmId = " + AlarmId.ToString();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                errorInfo = e.ToString();
            }
        }

        static public void DismissAlarm(int AlarmId, string AcknowledgedBy)
        {
            string sqlStatement = @"UPDATE Alarm SET AcknowledgedBy = '";
            sqlStatement += AcknowledgedBy + "', AlarmStatus = 'Dismissed'";
            sqlStatement += " WHERE AlarmId = " + AlarmId.ToString();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                errorInfo = e.ToString();
            }
        }

        static public string GetErrorInfo()
        {
            return errorInfo;
        }
    }
}
