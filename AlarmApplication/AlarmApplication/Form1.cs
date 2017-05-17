using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmApplication
{
    public partial class Form1 : Form
    {
        List<DBAlarm> alarmList;
        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Data Source=VEISLAKT\SCHOOL;Initial Catalog=ScadaLab;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DatabaseCommunication.connectionString = connectionString;
            alarmList = new List<DBAlarm>();
            alarmList = DatabaseCommunication.GetAlarmData();
            alarmList = alarmList.OrderByDescending(o => o.Severity).ToList();
            dgvPending.DataSource = alarmList;
            this.dgvPending.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPending_RowPrePaint);
            dgvPending.Refresh();
            tmrRefresh.Start();
        }

        private void dgvPending_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int severity = Convert.ToInt32(dgvPending.Rows[e.RowIndex].Cells[6].Value);
            string audioVisual = dgvPending.Rows[e.RowIndex].Cells[9].Value.ToString();
            if (severity >= 4 | audioVisual.Contains("Red"))
            {
                dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
            else if (severity >= 2 | audioVisual.Contains("Orange"))
            {
                dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            List<DBAlarm> newAlarmList = new List<DBAlarm>();
            newAlarmList = DatabaseCommunication.GetAlarmData();
            newAlarmList = newAlarmList.OrderByDescending(o => o.Severity).ToList();
            bool listContainsSameData = CheckAlarmListsEquality(alarmList, newAlarmList);
            if (!listContainsSameData)
            {
                alarmList = newAlarmList;
                dgvPending.DataSource = alarmList;
                dgvPending.Refresh();
            }
        }

        /// <summary>
        /// Checks if each list has an equivalent row with the same alarmId and alarm status in the other list
        /// </summary>
        /// <param name="alarmList1">Old alarm list</param>
        /// <param name="alarmList2">New alarm list</param>
        /// <returns>returns true if the lists are equal</returns>
        private bool CheckAlarmListsEquality(List<DBAlarm> alarmList1, List<DBAlarm> alarmList2)
        {
            bool allExists = true;
            bool existsInNew = false;
            foreach (DBAlarm oldAlarm in alarmList1)
            {
                existsInNew = false;
                foreach (DBAlarm newAlarm in alarmList2)
                {
                    if (!existsInNew)
                    {
                        existsInNew = ((oldAlarm.AlarmId == newAlarm.AlarmId) && (oldAlarm.AlarmStatus == newAlarm.AlarmStatus));
                    }
                }
                if (allExists)
                {
                    allExists = existsInNew;
                }
            }
            foreach (DBAlarm newAlarm in alarmList2)
            {
                existsInNew = false;
                foreach (DBAlarm oldAlarm in alarmList1)
                {
                    if (!existsInNew)
                    {
                        existsInNew = ((oldAlarm.AlarmId == newAlarm.AlarmId) && (oldAlarm.AlarmStatus == newAlarm.AlarmStatus));
                    }
                }
                if (allExists)
                {
                    allExists = existsInNew;
                }
            }
            return allExists;
        }
        
        private void btnAcknowledgeAlarm_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedCells.Count > 0) //No cell selected
            {
                if (cboOperator.SelectedItem == null) //No operator selected
                {
                    MessageBox.Show("Please select an operator before acknowledging an alarm");
                }
                else
                {
                    int selectedRowId = dgvPending.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvPending.Rows[selectedRowId];
                    if (selectedRow.Cells["AlarmStatus"].Value.ToString() == "Acknowledged")
                    {
                        MessageBox.Show("This alarm has already been Acknowledged");
                    }
                    else
                    {
                        string currentOperator = cboOperator.SelectedItem.ToString();
                        int selectedAlarmId = Convert.ToInt32(selectedRow.Cells["AlarmId"].Value.ToString());
                        DateTime currentTime = DateTime.Now;
                        string alarmStatus = "Acknowledged";
                        DatabaseCommunication.UpdateAlarmStatus(currentOperator, alarmStatus, currentTime, selectedAlarmId);
                    }
                }
            }
        }

        private void btnDismissAlarm_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedCells.Count > 0)
            {
                if (cboOperator.SelectedItem == null)
                {
                    MessageBox.Show("Please select an operator before dismissing an alarm");
                }
                else
                {
                    string currentOperator = cboOperator.SelectedItem.ToString();
                    int selectedRowId = dgvPending.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvPending.Rows[selectedRowId];
                    int selectedAlarmId = Convert.ToInt32(selectedRow.Cells["AlarmId"].Value.ToString());
                    DateTime currentTime = DateTime.Now;
                    DatabaseCommunication.DismissAlarm(selectedAlarmId, currentOperator);
                }
            }
            string error = DatabaseCommunication.GetErrorInfo();
        }
    }
}
