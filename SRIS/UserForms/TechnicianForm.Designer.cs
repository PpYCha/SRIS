
namespace SRIS.UserForms
{
    partial class TechnicianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianForm));
            this.dataGridView_Technician = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_SaveTech = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Technician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Technician
            // 
            this.dataGridView_Technician.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Technician.AutoGenerateColumns = false;
            this.dataGridView_Technician.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Technician.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Technician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Technician.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView_Technician.DataSource = this.technicianBindingSource;
            this.dataGridView_Technician.Location = new System.Drawing.Point(18, 18);
            this.dataGridView_Technician.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Technician.Name = "dataGridView_Technician";
            this.dataGridView_Technician.Size = new System.Drawing.Size(693, 241);
            this.dataGridView_Technician.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tech_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tech_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TechName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TechName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TechPosition";
            this.dataGridViewTextBoxColumn3.HeaderText = "TechPosition";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TechnicianService";
            this.dataGridViewTextBoxColumn4.HeaderText = "TechnicianService";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(SRIS.Models.Technician);
            // 
            // bt_SaveTech
            // 
            this.bt_SaveTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SaveTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bt_SaveTech.FlatAppearance.BorderSize = 0;
            this.bt_SaveTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveTech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_SaveTech.Location = new System.Drawing.Point(472, 267);
            this.bt_SaveTech.Margin = new System.Windows.Forms.Padding(0);
            this.bt_SaveTech.Name = "bt_SaveTech";
            this.bt_SaveTech.Size = new System.Drawing.Size(112, 34);
            this.bt_SaveTech.TabIndex = 1;
            this.bt_SaveTech.Text = "SAVE";
            this.bt_SaveTech.UseVisualStyleBackColor = false;
            this.bt_SaveTech.Click += new System.EventHandler(this.bt_SaveTech_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bt_Remove.FlatAppearance.BorderSize = 0;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_Remove.Location = new System.Drawing.Point(599, 267);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(112, 34);
            this.bt_Remove.TabIndex = 2;
            this.bt_Remove.Text = "REMOVE";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // TechnicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(730, 304);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_SaveTech);
            this.Controls.Add(this.dataGridView_Technician);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TechnicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technician List";
            this.Load += new System.EventHandler(this.TechnicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Technician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Technician;
        private System.Windows.Forms.Button bt_SaveTech;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn techidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource technicianBindingSource;
    }
}