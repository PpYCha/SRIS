using SRIS.Models;
using SRIS.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserControls
{
    public partial class ucArchivedInspection : UserControl
    {

        public ucArchivedInspection()
        {
            InitializeComponent();


            DesignClass.dataGridViewDesign(dataGridView_InspectionRecord);
            //  DesignClass.buttonDesign(bt_SearchInspection);


        }

        private static ucArchivedInspection _instance;

        public static ucArchivedInspection Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucArchivedInspection();
                return _instance;
            }


        }

        private void LoadInspection(string tbSearch)
        {
            using (SrisContext ctx = new SrisContext())
            {
                if (String.IsNullOrWhiteSpace(tbSearch))
                {

                    inspectionInfoBindingSource.DataSource = ctx.InspectionInfos.OrderByDescending(x => x.ReceivedDate).ToList();
                    dataGridView_InspectionRecord.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[11].DefaultCellStyle.Format = "MM/dd/yyyy";
                    label1.Text = inspectionInfoBindingSource.Count.ToString() + " items |";
                }
                else
                {
                    inspectionInfoBindingSource.DataSource = ctx.InspectionInfos.Where(x =>
                    x.RequestingOffice.Contains(tbSearch) ||
                    x.RequestedBy.Contains(tbSearch) ||
                    x.ReceivedBy.Contains(tbSearch) ||
                    x.TypeOfUnit.Contains(tbSearch) ||
                    x.PropertyNumber.Contains(tbSearch) ||
                    x.UnitReleasedTo.Contains(tbSearch)
                    ).OrderByDescending(x => x.ReceivedDate).ToList();
                    dataGridView_InspectionRecord.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[7].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_InspectionRecord.Columns[11].DefaultCellStyle.Format = "MM/dd/yyyy";
                    label1.Text = inspectionInfoBindingSource.Count.ToString() + " items |";
                }

            }

            dataGridView_InspectionRecord.ClearSelection();
        }

        private void dataGridView_InspectionRecord_DoubleClick(object sender, EventArgs e)
        {
            InspectionReportForm inspectionReportForm = new InspectionReportForm();
            inspectionReportForm.dgvr_archivedInspection = dataGridView_InspectionRecord.SelectedRows[0];
            inspectionReportForm.updateInspectionReport = true;

            inspectionReportForm.ShowDialog();

            //InspectionReportForm inspectionReportForm = new InspectionReportForm();
            //inspectionReportForm.ShowDialog();
        }

        private void bt_SearchInspection_Click(object sender, EventArgs e)
        {
            LoadInspection(textBox1.Text);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadInspection(textBox1.Text);
            }
        }
    }
}
