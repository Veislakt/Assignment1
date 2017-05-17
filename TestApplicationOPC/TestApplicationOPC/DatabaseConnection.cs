using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLoggingApp
{
    class DatabaseConnection
    {
        public static string connectionString { get; set; }
        public static string errorString { get; private set; }

        public static void InsertMeasurement(double Measurement, DateTime MeasurementTime, string OPCStatus, string OPCQuality, string Tag)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertMeasurement", connection);
                    SqlParameter measurementParam = new SqlParameter("@Measurement", SqlDbType.Float);
                    SqlParameter timeParam = new SqlParameter("@MeasurementTime", SqlDbType.DateTime);
                    SqlParameter statusParam = new SqlParameter("@OPCStatus", SqlDbType.VarChar);
                    SqlParameter qualityParam = new SqlParameter("@OPCQuality", SqlDbType.VarChar);
                    SqlParameter tagParam = new SqlParameter("@Tag", SqlDbType.VarChar);
                    measurementParam.Value = Measurement;
                    timeParam.Value = MeasurementTime;
                    statusParam.Value = OPCStatus;
                    qualityParam.Value = OPCQuality;
                    tagParam.Value = Tag;
                    cmd.Parameters.Add(measurementParam);
                    cmd.Parameters.Add(timeParam);
                    cmd.Parameters.Add(statusParam);
                    cmd.Parameters.Add(qualityParam);
                    cmd.Parameters.Add(tagParam);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                errorString = e.ToString();
            }
        }
    }
}
