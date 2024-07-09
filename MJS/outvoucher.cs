using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace MJS
{
    public partial class outvoucher : Form
    {
        public outvoucher()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            string connection_string = "Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215";
            string query = "SELECT Image, Date, Time, OutVoucher_No, Out_Remark, PurVoucher, ProductID, GoldType, GoldPrice, Item, ItemName, Gm, K, P, Y, S, WK, WP, WY, WS, TK, TP, TY, TS, Mcost, Repamt, Totalamt, Remark, Employee, Shop, Form, Counter FROM other_out";

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            ReportDataSource reportDataSource = new ReportDataSource("otheroutvoucher", dataTable);

            // Configure ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "MJS.otherout.rdlc";

            // Refresh the ReportViewer
            reportViewer1.RefreshReport();

            /*this.other_outTableAdapter.Fill(this.otherout.other_out);
            this.reportViewer1.RefreshReport();*/
        }
    }
}
