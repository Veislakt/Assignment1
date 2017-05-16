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
            this.components = new System.ComponentModel.Container();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnAcknowledgeAlarm = new System.Windows.Forms.Button();
            this.btnDismissAlarm = new System.Windows.Forms.Button();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPending
            // 
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Location = new System.Drawing.Point(12, 29);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.Size = new System.Drawing.Size(1119, 187);
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
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // btnAcknowledgeAlarm
            // 
            this.btnAcknowledgeAlarm.Location = new System.Drawing.Point(12, 223);
            this.btnAcknowledgeAlarm.Name = "btnAcknowledgeAlarm";
            this.btnAcknowledgeAlarm.Size = new System.Drawing.Size(126, 23);
            this.btnAcknowledgeAlarm.TabIndex = 2;
            this.btnAcknowledgeAlarm.Text = "Acknowledge Alarm";
            this.btnAcknowledgeAlarm.UseVisualStyleBackColor = true;
            this.btnAcknowledgeAlarm.Click += new System.EventHandler(this.btnAcknowledgeAlarm_Click);
            // 
            // btnDismissAlarm
            // 
            this.btnDismissAlarm.Location = new System.Drawing.Point(144, 223);
            this.btnDismissAlarm.Name = "btnDismissAlarm";
            this.btnDismissAlarm.Size = new System.Drawing.Size(126, 23);
            this.btnDismissAlarm.TabIndex = 3;
            this.btnDismissAlarm.Text = "Dismiss Alarm";
            this.btnDismissAlarm.UseVisualStyleBackColor = true;
            this.btnDismissAlarm.Click += new System.EventHandler(this.btnDismissAlarm_Click);
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "Morten"});
            this.cboOperator.Location = new System.Drawing.Point(12, 274);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(126, 21);
            this.cboOperator.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.btnDismissAlarm);
            this.Controls.Add(this.btnAcknowledgeAlarm);
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
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Button btnAcknowledgeAlarm;
        private System.Windows.Forms.Button btnDismissAlarm;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.Label label2;
    }
}

