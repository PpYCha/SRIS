﻿
namespace SRIS.UserForms
{
    partial class OfficeDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeDepartment));
            this.dataGridView_OfficeDepartment = new System.Windows.Forms.DataGridView();
            this.odidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDepartmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.officeDeparmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_OfficeDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfficeDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeDeparmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_OfficeDepartment
            // 
            this.dataGridView_OfficeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_OfficeDepartment.AutoGenerateColumns = false;
            this.dataGridView_OfficeDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OfficeDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odidDataGridViewTextBoxColumn,
            this.officeDepartmentNameDataGridViewTextBoxColumn,
            this.abbreviationDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView_OfficeDepartment.DataSource = this.officeDeparmentBindingSource;
            this.dataGridView_OfficeDepartment.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_OfficeDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_OfficeDepartment.Name = "dataGridView_OfficeDepartment";
            this.dataGridView_OfficeDepartment.Size = new System.Drawing.Size(1199, 335);
            this.dataGridView_OfficeDepartment.TabIndex = 0;
            // 
            // odidDataGridViewTextBoxColumn
            // 
            this.odidDataGridViewTextBoxColumn.DataPropertyName = "Od_id";
            this.odidDataGridViewTextBoxColumn.HeaderText = "Od_id";
            this.odidDataGridViewTextBoxColumn.Name = "odidDataGridViewTextBoxColumn";
            this.odidDataGridViewTextBoxColumn.Visible = false;
            // 
            // officeDepartmentNameDataGridViewTextBoxColumn
            // 
            this.officeDepartmentNameDataGridViewTextBoxColumn.DataPropertyName = "OfficeDepartmentName";
            this.officeDepartmentNameDataGridViewTextBoxColumn.HeaderText = "Office/Department";
            this.officeDepartmentNameDataGridViewTextBoxColumn.Name = "officeDepartmentNameDataGridViewTextBoxColumn";
            // 
            // abbreviationDataGridViewTextBoxColumn
            // 
            this.abbreviationDataGridViewTextBoxColumn.DataPropertyName = "Abbreviation";
            this.abbreviationDataGridViewTextBoxColumn.FillWeight = 70F;
            this.abbreviationDataGridViewTextBoxColumn.HeaderText = "Abbreviation";
            this.abbreviationDataGridViewTextBoxColumn.Name = "abbreviationDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.FillWeight = 30F;
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // officeDeparmentBindingSource
            // 
            this.officeDeparmentBindingSource.DataSource = typeof(SRIS.Models.OfficeDeparment);
            // 
            // bt_Remove
            // 
            this.bt_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bt_Remove.FlatAppearance.BorderSize = 0;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_Remove.Location = new System.Drawing.Point(1037, 351);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(174, 43);
            this.bt_Remove.TabIndex = 4;
            this.bt_Remove.Text = "REMOVE";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_OfficeDepartment
            // 
            this.bt_OfficeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OfficeDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bt_OfficeDepartment.FlatAppearance.BorderSize = 0;
            this.bt_OfficeDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OfficeDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bt_OfficeDepartment.Location = new System.Drawing.Point(848, 351);
            this.bt_OfficeDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.bt_OfficeDepartment.Name = "bt_OfficeDepartment";
            this.bt_OfficeDepartment.Size = new System.Drawing.Size(174, 43);
            this.bt_OfficeDepartment.TabIndex = 3;
            this.bt_OfficeDepartment.Text = "SAVE";
            this.bt_OfficeDepartment.UseVisualStyleBackColor = false;
            this.bt_OfficeDepartment.Click += new System.EventHandler(this.bt_OfficeDepartment_Click);
            // 
            // OfficeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1221, 403);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_OfficeDepartment);
            this.Controls.Add(this.dataGridView_OfficeDepartment);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OfficeDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office/Department List";
            this.Load += new System.EventHandler(this.OfficeDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OfficeDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeDeparmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_OfficeDepartment;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_OfficeDepartment;
        private System.Windows.Forms.BindingSource officeDeparmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn odidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDepartmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}