using Krypton.Toolkit;
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


namespace MJS
{
    public partial class payment_form : Form
    {

        public payment_form(DataTable dt)
        {
            InitializeComponent();
            DataTable tableWithImages = ConvertDataTableWithImages(dt);
            PopulateDataGridViewWithImages(tableWithImages);
            /*dataGridView2.DataSource = dt;*/
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
            dataGridView2.Columns.Clear();
            dataGridView2.AutoGenerateColumns = false;

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
                    dataGridView2.Columns.Add(imgColumn);
                }
                else
                {
                    DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = column.ColumnName,
                        DataPropertyName = column.ColumnName
                    };
                    dataGridView2.Columns.Add(textColumn);
                }
            }

            dataGridView2.DataSource = dt;

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
        }

        private void cash_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = true;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;
            txt_show.Text = "Cash";

        }

        private void bank_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = true;
            Mobile_group.Visible = false;
            txt_show.Text = "Bank Card";
        }

        private void foreign_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = true;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;
            txt_show.Text = "Foreign Currency";
        }

        private void MB_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = true;
            txt_show.Text = "Mobile Banking";
        }


        private void txt_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_dollar_rate_Leave(object sender, EventArgs e)
        {
            if (txt_currency_rate.Text == "")
            {
                txt_currency_rate.Text = "Currency Rate";
                txt_currency_rate.ForeColor = Color.LightGray;
            }
        }

        private void txt_dollar_rate_Enter(object sender, EventArgs e)
        {
            if (txt_currency_rate.Text == "Currency Rate")
            {
                txt_currency_rate.Text = "";
                txt_currency_rate.ForeColor = Color.Black;
            }
        }

        private void txt_currency_amt_TextChanged(object sender, EventArgs e)
        {
            double rate=double.Parse(txt_currency_rate.Text);double cuc_amt=double.Parse(txt_currency_amt.Text);double value = 0;
            value=Math.Round( rate*cuc_amt);
            txt_exchange_amt.Text = value.ToString();
        }
  
        private void btn_payment_Click(object sender, EventArgs e)
        {
            

            if (txt_show.Text=="Cash")
            {
               
                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_cash_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = number1 - (number2 + number3);
                double sum=number2+number3;
                if (minus < 0)
                {

                    System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                }
                else 
                {
                    lbl_payment_amt.Text = sum.ToString();
                    lbl_outstanding_amt.Text = minus.ToString();
                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse( lbl_payment_amt.Text)) + " " + "Ks";
                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                    dgv_show_paymethod.Rows.Add(txt_show.Text, "Cash", txt_cash_amt.Text);
                    txt_cash_amt.Text = "";
                }
                
            }
            else if (txt_show.Text == "Foreign Currency")
            {
                
                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_exchange_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = number1 - (number2 + number3);
                double sum = number2 + number3;
                if (minus < 0)
                {

                    System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");
                }
                else
                {
                    lbl_payment_amt.Text = sum.ToString();
                    lbl_outstanding_amt.Text = minus.ToString();
                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse (lbl_outstanding_amt.Text)) + " " + "Ks";
                    dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_currenty_type.Text, txt_exchange_amt.Text, txt_currency_rate.Text);
                    txt_exchange_amt.Text = "";
                }

            }
            else if (txt_show.Text == "Bank Card")
            {
                
                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_bankcard_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = number1 - (number2 + number3);
                double sum = number2 + number3;
                if (minus < 0)
                {

                    System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                }
                else
                {
                    lbl_payment_amt.Text = sum.ToString();
                    lbl_outstanding_amt.Text = minus.ToString();
                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                    dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_cardtype.Text, txt_bankcard_amt.Text, "", txt_POS.Text);
                    txt_bankcard_amt.Text = "";
                }
                
            }
            else if (txt_show.Text == "Mobile Banking")
            {
               
                double.TryParse(txt_sale_amt.Text, out double number1); double.TryParse(txt_mobilebanking_amt.Text, out double number2); double.TryParse(lbl_payment_amt.Text, out double number3);

                double minus = number1 - (number2 + number3);
                double sum = number2 + number3;
                if (minus < 0)
                {

                    System.Windows.MessageBox.Show("ပစ္စည်းတန်ဖိုးကျသင့်ငွေထက်များနေပါသည်။");

                }
                else
                {
                    lbl_payment_amt.Text = sum.ToString();
                    lbl_outstanding_amt.Text = minus.ToString();
                    lbl_show_payment.Text = string.Format("{0:n0}", double.Parse(lbl_payment_amt.Text)) + " " + "Ks";
                    lbl_show_outstanding.Text = string.Format("{0:n0}", double.Parse(lbl_outstanding_amt.Text)) + " " + "Ks";
                    dgv_show_paymethod.Rows.Add(txt_show.Text, cmb_bankname.Text, txt_mobilebanking_amt.Text);
                    txt_mobilebanking_amt.Text = "";
                }
                
            }
            else
            {
                System.Windows.MessageBox.Show("ငွေပေးချေမှု့ မှားယွင်းနေပါသည်။");
            }
         

        }

    }
}
