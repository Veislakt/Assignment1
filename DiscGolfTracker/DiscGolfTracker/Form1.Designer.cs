namespace DiscGolfTracker
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
            this.dgvDiscData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiscType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMinAccuracy = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.cboThrowType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDistance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTurningDir = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddDisc = new System.Windows.Forms.Button();
            this.btnDeleteDisc = new System.Windows.Forms.Button();
            this.txtSelProducentStats = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSelProducent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSelColour = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSelTurningDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSelHole = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSelPark = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCommitNewThrow = new System.Windows.Forms.Button();
            this.txtNewThrowQuality = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNewAccuracy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewDistance = new System.Windows.Forms.TextBox();
            this.txtNewThrowType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turningDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgAccuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiscData
            // 
            this.dgvDiscData.AllowUserToAddRows = false;
            this.dgvDiscData.AllowUserToDeleteRows = false;
            this.dgvDiscData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.turningDir,
            this.colour,
            this.producent,
            this.name,
            this.avgAccuracy,
            this.avgQuality});
            this.dgvDiscData.Location = new System.Drawing.Point(190, 39);
            this.dgvDiscData.Name = "dgvDiscData";
            this.dgvDiscData.ReadOnly = true;
            this.dgvDiscData.Size = new System.Drawing.Size(459, 244);
            this.dgvDiscData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disc Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboDiscType
            // 
            this.cboDiscType.FormattingEnabled = true;
            this.cboDiscType.Location = new System.Drawing.Point(4, 32);
            this.cboDiscType.Name = "cboDiscType";
            this.cboDiscType.Size = new System.Drawing.Size(121, 21);
            this.cboDiscType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disc Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMinAccuracy);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Controls.Add(this.cboThrowType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDistance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTurningDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDiscType);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 260);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Disc Data Parameters";
            // 
            // cboMinAccuracy
            // 
            this.cboMinAccuracy.FormattingEnabled = true;
            this.cboMinAccuracy.Location = new System.Drawing.Point(4, 197);
            this.cboMinAccuracy.Name = "cboMinAccuracy";
            this.cboMinAccuracy.Size = new System.Drawing.Size(121, 21);
            this.cboMinAccuracy.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Minimum Accuracy";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(7, 232);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(88, 22);
            this.btnLoadData.TabIndex = 11;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // cboThrowType
            // 
            this.cboThrowType.FormattingEnabled = true;
            this.cboThrowType.Location = new System.Drawing.Point(4, 153);
            this.cboThrowType.Name = "cboThrowType";
            this.cboThrowType.Size = new System.Drawing.Size(121, 21);
            this.cboThrowType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Throw Type";
            // 
            // cboDistance
            // 
            this.cboDistance.FormattingEnabled = true;
            this.cboDistance.Location = new System.Drawing.Point(4, 112);
            this.cboDistance.Name = "cboDistance";
            this.cboDistance.Size = new System.Drawing.Size(121, 21);
            this.cboDistance.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turning Direction";
            // 
            // cboTurningDir
            // 
            this.cboTurningDir.FormattingEnabled = true;
            this.cboTurningDir.Location = new System.Drawing.Point(4, 72);
            this.cboTurningDir.Name = "cboTurningDir";
            this.cboTurningDir.Size = new System.Drawing.Size(121, 21);
            this.cboTurningDir.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddDisc);
            this.groupBox2.Controls.Add(this.btnDeleteDisc);
            this.groupBox2.Controls.Add(this.txtSelProducentStats);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSelProducent);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSelColour);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSelTurningDir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSelType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSelName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(305, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 225);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disc";
            // 
            // btnAddDisc
            // 
            this.btnAddDisc.Location = new System.Drawing.Point(10, 196);
            this.btnAddDisc.Name = "btnAddDisc";
            this.btnAddDisc.Size = new System.Drawing.Size(136, 23);
            this.btnAddDisc.TabIndex = 13;
            this.btnAddDisc.Text = "Add Disc";
            this.btnAddDisc.UseVisualStyleBackColor = true;
            this.btnAddDisc.Click += new System.EventHandler(this.btnAddDisc_Click);
            // 
            // btnDeleteDisc
            // 
            this.btnDeleteDisc.Location = new System.Drawing.Point(10, 156);
            this.btnDeleteDisc.Name = "btnDeleteDisc";
            this.btnDeleteDisc.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteDisc.TabIndex = 12;
            this.btnDeleteDisc.Text = "Delete Disc";
            this.btnDeleteDisc.UseVisualStyleBackColor = true;
            this.btnDeleteDisc.Click += new System.EventHandler(this.btnDeleteDisc_Click);
            // 
            // txtSelProducentStats
            // 
            this.txtSelProducentStats.Location = new System.Drawing.Point(166, 121);
            this.txtSelProducentStats.Multiline = true;
            this.txtSelProducentStats.Name = "txtSelProducentStats";
            this.txtSelProducentStats.Size = new System.Drawing.Size(172, 59);
            this.txtSelProducentStats.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Producent stats";
            // 
            // txtSelProducent
            // 
            this.txtSelProducent.Location = new System.Drawing.Point(166, 76);
            this.txtSelProducent.Name = "txtSelProducent";
            this.txtSelProducent.Size = new System.Drawing.Size(172, 20);
            this.txtSelProducent.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producent";
            // 
            // txtSelColour
            // 
            this.txtSelColour.Location = new System.Drawing.Point(166, 36);
            this.txtSelColour.Name = "txtSelColour";
            this.txtSelColour.Size = new System.Drawing.Size(172, 20);
            this.txtSelColour.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Colour";
            // 
            // txtSelTurningDir
            // 
            this.txtSelTurningDir.Location = new System.Drawing.Point(10, 121);
            this.txtSelTurningDir.Name = "txtSelTurningDir";
            this.txtSelTurningDir.Size = new System.Drawing.Size(136, 20);
            this.txtSelTurningDir.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Turning Direction";
            // 
            // txtSelType
            // 
            this.txtSelType.Location = new System.Drawing.Point(10, 77);
            this.txtSelType.Name = "txtSelType";
            this.txtSelType.Size = new System.Drawing.Size(136, 20);
            this.txtSelType.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Type";
            // 
            // txtSelName
            // 
            this.txtSelName.Location = new System.Drawing.Point(10, 37);
            this.txtSelName.Name = "txtSelName";
            this.txtSelName.Size = new System.Drawing.Size(136, 20);
            this.txtSelName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(147, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Hole";
            // 
            // txtSelHole
            // 
            this.txtSelHole.Location = new System.Drawing.Point(150, 120);
            this.txtSelHole.Name = "txtSelHole";
            this.txtSelHole.Size = new System.Drawing.Size(121, 20);
            this.txtSelHole.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(147, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Park";
            // 
            // txtSelPark
            // 
            this.txtSelPark.Location = new System.Drawing.Point(150, 76);
            this.txtSelPark.Name = "txtSelPark";
            this.txtSelPark.Size = new System.Drawing.Size(121, 20);
            this.txtSelPark.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSelHole);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtSelPark);
            this.groupBox3.Controls.Add(this.btnCommitNewThrow);
            this.groupBox3.Controls.Add(this.txtNewThrowQuality);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtNewAccuracy);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNewDistance);
            this.groupBox3.Controls.Add(this.txtNewThrowType);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(8, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 225);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Throw";
            // 
            // btnCommitNewThrow
            // 
            this.btnCommitNewThrow.Location = new System.Drawing.Point(4, 156);
            this.btnCommitNewThrow.Name = "btnCommitNewThrow";
            this.btnCommitNewThrow.Size = new System.Drawing.Size(121, 23);
            this.btnCommitNewThrow.TabIndex = 12;
            this.btnCommitNewThrow.Text = "Commit new throw";
            this.btnCommitNewThrow.UseVisualStyleBackColor = true;
            this.btnCommitNewThrow.Click += new System.EventHandler(this.btnCommitNewThrow_Click);
            // 
            // txtNewThrowQuality
            // 
            this.txtNewThrowQuality.Location = new System.Drawing.Point(150, 36);
            this.txtNewThrowQuality.Name = "txtNewThrowQuality";
            this.txtNewThrowQuality.Size = new System.Drawing.Size(121, 20);
            this.txtNewThrowQuality.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Throw Quality";
            // 
            // txtNewAccuracy
            // 
            this.txtNewAccuracy.Location = new System.Drawing.Point(4, 120);
            this.txtNewAccuracy.Name = "txtNewAccuracy";
            this.txtNewAccuracy.Size = new System.Drawing.Size(121, 20);
            this.txtNewAccuracy.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Accuracy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Distance";
            // 
            // txtNewDistance
            // 
            this.txtNewDistance.Location = new System.Drawing.Point(4, 77);
            this.txtNewDistance.Name = "txtNewDistance";
            this.txtNewDistance.Size = new System.Drawing.Size(121, 20);
            this.txtNewDistance.TabIndex = 2;
            // 
            // txtNewThrowType
            // 
            this.txtNewThrowType.Location = new System.Drawing.Point(4, 36);
            this.txtNewThrowType.Name = "txtNewThrowType";
            this.txtNewThrowType.Size = new System.Drawing.Size(121, 20);
            this.txtNewThrowType.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Throw Type";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // turningDir
            // 
            this.turningDir.HeaderText = "Turning Direction";
            this.turningDir.Name = "turningDir";
            this.turningDir.ReadOnly = true;
            // 
            // colour
            // 
            this.colour.HeaderText = "Colour";
            this.colour.Name = "colour";
            this.colour.ReadOnly = true;
            // 
            // producent
            // 
            this.producent.HeaderText = "Producent";
            this.producent.Name = "producent";
            this.producent.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // avgAccuracy
            // 
            this.avgAccuracy.HeaderText = "Average Accuracy";
            this.avgAccuracy.Name = "avgAccuracy";
            this.avgAccuracy.ReadOnly = true;
            // 
            // avgQuality
            // 
            this.avgQuality.HeaderText = "Average Quality";
            this.avgQuality.Name = "avgQuality";
            this.avgQuality.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiscData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDiscType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.ComboBox cboThrowType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTurningDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSelProducentStats;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSelProducent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSelColour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSelTurningDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSelType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCommitNewThrow;
        private System.Windows.Forms.TextBox txtNewThrowQuality;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNewAccuracy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNewDistance;
        private System.Windows.Forms.TextBox txtNewThrowType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddDisc;
        private System.Windows.Forms.Button btnDeleteDisc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboMinAccuracy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSelHole;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSelPark;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn turningDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn producent;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgAccuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgQuality;
    }
}

