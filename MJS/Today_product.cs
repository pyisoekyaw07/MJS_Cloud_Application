using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MJS
{
    public partial class Today_product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        string shop = "";
        public Today_product()
        {
            InitializeComponent();
            shop = login.shopvalue;
        }
        
        private void btn_TPD_out_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = ("select * from todayproduct");
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_show.DataSource = dt;
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
    }
}
