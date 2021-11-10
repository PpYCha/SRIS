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
    public partial class ItemListForm : Form
    {
        public string PopulateItemList { get; internal set; }

        public ItemListForm()
        {
            InitializeComponent();
        }



        private void ItemListForm_Load(object sender, EventArgs e)
        {
            DesignClass.dataGridViewDesign(dataGridView_ItemList);


        }

        private void bt_SaveTech_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView_ItemList.Rows)
                {


                    PopulateItemList += item.Cells["ItemName"].Value.ToString() + ",";
                    MessageBox.Show("", PopulateItemList);
                }



            }
            catch (Exception)
            {


            }
            DialogResult = DialogResult.OK;

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_ItemList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_ItemList.SelectedRows)
                {
                    DeleteUser(row.DataBoundItem);
                    itemBindingSource.Remove(row.DataBoundItem);
                }
            }
        }

        private void DeleteUser(object dataBoundItem)
        {
            //if (dataBoundItem == null)

            //    return;

            //var item = (Item)dataBoundItem;

            //using (SrisContext ctx = new SrisContext())
            //{
            //    var toBeDeleted = ctx.Items.Where(u => u == tech.Tech_id).FirstOrDefault();
            //    if (toBeDeleted == null)
            //        return;

            //    ctx.Technicians.Remove(toBeDeleted);
            //    ctx.SaveChanges();
            //    MessageBox.Show(this, "Delete Successfull");
            //}
        }


    }
}
