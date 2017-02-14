using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAssignment1
{
    public partial class Form1 : Form
    {
        //Initializing variables
        Sensor sens1 = new Sensor(1);
        Sensor sens2 = new Sensor(2);
        Sensor sens3 = new Sensor(3);
        Sensor sens4 = new Sensor(4);
        DateTime nextSample = DateTime.Now;
        DateTime nextLogging = DateTime.Now;
        DateTime now;
        public Form1()
        {
            InitializeComponent();
            txtNextSampleTime.Text = nextSample.ToString("HH:mm:ss.ff");
            txtNextLoggingTime.Text = nextLogging.ToString("HH:mm:ss.ff");


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            now = DateTime.Now;
            if (now > nextSample)
            {
                txtSensorValues.Text = "Sensor 1:\r\n" + Convert.ToString(sens1.GetValue());
                txtSensorValues.Text += "\r\nSensor 2:\r\n" + Convert.ToString(sens2.GetValue());
                txtSensorValues.Text += "\r\nSensor 3:\r\n" + Convert.ToString(sens3.GetValue());
                txtSensorValues.Text += "\r\nSensor 4:\r\n" + Convert.ToString(sens4.GetValue());
                nextSample = now.AddMilliseconds(1400);
                txtNextSampleTime.Text = nextSample.ToString("HH:mm:ss.ff");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {

        }
    }
}
