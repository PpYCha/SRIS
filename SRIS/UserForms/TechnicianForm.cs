using SRIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserForms
{
    public partial class TechnicianForm : Form
    {
        public TechnicianForm()
        {
            InitializeComponent();
        }



        private void TechnicianForm_Load(object sender, EventArgs e)
        {
            DesignClass.dataGridViewDesign(dataGridView_Technician);

            using (SrisContext ctx = new SrisContext())
            {
                technicianBindingSource.DataSource = ctx.Technicians.ToList();
            };
        }

        private void bt_SaveTech_Click(object sender, EventArgs e)
        {
            using (var ctx = new SrisContext())
            {
                foreach (var item in technicianBindingSource.List)
                {
                    var tech = (Technician)item;
                    if (tech.Tech_id <= 0)
                        ctx.Technicians.Add(tech);
                    else
                    {
                        ctx.Technicians.Attach(tech);
                        ctx.Entry(tech).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_Technician.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_Technician.SelectedRows)
                {
                    DeleteUser(row.DataBoundItem);
                    technicianBindingSource.Remove(row.DataBoundItem);
                }
            }
        }

        private void DeleteUser(object dataBoundItem)
        {
            if (dataBoundItem == null)

                return;

            var tech = (Technician)dataBoundItem;

            using (SrisContext ctx = new SrisContext())
            {
                var toBeDeleted = ctx.Technicians.Where(u => u.Tech_id == tech.Tech_id).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.Technicians.Remove(toBeDeleted);
                ctx.SaveChanges();
                MessageBox.Show(this, "Delete Successfull");
            }
        }
    }
}
