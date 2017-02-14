namespace WFAssignment1
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
            this.btnSampling = new System.Windows.Forms.Button();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtNextSampleTime = new System.Windows.Forms.TextBox();
            this.txtNextLoggingTime = new System.Windows.Forms.TextBox();
            this.txtSensorValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSampling = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(12, 77);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(101, 23);
            this.btnSampling.TabIndex = 0;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(12, 180);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(101, 23);
            this.btnLogging.TabIndex = 1;
            this.btnLogging.Text = "Logging on File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // txtNextSampleTime
            // 
            this.txtNextSampleTime.Location = new System.Drawing.Point(13, 51);
            this.txtNextSampleTime.Name = "txtNextSampleTime";
            this.txtNextSampleTime.Size = new System.Drawing.Size(100, 20);
            this.txtNextSampleTime.TabIndex = 2;
            // 
            // txtNextLoggingTime
            // 
            this.txtNextLoggingTime.Location = new System.Drawing.Point(13, 154);
            this.txtNextLoggingTime.Name = "txtNextLoggingTime";
            this.txtNextLoggingTime.Size = new System.Drawing.Size(100, 20);
            this.txtNextLoggingTime.TabIndex = 3;
            // 
            // txtSensorValues
            // 
            this.txtSensorValues.Location = new System.Drawing.Point(159, 50);
            this.txtSensorValues.Multiline = true;
            this.txtSensorValues.Name = "txtSensorValues";
            this.txtSensorValues.Size = new System.Drawing.Size(100, 153);
            this.txtSensorValues.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Next Sampling Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Next Logging Time:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logging";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(12, 13);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(50, 13);
            this.lblSampling.TabIndex = 8;
            this.lblSampling.Text = "Sampling";
            this.lblSampling.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sensor Values:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSampling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensorValues);
            this.Controls.Add(this.txtNextLoggingTime);
            this.Controls.Add(this.txtNextSampleTime);
            this.Controls.Add(this.btnLogging);
            this.Controls.Add(this.btnSampling);
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.TextBox txtNextSampleTime;
        private System.Windows.Forms.TextBox txtNextLoggingTime;
        private System.Windows.Forms.TextBox txtSensorValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.Label label4;
    }
}

