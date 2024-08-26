
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Globalization;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;
using static MJS.Form2;
using static MJS.g_sale;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;


namespace MJS
{
    public partial class payment_form : Form
    {
        private Form2 _Home;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        SqlCommand cmd, cmd2, cmd3, cmd4;    
        string sql, sql2, sql3, sql4;


       

        public payment_form(DataTable dt, DataTable dt2)
        {
            InitializeComponent();
            DataTable tableWithImages = ConvertDataTableWithImages(dt);
            PopulateDataGridViewWithImages(tableWithImages);
            dgv_TDP.DataSource = dt2;
        }


        // Convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        // Convert DataTable with byte array images back to images
        private DataTable ConvertDataTableWithImages(DataTable dt)
        {
            DataTable newTable = dt.Clone();

            // Change the type of image columns to Image
            foreach (DataColumn column in newTable.Columns)
            {
                if (column.DataType == typeof(byte[]))
                {
                    column.DataType = typeof(Image);
                }
            }

            // Populate new DataTable with images
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = newTable.NewRow();
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.DataType == typeof(byte[]))
                    {
                        newRow[column.ColumnName] = row[column] != DBNull.Value ? ByteArrayToImage((byte[])row[column]) : null;
                    }
                    else
                    {
                        newRow[column.ColumnName] = row[column];
                    }
                }
                newTable.Rows.Add(newRow);
            }

            return newTable;
        }

        // Populate DataGridView with images
        private void PopulateDataGridViewWithImages(DataTable dt)
        {
            add_data.Columns.Clear();
            add_data.AutoGenerateColumns = false;

            foreach (DataColumn column in dt.Columns)
            {
                if (column.DataType == typeof(Image))
                {
                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = column.ColumnName,
                        DataPropertyName = column.ColumnName
                    };
                    add_data.Columns.Add(imgColumn);
                }
                else
                {
                    DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = column.ColumnName,
                        DataPropertyName = column.ColumnName
                    };
                    add_data.Columns.Add(textColumn);
                }
            }

            add_data.DataSource = dt;

        }
            public void SetValue(double value)
        {
            
            txt_sale_amt.Text = value.ToString();
            lbl_show_saleamt.Text = string.Format("{0:n0}", double.Parse(txt_sale_amt.Text)) + " " + "Ks";
           
        }

        private void payment_form_Load(object sender, EventArgs e)
        {
           
            cash_rdo_btn.Checked = true;
            txt_show.Text = "Cash";         
            txt_currency_rate.Text = "Currency Rate";
            txt_currency_rate.ForeColor = Color.LightGray;
            payment.SelectedIndex = 0;
            timer2.Start();
            
        }

        private void cash_rdo_btn_Click(object sender, EventArgs e)
        {
            payment.SelectedIndex = 0;
            txt_show.Text = "Cash";

        }

        private void bank_rdo_btn_Click(object sender, EventArgs e)
        {
            payment.SelectedIndex = 2;
            txt_show.Text = "Bank Card";

            txt_bankcard_amt.Text = "0";
            txt_POS.Text = "";
            cmb_cardtype.SelectedIndex = -1;
        }

        private void foreign_rdo_btn_Click(object sender, EventArgs e)
        {
            payment.SelectedIndex = 1;
            txt_show.Text = "Foreign Currency";

            txt_exchange_amt.Text = "0";
            txt_currency_rate.Text = "0";
            txt_currency_amt.Text = "0";
            cmb_currenty_type.SelectedIndex = -1;
        }

        private void MB_rdo_btn_Click(object sender, EventArgs e)
        {
            payment.SelectedIndex = 3;
            txt_show.Text = "Mobile Banking";

            txt_mobilebanking_amt.Text = "0";
            cmb_bankname.SelectedIndex = -1;
        }


        private void txt_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_dollar_rate_Leave(object sender, EventArgs e)
        {
            /*if (txt_currency_rate.Text == "")
            {
                txt_currency_rate.Text = "Currency Rate";
                txt_currency_rate.ForeColor = Color.LightGray;
            }*/
        }

        public void invoiceid()/*function Invoice Number*/
        {

            try
            {

                string shopvalue = login.shopvalue;
                con.Open();
                sql = $"SELECT Sale_Voucher_No FROM g_sale WHERE Shop = @shoped ORDER BY ID DESC";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@shoped", shopvalue);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    System.Windows.MessageBox.Show("null");
                    string form = "GS";
                    /*string shop = login.shoptext;*/
                    string shop = login.shopvalue;
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    txt_Voucher_no.Text = form + shop + date + "-" + id;
                    show_reg_piddata();

                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT Sale_Voucher_No FROM g_sale WHERE Shop = @shoped ORDER BY ID DESC";
                    cmd.Parameters.AddWithValue("@shoped", shopvalue);
                    sr = cmd.ExecuteReader();
                    if (sr.Read())

                    {
                        string form = "GS";
                        /*string num = txt_barcode.Text;*/
                        string shop = login.shopvalue;
                        string date = DateTime.Now.ToString("ddMMyy");
                        string pid = sr.GetValue(0).ToString();
                        txt_result_id.Text = pid;
                        string[] temparray = txt_result_id.Text.Split('-');
                        txt_temparay.Text = form + shop + date;
                        txt_Dece.Text = temparray[1];
                        int i = Convert.ToInt32(txt_Dece.Text);
                        i++;
                        txt_Dece.Text = i.ToString();
                        string autoid = txt_temparay.Text + "-" + String.Format("{0:0000}", i);
                      
                        /* txt_Dece.Text = autoid;*/
                        txt_Voucher_no.Text = autoid;
                        show_reg_piddata();

                    }

                }

                con.Close();

            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }
        public void resetpid()/*function Reset Code Invoice and Product ID*/
        {
            string date = DateTime.Now.ToString("dd/MMM/yyyy");
            string serverdate = "0";
            string shopvalue = login.shopvalue; 
            string datevalue = "";
            con.Open();
        
            sql = $"SELECT Date FROM g_sale WHERE Shop = @shoped ORDER BY ID DESC";
           

            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@shoped", shopvalue);
            cmd.Parameters.AddWithValue("@Date", date);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                serverdate = dr.GetValue(0).ToString();
                datevalue = serverdate.ToString();


            }
            con.Close();
            if (datevalue == "" || DateTime.Parse(date, CultureInfo.InvariantCulture) != DateTime.Parse(serverdate, CultureInfo.InvariantCulture))
            {

                string form = "GS";
                string ivshop = login.shopvalue;
                string ivdate = DateTime.Now.ToString("ddMMyy");
                string ivid = "0001";

                txt_Voucher_no.Text = form + ivshop + ivdate + "-" + ivid;

               /* System.Windows.MessageBox.Show("Code Is Reset");*/
                show_reg_piddata();

            }

            else

            {
               
                invoiceid();

            }

        }

        public void addpaymentmethod() 
        {

            con.Close();
            try
            {
                string voucherNumber = txt_Voucher_no.Text;

                con.Open();


                foreach (DataGridViewRow row in dgv_show_paymethod.Rows)
                {

                    if (row.IsNewRow)
                        continue;


                    string query = "insert into payment_method (Date,Time,Sale_Voucher_No,Payment_Method,Payment_Type,Amount,Currency_Rate,POS) values(@Date,@Time,@Sale_Voucher_No,@Payment_Method,@Payment_Type,@Amount,@Currency_Rate,@POS)";

                    using (SqlCommand cmd2 = new SqlCommand(query, con))
                    {
                        
                        cmd2.Parameters.AddWithValue("@Date", txt_date.Text.ToString());
                        cmd2.Parameters.AddWithValue("@Time", txt_time.Text.ToString());
                        cmd2.Parameters.AddWithValue("@Sale_Voucher_No", voucherNumber);
                        cmd2.Parameters.AddWithValue("@Payment_Method", row.Cells[0].Value ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@Payment_Type", row.Cells[1].Value ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@Amount", row.Cells[2].Value ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@Currency_Rate", row.Cells[3].Value ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@POS", row.Cells[4].Value ?? DBNull.Value);

                        cmd2.ExecuteNonQuery();
                        
                    }
                    
                }
                dgv_show_paymethod.Rows.Clear();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show($"An error occurred: {ex.Message}"); }

            /* con.Close();
             try
             {
                 con.Open();

                 for  (int i = 0; i < dgv_show_paymethod.Rows.Count; i++)
                 {
                     cmd2 = new SqlCommand("insert into payment_method (Date,Time,Sale_Voucher_No,Payment_Method,Payment_Type,Amount,Currency_Rate,POS) values(@Date,@Time,@Sale_Voucher_No,@Payment_Method,@Payment_Type,@Amount,@Currency_Rate,@POS)", con);

                     cmd2.Parameters.AddWithValue("@Date", txt_date.Text.ToString());
                     cmd2.Parameters.AddWithValue("@Time", txt_time.Text.ToString());
                     cmd2.Parameters.AddWithValue("@Sale_Voucher_No", txt_Voucher_no.Text.ToString());
                     cmd2.Parameters.AddWithValue("@Payment_Method", dgv_show_paymethod.Rows[i].Cells[0].Value ?? DBNull.Value);
                     cmd2.Parameters.AddWithValue("@Payment_Type", dgv_show_paymethod.Rows[i].Cells[1].Value ?? DBNull.Value);
                     cmd2.Parameters.AddWithValue("@Amount", dgv_show_paymethod.Rows[i].Cells[2].Value ?? DBNull.Value);
                     cmd2.Parameters.AddWithValue("@Currency_Rate", dgv_show_paymethod.Rows[i].Cells[3].Value ?? DBNull.Value);
                     cmd2.Parameters.AddWithValue("@POS", dgv_show_paymethod.Rows[i].Cells[4].Value ?? DBNull.Value);


                     cmd2.ExecuteNonQuery();

                     dgv_show_paymethod.Rows.Clear();
                 }
             }
             catch(Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (true)//check new order
            {
                timer1.Stop();
                int Desc;
                string check = "";
                check = (InternetGetConnectedState(out Desc, 0).ToString());
                if (check == "True")
                {
                    resetpid();

                }
                else
                {
                    System.Windows.MessageBox.Show("Check Your Internet Connection");

                    this.BackColor = System.Drawing.Color.GhostWhite;
                }
            }
        }

        public void show_reg_piddata()/*Show Register Data To Table Function*/
        {
            con.Close ();
            try
            {
               
                int primarykey;
                for (int i = 0; i < add_data.Rows.Count; i++)
                {
                    
                    con.Open();
                    sql = "SELECT Product_ID FROM g_sale";
                  


                    cmd = new SqlCommand(sql, con);
                 


                    var maxid = cmd.ExecuteScalar() as string;
                    
                    if (maxid == add_data.Rows[i].Cells[2].Value)
                    {
                        
                        System.Windows.MessageBox.Show("ProductID Is Already Have");
                        
                    }
                    else
                    {
                       
                        cmd = new SqlCommand("insert into g_sale (Date,Time,Sale_Voucher_No,Product_ID,Gold_Price,Item," +
                         "Itemname,Qty,Reg_Gm,Gold_Type,Sale_Gm,K,P,Y,S,WK,WP,WY,WS,TK,TP,TY,TS,M_Cost,GPD_Amt,P_Amt,BB_Amt,Total_BB_Amt," +
                         "Tax,Tax_Amt,In_Tax_Amt,Pro_Percent,Pro_Percent_Amt,Pro_Flat_Amt,Amount,Dis_Amt,Total_Amt,Remark,Empolyee,Shop,Form,Counter) values(@Date,@Time,@Sale_Voucher_No,@Product_ID,@Gold_Price,@Item," +
                         "@Itemname,@Qty,@Reg_Gm,@Gold_Type,@Sale_Gm,@K,@P,@Y,@S,@WK,@WP,@WY,@WS,@TK,@TP,@TY,@TS,@M_Cost,@GPD_Amt,@P_Amt,@BB_Amt,@Total_BB_Amt," +
                         "@Tax,@Tax_Amt,@In_Tax_Amt,@Pro_Percent,@Pro_Percent_Amt,@Pro_Flat_Amt,@Amount,@Dis_Amt,@Total_Amt,@Remark,@Empolyee,@Shop,@Form,@Counter)", con);

                       

                        cmd.Parameters.AddWithValue("@Date", txt_date.Text.ToString());
                        cmd.Parameters.AddWithValue("@Time", txt_time.Text.ToString());
                        cmd.Parameters.AddWithValue("@Sale_Voucher_No",txt_Voucher_no.Text.ToString());
                        cmd.Parameters.AddWithValue("@Product_ID", add_data.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@Gold_Price", add_data.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@Item", add_data.Rows[i].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@Itemname", add_data.Rows[i].Cells[5].Value);
                        cmd.Parameters.AddWithValue("@Qty", add_data.Rows[i].Cells[6].Value);
                        cmd.Parameters.AddWithValue("@Reg_Gm", add_data.Rows[i].Cells[7].Value);
                        cmd.Parameters.AddWithValue("@Gold_Type", add_data.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@Sale_Gm", add_data.Rows[i].Cells[9].Value);
                        cmd.Parameters.AddWithValue("@K", add_data.Rows[i].Cells[10].Value);
                        cmd.Parameters.AddWithValue("@P", add_data.Rows[i].Cells[11].Value);
                        cmd.Parameters.AddWithValue("@Y", add_data.Rows[i].Cells[12].Value);
                        cmd.Parameters.AddWithValue("@S", add_data.Rows[i].Cells[13].Value);
                        cmd.Parameters.AddWithValue("@WK", add_data.Rows[i].Cells[14].Value);
                        cmd.Parameters.AddWithValue("@WP", add_data.Rows[i].Cells[15].Value);
                        cmd.Parameters.AddWithValue("@WY", add_data.Rows[i].Cells[16].Value);
                        cmd.Parameters.AddWithValue("@WS", add_data.Rows[i].Cells[17].Value);
                        cmd.Parameters.AddWithValue("@TK", add_data.Rows[i].Cells[18].Value);
                        cmd.Parameters.AddWithValue("@TP", add_data.Rows[i].Cells[19].Value);
                        cmd.Parameters.AddWithValue("@TY", add_data.Rows[i].Cells[20].Value);
                        cmd.Parameters.AddWithValue("@TS", add_data.Rows[i].Cells[21].Value);
                        cmd.Parameters.AddWithValue("@M_Cost", add_data.Rows[i].Cells[22].Value);
                        cmd.Parameters.AddWithValue("@GPD_Amt", add_data.Rows[i].Cells[23].Value);
                        cmd.Parameters.AddWithValue("@P_Amt", add_data.Rows[i].Cells[24].Value);
                        cmd.Parameters.AddWithValue("@BB_Amt", add_data.Rows[i].Cells[25].Value);
                        cmd.Parameters.AddWithValue("@Total_BB_Amt", add_data.Rows[i].Cells[26].Value);
                        cmd.Parameters.AddWithValue("@Tax", add_data.Rows[i].Cells[27].Value);
                        cmd.Parameters.AddWithValue("@Tax_Amt", add_data.Rows[i].Cells[28].Value);
                        cmd.Parameters.AddWithValue("@In_Tax_Amt", add_data.Rows[i].Cells[29].Value);
                        cmd.Parameters.AddWithValue("@Pro_Percent", add_data.Rows[i].Cells[30].Value);
                        cmd.Parameters.AddWithValue("@Pro_Percent_Amt", add_data.Rows[i].Cells[31].Value);
                        cmd.Parameters.AddWithValue("@Pro_Flat_Amt", add_data.Rows[i].Cells[32].Value);
                        cmd.Parameters.AddWithValue("@Amount", add_data.Rows[i].Cells[33].Value);
                        cmd.Parameters.AddWithValue("@Dis_Amt", add_data.Rows[i].Cells[34].Value);
                        cmd.Parameters.AddWithValue("@Total_Amt", add_data.Rows[i].Cells[35].Value);
                        cmd.Parameters.AddWithValue("@Remark", add_data.Rows[i].Cells[36].Value);
                        cmd.Parameters.AddWithValue("@Empolyee", add_data.Rows[i].Cells[37].Value);
                        cmd.Parameters.AddWithValue("@Shop", add_data.Rows[i].Cells[38].Value);
                        cmd.Parameters.AddWithValue("@Form", add_data.Rows[i].Cells[39].Value);
                        cmd.Parameters.AddWithValue("@Counter", add_data.Rows[i].Cells[40].Value);

                        /*------------------------------------------- Today Product ______________________________________________________________*/
                        SaveVouchertodayproduct();
                        /*______________________________________________________________*/

                        primarykey = Convert.ToInt32(cmd.ExecuteScalar());
                      

                        addpaymentmethod();
                        

                    }
                    // Iterate through all rows in the DataGridView
                    for (int t = dgv_TDP.Rows.Count - 1; t >= 0; t--)
                    {
                        // Extract the value from cell at column index 2 (assuming 0-based index)
                        string valueToCheck = dgv_TDP.Rows[t].Cells[0].Value?.ToString();

                        // Delete the row if the value matches
                        if (!string.IsNullOrEmpty(valueToCheck))
                        {
                            // Delete from database
                            DeleteRowFromDatabase(valueToCheck);

                            // Remove row from DataGridView
                            dgv_TDP.Rows.RemoveAt(t);

                        }
                    }
                  
                    DialogResult result = System.Windows.Forms.MessageBox.Show("Operation completed successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        GlobalEventManager.TriggerSaveButtonClicked();
                        lbl_show_saleamt.Text = "0";
                        lbl_show_payment.Text = "0";
                        lbl_show_outstanding.Text = "0";
                        add_data.Rows.Clear();
                        this.Close();                   
                        

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Operation is incompleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    /* con.Close();*/

                }
               /* System.Windows.MessageBox.Show("success");*/  

            }
            catch (SqlException ex)
            {
                // Log or handle the SQL-specific error
                Console.WriteLine("SQL Server Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Log or handle any general error
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is always closed, even if an error occurs
                con.Close();
            }

        }

        private void SaveVouchertodayproduct()
        {
            con.Close();
            try
            {
                string voucherNumber = txt_Voucher_no.Text;

                con.Open();
              

                foreach (DataGridViewRow row in dgv_TDP.Rows)
                {

                    if (row.IsNewRow)
                        continue;


                    string query = "insert into todayproduct (Date,Time,Voucher_No,Product_ID,Item,Itemname,Qty,Gm,Empolyee,Shop,Form)values(@Date,@Time,@Voucher_No,@Product_ID,@Item,@Itemname,@Qty,@Gm,@Empolyee,@Shop,@Form)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        string shopvalue = login.shopvalue;
                        string empolyee=  Form2.setvalueemployee;
                        string form = g_sale.setvalueform;

                        command.Parameters.AddWithValue("@Date", txt_date.Text.ToString());
                        command.Parameters.AddWithValue("@Time", txt_time.Text.ToString());
                        command.Parameters.AddWithValue("@Voucher_No", voucherNumber);
                        command.Parameters.AddWithValue("@Product_ID", row.Cells[0].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Item", row.Cells[1].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Itemname", row.Cells[2].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Qty", row.Cells[3].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Gm", row.Cells[4].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Empolyee", empolyee);
                        command.Parameters.AddWithValue("@Shop", shopvalue);
                        command.Parameters.AddWithValue("@Form", form);



                        command.ExecuteNonQuery();
                    }
                }            
               
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show($"An error occurred: {ex.Message}"); }
      
                /*System.Windows.Forms.MessageBox.Show("Voucher data saved successfully!");*/
            
        }


        private void DeleteRowFromDatabase(string value)
        {
            con.Close();
            try
            {
                con.Open();

                // Construct SQL DELETE query
                string query = "DELETE FROM closing_stock WHERE ProductID = @Value";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Value", value);

                    // Execute the DELETE query
                    command.ExecuteNonQuery();


                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }

        }


       /* public void DeleteRowFromDatabase2()
        {
            con.Close();
            foreach (DataGridViewRow row in dgv_TDP.Rows)
            {
                if (!row.IsNewRow) // Skip the new row placeholder if using AllowUserToAddRows
                {
                    // Get the value from the first cell
                    string valueToDelete = row.Cells[0].Value.ToString();

                    try
                    {
                        con.Open();

                        // Construct SQL DELETE query
                        string query = "DELETE FROM closing_stock WHERE ProductID = @Value";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@Value", valueToDelete);

                            // Execute the DELETE query
                            command.ExecuteNonQuery();


                        }

                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No rows available to delete.");
                }
            }
        }*/

     /*   private void BulkDeleteSelectedRows()
        {
            // ဖျက်မည့် ID များကို စုစည်းပါ။
            List<string> idsToDelete = new List<string>();

            foreach (DataGridViewRow row in dgv_TDP.SelectedRows)
            {
                string id = row.Cells[0].Value?.ToString(); // ID ကို ယူပါ။ (ID ဟာ 0 ကော်လံမှာရှိတယ်ဟုယူဆထားပါသည်)
                if (!string.IsNullOrEmpty(id))
                {
                    idsToDelete.Add(id);
                }
            }

            // ID များစွာ စုစည်းပြီးရင် database မှာ bulk delete လုပ်ပါ။
            if (idsToDelete.Count > 0)
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Bulk delete query တည်ဆောက်ပါ။
                        string query = $"DELETE FROM closing_stock WHERE ProductID IN ({string.Join(",", idsToDelete.Select(id => $"'{id}'"))})";

                        using (SqlCommand command = new SqlCommand(query, con, transaction))
                        {
                            int rowsAffected = command.ExecuteNonQuery(); // ဖျက်ပစ်သော အတန်းအရေအတွက်ကို ပြန်လာပါမယ်။
                            System.Windows.Forms.MessageBox.Show($"{rowsAffected} rows deleted successfully.");
                        }

                        transaction.Commit(); // အောင်မြင်မှုမှာ ပြုလုပ်ချက်အားလုံးကို သိမ်းဆည်းပါ။
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // အမှားရှိပါက ပြန်သိမ်းဆည်းပါ။
                        System.Windows.Forms.MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No rows selected for deletion.");
            }
        }*/




        private void Btn_Pay_Click(object sender, EventArgs e)
        {
            
            if (txt_show.Text == "Cash")
            {

                if (txt_cash_amt.Text == "0" || txt_cash_amt.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Please Check Again");
                }
                else
                {
                    double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_cash_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                    double minus = 0;
                    double checkamt = number1 - (number2 + number3);

                    string newAmount = txt_cash_amt.Text; // TextBox for new amount input
                    bool cashFound = false;
                    double amt = 0;

                    if (checkamt < 0)

                    {
                        System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");
                    }
                    else

                    {
                        // Check if any cell in column 1 has the value "cash"    
                        foreach (DataGridViewRow row in dgv_show_paymethod.Rows)

                        {
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == "Cash")

                            {
                                // Update the amount cell                                   
                                row.Cells[2].Value = newAmount;

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)

                                {
                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";

                                    txt_cash_amt.Text = "0";
                                    cashFound = true;
                                    break;

                                }
                            }
                        }
                        // If "cash" was not found in column 1, add a new row
                        if (!cashFound)
                        {
                            if (checkamt < 0)
                            {

                                System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                            }
                            else
                            {
                                dgv_show_paymethod.Rows.Add(txt_show.Text, "Cash", txt_cash_amt.Text);

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)
                                {
                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";

                                }

                                txt_cash_amt.Text = "0";

                            }
                        }
                    }
                }
            }
            else if (txt_show.Text == "Foreign Currency")
            {

                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_exchange_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = 0;
                double checkamt = number1 - (number2 + number3);

                if (cmb_currenty_type.SelectedIndex == -1 || txt_currency_rate.Text == "" || txt_currency_amt.Text == "" || txt_exchange_amt.Text == "0")
                {
                    System.Windows.MessageBox.Show("Please Check");
                }
                else
                {

                    string newAmount = txt_exchange_amt.Text; // TextBox for new amount input
                    bool cashFound = false;
                    double amt = 0;
                    if (checkamt < 0)
                    {

                        System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");
                    }
                    else
                    {
                        // Check if any cell in column 1 has the value "cash"
                        foreach (DataGridViewRow row in dgv_show_paymethod.Rows)
                        {
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == cmb_currenty_type.SelectedItem.ToString())
                            {
                                // Update the amount cell

                                row.Cells[2].Value = newAmount;

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)
                                {

                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                                }

                                txt_exchange_amt.Text = "0";
                                txt_currency_rate.Text = "0";
                                txt_currency_amt.Text = "0";
                                cmb_currenty_type.SelectedIndex = -1;
                                cashFound = true;
                                break;
                            }
                        }
                        // If "cash" was not found in column 1, add a new row
                        if (!cashFound)
                        {
                            if (checkamt < 0)
                            {

                                System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");
                            }
                            else
                            {
                                dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_currenty_type.Text, txt_exchange_amt.Text, txt_currency_rate.Text);

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)
                                {
                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                                }

                                txt_exchange_amt.Text = "0";
                                txt_currency_rate.Text = "0";
                                txt_currency_amt.Text = "0";
                                cmb_currenty_type.SelectedIndex = -1;
                            }

                        }
                    }
                }
            }
            else if (txt_show.Text == "Bank Card")
            {

                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_bankcard_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = 0;
                double checkamt = number1 - (number2 + number3);


                if (cmb_cardtype.SelectedIndex == -1 || txt_POS.Text == "" || txt_bankcard_amt.Text == "0")
                {
                    System.Windows.MessageBox.Show("Please Check");
                }

                else
                {
                    string pos = txt_POS.Text;
                    string newAmount = txt_bankcard_amt.Text; // TextBox for new amount input
                    bool cashFound = false;
                    double amt = 0;
                    if (checkamt < 0)

                    {

                        System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                    }
                    else
                    {
                        // Check if any cell in column 1 has the value "cash"

                        foreach (DataGridViewRow row in dgv_show_paymethod.Rows)

                        {

                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == cmb_cardtype.SelectedItem.ToString())

                            {
                                // Update the amount cell

                                row.Cells[2].Value = newAmount;
                                row.Cells[4].Value = pos;


                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)

                                {

                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";

                                }

                                txt_bankcard_amt.Text = "0";
                                txt_POS.Text = "";
                                cmb_cardtype.SelectedIndex = -1;
                                cashFound = true;
                                break;

                            }
                        }
                        // If "cash" was not found in column 1, add a new row

                        if (!cashFound)

                        {
                            if (checkamt < 0)

                            {

                                System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                            }
                            else
                            {
                                dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_cardtype.Text, txt_bankcard_amt.Text, "", txt_POS.Text);


                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)

                                {
                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";

                                }

                                txt_bankcard_amt.Text = "0";
                                txt_POS.Text = "";
                                cmb_cardtype.SelectedIndex = -1;
                            }
                        }
                    }
                }

            }
            else if (txt_show.Text == "Mobile Banking")
            {

                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_mobilebanking_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = 0;
                double checkamt = number1 - (number2 + number3);

                if (cmb_bankname.SelectedIndex == -1 || txt_mobilebanking_amt.Text == "0")
                {
                    System.Windows.MessageBox.Show("Please Check");
                }
                else
                {
                    string newAmount = txt_mobilebanking_amt.Text; // TextBox for new amount input
                    bool cashFound = false;
                    double amt = 0;

                    if (checkamt < 0)

                    {

                        System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");


                    }
                    else
                    {
                        // Check if any cell in column 1 has the value "cash"
                        foreach (DataGridViewRow row in dgv_show_paymethod.Rows)
                        {
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == cmb_bankname.SelectedItem.ToString() && row.Cells[0].Value.ToString() == txt_show.Text)
                            {
                                // Update the amount cell

                                row.Cells[2].Value = newAmount;

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)
                                {

                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                                }

                                txt_mobilebanking_amt.Text = "0";
                                cmb_bankname.SelectedIndex = -1;
                                cashFound = true;
                                break;
                            }
                        }
                        // If "cash" was not found in column 1, add a new row
                        if (!cashFound)
                        {
                            if (checkamt < 0)

                            {

                                System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");


                            }
                            else
                            {
                                dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_bankname.Text, txt_mobilebanking_amt.Text);

                                for (int i = 0; i < dgv_show_paymethod.Rows.Count; ++i)
                                {
                                    amt += Convert.ToDouble(dgv_show_paymethod.Rows[i].Cells[2].Value);
                                    lbl_payment_amt.Text = amt.ToString();
                                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                                    minus = number1 - amt;
                                    lbl_outstanding_amt.Text = minus.ToString();
                                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                                }

                                txt_mobilebanking_amt.Text = "0";
                                cmb_bankname.SelectedIndex = -1;
                            }
                        }
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("ငွေပေးချေမှု့ မှားယွင်းနေပါသည်။");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
                DateTime d = new DateTime();
                d = DateTime.Now;
                txt_date.Text = d.ToString("dd/MMM/yyyy");
                txt_time.Text = DateTime.Now.ToLongTimeString();
            
        }


        private void payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = payment.SelectedIndex;

            // Check which tab is selected and show a message accordingly
            switch (selectedIndex)
            {
                case 0:

                    txt_show.Text = "Cash";
                  
                    break;
                case 1:

                    txt_show.Text = "Foreign Currency";

                    txt_exchange_amt.Text = "0";
                    txt_currency_rate.Text = "0";
                    txt_currency_amt.Text = "0";
                    cmb_currenty_type.SelectedIndex = -1;
            
                    break;
                case 2:

                    txt_show.Text = "Bank Card";

                    txt_bankcard_amt.Text = "0";
                    txt_POS.Text = "";
                    cmb_cardtype.SelectedIndex = -1;
                   
                    break;
            
                case 3:

                    txt_show.Text = "Mobile Banking";

                    txt_mobilebanking_amt.Text = "0";
                    cmb_bankname.SelectedIndex = -1; 
                    break;
                default:
           
                    break;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (lbl_show_payment.Text == lbl_show_saleamt.Text)
            {
                timer1.Interval = 100;
                timer1.Start();

            }
        }

        private void txt_dollar_rate_Enter(object sender, EventArgs e)
        {
            /*if (txt_currency_rate.Text == "Currency Rate")
            {
                txt_currency_rate.Text = "";
                txt_currency_rate.ForeColor = Color.Black;
            }*/
        }

        private void txt_currency_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_currency_amt.Text == "")
            {
                txt_currency_amt.Text = "0";             
                txt_currency_amt.SelectionStart = 0;
                txt_currency_amt.SelectionLength = txt_currency_amt.Text.Length;

            }
            else if (txt_currency_rate.Text == "") 
            {
                txt_currency_rate.Text = "0";
                txt_currency_rate.SelectionStart = 0;
                txt_currency_rate.SelectionLength = txt_currency_amt.Text.Length;
            }
            else 
            {
                double rate = double.Parse(txt_currency_rate.Text); double cuc_amt = double.Parse(txt_currency_amt.Text); double value = 0;
                value = rate * cuc_amt;
                txt_exchange_amt.Text = value.ToString();
            }         
        }

        private void txt_currency_amt_Leave(object sender, EventArgs e)
        {
            if (txt_currency_amt.Text == "")
            {
                txt_currency_amt.Text = "0";
            }
            else
            {
                double rate = double.Parse(txt_currency_rate.Text); double cuc_amt = double.Parse(txt_currency_amt.Text); double value = 0;
                value = Math.Round(rate * cuc_amt);
                txt_exchange_amt.Text = value.ToString();
            }
        }


        private void txt_bankcard_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_bankcard_amt.Text == "")
            {
                txt_bankcard_amt.Text = "0";
                txt_bankcard_amt.SelectionStart = 0;
                txt_bankcard_amt.SelectionLength = txt_bankcard_amt.Text.Length;

            }
        }

        private void txt_mobilebanking_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_mobilebanking_amt.Text == "")
            {
                txt_mobilebanking_amt.Text = "0";
                txt_mobilebanking_amt.SelectionStart = 0;
                txt_mobilebanking_amt.SelectionLength = txt_mobilebanking_amt.Text.Length;

            }
        }
    }
}
