using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestApplicationOPC
{
    class DatabaseConnection
    {
        public static string connectionString { get; set; }
        public static string errorString { get; private set; }
        public static List<string[]> GetTable(string SensorId, List<string> Columns, DateTime StartTime, DateTime EndTime)
        {
            bool CTime = false;
            bool CSensorId = false;
            bool CSensorName = false;
            bool CValue = false;
            bool CMesUnit = false;
            int columnCount = Columns.Count;
            List<string[]> dbStringArray = new List<String[]>(columnCount);
            List<string> headerList;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string SelectStatement;
                    SelectStatement = "SELECT[";
                    headerList = new List<String>();
                    foreach (string column in Columns)
                    {
                        switch (column)
                        {
                            case "Time": { CTime = true; } break;
                            case "SensorId": { CSensorId = true; } break;
                            case "SensorName": { CSensorName = true; } break;
                            case "Unit": { CMesUnit = true; } break;
                            case "Value": { CValue = true; } break;
                        }
                        if (SelectStatement == "SELECT [")
                        {
                            SelectStatement += column + "]";
                        }
                        else
                        {
                            SelectStatement += ", [" + column + "]";
                        }
                    }
                    SelectStatement += " From DatabaseLab WHERE ([SensorId] = '" + SensorId + "'";
                    if ((StartTime != null) && (EndTime != null))
                    {
                        SelectStatement += "AND [Time] BETWEEN '" + StartTime.ToString("MM/dd/yyyy HH:mm:ss") + "' AND '" + EndTime.ToString("MM/dd/yyyy HH:mm:ss") + "'";
                    }
                    SelectStatement += "ORDER BY [MeasurementId] ASC;";
                    SqlCommand cmd = new SqlCommand(SelectStatement);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[columnCount];
                        int columnnr = 0;
                        if (CTime)
                        {
                            DateTime time = Convert.ToDateTime(reader["Time"]);
                            string timestring = Convert.ToString(time);
                            row[columnnr] = timestring;
                            columnnr++;
                        }
                        if (CSensorId)
                        {
                            string sensorId = reader["SensorId"].ToString();
                            row[columnnr] = sensorId;
                            columnnr++;
                        }
                        if (CSensorName)
                        {
                            string sensorName = reader["SensorName"].ToString();
                            row[columnnr] = sensorName;
                            columnnr++;
                        }
                        if (CMesUnit)
                        {
                            string mesUnit = reader["Unit"].ToString();
                            row[columnnr] = mesUnit;
                            columnnr++;
                        }
                        if (CValue)
                        {
                            string value = reader["Value"].ToString();
                            row[columnnr] = value;
                            columnnr++;
                        }
                        dbStringArray.Add(row);
                    }
                    connection.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception e)
            {
                errorString = e.ToString();
            }

            return dbStringArray;
        }
    }
}
