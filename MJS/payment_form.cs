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
    public partial class payment_form : Form
    {

        public payment_form()
        {
            InitializeComponent();
        }
        public string payment { get; set; }
        private void payment_form_Load(object sender, EventArgs e)
        {
            cash_rdo_btn.Checked = true;
            txt_payment_amt.Text=payment;
            txt_dollar_rate.Text = "Currency Rate";
            txt_dollar_rate.ForeColor = Color.LightGray;
        }

        private void cash_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = true;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;

        }

        private void bank_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = true;
            Mobile_group.Visible = false;
        }

        private void foreign_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = true;
            Bank_group.Visible = false;
            Mobile_group.Visible = false;
        }

        private void MB_rdo_btn_Click(object sender, EventArgs e)
        {
            Cash_group.Visible = false;
            foreign_group.Visible = false;
            Bank_group.Visible = false;
            Mobile_group.Visible = true;
        }


        private void txt_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txt_dollar_rate_Leave(object sender, EventArgs e)
        {
            if (txt_dollar_rate.Text == "")
            {
                txt_dollar_rate.Text = "Currency Rate";
                txt_dollar_rate.ForeColor = Color.LightGray;
            }
        }

        private void txt_dollar_rate_Enter(object sender, EventArgs e)
        {
            if (txt_dollar_rate.Text == "Currency Rate")
            {
                txt_dollar_rate.Text = "";
                txt_dollar_rate.ForeColor = Color.Black;
            }
        }
    }
}
