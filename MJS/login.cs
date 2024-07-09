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
using System.Runtime.InteropServices;

namespace MJS
{
    public partial class login : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        public login()
        {
            InitializeComponent();

        }

        private void login_Load(object sender, EventArgs e)
        {

            timer2.Interval = 200;
            timer2.Start();

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

                    MessageBox.Show("Connect !");
                    branch();
                }
                else
                {
                    MessageBox.Show("Check Your Internet Connection !");

                }
            }
        }
        public void branch()
        {
            combo_shop.Items.Clear();
            string sqlquery = "select * from shop";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo_shop.Items.Add(reader["Branchname"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Check Your Internet Connection And Connection Speed ! Because Applicaton is can't connect to the Server !");
            }
            finally
            {
                con.Close();
            }
        }


        public static string shoptext = "";
        public static string username = "";
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (combo_shop.SelectedIndex == 0 && txt_username.Text == "a" && txt_password.Text == "1" || combo_shop.SelectedIndex == 1 && txt_username.Text == "a" && txt_password.Text == "1")
            {
                this.Hide();
                shoptext = combo_shop.Text;
                username = txt_username.Text;
                Form2 frm2 = new Form2();
                frm2.Show();
                combo_shop.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
            }
            else
            {
                MessageBox.Show("check");
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static string shopvalue = "";
        private void combo_shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            shopvalue = combo_shop.SelectedItem.ToString();
        }

        private void hide_pass_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '#')
            {
                unhide_pass.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }

        private void unhide_pass_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                hide_pass.BringToFront();
                txt_password.PasswordChar = '#';
            }
        }
    }
}
