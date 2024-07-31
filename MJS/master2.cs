using FontAwesome.Sharp;
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
using System.Net.Security;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
using GHF;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;


namespace MJS
{
    public partial class master2 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=pyisoekyaw_;Password=pyisoe@#101215");
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataAdapter adpt1;
        DataTable da;
        SqlCommandBuilder scb;


        public master2()
        {
            InitializeComponent();
        }


        private void master2_Load(object sender, EventArgs e)
        {

            Parentitem_combo.Hide();
            Pan_item.Hide();

            button1.Enabled = false;


        }

        /*--------------------------------------------------------------အချိန်နှင့်နာရီ-----------------------------------------------------------------*/
        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime d = new DateTime();
            d = DateTime.Now;
            txt_Date.Text = d.ToString("dd/MMM/yyyy");
            txt_Time.Text = DateTime.Now.ToLongTimeString();

        }
        /*----------------------------------------------------------------------------------------------------------------------------------------*/
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                /* groupBox1.Show();*/
                Pan_item.Show();
                Parentitem_combo.Hide();
               
                label1.Text = "Item";
                txt_master_item.Text = null;
                chk_parent.Show();
                chk_parent.Text = "Parent Item";
                chk_parent.Enabled = true;
                chk_parent.Checked = false;
                itemtype_combo.Show();
                label2.Show();
                /*groupBox1.Text = "Item";*/
                itemtype_combo.Enabled = true;
                pen_counter.Hide();
                itemtype_combo.SelectedIndex = -1;
                txt_update.Text = "";
                Gb_gp.Hide();
                txt_master_item.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                /* groupBox1.Show();*/
                label1.Text = "Gold Type";
                label2.Text = "Type";
                chk_parent.Hide();
                Parentitem_combo.Hide();
                Pan_item.Show();
                /*groupBox1.Text = "Gold Type";*/
                itemtype_combo.Enabled = true;
                pen_counter.Hide();
                itemtype_combo.SelectedIndex = -1;
                txt_update.Text = "";
                Gb_gp.Hide();
                txt_master_item.Show();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                /*groupBox1.Show();*/
                /* groupBox1.Text = "Gold Price";*/
                label1.Text = "Gold Price";
                label2.Text = "Type";
                chk_parent.Show();
                chk_parent.Text = "Parent Gold Type";
                chk_parent.Enabled = false;
                Parentitem_combo.Show();
                Pan_item.Show();
                itemtype_combo.Enabled = true;
                pen_counter.Hide();
                itemtype_combo.SelectedIndex = -1;
                Parentitem_combo.SelectedIndex = -1;
                txt_update.Text = "";
                Gb_gp.Show();
                txt_master_item.Hide();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                itemtype_combo.Enabled = false;
                label1.Text = "Source Remark";
                /*groupBox1.Text = "Source Remark";*/
                /*groupBox1.Show();*/
                Pan_item.Show();
                chk_parent.Hide();
                Parentitem_combo.Hide();
                pen_counter.Hide();
                itemtype_combo.SelectedIndex = -1;
                showsourceremark();
                txt_update.Text = "";
                Gb_gp.Hide();
                txt_master_item.Show();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                /* groupBox1.Show();*/
                /* groupBox1.Text = "Counter";*/
                Pan_item.Hide();
                pen_counter.Show();
                itemtype_combo.SelectedIndex = -1;
                showcounter();
                txt_update.Text = "";
                Gb_gp.Hide();
                txt_master_item.Show();

            }
        }

        /*-----------------------------------------------------မာစတာဖောင်တွင်ရှိသော function များ-------------------------------------------------*/

        public void showitem()/*Show Item To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from golditem", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            /*adpt = new SqlDataAdapter("select * from golditem", con);
            dset = new DataSet();
            adpt.Fill(dset);
            dataGridView1.DataSource = dset;*/
        }
        public void showitemname()/*Show Itemname To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from gold_itemname", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showgoldtype()/*Show Goldtype To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from g_type", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showgoldprice()/*Show GoldPrice To Table Function*/
        {

            adpt = new SqlDataAdapter("select * from goldprice", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

          
        }
        public void showsourceremark()/*Show GoldPrice To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from source_remark", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void showcounter()/*Show Counter To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from counter", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void shop()/*Show shop To Table Function*/
        {
            adpt = new SqlDataAdapter("select * from shop", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public void checkinternetconnection()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                if (comboBox1.SelectedIndex == 0)/*Item*/
                {
                    if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == false)/*ွGold*/
                    {

                        /*validate*/
                        con.Open();
                        SqlCommand valcmd = new SqlCommand("select GoldItem from golditem where GoldItem=@GoldItem", con);
                        valcmd.Parameters.AddWithValue("@GoldItem", txt_master_item.Text);
                        SqlDataReader reader1;
                        reader1 = valcmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            MessageBox.Show("Already Have");
                            con.Close();
                        }
                        else
                        {
                            /*Save*/
                            con.Close();
                            SqlCommand goldcmd = new SqlCommand("insert into golditem values(@Date,@Time,@GoldItem)", con);
                            goldcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                            goldcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                            goldcmd.Parameters.AddWithValue("@GoldItem", txt_master_item.Text);
                            con.Open();
                            goldcmd.ExecuteNonQuery();
                            {
                                MessageBox.Show("success");
                                txt_master_item.Text = "";
                            }
                            con.Close();
                            showitem();
                        }


                    }
                    else if (itemtype_combo.SelectedIndex == 1 && txt_master_item.Text != "" && chk_parent.Checked == false)/*WhiteGold*/
                    {
                        con.Open();
                        SqlCommand goldcmd = new SqlCommand("insert into whitegold_item values(@whitegold)", con);
                        goldcmd.Parameters.AddWithValue("@whitegold", txt_master_item.Text);
                        goldcmd.ExecuteNonQuery();
                        {
                            MessageBox.Show("success");
                            txt_master_item.Text = "";
                        }
                        con.Close();
                    }
                    else if (itemtype_combo.SelectedIndex == 2 && txt_master_item.Text != "" && chk_parent.Checked == false)/*Gems*/
                    {
                        con.Open();
                        SqlCommand goldcmd = new SqlCommand("insert into gems_item values(@gems)", con);
                        goldcmd.Parameters.AddWithValue("@gems", txt_master_item.Text);
                        goldcmd.ExecuteNonQuery();
                        {
                            MessageBox.Show("success");
                            txt_master_item.Text = "";
                        }
                        con.Close();

                    }
                    /*-------------------------------------------------Itemname----------------------------------------------------------------*/
                    else if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == true)/*Gold*/
                    {

                        /*validate*/
                        con.Open();
                        SqlCommand valcmd = new SqlCommand("select Itemname from gold_itemname where Itemname=@Itemname", con);
                        valcmd.Parameters.AddWithValue("@Itemname", txt_master_item.Text);
                        SqlDataReader reader1;
                        reader1 = valcmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            MessageBox.Show("Already Have");
                            con.Close();
                        }
                        else
                        {
                            /*Save*/
                            con.Close();
                            SqlCommand goldcmd = new SqlCommand("insert into gold_itemname values(@Date,@Time,@Item,@Itemname)", con);
                            goldcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                            goldcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                            goldcmd.Parameters.AddWithValue("@Item", Parentitem_combo.Text);
                            goldcmd.Parameters.AddWithValue("@Itemname", txt_master_item.Text);
                            con.Open();
                            goldcmd.ExecuteNonQuery();
                            {
                                MessageBox.Show("success");
                                txt_master_item.Text = "";
                            }
                            con.Close();
                            showitemname();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Check Item");
                    }
                }
                /*----------------------------------------------------------------------------------------------------------------------*/

                else if (comboBox1.SelectedIndex == 1)/*Gold Type*/
                {

                    if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "")
                    {
                        /*validate*/
                        con.Open();
                        SqlCommand valcmd = new SqlCommand("select Gold_Type from g_type where Gold_Type=@Gold_Type", con);
                        valcmd.Parameters.AddWithValue("@Gold_Type", txt_master_item.Text);
                        SqlDataReader reader1;
                        reader1 = valcmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            MessageBox.Show("Already Have");
                            con.Close();
                        }
                        else
                        {
                            con.Close();
                            string query = "INSERT INTO g_type([Date],[Time],[Gold_Type])VALUES('" + txt_Date.Text + "','" + txt_Time.Text + "',N'" + txt_master_item.Text + "')";
                            SqlCommand goldcmd = new SqlCommand(query, con);
                            con.Open();
                            goldcmd.ExecuteNonQuery();

                            {
                                MessageBox.Show("Success");
                                txt_master_item.Text = "";
                            }
                            con.Close();
                            showgoldtype();
                        }


                    }
                    else if (itemtype_combo.SelectedIndex == 1 && txt_master_item.Text != "")/*WhiteGold Type*/
                    {
                        string query = "INSERT INTO whitegold_type([whitegold])VALUES(N'" + txt_master_item.Text + "')";
                        SqlCommand goldcmd = new SqlCommand(query, con);
                        con.Open();
                        goldcmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Success");
                            txt_master_item.Text = "";
                        }
                        con.Close();
                    }
                    else if (itemtype_combo.SelectedIndex == 2 && txt_master_item.Text != "")/*Gem Type*/
                    {
                        string query = "INSERT INTO gem_type([gem])VALUES(N'" + txt_master_item.Text + "')";
                        SqlCommand goldcmd = new SqlCommand(query, con);
                        con.Open();
                        goldcmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Success");
                            txt_master_item.Text = "";
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Check");
                    }
                }
                /*----------------------------------------------------------------------------------------------------------------------------*/
                else if (comboBox1.SelectedIndex == 2)/*Goldprice*/
                {


                    CheckComboBoxIndexInDatabase();



                }
                /*-------------------------------------------------------------------------------------------------------------------------------------------*/
                else if (comboBox1.SelectedIndex == 3) /*source remark*/
                {

                    if (txt_master_item.Text != "")
                    {
                        /*validate*/
                        con.Open();
                        SqlCommand valcmd = new SqlCommand("select Source_Remark from source_remark where Source_Remark=@Source_Remark", con);
                        valcmd.Parameters.AddWithValue("@Source_Remark", txt_master_item.Text);
                        SqlDataReader reader1;
                        reader1 = valcmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            MessageBox.Show("Already Have");
                            con.Close();
                        }
                        else
                        {
                            con.Close();
                            string query = "INSERT INTO source_remark([Date],[Time],[Source_Remark])VALUES('" + txt_Date.Text + "','" + txt_Time.Text + "',N'" + txt_master_item.Text + "')";
                            SqlCommand goldcmd = new SqlCommand(query, con);
                            con.Open();
                            goldcmd.ExecuteNonQuery();

                            {
                                MessageBox.Show("Success");
                                txt_master_item.Text = "";
                            }
                            con.Close();
                            showsourceremark();
                        }

                    }
                    else
                    {
                        MessageBox.Show("check");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Internet Connection", "Check Internet Connect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
  

        private void CheckComboBoxIndexInDatabase()/*check goldtype is have in sqlserver*/
        {
            string selectedIndex = Parentitem_combo.Text.ToString();

            if (selectedIndex == "")
            {
                MessageBox.Show("No item is selected in the ComboBox.");
                return;
            }


            string query = "SELECT COUNT(*) FROM goldprice WHERE Gold_Type = @selectedIndex";

            {
                con.Close();
                try
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@selectedIndex", selectedIndex );

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                           /* SqlCommand itemcmd = new SqlCommand("update goldprice set Date=@Date,Time=@Time,Gold_Type=@Goldtype,Purchase_Gold_price=@Goldprice where Gold_Type=N'" + txt_master_item + "'", con);
                            itemcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                            itemcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                            itemcmd.Parameters.AddWithValue("@Goldtype", Parentitem_combo.Text);
                            itemcmd.Parameters.AddWithValue("@Goldprice", txt_master_item.Text);
                            *//*con.Open();*//*
                            itemcmd.ExecuteNonQuery();*/
                            /*con.Close();*/
                            SqlCommand itemnamecmd = new SqlCommand("update goldprice set Date=@Date,Time=@Time,Gold_Type=@Goldtype,Purchase_Gold_Price=@Goldprice,Sale_Gold_Price=@salegp where Gold_Type=N'" + Parentitem_combo.Text + "'", con);
                            itemnamecmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                            itemnamecmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                            itemnamecmd.Parameters.AddWithValue("@Goldtype", Parentitem_combo.Text);
                            itemnamecmd.Parameters.AddWithValue("@Goldprice", txt_purgp.Text);
                            itemnamecmd.Parameters.AddWithValue("@salegp", txt_salegp.Text);
                            /* con.Open();*/
                            itemnamecmd.ExecuteNonQuery();
                            showgoldprice();
                            MessageBox.Show("Success");
                            txt_purgp.Text = "";
                            txt_salegp.Text = "";

                        }
                        else
                        {
                            string qur = "INSERT INTO goldprice([Date],[Time],[Gold_Type],[Purchase_Gold_Price],[Sale_Gold_Price])VALUES('" + txt_Date.Text + "','" + txt_Time.Text + "',N'" + Parentitem_combo.Text + "',N'" + txt_purgp.Text + "',N'" + txt_salegp.Text + "')";
                            SqlCommand goldcmd = new SqlCommand(qur, con);
                            /*con.Open();*/
                            goldcmd.ExecuteNonQuery();

                            {
                                MessageBox.Show("Success");
                                txt_purgp.Text = "";
                                txt_salegp.Text = "";
                            }
                            /*con.Close();*/
                            showgoldprice();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        /*---------------------------------------------------Product Master Tab-------------------------------------------*/



        /*-------------------------------------------------------------------Save Button-------------------------------------------------------*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            checkinternetconnection();
        }
        /*------------------------------------------------------------Counter Form Save Button--------------------------------------------------*/
        private void btn_counter_save_Click(object sender, EventArgs e)/*Counter*/
        {
            if (txt_G_counter.Text != "" && txt_WG_counter.Text != "" && txt_Gem_counter.Text != "")

            {
                string query = "INSERT INTO counter([Date],[Time],[Gold],[Whitegold],[Gem])VALUES('" + txt_Date.Text + "','" + txt_Time.Text + "',N'" + txt_G_counter.Text + "',N'" + txt_WG_counter.Text + "',N'" + txt_Gem_counter.Text + "')";
                SqlCommand goldcmd = new SqlCommand(query, con);
                con.Open();
                goldcmd.ExecuteNonQuery();

                {
                    MessageBox.Show("Success");
                    txt_G_counter.Text = "";
                    txt_WG_counter.Text = "";
                    txt_Gem_counter.Text = "";
                }
                con.Close();
                showcounter();

            }

            else

            {
                MessageBox.Show("check");

            }

        }

        /*------------------------------------------------------------Update Button-------------------------------------------------------------*/
        private void button1_Click(object sender, EventArgs e)/*Update Button*/
        {
            if (comboBox1.SelectedIndex == 0)/*UpdateItem*/
            {
                if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == false)
                {
                    /*validate*/
                    con.Open();
                    SqlCommand valcmd = new SqlCommand("select GoldItem from golditem where GoldItem=@GoldItem", con);
                    valcmd.Parameters.AddWithValue("@GoldItem", txt_master_item.Text);
                    SqlDataReader reader1;
                    reader1 = valcmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Already Have");
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        SqlCommand itemcmd = new SqlCommand("update golditem set Date=@Date,Time=@Time,GoldItem=@GoldItem where GoldItem=N'" + txt_update.Text + "'", con);
                        itemcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                        itemcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                        itemcmd.Parameters.AddWithValue("@GoldItem", txt_master_item.Text);
                        con.Open();
                        itemcmd.ExecuteNonQuery();
                        con.Close();
                        SqlCommand itemnamecmd = new SqlCommand("update gold_itemname set Item=@Item where Item=N'" + txt_update.Text + "'", con);
                        itemnamecmd.Parameters.AddWithValue("@Item", txt_master_item.Text);
                        con.Open();
                        itemnamecmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Update Success");
                            txt_master_item.Text = "";
                            txt_update.Text = "";
                        }
                        con.Close();
                        showitem();
                    }


                }
                else if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == true)/*Update Itemname*/
                {
                    /*validate*/
                    con.Open();
                    SqlCommand valcmd = new SqlCommand("select Itemname from gold_itemname where Itemname=@Itemname", con);
                    valcmd.Parameters.AddWithValue("@Itemname", txt_master_item.Text);
                    SqlDataReader reader1;
                    reader1 = valcmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Already Have");
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        SqlCommand itemcmd = new SqlCommand("update gold_itemname set Date=@Date,Time=@Time,Item=@Item,Itemname=@Itemname where Itemname =N'" + txt_update.Text + "'", con);
                        itemcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                        itemcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                        itemcmd.Parameters.AddWithValue("@Item", txt_item.Text);
                        itemcmd.Parameters.AddWithValue("@Itemname", txt_master_item.Text);
                        con.Open();
                        itemcmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Update Success");
                            txt_master_item.Text = "";
                            txt_update.Text = "";
                        }
                        con.Close();
                        showitemname();
                    }

                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (itemtype_combo.SelectedIndex == 0 && txt_master_item.Text != "" && chk_parent.Checked == false)/*Update Goldtype*/
                {
                    /*validate*/
                    con.Open();
                    SqlCommand valcmd = new SqlCommand("select Gold_Type from g_type where Gold_Type=@Gold_Type", con);
                    valcmd.Parameters.AddWithValue("@Gold_Type", txt_master_item.Text);
                    SqlDataReader reader1;
                    reader1 = valcmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Already Have");
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        SqlCommand itemcmd = new SqlCommand("update g_type set Date=@Date,Time=@Time,Gold_Type=@Gold_Type where Gold_Type=N'" + txt_update.Text + "'", con);
                        itemcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                        itemcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                        itemcmd.Parameters.AddWithValue("@Gold_Type", txt_master_item.Text);
                        con.Open();
                        itemcmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Update Success");
                            txt_master_item.Text = "";
                            txt_update.Text = "";
                        }
                        con.Close();
                        showgoldtype();
                    }

                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (txt_master_item.Text != "" && chk_parent.Checked == false)/*Update Sourckremark*/
                {
                    /*validate*/
                    con.Open();
                    SqlCommand valcmd = new SqlCommand("select Source_Remark from source_remark where Source_Remark=@Source_Remark", con);
                    valcmd.Parameters.AddWithValue("@Source_Remark", txt_master_item.Text);
                    SqlDataReader reader1;
                    reader1 = valcmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Already Have");
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        SqlCommand itemcmd = new SqlCommand("update source_remark set Date=@Date,Time=@Time,Source_Remark=@Source_Remark where Source_Remark=N'" + txt_update.Text + "'", con);
                        itemcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                        itemcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                        itemcmd.Parameters.AddWithValue("@Source_Remark", txt_master_item.Text);
                        con.Open();
                        itemcmd.ExecuteNonQuery();

                        {
                            MessageBox.Show("Update Success");
                            txt_master_item.Text = "";
                            txt_update.Text = "";
                        }
                        con.Close();
                        showsourceremark();
                    }

                }
                else
                {
                    MessageBox.Show("Check");
                }
            }

        }

        /*------------------------------------------------------------txt_update change----------------------------------------------------------*/
        private void txt_update_TextChanged(object sender, EventArgs e)
        {
            /* btn_save.Enabled = false;
             button1.Enabled = true;*/
        }

        /*-----------------------------------------------------------Choose Item For Itemname----------------------------------------------------*/
        private void Parentitem_combo_Click_2(object sender, EventArgs e)
        {
            if (itemtype_combo.Text == "") 
            {
                MessageBox.Show("Please Select Type First");
            }
            if (comboBox1.SelectedIndex==0 && itemtype_combo.SelectedIndex == 0)/*Gold itmename*/
            {
                try 
                
                {
                    con.Open();
                    SqlCommand itemcmd = new SqlCommand("Select Golditem from golditem", con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = itemcmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Parentitem_combo.DataSource = dt;
                    Parentitem_combo.DisplayMember = "golditem";
                    Parentitem_combo.ValueMember = "";
                    if (Parentitem_combo.Items.Count > 0)
                    {
                        Parentitem_combo.SelectedIndex = -1;
                        Parentitem_combo.SelectedText = "---Select Item---";
                    }
                    con.Close();

                } 
                
                catch (Exception ex)
                
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
           
            /*-------------------------------------------------------------------------------------------*/
            else if (itemtype_combo.SelectedIndex == 1)/*WhiteGold*/
            {
                con.Open();
                SqlCommand itemcmd = new SqlCommand("Select whitegold from whitegold_item", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = itemcmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Parentitem_combo.DataSource = dt;
                Parentitem_combo.DisplayMember = "whitegold";
                Parentitem_combo.ValueMember = "";

                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
                con.Close();
            }
            /*----------------------------------------------------------------------------------------------*/
            else if (itemtype_combo.SelectedIndex == 2)/*Gems*/
            {
                con.Open();
                SqlCommand itemcmd = new SqlCommand("Select gems from gems_item", con);
                SqlDataAdapter dc = new SqlDataAdapter();
                dc.SelectCommand = itemcmd;
                DataTable dt = new DataTable();
                dc.Fill(dt);
                Parentitem_combo.DataSource = dt;
                Parentitem_combo.DisplayMember = "gems";
                Parentitem_combo.ValueMember = "";
                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 2 && itemtype_combo.SelectedIndex == 0) /*gold price*/
            {
                adpt1 = new SqlDataAdapter("select * from g_type", con);
                da = new DataTable();
                adpt1.Fill(da);
                Parentitem_combo.DataSource = da;
                Parentitem_combo.DataSource = da;
                Parentitem_combo.DisplayMember = "Gold_Type";
                Parentitem_combo.ValueMember = "";
                if (Parentitem_combo.Items.Count > 0)
                {
                    Parentitem_combo.SelectedIndex = -1;
                    Parentitem_combo.SelectedText = "---Select Item---";
                }
            }
        }

        private void itemtype_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && itemtype_combo.SelectedIndex == 0)/*Item*/
            {
                showitem();
            }
            else if (comboBox1.SelectedIndex == 1 && itemtype_combo.SelectedIndex == 0)/*goldtype*/
            {
                showgoldtype();
            }
            else if (comboBox1.SelectedIndex == 2 && itemtype_combo.SelectedIndex == 0)/*goldprice*/
            {
                showgoldprice();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)/*DataGridView Cell Click*/
        {

            if (comboBox1.SelectedIndex == 0 && itemtype_combo.SelectedIndex == 0 && chk_parent.Checked == false)/*UpdateItem*/
            {
                int i, j;
                i = dataGridView1.CurrentCell.RowIndex;
                /*j = dataGridView1.CurrentCell.ColumnIndex;*/

                txt_update.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            else if (comboBox1.SelectedIndex == 0 && itemtype_combo.SelectedIndex == 0 && chk_parent.Checked == true)
            {
                int i, j;
                i = dataGridView1.CurrentCell.RowIndex;
                /*j = dataGridView1.CurrentCell.ColumnIndex;*/
                txt_item.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_update.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();


            }
            else if (comboBox1.SelectedIndex == 1 && itemtype_combo.SelectedIndex == 0 && chk_parent.Checked == false)
            {
                int i, j;
                i = dataGridView1.CurrentCell.RowIndex;
                /*j = dataGridView1.CurrentCell.ColumnIndex;*/
                txt_update.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            else if (comboBox1.SelectedIndex == 3 && chk_parent.Checked == false)
            {
                int i, j;
                i = dataGridView1.CurrentCell.RowIndex;
                /*j = dataGridView1.CurrentCell.ColumnIndex;*/
                txt_update.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
        }

        /*--------------------------------------------------------------------------------------------------------------------*/

        /*-----------------------------------------------------------Shop Tab-------------------------------------------------*/
        private void btn_shop_save_Click(object sender, EventArgs e)/*Shop Save Button*/
        {

        }
        private void btn_View_Click(object sender, EventArgs e)
        {
            shop();
        }
        /*--------------------------------------------------------radiobutton master form update mode-------------------------*/
        bool isChecked = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton1.Checked;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !isChecked)
            {
                radioButton1.Checked = false;
                button1.Enabled = false;
                btn_save.Enabled = true;
                Parentitem_combo.Enabled = true;
            }

            else
            {
                radioButton1.Checked = true;
                isChecked = false;
                button1.Enabled = true;
                btn_save.Enabled = false;
                Parentitem_combo.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                Form frm3 = new shop_login();
                frm3.ShowDialog();
            }
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void btn_shop_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btn_setting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void chk_parent_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_parent.Checked)
            {
                showitemname();
                Parentitem_combo.Show();
                label1.Text = "Item Name";
                Parentitem_combo.SelectedIndex = -1;
            }
            else
            {
                showitem();
                Parentitem_combo.Hide();
                label1.Text = "Item";
                Parentitem_combo.SelectedIndex = -1;
            }
 
        }

        private void btn_sellingprice_Click(object sender, EventArgs e)
        {
           
            if (txt_sellingPrice.Text != "") 
            {
                try
                {
                    con.Open();
                    SqlCommand goldcmd = new SqlCommand("insert into setting values(@Date,@Time,@Selling_Price)", con);
                    goldcmd.Parameters.AddWithValue("@Date", txt_Date.Text);
                    goldcmd.Parameters.AddWithValue("@Time", txt_Time.Text);
                    goldcmd.Parameters.AddWithValue("@Selling_Price", txt_sellingPrice.Text);

                    goldcmd.ExecuteNonQuery();
                    {
                        MessageBox.Show("success");
                        txt_sellingPrice.Text = "";
                    }
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else 
            {
                MessageBox.Show("Please Insert Selling Price");
            }
                     
        }

        private void txt_sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------*/
    }
}
