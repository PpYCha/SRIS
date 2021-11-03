using SRIS.UserControls;
using SRIS.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void serviceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowServiceRequestPanel();
        }

        private void ShowServiceRequestPanel()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucServiceRequest.Intance))
            {
                panel_Body.Controls.Add(ucServiceRequest.Intance);
                ucServiceRequest.Intance.Dock = DockStyle.Fill;


            }
            else
            {

            }

            ucServiceRequest.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }



        private void serviceRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucArchivedRequest.Intance))
            {
                panel_Body.Controls.Add(ucArchivedRequest.Intance);
                ucArchivedRequest.Intance.Dock = DockStyle.Fill;


            }
            else
            {

            }

            ucArchivedRequest.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;

        }

        private void inspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucArchivedInspection.Intance))
            {
                panel_Body.Controls.Add(ucArchivedInspection.Intance);
                ucArchivedInspection.Intance.Dock = DockStyle.Fill;


            }
            else
            {

            }

            ucArchivedInspection.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucAccount.Intance))
            {
                panel_Body.Controls.Add(ucAccount.Intance);
                ucAccount.Intance.Dock = DockStyle.Fill;


            }
            else
            {

            }

            ucAccount.Intance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowServiceRequestPanel();
        }

        private void techninicianDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicianForm technicianForm = new TechnicianForm();
            technicianForm.ShowDialog();
        }

        private void officeDepartmentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficeDepartment officeDepartment = new OfficeDepartment();
            officeDepartment.ShowDialog();
        }

        private void sRMonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptForm rptForm = new RptForm();
           
            rptForm.ShowDialog();
        }

        private void sRYearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptForm rptForm = new RptForm();
            rptForm.reportCondition = "Report Yearly Technician";
            rptForm.ShowDialog();
        }

        private void requestedNamesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestedByForm requestedByForm = new RequestedByForm();
            DesignClass.FormDesign(requestedByForm);
            requestedByForm.ShowDialog();
        }

        private void itemReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReplacementForm itemReplacementForm = new ItemReplacementForm();
            DesignClass.FormDesign(itemReplacementForm);
            itemReplacementForm.ShowDialog();
        }
    }
}
