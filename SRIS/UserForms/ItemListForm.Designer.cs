
namespace SRIS.UserForms
{
    partial class ItemListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemListForm));
            this.bt_SaveTech = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.dataGridView_ItemList = new System.Windows.Forms.DataGridView();
            this.iidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemReplacementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView_ItemList
            // 
            this.dataGridView_ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ItemList.AutoGenerateColumns = false;
            this.dataGridView_ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iidDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemReplacementDataGridViewTextBoxColumn,
            this.iridDataGridViewTextBoxColumn});
            this.dataGridView_ItemList.DataSource = this.itemBindingSource;
            this.dataGridView_ItemList.Location = new System.Drawing.Point(18, 13);
            this.dataGridView_ItemList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ItemList.Name = "dataGridView_ItemList";
            this.dataGridView_ItemList.Size = new System.Drawing.Size(693, 246);
            this.dataGridView_ItemList.TabIndex = 0;
            // 
            // iidDataGridViewTextBoxColumn
            // 
            this.iidDataGridViewTextBoxColumn.DataPropertyName = "I_id";
            this.iidDataGridViewTextBoxColumn.HeaderText = "I_id";
            this.iidDataGridViewTextBoxColumn.Name = "iidDataGridViewTextBoxColumn";
            this.iidDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // itemReplacementDataGridViewTextBoxColumn
            // 
            this.itemReplacementDataGridViewTextBoxColumn.DataPropertyName = "ItemReplacement";
            this.itemReplacementDataGridViewTextBoxColumn.HeaderText = "ItemReplacement";
            this.itemReplacementDataGridViewTextBoxColumn.Name = "itemReplacementDataGridViewTextBoxColumn";
            this.itemReplacementDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemReplacementDataGridViewTextBoxColumn.Visible = false;
            // 
            // iridDataGridViewTextBoxColumn
            // 
            this.iridDataGridViewTextBoxColumn.DataPropertyName = "Ir_id";
            this.iridDataGridViewTextBoxColumn.HeaderText = "Ir_id";
            this.iridDataGridViewTextBoxColumn.Name = "iridDataGridViewTextBoxColumn";
            this.iridDataGridViewTextBoxColumn.ReadOnly = true;
            this.iridDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SRIS.Models.Item);
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(730, 304);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_SaveTech);
            this.Controls.Add(this.dataGridView_ItemList);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item List";
            this.Load += new System.EventHandler(this.ItemListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_SaveTech;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn techidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_ItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn iidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemReplacementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}