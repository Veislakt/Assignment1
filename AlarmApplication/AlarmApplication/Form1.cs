﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            //Dummy data generation starts
            List<Alarm> alarmList = new List<Alarm>();
            Alarm alarm1 = new Alarm(1, 1, DateTime.Now, 1, "New", 5);
            Alarm alarm2 = new Alarm(2, 1, DateTime.Now.AddHours(-1), 2, "Acknowledged", 3);
            alarm2.AcknowledgedTime = DateTime.Now.AddMinutes(-15);
            alarm2.AcknowledgedBy = "MH";
            Alarm alarm3 = new Alarm(3, 1, DateTime.Now.AddHours(-2), 3, "New", 1);
            Alarm alarm4 = new Alarm(4, 1, DateTime.Now.AddMinutes(-30), 4, "Dismissed", 4);
            alarmList.Add(alarm1);
            alarmList.Add(alarm2);
            alarmList.Add(alarm3);
            alarmList.Add(alarm4);
            //Dummy data generation ends
            alarmList = alarmList.OrderByDescending(o => o.Severity).ToList();
            dgvPending.DataSource = alarmList;
            this.dgvPending.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPending_RowPrePaint);
            dgvPending.Refresh();
        }

        private void dgvPending_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(dgvPending.Rows[e.RowIndex].Cells[8].Value) >= 4)
            {
                dgvPending.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
