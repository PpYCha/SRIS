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
    public partial class OfficeDepartment : Form
    {
        public OfficeDepartment()
        {
            InitializeComponent();
        }

        private void bt_OfficeDepartment_Click(object sender, EventArgs e)
        {
            using (var ctx = new SrisContext())
            {
                foreach (var item in officeDeparmentBindingSource.List)
                {
                    var od = (OfficeDeparment)item;
                    if (od.Od_id <= 0)
                        ctx.OfficeDeparments.Add(od);
                    else
                    {
                        ctx.OfficeDeparments.Attach(od);
                        ctx.Entry(od).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();
                ShowList();
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_OfficeDepartment.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_OfficeDepartment.SelectedRows)
                {
                    DeleteUser(row.DataBoundItem);
                    officeDeparmentBindingSource.Remove(row.DataBoundItem);
                }
                ShowList();
            }
        }

        private void DeleteUser(object dataBoundItem)
        {
            if (dataBoundItem == null)

                return;

            var od = (OfficeDeparment)dataBoundItem;

            using (SrisContext ctx = new SrisContext())
            {
                var toBeDeleted = ctx.OfficeDeparments.Where(u => u.Od_id == od.Od_id).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.OfficeDeparments.Remove(toBeDeleted);
                ctx.SaveChanges();
                ShowList();
                MessageBox.Show(this, "Delete Successfull");
            }


        }

        private void OfficeDepartment_Load(object sender, EventArgs e)
        {
            DesignClass.dataGridViewDesign(dataGridView_OfficeDepartment);

            ShowList();
        }

        private void ShowList()
        {
            using (SrisContext ctx = new SrisContext())
            {
                officeDeparmentBindingSource.DataSource = ctx.OfficeDeparments.ToList();
            };
        }
    }
}
