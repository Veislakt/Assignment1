﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DiscGolfTracker
{
    static class DatabaseCommunication
    {
        //connection string for testing database. 
        static string connectionString = @"Data Source=VEISLAKT\SCHOOL;Initial Catalog=DiscGolfTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Faulty conncetion string for testing purposes. Uncomment only for testing. 
        //static string connectionString = @"Data Source=VEISLAKT\SCHOOL2;Initial Catalog=DiscGolfTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static string errorInfo = "";

        static public List<Throw> GetThrowData()
        {
            List<Throw> throwData = new List<Throw>();
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
                        Throw throwRow = new Throw();
                        throwRow.ThrowId = Convert.ToInt32(reader["ThrowId"].ToString());
                        throwRow.DiscId = Convert.ToInt32(reader["DiscId"].ToString());
                        throwRow.ThrowType = reader["ThrowType"].ToString();
                        throwRow.Distance = Convert.ToInt32(reader["Distance"].ToString());
                        throwRow.Accuracy = Convert.ToInt32(reader["Accuracy"].ToString());
                        throwRow.ThrowQuality = Convert.ToInt32(reader["ThrowQuality"].ToString());
                        throwRow.Park = reader["Park"].ToString();
                        throwRow.Hole = Convert.ToInt32(reader["Hole"].ToString());
                        throwData.Add(throwRow);
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
