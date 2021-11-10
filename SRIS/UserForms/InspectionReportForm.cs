using SRIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.EntityClient;
using ServiceRequestInformationSystem;
using System.Data.SqlClient;

namespace SRIS.UserForms
{
    public partial class InspectionReportForm : Form
    {
        public DataGridViewRow dgvr_archivedInspection;
        public bool updateInspectionReport;
        public InspectionReportForm()
        {
            InitializeComponent();



            //  LoadDataToDataGridView<ServiceRequest>(dataGridView_UnitSpecs, "TypeOfServiceProvided", "TypeOfServiceProvided", serviceReq => serviceReq.TypeOfServiceProvided != null && serviceReq.TypeOfServiceProvided.Trim() != ""); // Return only SR if Fault

            LoadDesign();

            LoadDataToComboa<ServiceRequest>(cb_Finding, "FaultDiagnosis", "FaultDiagnosis", serviceReq => serviceReq.FaultDiagnosis != null && serviceReq.FaultDiagnosis.Trim() != ""); // Return only SR if Fault

            PopulateComboBox("OfficeDeparments", "Od_id", "OfficeDepartmentName", cb_RequestingOffice);
            PopulateComboBox("ServiceRequests", "Sr_id", "RequestedBy", cb_RequestedBy);


            PopulateComboBox("InspectionInfoes", "Ii_id", "UnitReleasedTo", cb_UnitReleasedTo);
            PopulateComboBox("InspectionInfoes", "Ii_id", "PositionUnitReleasedTo", cb_UnitReleasedTo_Position);

            PopulateComboBox("InspectionInfoes", "Ii_id", "ComplaintOnUnit", cb_ComplaintOnUnit);
            PopulateComboBox("InspectionInfoes", "Ii_id", "TypeOfUnit", cb_TypeOfUnit);
            PopulateComboBox("InspectionInfoes", "Ii_id", "PropertyNumber", cb_PropertyNo);

            PopulateComboBox("UnitSpecifications", "Us_id", "ComponentName", cb_Component);
            PopulateComboBox("UnitSpecifications", "Us_id", "ComponentSpec", cb_ComponentDetail);

            PopulateComboBox("ProcedureTests", "Pt_id", "PrecedureDetails", cb_ProcedureTest);

            PopulateComboBox("FindingParticulars", "Fp_id", "Particular", cb_Particular);
            PopulateComboBox("FindingParticulars", "Fp_id", "Condition", cb_Finding);

            PopulateComboBox("Recommendations", "R_id", "RecommendationDetail", cb_Recommendation);



            using (SrisContext ctx = new SrisContext())
            {
                var spNameList = ctx.Technicians.Where(x => x.IsActive == true).ToList();
                cb_InspectedBy.DataSource = spNameList;
                cb_InspectedBy.DisplayMember = "TechName";
                cb_InspectedBy.ValueMember = "Tech_id";
                cb_InspectedBy.SelectedIndex = -1;
                cb_InspectedBy.SelectionLength = 0;


            }

            using (SrisContext ctx = new SrisContext())
            {
                var spNameList = ctx.Technicians.Where(x => x.IsActive == true).ToList();
                cb_ReceivedBy.DataSource = spNameList;
                cb_ReceivedBy.DisplayMember = "TechName";
                cb_ReceivedBy.ValueMember = "Tech_id";
                cb_ReceivedBy.SelectedIndex = -1;
                cb_ReceivedBy.SelectionLength = 0;
            }
        }

        public void PopulateComboBox(string tableName, string valueName, string displayName, ComboBox cb_Name)
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT DISTINCT " + displayName + " FROM " + tableName + " ORDER BY " + displayName, SQLCon.sqlConnection);
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_Name.DataSource = SQLCon.dataTable;
            //   cb_Name.ValueMember = valueName;
            cb_Name.DisplayMember = displayName;
            cb_Name.AutoCompleteMode = AutoCompleteMode.Append;
            cb_Name.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Name.SelectedIndex = -1;
        }

        private void LoadDataToComboa<T>(ComboBox cb, string displayMember, string valueMember, Expression<Func<T, bool>> query) where T : class
        {
            using (var ctx = new SrisContext())
            {
                var model = ctx.Set<T>();

                // var aa = (from c in ctx.ServiceRequests select new { c.FaultDiagnosis }).Distinct().ToList();
                var aa = model.Where(query);
                cb.DataSource = aa.ToList();
                cb.ValueMember = displayMember;
                cb.DisplayMember = valueMember;

                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb.SelectedIndex = -1;
            }
        }

        public static int selectedId;





        private void LoadDesign()
        {
            DesignClass.dataGridViewDesign(dataGridView_FindingParticular);
            DesignClass.dataGridViewDesign(dataGridView_Inspected);
            DesignClass.dataGridViewDesign(dataGridView_ProcedureTest);
            DesignClass.dataGridViewDesign(dataGridView_Recommendation);
            DesignClass.dataGridViewDesign(dataGridView_UnitSpecs);


            //DesignClass.buttonDesign(bt_RemovePF);
            //DesignClass.buttonDesign(bt_RemovePI);
            //DesignClass.buttonDesign(bt_RemovePT);
            //DesignClass.buttonDesign(bt_RemoveR);
            //DesignClass.buttonDesign(bt_RemovePF);
            //DesignClass.buttonDesign(bt_RemoveUS);
            //DesignClass.buttonDesign(bt_SaveParticularFinding);
            //DesignClass.buttonDesign(bt_SaveProcedure);
            //DesignClass.buttonDesign(bt_SaveRecommendation);
            //DesignClass.buttonDesign(bt_SavePI);
            //DesignClass.buttonDesign(bt_UnitSpecification);
            //DesignClass.buttonDesign(bt_SaveInspectionReport);
            //DesignClass.buttonDesign(bt_Print);
        }

        private void bt_UnitSpecification_Click(object sender, EventArgs e)
        {
            AddDatagridviewRow(cb_Component, cb_ComponentDetail, dataGridView_UnitSpecs);
        }

        private void bt_SaveProcedure_Click(object sender, EventArgs e)
        {
            AddDatagridviewRow(cb_ProcedureTest, null, dataGridView_ProcedureTest);

        }
        private void bt_SaveParticularFinding_Click(object sender, EventArgs e)
        {
            AddDatagridviewRow(cb_Particular, cb_Finding, dataGridView_FindingParticular);
        }

        private void bt_SaveRecommendation_Click(object sender, EventArgs e)
        {
            AddDatagridviewRow(cb_Recommendation, null, dataGridView_Recommendation);
        }

        private void bt_SavePI_Click(object sender, EventArgs e)
        {
            AddDatagridviewRow(cb_InspectedBy, cb_InspectedPosition, dataGridView_Inspected);
        }

        private void AddDatagridviewRow(ComboBox cb1, ComboBox cb2, DataGridView dgv)
        {


            if (!(cb2 == null))
            {


                dgv.Rows.Add(cb1.Text, cb2.Text);
                cb1.Text = "";
                cb2.Text = "";

            }
            else
            {
                dgv.Rows.Add(cb1.Text);
                cb1.Text = "";
            }

            dgv.ClearSelection();
        }


        private void bt_RemoveR_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(cb_Recommendation, null, dataGridView_Recommendation);

        }

        private void bt_RemovePI_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(cb_InspectedBy, cb_InspectedPosition, dataGridView_Inspected);
        }

        private void bt_RemoveUS_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(cb_Component, cb_ComponentDetail, dataGridView_UnitSpecs);
        }

        private void bt_RemovePT_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(cb_ProcedureTest, null, dataGridView_ProcedureTest);
        }

        private void bt_RemovePF_Click(object sender, EventArgs e)
        {
            RemoveDatagridviewRow(cb_Particular, cb_Finding, dataGridView_FindingParticular);
        }


        private void RemoveDatagridviewRow(ComboBox cb1, ComboBox cb2, DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                if (!(cb2 == null))
                {
                    cb2.SelectedIndex = -1;
                }
                cb1.SelectedIndex = -1;
                dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);

                dgv.ClearSelection();
            }



        }

        private void bt_SaveInspectionReport_Click(object sender, EventArgs e)
        {
            SaveInspectionReport();
            MessageBox.Show("Save succesfully");
            Close();
        }

        private void SaveInspectionReport()
        {
            if (updateInspectionReport == true)
            {

                updateRecord();
            }
            if (updateInspectionReport == false)
            {

                saveRecord();
            }

        }

        private void saveRecord()
        {
            using (SrisContext ctx = new SrisContext())
            {
                var InspectionInfoes = new InspectionInfo
                {
                    RequestingOffice = cb_RequestingOffice.Text,
                    RequestedBy = cb_RequestedBy.Text,
                    ReceivedBy = cb_ReceivedBy.Text,
                    ReceivedPosition = cb_Position.Text,
                    ReceivedDate = dateTimePicker_Received.Value.Date,
                    UnitReleasedTo = cb_UnitReleasedTo.Text,
                    PositionUnitReleasedTo = cb_UnitReleasedTo_Position.Text,
                    DateReleased = null,
                    TypeOfUnit = cb_TypeOfUnit.Text,
                    ComplaintOnUnit = cb_ComplaintOnUnit.Text,
                    PropertyNumber = cb_PropertyNo.Text,

                };

                ctx.InspectionInfos.Add(InspectionInfoes);
                ctx.SaveChanges();



                var unitSpec = new UnitSpecification();
                foreach (DataGridViewRow item in dataGridView_UnitSpecs.Rows)
                {
                    unitSpec.ComponentName = item.Cells["Column_Components"].Value.ToString();
                    unitSpec.ComponentSpec = item.Cells["Column_Description"].Value.ToString();

                    unitSpec.II_ID = InspectionInfoes.Ii_id;

                    ctx.UnitSpecifications.Add(unitSpec);
                    ctx.SaveChanges();
                }

                var pt = new ProcedureTest();
                foreach (DataGridViewRow item in dataGridView_ProcedureTest.Rows)
                {
                    pt.PrecedureDetails = item.Cells["Column_Procedure"].Value.ToString();

                    pt.II_ID = InspectionInfoes.Ii_id;

                    ctx.ProcedureTests.Add(pt);
                    ctx.SaveChanges();
                }

                var particularFinding = new FindingParticular();
                foreach (DataGridViewRow item in dataGridView_FindingParticular.Rows)
                {
                    particularFinding.Particular = item.Cells["Column_Particular"].Value.ToString();
                    particularFinding.Condition = item.Cells["Column_Findings"].Value.ToString();

                    particularFinding.II_ID = InspectionInfoes.Ii_id;

                    ctx.FindingParticulars.Add(particularFinding);
                    ctx.SaveChanges();
                }

                var recommend = new Recommendation();
                foreach (DataGridViewRow item in dataGridView_Recommendation.Rows)
                {
                    recommend.RecommendationDetail = item.Cells["Column_Recommendations"].Value.ToString();

                    recommend.II_ID = InspectionInfoes.Ii_id;

                    ctx.Recommendations.Add(recommend);
                    ctx.SaveChanges();
                }

                var inspectedBy = new Inspected();
                foreach (DataGridViewRow item in dataGridView_Inspected.Rows)
                {
                    inspectedBy.InspectedName = item.Cells["Column_Name"].Value.ToString();
                    inspectedBy.InspectedPosition = item.Cells["Column_Position"].Value.ToString();

                    inspectedBy.II_ID = InspectionInfoes.Ii_id;

                    ctx.Inspecteds.Add(inspectedBy);
                    ctx.SaveChanges();
                }


            }
        }

        private void updateRecord()
        {
            using (SrisContext ctx = new SrisContext())
            {
                int select_id = Convert.ToInt32(dgvr_archivedInspection.Cells[0].Value.ToString());

                DateTime? dateReleased = null;

                if (checkBox1.Checked == true)
                {
                    dateReleased = dateTimePicker_UnitReleasedTo.Value.Date;
                }
                if (checkBox1.Checked == false)
                {
                    dateReleased = null;
                }

                var InspectionInfoes = new InspectionInfo
                {
                    Ii_id = select_id,
                    RequestingOffice = cb_RequestingOffice.Text,
                    RequestedBy = cb_RequestedBy.Text,
                    ReceivedBy = cb_ReceivedBy.Text,
                    ReceivedPosition = cb_Position.Text,
                    ReceivedDate = dateTimePicker_Received.Value.Date,
                    UnitReleasedTo = cb_UnitReleasedTo.Text,
                    PositionUnitReleasedTo = cb_UnitReleasedTo_Position.Text,
                    DateReleased = dateReleased,
                    TypeOfUnit = cb_TypeOfUnit.Text,
                    ComplaintOnUnit = cb_ComplaintOnUnit.Text,
                    PropertyNumber = cb_PropertyNo.Text,

                };

                ctx.InspectionInfos.Attach(InspectionInfoes);
                ctx.Entry(InspectionInfoes).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                ctx.UnitSpecifications.RemoveRange(ctx.UnitSpecifications.Where(x => x.II_ID == select_id));
                ctx.SaveChanges();
                var unitSpec = new UnitSpecification();
                foreach (DataGridViewRow item in dataGridView_UnitSpecs.Rows)
                {
                    unitSpec.ComponentName = item.Cells["Column_Components"].Value.ToString();
                    unitSpec.ComponentSpec = item.Cells["Column_Description"].Value.ToString();

                    unitSpec.II_ID = InspectionInfoes.Ii_id;

                    ctx.UnitSpecifications.Add(unitSpec);
                    ctx.SaveChanges();
                }

                ctx.ProcedureTests.RemoveRange(ctx.ProcedureTests.Where(x => x.II_ID == select_id));
                ctx.SaveChanges();
                var pt = new ProcedureTest();
                foreach (DataGridViewRow item in dataGridView_ProcedureTest.Rows)
                {
                    pt.PrecedureDetails = item.Cells["Column_Procedure"].Value.ToString();

                    pt.II_ID = InspectionInfoes.Ii_id;

                    ctx.ProcedureTests.Add(pt);
                    ctx.SaveChanges();
                }

                ctx.FindingParticulars.RemoveRange(ctx.FindingParticulars.Where(x => x.II_ID == select_id));
                ctx.SaveChanges();
                var particularFinding = new FindingParticular();
                foreach (DataGridViewRow item in dataGridView_FindingParticular.Rows)
                {
                    particularFinding.Particular = item.Cells["Column_Particular"].Value.ToString();
                    particularFinding.Condition = item.Cells["Column_Findings"].Value.ToString();

                    particularFinding.II_ID = InspectionInfoes.Ii_id;

                    ctx.FindingParticulars.Add(particularFinding);
                    ctx.SaveChanges();
                }

                ctx.Recommendations.RemoveRange(ctx.Recommendations.Where(x => x.II_ID == select_id));
                ctx.SaveChanges();
                var recommend = new Recommendation();
                foreach (DataGridViewRow item in dataGridView_Recommendation.Rows)
                {
                    recommend.RecommendationDetail = item.Cells["Column_Recommendations"].Value.ToString();

                    recommend.II_ID = InspectionInfoes.Ii_id;

                    ctx.Recommendations.Add(recommend);
                    ctx.SaveChanges();
                }

                ctx.Inspecteds.RemoveRange(ctx.Inspecteds.Where(x => x.II_ID == select_id));
                ctx.SaveChanges();
                var inspectedBy = new Inspected();
                foreach (DataGridViewRow item in dataGridView_Inspected.Rows)
                {
                    inspectedBy.InspectedName = item.Cells["Column_Name"].Value.ToString();
                    inspectedBy.InspectedPosition = item.Cells["Column_Position"].Value.ToString();

                    inspectedBy.II_ID = InspectionInfoes.Ii_id;

                    ctx.Inspecteds.Add(inspectedBy);
                    ctx.SaveChanges();
                }
            }
        }

        private void cb_ReceivedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SrisContext ctx = new SrisContext())
                {


                    var pos = ctx.Technicians.Where(x => x.TechName == cb_ReceivedBy.Text).Select(p => p.TechPosition);

                    cb_Position.Text = pos.FirstOrDefault();
                }
            }
            catch (Exception)
            {


            }
        }

        private void UpdateInspectionReport()
        {
            MessageBox.Show("", dgvr_archivedInspection.ToString());
        }

        private void InspectionReportForm_Load(object sender, EventArgs e)
        {



            if (updateInspectionReport == true)
            {
                bt_Print.Visible = true;

                int temp_ii_id = Convert.ToInt32(dgvr_archivedInspection.Cells[0].Value.ToString());
                cb_RequestingOffice.Text = dgvr_archivedInspection.Cells[1].Value.ToString();
                cb_RequestedBy.Text = dgvr_archivedInspection.Cells[2].Value.ToString();
                cb_ReceivedBy.Text = dgvr_archivedInspection.Cells[3].Value.ToString();
                dateTimePicker_Received.Value = Convert.ToDateTime(dgvr_archivedInspection.Cells[4].Value.ToString());

                cb_Position.Text = dgvr_archivedInspection.Cells[5].Value.ToString();
                cb_TypeOfUnit.Text = dgvr_archivedInspection.Cells[6].Value.ToString();
                cb_ComplaintOnUnit.Text = dgvr_archivedInspection.Cells[7].Value.ToString();
                cb_PropertyNo.Text = dgvr_archivedInspection.Cells[8].Value.ToString();
                cb_UnitReleasedTo.Text = dgvr_archivedInspection.Cells[9].Value.ToString();
                cb_UnitReleasedTo_Position.Text = dgvr_archivedInspection.Cells[10].Value.ToString();
                try
                {
                    dateTimePicker_UnitReleasedTo.Value = Convert.ToDateTime(dgvr_archivedInspection.Cells[11].Value.ToString());

                }
                catch (Exception)
                {


                }
                using (SrisContext ctx = new SrisContext())
                {


                    var queryUnitSpec = from p1 in ctx.UnitSpecifications
                                        where p1.II_ID == temp_ii_id
                                        select new { p1.ComponentName, p1.ComponentSpec };

                    foreach (var item in queryUnitSpec)
                    {
                        dataGridView_UnitSpecs.Rows.Add(item.ComponentName, item.ComponentSpec);
                    }

                    var queryProcedureTest = from p1 in ctx.ProcedureTests
                                             where p1.II_ID == temp_ii_id
                                             select new { p1.PrecedureDetails };
                    foreach (var item in queryProcedureTest)
                    {
                        dataGridView_ProcedureTest.Rows.Add(item.PrecedureDetails);
                    }

                    var queryParticularFinding = from p1 in ctx.FindingParticulars
                                                 where p1.II_ID == temp_ii_id
                                                 select new { p1.Particular, p1.Condition };
                    foreach (var item in queryParticularFinding)
                    {
                        dataGridView_FindingParticular.Rows.Add(item.Particular, item.Condition);
                    }

                    var queryRecommendation = from p1 in ctx.Recommendations
                                              where p1.II_ID == temp_ii_id
                                              select new { p1.RecommendationDetail };
                    foreach (var item in queryRecommendation)
                    {
                        dataGridView_Recommendation.Rows.Add(item.RecommendationDetail);
                    }

                    var queryTech = from p1 in ctx.Inspecteds
                                    where p1.II_ID == temp_ii_id
                                    select new { p1.InspectedName, p1.InspectedPosition };
                    foreach (var item in queryTech)
                    {
                        dataGridView_Inspected.Rows.Add(item.InspectedName, item.InspectedPosition);
                    }


                }
            }



        }

        private void cb_InspectedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SrisContext ctx = new SrisContext())
                {


                    var pos = ctx.Technicians.Where(x => x.TechName == cb_InspectedBy.Text).Select(p => p.TechPosition);

                    cb_InspectedPosition.Text = pos.FirstOrDefault();
                }
            }
            catch (Exception)
            {


            }
        }

        private void cb_RequestingOffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_RequestedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ReceivedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Position_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_UnitReleasedTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_UnitReleasedTo_Position_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_TypeOfUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ComplaintOnUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_PropertyNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Component_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ComponentDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_ProcedureTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Particular_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Finding_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_Recommendation_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_InspectedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_InspectedPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            int temp_ii_id = Convert.ToInt32(dgvr_archivedInspection.Cells[0].Value.ToString());
            RptForm rptForm = new RptForm();
            rptForm.reportCondition = "Print Inspection";
            rptForm.ii_Id = temp_ii_id;
            rptForm.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cb_UnitReleasedTo.Enabled = true;
                cb_UnitReleasedTo_Position.Enabled = true;
                dateTimePicker_UnitReleasedTo.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                cb_UnitReleasedTo.Enabled = false;
                cb_UnitReleasedTo_Position.Enabled = false;
                dateTimePicker_UnitReleasedTo.Enabled = false;
            }
        }
    }
}
