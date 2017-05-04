namespace OPC_DA_Client
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.tmCelcius = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.tmFahrenheit = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            ((System.ComponentModel.ISupportInitialize)(this.tmCelcius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmFahrenheit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Location = new System.Drawing.Point(173, 73);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(173, 128);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Reading";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(173, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Reading";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrRead
            // 
            this.tmrRead.Enabled = true;
            this.tmrRead.Interval = 1000;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // tmCelcius
            // 
            this.tmCelcius.Location = new System.Drawing.Point(17, 54);
            this.tmCelcius.Name = "tmCelcius";
            this.tmCelcius.Size = new System.Drawing.Size(72, 184);
            this.tmCelcius.TabIndex = 4;
            // 
            // tmFahrenheit
            // 
            this.tmFahrenheit.Location = new System.Drawing.Point(95, 54);
            this.tmFahrenheit.Name = "tmFahrenheit";
            this.tmFahrenheit.Size = new System.Drawing.Size(72, 184);
            this.tmFahrenheit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "C";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "F";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(301, 54);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(272, 168);
            this.waveformGraph1.TabIndex = 8;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tmFahrenheit);
            this.Controls.Add(this.tmCelcius);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tmCelcius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmFahrenheit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrRead;
        private NationalInstruments.UI.WindowsForms.Thermometer tmCelcius;
        private NationalInstruments.UI.WindowsForms.Thermometer tmFahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
    }
}

