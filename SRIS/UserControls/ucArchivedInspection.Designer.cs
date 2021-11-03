
namespace SRIS.UserControls
{
    partial class ucArchivedInspection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucArchivedInspection));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_SearchInspection = new System.Windows.Forms.Button();
            this.dataGridView_InspectionRecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestingOfficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaintOnUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitReleasedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionUnitReleasedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReleasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findingParticularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSpecificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InspectionRecord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bt_SearchInspection
            // 
            this.bt_SearchInspection.ForeColor = System.Drawing.Color.Black;
            this.bt_SearchInspection.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchInspection.Image")));
            this.bt_SearchInspection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SearchInspection.Location = new System.Drawing.Point(6, 13);
            this.bt_SearchInspection.Name = "bt_SearchInspection";
            this.bt_SearchInspection.Size = new System.Drawing.Size(89, 29);
            this.bt_SearchInspection.TabIndex = 5;
            this.bt_SearchInspection.Text = "Search";
            this.bt_SearchInspection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchInspection.UseVisualStyleBackColor = true;
            this.bt_SearchInspection.Click += new System.EventHandler(this.bt_SearchInspection_Click);
            // 
            // dataGridView_InspectionRecord
            // 
            this.dataGridView_InspectionRecord.AllowUserToAddRows = false;
            this.dataGridView_InspectionRecord.AllowUserToDeleteRows = false;
            this.dataGridView_InspectionRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_InspectionRecord.AutoGenerateColumns = false;
            this.dataGridView_InspectionRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_InspectionRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InspectionRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iiidDataGridViewTextBoxColumn,
            this.requestingOfficeDataGridViewTextBoxColumn,
            this.requestedByDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.receivedDateDataGridViewTextBoxColumn,
            this.receivedPositionDataGridViewTextBoxColumn,
            this.typeOfUnitDataGridViewTextBoxColumn,
            this.complaintOnUnitDataGridViewTextBoxColumn,
            this.propertyNumberDataGridViewTextBoxColumn,
            this.unitReleasedToDataGridViewTextBoxColumn,
            this.positionUnitReleasedToDataGridViewTextBoxColumn,
            this.dateReleasedDataGridViewTextBoxColumn,
            this.findingParticularDataGridViewTextBoxColumn,
            this.procedureTestDataGridViewTextBoxColumn,
            this.unitSpecificationDataGridViewTextBoxColumn,
            this.inspectedDataGridViewTextBoxColumn,
            this.recommendationDataGridViewTextBoxColumn});
            this.dataGridView_InspectionRecord.DataSource = this.inspectionInfoBindingSource;
            this.dataGridView_InspectionRecord.Location = new System.Drawing.Point(2, 47);
            this.dataGridView_InspectionRecord.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_InspectionRecord.Name = "dataGridView_InspectionRecord";
            this.dataGridView_InspectionRecord.ReadOnly = true;
            this.dataGridView_InspectionRecord.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_InspectionRecord.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_InspectionRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_InspectionRecord.Size = new System.Drawing.Size(1027, 361);
            this.dataGridView_InspectionRecord.TabIndex = 9;
            this.dataGridView_InspectionRecord.DoubleClick += new System.EventHandler(this.dataGridView_InspectionRecord_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 28);
            this.panel1.TabIndex = 10;
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
            // iiidDataGridViewTextBoxColumn
            // 
            this.iiidDataGridViewTextBoxColumn.DataPropertyName = "Ii_id";
            this.iiidDataGridViewTextBoxColumn.HeaderText = "Ii_id";
            this.iiidDataGridViewTextBoxColumn.Name = "iiidDataGridViewTextBoxColumn";
            this.iiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.iiidDataGridViewTextBoxColumn.Visible = false;
            // 
            // requestingOfficeDataGridViewTextBoxColumn
            // 
            this.requestingOfficeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.requestingOfficeDataGridViewTextBoxColumn.DataPropertyName = "RequestingOffice";
            this.requestingOfficeDataGridViewTextBoxColumn.FillWeight = 100.1953F;
            this.requestingOfficeDataGridViewTextBoxColumn.HeaderText = "Requesting Office";
            this.requestingOfficeDataGridViewTextBoxColumn.Name = "requestingOfficeDataGridViewTextBoxColumn";
            this.requestingOfficeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestedByDataGridViewTextBoxColumn
            // 
            this.requestedByDataGridViewTextBoxColumn.DataPropertyName = "RequestedBy";
            this.requestedByDataGridViewTextBoxColumn.FillWeight = 100.1728F;
            this.requestedByDataGridViewTextBoxColumn.HeaderText = "Requested By";
            this.requestedByDataGridViewTextBoxColumn.Name = "requestedByDataGridViewTextBoxColumn";
            this.requestedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedByDataGridViewTextBoxColumn
            // 
            this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "ReceivedBy";
            this.receivedByDataGridViewTextBoxColumn.FillWeight = 99.27428F;
            this.receivedByDataGridViewTextBoxColumn.HeaderText = "Received By";
            this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
            this.receivedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedDateDataGridViewTextBoxColumn
            // 
            this.receivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.FillWeight = 100.2328F;
            this.receivedDateDataGridViewTextBoxColumn.HeaderText = "Received Date";
            this.receivedDateDataGridViewTextBoxColumn.Name = "receivedDateDataGridViewTextBoxColumn";
            this.receivedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedPositionDataGridViewTextBoxColumn
            // 
            this.receivedPositionDataGridViewTextBoxColumn.DataPropertyName = "ReceivedPosition";
            this.receivedPositionDataGridViewTextBoxColumn.HeaderText = "ReceivedPosition";
            this.receivedPositionDataGridViewTextBoxColumn.Name = "receivedPositionDataGridViewTextBoxColumn";
            this.receivedPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedPositionDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeOfUnitDataGridViewTextBoxColumn
            // 
            this.typeOfUnitDataGridViewTextBoxColumn.DataPropertyName = "TypeOfUnit";
            this.typeOfUnitDataGridViewTextBoxColumn.FillWeight = 100.2062F;
            this.typeOfUnitDataGridViewTextBoxColumn.HeaderText = "Type Of Unit";
            this.typeOfUnitDataGridViewTextBoxColumn.Name = "typeOfUnitDataGridViewTextBoxColumn";
            this.typeOfUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complaintOnUnitDataGridViewTextBoxColumn
            // 
            this.complaintOnUnitDataGridViewTextBoxColumn.DataPropertyName = "ComplaintOnUnit";
            this.complaintOnUnitDataGridViewTextBoxColumn.FillWeight = 100.1824F;
            this.complaintOnUnitDataGridViewTextBoxColumn.HeaderText = "Complaint On Unit";
            this.complaintOnUnitDataGridViewTextBoxColumn.Name = "complaintOnUnitDataGridViewTextBoxColumn";
            this.complaintOnUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // propertyNumberDataGridViewTextBoxColumn
            // 
            this.propertyNumberDataGridViewTextBoxColumn.DataPropertyName = "PropertyNumber";
            this.propertyNumberDataGridViewTextBoxColumn.FillWeight = 99.28276F;
            this.propertyNumberDataGridViewTextBoxColumn.HeaderText = "PropertyNumber";
            this.propertyNumberDataGridViewTextBoxColumn.Name = "propertyNumberDataGridViewTextBoxColumn";
            this.propertyNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitReleasedToDataGridViewTextBoxColumn
            // 
            this.unitReleasedToDataGridViewTextBoxColumn.DataPropertyName = "UnitReleasedTo";
            this.unitReleasedToDataGridViewTextBoxColumn.FillWeight = 100.2405F;
            this.unitReleasedToDataGridViewTextBoxColumn.HeaderText = "Unit Released To";
            this.unitReleasedToDataGridViewTextBoxColumn.Name = "unitReleasedToDataGridViewTextBoxColumn";
            this.unitReleasedToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionUnitReleasedToDataGridViewTextBoxColumn
            // 
            this.positionUnitReleasedToDataGridViewTextBoxColumn.DataPropertyName = "PositionUnitReleasedTo";
            this.positionUnitReleasedToDataGridViewTextBoxColumn.HeaderText = "PositionUnitReleasedTo";
            this.positionUnitReleasedToDataGridViewTextBoxColumn.Name = "positionUnitReleasedToDataGridViewTextBoxColumn";
            this.positionUnitReleasedToDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionUnitReleasedToDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateReleasedDataGridViewTextBoxColumn
            // 
            this.dateReleasedDataGridViewTextBoxColumn.DataPropertyName = "DateReleased";
            this.dateReleasedDataGridViewTextBoxColumn.FillWeight = 100.2129F;
            this.dateReleasedDataGridViewTextBoxColumn.HeaderText = "Date Released";
            this.dateReleasedDataGridViewTextBoxColumn.Name = "dateReleasedDataGridViewTextBoxColumn";
            this.dateReleasedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // findingParticularDataGridViewTextBoxColumn
            // 
            this.findingParticularDataGridViewTextBoxColumn.DataPropertyName = "FindingParticular";
            this.findingParticularDataGridViewTextBoxColumn.HeaderText = "FindingParticular";
            this.findingParticularDataGridViewTextBoxColumn.Name = "findingParticularDataGridViewTextBoxColumn";
            this.findingParticularDataGridViewTextBoxColumn.ReadOnly = true;
            this.findingParticularDataGridViewTextBoxColumn.Visible = false;
            // 
            // procedureTestDataGridViewTextBoxColumn
            // 
            this.procedureTestDataGridViewTextBoxColumn.DataPropertyName = "ProcedureTest";
            this.procedureTestDataGridViewTextBoxColumn.HeaderText = "ProcedureTest";
            this.procedureTestDataGridViewTextBoxColumn.Name = "procedureTestDataGridViewTextBoxColumn";
            this.procedureTestDataGridViewTextBoxColumn.ReadOnly = true;
            this.procedureTestDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitSpecificationDataGridViewTextBoxColumn
            // 
            this.unitSpecificationDataGridViewTextBoxColumn.DataPropertyName = "UnitSpecification";
            this.unitSpecificationDataGridViewTextBoxColumn.HeaderText = "UnitSpecification";
            this.unitSpecificationDataGridViewTextBoxColumn.Name = "unitSpecificationDataGridViewTextBoxColumn";
            this.unitSpecificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitSpecificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspectedDataGridViewTextBoxColumn
            // 
            this.inspectedDataGridViewTextBoxColumn.DataPropertyName = "Inspected";
            this.inspectedDataGridViewTextBoxColumn.HeaderText = "Inspected";
            this.inspectedDataGridViewTextBoxColumn.Name = "inspectedDataGridViewTextBoxColumn";
            this.inspectedDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectedDataGridViewTextBoxColumn.Visible = false;
            // 
            // recommendationDataGridViewTextBoxColumn
            // 
            this.recommendationDataGridViewTextBoxColumn.DataPropertyName = "Recommendation";
            this.recommendationDataGridViewTextBoxColumn.HeaderText = "Recommendation";
            this.recommendationDataGridViewTextBoxColumn.Name = "recommendationDataGridViewTextBoxColumn";
            this.recommendationDataGridViewTextBoxColumn.ReadOnly = true;
            this.recommendationDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspectionInfoBindingSource
            // 
            this.inspectionInfoBindingSource.DataSource = typeof(SRIS.Models.InspectionInfo);
            // 
            // ucArchivedInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_InspectionRecord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_SearchInspection);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucArchivedInspection";
            this.Size = new System.Drawing.Size(1031, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InspectionRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_SearchInspection;
        private System.Windows.Forms.DataGridView dataGridView_InspectionRecord;
        private System.Windows.Forms.BindingSource inspectionInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestingOfficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaintOnUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitReleasedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionUnitReleasedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReleasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn findingParticularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedureTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSpecificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
