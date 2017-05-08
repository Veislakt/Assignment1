using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Net;
using NationalInstruments;
using System.Threading;

namespace DataLoggingApp
{
    class Program
    {
        public static DateTime lastOPCTime;
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=MORTENH\SCHOOL;Initial Catalog=ScadaLab;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DatabaseConnection.connectionString = connectionString;
            lastOPCTime = DateTime.Now;
            Console.WriteLine("Logging application running, press enter to stop");
            Timer t = new Timer(TimerCallback, null, 0, 1000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            double OPCValue;
            DateTime OPCTime;
            string OPCStatus;
            string OPCQuality;
            string OPCVariable = "Real4";
            string SensorTag = "TT-01";
            OPCConnection OPCConn = new OPCConnection();
            OPCValue = OPCConn.GetValue(OPCVariable);
            OPCTime = OPCConn.GetTimeStamp(OPCVariable);
            //OPCStatus = OPCConn.GetStatus(OPCVariable);
            OPCQuality = OPCConn.GetQuality(OPCVariable);
            if (lastOPCTime != OPCTime)
            {
                DatabaseConnection.InsertMeasurement(OPCValue, OPCTime, "Not Available", OPCQuality, SensorTag);
                lastOPCTime = OPCTime;
            }
            //Console.WriteLine("In TimerCallback: " + DateTime.Now.ToString());
        }
    }
}
