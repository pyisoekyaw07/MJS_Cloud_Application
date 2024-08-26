using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan_rep = new System.Windows.Forms.Panel();
            this.lbl_report = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pan_master = new System.Windows.Forms.Panel();
            this.lbl_master = new System.Windows.Forms.Label();
            this.pan_line_master = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pan_home = new System.Windows.Forms.Panel();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.pan_line_home = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pit_exit = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.goldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteGoldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemDiamondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pan_rep.SuspendLayout();
            this.pan_master.SuspendLayout();
            this.pan_home.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.pan_rep);
            this.panel2.Controls.Add(this.pan_master);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.pan_home);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 63);
            this.panel2.TabIndex = 2;
            // 
            // pan_rep
            // 
            this.pan_rep.Controls.Add(this.lbl_report);
            this.pan_rep.Controls.Add(this.panel6);
            this.pan_rep.Location = new System.Drawing.Point(630, 11);
            this.pan_rep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_rep.Name = "pan_rep";
            this.pan_rep.Size = new System.Drawing.Size(122, 42);
            this.pan_rep.TabIndex = 31;
            // 
            // lbl_report
            // 
            this.lbl_report.AutoSize = true;
            this.lbl_report.BackColor = System.Drawing.Color.Transparent;
            this.lbl_report.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lbl_report.Location = new System.Drawing.Point(32, 6);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Size = new System.Drawing.Size(58, 27);
            this.lbl_report.TabIndex = 21;
            this.lbl_report.Text = "Report";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.panel6.Location = new System.Drawing.Point(1, 34);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(118, 2);
            this.panel6.TabIndex = 24;
            this.panel6.Visible = false;
            // 
            // pan_master
            // 
            this.pan_master.Controls.Add(this.lbl_master);
            this.pan_master.Controls.Add(this.pan_line_master);
            this.pan_master.Location = new System.Drawing.Point(506, 11);
            this.pan_master.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_master.Name = "pan_master";
            this.pan_master.Size = new System.Drawing.Size(118, 42);
            this.pan_master.TabIndex = 30;
            // 
            // lbl_master
            // 
            this.lbl_master.AutoSize = true;
            this.lbl_master.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_master.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.lbl_master.Location = new System.Drawing.Point(14, 6);
            this.lbl_master.Name = "lbl_master";
            this.lbl_master.Size = new System.Drawing.Size(93, 27);
            this.lbl_master.TabIndex = 20;
            this.lbl_master.Text = "Data Master";
            this.lbl_master.Click += new System.EventHandler(this.lbl_master_Click);
            // 
            // pan_line_master
            // 
            this.pan_line_master.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_line_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.pan_line_master.Location = new System.Drawing.Point(0, 34);
            this.pan_line_master.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_line_master.Name = "pan_line_master";
            this.pan_line_master.Size = new System.Drawing.Size(118, 2);
            this.pan_line_master.TabIndex = 23;
            this.pan_line_master.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.Location = new System.Drawing.Point(1157, 15);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // pan_home
            // 
            this.pan_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_home.Controls.Add(this.lbl_Home);
            this.pan_home.Controls.Add(this.pan_line_home);
            this.pan_home.Location = new System.Drawing.Point(380, 11);
            this.pan_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_home.Name = "pan_home";
            this.pan_home.Size = new System.Drawing.Size(118, 42);
            this.pan_home.TabIndex = 29;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.White;
            this.lbl_Home.Location = new System.Drawing.Point(35, 6);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(52, 27);
            this.lbl_Home.TabIndex = 0;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // pan_line_home
            // 
            this.pan_line_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_line_home.BackColor = System.Drawing.Color.White;
            this.pan_line_home.ForeColor = System.Drawing.Color.White;
            this.pan_line_home.Location = new System.Drawing.Point(0, 34);
            this.pan_line_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_line_home.Name = "pan_line_home";
            this.pan_line_home.Size = new System.Drawing.Size(118, 2);
            this.pan_line_home.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pit_exit);
            this.panel3.Controls.Add(this.lbl_username);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1219, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 63);
            this.panel3.TabIndex = 16;
            // 
            // pit_exit
            // 
            this.pit_exit.Image = ((System.Drawing.Image)(resources.GetObject("pit_exit.Image")));
            this.pit_exit.Location = new System.Drawing.Point(140, 4);
            this.pit_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pit_exit.Name = "pit_exit";
            this.pit_exit.Size = new System.Drawing.Size(81, 55);
            this.pit_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pit_exit.TabIndex = 32;
            this.pit_exit.TabStop = false;
            this.pit_exit.Click += new System.EventHandler(this.pit_exit_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(40, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 22);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "Pyi Soe Kyaw";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Location = new System.Drawing.Point(1107, 15);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modern Jewellery Software";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "MJS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 37);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goldToolStripMenuItem1,
            this.whiteGoldToolStripMenuItem1,
            this.gemDiamondToolStripMenuItem,
            this.cashierToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(8, 1);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(340, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // goldToolStripMenuItem1
            // 
            this.goldToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.otherOutToolStripMenuItem,
            this.saleToolStripMenuItem});
            this.goldToolStripMenuItem1.Name = "goldToolStripMenuItem1";
            this.goldToolStripMenuItem1.Size = new System.Drawing.Size(44, 26);
            this.goldToolStripMenuItem1.Text = "Gold";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registerToolStripMenuItem.Image")));
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // otherOutToolStripMenuItem
            // 
            this.otherOutToolStripMenuItem.Name = "otherOutToolStripMenuItem";
            this.otherOutToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.otherOutToolStripMenuItem.Text = "Other Out";
            this.otherOutToolStripMenuItem.Click += new System.EventHandler(this.otherOutToolStripMenuItem_Click_1);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // whiteGoldToolStripMenuItem1
            // 
            this.whiteGoldToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem1});
            this.whiteGoldToolStripMenuItem1.Name = "whiteGoldToolStripMenuItem1";
            this.whiteGoldToolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.whiteGoldToolStripMenuItem1.Text = "WhiteGold";
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem1.Text = "Register";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // gemDiamondToolStripMenuItem
            // 
            this.gemDiamondToolStripMenuItem.Name = "gemDiamondToolStripMenuItem";
            this.gemDiamondToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.gemDiamondToolStripMenuItem.Text = "Gem Diamond";
            // 
            // cashierToolStripMenuItem
            // 
            this.cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            this.cashierToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.cashierToolStripMenuItem.Text = "Cashier";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closingStockToolStripMenuItem,
            this.todayProductToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // closingStockToolStripMenuItem
            // 
            this.closingStockToolStripMenuItem.Name = "closingStockToolStripMenuItem";
            this.closingStockToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.closingStockToolStripMenuItem.Text = "Closing Stock";
            this.closingStockToolStripMenuItem.Click += new System.EventHandler(this.closingStockToolStripMenuItem_Click);
            // 
            // todayProductToolStripMenuItem
            // 
            this.todayProductToolStripMenuItem.Name = "todayProductToolStripMenuItem";
            this.todayProductToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.todayProductToolStripMenuItem.Text = "Today Product";
            this.todayProductToolStripMenuItem.Click += new System.EventHandler(this.todayProductToolStripMenuItem_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.AutoScroll = true;
            this.mainpanel.AutoSize = true;
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 100);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1443, 357);
            this.mainpanel.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1443, 457);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pan_rep.ResumeLayout(false);
            this.pan_rep.PerformLayout();
            this.pan_master.ResumeLayout(false);
            this.pan_master.PerformLayout();
            this.pan_home.ResumeLayout(false);
            this.pan_home.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pit_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem goldToolStripMenuItem1;
        private ToolStripMenuItem whiteGoldToolStripMenuItem1;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem gemDiamondToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem cashierToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Panel mainpanel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lbl_username;
        private Panel panel3;
        private Label lbl_Home;
        private Label lbl_report;
        private Label lbl_master;
        private Panel panel6;
        private Panel pan_line_home;
        private Panel pan_line_master;
        private Panel pan_home;
        private Panel pan_rep;
        private Panel pan_master;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem closingStockToolStripMenuItem;
        private ToolStripMenuItem otherOutToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem todayProductToolStripMenuItem;
        private PictureBox pit_exit;
    }
}