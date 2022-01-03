using ServiceRequestInformationSystem;
using SRIS.Models;
using SRIS.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserControls
{
    public partial class ucServiceRequest : UserControl
    {
        public ucServiceRequest()
        {
            InitializeComponent();


            try
            {
                LoadAll();
            }
            catch (Exception)
            {


            }

            //   DesignClass.dataGridViewDesign(dataGridView1);

        }

        private void LoadAll()
        {
            //LoadDataToComboa<ServiceRequest>(cb_FaultDiagnosis, "FaultDiagnosis", "FaultDiagnosis", serviceReq => serviceReq.FaultDiagnosis != null && serviceReq.FaultDiagnosis.Trim() != ""); // Return only SR if Fault
            //LoadDataToComboa<ServiceRequest>(cb_RequestedBy, "RequestedBy", "RequestedBy", serviceReq => serviceReq.RequestedBy != null && serviceReq.RequestedBy.Trim() != ""); // Return only SR if Fault
            //LoadDataToComboa<OfficeDeparment>(cb_OfficeDepartment, "Od_id", "OfficeDepartmentName", serviceReq => serviceReq.OfficeDepartmentName != null && serviceReq.OfficeDepartmentName.Trim() != ""); // Return only SR if Fault
            //LoadDataToComboa<ServiceRequest>(cb_Tosp, "TypeOfServiceProvided", "TypeOfServiceProvided", serviceReq => serviceReq.TypeOfServiceProvided != null && serviceReq.TypeOfServiceProvided.Trim() != ""); // Return only SR if Fault

            LoadTypeOfService();
            //  PopulateComboBox("OfficeDeparments", "Od_id", "OfficeDepartmentName", cb_RequestingOffice);
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

        private void LoadTypeOfService()
        {
            using (var ctx = new SrisContext())
            {
                var result = ctx.ServiceRequests.OrderBy(x => x.TypeOfServiceProvided).Select(x => x.TypeOfServiceProvided).Distinct();
                cb_Tosp.DataSource = result.ToList();
                cb_Tosp.DisplayMember = "TypeOfServiceProvided";
                cb_Tosp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_Tosp.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_Tosp.SelectedIndex = -1;

                var result1 = ctx.ServiceRequests.OrderBy(x => x.FaultDiagnosis).Select(x => x.FaultDiagnosis).Distinct();
                cb_FaultDiagnosis.DataSource = result1.ToList();
                cb_FaultDiagnosis.DisplayMember = "FaultDiagnosis";
                cb_FaultDiagnosis.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_FaultDiagnosis.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_FaultDiagnosis.SelectedIndex = -1;

                var result2 = ctx.ServiceRequests.OrderBy(x => x.RequestedBy).Select(x => x.RequestedBy).Distinct();
                cb_RequestedBy.DataSource = result2.ToList();
                cb_RequestedBy.DisplayMember = "RequestedBy";
                cb_RequestedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_RequestedBy.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_RequestedBy.SelectedIndex = -1;

                var result3 = ctx.OfficeDeparments.OrderBy(x => x.OfficeDepartmentName).Select(x => x.OfficeDepartmentName).Distinct();
                cb_OfficeDepartment.DataSource = result3.ToList();
                cb_OfficeDepartment.DisplayMember = "OfficeDepartmentName";
                cb_OfficeDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_OfficeDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_OfficeDepartment.SelectedIndex = -1;
            }
        }

        private void LoadDataToComboa<T>(ComboBox cb, string displayMember, string valueMember, Expression<Func<T, bool>> query) where T : class
        {
            using (var ctx = new SrisContext())
            {
                var model = ctx.Set<T>();
                var aa = model.Where(query);
                cb.DataSource = aa.ToList();
                cb.ValueMember = displayMember;
                cb.DisplayMember = valueMember;
                cb.SelectedIndex = -1;
            }
        }

        public static string[] AssignTechId { get; set; }

        private static ucServiceRequest _instance;

        public static ucServiceRequest Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucServiceRequest();
                return _instance;
            }


        }

        private void bt_AddSeviceToBeProvidedBy_Click(object sender, EventArgs e)
        {

            TechnicianListForm technicianListForm = new TechnicianListForm();
            technicianListForm.ShowDialog();

            try
            {
                cb_ServiceToBeProvidedBy.Text = technicianListForm.PopulateTechnician.ToString();

                AssignTechId = technicianListForm.SelectedTech.ToString().Split(',');

            }
            catch (Exception)
            {


            }
        }

        private void cb_Tosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_RequestedBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_OfficeDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void cb_FaultDiagnosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            custom_Class.ToUpper(e);
        }

        private void checkBox_IfCompleted_Click(object sender, EventArgs e)
        {
            if (checkBox_IfCompleted.Checked)
            {

                dateTimePicker_DateAccomplished.Enabled = true;
                cb_ServiceProvidedBy.Enabled = true;
                bt_ServiceProvidedBy.Enabled = true;
                checkBox_ProceedToIR.Enabled = false;
                checkBox_ProceedToIR.Checked = false;
            }
            else
            {
                dateTimePicker_DateAccomplished.Enabled = false;
                cb_ServiceProvidedBy.Enabled = false;
                bt_ServiceProvidedBy.Enabled = false;
                checkBox_ProceedToIR.Enabled = true;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(cb_ServiceToBeProvidedBy.Text) || string.IsNullOrWhiteSpace(cb_RequestedBy.Text) || string.IsNullOrWhiteSpace(cb_OfficeDepartment.Text) || string.IsNullOrWhiteSpace(cb_FaultDiagnosis.Text)))
            {
                using (SrisContext ctx = new SrisContext())
                {
                    string status;
                    bool work;
                    if (checkBox_IfCompleted.Checked)
                    {
                        status = "Completed";
                        work = true;
                    }
                    else
                    {
                        status = "UnCompleted";
                        work = false;
                    }


                    var serviceRequest = new ServiceRequest
                    {
                        TypeOfServiceProvided = cb_Tosp.Text,
                        TypeOfServiceProvided_Description = cb_TypeOfServiceDescription.Text,
                        RequestedBy = cb_RequestedBy.Text,
                        DateRequested = dateTimePicker_DateRequested.Value,
                        FaultDiagnosis = cb_FaultDiagnosis.Text,
                        DateCompleted = dateTimePicker_DateAccomplished.Value,
                        Status = status,
                        OfficeDepartmentSr = cb_OfficeDepartment.Text,
                        DateEntered = DateTime.Now.ToString()

                    };
                    ctx.ServiceRequests.Add(serviceRequest);
                    ctx.SaveChanges();


                    foreach (string item in AssignTechId)
                    {
                        var technicianService = new TechnicianService
                        {

                            Sr_id = serviceRequest.Sr_id,
                            Tech_id = Convert.ToInt32(item),
                            ProvidedBy = work,

                        };
                        ctx.TechnicianServices.Add(technicianService);
                        ctx.SaveChanges();
                    }


                    LoadSrUncomplete();
                    MessageBox.Show("Save successfully");
                    ClearTextField();

                }

            }
            else
            {
                MessageBox.Show("Please fill up the form completely..");
            }
        }

        private void LoadSrUncomplete()
        {
            using (var ctx = new SrisContext())
            {
                dataGridView_SRInComplete.DataSource = ctx.ServiceRequests.Where(x => x.Status == "UnCompleted").ToList();

            }
        }

        private void ClearTextField()
        {
            LoadAll();
            checkBox_IfCompleted.Checked = false;
            cb_ServiceProvidedBy.Clear();
            cb_ServiceToBeProvidedBy.Clear();
            dateTimePicker_DateRequested.Value = DateTime.Now;
            dateTimePicker_DateAccomplished.Value = DateTime.Now;

        }

        private void checkBox_ProceedToIR_Click(object sender, EventArgs e)
        {
            if (checkBox_ProceedToIR.Checked)
            {
                checkBox_IfCompleted.Enabled = false;
                checkBox_IfCompleted.Checked = false;

            }
            else
            {
                checkBox_IfCompleted.Enabled = true;
                checkBox_IfCompleted.Checked = false;
            }
        }

        private void bt_InspectionReport_Click(object sender, EventArgs e)
        {
            InspectionReportForm inspectionReportForm = new InspectionReportForm();
            inspectionReportForm.ShowDialog();
        }

        private void bt_ServiceProvidedBy_Click(object sender, EventArgs e)
        {
            TechnicianListForm technicianListForm = new TechnicianListForm();
            technicianListForm.ShowDialog();

            try
            {
                cb_ServiceProvidedBy.Text = technicianListForm.PopulateTechnician.ToString();

                AssignTechId = technicianListForm.SelectedTech.ToString().Split(',');

            }
            catch (Exception)
            {


            }
        }

        private void dateTimePicker_DateRequested_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_DateAccomplished.Value = dateTimePicker_DateRequested.Value;
        }

        private void cb_RequestedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SrisContext ctx = new SrisContext())
                {
                    var result = ctx.ServiceRequests.Where(x => x.RequestedBy == cb_RequestedBy.Text).Select(p => p.OfficeDepartmentSr).FirstOrDefault();
                    cb_OfficeDepartment.Text = result.ToString();
                }
            }
            catch (Exception)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSrUncomplete();
        }
    }
}
