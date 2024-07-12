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



namespace MJS
{

    public partial class g_sale : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        SqlCommand cmd, cmd2, cmd3;
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
            timer2.Interval = 200;
            timer2.Start();
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
                    invoiceid();
                    resetpid();
                    counter();

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
     
        private void btn_cash_Click(object sender, EventArgs e)
        {
            Form formbackground = new Form();
            try
            {
                using (payment_form pay_Form = new payment_form())
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
                    pay_Form.payment=txt_showamt.Text;
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
        private int sumqty = 0;
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
                    string query = "SELECT Top(1) Gold_Price FROM goldprice where Gold_Type=@goldtype ORDER BY ID DESC";
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
        public void invoiceid()/*function Invoice Number*/
        {

            try
            {
                /*if (Con1.State == ConnectionState.Closed)
                {
                    Con1.Open();
                }*/
                string shopvalue = txt_shop.Text;
                con.Open();
                sql = $"SELECT Sale_Voucher_No FROM g_sale WHERE Shop = @shoped ORDER BY ID DESC";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@shoped", shopvalue);
                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)

                {
                    string form = "GS";
                    /*string shop = login.shoptext;*/
                    string shop = login.shopvalue;
                    string date = DateTime.Now.ToString("ddMMyy");
                    string id = "0001";
                    txt_salevoc_number.Text = form + shop + date + "-" + id;

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
                        txt_salevoc_number.Text = autoid;

                    }

                }

                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        public void resetpid()/*function Reset Code Invoice and Product ID*/
        {
            string date = DateTime.Now.ToString("dd/MMM/yyyy");
            string serverdate = "0";
            string shopvalue = txt_shop.Text;
            string datevalue = "";
            con.Open();
            /*sql = "SELECT Date FROM reg_gold WHERE Shop = @shoped ORDER BY DAY(Date),MONTH(Date),YEAR(Date)";*/
            sql = $"SELECT Date FROM g_sale WHERE Shop = @shoped ORDER BY ID DESC";
            /*sql = $"SELECT Date FROM reg_gold WHERE Shop = @shoped And Date=@Date ";*/

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
               
                string form = "GR";
                string ivshop = login.shopvalue;
                string ivdate = DateTime.Now.ToString("ddMMyy");
                string ivid = "0001";
                txt_salevoc_number.Text = form + ivshop + ivdate + "-" + ivid;

                MessageBox.Show("Code Is Reset");

            }

            else

            {
               /* pid();*/

            }

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
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
            if (txt_rep.Text == "")
            {
                txt_rep.Text = "0";
                txt_rep.SelectionStart = 0;
                txt_rep.SelectionLength = txt_rep.Text.Length;
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
            if (txt_WC.Text == "")
            {
                txt_WC.Text = "0";
                txt_WC.SelectionStart = 0;
                txt_WC.SelectionLength = txt_WC.Text.Length;
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

            if (txt_WK.Text != "" || txt_WK.Text != "0" || txt_WP.Text != "" || txt_WP.Text != "0" || txt_WY.Text != "" || txt_WY.Text != "0" || txt_WC.Text != "" || txt_WC.Text != "0")
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

                if (txt_WC.Text != "")
                {
                    totalS = double.Parse(txt_s.Text) + double.Parse(txt_WC.Text);
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
                mcost = double.Parse(txt_mcost.Text); reploss = double.Parse(txt_rep.Text);
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
            if (txt_WC.Text == "")
            {
                txt_WC.Text = "";

            }
            else if (double.Parse(txt_WC.Text) > p)
            {
                MessageBox.Show("အလျော့တွက် 4 \"စိတ်\" နှင့်အထက် ဖြစ်နေပါသည်");
                txt_WC.Text = "0";
                txt_WC.SelectionStart = 0;
                txt_WC.SelectionLength = txt_WC.Text.Length;
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
            txt_totalcost.Text=minus.ToString();
            
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
            txt_rep.Text = string.Format("{0:n0}", double.Parse(txt_rep.Text));
        }

        private void txt_percent_amt_Leave(object sender, EventArgs e)
        {
            txt_percent_amt.Text = string.Format("{0:n0}", double.Parse(txt_percent_amt.Text));
        }

        private void txt_pro_amt_Leave(object sender, EventArgs e)
        {
            txt_pro_amt.Text = string.Format("{0:n0}", double.Parse(txt_pro_amt.Text));
        }

        

        private void txt_pro_famt_Leave(object sender, EventArgs e)
        {
            txt_pro_famt.Text = string.Format("{0:n0}", double.Parse(txt_pro_famt.Text));
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            txt_discount.Text = string.Format("{0:n0}", double.Parse(txt_discount.Text));
        }

        private void label_goldtype_TextChanged(object sender, EventArgs e)
        {
            getgoldprice();
        }

        private void txt_out_no_Leave(object sender, EventArgs e)
        {
            try
            {

                if (txt_out_no.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select Image,Item,Itemname,Gm,GoldType from closing_stock where ProductID=@ProductID", con);
                    cmd.Parameters.AddWithValue("@ProductID", txt_out_no.Text);
                    using (SqlDataReader da = cmd.ExecuteReader())
                    {
                        byte[] imagedata = null;

                        if (da.Read())
                        {

                            imagedata = (byte[])da.GetValue(0);
                            label_Item.Text = da.GetValue(1).ToString();
                            label_itemname.Text = da.GetValue(2).ToString();
                            label_gm.Text = da.GetValue(3).ToString();
                            label_goldtype.Text = da.GetValue(4).ToString();
                            label_qty.Text = "1";
                            totalqty();
                            totalgm();


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
            catch (Exception ex) { MessageBox.Show("An error occurred:" + ex.Message); }
        }
    }
}
