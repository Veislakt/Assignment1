using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClassMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DBMeasurements> testList = new List<DBMeasurements>();
            testList = DatabaseCommunication.GetMeasurementData("T-01");
            string errorS = DatabaseCommunication.GetErrorInfo();
            Console.ReadLine();
        }
    }
}
