using SRIS.Models;
using SRIS.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRIS.UserForms
{
    public partial class RptForm : Form
    {

        public string reportCondition;
        public int ii_Id;

        public RptForm()
        {
            InitializeComponent();
        }

        private void RptForm_Load(object sender, EventArgs e)
        {
            cb_MonthStart.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames.Take(12).ToList();
            cb_MonthStart.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];
            cb_MonthEnd.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames.Take(12).ToList();
            cb_MonthEnd.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];

            cb_Year.DataSource = Enumerable.Range(2019, DateTime.Now.Year - 2019 + 1).ToList();
            cb_Year.SelectedItem = DateTime.Now.Year;

            crystalReportViewer1.ReuseParameterValuesOnRefresh = false;
            crystalReportViewer1.ShowCloseButton = false;
            crystalReportViewer1.ShowCopyButton = false;
            crystalReportViewer1.ShowGroupTreeButton = false;
            crystalReportViewer1.ShowLogo = false;
            crystalReportViewer1.ShowParameterPanelButton = false;
            crystalReportViewer1.ShowRefreshButton = false;

            if (reportCondition == "Print Inspection")
            {
                cb_Find.Visible = false;
                cb_MonthStart.Visible = false;
                cb_MonthEnd.Visible = false;
                cb_Year.Visible = false;
                RptForm.ActiveForm.Text = "Inspection Report";
                LoadInspectionReport();


            }


        }

        private void LoadInspectionReport()
        {
            crystalReportViewer1.Dock = DockStyle.Fill;
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDbTest";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;

            rpt_Inspection report1 = new rpt_Inspection();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("ii_Id", ii_Id);
            report1.SetParameterValue("us_Id", ii_Id);
            report1.SetParameterValue("ii_Id_Procedure", ii_Id);
            report1.SetParameterValue("ii_id_PF", ii_Id);
            report1.SetParameterValue("ii_id_Rec", ii_Id);
            report1.SetParameterValue("ii_id_Inspected", ii_Id);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;

        }

        private void cb_Find_Click(object sender, EventArgs e)
        {
            string monthStart = cb_MonthStart.Text;
            string monthEnd = cb_MonthEnd.Text;

            if (monthStart == monthEnd)
            {
                CrystalReport1();

            }
            if (monthStart == "January" && monthEnd == "December")
            {
                YearlyReport();

            }
            else if ((monthStart != monthEnd))
            {
                FirstHalfReport();
            }

        }

        private void FirstHalfReport()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDbTest";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;

            string monthStart = cb_MonthStart.GetItemText(cb_MonthStart.SelectedItem);
            var monthEnd = cb_MonthStart.GetItemText(cb_MonthEnd.SelectedItem);
            string year = cb_Year.Text;

            int monthNo = DateTime.ParseExact(monthEnd, "MMMM", CultureInfo.CurrentCulture).Month;


            string lastDay = DateTime.DaysInMonth(Convert.ToInt32(year), monthNo).ToString();

            rpt_MonthlyTest report1 = new rpt_MonthlyTest();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("start", DateTime.ParseExact(year + "-" + monthStart + "-01", "yyyy-MMMM-dd", CultureInfo.CurrentCulture).Date);
            report1.SetParameterValue("end", DateTime.ParseExact(year + "-" + monthEnd + "-" + lastDay, "yyyy-MMMM-dd", CultureInfo.CurrentCulture).Date);
            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;

        }

        private void YearlyReport()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDbTest";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;

            var month = cb_MonthStart.GetItemText(cb_MonthStart.SelectedItem);
            var year = cb_Year.GetItemText(cb_Year.SelectedItem);
            string desktopRepairCount = "DESKTOP";
            string laptopRepairCount = "LAPTOP";
            string printerRepairCount = "PRINTER";
            string netWorkConnectivityRepairCount = "NETWORK";
            string othersRepair = string.Empty;

            string totalCount = TotalServiceT(year);

            string drCount = GetCountT(desktopRepairCount, year);
            string lrCount = GetCountT(laptopRepairCount, year);
            string prCount = GetCountT(printerRepairCount, year);
            string nrCOunt = GetCountT(netWorkConnectivityRepairCount, year);
            string orCOunt = GetOthersT(othersRepair, year);

            rpt_Yearly_Technicians report1 = new rpt_Yearly_Technicians();
            report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
            report1.SetParameterValue("ReportLabel", "Service Request Annual Report");
            report1.SetParameterValue("YearLabel", "For the year of " + year);
            report1.SetParameterValue("DesktopRepair", drCount);
            report1.SetParameterValue("LaptopRepair", lrCount);
            report1.SetParameterValue("PrinterRepair", prCount);
            report1.SetParameterValue("NetWorkConnectivityRepairCount", nrCOunt);
            report1.SetParameterValue("OthersRepair", orCOunt);
            report1.SetParameterValue("Total", totalCount);
            // report1.SetParameterValue("param_year", year);

            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ReportSource = report1;
            Cursor.Current = Cursors.Default;


        }

        private string GetOthersT(string othersRepair, string year)
        {
            int y = Convert.ToInt32(year);

            DateTime start, end;



            using (var ctx = new SrisContext())
            {

                var result = ctx.ServiceRequests.Where(x => !(x.TypeOfServiceProvided.Contains("DESKTOP")) &&
                                                            !(x.TypeOfServiceProvided.Contains("LAPTOP")) &&
                                                            !(x.TypeOfServiceProvided.Contains("PRINTER")) &&
                                                            !(x.TypeOfServiceProvided.Contains("NETWORK"))
                                                            && x.DateCompleted.Value.Month != 8 && x.DateCompleted.Value.Year == y).ToList();

                int i = 0;
                foreach (var item in result)
                {
                    i++;
                }

                string number;
                number = i.ToString();

                return number;
            }
        }

        private string GetCountT(string printerRepairCount, string year)
        {
            int y = Convert.ToInt32(year);

            int sss = DateTime.ParseExact(cb_MonthStart.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            using (var ctx = new SrisContext())
            {
                var result = ctx.ServiceRequests.Where(x => x.TypeOfServiceProvided.Contains(printerRepairCount) && x.DateCompleted.Value.Year == y && x.DateCompleted.Value.Month != 8).ToList();

                int i = 0;
                foreach (var item in result)
                {
                    i++;
                }

                string number;
                number = i.ToString();

                return number;
            }
        }

        private string TotalServiceT(string year)
        {
            using (var ctx = new SrisContext())
            {
                int y = Convert.ToInt32(year);
                var result = ctx.ServiceRequests.Where(x => x.Status.Contains("Completed") && x.DateCompleted.Value.Year == y && x.DateCompleted.Value.Month != 8).ToList();


                int i = 0;
                foreach (var item in result)
                {
                    i++;
                }

                string number;
                number = i.ToString();

                return number;
            }
        }

        private void CrystalReport1()
        {
            Cursor.Current = Cursors.WaitCursor;

            string strServer = "Mew";
            string strDatabase = "SrisDbTest";
            string strUserId = "miso_server";
            string strPwd = "miso4321";
            bool useIntegratedSecurity = true;

            var month = cb_MonthStart.GetItemText(cb_MonthStart.SelectedItem);
            var year = cb_Year.Text;
            string desktopRepairCount = "DESKTOP";
            string laptopRepairCount = "LAPTOP";
            string printerRepairCount = "PRINTER";
            string netWorkConnectivityRepairCount = "NETWORK";
            string othersRepair = string.Empty;


            crystalReportViewer1.SelectionFormula = "monthname(month({ServiceRequests.DateCompleted})) Like '*" + month + "*'" + " AND " +
                                                    "Year({ServiceRequests.DateCompleted})= " + year +
                                                    " AND {ServiceRequests.Status} Like '*Completed*'";



            try
            {
                string drCount = GetCount(desktopRepairCount, month, year);
                string lrCount = GetCount(laptopRepairCount, month, year);
                string prCount = GetCount(printerRepairCount, month, year);
                string nrCOunt = GetCount(netWorkConnectivityRepairCount, month, year);
                string orCOunt = GetOthers(othersRepair, month, year);




                rpt_Monthly_Technicians_Summary report1 = new rpt_Monthly_Technicians_Summary();
                report1.DataSourceConnections[0].SetConnection(strServer, strDatabase, useIntegratedSecurity);
                report1.SetParameterValue("MonthLabel", "For the month of " + month + ", " + year);
                report1.SetParameterValue("DesktopRepair", drCount);
                report1.SetParameterValue("LaptopRepair", lrCount);
                report1.SetParameterValue("PrinterRepair", prCount);
                report1.SetParameterValue("NetWorkConnectivityRepairCount", nrCOunt);
                report1.SetParameterValue("OthersRepair", orCOunt);
                // report1.SetParameterValue("param_year", year);

                crystalReportViewer1.ShowPrintButton = true;
                crystalReportViewer1.ShowExportButton = true;
                crystalReportViewer1.ReportSource = report1;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Year");
            }
        }

        private string GetOthers(string othersRepair, string month, string year)
        {
            int y = Convert.ToInt32(year);
            int sss = DateTime.ParseExact(cb_MonthStart.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            using (var ctx = new SrisContext())
            {
                var result = ctx.ServiceRequests.Where(x => !(x.TypeOfServiceProvided.Contains("DESKTOP")) &&
                                                            !(x.TypeOfServiceProvided.Contains("LAPTOP")) &&
                                                            !(x.TypeOfServiceProvided.Contains("PRINTER")) &&
                                                            !(x.TypeOfServiceProvided.Contains("NETWORK"))
                                                            && x.DateCompleted.Value.Month == sss && x.DateCompleted.Value.Year == y).ToList();

                int i = 0;
                foreach (var item in result)
                {
                    i++;
                }

                string number;
                number = i.ToString();

                return number;
            }
        }

        private string GetCount(string desktopRepairCount, string month, string year)
        {

            int y = Convert.ToInt32(year);
            int sss = DateTime.ParseExact(cb_MonthStart.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            using (var ctx = new SrisContext())
            {
                var result = ctx.ServiceRequests.Where(x => x.TypeOfServiceProvided.Contains(desktopRepairCount) && x.DateCompleted.Value.Month == sss && x.DateCompleted.Value.Year == y).ToList();

                int i = 0;
                foreach (var item in result)
                {
                    i++;
                }

                string number;
                number = i.ToString();

                return number;
            }


        }
    }
}
