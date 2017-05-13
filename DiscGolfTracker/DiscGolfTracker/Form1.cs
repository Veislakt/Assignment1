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
        private List<Throw> ThrowTable;
        public Form1()
        {
            InitializeComponent();
            string[] dummyDiscTypes = new string[3] { "Driver", "Midrange", "Putter" }; //Dummy data to show functionality
            string[] dummyThrowTypes = new string[2] { "Forehand", "Backhand" }; //Dummy data to show functionality
            string[] dummyDiscDetails = new string[6] { "Disc Type", "Turning Direction", "Colour", "Producent", "Name", "Producent Stats. i.e. stability, distance, speed"}; //Dummy data to show functionality
            FillComboBoxes(dummyDiscTypes, dummyThrowTypes); //Uses dummy data
            FillDiscData(); //Demonstates GUI, full method will need data
            FillDiscDetails(dummyDiscDetails);
        }

        private void FillComboBoxes(string[] DiscTypes, string[] ThrowTypes)
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

        private void FillDiscData() //Will require List of Disc objects and statistics list/array
        {
            //Use foreach structure to loop through the Disc Objects
            //Placeholder data for filling tableview
            string type = "DiscType";
            string turningDir = "TurningDirection";
            string colour = "Colour";
            string producent = "Producent";
            string name = "Name";
            string avgAccuracy = "Average accuracy";
            string avgQuality = "Average quality";
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvDiscData);
            row.Cells[0].Value = type;
            row.Cells[1].Value = turningDir;
            row.Cells[2].Value = colour;
            row.Cells[3].Value = producent;
            row.Cells[4].Value = name;
            row.Cells[5].Value = avgAccuracy;
            row.Cells[6].Value = avgQuality;
            dgvDiscData.Rows.Add(row);
        }

        private void FillDiscDetails(string[] DiscDetails)
        {
            if(DiscDetails.Length == 6)
            {
                txtSelType.Text = DiscDetails[0];
                txtSelTurningDir.Text = DiscDetails[1];
                txtSelColour.Text = DiscDetails[2];
                txtSelProducent.Text = DiscDetails[3];
                txtSelName.Text = DiscDetails[4];
                txtSelProducentStats.Text = DiscDetails[5];
            }
            else
            {
                MessageBox.Show("Wrong array length in FillDisc method");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDiscData_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCommitNewThrow_Click(object sender, EventArgs e)
        {
            //run Save Throw method
            MessageBox.Show("Will run method to save throw");
        }

        private void btnDeleteDisc_Click(object sender, EventArgs e)
        {
            //run Delete disc method
            MessageBox.Show("Will run method to delete disc");
        }

        private void btnAddDisc_Click(object sender, EventArgs e)
        {
            //run add disc method
            MessageBox.Show("Will run method to add disc");
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //run get data method
            //populate dgvDiscData with FillDiscData() method once completed. 

            //Code for testing the GetThrowData method and usecase. 
            List<Throw> ThrowTable = new List<Throw>();
            ThrowTable = DatabaseCommunication.GetThrowData();
            if (ThrowTable.Count > 0)
            {
                MessageBox.Show("Successful retrieval of Throw Data");
            }
            else
            {
                MessageBox.Show("Failed to retrieve Throw data\r\nError Code:\r\n" + DatabaseCommunication.GetErrorInfo());
            }
            //ThrowTable to be used in further usecases, presence of data in throw table shows working GetThrowData method
        }
    }
}
