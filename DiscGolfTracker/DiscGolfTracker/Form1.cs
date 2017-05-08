using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscGolfTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] dummyDiscTypes = new string[3] { "Driver", "Midrange", "Putter" }; //Dummy data to show functionality
            string[] dummyThrowTypes = new string[2] { "Forehand", "Backhand" }; //Dummy data to show functionality
            FillComboBoxes(dummyDiscTypes, dummyThrowTypes); //Uses dummy data
        }

        public void FillComboBoxes(string[] DiscTypes, string[] ThrowTypes)
        {
            string[] distances = new string[6] { "0-10", "10-25", "25-50", "50-100", "100-200", "200+" }; //Designed array of distance brackets
            //Clears the items of each combo box and adds the empty field to allow for not selecting. 
            cboDiscType.Items.Clear();
            cboDiscType.Items.Add("");
            cboTurningDir.Items.Clear();
            cboTurningDir.Items.Add("");
            cboDistance.Items.Clear();
            cboDistance.Items.Add("");
            cboThrowType.Items.Clear();
            cboThrowType.Items.Add("");
            cboMinAccuracy.Items.Clear();
            cboMinAccuracy.Items.Add("");
            //Fill cboDiscType
            foreach (string discType in DiscTypes)
            {
                cboDiscType.Items.Add(discType);
            }
            //Fill cboTurningDir
            cboTurningDir.Items.Add("Over stable");
            cboTurningDir.Items.Add("Under stable");
            //Fill cboDistance
            foreach (string distance in distances)
            {
                cboDistance.Items.Add(distance);
            }
            //Fill cboThrowType
            foreach (string throwType in ThrowTypes)
            {
                cboThrowType.Items.Add(throwType);
            }
            //Fill cboMinAccuracy
            for (int i = 1; i <= 10; i++)
            {
                cboMinAccuracy.Items.Add(Convert.ToString(i));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDiscData_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
