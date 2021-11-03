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
    public partial class ucInspectionReport : UserControl
    {
        public ucInspectionReport()
        {
            InitializeComponent();
        }

        private static ucInspectionReport _instance;

        public static ucInspectionReport Intance
        {
            get
            {
                if (_instance == null)

                    _instance = new ucInspectionReport();
                return _instance;
            }


        }
    }
}
