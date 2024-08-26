using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class closing_stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_cs = new System.Windows.Forms.DataGridView();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.lbl_totalqty = new System.Windows.Forms.Label();
            this.lbl_totoalgm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_Img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemname = new System.Windows.Forms.Label();
            this.lblamt = new System.Windows.Forms.Label();
            this.lblgm = new System.Windows.Forms.Label();
            this.cmb_shop = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_openingdate = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_closingstock = new System.Windows.Forms.Button();
            this.txt_searchproduct = new System.Windows.Forms.TextBox();
            this.cmb_counter = new System.Windows.Forms.ComboBox();
            this.chk_counter = new System.Windows.Forms.CheckBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.chk_item = new System.Windows.Forms.CheckBox();
            this.chk_othershop = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Img)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_cs);
            this.panel1.Location = new System.Drawing.Point(336, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 682);
            this.panel1.TabIndex = 2;
            // 
            // dgv_cs
            // 
            this.dgv_cs.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_cs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_cs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_cs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_cs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_cs.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_cs.EnableHeadersVisualStyles = false;
            this.dgv_cs.Location = new System.Drawing.Point(12, 12);
            this.dgv_cs.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_cs.Name = "dgv_cs";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_cs.RowHeadersWidth = 51;
            this.dgv_cs.RowTemplate.Height = 30;
            this.dgv_cs.Size = new System.Drawing.Size(1581, 652);
            this.dgv_cs.TabIndex = 25;
            this.dgv_cs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cs_CellClick);
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.AutoSize = true;
            this.lbl_totalamt.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalamt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_totalamt.Location = new System.Drawing.Point(573, 21);
            this.lbl_totalamt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(22, 29);
            this.lbl_totalamt.TabIndex = 10;
            this.lbl_totalamt.Text = "0";
            // 
            // lbl_totalqty
            // 
            this.lbl_totalqty.AutoSize = true;
            this.lbl_totalqty.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalqty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_totalqty.Location = new System.Drawing.Point(325, 21);
            this.lbl_totalqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalqty.Name = "lbl_totalqty";
            this.lbl_totalqty.Size = new System.Drawing.Size(22, 29);
            this.lbl_totalqty.TabIndex = 9;
            this.lbl_totalqty.Text = "0";
            // 
            // lbl_totoalgm
            // 
            this.lbl_totoalgm.AutoSize = true;
            this.lbl_totoalgm.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totoalgm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_totoalgm.Location = new System.Drawing.Point(113, 21);
            this.lbl_totoalgm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totoalgm.Name = "lbl_totoalgm";
            this.lbl_totoalgm.Size = new System.Drawing.Size(22, 29);
            this.lbl_totoalgm.TabIndex = 8;
            this.lbl_totoalgm.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(447, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Amount";
            // 
            // Show_Img
            // 
            this.Show_Img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Show_Img.Location = new System.Drawing.Point(74, 37);
            this.Show_Img.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_Img.Name = "Show_Img";
            this.Show_Img.Size = new System.Drawing.Size(267, 175);
            this.Show_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show_Img.TabIndex = 4;
            this.Show_Img.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(235, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Gm";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductID.Location = new System.Drawing.Point(395, 21);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(98, 29);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.Text = "Product ID";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(398, 68);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(50, 29);
            this.lblItem.TabIndex = 12;
            this.lblItem.Text = "Item";
            // 
            // lblItemname
            // 
            this.lblItemname.AutoSize = true;
            this.lblItemname.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemname.Location = new System.Drawing.Point(398, 118);
            this.lblItemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemname.Name = "lblItemname";
            this.lblItemname.Size = new System.Drawing.Size(94, 29);
            this.lblItemname.TabIndex = 13;
            this.lblItemname.Text = "Itemname";
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblamt.Location = new System.Drawing.Point(403, 213);
            this.lblamt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(74, 29);
            this.lblamt.TabIndex = 15;
            this.lblamt.Text = "Amount";
            // 
            // lblgm
            // 
            this.lblgm.AutoSize = true;
            this.lblgm.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgm.Location = new System.Drawing.Point(401, 167);
            this.lblgm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgm.Name = "lblgm";
            this.lblgm.Size = new System.Drawing.Size(40, 29);
            this.lblgm.TabIndex = 14;
            this.lblgm.Text = "Gm";
            // 
            // cmb_shop
            // 
            this.cmb_shop.Enabled = false;
            this.cmb_shop.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shop.FormattingEnabled = true;
            this.cmb_shop.Location = new System.Drawing.Point(17, 603);
            this.cmb_shop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmb_shop.Name = "cmb_shop";
            this.cmb_shop.Size = new System.Drawing.Size(215, 34);
            this.cmb_shop.TabIndex = 3;
            this.cmb_shop.SelectedIndexChanged += new System.EventHandler(this.cmb_shop_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_totalamt);
            this.panel2.Controls.Add(this.lbl_totalqty);
            this.panel2.Controls.Add(this.lbl_totoalgm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(336, 701);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 71);
            this.panel2.TabIndex = 21;
            // 
            // txt_openingdate
            // 
            this.txt_openingdate.Location = new System.Drawing.Point(164, 541);
            this.txt_openingdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_openingdate.Name = "txt_openingdate";
            this.txt_openingdate.Size = new System.Drawing.Size(85, 34);
            this.txt_openingdate.TabIndex = 32;
            this.txt_openingdate.Text = "1/Aug/2024";
            this.txt_openingdate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblamt);
            this.panel3.Controls.Add(this.lblItem);
            this.panel3.Controls.Add(this.lblgm);
            this.panel3.Controls.Add(this.lblItemname);
            this.panel3.Controls.Add(this.Show_Img);
            this.panel3.Controls.Add(this.lblProductID);
            this.panel3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1301, 701);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 255);
            this.panel3.TabIndex = 22;
            // 
            // Btn_closingstock
            // 
            this.Btn_closingstock.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_closingstock.Location = new System.Drawing.Point(20, 808);
            this.Btn_closingstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_closingstock.Name = "Btn_closingstock";
            this.Btn_closingstock.Size = new System.Drawing.Size(312, 42);
            this.Btn_closingstock.TabIndex = 23;
            this.Btn_closingstock.Text = "Search";
            this.Btn_closingstock.UseVisualStyleBackColor = true;
            this.Btn_closingstock.Visible = false;
            this.Btn_closingstock.Click += new System.EventHandler(this.Btn_closingstock_Click);
            // 
            // txt_searchproduct
            // 
            this.txt_searchproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchproduct.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchproduct.Location = new System.Drawing.Point(9, 438);
            this.txt_searchproduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_searchproduct.Name = "txt_searchproduct";
            this.txt_searchproduct.Size = new System.Drawing.Size(259, 34);
            this.txt_searchproduct.TabIndex = 24;
            this.txt_searchproduct.TextChanged += new System.EventHandler(this.txt_searchproduct_TextChanged);
            this.txt_searchproduct.Enter += new System.EventHandler(this.txt_searchproduct_Enter);
            this.txt_searchproduct.Leave += new System.EventHandler(this.txt_searchproduct_Leave);
            // 
            // cmb_counter
            // 
            this.cmb_counter.Enabled = false;
            this.cmb_counter.FormattingEnabled = true;
            this.cmb_counter.Location = new System.Drawing.Point(17, 188);
            this.cmb_counter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_counter.Name = "cmb_counter";
            this.cmb_counter.Size = new System.Drawing.Size(232, 34);
            this.cmb_counter.TabIndex = 35;
            // 
            // chk_counter
            // 
            this.chk_counter.AutoSize = true;
            this.chk_counter.Location = new System.Drawing.Point(17, 149);
            this.chk_counter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_counter.Name = "chk_counter";
            this.chk_counter.Size = new System.Drawing.Size(142, 33);
            this.chk_counter.TabIndex = 34;
            this.chk_counter.Text = "Select Counter";
            this.chk_counter.UseVisualStyleBackColor = true;
            this.chk_counter.CheckedChanged += new System.EventHandler(this.chk_counter_CheckedChanged);
            // 
            // cmb_item
            // 
            this.cmb_item.Enabled = false;
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(17, 295);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(232, 34);
            this.cmb_item.TabIndex = 33;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(16, 81);
            this.enddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(265, 34);
            this.enddate.TabIndex = 31;
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            // 
            // chk_item
            // 
            this.chk_item.AutoSize = true;
            this.chk_item.Location = new System.Drawing.Point(17, 254);
            this.chk_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_item.Name = "chk_item";
            this.chk_item.Size = new System.Drawing.Size(118, 33);
            this.chk_item.TabIndex = 29;
            this.chk_item.Text = "Select Item";
            this.chk_item.UseVisualStyleBackColor = true;
            this.chk_item.CheckedChanged += new System.EventHandler(this.chk_item_CheckedChanged);
            // 
            // chk_othershop
            // 
            this.chk_othershop.AutoSize = true;
            this.chk_othershop.Location = new System.Drawing.Point(17, 565);
            this.chk_othershop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_othershop.Name = "chk_othershop";
            this.chk_othershop.Size = new System.Drawing.Size(117, 33);
            this.chk_othershop.TabIndex = 26;
            this.chk_othershop.Text = "Other Shop";
            this.chk_othershop.UseVisualStyleBackColor = true;
            this.chk_othershop.Click += new System.EventHandler(this.chk_othershop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chk_othershop);
            this.groupBox2.Controls.Add(this.cmb_shop);
            this.groupBox2.Controls.Add(this.txt_openingdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.enddate);
            this.groupBox2.Controls.Add(this.txt_searchproduct);
            this.groupBox2.Controls.Add(this.chk_counter);
            this.groupBox2.Controls.Add(this.cmb_item);
            this.groupBox2.Controls.Add(this.cmb_counter);
            this.groupBox2.Controls.Add(this.chk_item);
            this.groupBox2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(304, 687);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Tab";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 402);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Search ProductID";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(-5, 514);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 2);
            this.label9.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(-1, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 2);
            this.label8.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Select Date";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.groupBox2);
            this.menuPanel.Location = new System.Drawing.Point(16, 15);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(312, 757);
            this.menuPanel.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(336, 891);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 53);
            this.button1.TabIndex = 30;
            this.button1.Text = "Export To Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(602, 891);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 53);
            this.button2.TabIndex = 31;
            this.button2.Text = "Print Summery";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // closing_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1942, 967);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_closingstock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "closing_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "closing_stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.closing_stock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_Img)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ComboBox cmb_shop;
        private DataGridView dgv_cs;
        private PictureBox Show_Img;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_totoalgm;
        private Label lbl_totalqty;
        private Label lbl_totalamt;
        private Label lblProductID;
        private Label lblItem;
        private Label lblItemname;
        private Label lblgm;
        private Label lblamt;
        private Panel panel2;
        private Panel panel3;
        private Button Btn_closingstock;
        private TextBox txt_searchproduct;
        private CheckBox chk_othershop;
        private CheckBox chk_item;
        private DateTimePicker enddate;
        private TextBox txt_openingdate;
        private ComboBox cmb_item;
        private ComboBox cmb_counter;
        private CheckBox chk_counter;
        private GroupBox groupBox2;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel menuPanel;
        private Button button1;
        private Button button2;
    }
}