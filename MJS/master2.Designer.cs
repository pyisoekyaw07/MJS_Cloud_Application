using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class master2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(master2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_update = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pan_item = new System.Windows.Forms.Panel();
            this.Gb_gp = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_purgp = new System.Windows.Forms.TextBox();
            this.txt_salegp = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_master_item = new System.Windows.Forms.TextBox();
            this.chk_parent = new System.Windows.Forms.CheckBox();
            this.Parentitem_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.itemtype_combo = new System.Windows.Forms.ComboBox();
            this.pen_counter = new System.Windows.Forms.Panel();
            this.btn_counter_save = new System.Windows.Forms.Button();
            this.txt_Gem_counter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_WG_counter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_G_counter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.txt_shop_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_shop_name = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_branch_name = new System.Windows.Forms.TextBox();
            this.btn_shop_save = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_sellingprice = new System.Windows.Forms.Button();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Date = new System.Windows.Forms.Label();
            this.Btn_Pd = new System.Windows.Forms.Button();
            this.Btn_Shop2 = new System.Windows.Forms.Button();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.setting_tab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fct = new System.Windows.Forms.TextBox();
            this.btn_fct = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bankcard = new System.Windows.Forms.TextBox();
            this.btn_bankcard = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_mobilebanking = new System.Windows.Forms.TextBox();
            this.btn_mobilebanking = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Pan_item.SuspendLayout();
            this.Gb_gp.SuspendLayout();
            this.pen_counter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.setting_tab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.tabControl1.ItemSize = new System.Drawing.Size(1, 4);
            this.tabControl1.Location = new System.Drawing.Point(236, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1640, 598);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 8);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Size = new System.Drawing.Size(1632, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Master";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_update);
            this.panel2.Controls.Add(this.txt_item);
            this.panel2.Location = new System.Drawing.Point(692, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 100);
            this.panel2.TabIndex = 31;
            // 
            // txt_update
            // 
            this.txt_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_update.BackColor = System.Drawing.Color.White;
            this.txt_update.Location = new System.Drawing.Point(30, 25);
            this.txt_update.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_update.Name = "txt_update";
            this.txt_update.ReadOnly = true;
            this.txt_update.Size = new System.Drawing.Size(376, 34);
            this.txt_update.TabIndex = 19;
            this.txt_update.TextChanged += new System.EventHandler(this.txt_update_TextChanged);
            // 
            // txt_item
            // 
            this.txt_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_item.Location = new System.Drawing.Point(430, 25);
            this.txt_item.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(292, 34);
            this.txt_item.TabIndex = 28;
            this.txt_item.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Pan_item);
            this.groupBox1.Controls.Add(this.pen_counter);
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(635, 476);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product and Counter Setup Form";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Item/Itemname",
            "GoldType",
            "Gold Price",
            "Source Remark",
            "Counter"});
            this.comboBox1.Location = new System.Drawing.Point(25, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 34);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Pan_item
            // 
            this.Pan_item.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pan_item.Controls.Add(this.Gb_gp);
            this.Pan_item.Controls.Add(this.radioButton1);
            this.Pan_item.Controls.Add(this.label2);
            this.Pan_item.Controls.Add(this.label1);
            this.Pan_item.Controls.Add(this.btn_save);
            this.Pan_item.Controls.Add(this.txt_master_item);
            this.Pan_item.Controls.Add(this.chk_parent);
            this.Pan_item.Controls.Add(this.Parentitem_combo);
            this.Pan_item.Controls.Add(this.button1);
            this.Pan_item.Controls.Add(this.itemtype_combo);
            this.Pan_item.Location = new System.Drawing.Point(25, 97);
            this.Pan_item.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Pan_item.Name = "Pan_item";
            this.Pan_item.Size = new System.Drawing.Size(581, 353);
            this.Pan_item.TabIndex = 22;
            // 
            // Gb_gp
            // 
            this.Gb_gp.Controls.Add(this.label8);
            this.Gb_gp.Controls.Add(this.label7);
            this.Gb_gp.Controls.Add(this.txt_purgp);
            this.Gb_gp.Controls.Add(this.txt_salegp);
            this.Gb_gp.Location = new System.Drawing.Point(143, 82);
            this.Gb_gp.Margin = new System.Windows.Forms.Padding(4);
            this.Gb_gp.Name = "Gb_gp";
            this.Gb_gp.Padding = new System.Windows.Forms.Padding(4);
            this.Gb_gp.Size = new System.Drawing.Size(348, 97);
            this.Gb_gp.TabIndex = 31;
            this.Gb_gp.TabStop = false;
            this.Gb_gp.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Purchase";
            // 
            // txt_purgp
            // 
            this.txt_purgp.Location = new System.Drawing.Point(11, 50);
            this.txt_purgp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_purgp.Name = "txt_purgp";
            this.txt_purgp.Size = new System.Drawing.Size(159, 34);
            this.txt_purgp.TabIndex = 0;
            // 
            // txt_salegp
            // 
            this.txt_salegp.Location = new System.Drawing.Point(181, 50);
            this.txt_salegp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salegp.Name = "txt_salegp";
            this.txt_salegp.Size = new System.Drawing.Size(155, 34);
            this.txt_salegp.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 9);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 33);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Update Mode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 284);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(160, 43);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_master_item
            // 
            this.txt_master_item.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_master_item.Location = new System.Drawing.Point(149, 122);
            this.txt_master_item.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_master_item.Name = "txt_master_item";
            this.txt_master_item.Size = new System.Drawing.Size(335, 34);
            this.txt_master_item.TabIndex = 17;
            // 
            // chk_parent
            // 
            this.chk_parent.AutoSize = true;
            this.chk_parent.Location = new System.Drawing.Point(149, 182);
            this.chk_parent.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chk_parent.Name = "chk_parent";
            this.chk_parent.Size = new System.Drawing.Size(121, 33);
            this.chk_parent.TabIndex = 18;
            this.chk_parent.Text = "Parent Item";
            this.chk_parent.UseVisualStyleBackColor = true;
            this.chk_parent.CheckedChanged += new System.EventHandler(this.chk_parent_CheckedChanged);
            // 
            // Parentitem_combo
            // 
            this.Parentitem_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parentitem_combo.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.Parentitem_combo.FormattingEnabled = true;
            this.Parentitem_combo.Items.AddRange(new object[] {
            "Gold",
            "WhiteGold",
            "Gems & Diamond"});
            this.Parentitem_combo.Location = new System.Drawing.Point(149, 219);
            this.Parentitem_combo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Parentitem_combo.Name = "Parentitem_combo";
            this.Parentitem_combo.Size = new System.Drawing.Size(335, 34);
            this.Parentitem_combo.TabIndex = 16;
            this.Parentitem_combo.Click += new System.EventHandler(this.Parentitem_combo_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemtype_combo
            // 
            this.itemtype_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemtype_combo.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.itemtype_combo.FormattingEnabled = true;
            this.itemtype_combo.Items.AddRange(new object[] {
            "Gold",
            "WhiteGold",
            "Gems & Diamond"});
            this.itemtype_combo.Location = new System.Drawing.Point(148, 43);
            this.itemtype_combo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.itemtype_combo.Name = "itemtype_combo";
            this.itemtype_combo.Size = new System.Drawing.Size(335, 34);
            this.itemtype_combo.TabIndex = 10;
            this.itemtype_combo.SelectedIndexChanged += new System.EventHandler(this.itemtype_combo_SelectedIndexChanged);
            // 
            // pen_counter
            // 
            this.pen_counter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pen_counter.Controls.Add(this.btn_counter_save);
            this.pen_counter.Controls.Add(this.txt_Gem_counter);
            this.pen_counter.Controls.Add(this.label6);
            this.pen_counter.Controls.Add(this.label5);
            this.pen_counter.Controls.Add(this.txt_WG_counter);
            this.pen_counter.Controls.Add(this.label4);
            this.pen_counter.Controls.Add(this.txt_G_counter);
            this.pen_counter.Location = new System.Drawing.Point(25, 97);
            this.pen_counter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pen_counter.Name = "pen_counter";
            this.pen_counter.Size = new System.Drawing.Size(581, 353);
            this.pen_counter.TabIndex = 23;
            // 
            // btn_counter_save
            // 
            this.btn_counter_save.Location = new System.Drawing.Point(149, 203);
            this.btn_counter_save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_counter_save.Name = "btn_counter_save";
            this.btn_counter_save.Size = new System.Drawing.Size(257, 44);
            this.btn_counter_save.TabIndex = 6;
            this.btn_counter_save.Text = "Save";
            this.btn_counter_save.UseVisualStyleBackColor = true;
            this.btn_counter_save.Click += new System.EventHandler(this.btn_counter_save_Click);
            // 
            // txt_Gem_counter
            // 
            this.txt_Gem_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_Gem_counter.Location = new System.Drawing.Point(149, 150);
            this.txt_Gem_counter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_Gem_counter.Name = "txt_Gem_counter";
            this.txt_Gem_counter.Size = new System.Drawing.Size(256, 34);
            this.txt_Gem_counter.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gems";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Whitegold";
            // 
            // txt_WG_counter
            // 
            this.txt_WG_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WG_counter.Location = new System.Drawing.Point(149, 94);
            this.txt_WG_counter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_WG_counter.Name = "txt_WG_counter";
            this.txt_WG_counter.Size = new System.Drawing.Size(256, 34);
            this.txt_WG_counter.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gold";
            // 
            // txt_G_counter
            // 
            this.txt_G_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_G_counter.Location = new System.Drawing.Point(149, 37);
            this.txt_G_counter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_G_counter.Name = "txt_G_counter";
            this.txt_G_counter.Size = new System.Drawing.Size(256, 34);
            this.txt_G_counter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(692, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 323);
            this.panel1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(904, 272);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 8);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Size = new System.Drawing.Size(1632, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_View);
            this.groupBox2.Controls.Add(this.txt_shop_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_shop_name);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txt_branch_name);
            this.groupBox2.Controls.Add(this.btn_shop_save);
            this.groupBox2.Location = new System.Drawing.Point(73, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(1008, 260);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(169, 165);
            this.btn_View.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(221, 39);
            this.btn_View.TabIndex = 33;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // txt_shop_name
            // 
            this.txt_shop_name.Location = new System.Drawing.Point(169, 27);
            this.txt_shop_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_shop_name.Name = "txt_shop_name";
            this.txt_shop_name.Size = new System.Drawing.Size(220, 34);
            this.txt_shop_name.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Branch Name";
            // 
            // lbl_shop_name
            // 
            this.lbl_shop_name.AutoSize = true;
            this.lbl_shop_name.Location = new System.Drawing.Point(8, 33);
            this.lbl_shop_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_shop_name.Name = "lbl_shop_name";
            this.lbl_shop_name.Size = new System.Drawing.Size(134, 29);
            this.lbl_shop_name.TabIndex = 30;
            this.lbl_shop_name.Text = "Main Shop Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(440, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(536, 165);
            this.dataGridView2.TabIndex = 30;
            // 
            // txt_branch_name
            // 
            this.txt_branch_name.Location = new System.Drawing.Point(169, 74);
            this.txt_branch_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_branch_name.Name = "txt_branch_name";
            this.txt_branch_name.Size = new System.Drawing.Size(220, 34);
            this.txt_branch_name.TabIndex = 30;
            // 
            // btn_shop_save
            // 
            this.btn_shop_save.Location = new System.Drawing.Point(169, 119);
            this.btn_shop_save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_shop_save.Name = "btn_shop_save";
            this.btn_shop_save.Size = new System.Drawing.Size(221, 39);
            this.btn_shop_save.TabIndex = 30;
            this.btn_shop_save.Text = "Save";
            this.btn_shop_save.UseVisualStyleBackColor = true;
            this.btn_shop_save.Click += new System.EventHandler(this.btn_shop_save_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.setting_tab);
            this.tabPage3.Controls.Add(this.dgv_show);
            this.tabPage3.Location = new System.Drawing.Point(4, 8);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1632, 586);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "setting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_sellingprice
            // 
            this.btn_sellingprice.Location = new System.Drawing.Point(141, 172);
            this.btn_sellingprice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sellingprice.Name = "btn_sellingprice";
            this.btn_sellingprice.Size = new System.Drawing.Size(235, 44);
            this.btn_sellingprice.TabIndex = 2;
            this.btn_sellingprice.Text = "Selling Price";
            this.btn_sellingprice.UseVisualStyleBackColor = true;
            this.btn_sellingprice.Click += new System.EventHandler(this.btn_sellingprice_Click);
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingPrice.Location = new System.Drawing.Point(141, 108);
            this.txt_sellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(233, 41);
            this.txt_sellingPrice.TabIndex = 1;
            this.txt_sellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sellingPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Selling Price";
            // 
            // txt_Time
            // 
            this.txt_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Time.AutoSize = true;
            this.txt_Time.Location = new System.Drawing.Point(64, 552);
            this.txt_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(44, 16);
            this.txt_Time.TabIndex = 28;
            this.txt_Time.Text = "label7";
            this.txt_Time.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Date.AutoSize = true;
            this.txt_Date.Location = new System.Drawing.Point(64, 603);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(44, 16);
            this.txt_Date.TabIndex = 29;
            this.txt_Date.Text = "label8";
            this.txt_Date.Visible = false;
            // 
            // Btn_Pd
            // 
            this.Btn_Pd.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pd.Location = new System.Drawing.Point(30, 39);
            this.Btn_Pd.Name = "Btn_Pd";
            this.Btn_Pd.Size = new System.Drawing.Size(175, 49);
            this.Btn_Pd.TabIndex = 27;
            this.Btn_Pd.Text = "Product";
            this.Btn_Pd.UseVisualStyleBackColor = true;
            this.Btn_Pd.Click += new System.EventHandler(this.Btn_Pd_Click);
            // 
            // Btn_Shop2
            // 
            this.Btn_Shop2.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Shop2.Location = new System.Drawing.Point(30, 106);
            this.Btn_Shop2.Name = "Btn_Shop2";
            this.Btn_Shop2.Size = new System.Drawing.Size(175, 49);
            this.Btn_Shop2.TabIndex = 35;
            this.Btn_Shop2.Text = "Shop";
            this.Btn_Shop2.UseVisualStyleBackColor = true;
            this.Btn_Shop2.Click += new System.EventHandler(this.Btn_Shop2_Click);
            // 
            // Btn_Set
            // 
            this.Btn_Set.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Set.Location = new System.Drawing.Point(30, 171);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(175, 49);
            this.Btn_Set.TabIndex = 36;
            this.Btn_Set.Text = "Setting";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // dgv_show
            // 
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(610, 82);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.RowHeadersWidth = 51;
            this.dgv_show.RowTemplate.Height = 24;
            this.dgv_show.Size = new System.Drawing.Size(661, 237);
            this.dgv_show.TabIndex = 3;
            // 
            // setting_tab
            // 
            this.setting_tab.Controls.Add(this.tabPage4);
            this.setting_tab.Controls.Add(this.tabPage5);
            this.setting_tab.Controls.Add(this.tabPage6);
            this.setting_tab.Controls.Add(this.tabPage7);
            this.setting_tab.Location = new System.Drawing.Point(21, 50);
            this.setting_tab.Name = "setting_tab";
            this.setting_tab.SelectedIndex = 0;
            this.setting_tab.Size = new System.Drawing.Size(568, 348);
            this.setting_tab.TabIndex = 4;
            this.setting_tab.SelectedIndexChanged += new System.EventHandler(this.setting_tab_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txt_sellingPrice);
            this.tabPage4.Controls.Add(this.btn_sellingprice);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(560, 309);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Selling Price";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.txt_fct);
            this.tabPage5.Controls.Add(this.btn_fct);
            this.tabPage5.Location = new System.Drawing.Point(4, 35);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(560, 309);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Foreign Currency";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Foreign Currency Type";
            // 
            // txt_fct
            // 
            this.txt_fct.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fct.Location = new System.Drawing.Point(166, 116);
            this.txt_fct.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fct.Name = "txt_fct";
            this.txt_fct.Size = new System.Drawing.Size(233, 41);
            this.txt_fct.TabIndex = 4;
            // 
            // btn_fct
            // 
            this.btn_fct.Location = new System.Drawing.Point(166, 180);
            this.btn_fct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fct.Name = "btn_fct";
            this.btn_fct.Size = new System.Drawing.Size(235, 44);
            this.btn_fct.TabIndex = 5;
            this.btn_fct.Text = "Add";
            this.btn_fct.UseVisualStyleBackColor = true;
            this.btn_fct.Click += new System.EventHandler(this.btn_fct_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.txt_pos);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txt_bankcard);
            this.tabPage6.Controls.Add(this.btn_bankcard);
            this.tabPage6.Location = new System.Drawing.Point(4, 35);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(560, 309);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Bank Card";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.txt_mobilebanking);
            this.tabPage7.Controls.Add(this.btn_mobilebanking);
            this.tabPage7.Location = new System.Drawing.Point(4, 35);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(560, 309);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Mobile Banking";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bank Card Type";
            // 
            // txt_bankcard
            // 
            this.txt_bankcard.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bankcard.Location = new System.Drawing.Point(163, 68);
            this.txt_bankcard.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bankcard.Name = "txt_bankcard";
            this.txt_bankcard.Size = new System.Drawing.Size(233, 41);
            this.txt_bankcard.TabIndex = 7;
            // 
            // btn_bankcard
            // 
            this.btn_bankcard.Location = new System.Drawing.Point(161, 231);
            this.btn_bankcard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bankcard.Name = "btn_bankcard";
            this.btn_bankcard.Size = new System.Drawing.Size(235, 44);
            this.btn_bankcard.TabIndex = 8;
            this.btn_bankcard.Text = "Add";
            this.btn_bankcard.UseVisualStyleBackColor = true;
            this.btn_bankcard.Click += new System.EventHandler(this.btn_bankcard_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "POS";
            // 
            // txt_pos
            // 
            this.txt_pos.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pos.Location = new System.Drawing.Point(163, 167);
            this.txt_pos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(233, 41);
            this.txt_pos.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Mobile Banking Type";
            // 
            // txt_mobilebanking
            // 
            this.txt_mobilebanking.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobilebanking.Location = new System.Drawing.Point(163, 120);
            this.txt_mobilebanking.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mobilebanking.Name = "txt_mobilebanking";
            this.txt_mobilebanking.Size = new System.Drawing.Size(233, 41);
            this.txt_mobilebanking.TabIndex = 7;
            // 
            // btn_mobilebanking
            // 
            this.btn_mobilebanking.Location = new System.Drawing.Point(163, 184);
            this.btn_mobilebanking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mobilebanking.Name = "btn_mobilebanking";
            this.btn_mobilebanking.Size = new System.Drawing.Size(235, 44);
            this.btn_mobilebanking.TabIndex = 8;
            this.btn_mobilebanking.Text = "Add";
            this.btn_mobilebanking.UseVisualStyleBackColor = true;
            this.btn_mobilebanking.Click += new System.EventHandler(this.btn_mobilebanking_Click);
            // 
            // master2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1892, 642);
            this.Controls.Add(this.Btn_Set);
            this.Controls.Add(this.Btn_Shop2);
            this.Controls.Add(this.Btn_Pd);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "master2";
            this.Text = "master2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.master2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Pan_item.ResumeLayout(false);
            this.Pan_item.PerformLayout();
            this.Gb_gp.ResumeLayout(false);
            this.Gb_gp.PerformLayout();
            this.pen_counter.ResumeLayout(false);
            this.pen_counter.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.setting_tab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private Panel Pan_item;
        private Label label2;
        private Label label1;
        private Button btn_save;
        private Button button1;
        private CheckBox chk_parent;
        private ComboBox itemtype_combo;
        private TextBox txt_master_item;
        private ComboBox Parentitem_combo;
        private Panel pen_counter;
        private Label label5;
        private TextBox txt_WG_counter;
        private Label label4;
        private TextBox txt_G_counter;
        private Button btn_counter_save;
        private TextBox txt_Gem_counter;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private Label txt_Time;
        private Label txt_Date;
        private Label lbl_shop_name;
        private TextBox txt_update;
        private TabPage tabPage2;
        private TextBox txt_branch_name;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button btn_shop_save;
        private TextBox txt_shop_name;
        private Label label3;
        private Button btn_View;
        private RadioButton radioButton1;
        private Panel panel1;
        private TextBox txt_item;
        private GroupBox groupBox1;
        private TabPage tabPage3;
        private GroupBox Gb_gp;
        private Label label8;
        private Label label7;
        private TextBox txt_salegp;
        private TextBox txt_purgp;
        private TextBox txt_sellingPrice;
        private Label label9;
        private Button btn_sellingprice;
        protected TabControl tabControl1;
        private Button Btn_Pd;
        private Button Btn_Shop2;
        private Button Btn_Set;
        private Panel panel2;
        private TabControl setting_tab;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label10;
        private TextBox txt_fct;
        private Button btn_fct;
        private DataGridView dgv_show;
        private TabPage tabPage6;
        private Label label12;
        private TextBox txt_pos;
        private Label label11;
        private TextBox txt_bankcard;
        private Button btn_bankcard;
        private TabPage tabPage7;
        private Label label13;
        private TextBox txt_mobilebanking;
        private Button btn_mobilebanking;
    }
}