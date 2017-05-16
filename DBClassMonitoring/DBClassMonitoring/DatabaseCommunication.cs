using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBClassMonitoring
{
    static class DatabaseCommunication
    {
        //connection string for testing database. 
        static string connectionString = @"Data Source=VEISLAKT\SCHOOL;Initial Catalog=ScadaLab;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static string errorInfo = "";

        static public List<DBMeasurements> GetMeasurementData()
        {
            List<DBMeasurements> DBAlarmData = new List<DBMeasurements>();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStatement = @"SELECT * FROM MeasurementsView";
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DBMeasurements measurementsRow = new DBMeasurements();
                        measurementsRow.MeasId = Convert.ToInt32(reader["MeasId"].ToString());
                        measurementsRow.Value = Convert.ToDouble(reader["Value"].ToString());
                        measurementsRow.TimeStamp = Convert.ToDateTime(reader["TimeStamp"].ToString());
                        measurementsRow.TagId = Convert.ToInt32(reader["TagId"].ToString());
                        measurementsRow.TagName = reader["TagName"].ToString();
                        DBAlarmData.Add(measurementsRow);
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

        static public List<DBMeasurements> GetMeasurementData(string TagName)
        {
            List<DBMeasurements> DBAlarmData = new List<DBMeasurements>();
            errorInfo = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlStatement = @"SELECT * FROM MeasurementsView WHERE TagName = '";
                    sqlStatement += TagName + "'";
                    SqlCommand cmd = new SqlCommand(sqlStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DBMeasurements measurementsRow = new DBMeasurements();
                        measurementsRow.MeasId = Convert.ToInt32(reader["MeasId"].ToString());
                        measurementsRow.Value = Convert.ToDouble(reader["Value"].ToString());
                        measurementsRow.TimeStamp = Convert.ToDateTime(reader["TimeStamp"].ToString());
                        measurementsRow.TagId = Convert.ToInt32(reader["TagId"].ToString());
                        measurementsRow.TagName = reader["TagName"].ToString();
                        DBAlarmData.Add(measurementsRow);
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

        static public string GetErrorInfo()
        {
            return errorInfo;
        }
    }
}
