using SRIS.Models;
using SRIS.UserControls;
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

namespace SRIS.UserForms
{
    public partial class TechnicianListForm : Form
    {
        public TechnicianListForm()
        {
            InitializeComponent();
            DesignClass.dataGridViewDesign(dataGridView_TechList);
        }

        public string SelectedTech { get; set; }
        public string PopulateTechnician { get; set; }

        private void TechnicianListForm_Load(object sender, EventArgs e)
        {
            using (SrisContext ctx = new SrisContext())
            {
                var techList = from p1 in ctx.Technicians
                               where p1.IsActive == true
                               select new
                               {
                                   p1.Tech_id,
                                   p1.TechName,
                                   p1.TechPosition,

                               };



                dataGridView_TechList.DataSource = techList.ToList();
                dataGridView_TechList.Columns[0].HeaderCell.Value = "id";
                dataGridView_TechList.Columns[0].Visible = false;
                dataGridView_TechList.Columns[1].HeaderCell.Value = "Name";
                dataGridView_TechList.Columns[2].HeaderCell.Value = "Position";

                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "X";
                checkColumn.HeaderText = "Assign";
                checkColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                checkColumn.Width = 50;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 50;
                dataGridView_TechList.Columns.Add(checkColumn);

                try
                {


                    //  string[] checkList = ucServiceRequest.AssignTechId.ToString().Split(',');

                    foreach (var id in ucServiceRequest.AssignTechId)
                    {
                        foreach (DataGridViewRow row in dataGridView_TechList.Rows)
                        {
                            string test = row.Index.ToString();
                            int test2 = Convert.ToInt32(test);
                            if (id == dataGridView_TechList.Rows[test2].Cells[0].Value.ToString())
                            {
                                row.Cells[3].Value = true;
                            }


                        }
                    }
                }
                catch (Exception)
                {


                }
            }
        }

        private void bt_AssignTech_Click(object sender, EventArgs e)
        {
            try
            {
                string tempTechList = string.Empty;
                foreach (DataGridViewRow row in dataGridView_TechList.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["X"].Value);

                    if (isSelected)
                    {
                        SelectedTech += row.Cells["Tech_id"].Value.ToString() + ",";
                        tempTechList += SelectedTech.ToString();
                        PopulateTechnician += row.Cells["TechName"].Value.ToString() + ",";
                    }

                }
                if (String.IsNullOrEmpty(tempTechList))
                {
                    PopulateTechnician = "";
                    SelectedTech = "";

                }
                else
                {
                    PopulateTechnician = PopulateTechnician.Remove(PopulateTechnician.Length - 1);
                    SelectedTech = SelectedTech.Remove(SelectedTech.Length - 1);
                }



            }
            catch (Exception)
            {


            }
            DialogResult = DialogResult.OK;


        }
    }
}
