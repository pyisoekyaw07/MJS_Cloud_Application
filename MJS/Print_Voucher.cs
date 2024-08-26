using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJS
{
    public partial class Print_Voucher : Form
    {
        public Print_Voucher()
        {
            InitializeComponent();
        }
        public void ShowReport(ReportDocument reportDocument)
        {
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }
    }
}
