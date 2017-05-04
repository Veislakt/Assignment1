using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Net;
using NationalInstruments;

namespace TestApplicationOPC
{
    class OPCConnection
    {
        string opcUrlBase = "opc://localhost/Matrikon.OPC.Simulation/Bucket Brigade.";

        public double GetValue(string Variable)
        {
            double value;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected)
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            value = Convert.ToDouble(dataSocket.Data.Value);
            return value;
        }

        public string GetQuality(string Variable)
        {
            string quality;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected)
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            quality = dataSocket.Data.Attributes["Quality"].Value.ToString();
            return quality;
        }

        public DateTime GetTimeStamp(string Variable)
        {
            DateTime timeStamp;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected)
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            timeStamp = Convert.ToDateTime(dataSocket.Data.Attributes["TimeStamp"].Value.ToString());
            return timeStamp;
        }
    }
}
