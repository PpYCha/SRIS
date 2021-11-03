
namespace SRIS.UserForms
{
    partial class RptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptForm));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cb_MonthStart = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.cb_MonthEnd = new System.Windows.Forms.ComboBox();
            this.cb_Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1121, 434);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cb_MonthStart
            // 
            this.cb_MonthStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MonthStart.FormattingEnabled = true;
            this.cb_MonthStart.Location = new System.Drawing.Point(114, 11);
            this.cb_MonthStart.Name = "cb_MonthStart";
            this.cb_MonthStart.Size = new System.Drawing.Size(151, 31);
            this.cb_MonthStart.TabIndex = 4;
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(446, 13);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(151, 31);
            this.cb_Year.TabIndex = 5;
            // 
            // cb_MonthEnd
            // 
            this.cb_MonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MonthEnd.FormattingEnabled = true;
            this.cb_MonthEnd.Location = new System.Drawing.Point(280, 12);
            this.cb_MonthEnd.Name = "cb_MonthEnd";
            this.cb_MonthEnd.Size = new System.Drawing.Size(151, 31);
            this.cb_MonthEnd.TabIndex = 6;
            // 
            // cb_Find
            // 
            this.cb_Find.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_Find.Image = ((System.Drawing.Image)(resources.GetObject("cb_Find.Image")));
            this.cb_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_Find.Location = new System.Drawing.Point(6, 13);
            this.cb_Find.Name = "cb_Find";
            this.cb_Find.Size = new System.Drawing.Size(89, 29);
            this.cb_Find.TabIndex = 12;
            this.cb_Find.Text = "Search";
            this.cb_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Find.UseVisualStyleBackColor = true;
            this.cb_Find.Click += new System.EventHandler(this.cb_Find_Click);
            // 
            // RptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 506);
            this.Controls.Add(this.cb_Find);
            this.Controls.Add(this.cb_MonthEnd);
            this.Controls.Add(this.cb_Year);
            this.Controls.Add(this.cb_MonthStart);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RptForm";
            this.Text = "Service Request Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cb_MonthStart;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.ComboBox cb_MonthEnd;
        private System.Windows.Forms.Button cb_Find;
    }
}