
namespace SRIS.UserControls
{
    partial class ucServiceRequest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucServiceRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_AddSeviceToBeProvidedBy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tosp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateRequested = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ServiceToBeProvidedBy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_InspectionReport = new System.Windows.Forms.Button();
            this.checkBox_ProceedToIR = new System.Windows.Forms.CheckBox();
            this.bt_ServiceProvidedBy = new System.Windows.Forms.Button();
            this.cb_ServiceProvidedBy = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateAccomplished = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_IfCompleted = new System.Windows.Forms.CheckBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.cb_TypeOfServiceDescription = new System.Windows.Forms.ComboBox();
            this.cb_Tosp = new System.Windows.Forms.ComboBox();
            this.cb_RequestedBy = new System.Windows.Forms.ComboBox();
            this.cb_OfficeDepartment = new System.Windows.Forms.ComboBox();
            this.cb_FaultDiagnosis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type of Service:";
            // 
            // bt_AddSeviceToBeProvidedBy
            // 
            this.bt_AddSeviceToBeProvidedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AddSeviceToBeProvidedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bt_AddSeviceToBeProvidedBy.FlatAppearance.BorderSize = 0;
            this.bt_AddSeviceToBeProvidedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddSeviceToBeProvidedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_AddSeviceToBeProvidedBy.Image = ((System.Drawing.Image)(resources.GetObject("bt_AddSeviceToBeProvidedBy.Image")));
            this.bt_AddSeviceToBeProvidedBy.Location = new System.Drawing.Point(505, 184);
            this.bt_AddSeviceToBeProvidedBy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddSeviceToBeProvidedBy.Name = "bt_AddSeviceToBeProvidedBy";
            this.bt_AddSeviceToBeProvidedBy.Size = new System.Drawing.Size(37, 27);
            this.bt_AddSeviceToBeProvidedBy.TabIndex = 5;
            this.bt_AddSeviceToBeProvidedBy.UseVisualStyleBackColor = false;
            this.bt_AddSeviceToBeProvidedBy.Click += new System.EventHandler(this.bt_AddSeviceToBeProvidedBy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tosp,
            this.RequestedBy,
            this.Office,
            this.DateRequested,
            this.TimeLeft,
            this.AssignedTechnician});
            this.dataGridView1.Location = new System.Drawing.Point(2, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 242);
            this.dataGridView1.TabIndex = 6;
            // 
            // Tosp
            // 
            this.Tosp.HeaderText = "Type Of Service Provided";
            this.Tosp.Name = "Tosp";
            this.Tosp.ReadOnly = true;
            // 
            // RequestedBy
            // 
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // Office
            // 
            this.Office.HeaderText = "Office";
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            // 
            // DateRequested
            // 
            this.DateRequested.HeaderText = "Date Requested";
            this.DateRequested.Name = "DateRequested";
            this.DateRequested.ReadOnly = true;
            // 
            // TimeLeft
            // 
            this.TimeLeft.HeaderText = "Time Left";
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.ReadOnly = true;
            // 
            // AssignedTechnician
            // 
            this.AssignedTechnician.HeaderText = "Remarks";
            this.AssignedTechnician.Name = "AssignedTechnician";
            this.AssignedTechnician.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requested By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Office/Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fault Diagnosis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Requested:";
            // 
            // dateTimePicker_DateRequested
            // 
            this.dateTimePicker_DateRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DateRequested.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dateTimePicker_DateRequested.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dateTimePicker_DateRequested.Location = new System.Drawing.Point(157, 82);
            this.dateTimePicker_DateRequested.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_DateRequested.Name = "dateTimePicker_DateRequested";
            this.dateTimePicker_DateRequested.Size = new System.Drawing.Size(344, 27);
            this.dateTimePicker_DateRequested.TabIndex = 13;
            this.dateTimePicker_DateRequested.ValueChanged += new System.EventHandler(this.dateTimePicker_DateRequested_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Service to be Provided By:";
            // 
            // cb_ServiceToBeProvidedBy
            // 
            this.cb_ServiceToBeProvidedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ServiceToBeProvidedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_ServiceToBeProvidedBy.Location = new System.Drawing.Point(208, 184);
            this.cb_ServiceToBeProvidedBy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cb_ServiceToBeProvidedBy.Name = "cb_ServiceToBeProvidedBy";
            this.cb_ServiceToBeProvidedBy.ReadOnly = true;
            this.cb_ServiceToBeProvidedBy.Size = new System.Drawing.Size(292, 27);
            this.cb_ServiceToBeProvidedBy.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_InspectionReport);
            this.groupBox1.Controls.Add(this.checkBox_ProceedToIR);
            this.groupBox1.Controls.Add(this.bt_ServiceProvidedBy);
            this.groupBox1.Controls.Add(this.cb_ServiceProvidedBy);
            this.groupBox1.Controls.Add(this.dateTimePicker_DateAccomplished);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox_IfCompleted);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(507, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // bt_InspectionReport
            // 
            this.bt_InspectionReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bt_InspectionReport.FlatAppearance.BorderSize = 0;
            this.bt_InspectionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_InspectionReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_InspectionReport.Image = ((System.Drawing.Image)(resources.GetObject("bt_InspectionReport.Image")));
            this.bt_InspectionReport.Location = new System.Drawing.Point(481, 22);
            this.bt_InspectionReport.Margin = new System.Windows.Forms.Padding(2);
            this.bt_InspectionReport.Name = "bt_InspectionReport";
            this.bt_InspectionReport.Size = new System.Drawing.Size(37, 27);
            this.bt_InspectionReport.TabIndex = 22;
            this.bt_InspectionReport.UseVisualStyleBackColor = false;
            this.bt_InspectionReport.Click += new System.EventHandler(this.bt_InspectionReport_Click);
            // 
            // checkBox_ProceedToIR
            // 
            this.checkBox_ProceedToIR.AutoSize = true;
            this.checkBox_ProceedToIR.ForeColor = System.Drawing.Color.Black;
            this.checkBox_ProceedToIR.Location = new System.Drawing.Point(254, 26);
            this.checkBox_ProceedToIR.Name = "checkBox_ProceedToIR";
            this.checkBox_ProceedToIR.Size = new System.Drawing.Size(230, 23);
            this.checkBox_ProceedToIR.TabIndex = 21;
            this.checkBox_ProceedToIR.Text = "Proceed to Inspection Report";
            this.checkBox_ProceedToIR.UseVisualStyleBackColor = true;
            this.checkBox_ProceedToIR.Click += new System.EventHandler(this.checkBox_ProceedToIR_Click);
            // 
            // bt_ServiceProvidedBy
            // 
            this.bt_ServiceProvidedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.bt_ServiceProvidedBy.Enabled = false;
            this.bt_ServiceProvidedBy.FlatAppearance.BorderSize = 0;
            this.bt_ServiceProvidedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ServiceProvidedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_ServiceProvidedBy.Image = ((System.Drawing.Image)(resources.GetObject("bt_ServiceProvidedBy.Image")));
            this.bt_ServiceProvidedBy.Location = new System.Drawing.Point(489, 108);
            this.bt_ServiceProvidedBy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ServiceProvidedBy.Name = "bt_ServiceProvidedBy";
            this.bt_ServiceProvidedBy.Size = new System.Drawing.Size(37, 27);
            this.bt_ServiceProvidedBy.TabIndex = 17;
            this.bt_ServiceProvidedBy.UseVisualStyleBackColor = false;
            this.bt_ServiceProvidedBy.Click += new System.EventHandler(this.bt_ServiceProvidedBy_Click);
            // 
            // cb_ServiceProvidedBy
            // 
            this.cb_ServiceProvidedBy.Enabled = false;
            this.cb_ServiceProvidedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_ServiceProvidedBy.Location = new System.Drawing.Point(168, 108);
            this.cb_ServiceProvidedBy.Name = "cb_ServiceProvidedBy";
            this.cb_ServiceProvidedBy.ReadOnly = true;
            this.cb_ServiceProvidedBy.Size = new System.Drawing.Size(316, 27);
            this.cb_ServiceProvidedBy.TabIndex = 20;
            // 
            // dateTimePicker_DateAccomplished
            // 
            this.dateTimePicker_DateAccomplished.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dateTimePicker_DateAccomplished.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dateTimePicker_DateAccomplished.Enabled = false;
            this.dateTimePicker_DateAccomplished.Location = new System.Drawing.Point(168, 69);
            this.dateTimePicker_DateAccomplished.Name = "dateTimePicker_DateAccomplished";
            this.dateTimePicker_DateAccomplished.Size = new System.Drawing.Size(347, 27);
            this.dateTimePicker_DateAccomplished.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Service Provided By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date Accomplished:";
            // 
            // checkBox_IfCompleted
            // 
            this.checkBox_IfCompleted.AutoSize = true;
            this.checkBox_IfCompleted.ForeColor = System.Drawing.Color.Black;
            this.checkBox_IfCompleted.Location = new System.Drawing.Point(18, 26);
            this.checkBox_IfCompleted.Name = "checkBox_IfCompleted";
            this.checkBox_IfCompleted.Size = new System.Drawing.Size(230, 23);
            this.checkBox_IfCompleted.TabIndex = 0;
            this.checkBox_IfCompleted.Text = "If Completed (Check the box)";
            this.checkBox_IfCompleted.UseVisualStyleBackColor = true;
            this.checkBox_IfCompleted.Click += new System.EventHandler(this.checkBox_IfCompleted_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Save.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.ForeColor = System.Drawing.Color.Black;
            this.bt_Save.Image = ((System.Drawing.Image)(resources.GetObject("bt_Save.Image")));
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(988, 187);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(82, 27);
            this.bt_Save.TabIndex = 17;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.ForeColor = System.Drawing.Color.Black;
            this.bt_Clear.Image = ((System.Drawing.Image)(resources.GetObject("bt_Clear.Image")));
            this.bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Clear.Location = new System.Drawing.Point(884, 187);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(93, 27);
            this.bt_Clear.TabIndex = 18;
            this.bt_Clear.Text = "CLEAR";
            this.bt_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Clear.UseVisualStyleBackColor = false;
            // 
            // cb_TypeOfServiceDescription
            // 
            this.cb_TypeOfServiceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TypeOfServiceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_TypeOfServiceDescription.FormattingEnabled = true;
            this.cb_TypeOfServiceDescription.Items.AddRange(new object[] {
            "--",
            "SOFTWARE",
            "HARDWARE"});
            this.cb_TypeOfServiceDescription.Location = new System.Drawing.Point(380, 12);
            this.cb_TypeOfServiceDescription.Name = "cb_TypeOfServiceDescription";
            this.cb_TypeOfServiceDescription.Size = new System.Drawing.Size(121, 27);
            this.cb_TypeOfServiceDescription.TabIndex = 19;
            this.cb_TypeOfServiceDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // cb_Tosp
            // 
            this.cb_Tosp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Tosp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_Tosp.FormattingEnabled = true;
            this.cb_Tosp.Location = new System.Drawing.Point(138, 12);
            this.cb_Tosp.Name = "cb_Tosp";
            this.cb_Tosp.Size = new System.Drawing.Size(234, 27);
            this.cb_Tosp.TabIndex = 20;
            this.cb_Tosp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Tosp_KeyPress);
            // 
            // cb_RequestedBy
            // 
            this.cb_RequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_RequestedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_RequestedBy.FormattingEnabled = true;
            this.cb_RequestedBy.Location = new System.Drawing.Point(140, 46);
            this.cb_RequestedBy.Name = "cb_RequestedBy";
            this.cb_RequestedBy.Size = new System.Drawing.Size(361, 27);
            this.cb_RequestedBy.TabIndex = 21;
            this.cb_RequestedBy.SelectedIndexChanged += new System.EventHandler(this.cb_RequestedBy_SelectedIndexChanged);
            this.cb_RequestedBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_RequestedBy_KeyPress);
            // 
            // cb_OfficeDepartment
            // 
            this.cb_OfficeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_OfficeDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_OfficeDepartment.FormattingEnabled = true;
            this.cb_OfficeDepartment.Location = new System.Drawing.Point(157, 114);
            this.cb_OfficeDepartment.Name = "cb_OfficeDepartment";
            this.cb_OfficeDepartment.Size = new System.Drawing.Size(344, 27);
            this.cb_OfficeDepartment.TabIndex = 22;
            this.cb_OfficeDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_OfficeDepartment_KeyPress);
            // 
            // cb_FaultDiagnosis
            // 
            this.cb_FaultDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_FaultDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cb_FaultDiagnosis.FormattingEnabled = true;
            this.cb_FaultDiagnosis.Location = new System.Drawing.Point(155, 147);
            this.cb_FaultDiagnosis.Name = "cb_FaultDiagnosis";
            this.cb_FaultDiagnosis.Size = new System.Drawing.Size(346, 27);
            this.cb_FaultDiagnosis.TabIndex = 23;
            this.cb_FaultDiagnosis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_FaultDiagnosis_KeyPress);
            // 
            // ucServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.cb_FaultDiagnosis);
            this.Controls.Add(this.cb_OfficeDepartment);
            this.Controls.Add(this.cb_RequestedBy);
            this.Controls.Add(this.cb_Tosp);
            this.Controls.Add(this.cb_TypeOfServiceDescription);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_ServiceToBeProvidedBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_DateRequested);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_AddSeviceToBeProvidedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ucServiceRequest";
            this.Size = new System.Drawing.Size(1085, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_AddSeviceToBeProvidedBy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateRequested;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cb_ServiceToBeProvidedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_IfCompleted;
        private System.Windows.Forms.Button bt_ServiceProvidedBy;
        private System.Windows.Forms.TextBox cb_ServiceProvidedBy;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateAccomplished;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_InspectionReport;
        private System.Windows.Forms.CheckBox checkBox_ProceedToIR;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tosp;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedTechnician;
        private System.Windows.Forms.ComboBox cb_TypeOfServiceDescription;
        private System.Windows.Forms.ComboBox cb_Tosp;
        private System.Windows.Forms.ComboBox cb_RequestedBy;
        private System.Windows.Forms.ComboBox cb_OfficeDepartment;
        private System.Windows.Forms.ComboBox cb_FaultDiagnosis;
    }
}
