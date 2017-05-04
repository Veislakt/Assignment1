using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.Net;
using System.Timers;

namespace OPC_DA_Client
{
    public partial class Form1 : Form
    {
        double temperature;
        string opcURL;
        bool run = false;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            run = true;
        }

        private void tmrRead_Tick(object sender, EventArgs e)
        {
            if (run)
            {
                opcURL = "opc://localhost/Matrikon.OPC.Simulation/Bucket Brigade.Real4";
                DataSocket dataSocket = new DataSocket();
                if (dataSocket.IsConnected)
                {
                    dataSocket.Disconnect();
                }
                dataSocket.Connect(opcURL, AccessMode.Read);
                dataSocket.Update();
                temperature = Convert.ToDouble(dataSocket.Data.Value);
                txtTemp.Text = temperature.ToString();
                tmCelcius.Value = temperature;
                tmFahrenheit.Value = temperature * 1.8 + 32;
                waveformGraph1.PlotYAppend(temperature);
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
