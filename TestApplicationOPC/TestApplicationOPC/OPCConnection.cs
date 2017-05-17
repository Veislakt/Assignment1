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

        /// <summary>
        /// Gets the value from the variable
        /// </summary>
        /// <param name="Variable">OPC Variable name</param>
        /// <returns>Value of the OPC variable</returns>
        public double GetValue(string Variable)
        {
            double value;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected) //Disconnects any previous connections before connecting;
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            value = Convert.ToDouble(dataSocket.Data.Value);
            return value;
        }

        /// <summary>
        /// Gets the quality parameter from the variable
        /// </summary>
        /// <param name="Variable">OPC Variable name</param>
        /// <returns>Quality of the OPC variable</returns>
        public string GetQuality(string Variable)
        {
            string quality;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected) //Disconnects any previous connections before connecting;
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            quality = dataSocket.Data.Attributes["Quality"].Value.ToString(); //Reads the Quality 
            dataSocket.Disconnect();
            return quality;
        }

        /// <summary>
        /// NB! Does not work!
        /// </summary>
        /// <param name="Variable">OPC Variable name</param>
        /// <returns>Status of the OPC Variable</returns>
        public string GetStatus(string Variable)
        {
            string status;
            string opcUrl = opcUrlBase + Variable;
            DataSocket dataSocket = new DataSocket();
            if (dataSocket.IsConnected) //Disconnects any previous connections before connecting;
            {
                dataSocket.Disconnect();
            }
            dataSocket.Connect(opcUrl, AccessMode.Read);
            dataSocket.Update();
            status = dataSocket.Data.Attributes["Status"].Value.ToString();
            dataSocket.Disconnect();
            return status;
        }

        /// <summary>
        /// Gets the timestamp from the Variable, showing when the Variable was last written to. 
        /// </summary>
        /// <param name="Variable">OPC Variable name</param>
        /// <returns>Timestamp of the OPC Variable</returns>
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

        /// <summary>
        /// Writes a value to the OPC Variable
        /// </summary>
        /// <param name="Variable">OPC Variable name</param>
        /// <param name="Value">New value for the OPC Variable</param>
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
