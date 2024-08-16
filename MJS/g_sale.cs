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
using System.IO;
using System.Globalization;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Windows.Documents;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;



namespace MJS
{

    public partial class g_sale : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        SqlCommand cmd, cmd2, cmd3,cmd4;
        SqlDataAdapter adpt;
        DataTable dt;
        DataSet ds;
        string sql, sql2, sql3;
        public g_sale()
        {
            InitializeComponent();
            
        }
        private void g_sale_Load(object sender, EventArgs e)
        {
            txt_shop.Text = login.shopvalue;
            counter();
            getselling_percent();
            if (txt_goldprice.Text == "")
            {
                txt_goldprice.Text = "0";
                txt_goldprice.Text = "0";
                txt_goldprice.SelectionStart = 0;
                txt_goldprice.SelectionLength = txt_goldprice.Text.Length;
            }
            /*getgoldprice();*/

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
                    MessageBox.Show("Internet Connection Success");
                }
                else
                {
                    MessageBox.Show("Check Your Internet Connection");
                    this.Enabled = false;
                    this.BackColor = System.Drawing.Color.GhostWhite;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_date.Text = d.ToString("dd/MMM/yyyy");
            txt_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_BB_Click(object sender, EventArgs e)
        {
            Form formbackground = new Form();
            try
            {
                using (BB_Form bB_Form = new BB_Form())
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

                    bB_Form.Owner = formbackground;
                    bB_Form.ShowDialog();

                    formbackground.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { formbackground.Dispose(); }


        }
/*-----------------------------------------------------------------------------------------------*/
        private bool rowadded=false;
        private void adddata_datagriview() 
        {

           /* if (double.Parse(txt_salegm.Text) < double.Parse(result_gm.Text)) 
            {
                MessageBox.Show("Please Check Selling Price");
            }*/
            if (!rowadded)
            {

                string shop = login.shopvalue;
                string empolyee = "";
                empolyee = Form2.setvalueemployee;
                dgv_show_saledata.Rows.Add(txt_date.Text, txt_time.Text, txt_out_no.Text, txt_goldprice.Text, label_Item.Text, label_itemname.Text, txt_total_qty.Text, label_gm.Text, label_goldtype.Text, txt_total_gm.Text,
                    txt_k.Text, txt_p.Text, txt_y.Text, txt_s.Text, txt_WK.Text, txt_WP.Text, txt_WY.Text, txt_WS.Text, total_K.Text, total_P.Text, total_Y.Text, total_S.Text,
                    txt_mcost.Text, txt_gpd.Text, txt_totalamt.Text, txt_bbamt.Text, txt_include_bbamt.Text, txt_pernumber.Text, txt_percent_amt.Text, txt_include_percent.Text, txt_pro_number.Text,
                    txt_pro_amt.Text, txt_pro_famt.Text, txt_alltotal_amt.Text, txt_discount.Text, txt_totalcost.Text, txt_saleremark.Text, empolyee, shop, txt_form.Text, txt_counter.Text);

                rowadded = true;
            }
            else
            {
                string shop2 = login.shopvalue;
                string empolyee2 = "";
                empolyee2 = Form2.setvalueemployee;

                dgv_show_saledata.Rows[0].Cells[0].Value = txt_date.Text;
                dgv_show_saledata.Rows[0].Cells[1].Value = txt_time.Text;
                dgv_show_saledata.Rows[0].Cells[2].Value = txt_out_no.Text;
                dgv_show_saledata.Rows[0].Cells[3].Value = label_Item.Text;
                dgv_show_saledata.Rows[0].Cells[4].Value = label_itemname.Text;
                dgv_show_saledata.Rows[0].Cells[5].Value = txt_total_qty.Text;
                dgv_show_saledata.Rows[0].Cells[6].Value = txt_total_gm.Text;
                dgv_show_saledata.Rows[0].Cells[7].Value = txt_goldprice.Text;
                dgv_show_saledata.Rows[0].Cells[8].Value = label_goldtype.Text;
                dgv_show_saledata.Rows[0].Cells[9].Value = txt_k.Text;
                dgv_show_saledata.Rows[0].Cells[10].Value = txt_p.Text;
                dgv_show_saledata.Rows[0].Cells[11].Value = txt_y.Text;
                dgv_show_saledata.Rows[0].Cells[12].Value = txt_s.Text;
                dgv_show_saledata.Rows[0].Cells[13].Value = txt_WK.Text;
                dgv_show_saledata.Rows[0].Cells[14].Value = txt_WP.Text;
                dgv_show_saledata.Rows[0].Cells[15].Value = txt_WY.Text;
                dgv_show_saledata.Rows[0].Cells[16].Value = txt_WS.Text;
                dgv_show_saledata.Rows[0].Cells[17].Value = total_K.Text;
                dgv_show_saledata.Rows[0].Cells[18].Value = total_P.Text;
                dgv_show_saledata.Rows[0].Cells[19].Value = total_Y.Text;
                dgv_show_saledata.Rows[0].Cells[20].Value = total_S.Text;
                dgv_show_saledata.Rows[0].Cells[21].Value = txt_mcost.Text;
                dgv_show_saledata.Rows[0].Cells[22].Value = txt_gpd.Text;
                dgv_show_saledata.Rows[0].Cells[23].Value = txt_totalamt.Text;
                dgv_show_saledata.Rows[0].Cells[24].Value = txt_bbamt.Text;
                dgv_show_saledata.Rows[0].Cells[25].Value = txt_include_bbamt.Text;
                dgv_show_saledata.Rows[0].Cells[26].Value = txt_pernumber.Text;
                dgv_show_saledata.Rows[0].Cells[27].Value = txt_percent_amt.Text;
                dgv_show_saledata.Rows[0].Cells[28].Value = txt_include_percent.Text;
                dgv_show_saledata.Rows[0].Cells[29].Value = txt_pro_number.Text;
                dgv_show_saledata.Rows[0].Cells[30].Value = txt_pro_amt.Text;
                dgv_show_saledata.Rows[0].Cells[31].Value = txt_pro_famt.Text;
                dgv_show_saledata.Rows[0].Cells[32].Value = txt_alltotal_amt.Text;
                dgv_show_saledata.Rows[0].Cells[33].Value = txt_discount.Text;
                dgv_show_saledata.Rows[0].Cells[34].Value = txt_totalcost.Text;
                dgv_show_saledata.Rows[0].Cells[35].Value = txt_saleremark.Text;
                dgv_show_saledata.Rows[0].Cells[36].Value = empolyee2;
                dgv_show_saledata.Rows[0].Cells[37].Value = shop2;
                dgv_show_saledata.Rows[0].Cells[38].Value = txt_form.Text;
                dgv_show_saledata.Rows[0].Cells[39].Value = txt_counter.Text;

            } 
        }
/*------------------------------------------------------------------------------------------------*/

        private DataTable GetDataTableFromDataGridView(DataGridView dgv)
        {
                DataTable dt = new DataTable();

                // Add columns to DataTable.
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                Type columnType = column.ValueType ?? typeof(string); // Use string as the default type if ValueType is null

                // Handle image columns
                if (columnType == typeof(Image))
                {
                    columnType = typeof(byte[]);
                }

                dt.Columns.Add(column.HeaderText, columnType);
                }

                // Add rows to DataTable.
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                        object value = row.Cells[i].Value;

                        // Convert images to byte arrays
                        if (value is Image img)
                        {
                            value = ImageToByteArray(img);
                        }

                        dr[i] = row.Cells[i].Value ?? DBNull.Value;
                        }
                        dt.Rows.Add(dr);
                    }
                }

                return dt;
            }
        private DataTable GetDataTableForTDP(DataGridView dgv)
        {
            DataTable dt2 = new DataTable();

            // Add columns to DataTable.
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                Type columnType = column.ValueType ?? typeof(string); // Use string as the default type if ValueType is null

                dt2.Columns.Add(column.HeaderText, columnType);
            }

            // Add rows to DataTable.
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = dt2.NewRow();
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        object value = row.Cells[i].Value;

                     

                        dr[i] = row.Cells[i].Value ?? DBNull.Value;
                    }
                    dt2.Rows.Add(dr);
                }
            }

            return dt2;
        }


        // Convert Image to byte array
        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }



        private void btn_cash_Click(object sender, EventArgs e)
        {
            adddata_datagriview();
            DataTable dt = GetDataTableFromDataGridView(dgv_show_saledata);
            DataTable dt2 = GetDataTableForTDP(dgv_showdata);
           

            if (double.TryParse(txt_totalcost.Text, out double number))
            {


                Form formbackground = new Form();
                try
                {
                    using (payment_form pay_Form = new payment_form(dt, dt2))
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
                        /* DataTable dt = GetDataTableFromDataGridView(dgv_show_saledata);*/                    
                        pay_Form.SetValue(number);
                        pay_Form.Owner = formbackground;                  
                        pay_Form.ShowDialog();
                        
                        formbackground.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { formbackground.Dispose(); }
            }
            else
            {
                MessageBox.Show("မှားယွင်းနေပါသည်။");
            }

           
        }

       
        /* private int sumqty = 0;
         private void totalqty()
         {
             if (int.TryParse(label_qty.Text, out int value)) 
             {
                 sumqty += value;
                 txt_total_qty.Text = sumqty.ToString();

             }
         }
         private decimal sumgm = 0;
         private void totalgm()
         {
             if (decimal.TryParse(label_gm.Text, out decimal gm))
             {
                 sumgm += gm;
                 txt_total_gm.Text = sumgm.ToString();

             }
         }*/
        public void TotalGm()
        {
            /* decimal gm = 0;
             for (int i = 0; i < dgv_showdata.Rows.Count; ++i)
             {
                 gm += Convert.ToDecimal(dgv_showdata.Rows[i].Cells[3].Value);
                 txt_total_gm.Text = gm.ToString();
             }*/

            decimal sum = 0;

            foreach (DataGridViewRow row in dgv_showdata.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal value))
                    {
                        sum += value;
                    }
                }
            }

            txt_total_gm.Text =  sum.ToString();
        }

        public void TotalQty()
        {
            txt_total_qty.Text = dgv_showdata.Rows.Count.ToString();
        }

        public void getgoldprice()
        {
            try 
            {
                con.Close();
                if (label_goldtype.Text != "")
                {
                    con.Open();
                    string goldpricevalue = label_goldtype.Text;
                    string query = "SELECT Top(1) Purchase_Gold_Price FROM goldprice where Gold_Type=@goldtype ORDER BY ID DESC";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@goldtype", goldpricevalue);

                    using (SqlDataReader gp2 = cmd.ExecuteReader())
                    {
                        if (gp2.Read())
                        {

                            txt_goldprice.Text = gp2.GetValue(0).ToString();
                            txt_goldprice.Text = string.Format("{0:n0}", double.Parse(txt_goldprice.Text));
                        }
                    }

                    con.Close();
                }

            }
            catch(Exception ex) { MessageBox.Show("An error occurred:" + ex.Message); }
           
        }

        private int clickCount = 0;
        private void edit_goldprice_btn_Click(object sender, EventArgs e)
        {
            clickCount++;

            // Toggle TextBox enabled state based on the click count
            if (clickCount % 2 == 1)
            {
                // Enable TextBox on odd clicks
                txt_goldprice.Enabled = true;
            }
            else
            {
                // Disable TextBox on even clicks
                txt_goldprice.Enabled = false;
            }

        }

        private Bitmap memoryImage;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
       
        public void counter()/*function counter */
        {
            string sqlquery = "select * from counter";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_counter.Text = reader["Gold"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    
        private void iconButton1_Click(object sender, EventArgs e)
        {
           /* PrintScreen();
            printPreviewDialog1.ShowDialog();*/
           /* timer2.Interval = 200;
            timer2.Start();*/
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            outvoucher outvoucher = new outvoucher();
            outvoucher.ShowDialog();
        }
        public void calculategm()/*function claculation TOTAL AMOUNT*/
        {
            double intk, intp, inty, ints, tk, tp, ty, ts, totalK, totalP, totalY, totalS, resultP, resultP2, resultP3, resultP4,
                resultY, resultY2, resultY3, resultY4, resultS, resultS2, resultS3, resultS4, T_wastageK, T_wastageP,
                T_wastageY, T_wastageS, wastageamount, mcost, reploss, totalamt,bbamt,include_bbamt,percent,percentamt,include_percentamt,dicountamt,totalcost = 0;
            string chks = "0";
            string svalue = "0";
            double gm = 0;
            /*---------------------- Gm To KPY Method------------------------*/
            if (txt_gm.Text == "")
            {
                txt_s.Text = "0";
                txt_gm.Text = "0";
                txt_gm.SelectionStart = 0;
                txt_gm.SelectionLength = txt_gm.Text.Length;
            }
            if (txt_mcost.Text == "")
            {
                txt_mcost.Text = "0";
                txt_mcost.SelectionStart = 0;
                txt_mcost.SelectionLength = txt_mcost.Text.Length;
            }
            if (txt_gpd.Text == "")
            {
                txt_gpd.Text = "0";
                txt_gpd.SelectionStart = 0;
                txt_gpd.SelectionLength = txt_gpd.Text.Length;
            }
            if (txt_WK.Text == "")
            {
                txt_WK.Text = "0";
                txt_WK.SelectionStart = 0;
                txt_WK.SelectionLength = txt_WK.Text.Length;
            }
            if (txt_WP.Text == "")
            {
                txt_WP.Text = "0";
                txt_WP.SelectionStart = 0;
                txt_WP.SelectionLength = txt_WP.Text.Length;
            }
            if (txt_WY.Text == "")
            {
                txt_WY.Text = "0";
                txt_WY.SelectionStart = 0;
                txt_WY.SelectionLength = txt_WY.Text.Length;
            }
            if (txt_WS.Text == "")
            {
                txt_WS.Text = "0";
                txt_WS.SelectionStart = 0;
                txt_WS.SelectionLength = txt_WS.Text.Length;
            }
            if (txt_percent_amt.Text == "")
            {
                txt_percent_amt.Text = "0";
                txt_percent_amt.SelectionStart = 0;
                txt_percent_amt.SelectionLength = txt_percent_amt.Text.Length;
            }
            if (txt_pernumber.Text == "")
            {
                txt_pernumber.Text = "0";
                txt_pernumber.SelectionStart = 0;
                txt_pernumber.SelectionLength = txt_pernumber.Text.Length;

            }
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
                txt_discount.SelectionStart = 0;
                txt_discount.SelectionLength = txt_discount.Text.Length;
            }
            
            intk = Math.Floor(double.Parse(txt_gm.Text) / double.Parse("16.6"));
            tk = double.Parse(txt_gm.Text) / double.Parse("16.6");
            txt_k.Text = intk.ToString();

            tp = (tk - intk) * 16;
            intp = Math.Floor((tk - intk) * 16);
            txt_p.Text = intp.ToString();

            ty = (tp - intp) * 8;
            inty = Math.Floor((tp - intp) * 8);
            txt_y.Text = inty.ToString();

            ts = ty - inty;
            chks = ts.ToString("0.##");
            if (double.Parse(chks) >= 0.25 && double.Parse(chks) <= 0.49)
            {
                txt_s.Text = "1";

            }
            else if (double.Parse(chks) >= 0.50 && double.Parse(chks) <= 0.74)
            {
                txt_s.Text = "2";

            }
            else if (double.Parse(chks) >= 0.75 && double.Parse(chks) <= 0.9)
            {
                txt_s.Text = "3";

            }
            else if (double.Parse(chks) >= 0.9 && double.Parse(chks) <= 1)
            {
                txt_s.Text = "0";
                txt_y.Text = (inty + 1).ToString();
            }
            else
            {
                if (double.Parse(chks) < 0.25)
                {
                    txt_s.Text = "0";

                }
            }
            /*---------------------- Total KPYS Method------------------------*/

            if (txt_WK.Text != "" || txt_WK.Text != "0" || txt_WP.Text != "" || txt_WP.Text != "0" || txt_WY.Text != "" || txt_WY.Text != "0" || txt_WS.Text != "" || txt_WS.Text != "0")
            {
                if (txt_WK.Text != "")
                {
                    double sumK1 = double.Parse(txt_k.Text);
                    double sumK2 = double.Parse(txt_WK.Text);
                    totalK = sumK1 + sumK2;
                    total_K.Text = totalK.ToString();
                    T_wastageK = double.Parse(total_K.Text);
                }

                if (txt_WP.Text != "")
                {
                    totalP = double.Parse(txt_p.Text) + double.Parse(txt_WP.Text);
                    if (totalP >= 16)
                    {
                        resultP = Math.Floor(totalP / 16);
                        resultP2 = totalP / 16;
                        resultP3 = Math.Floor((resultP2 - resultP) * 16);
                        resultP4 = double.Parse(total_K.Text) + resultP;
                        total_P.Text = resultP3.ToString();
                        total_K.Text = resultP4.ToString();
                        T_wastageP = double.Parse(total_P.Text);
                        T_wastageK = double.Parse(total_K.Text);
                    }
                    else
                    {
                        total_P.Text = totalP.ToString();
                        T_wastageP = double.Parse(total_P.Text);
                    }
                }

                if (txt_WY.Text != "")
                {
                    totalY = double.Parse(txt_y.Text) + double.Parse(txt_WY.Text);
                    if (totalY >= 8)
                    {
                        resultY = Math.Floor(totalY / 8);
                        resultY2 = totalY / 8;
                        resultY3 = Math.Floor((resultY2 - resultY) * 8);
                        resultY4 = double.Parse(total_P.Text) + resultY;
                        total_Y.Text = resultY3.ToString();
                        total_P.Text = resultY4.ToString();
                        T_wastageY = double.Parse(total_Y.Text);
                        T_wastageP = double.Parse(total_P.Text);
                    }
                    else
                    {
                        total_Y.Text = totalY.ToString();
                        T_wastageY = double.Parse(total_Y.Text);
                    }
                }

                if (txt_WS.Text != "")
                {
                    totalS = double.Parse(txt_s.Text) + double.Parse(txt_WS.Text);
                    if (totalS >= 4)
                    {
                        resultS = Math.Floor(totalS / 4);
                        resultS2 = totalS / 4;
                        resultS3 = Math.Floor((resultS2 - resultS) * 4);
                        resultS4 = double.Parse(total_Y.Text) + resultS;
                        total_S.Text = resultS3.ToString();
                        total_Y.Text = resultS4.ToString();
                        T_wastageS = double.Parse(total_S.Text);
                        T_wastageY = double.Parse(total_Y.Text);
                    }
                    else
                    {
                        total_S.Text = totalS.ToString();
                        T_wastageS = double.Parse(total_S.Text);
                    }
                }
            }
            /*------------------------------------------------Total Amount------------------------------------------------*/
            if (total_K.Text != "" && total_P.Text != "" && total_Y.Text != "" && total_S.Text != "")
            {

                T_wastageK = double.Parse(total_K.Text); T_wastageP = double.Parse(total_P.Text);
                T_wastageY = double.Parse(total_Y.Text); T_wastageS = double.Parse(total_S.Text);
                mcost = double.Parse(txt_mcost.Text); reploss = double.Parse(txt_gpd.Text);
                bbamt= double.Parse(txt_bbamt.Text);include_bbamt=double.Parse(txt_include_bbamt.Text);
                percentamt=double.Parse(txt_percent_amt.Text);include_percentamt=double.Parse(txt_include_percent.Text);
                dicountamt = double.Parse(txt_discount.Text);totalcost= double.Parse(txt_alltotal_amt.Text);
                percent = double.Parse(txt_pernumber.Text);

                wastageamount = Math.Round(((((T_wastageS / 4) + T_wastageY) / 8 + T_wastageP) / 16 + T_wastageK) * double.Parse(txt_goldprice.Text));
                
                totalamt = (wastageamount + mcost) + reploss;
                txt_totalamt.Text = totalamt.ToString();
                include_bbamt = (totalamt + bbamt);
                txt_include_bbamt.Text = include_bbamt.ToString();

                
                percentamt = Math.Round(include_bbamt / 100) * percent;
                txt_percent_amt.Text = percentamt.ToString();

                include_percentamt = include_bbamt+percentamt;
                txt_include_percent.Text = include_percentamt.ToString();
                totalcost = include_percentamt - dicountamt;
                txt_alltotal_amt.Text = totalcost.ToString();

            }

        }

        private void txt_gm_TextChanged(object sender, EventArgs e)
        {
            calculategm();
        }

        private void txt_WK_TextChanged(object sender, EventArgs e)
        {
            calculategm();
           
        }

        private void txt_WP_TextChanged(object sender, EventArgs e)
        {
            double p = 16;
            if (txt_WP.Text == "")
            {
                txt_WP.Text = "";

            }
            else if (double.Parse(txt_WP.Text) > p)
            {
                MessageBox.Show(" အလျော့တွက် 16 \"ပဲ\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WP.Text = "0";
                txt_WP.SelectionStart = 0;
                txt_WP.SelectionLength = txt_WP.Text.Length;
            }
            calculategm();
          
        }

        private void txt_WY_TextChanged(object sender, EventArgs e)
        {
            double p = 8;
            if (txt_WY.Text == "")
            {
                txt_WY.Text = "";

            }
            else if (double.Parse(txt_WY.Text) > p)
            {
                MessageBox.Show(" အလျော့တွက် 8 \"ရွေး\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WY.Text = "0";
                txt_WY.SelectionStart = 0;
                txt_WY.SelectionLength = txt_WY.Text.Length;
            }
            calculategm();
            
        }

        private void txt_WC_TextChanged(object sender, EventArgs e)
        {
            double p = 4;
            if (txt_WS.Text == "")
            {
                txt_WS.Text = "";

            }
            else if (double.Parse(txt_WS.Text) > p)
            {
                MessageBox.Show("အလျော့တွက် 4 \"စိတ်\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WS.Text = "0";
                txt_WS.SelectionStart = 0;
                txt_WS.SelectionLength = txt_WS.Text.Length;
            }
            calculategm();
            
        }

        private void txt_mcost_TextChanged(object sender, EventArgs e)
        {
            calculategm();
           
        }

        private void txt_rep_TextChanged(object sender, EventArgs e)
        {
            calculategm();
            
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
                txt_discount.SelectionStart = 0;
                txt_discount.SelectionLength = txt_discount.Text.Length;
            }
            double txttotalamt, discamt, minus = 0;
            txttotalamt = double.Parse(txt_alltotal_amt.Text);
            discamt=double.Parse(txt_discount.Text);
            minus = double.Parse(txt_totalcost.Text);
            minus = txttotalamt - discamt;
            txt_totalcost.Text = string.Format("{0:n0}", minus);

        }

        private void txt_pernumber_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_pernumber.Text == "")
            {
                txt_pernumber.Text = "0";
                txt_pernumber.SelectionStart = 0;
                txt_pernumber.SelectionLength = txt_pernumber.Text.Length;

            }

            double bbamt, pernumber = 0;
            bbamt=double.Parse(txt_include_bbamt.Text);
            pernumber = double.Parse(txt_pernumber.Text);

            txt_percent_amt.Text = Math.Round((bbamt/100)*pernumber).ToString();
        }

        private void txt_percent_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_percent_amt.Text == "")
            {
                txt_percent_amt.Text = "0";
                txt_percent_amt.SelectionStart = 0;
                txt_percent_amt.SelectionLength = txt_percent_amt.Text.Length;
            }

            double bbamt2, percentamt,sum = 0;
            bbamt2 = double.Parse(txt_include_bbamt.Text);
            percentamt = double.Parse(txt_percent_amt.Text);
            sum = double.Parse(txt_include_percent.Text);
            sum=bbamt2+percentamt;
            txt_include_percent.Text = sum.ToString();
            
        }

        private void txt_pro_number_TextChanged(object sender, EventArgs e)
        {
            if (txt_pro_number.Text == "")
            {
                txt_pro_number.Text = "0";
                txt_pro_number.SelectionStart = 0;
                txt_pro_number.SelectionLength = txt_pro_number.Text.Length;

            }

            double bbamt, pronumber = 0;
            bbamt = double.Parse(txt_include_bbamt.Text);
            pronumber = double.Parse(txt_pro_number.Text);

            txt_pro_amt.Text = Math.Round((bbamt / 100) * pronumber).ToString();
        }

        private void txt_pro_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_pro_amt.Text == "")
            {
                txt_pro_amt.Text = "0";
                txt_pro_amt.SelectionStart = 0;
                txt_pro_amt.SelectionLength = txt_pro_amt.Text.Length;

            }
            double pro_peramt, Pro_flatamt,includeperamt,calculate = 0;
            pro_peramt = double.Parse(txt_pro_amt.Text);
            Pro_flatamt = double.Parse(txt_pro_famt.Text);
            includeperamt=double.Parse(txt_include_percent.Text);
            calculate = includeperamt-(pro_peramt+Pro_flatamt);
            txt_alltotal_amt.Text = calculate.ToString();
            
        }

        private void txt_pro_famt_TextChanged(object sender, EventArgs e)
        {
            if (txt_pro_famt.Text == "")
            {
                txt_pro_famt.Text = "0";
                txt_pro_famt.SelectionStart = 0;
                txt_pro_famt.SelectionLength = txt_pro_famt.Text.Length;
            }
            double pro_peramt, Pro_flatamt, includeperamt, calculate = 0;
            pro_peramt = double.Parse(txt_pro_amt.Text);
            Pro_flatamt = double.Parse(txt_pro_famt.Text);
            includeperamt = double.Parse(txt_include_percent.Text);
            calculate = includeperamt-(pro_peramt + Pro_flatamt);
            txt_alltotal_amt.Text = calculate.ToString();
            
        }

        private void txt_include_percent_TextChanged(object sender, EventArgs e)
        {
            if (txt_include_percent.Text == "")
            {
                txt_include_percent.Text = "0";
                txt_include_percent.SelectionStart = 0;
                txt_include_percent.SelectionLength = txt_include_percent.Text.Length;
            }
            double pro_peramt, Pro_flatamt, includeperamt, calculate = 0;
            pro_peramt = double.Parse(txt_pro_amt.Text);
            Pro_flatamt = double.Parse(txt_pro_famt.Text);
            includeperamt = double.Parse(txt_include_percent.Text);
            calculate = includeperamt-(pro_peramt + Pro_flatamt) ;
            txt_alltotal_amt.Text = calculate.ToString();
            txt_include_percent.Text = string.Format("{0:n0}", double.Parse(txt_include_percent.Text));
        }

        private void txt_alltotal_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_alltotal_amt.Text == "")
            {
                txt_alltotal_amt.Text = "0";
                txt_alltotal_amt.SelectionStart = 0;
                txt_alltotal_amt.SelectionLength = txt_alltotal_amt.Text.Length;
            }
            double txttotalamt, discamt, minus = 0;
            txttotalamt = double.Parse(txt_alltotal_amt.Text);
            discamt = double.Parse(txt_discount.Text);
            minus = double.Parse(txt_totalcost.Text);
            minus = txttotalamt - discamt;
            txt_totalcost.Text = minus.ToString();
            txt_alltotal_amt.Text = string.Format("{0:n0}", double.Parse(txt_alltotal_amt.Text));
        }

        private void txt_totalcost_TextChanged(object sender, EventArgs e)
        {          
            txt_showamt.Text = txt_totalcost.Text;
            /*txt_showamt.Text = string.Format("{0:n0}", double.Parse(txt_showamt.Text) +" "+ "Ks");*/
            txt_showamt.Text = string.Format("{0:n0}", double.Parse(txt_showamt.Text))+" "+"Ks";
        }

        private void txt_totalamt_TextChanged(object sender, EventArgs e)
        {
            txt_totalamt.Text = string.Format("{0:n0}", double.Parse(txt_totalamt.Text));
        }

        private void txt_bbamt_TextChanged(object sender, EventArgs e)
        {
            txt_bbamt.Text = string.Format("{0:n0}", double.Parse(txt_bbamt.Text));
        }

        private void txt_include_bbamt_TextChanged(object sender, EventArgs e)
        {
            txt_include_bbamt.Text = string.Format("{0:n0}", double.Parse(txt_include_bbamt.Text));
        }

        private void txt_mcost_Leave(object sender, EventArgs e)
        {
            txt_mcost.Text = string.Format("{0:n0}", double.Parse(txt_mcost.Text));
        }

        private void txt_rep_Leave(object sender, EventArgs e)
        {
            txt_gpd.Text = string.Format("{0:n0}", double.Parse(txt_gpd.Text));
        }

        private void txt_percent_amt_Leave(object sender, EventArgs e)
        {
            txt_percent_amt.Text = string.Format("{0:n0}", double.Parse(txt_percent_amt.Text));
        }

        private void txt_pro_amt_Leave(object sender, EventArgs e)
        {
            txt_pro_amt.Text = string.Format("{0:n0}", double.Parse(txt_pro_amt.Text));
        }
        int pic = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            pic *= -1;
            if (pic == -1)
            {
                Bitmap a= new Bitmap(@"D:\MJS_Cloud_Application\MJS\Properties\down_arrow.png");
                button2.BackgroundImage = a;
            }
            else
            {
                Bitmap b = new Bitmap(@"D:\MJS_Cloud_Application\MJS\Properties\up-arrow.png");
                button2.BackgroundImage = b;
            }
            TogglePanelVisibility();
        }

        private void TogglePanelVisibility()
        {
            panel2.Visible = !panel2.Visible;

            // Optionally adjust the layout of other controls
            if (panel2.Visible)
            {
                // Make space for the panel
                panel3.Top = panel2.Bottom+10; // Adjust as necessary
            }
            else
            {
                // Remove the space occupied by the panel
                panel3.Top = panel2.Top; // Adjust as necessary
            }
        }
        private void txt_pro_famt_Leave(object sender, EventArgs e)
        {
            txt_pro_famt.Text = string.Format("{0:n0}", double.Parse(txt_pro_famt.Text));
        }
       
        private void minimum_price_calculate() 
        {
            double txtsk, txtsp, txtsy, txtss, txt_minimum_per, txt_result_gm, result = 0;
            double gm = 16.6;

            txtsk =double.Parse(txt_sk.Text);txtsp=double.Parse(txt_sp.Text);txtsy=double.Parse(txt_sy.Text);txtss=double.Parse(txt_ss.Text);
            txt_minimum_per=double.Parse(txt_mini_percent.Text);
           
           
            result =  (((((txtss / 4) + txtsy) / 8 + txtsp) / 16 + txtsk) * gm)*txt_minimum_per;
           
            txt_result_sum.Text = result.ToString("F2");


        }

        private void minimum_price_check()
        {
            double txtWK, txtWP, txtWY, txtWC, txt_minimum_per, txt_result_gm, result2 = 0;
            double gm = 16.6;

            txtWK = double.Parse(txt_WK.Text); txtWP = double.Parse(txt_WP.Text); txtWY = double.Parse(txt_WY.Text); txtWC = double.Parse(txt_WS.Text);
            txt_minimum_per = double.Parse(txt_mini_percent.Text);

            result2 = ((((txtWC / 4) + txtWY) / 8 + txtWP) / 16 + txtWK) * gm;      
            txt_salegm.Text = result2.ToString("F2");
            if (double.Parse(txt_salegm.Text) < double.Parse(result_gm.Text))
            {
                txt_mcost.Enabled = false;
                txt_gpd.Enabled = false;
                txt_pernumber.Enabled = false;
                txt_percent_amt.Enabled = false;
                txt_pro_number.Enabled = false;
                txt_pro_amt.Enabled = false;
                txt_pro_famt.Enabled = false;
                txt_discount.Enabled = false;
                txt_saleremark.Enabled = false;
                btn_gsale_save.Enabled = false;
                btn_review.Enabled = false;
                Btn_BB.Enabled = false;
                btn_cash.Enabled = false;


                MessageBox.Show("‌ေရောင်းစျေးလျော့နည်းနေပါသည်။ခွင့်ပြုချက်လိုအပ်ပါသည်။");

                
            }
            else
            {
                txt_mcost.Enabled = true;
                txt_gpd.Enabled =true;
                txt_pernumber.Enabled = true;
                txt_percent_amt.Enabled = true;
                txt_pro_number.Enabled = true;
                txt_pro_amt.Enabled = true;
                txt_pro_famt.Enabled = true;
                txt_discount.Enabled = true;
                txt_saleremark.Enabled = true;
                btn_gsale_save.Enabled = true;
                btn_review.Enabled = true;
                Btn_BB.Enabled = true;
                btn_cash.Enabled = true;

            }

        }


        private void txt_sk_TextChanged(object sender, EventArgs e)
        {
            minimum_price_calculate();
           
        }

        private void txt_sp_TextChanged(object sender, EventArgs e)
        {
            minimum_price_calculate();

        }

        private void txt_sy_TextChanged(object sender, EventArgs e)
        {
            minimum_price_calculate();

        }

        private void txt_ss_TextChanged(object sender, EventArgs e)
        {
            minimum_price_calculate();

        }

        private void dgv_showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgv_showdata.Rows.RemoveAt(e.RowIndex);
                    TotalQty();
                    TotalGm();
                }
            }
        }



        private void wastage_panel_Leave(object sender, EventArgs e)
        {
            minimum_price_check();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }


        private void txt_result_sum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_WK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_WP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_WY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_WS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_mcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_gpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_pernumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_percent_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_pro_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_pro_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_pro_famt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_gm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_gm_Leave(object sender, EventArgs e)
        {
            if (txt_gm.Text == "0" || txt_gm.Text == "") 
            {
                MessageBox.Show("Gm ထည့်ရန်လိုအပ်ပါသည်.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gm.Focus();
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
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

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            txt_discount.Text = string.Format("{0:n0}", double.Parse(txt_discount.Text));
        }

        private void label_goldtype_TextChanged(object sender, EventArgs e)
        {
            getgoldprice();
        }

        private void getselling_percent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Selling_Price FROM setting ORDER BY ID DESC", con);
   
            using (SqlDataReader da = cmd.ExecuteReader())
            {
               
               if (da.Read())
                {
                    txt_mini_percent.Text = da.GetValue(0).ToString();
                  
                }
               con.Close();
            }
        }
        private void addRow(string productid,string item, string itemname, string qty, string gm)
        {
            string[] row = {productid,item,itemname,qty,gm };
            dgv_showdata.Rows.Add(row);

           
        }
        private void txt_out_no_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_showdata.Rows.Count; i++)
            {
                if (txt_out_no.Text == dgv_showdata.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Already have ProductID insert!");
                    return;
                }
            }

            try
            {

                if (txt_out_no.Text != "")
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Select Image_TB.Image ,closing_stock.SK," +
                        "closing_stock.SP,closing_stock.SY,closing_stock.SS,closing_stock.Item," +
                        "closing_stock.Itemname,closing_stock.Gm,closing_stock.GoldType FROM closing_stock INNER JOIN Image_TB ON closing_stock.ProductID = Image_TB.ProductID where closing_stock.ProductID=@ProductID", con);

                    cmd.Parameters.AddWithValue("@ProductID", txt_out_no.Text);
                    using (SqlDataReader da = cmd.ExecuteReader())
                    {
                        byte[] imagedata = null;

                        if (da.Read())
                        {

                            imagedata = (byte[])da.GetValue(0);
                            txt_sk.Text = da.GetValue(1).ToString();
                            txt_sp.Text = da.GetValue(2).ToString();
                            txt_sy.Text = da.GetValue(3).ToString();
                            txt_ss.Text = da.GetValue(4).ToString();
                            label_Item.Text = da.GetValue(5).ToString();
                            label_itemname.Text = da.GetValue(6).ToString();
                            label_gm.Text = da.GetValue(7).ToString();
                            label_goldtype.Text = da.GetValue(8).ToString();
                            label_qty.Text = "1";
                            addRow(txt_out_no.Text, label_Item.Text, label_itemname.Text, label_qty.Text, label_gm.Text);
                            /*totalqty();
                            totalgm();*/
                            TotalGm();
                            TotalQty();


                            dataGridView2.Rows.Add(txt_result_sum.Text);
                            decimal amt = 0;
                            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                            {
                                amt += Convert.ToDecimal(dataGridView2.Rows[i].Cells[0].Value);
                                result_gm.Text = amt.ToString();
                            }


                        }
                        else
                        {
                            MessageBox.Show("No Data Found.");
                            pit_show.Image = null;
                            label_Item.Text = "";
                            label_itemname.Text = "";
                            label_gm.Text = "";
                            label_goldtype.Text = "";
                            label_qty.Text = "0";
                        }
                        /*da.Close();*/
                        
                        if (imagedata != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imagedata))
                            {
                                Image image = Image.FromStream(ms);

                                PictureBox pictureBox = new PictureBox();
                                pit_show.Image = image;
                            }
                        }
                        con.Close();
                    }

                }
                else
                {
                    pit_show.Image = null;
                    label_Item.Text = "";
                    label_itemname.Text = "";
                    label_gm.Text = "";
                    label_goldtype.Text = "";
                    label_qty.Text = "0";
                }

            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { MessageBox.Show("An error occurred:" + ex.Message); }

        }
    }
}
