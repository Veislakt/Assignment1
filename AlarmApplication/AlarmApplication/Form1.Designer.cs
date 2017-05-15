namespace AlarmApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcknowledgedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcknowledgedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPending
            // 
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivationTime,
            this.AcknowledgedTime,
            this.AcknowledgedBy,
            this.AlarmStatus,
            this.Description,
            this.Severity,
            this.AlarmType,
            this.AlarmLimit,
            this.TagName,
            this.Value});
            this.dgvPending.Location = new System.Drawing.Point(12, 29);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.Size = new System.Drawing.Size(1044, 187);
            this.dgvPending.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Alarms";
            // 
            // ActivationTime
            // 
            this.ActivationTime.HeaderText = "ActivationTime";
            this.ActivationTime.Name = "ActivationTime";
            this.ActivationTime.ReadOnly = true;
            // 
            // AcknowledgedTime
            // 
            this.AcknowledgedTime.HeaderText = "AcknowledgedTime";
            this.AcknowledgedTime.Name = "AcknowledgedTime";
            this.AcknowledgedTime.ReadOnly = true;
            // 
            // AcknowledgedBy
            // 
            this.AcknowledgedBy.HeaderText = "AcknowledgedBy";
            this.AcknowledgedBy.Name = "AcknowledgedBy";
            this.AcknowledgedBy.ReadOnly = true;
            // 
            // AlarmStatus
            // 
            this.AlarmStatus.HeaderText = "AlarmStatus";
            this.AlarmStatus.Name = "AlarmStatus";
            this.AlarmStatus.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Severity
            // 
            this.Severity.HeaderText = "Severity";
            this.Severity.Name = "Severity";
            this.Severity.ReadOnly = true;
            // 
            // AlarmType
            // 
            this.AlarmType.HeaderText = "AlarmType";
            this.AlarmType.Name = "AlarmType";
            this.AlarmType.ReadOnly = true;
            // 
            // AlarmLimit
            // 
            this.AlarmLimit.HeaderText = "AlarmLimit";
            this.AlarmLimit.Name = "AlarmLimit";
            this.AlarmLimit.ReadOnly = true;
            // 
            // TagName
            // 
            this.TagName.HeaderText = "TagName";
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPending);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcknowledgedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcknowledgedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

