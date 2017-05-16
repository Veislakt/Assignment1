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
            ////Dummy data generation starts
            //List<Alarm> alarmList = new List<Alarm>();
            //Alarm alarm1 = new Alarm(1, 1, DateTime.Now, 1, "New", 5);
            //Alarm alarm2 = new Alarm(2, 1, DateTime.Now.AddHours(-1), 2, "Acknowledged", 3);
            //alarm2.AcknowledgedTime = DateTime.Now.AddMinutes(-15);
            //alarm2.AcknowledgedBy = "MH";
            //Alarm alarm3 = new Alarm(3, 1, DateTime.Now.AddHours(-2), 3, "New", 1);
            //Alarm alarm4 = new Alarm(4, 1, DateTime.Now.AddMinutes(-30), 4, "Dismissed", 4);
            //alarmList.Add(alarm1);
            //alarmList.Add(alarm2);
            //alarmList.Add(alarm3);
            //alarmList.Add(alarm4);
            ////Dummy data generation ends
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
            if (severity >= 4)
            {
                dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
            else if (severity >= 2)
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

        private void FillAlarmList(List<DBAlarm> alarmList) //Will require List of alarm objects
        {
            //Use foreach structure to loop through the Disc Objects
            //Placeholder data for filling tableview
            foreach (DBAlarm alarm in alarmList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPending);
                row.Cells[0].Value = alarm.ActivationTime;
                row.Cells[1].Value = alarm.AcknowledgedTime;
                row.Cells[2].Value = alarm.AcknowledgedBy;
                row.Cells[3].Value = alarm.AlarmStatus;
                row.Cells[4].Value = alarm.Description;
                row.Cells[5].Value = alarm.Severity;
                row.Cells[6].Value = alarm.AlarmType;
                row.Cells[7].Value = alarm.AlarmLimit;
                row.Cells[8].Value = alarm.TagName;
                row.Cells[9].Value = alarm.Value;
                dgvPending.Rows.Add(row);
            }
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
            if (dgvPending.SelectedCells.Count > 0)
            {
                if (cboOperator.SelectedItem == null)
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
