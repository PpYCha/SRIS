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

namespace SRIS.UserControls
{
    public partial class ucArchivedRequest : UserControl
    {
        public ucArchivedRequest()
        {
            InitializeComponent();

            DesignClass.dataGridViewDesign(dataGridView_SRlist);
            //DesignClass.buttonDesign(bt_search);



        }

        private static ucArchivedRequest _instance;

        public static ucArchivedRequest Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucArchivedRequest();
                return _instance;
            }


        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            LoadRequest();


        }

        private void LoadRequest()
        {
            using (SrisContext ctx = new SrisContext())
            {
                if (String.IsNullOrWhiteSpace(tb_search.Text))
                {
                    serviceRequestBindingSource.DataSource = ctx.ServiceRequests.OrderByDescending(x => x.DateRequested).ToList();
                    dataGridView_SRlist.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_SRlist.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
                    label1.Text = serviceRequestBindingSource.Count.ToString() + " items |";
                }
                else
                {
                    serviceRequestBindingSource.DataSource = ctx.ServiceRequests.Where(x => x.TypeOfServiceProvided.Contains(tb_search.Text) ||
                    x.RequestedBy.Contains(tb_search.Text) ||
                    x.FaultDiagnosis.Contains(tb_search.Text) ||
                    x.OfficeDepartmentSr.Contains(tb_search.Text)
                    ).OrderByDescending(x => x.DateRequested).ToList();
                    dataGridView_SRlist.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dataGridView_SRlist.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
                    label1.Text = serviceRequestBindingSource.Count.ToString() + " items |";
                }



            }
            dataGridView_SRlist.ClearSelection();
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadRequest();
            }
        }
    }
}

