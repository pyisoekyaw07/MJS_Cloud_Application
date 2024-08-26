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
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;


namespace MJS
{
    public partial class login : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        public login()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var client = new WebClient();
            if (!webClient.DownloadString("https://www.dropbox.com/scl/fi/ow5ugr7g75zgh56yz1brs/Update.txt.txt?rlkey=sisg6u8gr504h53ez19ctyojc&st=gvb4g97t&dl=1").Contains("1.0.0"))
            {
                if (MessageBox.Show("A new update is available! Do you want to download it?", "MJS Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(@".\MyAppSetup.msi")) { File.Delete(@".\MyAppSetup.msi"); }
                        client.DownloadFile("https://www.dropbox.com/scl/fi/lwyqdgq9vrzx4wpebcris/MyAppSetup.zip?rlkey=v0mhqey7pn4q7jp574aig11e0&st=h7brk74s&dl=1", @"MyAppSetup.zip");
                        string zipPath = @".\MyAppSetup.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);
                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec.exe";
                        process.StartInfo.Arguments = string.Format("/i MyAppSetup.msi");
                        this.Close();
                        process.Start();
                    }
                    catch
                    {
                    }
                }

            }
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

                   /* MessageBox.Show("Connect !");*/
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
                MessageBox.Show("Connect"+" "+"(Ver:0.0.0.2)");
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

        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress[] ip=Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip) 
            { 
                if(address.AddressFamily == AddressFamily.InterNetwork) 
                { 
                    textBox1.Text=address.ToString();
                    MessageBox.Show("Ipaddress"+address.ToString(),"IP Address",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {// Assume textBox1 contains the IP address and textBox2 is where you want to display the last two digits
            string ipAddress = textBox1.Text;

            // Split the IP address by the '.' character
            string[] parts = ipAddress.Split('.');

            // Check if the IP address is valid (contains 4 parts)
            if (parts.Length == 4)
            {
                // Get the last part and extract the last two digits
                string lastPart = parts[3];
                string lastTwoDigits = lastPart.Length >= 2 ? lastPart.Substring(lastPart.Length - 2) : lastPart;

                // Display the last two digits in textBox2
                textBox2.Text = lastTwoDigits;
            }
            else
            {
                // Handle invalid IP address
                textBox2.Text = "Invalid IP";
               

            }
            
        }

    }
}
