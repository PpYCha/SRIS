using ServiceRequestInformationSystem;
using SRIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserForms
{
    public partial class ItemReplacementForm : Form
    {
        public string[] AssignTechId { get; private set; }
        public string[] ItemList { get; set; }

        public ItemReplacementForm()
        {
            InitializeComponent();
        }

        private void ItemReplacementForm_Load(object sender, EventArgs e)
        {
            DesignClass.buttonDesign(bt_Save);
            DesignClass.buttonDesign(bt_Print);
            PopulateComboBox("OfficeDeparments", "Od_id", "OfficeDepartmentName", cb_RequestingOffice);
            PopulateComboBox("InspectionInfoes", "Ii_id", "PropertyNumber", cb_PropertyNo);
            PopulateComboBox("InspectionInfoes", "Ii_id", "TypeOfUnit", cb_TypeOfUnit);
            PopulateComboBox("ServiceRequests", "Sr_id", "RequestedBy", cb_RequestedBy);
            PopulateComboBox("InspectionInfoes", "Ii_id", "UnitReleasedTo", cb_UnitReleasedTo);
            PopulateComboBox("InspectionInfoes", "Ii_id", "PositionUnitReleasedTo", cb_UnitReleasedTo_Position);

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

        private void bt_Save_Click(object sender, EventArgs e)
        {

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

        private void cb_RequestedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SrisContext ctx = new SrisContext())
                {
                    var result = ctx.ServiceRequests.Where(x => x.RequestedBy == cb_RequestedBy.Text).Select(p => p.OfficeDepartmentSr).FirstOrDefault();
                    cb_RequestingOffice.Text = result.ToString();
                }
            }
            catch (Exception)
            {


            }
        }

        private void bt_itemReplacement_Click(object sender, EventArgs e)
        {
            ItemListForm itemListForm = new ItemListForm();
            itemListForm.ShowDialog();

            try
            {
                cb_ItemList.Text = itemListForm.PopulateItemList.ToString();

                //ItemList = itemListForm.SelectedTech.ToString().Split(',');

            }
            catch (Exception)
            {


            }
        }
    }
}
