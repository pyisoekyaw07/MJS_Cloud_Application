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
using Microsoft.Identity.Client;
using System.Windows.Media.Animation;

namespace MJS
{
    public partial class Form2 : Form
    {
        private gform form2Instance;
        public Form2()
        {
            InitializeComponent();
        }
        private void movepanel(Control pan)
        {
            pan_line_home.Width = pan.Width;
            pan_line_home.Left = pan.Left;
        }
        public void formload(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.None;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            this.WindowState = FormWindowState.Maximized;

        }
        public static string setvalueemployee = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            /*  gold1.Hide();
              master1.Hide();*/
            /*this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            this.WindowState = FormWindowState.Maximized;
            /*formload(new wallpaper());*/
            panel1.Show();
            formload(new wallpaper());
            panel1.BackColor = Color.White;
            /*lbl_username.Text = login.username;*/
            setvalueemployee = lbl_username.Text;


        }


        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  gold1.Show();*/
            /* master1.Hide();*/
            formload(new gform());

        }
        private void otherOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formload(new g_otherout());
        }

        private void saleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formload(new g_sale());
        }


        /*-----------------Change language----------------------------------*/
        public static string setvalueformyan = "";

        private void radioButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ဘာသာစကားပြောင်းလဲရာတွင် သွင်းနေဆဲအချက်အလက်များ ပျောက်ဆုံးနိုင်ပါသည်။", "ဘာသာစကားပြောင်းလဲခြင်း", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setvalueformyan = "myanmar";
                gform.language = setvalueformyan;
                formload(new gform());
            }
            else if (dialogResult == DialogResult.No)
            {
                radioButton1.Checked = true;
            }

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Data being entered may be lost when changing the language.", "Change Language", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setvalueformyan = "eng";
                gform.language = setvalueformyan;
                formload(new gform());
            }
            else if (dialogResult == DialogResult.No)
            {
                radioButton2.Checked = true;
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login showlogin = new login();
            showlogin.Show();
        }
        public void homeclick()
        {
            panel1.Show();
            formload(new wallpaper());
            panel1.BackColor = Color.White;
            lbl_master.ForeColor = Color.FromArgb(167, 167, 167);
            pan_line_master.BackColor = Color.FromArgb(167, 167, 167);
            pan_line_master.Visible = false;
            lbl_Home.ForeColor = Color.White;
            pan_line_home.BackColor = Color.White;
            pan_line_home.Visible = true;
            ico_home.ForeColor = Color.White;
            ico_master.ForeColor = Color.FromArgb(167, 167, 167);
            ico_rep.ForeColor = Color.FromArgb(167, 167, 167);
        }
        public void masterclick()
        {
            /*  master1.Show();
            gold1.Hide();*/
            panel1.Hide();
            formload(new master2());
            lbl_master.ForeColor = Color.White;
            pan_line_master.BackColor = Color.White;
            pan_line_master.Visible = true;
            lbl_Home.ForeColor = Color.FromArgb(167, 167, 167);
            pan_line_home.BackColor = Color.FromArgb(167, 167, 167);
            pan_line_home.Visible = false;
            ico_home.ForeColor = Color.FromArgb(167, 167, 167);
            ico_master.ForeColor = Color.White;
            ico_rep.ForeColor = Color.FromArgb(167, 167, 167);
        }
        private void pan_home_Click(object sender, EventArgs e)
        {
            homeclick();
            /* movepanel(pan_home);*/
        }

        private void pan_master_Click(object sender, EventArgs e)
        {
            masterclick();
            /* movepanel(pan_master);*/
        }

        private void lbl_Home_Click(object sender, EventArgs e)
        {
            homeclick();
            /* movepanel(pan_home);*/
        }

        private void lbl_master_Click(object sender, EventArgs e)
        {
            masterclick();
            /* movepanel(pan_master);*/
        }

        private void closingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formload(new closing_stock());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login showlogin = new login();
            showlogin.Show();
        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formload(new gform());
        }

        private void otherOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formload(new g_otherout());
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /*-----------------------------------------------------------------------------*/
    }
}
