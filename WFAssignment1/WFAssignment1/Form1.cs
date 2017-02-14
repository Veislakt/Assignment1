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
        double[] sensVals = new double[4];
        DateTime nextSample = DateTime.Now;
        DateTime nextLogging = DateTime.Now;
        DateTime nowS;
        DateTime nowL;
        string fileHeader = "Logging Time;Reading Time;Sensor 1;Sensor 2;Sensor 3;Sensor 4";
        bool sampled = false;

        public Form1()
        {
            InitializeComponent();
            txtNextSampleTime.Text = nextSample.ToString("HH:mm:ss.ff");
            txtNextLoggingTime.Text = nextLogging.ToString("HH:mm:ss.ff");
            var lineCount = System.IO.File.ReadLines(System.IO.Directory.GetCurrentDirectory() + @"\LogFile.csv").Count();
            lineCount -= 1;
            txtLogged.Text = lineCount.ToString();
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
            nowS = DateTime.Now; //activation time is taken immediately so that the time is between activation rather than a wait after completion. 
            if (nowS > nextSample)
            {
                sensVals[0] = sens1.GetValue();
                sensVals[1] = sens2.GetValue();
                sensVals[2] = sens3.GetValue();
                sensVals[3] = sens4.GetValue();
                txtSensorValues.Text = "Sensor 1:\r\n" + Convert.ToString(sensVals[0]);
                txtSensorValues.Text += "\r\nSensor 2:\r\n" + Convert.ToString(sensVals[1]);
                txtSensorValues.Text += "\r\nSensor 3:\r\n" + Convert.ToString(sensVals[2]);
                txtSensorValues.Text += "\r\nSensor 4:\r\n" + Convert.ToString(sensVals[3]);
                nextSample = nowS.AddMilliseconds(1400);
                sampled = true;
                txtNextSampleTime.Text = nextSample.ToString("HH:mm:ss.ff");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            nowL = DateTime.Now;
            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\LogFile.csv") == false)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\LogFile.csv", true))
                {
                    file.WriteLine(fileHeader);
                }
            }
            if (sampled)
            {
                if (nowL > nextLogging)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + @"\LogFile.csv", true))
                    {
                        string logTime = nowL.ToString("dd/MM/yy HH:mm:ss.ff");
                        string sensTime = nowS.ToString("dd/MM/yy HH:mm:ss.ff");
                        string line = logTime + ";" + sensTime;
                        foreach (double sensVal in sensVals)
                        {
                            line += ";" + sensVal.ToString();
                        }
                        file.WriteLine(line);
                    }
                    nextLogging = nowL.AddMilliseconds(37000);
                    txtNextLoggingTime.Text = nextLogging.ToString("HH:mm:ss.ff");
                    var lineCount = System.IO.File.ReadLines(System.IO.Directory.GetCurrentDirectory() + @"\LogFile.csv").Count();
                    lineCount -= 1;
                    txtLogged.Text = lineCount.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please sample before you try to log values");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DAQ Simulator \r\nThis is a program for simulating data from sensors, all the data is dummy data. "
                + "\r\nNext Sampling Time: Next time the sampling is available "
                + "\r\nSampling: Push this button to sample data from the dummy sensors "
                + "\r\nNext Logging Time: Next time the logging is available "
                + "\r\nLogging on File: Push this button to log the sensor values to a .csv file "
                + "\r\nNumber of datasets logged: Shows the number of complete sets of data that are logged in the log file "
                + "\r\nSensor Values: Lists the last values for all sensors ");
        }
    }
}
