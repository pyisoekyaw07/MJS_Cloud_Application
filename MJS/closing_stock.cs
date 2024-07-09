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
using System.Collections;
using System.Configuration;
using System.Dynamic;


namespace MJS
{
    public partial class closing_stock : Form
    {
        SqlConnection con4 = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");

        /*string maincon = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;*/
        
        public closing_stock()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try {

                con4.Open();

                string query = ("select * from closing_stock");
                SqlDataAdapter da = new SqlDataAdapter(query, con4);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CS_Table.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                con4.Close();

            }

            
        }

        private void closing_stock_Load(object sender, EventArgs e)
        {
            branch();
        }
        public void branch()
        {
           
            cmb_shop.Items.Clear();
            string sqlquery = "select * from shop";
            SqlCommand cmd = new SqlCommand(sqlquery, con4);

            try
            {
                con4.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_shop.Items.Add(reader["Branchname"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con4.Close();
            }
        }
    }
}
