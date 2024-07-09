using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Globalization;
using OfficeOpenXml.ConditionalFormatting;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MJS
{
    public partial class g_otherout :Form
    {
       

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public g_otherout()
        {
            InitializeComponent();
            showdata.AutoGenerateColumns = true;
        }

        private void g_otherout_Load(object sender, EventArgs e)
        {
            txt_shop.Text = login.shopvalue;
            timer3.Interval = 100;
            timer3.Start();

        }

        public void resetpid()/*function Reset Code Invoice and Product ID*/
        {
            string date = DateTime.Now.ToString("dd/MMM/yyyy");
            string serverdate = "0";
            string shopvalue = txt_shop.Text;
            string datevalue = "";
            con.Open();
            /*sql = "SELECT Date FROM reg_gold ORDER BY Date DESC";*/
            sql = $"SELECT Date FROM other_out WHERE Shop = @shoped ORDER BY ID DESC";
            
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@shoped", shopvalue);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                serverdate = dr.GetValue(0).ToString();
                datevalue = serverdate.ToString();
                textBox1.Text = datevalue;
            }
            con.Close();
            if (datevalue == "" || DateTime.Parse(date, CultureInfo.InvariantCulture) != DateTime.Parse(serverdate, CultureInfo.InvariantCulture))
            {

                string form = "GO";
                string ivshop = login.shopvalue;
                string ivdate = DateTime.Now.ToString("ddMMyy");
                string ivid = "0001";
                txt_outvoucher.Text = form + ivshop + ivdate + "-" + ivid;

                MessageBox.Show("Code Is Reset");

            }

            else

            {
                invoiceid();

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (true)//check new order
            {
                timer2.Stop();
                int Desc;
                string check = "";
                check = (InternetGetConnectedState(out Desc, 0).ToString());
                if (check == "True")
                {
                    adddata();

                    // Iterate through all rows in the DataGridView
                    for (int t = store_data.Rows.Count - 1; t >= 0; t--)
                    {
                        // Extract the value from cell at column index 2 (assuming 0-based index)
                        string valueToCheck = store_data.Rows[t].Cells[6].Value.ToString();

                        // Delete the row if the value matches
                        if (!string.IsNullOrEmpty(valueToCheck))
                        {
                            // Delete from database
                            DeleteRowFromDatabase(valueToCheck);

                            // Remove row from DataGridView
                            store_data.Rows.RemoveAt(t);

                            invoiceid();

                            lbl_totalamt.Text = "0";
                            lbl_gm.Text = "0";
                            lbl_qty.Text = "0";

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Check Your Internet Connection");
                    /*this.Enabled = false;
                    this.BackColor = System.Drawing.Color.GhostWhite;*/
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (true)//check new order
            {
                timer3.Stop();
                int Desc;
                string check = "";
                check = (InternetGetConnectedState(out Desc, 0).ToString());
                if (check == "True")
                {
                    resetpid();
                }
                else
                {
                    MessageBox.Show("Check Your Internet Connection");
                    /* this.Enabled = false;
                     this.BackColor = System.Drawing.Color.GhostWhite;*/
                }
            }
        }


        private void txt_pur_no_TextChanged(object sender, EventArgs e)
        {
            show();

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            /* if (showdata.Rows.Count > 0)
             {
                 try
                 {
                     con.Close();
                     con.Open();
                     string sql = "delete from closing_stock where ProductID='" + showdata.Rows[0].Cells[6].Value.ToString() + "'";
                     SqlCommand cmd = new SqlCommand(sql, con);
                     cmd.ExecuteNonQuery();
                     con.Close();
                     txt_out_no.Text = "";
                     MessageBox.Show("Product Out Successfully");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }
             else
             {
                 MessageBox.Show("Something Went Wrong");
             }*/
            timer2.Interval = 100;
            timer2.Start();


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
                MessageBox.Show(ex.Message);
            }

        }

        public void adddata()
        {
            con.Close();
            try
            {
                con.Open();
                for (int i = 0; i < store_data.Rows.Count; i++)
                {
                    cmd = new SqlCommand("insert into other_out (Date,Time,OutVoucher_No,Out_Remark,PurVoucher,ProductID,GoldType,GoldPrice,Item," +
               "ItemName,Gm,K,P,Y,S,WK,WP,WY,WS,TK,TP,TY,TS,Mcost,Repamt,Totalamt,Remark,Employee,Shop,Form,Counter) values(@Date,@Time,@OutVoucher_No,@Out_Remark,@PurVoucher,@ProductID,@GoldType,@GoldPrice,@Item," +
               "@ItemName,@Gm,@K,@P,@Y,@S,@WK,@WP,@WY,@WS,@TK,@TP,@TY,@TS,@Mcost,@Repamt,@Totalamt,@Remark,@Employee,@Shop,@Form,@Counter)", con);

                    cmd.Parameters.AddWithValue("@Date", store_data.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@Time", store_data.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@OutVoucher_No", store_data.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@Out_Remark", store_data.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@PurVoucher", store_data.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@ProductID", store_data.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@GoldType", store_data.Rows[i].Cells[7].Value);
                    cmd.Parameters.AddWithValue("@GoldPrice", store_data.Rows[i].Cells[8].Value);
                    cmd.Parameters.AddWithValue("@Item", store_data.Rows[i].Cells[9].Value);
                    cmd.Parameters.AddWithValue("@ItemName", store_data.Rows[i].Cells[10].Value);
                    cmd.Parameters.AddWithValue("@Gm", store_data.Rows[i].Cells[11].Value);
                    cmd.Parameters.AddWithValue("@K", store_data.Rows[i].Cells[12].Value);
                    cmd.Parameters.AddWithValue("@P", store_data.Rows[i].Cells[13].Value);
                    cmd.Parameters.AddWithValue("@Y", store_data.Rows[i].Cells[14].Value);
                    cmd.Parameters.AddWithValue("@S", store_data.Rows[i].Cells[15].Value);
                    cmd.Parameters.AddWithValue("@WK", store_data.Rows[i].Cells[16].Value);
                    cmd.Parameters.AddWithValue("@WP", store_data.Rows[i].Cells[17].Value);
                    cmd.Parameters.AddWithValue("@WY", store_data.Rows[i].Cells[18].Value);
                    cmd.Parameters.AddWithValue("@WS", store_data.Rows[i].Cells[19].Value);
                    cmd.Parameters.AddWithValue("@TK", store_data.Rows[i].Cells[20].Value);
                    cmd.Parameters.AddWithValue("@TP", store_data.Rows[i].Cells[21].Value);
                    cmd.Parameters.AddWithValue("@TY", store_data.Rows[i].Cells[22].Value);
                    cmd.Parameters.AddWithValue("@TS", store_data.Rows[i].Cells[23].Value);
                    cmd.Parameters.AddWithValue("@Mcost", store_data.Rows[i].Cells[24].Value);
                    cmd.Parameters.AddWithValue("@Repamt", store_data.Rows[i].Cells[25].Value);
                    cmd.Parameters.AddWithValue("@Totalamt", store_data.Rows[i].Cells[26].Value);
                    cmd.Parameters.AddWithValue("@Remark", store_data.Rows[i].Cells[27].Value);
                    cmd.Parameters.AddWithValue("@Employee", store_data.Rows[i].Cells[28].Value);
                    cmd.Parameters.AddWithValue("@Shop", store_data.Rows[i].Cells[29].Value);
                    cmd.Parameters.AddWithValue("@Form", store_data.Rows[i].Cells[30].Value);
                    cmd.Parameters.AddWithValue("@Counter", store_data.Rows[i].Cells[31].Value);


                    cmd.ExecuteNonQuery();
                    /*MessageBox.Show("success");*/

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("success");
        }

        public void show()
        {
            con.Close();
            try
            {
                con.Open();
                string sql = "SELECT * FROM closing_stock Where ProductID='" + txt_out_no.Text.ToString() + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check_shop.Text = dt.Rows[0]["Shop"].ToString();
                    if (check_shop.Text == txt_shop.Text)
                    {
                        showdata.DataSource = dt;


                        byte[] imagedata = null;
                        SqlCommand cmd = new SqlCommand(sql, con);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                imagedata = (byte[])reader["Image"];
                            }
                        }
                        if (imagedata != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imagedata))
                            {
                                Image image = Image.FromStream(ms);

                                PictureBox pictureBox = new PictureBox();
                                show_image.Image = image;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Product ID Not Found");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        string sql;
        SqlCommand cmd;
        private int primarykey;

        public void invoiceid()/*function Invoice Number*/
        {
            con.Close();
            try
            {
                /*if (Con1.State == ConnectionState.Closed)
                {
                    Con1.Open();
                }*/
                string shopvalue = txt_shop.Text;
                con.Open();
                sql = $"SELECT OutVoucher_No FROM other_out WHERE Shop = @shoped ORDER BY ID DESC";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@shoped", shopvalue);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    string form = "GO";
                    /*string shop = login.shoptext;*/
                    string shop = login.shopvalue;
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    txt_outvoucher.Text = form + shop + date + "-" + id;

                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader sr = null;
                    cmd.Connection = con;
                    cmd.CommandText = $"SELECT OutVoucher_No FROM other_out WHERE Shop = @shoped ORDER BY ID DESC";
                    cmd.Parameters.AddWithValue("@shoped", shopvalue);
                    sr = cmd.ExecuteReader();
                    if (sr.Read())

                    {
                        string form = "GO";
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
                        txt_outvoucher.Text = autoid;

                    }

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }



        private void ico_add_btn_Click(object sender, EventArgs e)
        {
            string texttosent = txt_date.Text;
            textBox1.Text= texttosent;

        }

        public void Totalamt2()
        {
            decimal amt = 0;
            for (int i = 0; i < store_data.Rows.Count; ++i)
            {
                amt += Convert.ToDecimal(store_data.Rows[i].Cells[26].Value);
                string amtformat = amt.ToString("#,##0");
                lbl_totalamt.Text = amtformat;
            }
        }
        public void Totalgm2()
        {
            decimal amt = 0;
            for (int i = 0; i < store_data.Rows.Count; ++i)
            {
                amt += Convert.ToDecimal(store_data.Rows[i].Cells[11].Value);
                lbl_gm.Text = amt.ToString();
            }
        }
        public void Totalqty2()
        {
            lbl_qty.Text = store_data.Rows.Count.ToString();
        }


        public static string formvalue = "";

        public static string other = "";


        private void btn_review_Click(object sender, EventArgs e)
        {

           /* Form formbackground = new Form();
            try
            {
                using (preview frm = new preview(txt_form.Text))
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .70d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = this.Location;
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();
                   
                    frm.Owner = formbackground;

                    frm.ShowDialog();

                    formbackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formbackground.Dispose(); }*/

        }

        private void store_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 32)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient report?", "Conformation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)

                {
                    int rowIndex = store_data.CurrentCell.RowIndex;

                    store_data.Rows.RemoveAt(rowIndex);
                }

                else if (result == DialogResult.No)

                {

                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            g_otherout g_Otherout = new g_otherout();
            g_Otherout.show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < store_data.Rows.Count; i++)
            {
                if (txt_out_no.Text == store_data.Rows[i].Cells[6].Value.ToString())
                {
                    MessageBox.Show("Already have data insert!");
                    return;
                }
            }

            try
            {

                string date, time, OutVoucher, Outremark, purvoc, barcode, goldtype, gold_price, items, itemname,
                gm, k, p, y, s, wk, wp, wy, ws, totalk, totalp, totaly, totals, mcost, repamt, totalamt, remark,
                 employee, shop, form, type;

                date = txt_date.Text; time = txt_time.Text;
                OutVoucher = txt_outvoucher.Text; Outremark = txt_outremark.Text;
                employee = Form2.setvalueemployee;
                shop = login.shopvalue;
                form = txt_form.Text;
                type = txt_counter.Text;


                int no = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(store_data);


                newRow.Cells[1].Value = date;
                newRow.Cells[2].Value = time;
                newRow.Cells[3].Value = OutVoucher;
                newRow.Cells[4].Value = Outremark;
                newRow.Cells[5].Value = showdata.Rows[0].Cells[5].Value.ToString();
                newRow.Cells[6].Value = showdata.Rows[0].Cells[6].Value.ToString();
                newRow.Cells[7].Value = showdata.Rows[0].Cells[7].Value.ToString();
                newRow.Cells[8].Value = showdata.Rows[0].Cells[8].Value.ToString();
                newRow.Cells[9].Value = showdata.Rows[0].Cells[9].Value.ToString();
                newRow.Cells[10].Value = showdata.Rows[0].Cells[10].Value.ToString();
                newRow.Cells[11].Value = showdata.Rows[0].Cells[11].Value.ToString();
                newRow.Cells[12].Value = showdata.Rows[0].Cells[12].Value.ToString();
                newRow.Cells[13].Value = showdata.Rows[0].Cells[13].Value.ToString();
                newRow.Cells[14].Value = showdata.Rows[0].Cells[14].Value.ToString();
                newRow.Cells[15].Value = showdata.Rows[0].Cells[15].Value.ToString();
                newRow.Cells[16].Value = showdata.Rows[0].Cells[16].Value.ToString();
                newRow.Cells[17].Value = showdata.Rows[0].Cells[17].Value.ToString();
                newRow.Cells[18].Value = showdata.Rows[0].Cells[18].Value.ToString();
                newRow.Cells[19].Value = showdata.Rows[0].Cells[19].Value.ToString();
                newRow.Cells[20].Value = showdata.Rows[0].Cells[20].Value.ToString();
                newRow.Cells[21].Value = showdata.Rows[0].Cells[21].Value.ToString();
                newRow.Cells[22].Value = showdata.Rows[0].Cells[22].Value.ToString();
                newRow.Cells[23].Value = showdata.Rows[0].Cells[23].Value.ToString();
                newRow.Cells[24].Value = showdata.Rows[0].Cells[24].Value.ToString();
                newRow.Cells[25].Value = showdata.Rows[0].Cells[25].Value.ToString();
                newRow.Cells[26].Value = showdata.Rows[0].Cells[26].Value.ToString();
                newRow.Cells[27].Value = showdata.Rows[0].Cells[27].Value.ToString();
                newRow.Cells[28].Value = employee;
                newRow.Cells[29].Value = shop;
                newRow.Cells[30].Value = form;
                newRow.Cells[31].Value = type;

                store_data.Rows.Add(newRow);

                txt_out_no.Text = "";
                showdata.DataSource = null;
                Totalamt2();
                Totalgm2();
                Totalqty2();
                show_image.Image = null;

                if (show_image.Image != null)
                {

                    Image image = show_image.Image;
                    newRow.Cells[0].Value = image;

                }
            }

            catch
            {

            }
        }

        private void outproduct_btn_Click(object sender, EventArgs e)
        {
            timer2.Interval = 100;
            timer2.Start();

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            g_otherout g_Otherout = new g_otherout();
            g_Otherout.show();
        }
        

        
        private void preview_btn_Click(object sender, EventArgs e)
        {
            
            
            Form formbackground = new Form();
            try
            {

                using (preview frm = new preview())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .70d;
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.TopMost = true;
                    formbackground.Location = this.Location;
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();
                    frm.stdname = txt_form.Text;
                    frm.Owner = formbackground;                
                    frm.ShowDialog();
                    formbackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formbackground.Dispose(); }
        }
    }


}
