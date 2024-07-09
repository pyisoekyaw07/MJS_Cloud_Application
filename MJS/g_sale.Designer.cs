using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class g_sale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(g_sale));
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_shop = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txt_out_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_WK = new System.Windows.Forms.TextBox();
            this.txt_WP = new System.Windows.Forms.TextBox();
            this.txt_WY = new System.Windows.Forms.TextBox();
            this.txt_WC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Btn_BB = new FontAwesome.Sharp.IconButton();
            this.btn_cash = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_alltotal_amt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_pro_famt = new System.Windows.Forms.TextBox();
            this.txt_pro_amt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_pro_number = new System.Windows.Forms.TextBox();
            this.txt_pernumber = new System.Windows.Forms.TextBox();
            this.txt_percent_amt = new System.Windows.Forms.TextBox();
            this.txt_rep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_gm = new System.Windows.Forms.TextBox();
            this.edit_goldprice_btn = new System.Windows.Forms.Button();
            this.txt_goldprice = new System.Windows.Forms.TextBox();
            this.txt_saleremark = new System.Windows.Forms.TextBox();
            this.txt_mcost = new System.Windows.Forms.TextBox();
            this.txt_showamt = new System.Windows.Forms.Label();
            this.pit_show = new System.Windows.Forms.PictureBox();
            this.label_gm = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.label_goldtype = new System.Windows.Forms.Label();
            this.label_itemname = new System.Windows.Forms.Label();
            this.label_Item = new System.Windows.Forms.Label();
            this.total_S = new System.Windows.Forms.Label();
            this.total_Y = new System.Windows.Forms.Label();
            this.total_P = new System.Windows.Forms.Label();
            this.total_K = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.Label();
            this.txt_y = new System.Windows.Forms.Label();
            this.txt_p = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_totalamt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_totalcost = new System.Windows.Forms.TextBox();
            this.txt_include_percent = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_bbamt = new System.Windows.Forms.TextBox();
            this.txt_include_bbamt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gm = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_date.ForeColor = System.Drawing.Color.Black;
            this.txt_date.Location = new System.Drawing.Point(10, 11);
            this.txt_date.Multiline = true;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(106, 28);
            this.txt_date.TabIndex = 300;
            this.txt_date.TabStop = false;
            this.txt_date.Text = "date";
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_time.ForeColor = System.Drawing.Color.Black;
            this.txt_time.Location = new System.Drawing.Point(113, 11);
            this.txt_time.Multiline = true;
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(108, 28);
            this.txt_time.TabIndex = 300;
            this.txt_time.TabStop = false;
            this.txt_time.Text = "time";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(10, 42);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(237, 28);
            this.textBox3.TabIndex = 300;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "GS/101224-0001";
            // 
            // txt_shop
            // 
            this.txt_shop.BackColor = System.Drawing.SystemColors.Window;
            this.txt_shop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shop.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shop.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_shop.Location = new System.Drawing.Point(720, 25);
            this.txt_shop.Name = "txt_shop";
            this.txt_shop.ReadOnly = true;
            this.txt_shop.Size = new System.Drawing.Size(121, 28);
            this.txt_shop.TabIndex = 300;
            this.txt_shop.TabStop = false;
            this.txt_shop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox5.Location = new System.Drawing.Point(593, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(121, 28);
            this.textBox5.TabIndex = 300;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Gold Sale";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Location = new System.Drawing.Point(465, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(121, 28);
            this.textBox6.TabIndex = 300;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "A Counter";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label12.Location = new System.Drawing.Point(13, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 310;
            this.label12.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // txt_out_no
            // 
            this.txt_out_no.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_out_no.Location = new System.Drawing.Point(13, 101);
            this.txt_out_no.Name = "txt_out_no";
            this.txt_out_no.Size = new System.Drawing.Size(193, 35);
            this.txt_out_no.TabIndex = 1;
            this.txt_out_no.TextChanged += new System.EventHandler(this.txt_out_no_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label7.Location = new System.Drawing.Point(488, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 316;
            this.label7.Text = "အရောင်း အလျော့တွက်";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label6.Location = new System.Drawing.Point(488, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 315;
            this.label6.Text = "ရွှေချိန်";
            // 
            // txt_WK
            // 
            this.txt_WK.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WK.Location = new System.Drawing.Point(637, 444);
            this.txt_WK.Name = "txt_WK";
            this.txt_WK.Size = new System.Drawing.Size(59, 35);
            this.txt_WK.TabIndex = 3;
            this.txt_WK.Text = "0";
            this.txt_WK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WK.TextChanged += new System.EventHandler(this.txt_WK_TextChanged);
            // 
            // txt_WP
            // 
            this.txt_WP.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WP.Location = new System.Drawing.Point(702, 444);
            this.txt_WP.Name = "txt_WP";
            this.txt_WP.Size = new System.Drawing.Size(59, 35);
            this.txt_WP.TabIndex = 4;
            this.txt_WP.Text = "0";
            this.txt_WP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WP.TextChanged += new System.EventHandler(this.txt_WP_TextChanged);
            // 
            // txt_WY
            // 
            this.txt_WY.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WY.Location = new System.Drawing.Point(765, 444);
            this.txt_WY.Name = "txt_WY";
            this.txt_WY.Size = new System.Drawing.Size(59, 35);
            this.txt_WY.TabIndex = 5;
            this.txt_WY.Text = "0";
            this.txt_WY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WY.TextChanged += new System.EventHandler(this.txt_WY_TextChanged);
            // 
            // txt_WC
            // 
            this.txt_WC.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WC.Location = new System.Drawing.Point(827, 444);
            this.txt_WC.Name = "txt_WC";
            this.txt_WC.Size = new System.Drawing.Size(59, 35);
            this.txt_WC.TabIndex = 6;
            this.txt_WC.Text = "0";
            this.txt_WC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WC.TextChanged += new System.EventHandler(this.txt_WC_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label13.Location = new System.Drawing.Point(651, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 22);
            this.label13.TabIndex = 326;
            this.label13.Text = "ကျပ်";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label29.Location = new System.Drawing.Point(724, 360);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 22);
            this.label29.TabIndex = 327;
            this.label29.Text = "ပဲ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label30.Location = new System.Drawing.Point(783, 359);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 22);
            this.label30.TabIndex = 328;
            this.label30.Text = "ရွေး";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label31.Location = new System.Drawing.Point(848, 359);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 22);
            this.label31.TabIndex = 329;
            this.label31.Text = "စိတ်";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label19.Location = new System.Drawing.Point(3, 625);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 22);
            this.label19.TabIndex = 340;
            this.label19.Text = "စုစုပေါင်း ကျသင့်ငွေ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label18.Location = new System.Drawing.Point(950, 707);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 22);
            this.label18.TabIndex = 339;
            this.label18.Text = "မှတ်ချက်";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label17.Location = new System.Drawing.Point(488, 540);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 338;
            this.label17.Text = "လက်ခ";
            // 
            // Btn_BB
            // 
            this.Btn_BB.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.Btn_BB.IconColor = System.Drawing.Color.Black;
            this.Btn_BB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_BB.IconSize = 25;
            this.Btn_BB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BB.Location = new System.Drawing.Point(3, 695);
            this.Btn_BB.Name = "Btn_BB";
            this.Btn_BB.Size = new System.Drawing.Size(218, 44);
            this.Btn_BB.TabIndex = 9;
            this.Btn_BB.Text = "BB";
            this.Btn_BB.UseVisualStyleBackColor = true;
            this.Btn_BB.Click += new System.EventHandler(this.Btn_BB_Click);
            // 
            // btn_cash
            // 
            this.btn_cash.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_cash.IconColor = System.Drawing.Color.Black;
            this.btn_cash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cash.IconSize = 25;
            this.btn_cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cash.Location = new System.Drawing.Point(220, 695);
            this.btn_cash.Name = "btn_cash";
            this.btn_cash.Size = new System.Drawing.Size(227, 44);
            this.btn_cash.TabIndex = 17;
            this.btn_cash.Text = "Cash";
            this.btn_cash.UseVisualStyleBackColor = true;
            this.btn_cash.Click += new System.EventHandler(this.btn_cash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label1.Location = new System.Drawing.Point(488, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 334;
            this.label1.Text = "ကျသင့် အလျော့တွက်";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label5.Location = new System.Drawing.Point(950, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 346;
            this.label5.Text = "အခွန်";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.txt_alltotal_amt);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.txt_pro_famt);
            this.panel1.Controls.Add(this.txt_pro_amt);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_pro_number);
            this.panel1.Controls.Add(this.txt_pernumber);
            this.panel1.Controls.Add(this.txt_percent_amt);
            this.panel1.Controls.Add(this.txt_rep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_gm);
            this.panel1.Controls.Add(this.edit_goldprice_btn);
            this.panel1.Controls.Add(this.txt_goldprice);
            this.panel1.Controls.Add(this.txt_saleremark);
            this.panel1.Controls.Add(this.txt_mcost);
            this.panel1.Controls.Add(this.txt_showamt);
            this.panel1.Controls.Add(this.txt_shop);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.pit_show);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txt_time);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.label_gm);
            this.panel1.Controls.Add(this.label_qty);
            this.panel1.Controls.Add(this.label_goldtype);
            this.panel1.Controls.Add(this.label_itemname);
            this.panel1.Controls.Add(this.label_Item);
            this.panel1.Controls.Add(this.total_S);
            this.panel1.Controls.Add(this.total_Y);
            this.panel1.Controls.Add(this.total_P);
            this.panel1.Controls.Add(this.total_K);
            this.panel1.Controls.Add(this.txt_s);
            this.panel1.Controls.Add(this.txt_y);
            this.panel1.Controls.Add(this.txt_p);
            this.panel1.Controls.Add(this.txt_k);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.txt_totalamt);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txt_totalcost);
            this.panel1.Controls.Add(this.txt_include_percent);
            this.panel1.Controls.Add(this.txt_discount);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txt_bbamt);
            this.panel1.Controls.Add(this.txt_include_bbamt);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbl_qty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_gm);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lbl_totalamt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_out_no);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_cash);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Btn_BB);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txt_WC);
            this.panel1.Controls.Add(this.txt_WY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_WP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_WK);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 763);
            this.panel1.TabIndex = 348;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(951, 586);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(38, 22);
            this.label35.TabIndex = 433;
            this.label35.Text = "Total";
            // 
            // txt_alltotal_amt
            // 
            this.txt_alltotal_amt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_alltotal_amt.Enabled = false;
            this.txt_alltotal_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alltotal_amt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_alltotal_amt.Location = new System.Drawing.Point(1094, 580);
            this.txt_alltotal_amt.Name = "txt_alltotal_amt";
            this.txt_alltotal_amt.Size = new System.Drawing.Size(189, 35);
            this.txt_alltotal_amt.TabIndex = 432;
            this.txt_alltotal_amt.Text = "0";
            this.txt_alltotal_amt.TextChanged += new System.EventHandler(this.txt_alltotal_amt_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(950, 538);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(108, 24);
            this.label34.TabIndex = 431;
            this.label34.Text = "Promotion(Flat)";
            // 
            // txt_pro_famt
            // 
            this.txt_pro_famt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_famt.Location = new System.Drawing.Point(1092, 538);
            this.txt_pro_famt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pro_famt.Name = "txt_pro_famt";
            this.txt_pro_famt.Size = new System.Drawing.Size(191, 35);
            this.txt_pro_famt.TabIndex = 14;
            this.txt_pro_famt.Text = "0";
            this.txt_pro_famt.TextChanged += new System.EventHandler(this.txt_pro_famt_TextChanged);
            this.txt_pro_famt.Leave += new System.EventHandler(this.txt_pro_famt_Leave);
            // 
            // txt_pro_amt
            // 
            this.txt_pro_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_amt.Location = new System.Drawing.Point(1164, 494);
            this.txt_pro_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pro_amt.Name = "txt_pro_amt";
            this.txt_pro_amt.Size = new System.Drawing.Size(117, 35);
            this.txt_pro_amt.TabIndex = 13;
            this.txt_pro_amt.Text = "0";
            this.txt_pro_amt.TextChanged += new System.EventHandler(this.txt_pro_amt_TextChanged);
            this.txt_pro_amt.Leave += new System.EventHandler(this.txt_pro_amt_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label14.Location = new System.Drawing.Point(950, 494);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 22);
            this.label14.TabIndex = 427;
            this.label14.Text = "Promotion (%)";
            // 
            // txt_pro_number
            // 
            this.txt_pro_number.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_number.Location = new System.Drawing.Point(1092, 495);
            this.txt_pro_number.Name = "txt_pro_number";
            this.txt_pro_number.Size = new System.Drawing.Size(55, 35);
            this.txt_pro_number.TabIndex = 12;
            this.txt_pro_number.Text = "0";
            this.txt_pro_number.TextChanged += new System.EventHandler(this.txt_pro_number_TextChanged);
            // 
            // txt_pernumber
            // 
            this.txt_pernumber.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pernumber.Location = new System.Drawing.Point(1092, 407);
            this.txt_pernumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pernumber.Name = "txt_pernumber";
            this.txt_pernumber.Size = new System.Drawing.Size(55, 35);
            this.txt_pernumber.TabIndex = 10;
            this.txt_pernumber.Text = "0";
            this.txt_pernumber.TextChanged += new System.EventHandler(this.txt_pernumber_TextChanged);
            // 
            // txt_percent_amt
            // 
            this.txt_percent_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_percent_amt.Location = new System.Drawing.Point(1164, 406);
            this.txt_percent_amt.Name = "txt_percent_amt";
            this.txt_percent_amt.Size = new System.Drawing.Size(117, 35);
            this.txt_percent_amt.TabIndex = 11;
            this.txt_percent_amt.Text = "0";
            this.txt_percent_amt.TextChanged += new System.EventHandler(this.txt_percent_amt_TextChanged);
            this.txt_percent_amt.Leave += new System.EventHandler(this.txt_percent_amt_Leave);
            // 
            // txt_rep
            // 
            this.txt_rep.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rep.Location = new System.Drawing.Point(639, 580);
            this.txt_rep.Name = "txt_rep";
            this.txt_rep.Size = new System.Drawing.Size(185, 35);
            this.txt_rep.TabIndex = 8;
            this.txt_rep.Text = "0";
            this.txt_rep.TextChanged += new System.EventHandler(this.txt_rep_TextChanged);
            this.txt_rep.Leave += new System.EventHandler(this.txt_rep_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label2.Location = new System.Drawing.Point(489, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 421;
            this.label2.Text = "GPD တန်ဖိုး";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(707, 695);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(205, 44);
            this.iconButton2.TabIndex = 420;
            this.iconButton2.Text = "crystal print";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(484, 695);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(205, 44);
            this.iconButton1.TabIndex = 419;
            this.iconButton1.Text = "Save";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(795, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 418;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_gm
            // 
            this.txt_gm.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gm.Location = new System.Drawing.Point(637, 323);
            this.txt_gm.Name = "txt_gm";
            this.txt_gm.Size = new System.Drawing.Size(194, 35);
            this.txt_gm.TabIndex = 2;
            this.txt_gm.TextChanged += new System.EventHandler(this.txt_gm_TextChanged);
            // 
            // edit_goldprice_btn
            // 
            this.edit_goldprice_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_goldprice_btn.BackgroundImage")));
            this.edit_goldprice_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_goldprice_btn.Location = new System.Drawing.Point(370, 103);
            this.edit_goldprice_btn.Name = "edit_goldprice_btn";
            this.edit_goldprice_btn.Size = new System.Drawing.Size(29, 23);
            this.edit_goldprice_btn.TabIndex = 416;
            this.edit_goldprice_btn.UseVisualStyleBackColor = true;
            this.edit_goldprice_btn.Click += new System.EventHandler(this.edit_goldprice_btn_Click);
            // 
            // txt_goldprice
            // 
            this.txt_goldprice.Enabled = false;
            this.txt_goldprice.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_goldprice.Location = new System.Drawing.Point(212, 100);
            this.txt_goldprice.Name = "txt_goldprice";
            this.txt_goldprice.Size = new System.Drawing.Size(194, 35);
            this.txt_goldprice.TabIndex = 415;
            // 
            // txt_saleremark
            // 
            this.txt_saleremark.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saleremark.Location = new System.Drawing.Point(1092, 704);
            this.txt_saleremark.Name = "txt_saleremark";
            this.txt_saleremark.Size = new System.Drawing.Size(246, 35);
            this.txt_saleremark.TabIndex = 16;
            // 
            // txt_mcost
            // 
            this.txt_mcost.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mcost.Location = new System.Drawing.Point(639, 537);
            this.txt_mcost.Name = "txt_mcost";
            this.txt_mcost.Size = new System.Drawing.Size(185, 35);
            this.txt_mcost.TabIndex = 7;
            this.txt_mcost.Text = "0";
            this.txt_mcost.TextChanged += new System.EventHandler(this.txt_mcost_TextChanged);
            this.txt_mcost.Leave += new System.EventHandler(this.txt_mcost_Leave);
            // 
            // txt_showamt
            // 
            this.txt_showamt.AutoSize = true;
            this.txt_showamt.Font = new System.Drawing.Font("Pyidaungsu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showamt.Location = new System.Drawing.Point(148, 613);
            this.txt_showamt.Name = "txt_showamt";
            this.txt_showamt.Size = new System.Drawing.Size(30, 41);
            this.txt_showamt.TabIndex = 411;
            this.txt_showamt.Text = "0";
            // 
            // pit_show
            // 
            this.pit_show.Location = new System.Drawing.Point(114, 383);
            this.pit_show.Name = "pit_show";
            this.pit_show.Size = new System.Drawing.Size(221, 178);
            this.pit_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pit_show.TabIndex = 410;
            this.pit_show.TabStop = false;
            // 
            // label_gm
            // 
            this.label_gm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_gm.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_gm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_gm.Location = new System.Drawing.Point(206, 240);
            this.label_gm.Name = "label_gm";
            this.label_gm.Size = new System.Drawing.Size(193, 34);
            this.label_gm.TabIndex = 409;
            this.label_gm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_qty
            // 
            this.label_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_qty.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_qty.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_qty.Location = new System.Drawing.Point(13, 240);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(193, 34);
            this.label_qty.TabIndex = 408;
            this.label_qty.Text = "1";
            this.label_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_goldtype
            // 
            this.label_goldtype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_goldtype.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_goldtype.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_goldtype.Location = new System.Drawing.Point(13, 317);
            this.label_goldtype.Name = "label_goldtype";
            this.label_goldtype.Size = new System.Drawing.Size(193, 34);
            this.label_goldtype.TabIndex = 407;
            this.label_goldtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_goldtype.TextChanged += new System.EventHandler(this.label_goldtype_TextChanged);
            // 
            // label_itemname
            // 
            this.label_itemname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_itemname.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_itemname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_itemname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_itemname.Location = new System.Drawing.Point(205, 167);
            this.label_itemname.Name = "label_itemname";
            this.label_itemname.Size = new System.Drawing.Size(193, 34);
            this.label_itemname.TabIndex = 406;
            this.label_itemname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Item
            // 
            this.label_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Item.Font = new System.Drawing.Font("Pyidaungsu", 12F);
            this.label_Item.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Item.Location = new System.Drawing.Point(13, 167);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(193, 34);
            this.label_Item.TabIndex = 405;
            this.label_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total_S
            // 
            this.total_S.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_S.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_S.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.total_S.Location = new System.Drawing.Point(828, 490);
            this.total_S.Name = "total_S";
            this.total_S.Size = new System.Drawing.Size(57, 33);
            this.total_S.TabIndex = 404;
            this.total_S.Text = "0";
            this.total_S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_Y
            // 
            this.total_Y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_Y.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Y.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.total_Y.Location = new System.Drawing.Point(765, 490);
            this.total_Y.Name = "total_Y";
            this.total_Y.Size = new System.Drawing.Size(57, 33);
            this.total_Y.TabIndex = 403;
            this.total_Y.Text = "0";
            this.total_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_P
            // 
            this.total_P.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_P.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_P.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.total_P.Location = new System.Drawing.Point(702, 490);
            this.total_P.Name = "total_P";
            this.total_P.Size = new System.Drawing.Size(57, 33);
            this.total_P.TabIndex = 402;
            this.total_P.Text = "0";
            this.total_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_K
            // 
            this.total_K.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_K.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_K.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.total_K.Location = new System.Drawing.Point(639, 490);
            this.total_K.Name = "total_K";
            this.total_K.Size = new System.Drawing.Size(57, 33);
            this.total_K.TabIndex = 401;
            this.total_K.Text = "0";
            this.total_K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_s
            // 
            this.txt_s.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_s.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_s.Location = new System.Drawing.Point(828, 396);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(57, 33);
            this.txt_s.TabIndex = 400;
            this.txt_s.Text = "0";
            this.txt_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_y
            // 
            this.txt_y.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_y.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_y.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_y.Location = new System.Drawing.Point(765, 396);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(57, 33);
            this.txt_y.TabIndex = 399;
            this.txt_y.Text = "0";
            this.txt_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_p
            // 
            this.txt_p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_p.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_p.Location = new System.Drawing.Point(702, 396);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(57, 33);
            this.txt_p.TabIndex = 398;
            this.txt_p.Text = "0";
            this.txt_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_k
            // 
            this.txt_k.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_k.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_k.Location = new System.Drawing.Point(639, 396);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(57, 33);
            this.txt_k.TabIndex = 397;
            this.txt_k.Text = "0";
            this.txt_k.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label32.Location = new System.Drawing.Point(13, 286);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 22);
            this.label32.TabIndex = 376;
            this.label32.Text = "အရောင်း ‌ရွှေရည်";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label28.Location = new System.Drawing.Point(488, 625);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 22);
            this.label28.TabIndex = 374;
            this.label28.Text = "ပစ္စည်းတန်ဖိုး ကျသင့်ငွေ";
            // 
            // txt_totalamt
            // 
            this.txt_totalamt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_totalamt.Enabled = false;
            this.txt_totalamt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalamt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_totalamt.Location = new System.Drawing.Point(637, 622);
            this.txt_totalamt.Name = "txt_totalamt";
            this.txt_totalamt.Size = new System.Drawing.Size(187, 35);
            this.txt_totalamt.TabIndex = 373;
            this.txt_totalamt.TabStop = false;
            this.txt_totalamt.Text = "0";
            this.txt_totalamt.TextChanged += new System.EventHandler(this.txt_totalamt_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label27.Location = new System.Drawing.Point(950, 664);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 22);
            this.label27.TabIndex = 372;
            this.label27.Text = "စုစုပေါင်း ကျသင့်ငွေ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label26.Location = new System.Drawing.Point(950, 622);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 22);
            this.label26.TabIndex = 371;
            this.label26.Text = "လျှော့ပေးငွေ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label25.Location = new System.Drawing.Point(950, 365);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 22);
            this.label25.TabIndex = 370;
            this.label25.Text = "အလဲနုတ်ပြီး ကျသင့်ငွေ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label24.Location = new System.Drawing.Point(950, 321);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 22);
            this.label24.TabIndex = 369;
            this.label24.Text = "အလဲတန်ဖိုး ကျသင့်ငွေ";
            // 
            // txt_totalcost
            // 
            this.txt_totalcost.BackColor = System.Drawing.SystemColors.Window;
            this.txt_totalcost.Enabled = false;
            this.txt_totalcost.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalcost.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_totalcost.Location = new System.Drawing.Point(1092, 661);
            this.txt_totalcost.Name = "txt_totalcost";
            this.txt_totalcost.Size = new System.Drawing.Size(191, 35);
            this.txt_totalcost.TabIndex = 368;
            this.txt_totalcost.TabStop = false;
            this.txt_totalcost.Text = "0";
            this.txt_totalcost.TextChanged += new System.EventHandler(this.txt_totalcost_TextChanged);
            // 
            // txt_include_percent
            // 
            this.txt_include_percent.BackColor = System.Drawing.SystemColors.Window;
            this.txt_include_percent.Enabled = false;
            this.txt_include_percent.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_include_percent.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_include_percent.Location = new System.Drawing.Point(1092, 448);
            this.txt_include_percent.Name = "txt_include_percent";
            this.txt_include_percent.Size = new System.Drawing.Size(191, 35);
            this.txt_include_percent.TabIndex = 367;
            this.txt_include_percent.TabStop = false;
            this.txt_include_percent.Text = "0";
            this.txt_include_percent.TextChanged += new System.EventHandler(this.txt_include_percent_TextChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(1092, 620);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(189, 35);
            this.txt_discount.TabIndex = 15;
            this.txt_discount.Text = "0";
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label23.Location = new System.Drawing.Point(950, 451);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 22);
            this.label23.TabIndex = 365;
            this.label23.Text = "အခွန်ပါပြီး ကျသင့်ငွေ";
            // 
            // txt_bbamt
            // 
            this.txt_bbamt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_bbamt.Enabled = false;
            this.txt_bbamt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bbamt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_bbamt.Location = new System.Drawing.Point(1092, 318);
            this.txt_bbamt.Name = "txt_bbamt";
            this.txt_bbamt.Size = new System.Drawing.Size(191, 35);
            this.txt_bbamt.TabIndex = 364;
            this.txt_bbamt.TabStop = false;
            this.txt_bbamt.Text = "0";
            this.txt_bbamt.TextChanged += new System.EventHandler(this.txt_bbamt_TextChanged);
            // 
            // txt_include_bbamt
            // 
            this.txt_include_bbamt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_include_bbamt.Enabled = false;
            this.txt_include_bbamt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_include_bbamt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_include_bbamt.Location = new System.Drawing.Point(1092, 362);
            this.txt_include_bbamt.Name = "txt_include_bbamt";
            this.txt_include_bbamt.Size = new System.Drawing.Size(191, 35);
            this.txt_include_bbamt.TabIndex = 363;
            this.txt_include_bbamt.TabStop = false;
            this.txt_include_bbamt.Text = "0";
            this.txt_include_bbamt.TextChanged += new System.EventHandler(this.txt_include_bbamt_TextChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(453, 292);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(903, 2);
            this.label22.TabIndex = 362;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(453, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(2, 957);
            this.label21.TabIndex = 361;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.Location = new System.Drawing.Point(458, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 288;
            this.label16.Text = "TOTALQTY";
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qty.Location = new System.Drawing.Point(527, 259);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(59, 33);
            this.lbl_qty.TabIndex = 2;
            this.lbl_qty.Text = "0";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(746, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 286;
            this.label4.Text = "TOTAL AMOUNT";
            // 
            // lbl_gm
            // 
            this.lbl_gm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gm.Location = new System.Drawing.Point(660, 259);
            this.lbl_gm.Name = "lbl_gm";
            this.lbl_gm.Size = new System.Drawing.Size(86, 33);
            this.lbl_gm.TabIndex = 0;
            this.lbl_gm.Text = "0";
            this.lbl_gm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label20.Location = new System.Drawing.Point(592, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 287;
            this.label20.Text = "TOTAL GM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(463, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(876, 176);
            this.dataGridView1.TabIndex = 359;
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalamt.Location = new System.Drawing.Point(844, 259);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(131, 33);
            this.lbl_totalamt.TabIndex = 1;
            this.lbl_totalamt.Text = "0";
            this.lbl_totalamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label11.Location = new System.Drawing.Point(208, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 358;
            this.label11.Text = "ဂရမ်ချိန်";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label15.Location = new System.Drawing.Point(480, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 22);
            this.label15.TabIndex = 352;
            this.label15.Text = "အရောင်း  ဂရမ်ချိန်";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label10.Location = new System.Drawing.Point(15, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 356;
            this.label10.Text = "အခုရေ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label3.Location = new System.Drawing.Point(212, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 349;
            this.label3.Text = "အရောင်း ရွှေစျေး";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label9.Location = new System.Drawing.Point(206, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 354;
            this.label9.Text = "ပစ္စည်းအမည်";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label8.Location = new System.Drawing.Point(15, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 22);
            this.label8.TabIndex = 352;
            this.label8.Text = "ပစ္စည်း";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // g_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 776);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "g_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "g_sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.g_sale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_date;
        private TextBox txt_time;
        private TextBox textBox3;
        private TextBox txt_shop;
        private TextBox textBox5;
        private TextBox textBox6;
        private System.Windows.Forms.Timer timer1;
        private Label label12;
        private TextBox txt_out_no;
        private Label label7;
        private Label label6;
        private TextBox txt_WK;
        private TextBox txt_WP;
        private TextBox txt_WY;
        private TextBox txt_WC;
        private Label label13;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label19;
        private Label label18;
        private Label label17;
        private FontAwesome.Sharp.IconButton Btn_BB;
        private FontAwesome.Sharp.IconButton btn_cash;
        private Label label1;
        private Label label5;
        private Panel panel1;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label15;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label16;
        private Label lbl_gm;
        private Label label20;
        private Label lbl_totalamt;
        private Label lbl_qty;
        private Label label21;
        private Label label22;
        private TextBox txt_totalcost;
        private TextBox txt_include_percent;
        private TextBox txt_discount;
        private Label label23;
        private TextBox txt_bbamt;
        private TextBox txt_include_bbamt;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label28;
        private TextBox txt_totalamt;
        private Label label32;
        private Label txt_k;
        private Label label_gm;
        private Label label_qty;
        private Label label_goldtype;
        private Label label_itemname;
        private Label label_Item;
        private Label total_S;
        private Label total_Y;
        private Label total_P;
        private Label total_K;
        private Label txt_s;
        private Label txt_y;
        private Label txt_p;
        private PictureBox pit_show;
        private Label txt_showamt;
        private TextBox txt_mcost;
        private TextBox txt_saleremark;
        private TextBox txt_goldprice;
        private Button edit_goldprice_btn;
        private Button button1;
        private TextBox txt_gm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox txt_rep;
        private Label label2;
        private TextBox txt_percent_amt;
        private TextBox txt_pernumber;
        private Label label14;
        private TextBox txt_pro_number;
        private TextBox txt_pro_amt;
        private Label label34;
        private TextBox txt_pro_famt;
        private Label label35;
        private TextBox txt_alltotal_amt;
    }
}