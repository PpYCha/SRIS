
namespace SRIS.UserForms
{
    partial class TechnicianListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianListForm));
            this.dataGridView_TechList = new System.Windows.Forms.DataGridView();
            this.bt_AssignTech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TechList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TechList
            // 
            this.dataGridView_TechList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TechList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TechList.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_TechList.Name = "dataGridView_TechList";
            this.dataGridView_TechList.Size = new System.Drawing.Size(749, 308);
            this.dataGridView_TechList.TabIndex = 0;
            // 
            // bt_AssignTech
            // 
            this.bt_AssignTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AssignTech.Image = ((System.Drawing.Image)(resources.GetObject("bt_AssignTech.Image")));
            this.bt_AssignTech.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_AssignTech.Location = new System.Drawing.Point(584, 335);
            this.bt_AssignTech.Name = "bt_AssignTech";
            this.bt_AssignTech.Size = new System.Drawing.Size(177, 37);
            this.bt_AssignTech.TabIndex = 1;
            this.bt_AssignTech.Text = "Assign Technician";
            this.bt_AssignTech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_AssignTech.UseVisualStyleBackColor = true;
            this.bt_AssignTech.Click += new System.EventHandler(this.bt_AssignTech_Click);
            // 
            // TechnicianListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(773, 382);
            this.Controls.Add(this.bt_AssignTech);
            this.Controls.Add(this.dataGridView_TechList);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TechnicianListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technician List";
            this.Load += new System.EventHandler(this.TechnicianListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TechList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TechList;
        private System.Windows.Forms.Button bt_AssignTech;
    }
}