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
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MJS
{
    public partial class preview : Form
    {
       
        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");


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

            if(txt_form_perview.Text=="Gold Sale") 
            {
                Choose_Box.Visible= true;
            }

            Choose_Box.ItemCheck += Choose_Box_ItemCheck;
        }

        private void Choose_Box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Check if the current item is about to be checked
            if (e.NewValue == CheckState.Checked)
            {
                // Get the index of the item that is about to be checked
                int checkedIndex = e.Index;

                // Loop through all items in the CheckedListBox
                for (int i = 0; i < Choose_Box.Items.Count; i++)
                {
                    // Skip the currently checked item
                    if (i == checkedIndex)
                        continue;

                    // Uncheck all other items
                    Choose_Box.SetItemChecked(i, false);
                }
            }
        }

        public void goldotherout_datefilter()
        {
            con.Close();
            try 
            {
                DateTime todayDate = DateTime.Today;
                string shopvalue = txt_shop_preview.Text;
                con.Open();
                string sql = "SELECT * FROM other_out Where Shop=@shop AND (Date BETWEEN @date1 and @date2)OR Date=@Today";
                System.Data.DataTable dt = new System.Data.DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
                adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
                adp.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
                adp.SelectCommand.Parameters.AddWithValue("@Today", todayDate);
                adp.Fill(dt);
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
                dataGridView1.DataSource = dt;
                con.Close();
            } 
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            
        }
        public void goldregister_datefilter()
        {
            con.Close();
            try {
                DateTime todayDate = DateTime.Today;
                string shopvalue = txt_shop_preview.Text;
                con.Open();
                string sql = "SELECT * FROM reg_gold Where Shop=@shop AND (Date BETWEEN @date1 and @date2) OR Date=@Today";
                System.Data.DataTable dt = new System.Data.DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
                adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
                adp.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
                adp.SelectCommand.Parameters.AddWithValue("@Today", todayDate);
                adp.Fill(dt);
                if (dataGridView1.Columns.Contains("ID"))
                {
                    dataGridView1.Columns["ID"].Visible = false;
                }
                dataGridView1.DataSource = dt;
                con.Close();

            } 
            
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            
        }
        public void goldsale_datefilter()
        {
            con.Close();
            try 
            
            {
                con.Open();
                // Loop through all checked items
                foreach (var item in Choose_Box.CheckedItems)
                {
                    // Perform actions with the checked items
                    string itemText = item.ToString();
                  /*  System.Windows.Forms.MessageBox.Show($"Checked Item: {itemText}");*/
                    if ( itemText == "Sale") 
                    {
                        DateTime todayDate = DateTime.Today;
                        string shopvalue = txt_shop_preview.Text;
                        /*con.Open();*/
                        string sql = "SELECT * FROM g_sale Where Shop=@shop AND (Date BETWEEN @date1 and @date2) OR Date=@Today";
                        System.Data.DataTable dt = new System.Data.DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
                        adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
                        adp.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
                        adp.SelectCommand.Parameters.AddWithValue("@Today", todayDate);
                        adp.Fill(dt);
                        if (dataGridView1.Columns.Contains("ID"))
                        {
                            dataGridView1.Columns["ID"].Visible = false;
                        }
                        dataGridView1.DataSource = dt;
                    }
                    else if(itemText =="Payment Method")
                    {
                        DateTime todayDate = DateTime.Today;
                        string shopvalue = txt_shop_preview.Text;
                        /*con.Open();*/
                        string sql = "SELECT * FROM payment_method Where Date BETWEEN @date1 and @date2 OR Date=@Today";
                        System.Data.DataTable dt = new System.Data.DataTable();
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        adp.SelectCommand.Parameters.AddWithValue("@date1", startdate.Value);
                        adp.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
                        adp.SelectCommand.Parameters.AddWithValue("@Today", todayDate);
                        adp.Fill(dt);
                        if (dataGridView1.Columns.Contains("ID"))
                        {
                            dataGridView1.Columns["ID"].Visible = false;
                        }
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Something went wrong");
                    }
                   
                }
                con.Close();
            }
            catch(Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
           

            
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
            else if (txt_form_perview.Text == "Gold Sale")
            {
                goldsale_search();
            }
        }

        public void goldregister_search()
        {
            con.Close();
            try 
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

            } catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            
        }

        public void goldotherout_search()
        {
            con.Close ();
            try 
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

            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            
        }

        public void goldsale_search()
        {
            con.Close();
            try 
            {
                con.Open();
                foreach (var item in Choose_Box.CheckedItems)
                {
                    string itemText = item.ToString();
                    if (itemText == "Sale")
                    {
                        string sql = "SELECT * FROM g_sale Where Product_ID='" + txt_searchbox.Text.ToString() + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        /*            if (dataGridView1.Rows.Count <1)
                                    {wh
                                        MessageBox.Show("Product မရှိပါ");
                                    }*/                      

                    }
                    else if (itemText == "Payment Method")
                    {
                        string sql = "SELECT * FROM payment_method Where Sale_Voucher_No ='" + txt_searchbox.Text.ToString() + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        /*            if (dataGridView1.Rows.Count <1)
                                    {wh
                                        MessageBox.Show("Product မရှိပါ");
                                    }*/

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Something went wrong");
                    }
                }
                con.Close();
            }
            catch(Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            
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

        private void Btn_Exp_Excel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_form_perview.Text == "Gold Other Out")
            {
                goldotherout_datefilter();
            }
            else if (txt_form_perview.Text == "Gold Register")
            {
                goldregister_datefilter();
            }
            else if (txt_form_perview.Text == "Gold Sale")
            {
                bool isChecked = false;

                // Iterate through the items in the CheckedListBox
                foreach (int index in Choose_Box.CheckedIndices)
                {
                    isChecked = true;
                    break;
                }

                if (!isChecked)
                {
                    // Show a message box if no items are checked
                    System.Windows.Forms.MessageBox.Show("Please check at least one item.", "No Items Checked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = null;
                }
                else
                {
                    // Perform the desired action if at least one item is checked
                    goldsale_datefilter();
                }

                
            }
        }


    }
}
