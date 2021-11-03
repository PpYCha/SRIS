﻿
namespace SRIS.UserControls
{
    partial class ucInspectionReport
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
            this.panel_PostPre = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_RemovePI = new System.Windows.Forms.Button();
            this.dataGridView_PerformedInspected = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_SavePI = new System.Windows.Forms.Button();
            this.cb_Position = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_NamePerformedInspected = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_MagicBox = new System.Windows.Forms.ComboBox();
            this.bt_RemovePT = new System.Windows.Forms.Button();
            this.dataGridView_ProcedureTest = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_ProcedureTest = new System.Windows.Forms.ComboBox();
            this.bt_SaveProcedure = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_PropertyNo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_TypeOfUnit = new System.Windows.Forms.ComboBox();
            this.cb_ComplaintOnUnit = new System.Windows.Forms.ComboBox();
            this.gb_TypeOfUnit = new System.Windows.Forms.GroupBox();
            this.bt_RemoveUS = new System.Windows.Forms.Button();
            this.bt_UnitSpecification = new System.Windows.Forms.Button();
            this.cb_ComponentRemarks = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cb_HardwareComponents = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView_UnitSpecs = new System.Windows.Forms.DataGridView();
            this.Column_Components = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_RemoveR = new System.Windows.Forms.Button();
            this.bt_RemovePF = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView_Recommendation = new System.Windows.Forms.DataGridView();
            this.Column_Recommendations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_SaveRecommendation = new System.Windows.Forms.Button();
            this.cb_Recommendation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_FindingParticular = new System.Windows.Forms.DataGridView();
            this.Column_Particular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Findings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_SaveParticularFinding = new System.Windows.Forms.Button();
            this.cb_Finding = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_Particular = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_RequestingOffice = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker_Received = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_RequestedBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_ReceivedBy = new System.Windows.Forms.ComboBox();
            this.panel_PostPre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PerformedInspected)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProcedureTest)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gb_TypeOfUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnitSpecs)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recommendation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FindingParticular)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_PostPre
            // 
            this.panel_PostPre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_PostPre.AutoScroll = true;
            this.panel_PostPre.BackColor = System.Drawing.Color.Transparent;
            this.panel_PostPre.Controls.Add(this.groupBox2);
            this.panel_PostPre.Controls.Add(this.groupBox6);
            this.panel_PostPre.Controls.Add(this.groupBox4);
            this.panel_PostPre.Controls.Add(this.groupBox5);
            this.panel_PostPre.Controls.Add(this.groupBox3);
            this.panel_PostPre.Location = new System.Drawing.Point(32, 22);
            this.panel_PostPre.Name = "panel_PostPre";
            this.panel_PostPre.Size = new System.Drawing.Size(884, 506);
            this.panel_PostPre.TabIndex = 91;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_RemovePI);
            this.groupBox2.Controls.Add(this.dataGridView_PerformedInspected);
            this.groupBox2.Controls.Add(this.cb_SavePI);
            this.groupBox2.Controls.Add(this.cb_Position);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cb_NamePerformedInspected);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(6, 1074);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 175);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performed/Inspected by:";
            // 
            // bt_RemovePI
            // 
            this.bt_RemovePI.Location = new System.Drawing.Point(734, 19);
            this.bt_RemovePI.Name = "bt_RemovePI";
            this.bt_RemovePI.Size = new System.Drawing.Size(83, 27);
            this.bt_RemovePI.TabIndex = 96;
            this.bt_RemovePI.Text = "REMOVE";
            this.bt_RemovePI.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PerformedInspected
            // 
            this.dataGridView_PerformedInspected.AllowUserToAddRows = false;
            this.dataGridView_PerformedInspected.AllowUserToDeleteRows = false;
            this.dataGridView_PerformedInspected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PerformedInspected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PerformedInspected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Position});
            this.dataGridView_PerformedInspected.Location = new System.Drawing.Point(19, 51);
            this.dataGridView_PerformedInspected.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_PerformedInspected.Name = "dataGridView_PerformedInspected";
            this.dataGridView_PerformedInspected.ReadOnly = true;
            this.dataGridView_PerformedInspected.RowHeadersVisible = false;
            this.dataGridView_PerformedInspected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PerformedInspected.Size = new System.Drawing.Size(798, 106);
            this.dataGridView_PerformedInspected.TabIndex = 94;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            // 
            // Column_Position
            // 
            this.Column_Position.FillWeight = 50F;
            this.Column_Position.HeaderText = "Position";
            this.Column_Position.Name = "Column_Position";
            this.Column_Position.ReadOnly = true;
            // 
            // cb_SavePI
            // 
            this.cb_SavePI.Location = new System.Drawing.Point(630, 18);
            this.cb_SavePI.Name = "cb_SavePI";
            this.cb_SavePI.Size = new System.Drawing.Size(83, 27);
            this.cb_SavePI.TabIndex = 91;
            this.cb_SavePI.Text = "SAVE";
            this.cb_SavePI.UseVisualStyleBackColor = true;
            // 
            // cb_Position
            // 
            this.cb_Position.FormattingEnabled = true;
            this.cb_Position.Location = new System.Drawing.Point(406, 19);
            this.cb_Position.Name = "cb_Position";
            this.cb_Position.Size = new System.Drawing.Size(218, 27);
            this.cb_Position.TabIndex = 93;
            this.cb_Position.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label24.Location = new System.Drawing.Point(332, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 21);
            this.label24.TabIndex = 92;
            this.label24.Text = "Position:";
            this.label24.Visible = false;
            // 
            // cb_NamePerformedInspected
            // 
            this.cb_NamePerformedInspected.FormattingEnabled = true;
            this.cb_NamePerformedInspected.Location = new System.Drawing.Point(80, 21);
            this.cb_NamePerformedInspected.Name = "cb_NamePerformedInspected";
            this.cb_NamePerformedInspected.Size = new System.Drawing.Size(233, 27);
            this.cb_NamePerformedInspected.TabIndex = 90;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label25.Location = new System.Drawing.Point(21, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 21);
            this.label25.TabIndex = 89;
            this.label25.Text = "Name:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_MagicBox);
            this.groupBox6.Controls.Add(this.bt_RemovePT);
            this.groupBox6.Controls.Add(this.dataGridView_ProcedureTest);
            this.groupBox6.Controls.Add(this.cb_ProcedureTest);
            this.groupBox6.Controls.Add(this.bt_SaveProcedure);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(6, 538);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(848, 175);
            this.groupBox6.TabIndex = 89;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Procedures/Tests";
            // 
            // cb_MagicBox
            // 
            this.cb_MagicBox.FormattingEnabled = true;
            this.cb_MagicBox.Location = new System.Drawing.Point(489, 31);
            this.cb_MagicBox.Name = "cb_MagicBox";
            this.cb_MagicBox.Size = new System.Drawing.Size(121, 27);
            this.cb_MagicBox.TabIndex = 91;
            this.cb_MagicBox.Text = "MagicBox";
            this.cb_MagicBox.Visible = false;
            // 
            // bt_RemovePT
            // 
            this.bt_RemovePT.Location = new System.Drawing.Point(734, 24);
            this.bt_RemovePT.Name = "bt_RemovePT";
            this.bt_RemovePT.Size = new System.Drawing.Size(83, 27);
            this.bt_RemovePT.TabIndex = 90;
            this.bt_RemovePT.Text = "REMOVE";
            this.bt_RemovePT.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ProcedureTest
            // 
            this.dataGridView_ProcedureTest.AllowUserToAddRows = false;
            this.dataGridView_ProcedureTest.AllowUserToDeleteRows = false;
            this.dataGridView_ProcedureTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ProcedureTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProcedureTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_ProcedureTest.Location = new System.Drawing.Point(19, 62);
            this.dataGridView_ProcedureTest.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ProcedureTest.Name = "dataGridView_ProcedureTest";
            this.dataGridView_ProcedureTest.ReadOnly = true;
            this.dataGridView_ProcedureTest.RowHeadersVisible = false;
            this.dataGridView_ProcedureTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ProcedureTest.Size = new System.Drawing.Size(798, 106);
            this.dataGridView_ProcedureTest.TabIndex = 85;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Procedure";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cb_ProcedureTest
            // 
            this.cb_ProcedureTest.FormattingEnabled = true;
            this.cb_ProcedureTest.Location = new System.Drawing.Point(142, 30);
            this.cb_ProcedureTest.Name = "cb_ProcedureTest";
            this.cb_ProcedureTest.Size = new System.Drawing.Size(308, 27);
            this.cb_ProcedureTest.TabIndex = 84;
            // 
            // bt_SaveProcedure
            // 
            this.bt_SaveProcedure.Location = new System.Drawing.Point(633, 24);
            this.bt_SaveProcedure.Name = "bt_SaveProcedure";
            this.bt_SaveProcedure.Size = new System.Drawing.Size(83, 27);
            this.bt_SaveProcedure.TabIndex = 83;
            this.bt_SaveProcedure.Text = "SAVE";
            this.bt_SaveProcedure.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(15, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 21);
            this.label15.TabIndex = 82;
            this.label15.Text = "Procedure/Tests:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cb_PropertyNo);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cb_TypeOfUnit);
            this.groupBox4.Controls.Add(this.cb_ComplaintOnUnit);
            this.groupBox4.Controls.Add(this.gb_TypeOfUnit);
            this.groupBox4.Location = new System.Drawing.Point(6, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(848, 300);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRE-INSPECTION";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label22.Location = new System.Drawing.Point(6, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 21);
            this.label22.TabIndex = 29;
            this.label22.Text = "Property No:";
            // 
            // cb_PropertyNo
            // 
            this.cb_PropertyNo.FormattingEnabled = true;
            this.cb_PropertyNo.Location = new System.Drawing.Point(111, 62);
            this.cb_PropertyNo.Name = "cb_PropertyNo";
            this.cb_PropertyNo.Size = new System.Drawing.Size(279, 27);
            this.cb_PropertyNo.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.Location = new System.Drawing.Point(415, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Complaint on Unit:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 7;
            this.label14.Text = "Type of unit:";
            // 
            // cb_TypeOfUnit
            // 
            this.cb_TypeOfUnit.FormattingEnabled = true;
            this.cb_TypeOfUnit.Location = new System.Drawing.Point(111, 24);
            this.cb_TypeOfUnit.Name = "cb_TypeOfUnit";
            this.cb_TypeOfUnit.Size = new System.Drawing.Size(279, 27);
            this.cb_TypeOfUnit.TabIndex = 20;
            // 
            // cb_ComplaintOnUnit
            // 
            this.cb_ComplaintOnUnit.FormattingEnabled = true;
            this.cb_ComplaintOnUnit.Location = new System.Drawing.Point(561, 24);
            this.cb_ComplaintOnUnit.Name = "cb_ComplaintOnUnit";
            this.cb_ComplaintOnUnit.Size = new System.Drawing.Size(238, 27);
            this.cb_ComplaintOnUnit.TabIndex = 21;
            // 
            // gb_TypeOfUnit
            // 
            this.gb_TypeOfUnit.Controls.Add(this.bt_RemoveUS);
            this.gb_TypeOfUnit.Controls.Add(this.bt_UnitSpecification);
            this.gb_TypeOfUnit.Controls.Add(this.cb_ComponentRemarks);
            this.gb_TypeOfUnit.Controls.Add(this.label19);
            this.gb_TypeOfUnit.Controls.Add(this.cb_HardwareComponents);
            this.gb_TypeOfUnit.Controls.Add(this.label17);
            this.gb_TypeOfUnit.Controls.Add(this.dataGridView_UnitSpecs);
            this.gb_TypeOfUnit.Location = new System.Drawing.Point(6, 102);
            this.gb_TypeOfUnit.Name = "gb_TypeOfUnit";
            this.gb_TypeOfUnit.Size = new System.Drawing.Size(836, 192);
            this.gb_TypeOfUnit.TabIndex = 27;
            this.gb_TypeOfUnit.TabStop = false;
            this.gb_TypeOfUnit.Text = "Unit Specification";
            // 
            // bt_RemoveUS
            // 
            this.bt_RemoveUS.Location = new System.Drawing.Point(728, 35);
            this.bt_RemoveUS.Name = "bt_RemoveUS";
            this.bt_RemoveUS.Size = new System.Drawing.Size(83, 27);
            this.bt_RemoveUS.TabIndex = 89;
            this.bt_RemoveUS.Text = "REMOVE";
            this.bt_RemoveUS.UseVisualStyleBackColor = true;
            // 
            // bt_UnitSpecification
            // 
            this.bt_UnitSpecification.Location = new System.Drawing.Point(627, 33);
            this.bt_UnitSpecification.Name = "bt_UnitSpecification";
            this.bt_UnitSpecification.Size = new System.Drawing.Size(83, 27);
            this.bt_UnitSpecification.TabIndex = 86;
            this.bt_UnitSpecification.Text = "SAVE";
            this.bt_UnitSpecification.UseVisualStyleBackColor = true;
            // 
            // cb_ComponentRemarks
            // 
            this.cb_ComponentRemarks.FormattingEnabled = true;
            this.cb_ComponentRemarks.Location = new System.Drawing.Point(435, 36);
            this.cb_ComponentRemarks.Name = "cb_ComponentRemarks";
            this.cb_ComponentRemarks.Size = new System.Drawing.Size(154, 27);
            this.cb_ComponentRemarks.TabIndex = 87;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label19.Location = new System.Drawing.Point(337, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 21);
            this.label19.TabIndex = 88;
            this.label19.Text = "Description:";
            // 
            // cb_HardwareComponents
            // 
            this.cb_HardwareComponents.FormattingEnabled = true;
            this.cb_HardwareComponents.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Biometric",
            "Printer",
            "External Hdd",
            "Usb Flash Drive"});
            this.cb_HardwareComponents.Location = new System.Drawing.Point(105, 35);
            this.cb_HardwareComponents.Name = "cb_HardwareComponents";
            this.cb_HardwareComponents.Size = new System.Drawing.Size(154, 27);
            this.cb_HardwareComponents.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label17.Location = new System.Drawing.Point(6, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 21);
            this.label17.TabIndex = 28;
            this.label17.Text = "Component:";
            // 
            // dataGridView_UnitSpecs
            // 
            this.dataGridView_UnitSpecs.AllowUserToAddRows = false;
            this.dataGridView_UnitSpecs.AllowUserToDeleteRows = false;
            this.dataGridView_UnitSpecs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UnitSpecs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UnitSpecs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Components,
            this.Column_Remarks});
            this.dataGridView_UnitSpecs.Location = new System.Drawing.Point(10, 79);
            this.dataGridView_UnitSpecs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_UnitSpecs.Name = "dataGridView_UnitSpecs";
            this.dataGridView_UnitSpecs.ReadOnly = true;
            this.dataGridView_UnitSpecs.RowHeadersVisible = false;
            this.dataGridView_UnitSpecs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UnitSpecs.Size = new System.Drawing.Size(822, 106);
            this.dataGridView_UnitSpecs.TabIndex = 86;
            // 
            // Column_Components
            // 
            this.Column_Components.HeaderText = "Component";
            this.Column_Components.Name = "Column_Components";
            this.Column_Components.ReadOnly = true;
            // 
            // Column_Remarks
            // 
            this.Column_Remarks.HeaderText = "Description";
            this.Column_Remarks.Name = "Column_Remarks";
            this.Column_Remarks.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_RemoveR);
            this.groupBox5.Controls.Add(this.bt_RemovePF);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.dataGridView_Recommendation);
            this.groupBox5.Controls.Add(this.bt_SaveRecommendation);
            this.groupBox5.Controls.Add(this.cb_Recommendation);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.dataGridView_FindingParticular);
            this.groupBox5.Controls.Add(this.bt_SaveParticularFinding);
            this.groupBox5.Controls.Add(this.cb_Finding);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cb_Particular);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(6, 719);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(848, 349);
            this.groupBox5.TabIndex = 83;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "POST-INSPECTION";
            // 
            // bt_RemoveR
            // 
            this.bt_RemoveR.Location = new System.Drawing.Point(719, 198);
            this.bt_RemoveR.Name = "bt_RemoveR";
            this.bt_RemoveR.Size = new System.Drawing.Size(83, 27);
            this.bt_RemoveR.TabIndex = 95;
            this.bt_RemoveR.Text = "REMOVE";
            this.bt_RemoveR.UseVisualStyleBackColor = true;
            // 
            // bt_RemovePF
            // 
            this.bt_RemovePF.Location = new System.Drawing.Point(755, 32);
            this.bt_RemovePF.Name = "bt_RemovePF";
            this.bt_RemovePF.Size = new System.Drawing.Size(83, 27);
            this.bt_RemovePF.TabIndex = 94;
            this.bt_RemovePF.Text = "REMOVE";
            this.bt_RemovePF.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label23.Location = new System.Drawing.Point(6, 207);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 21);
            this.label23.TabIndex = 93;
            this.label23.Text = "Recommendations:";
            // 
            // dataGridView_Recommendation
            // 
            this.dataGridView_Recommendation.AllowUserToAddRows = false;
            this.dataGridView_Recommendation.AllowUserToDeleteRows = false;
            this.dataGridView_Recommendation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Recommendation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Recommendation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Recommendations});
            this.dataGridView_Recommendation.Location = new System.Drawing.Point(19, 232);
            this.dataGridView_Recommendation.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Recommendation.Name = "dataGridView_Recommendation";
            this.dataGridView_Recommendation.ReadOnly = true;
            this.dataGridView_Recommendation.RowHeadersVisible = false;
            this.dataGridView_Recommendation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Recommendation.Size = new System.Drawing.Size(798, 106);
            this.dataGridView_Recommendation.TabIndex = 92;
            // 
            // Column_Recommendations
            // 
            this.Column_Recommendations.HeaderText = "Recommendations";
            this.Column_Recommendations.Name = "Column_Recommendations";
            this.Column_Recommendations.ReadOnly = true;
            // 
            // bt_SaveRecommendation
            // 
            this.bt_SaveRecommendation.Location = new System.Drawing.Point(630, 200);
            this.bt_SaveRecommendation.Name = "bt_SaveRecommendation";
            this.bt_SaveRecommendation.Size = new System.Drawing.Size(83, 27);
            this.bt_SaveRecommendation.TabIndex = 91;
            this.bt_SaveRecommendation.Text = "SAVE";
            this.bt_SaveRecommendation.UseVisualStyleBackColor = true;
            // 
            // cb_Recommendation
            // 
            this.cb_Recommendation.FormattingEnabled = true;
            this.cb_Recommendation.Location = new System.Drawing.Point(151, 203);
            this.cb_Recommendation.Name = "cb_Recommendation";
            this.cb_Recommendation.Size = new System.Drawing.Size(473, 27);
            this.cb_Recommendation.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(15, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 89;
            this.label10.Text = "Recommendation:";
            // 
            // dataGridView_FindingParticular
            // 
            this.dataGridView_FindingParticular.AllowUserToAddRows = false;
            this.dataGridView_FindingParticular.AllowUserToDeleteRows = false;
            this.dataGridView_FindingParticular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FindingParticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FindingParticular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Particular,
            this.Column_Findings});
            this.dataGridView_FindingParticular.Location = new System.Drawing.Point(19, 68);
            this.dataGridView_FindingParticular.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_FindingParticular.Name = "dataGridView_FindingParticular";
            this.dataGridView_FindingParticular.ReadOnly = true;
            this.dataGridView_FindingParticular.RowHeadersVisible = false;
            this.dataGridView_FindingParticular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FindingParticular.Size = new System.Drawing.Size(798, 106);
            this.dataGridView_FindingParticular.TabIndex = 88;
            // 
            // Column_Particular
            // 
            this.Column_Particular.HeaderText = "Particular";
            this.Column_Particular.Name = "Column_Particular";
            this.Column_Particular.ReadOnly = true;
            // 
            // Column_Findings
            // 
            this.Column_Findings.FillWeight = 50F;
            this.Column_Findings.HeaderText = "Findings";
            this.Column_Findings.Name = "Column_Findings";
            this.Column_Findings.ReadOnly = true;
            // 
            // bt_SaveParticularFinding
            // 
            this.bt_SaveParticularFinding.Location = new System.Drawing.Point(684, 32);
            this.bt_SaveParticularFinding.Name = "bt_SaveParticularFinding";
            this.bt_SaveParticularFinding.Size = new System.Drawing.Size(58, 27);
            this.bt_SaveParticularFinding.TabIndex = 86;
            this.bt_SaveParticularFinding.Text = "SAVE";
            this.bt_SaveParticularFinding.UseVisualStyleBackColor = true;
            // 
            // cb_Finding
            // 
            this.cb_Finding.FormattingEnabled = true;
            this.cb_Finding.Location = new System.Drawing.Point(385, 38);
            this.cb_Finding.Name = "cb_Finding";
            this.cb_Finding.Size = new System.Drawing.Size(284, 27);
            this.cb_Finding.TabIndex = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label16.Location = new System.Drawing.Point(323, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 21);
            this.label16.TabIndex = 86;
            this.label16.Text = "Finding:";
            // 
            // cb_Particular
            // 
            this.cb_Particular.FormattingEnabled = true;
            this.cb_Particular.Location = new System.Drawing.Point(80, 38);
            this.cb_Particular.Name = "cb_Particular";
            this.cb_Particular.Size = new System.Drawing.Size(233, 27);
            this.cb_Particular.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Particular:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cb_RequestingOffice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dateTimePicker_Received);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cb_RequestedBy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cb_ReceivedBy);
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 192);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 27);
            this.comboBox1.TabIndex = 83;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label18.Location = new System.Drawing.Point(6, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 21);
            this.label18.TabIndex = 82;
            this.label18.Text = "Position:";
            // 
            // cb_RequestingOffice
            // 
            this.cb_RequestingOffice.FormattingEnabled = true;
            this.cb_RequestingOffice.Location = new System.Drawing.Point(179, 27);
            this.cb_RequestingOffice.Name = "cb_RequestingOffice";
            this.cb_RequestingOffice.Size = new System.Drawing.Size(392, 27);
            this.cb_RequestingOffice.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(133, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Requesting Office";
            // 
            // dateTimePicker_Received
            // 
            this.dateTimePicker_Received.Location = new System.Drawing.Point(179, 153);
            this.dateTimePicker_Received.Name = "dateTimePicker_Received";
            this.dateTimePicker_Received.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_Received.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(6, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date:";
            // 
            // cb_RequestedBy
            // 
            this.cb_RequestedBy.FormattingEnabled = true;
            this.cb_RequestedBy.Location = new System.Drawing.Point(179, 59);
            this.cb_RequestedBy.Name = "cb_RequestedBy";
            this.cb_RequestedBy.Size = new System.Drawing.Size(392, 27);
            this.cb_RequestedBy.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Received by:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label21.Location = new System.Drawing.Point(6, 59);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(107, 21);
            this.label21.TabIndex = 78;
            this.label21.Text = "Requested by:";
            // 
            // cb_ReceivedBy
            // 
            this.cb_ReceivedBy.FormattingEnabled = true;
            this.cb_ReceivedBy.Location = new System.Drawing.Point(179, 88);
            this.cb_ReceivedBy.Name = "cb_ReceivedBy";
            this.cb_ReceivedBy.Size = new System.Drawing.Size(392, 27);
            this.cb_ReceivedBy.TabIndex = 18;
            // 
            // ucInspectionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panel_PostPre);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucInspectionReport";
            this.Size = new System.Drawing.Size(948, 531);
            this.panel_PostPre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PerformedInspected)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProcedureTest)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gb_TypeOfUnit.ResumeLayout(false);
            this.gb_TypeOfUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnitSpecs)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recommendation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FindingParticular)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_PostPre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_RemovePI;
        private System.Windows.Forms.DataGridView dataGridView_PerformedInspected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Position;
        private System.Windows.Forms.Button cb_SavePI;
        private System.Windows.Forms.ComboBox cb_Position;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_NamePerformedInspected;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_MagicBox;
        private System.Windows.Forms.Button bt_RemovePT;
        private System.Windows.Forms.DataGridView dataGridView_ProcedureTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cb_ProcedureTest;
        private System.Windows.Forms.Button bt_SaveProcedure;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_PropertyNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_TypeOfUnit;
        private System.Windows.Forms.ComboBox cb_ComplaintOnUnit;
        private System.Windows.Forms.GroupBox gb_TypeOfUnit;
        private System.Windows.Forms.Button bt_RemoveUS;
        private System.Windows.Forms.Button bt_UnitSpecification;
        private System.Windows.Forms.ComboBox cb_ComponentRemarks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cb_HardwareComponents;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView_UnitSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Components;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Remarks;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_RemoveR;
        private System.Windows.Forms.Button bt_RemovePF;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView_Recommendation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Recommendations;
        private System.Windows.Forms.Button bt_SaveRecommendation;
        private System.Windows.Forms.ComboBox cb_Recommendation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_FindingParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Particular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Findings;
        private System.Windows.Forms.Button bt_SaveParticularFinding;
        private System.Windows.Forms.ComboBox cb_Finding;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_Particular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_RequestingOffice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Received;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_RequestedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cb_ReceivedBy;
    }
}
