
namespace SRIS.UserForms
{
    partial class RequestedByForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestedByForm));
            this.dataGridView_Names = new System.Windows.Forms.DataGridView();
            this.sridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Names)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Names
            // 
            this.dataGridView_Names.AutoGenerateColumns = false;
            this.dataGridView_Names.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Names.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sridDataGridViewTextBoxColumn,
            this.requestedByDataGridViewTextBoxColumn});
            this.dataGridView_Names.DataSource = this.serviceRequestBindingSource;
            this.dataGridView_Names.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Names.Name = "dataGridView_Names";
            this.dataGridView_Names.Size = new System.Drawing.Size(936, 368);
            this.dataGridView_Names.TabIndex = 0;
            // 
            // sridDataGridViewTextBoxColumn
            // 
            this.sridDataGridViewTextBoxColumn.DataPropertyName = "Sr_id";
            this.sridDataGridViewTextBoxColumn.HeaderText = "Sr_id";
            this.sridDataGridViewTextBoxColumn.Name = "sridDataGridViewTextBoxColumn";
            this.sridDataGridViewTextBoxColumn.Visible = false;
            // 
            // requestedByDataGridViewTextBoxColumn
            // 
            this.requestedByDataGridViewTextBoxColumn.DataPropertyName = "RequestedBy";
            this.requestedByDataGridViewTextBoxColumn.HeaderText = "RequestedBy";
            this.requestedByDataGridViewTextBoxColumn.Name = "requestedByDataGridViewTextBoxColumn";
            // 
            // serviceRequestBindingSource
            // 
            this.serviceRequestBindingSource.DataSource = typeof(SRIS.Models.ServiceRequest);
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Save.ForeColor = System.Drawing.Color.Black;
            this.bt_Save.Image = ((System.Drawing.Image)(resources.GetObject("bt_Save.Image")));
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(847, 386);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(101, 29);
            this.bt_Save.TabIndex = 106;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // RequestedByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 423);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.dataGridView_Names);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestedByForm";
            this.Text = "Request Name List";
            this.Load += new System.EventHandler(this.RequestedByForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Names)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Names;
        private System.Windows.Forms.BindingSource serviceRequestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_Save;
    }
}