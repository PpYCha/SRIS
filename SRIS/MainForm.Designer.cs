
namespace SRIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serviceRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceRequestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sRMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectionMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDevelopmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techninicianDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeDepartmentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestedNamesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.menuStrip.Font = new System.Drawing.Font("Roboto", 13.25F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceRequestToolStripMenuItem,
            this.archivedToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.manageDatabaseToolStripMenuItem,
            this.systemDevelopmentToolStripMenuItem,
            this.manageDataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1085, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serviceRequestToolStripMenuItem
            // 
            this.serviceRequestToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.serviceRequestToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.serviceRequestToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_request_service_32px;
            this.serviceRequestToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.serviceRequestToolStripMenuItem.Name = "serviceRequestToolStripMenuItem";
            this.serviceRequestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serviceRequestToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.serviceRequestToolStripMenuItem.Text = "Service Request";
            this.serviceRequestToolStripMenuItem.Click += new System.EventHandler(this.serviceRequestToolStripMenuItem_Click);
            // 
            // archivedToolStripMenuItem
            // 
            this.archivedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceRequestToolStripMenuItem1,
            this.inspectionToolStripMenuItem});
            this.archivedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.archivedToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_archive_folder_32px_1;
            this.archivedToolStripMenuItem.Name = "archivedToolStripMenuItem";
            this.archivedToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.archivedToolStripMenuItem.Text = "Archived";
            // 
            // serviceRequestToolStripMenuItem1
            // 
            this.serviceRequestToolStripMenuItem1.Name = "serviceRequestToolStripMenuItem1";
            this.serviceRequestToolStripMenuItem1.Size = new System.Drawing.Size(209, 26);
            this.serviceRequestToolStripMenuItem1.Text = "Service Request";
            this.serviceRequestToolStripMenuItem1.Click += new System.EventHandler(this.serviceRequestToolStripMenuItem1_Click);
            // 
            // inspectionToolStripMenuItem
            // 
            this.inspectionToolStripMenuItem.Name = "inspectionToolStripMenuItem";
            this.inspectionToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.inspectionToolStripMenuItem.Text = "Inspection";
            this.inspectionToolStripMenuItem.Click += new System.EventHandler(this.inspectionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sRMonthlyToolStripMenuItem,
            this.inspectionMonthlyToolStripMenuItem,
            this.itemReplacementToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.reportsToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_pie_chart_32px;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // sRMonthlyToolStripMenuItem
            // 
            this.sRMonthlyToolStripMenuItem.Name = "sRMonthlyToolStripMenuItem";
            this.sRMonthlyToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.sRMonthlyToolStripMenuItem.Text = "Service Request";
            this.sRMonthlyToolStripMenuItem.Click += new System.EventHandler(this.sRMonthlyToolStripMenuItem_Click);
            // 
            // inspectionMonthlyToolStripMenuItem
            // 
            this.inspectionMonthlyToolStripMenuItem.Name = "inspectionMonthlyToolStripMenuItem";
            this.inspectionMonthlyToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.inspectionMonthlyToolStripMenuItem.Text = "Inspection";
            // 
            // itemReplacementToolStripMenuItem
            // 
            this.itemReplacementToolStripMenuItem.Name = "itemReplacementToolStripMenuItem";
            this.itemReplacementToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.itemReplacementToolStripMenuItem.Text = "Item Replacement";
            this.itemReplacementToolStripMenuItem.Click += new System.EventHandler(this.itemReplacementToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.accountsToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_account_32px;
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // manageDatabaseToolStripMenuItem
            // 
            this.manageDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDatabaseToolStripMenuItem,
            this.backUpDatabaseToolStripMenuItem});
            this.manageDatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.manageDatabaseToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_database_32px;
            this.manageDatabaseToolStripMenuItem.Name = "manageDatabaseToolStripMenuItem";
            this.manageDatabaseToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.manageDatabaseToolStripMenuItem.Text = "Database";
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.importDatabaseToolStripMenuItem.Text = "Import Database";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDatabaseToolStripMenuItem_Click);
            // 
            // backUpDatabaseToolStripMenuItem
            // 
            this.backUpDatabaseToolStripMenuItem.Name = "backUpDatabaseToolStripMenuItem";
            this.backUpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.backUpDatabaseToolStripMenuItem.Text = "Back Up Database";
            this.backUpDatabaseToolStripMenuItem.Click += new System.EventHandler(this.backUpDatabaseToolStripMenuItem_Click);
            // 
            // systemDevelopmentToolStripMenuItem
            // 
            this.systemDevelopmentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.systemDevelopmentToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_system_task_32px;
            this.systemDevelopmentToolStripMenuItem.Name = "systemDevelopmentToolStripMenuItem";
            this.systemDevelopmentToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.systemDevelopmentToolStripMenuItem.Text = "System Development";
            // 
            // manageDataToolStripMenuItem
            // 
            this.manageDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.techninicianDataToolStripMenuItem,
            this.officeDepartmentDataToolStripMenuItem,
            this.requestedNamesDataToolStripMenuItem});
            this.manageDataToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(63)))));
            this.manageDataToolStripMenuItem.Image = global::SRIS.Properties.Resources.icons8_data_32px;
            this.manageDataToolStripMenuItem.Name = "manageDataToolStripMenuItem";
            this.manageDataToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.manageDataToolStripMenuItem.Text = "Manage Data";
            // 
            // techninicianDataToolStripMenuItem
            // 
            this.techninicianDataToolStripMenuItem.Name = "techninicianDataToolStripMenuItem";
            this.techninicianDataToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.techninicianDataToolStripMenuItem.Text = "Technician Data";
            this.techninicianDataToolStripMenuItem.Click += new System.EventHandler(this.techninicianDataToolStripMenuItem_Click);
            // 
            // officeDepartmentDataToolStripMenuItem
            // 
            this.officeDepartmentDataToolStripMenuItem.Name = "officeDepartmentDataToolStripMenuItem";
            this.officeDepartmentDataToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.officeDepartmentDataToolStripMenuItem.Text = "Office/Department Data";
            this.officeDepartmentDataToolStripMenuItem.Click += new System.EventHandler(this.officeDepartmentDataToolStripMenuItem_Click);
            // 
            // requestedNamesDataToolStripMenuItem
            // 
            this.requestedNamesDataToolStripMenuItem.Name = "requestedNamesDataToolStripMenuItem";
            this.requestedNamesDataToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.requestedNamesDataToolStripMenuItem.Text = "Requested Names Data";
            this.requestedNamesDataToolStripMenuItem.Click += new System.EventHandler(this.requestedNamesDataToolStripMenuItem_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Transparent;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 30);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1085, 437);
            this.panel_Body.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1085, 467);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1085, 433);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem serviceRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceRequestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sRMonthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspectionMonthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemDevelopmentToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techninicianDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeDepartmentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestedNamesDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemReplacementToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}

