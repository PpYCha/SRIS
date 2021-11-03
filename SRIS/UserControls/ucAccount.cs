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
    public partial class ucAccount : UserControl
    {
        public ucAccount()
        {
            InitializeComponent();
            ShowAccountList();
            DesignClass.dataGridViewDesign(dataGridView_AccountList);
        }

        private static ucAccount _instance;

        public static ucAccount Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucAccount();
                return _instance;
            }


        }

        private void bt_AddUser_Click(object sender, EventArgs e)
        {
            using (var ctx = new SrisContext())
            {
                //var acc = new Account()
                //{
                //    Username = tb_Username.Text,
                //    FirstName = tb_FirstName.Text,
                //    MiddleName = tb_MiddleName.Text,
                //    LastName = tb_LastName.Text,
                //    IsActive = true,
                //    Password = tb_Password.Text,
                //    AccessLevel = cb_AccessLevel.Text
                //};
                //ctx.Accounts.Add(acc);
                //ctx.SaveChanges();

                foreach (var item in accountBindingSource.List)
                {
                    var acc = (Account)item;
                    if (acc.User_id <= 0)
                        ctx.Accounts.Add(acc);
                    else
                    {
                        ctx.Accounts.Attach(acc);
                        ctx.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();

            };

            ShowAccountList();

            dataGridView_AccountList.ClearSelection();
        }

        private void ShowAccountList()
        {
            using (var ctx = new SrisContext())
            {
                accountBindingSource.DataSource = ctx.Accounts.ToList();

            }

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_AccountList.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_AccountList.SelectedRows)
                {
                    DeleteUser(row.DataBoundItem);
                    accountBindingSource.Remove(row.DataBoundItem);
                }
            }
        }

        private void DeleteUser(object dataBoundItem)
        {
            if (dataBoundItem == null)

                return;

            var account = (Account)dataBoundItem;

            using (SrisContext ctx = new SrisContext())
            {
                var toBeDeleted = ctx.Accounts.Where(u => u.User_id == account.User_id).FirstOrDefault();
                if (toBeDeleted == null)
                    return;

                ctx.Accounts.Remove(toBeDeleted);
                ctx.SaveChanges();
                MessageBox.Show(this, "Delete Successfull");
            }
        }

        private void dataGridView_AccountList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
