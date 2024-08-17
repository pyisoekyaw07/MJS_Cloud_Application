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
using System.IO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;


namespace MJS
{
    public partial class closing_stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        /*string maincon = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;*/
        
        public closing_stock()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = ("select * from closing_stock");
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_cs.DataSource = dt;
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

        private void closing_stock_Load(object sender, EventArgs e)
        {
            branch();
        }
        public void branch()
        {
           
            cmb_shop.Items.Clear();
            string sqlquery = "select * from shop";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
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
                con.Close();
            }
        }

        private void dgv_cs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
              
                string Productid = dgv_cs.Rows[e.RowIndex].Cells["ProductID"].Value?.ToString();
                string item = dgv_cs.Rows[e.RowIndex].Cells["Item"].Value?.ToString();
                string itemname = dgv_cs.Rows[e.RowIndex].Cells["ItemName"].Value?.ToString();
                string gm = dgv_cs.Rows[e.RowIndex].Cells["Gm"].Value?.ToString();
                string amt = dgv_cs.Rows[e.RowIndex].Cells["Totalamt"].Value?.ToString();


                lblProductID.Text = $"ProductID: {Productid}";
                lblItem.Text = $"Item: {item}";
                lblItemname.Text = $"Itemname: {itemname}";
                lblgm.Text = $"Gm: {gm}";
                lblamt.Text = $"Amount: {amt}";

                DataGridViewRow row = dgv_cs.Rows[e.RowIndex];
                string productId = row.Cells["ProductID"].Value.ToString();

                FetchAndDisplayImage(productId);

            }
        }
        private void FetchAndDisplayImage(string productId)
        {
            con.Open();

          
                string query = "SELECT Image FROM Image_TB WHERE productid = @ProductId"; // Replace ImageColumnName with your actual image column name

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    byte[] imageBytes = (byte[])command.ExecuteScalar();

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Show_Img.Image = Image.FromStream(ms); // Display the image in PictureBox
                        }
                    }
                    else
                    {
                        MessageBox.Show("Image not found for the selected product.");
                    }
                }con.Close();
            
        }

       
    }
}
