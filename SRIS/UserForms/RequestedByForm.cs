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
    public partial class RequestedByForm : Form
    {
        public RequestedByForm()
        {
            InitializeComponent();

            LoadDesign();

        }

        private void LoadDesign()
        {
            DesignClass.dataGridViewDesign(dataGridView_Names);
            DesignClass.buttonDesign(bt_Save);
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            using (var ctx = new SrisContext())
            {
                foreach (var item in serviceRequestBindingSource.List)
                {
                    var od = (ServiceRequest)item;
                    if (od.Sr_id <= 0)
                        ctx.ServiceRequests.Add(od);
                    else
                    {
                        ctx.ServiceRequests.Attach(od);
                        ctx.Entry(od).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();
                ShowName();
            }
        }

        private void ShowName()
        {
            using (SrisContext ctx = new SrisContext())
            {
                serviceRequestBindingSource.DataSource = ctx.ServiceRequests.OrderBy(x => x.RequestedBy).ToList();
            };
        }

        private void RequestedByForm_Load(object sender, EventArgs e)
        {
            ShowName();
        }
    }
}
