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
using System.Windows;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.IO;

namespace MJS
{
    public partial class preview : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");


        public preview()
        {
            InitializeComponent();  
        }

        public string stdname { get; set; }
        private void preview_Load(object sender, EventArgs e)
        {
            txt_shop_preview.Text = login.shopvalue;
            txt_form_perview.Text = stdname;
            txt_searchbox.Text = "Search ProductID";
            txt_searchbox.ForeColor = Color.LightGray;         
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(txt_form_perview.Text == "Gold Other Out") 
            {
                goldotherout_datefilter();
            }else if(txt_form_perview.Text == "Gold Register")
            {
                goldregister_datefilter();
            }
           
        }

        public void goldotherout_datefilter()
        {
            string shopvalue = txt_shop_preview.Text;
            con.Open();
            string sql = "SELECT * FROM other_out Where Shop=@shop AND Date BETWEEN @date1 and @date2";
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
            adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
            adp.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void goldregister_datefilter()
        {
            string shopvalue = txt_shop_preview.Text;
            con.Open();
            string sql = "SELECT * FROM reg_gold Where Shop=@shop AND Date BETWEEN @date1 and @date2";
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
            adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
            adp.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_searchbox_TextChanged(object sender, EventArgs e)
        {
            if (txt_form_perview.Text == "Gold Other Out")
            {
                goldotherout_search();
            }
            else if (txt_form_perview.Text == "Gold Register")
            {
                goldregister_search();
            }
        }

        public void goldregister_search()
        {
            con.Open();
            string sql = "SELECT * FROM reg_gold Where ProductID='" + txt_searchbox.Text.ToString() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            /*            if (dataGridView1.Rows.Count <1)
                        {wh
                            MessageBox.Show("Product မရှိပါ");
                        }*/
            con.Close();
        }

        public void goldotherout_search()
        {
            con.Open();
            string sql = "SELECT * FROM other_out Where ProductID='" + txt_searchbox.Text.ToString() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            /*            if (dataGridView1.Rows.Count <1)
                        {wh
                            MessageBox.Show("Product မရှိပါ");
                        }*/
            con.Close();
        }


        private void export_excel_Click(object sender, EventArgs e)
        {

            ExportToExcel(dataGridView1);
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Excel File";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                            // Write column headers to Excel
                            for (int i = 2; i <= dataGridView.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                            }

                            // Write data to Excel
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 1; j < dataGridView.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            // Save the Excel file
                            FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(excelFile);
                            System.Windows.MessageBox.Show("Excel file saved successfully!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void txt_searchbox_Enter(object sender, EventArgs e)
        {
            if(txt_searchbox.Text=="Search ProductID")
            {
                txt_searchbox.Text = "";
                txt_searchbox.ForeColor = Color.Black;
            }
        }

        private void txt_searchbox_Leave(object sender, EventArgs e)
        {
            if (txt_searchbox.Text == "")
            {
                txt_searchbox.Text = "Search ProductID";
                txt_searchbox.ForeColor = Color.LightGray;
            }
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            if (txt_form_perview.Text == "Gold Other Out")
            {
                goldotherout_datefilter();
            }
            else if (txt_form_perview.Text == "Gold Register")
            {
                goldregister_datefilter();
            }
        }
    }
}
