
namespace SRIS.UserControls
{
    partial class ucArchivedRequest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucArchivedRequest));
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.dataGridView_SRlist = new System.Windows.Forms.DataGridView();
            this.sridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfServiceProvidedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRequestedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDepartmentSrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SRlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_search.Location = new System.Drawing.Point(6, 13);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(89, 29);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Search";
            this.bt_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(101, 13);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(524, 27);
            this.tb_search.TabIndex = 2;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Searches:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(756, 25);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(0, 19);
            this.label_Total.TabIndex = 4;
            // 
            // dataGridView_SRlist
            // 
            this.dataGridView_SRlist.AllowUserToAddRows = false;
            this.dataGridView_SRlist.AllowUserToDeleteRows = false;
            this.dataGridView_SRlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SRlist.AutoGenerateColumns = false;
            this.dataGridView_SRlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SRlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SRlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sridDataGridViewTextBoxColumn,
            this.typeOfServiceProvidedDataGridViewTextBoxColumn,
            this.RequestedBy,
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn,
            this.dateRequestedDataGridViewTextBoxColumn,
            this.faultDiagnosisDataGridViewTextBoxColumn,
            this.dateCompletedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateEnteredDataGridViewTextBoxColumn,
            this.technicianServiceDataGridViewTextBoxColumn,
            this.officeDepartmentSrDataGridViewTextBoxColumn});
            this.dataGridView_SRlist.DataSource = this.serviceRequestBindingSource;
            this.dataGridView_SRlist.Location = new System.Drawing.Point(2, 47);
            this.dataGridView_SRlist.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_SRlist.Name = "dataGridView_SRlist";
            this.dataGridView_SRlist.ReadOnly = true;
            this.dataGridView_SRlist.RowHeadersVisible = false;
            this.dataGridView_SRlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SRlist.Size = new System.Drawing.Size(1027, 379);
            this.dataGridView_SRlist.TabIndex = 7;
            // 
            // sridDataGridViewTextBoxColumn
            // 
            this.sridDataGridViewTextBoxColumn.DataPropertyName = "Sr_id";
            this.sridDataGridViewTextBoxColumn.HeaderText = "Sr_id";
            this.sridDataGridViewTextBoxColumn.Name = "sridDataGridViewTextBoxColumn";
            this.sridDataGridViewTextBoxColumn.ReadOnly = true;
            this.sridDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeOfServiceProvidedDataGridViewTextBoxColumn
            // 
            this.typeOfServiceProvidedDataGridViewTextBoxColumn.DataPropertyName = "TypeOfServiceProvided";
            this.typeOfServiceProvidedDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.typeOfServiceProvidedDataGridViewTextBoxColumn.HeaderText = "Type Of Service Provided";
            this.typeOfServiceProvidedDataGridViewTextBoxColumn.Name = "typeOfServiceProvidedDataGridViewTextBoxColumn";
            this.typeOfServiceProvidedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RequestedBy
            // 
            this.RequestedBy.DataPropertyName = "RequestedBy";
            this.RequestedBy.FillWeight = 82.91032F;
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn
            // 
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TypeOfServiceProvided_Description";
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn.HeaderText = "TypeOfServiceProvided_Description";
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn.Name = "typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn";
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateRequestedDataGridViewTextBoxColumn
            // 
            this.dateRequestedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateRequestedDataGridViewTextBoxColumn.DataPropertyName = "DateRequested";
            this.dateRequestedDataGridViewTextBoxColumn.FillWeight = 126.9035F;
            this.dateRequestedDataGridViewTextBoxColumn.HeaderText = "Date Requested";
            this.dateRequestedDataGridViewTextBoxColumn.Name = "dateRequestedDataGridViewTextBoxColumn";
            this.dateRequestedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateRequestedDataGridViewTextBoxColumn.Width = 132;
            // 
            // faultDiagnosisDataGridViewTextBoxColumn
            // 
            this.faultDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "FaultDiagnosis";
            this.faultDiagnosisDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.faultDiagnosisDataGridViewTextBoxColumn.HeaderText = "Fault Diagnosis";
            this.faultDiagnosisDataGridViewTextBoxColumn.Name = "faultDiagnosisDataGridViewTextBoxColumn";
            this.faultDiagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCompletedDataGridViewTextBoxColumn
            // 
            this.dateCompletedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateCompletedDataGridViewTextBoxColumn.DataPropertyName = "DateCompleted";
            this.dateCompletedDataGridViewTextBoxColumn.FillWeight = 41.45516F;
            this.dateCompletedDataGridViewTextBoxColumn.HeaderText = "Date Completed";
            this.dateCompletedDataGridViewTextBoxColumn.Name = "dateCompletedDataGridViewTextBoxColumn";
            this.dateCompletedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCompletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateEnteredDataGridViewTextBoxColumn
            // 
            this.dateEnteredDataGridViewTextBoxColumn.DataPropertyName = "DateEntered";
            this.dateEnteredDataGridViewTextBoxColumn.HeaderText = "DateEntered";
            this.dateEnteredDataGridViewTextBoxColumn.Name = "dateEnteredDataGridViewTextBoxColumn";
            this.dateEnteredDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEnteredDataGridViewTextBoxColumn.Visible = false;
            // 
            // technicianServiceDataGridViewTextBoxColumn
            // 
            this.technicianServiceDataGridViewTextBoxColumn.DataPropertyName = "TechnicianService";
            this.technicianServiceDataGridViewTextBoxColumn.HeaderText = "TechnicianService";
            this.technicianServiceDataGridViewTextBoxColumn.Name = "technicianServiceDataGridViewTextBoxColumn";
            this.technicianServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.technicianServiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // officeDepartmentSrDataGridViewTextBoxColumn
            // 
            this.officeDepartmentSrDataGridViewTextBoxColumn.DataPropertyName = "OfficeDepartmentSr";
            this.officeDepartmentSrDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.officeDepartmentSrDataGridViewTextBoxColumn.HeaderText = "Office/Department";
            this.officeDepartmentSrDataGridViewTextBoxColumn.Name = "officeDepartmentSrDataGridViewTextBoxColumn";
            this.officeDepartmentSrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceRequestBindingSource
            // 
            this.serviceRequestBindingSource.DataSource = typeof(SRIS.Models.ServiceRequest);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 28);
            this.panel1.TabIndex = 8;
            // 
            // ucArchivedRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_SRlist);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_search);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucArchivedRequest";
            this.Size = new System.Drawing.Size(1031, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SRlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.DataGridView dataGridView_SRlist;
        private System.Windows.Forms.BindingSource serviceRequestBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfServiceProvidedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfServiceProvidedDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRequestedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faultDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDepartmentSrDataGridViewTextBoxColumn;
    }
}
