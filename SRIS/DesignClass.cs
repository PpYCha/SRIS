using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS
{
    public class DesignClass
    {
        public static void dataGridViewDesign(DataGridView dgv)
        {
            //Testing push


            //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            //dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(238, 238, 238);

            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            //dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(238, 238, 238);
            ////dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 173, 181);
            ////dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(238, 238, 238);

            //dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 119, 119);
            //dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(238, 238, 238);

            //dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(63, 62, 63);
            ////dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 173, 181);
            ////dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(238, 238, 238);

            //dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 119, 119);
            //dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(238, 238, 238);




            //dgv.BackgroundColor = Color.FromArgb(25, 25, 25);




            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ClearSelection();
        }

        public static void buttonDesign(Button bt)
        {
            //bt.BackColor = Color.FromArgb(57, 62, 70);
            //bt.ForeColor = Color.FromArgb(238, 238, 238);
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
            bt.Margin = new Padding(0, 0, 0, 0);
        }

        public static void MenuStripDesign(MenuStrip menuStrip)
        {


        }

        public static void FormDesign(Form form)
        {
            form.BackColor = Color.FromArgb(247, 245, 246);
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.CenterScreen;


        }
    }
}
