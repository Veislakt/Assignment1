using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.Net;
using NationalInstruments;

namespace DataLoggingApp
{
    class OPCConnection
    {
        string opcUrlBase = @"opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.";

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
            dataSocket.Disconnect();
            return quality;
        }

        public string GetStatus(string Variable)
        {
            string status;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected)
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            status = dataSocket.Data.Attributes["Status"].Value.ToString();
            dataSocket.Disconnect();
            return status;
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
            timeStamp = Convert.ToDateTime(dataSocket.Data.Attributes["Timestamp"].Value.ToString());
            dataSocket.Disconnect();
            return timeStamp;
        }

        public void SetValue(string Variable, double Value)
        {
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected)
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Write);
            dataSocket.Data.Value = Value;
            dataSocket.Update();
            dataSocket.Disconnect();
        }
    }
}
