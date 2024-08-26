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
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using System.Runtime.InteropServices.ComTypes;


namespace MJS
{
    public partial class closing_stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=150.95.88.172;Initial Catalog=MJS;User ID=sa;Password=Modernjewellery@5");

        /*string maincon = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;*/


        public closing_stock()
        {
            InitializeComponent();
            chk_item.CheckedChanged += new EventHandler(chk_item_CheckedChanged);
        
        }
        public void totalgm()
        {
            decimal gm = 0;
            for (int i = 0; i < dgv_cs.Rows.Count; ++i)
            {
                gm += Convert.ToDecimal(dgv_cs.Rows[i].Cells[10].Value);
                lbl_totoalgm.Text = gm.ToString();
            }
        }
        public void totalqty()
        {
            lbl_totalqty.Text = dgv_cs.Rows.Count.ToString();
        }
        public void totalamt()
        {
            decimal amt = 0;
            for (int i = 0; i < dgv_cs.Rows.Count; ++i)
            {
                amt += Convert.ToDecimal(dgv_cs.Rows[i].Cells[25].Value);
                lbl_totalamt.Text = amt.ToString();
            }
        }



        string shop = "";
        private void closing_stock_Load(object sender, EventArgs e)
        {
            branch();
            shop=login.shopvalue;          
            txt_searchproduct.Text = "Search ProductID";
            txt_searchproduct.ForeColor = Color.LightGray;
            closingstock();
        }

        public void closingstock() 
        {
            con.Close();
            cmb_shop.Enabled = false;
            chk_othershop.Checked = false;
            try
            {
                con.Open();

                DateTime todayDate = DateTime.Today;
                string shopvalue = shop;

                /*string query = ("SELECT * FROM all_stocks Where Shop = @shop AND(Date BETWEEN @date1 and @date2) OR Date = @Today");*/


                /*string query = @"
        SELECT *
        FROM all_stocks
        WHERE Shop = @shop AND (Date BETWEEN @date1 and @date2 OR Date = @Today)
        AND ProductID NOT IN (
            SELECT ProductID
            FROM other_out
            WHERE Shop = @shop AND(Date BETWEEN @date1 and @date2 OR Date = @Today)
            UNION
            SELECT Product_ID
            FROM g_sale
            WHERE Shop = @shop AND(Date BETWEEN @date1 and @date2 OR Date = @Today)
        );";*/

                string query = @"SELECT *
FROM all_stocks
WHERE Shop = @shop 
  AND Date BETWEEN @date1 and @date2
  AND ProductID NOT IN (
    SELECT ProductID
    FROM other_out
    WHERE Shop = @shop 
      AND Date = @Today
    UNION
    SELECT Product_ID
    FROM g_sale
    WHERE Shop = @shop 
      AND Date = @Today
);";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@date1", txt_openingdate.Text.ToString());
                da.SelectCommand.Parameters.AddWithValue("@date2", enddate.Value);
                da.SelectCommand.Parameters.AddWithValue("@shop", shopvalue);
                da.SelectCommand.Parameters.AddWithValue("@Today", todayDate);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) 
                {
                    dgv_cs.DataSource = dt;
                }
                else 
                {
                    dgv_cs.DataSource = null;
                    MessageBox.Show("No matching data found for the selected date.");
                }
                totalamt();
                totalgm();
                totalqty();
                
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

        private void Btn_closingstock_Click(object sender, EventArgs e)
        {
            con.Close();
            cmb_shop.Enabled = false;
            chk_othershop.Checked = false;
                try
                {
                    con.Open();

                    string query = ("select * from closing_stock where Shop='"+shop+"'");
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


        private void txt_searchproduct_Enter(object sender, EventArgs e)
        {
            if (txt_searchproduct.Text == "Search ProductID")
            {
                txt_searchproduct.Text = "";
                txt_searchproduct.ForeColor = Color.Black;
            }
        }

        private void txt_searchproduct_Leave(object sender, EventArgs e)
        {
            if (txt_searchproduct.Text == "")
            {
                txt_searchproduct.Text = "Search ProductID";
                txt_searchproduct.ForeColor = Color.LightGray;
                txt_searchproduct.Text = "";
            }
        }
      

        private void cmb_shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string query = ("select * from closing_stock where Shop='" + cmb_shop.SelectedItem.ToString() + "' ");
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

        private void chk_othershop_Click(object sender, EventArgs e)
        {
            cmb_shop.Enabled = chk_othershop.Checked;


        }

        private void txt_searchproduct_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                string sql = "SELECT * FROM closing_stock Where ProductID='" + txt_searchproduct.Text.ToString() + "'";
                SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                dgv_cs.DataSource = dt;
                /*            if (dataGridView1.Rows.Count <1)
                            {wh
                                MessageBox.Show("Product မရှိပါ");
                            }*/
                con.Close();

            }

            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public void item()/*function item*/
        {
           
           cmb_item.Items.Clear();

            string sqlquery = "select * from golditem";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_item.Items.Add(reader["Golditem"].ToString());
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

        private void chk_item_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_item.Checked) 
            {
                item();
                cmb_item.Enabled = true;
            }
            else 
            {
                cmb_item .Enabled = false;
            }
                
        }

        public void counter()/*function counter */
        {
            string sqlquery = "select Gold,Whitegold,Gem from counter";
            SqlCommand cmd = new SqlCommand(sqlquery, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    cmb_counter.Items.Add(reader["Gold"]);                 
                    cmb_counter.Items.Add(reader["Gem"]);
                    cmb_counter.Items.Add(reader["Whitegold"]);

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
        private void chk_counter_CheckedChanged(object sender, EventArgs e)
        {
            cmb_counter.Items.Clear();
            if (chk_counter.Checked)
            {
                counter();
                cmb_counter.Enabled = true;
            }
            else
            {
                cmb_counter.Enabled = false;
            }
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            closingstock();
        }
    }
}
