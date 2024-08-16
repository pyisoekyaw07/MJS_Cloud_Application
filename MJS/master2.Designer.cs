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
            this.txt_item = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_update = new System.Windows.Forms.TextBox();
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
            this.btn_product = new FontAwesome.Sharp.IconButton();
            this.btn_shop = new FontAwesome.Sharp.IconButton();
            this.btn_setting = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(177, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 486);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_item);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txt_update);
            this.tabPage1.Location = new System.Drawing.Point(4, 8);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1222, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Master";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Pan_item);
            this.groupBox1.Controls.Add(this.pen_counter);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(476, 387);
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
            this.comboBox1.Location = new System.Drawing.Point(19, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 30);
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
            this.Pan_item.Location = new System.Drawing.Point(19, 79);
            this.Pan_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pan_item.Name = "Pan_item";
            this.Pan_item.Size = new System.Drawing.Size(436, 287);
            this.Pan_item.TabIndex = 22;
            // 
            // Gb_gp
            // 
            this.Gb_gp.Controls.Add(this.label8);
            this.Gb_gp.Controls.Add(this.label7);
            this.Gb_gp.Controls.Add(this.txt_purgp);
            this.Gb_gp.Controls.Add(this.txt_salegp);
            this.Gb_gp.Location = new System.Drawing.Point(107, 67);
            this.Gb_gp.Name = "Gb_gp";
            this.Gb_gp.Size = new System.Drawing.Size(261, 79);
            this.Gb_gp.TabIndex = 31;
            this.Gb_gp.TabStop = false;
            this.Gb_gp.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Purchase";
            // 
            // txt_purgp
            // 
            this.txt_purgp.Location = new System.Drawing.Point(8, 41);
            this.txt_purgp.Name = "txt_purgp";
            this.txt_purgp.Size = new System.Drawing.Size(120, 30);
            this.txt_purgp.TabIndex = 0;
            // 
            // txt_salegp
            // 
            this.txt_salegp.Location = new System.Drawing.Point(136, 41);
            this.txt_salegp.Name = "txt_salegp";
            this.txt_salegp.Size = new System.Drawing.Size(117, 30);
            this.txt_salegp.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 7);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 26);
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
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(112, 231);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 35);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_master_item
            // 
            this.txt_master_item.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_master_item.Location = new System.Drawing.Point(112, 99);
            this.txt_master_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_master_item.Name = "txt_master_item";
            this.txt_master_item.Size = new System.Drawing.Size(252, 30);
            this.txt_master_item.TabIndex = 17;
            // 
            // chk_parent
            // 
            this.chk_parent.AutoSize = true;
            this.chk_parent.Location = new System.Drawing.Point(112, 148);
            this.chk_parent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_parent.Name = "chk_parent";
            this.chk_parent.Size = new System.Drawing.Size(93, 26);
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
            this.Parentitem_combo.Location = new System.Drawing.Point(112, 178);
            this.Parentitem_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parentitem_combo.Name = "Parentitem_combo";
            this.Parentitem_combo.Size = new System.Drawing.Size(252, 30);
            this.Parentitem_combo.TabIndex = 16;
            this.Parentitem_combo.Click += new System.EventHandler(this.Parentitem_combo_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
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
            this.itemtype_combo.Location = new System.Drawing.Point(111, 35);
            this.itemtype_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemtype_combo.Name = "itemtype_combo";
            this.itemtype_combo.Size = new System.Drawing.Size(252, 30);
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
            this.pen_counter.Location = new System.Drawing.Point(19, 79);
            this.pen_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pen_counter.Name = "pen_counter";
            this.pen_counter.Size = new System.Drawing.Size(436, 287);
            this.pen_counter.TabIndex = 23;
            // 
            // btn_counter_save
            // 
            this.btn_counter_save.Location = new System.Drawing.Point(112, 165);
            this.btn_counter_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_counter_save.Name = "btn_counter_save";
            this.btn_counter_save.Size = new System.Drawing.Size(193, 36);
            this.btn_counter_save.TabIndex = 6;
            this.btn_counter_save.Text = "Save";
            this.btn_counter_save.UseVisualStyleBackColor = true;
            this.btn_counter_save.Click += new System.EventHandler(this.btn_counter_save_Click);
            // 
            // txt_Gem_counter
            // 
            this.txt_Gem_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_Gem_counter.Location = new System.Drawing.Point(112, 122);
            this.txt_Gem_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Gem_counter.Name = "txt_Gem_counter";
            this.txt_Gem_counter.Size = new System.Drawing.Size(193, 30);
            this.txt_Gem_counter.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gems";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Whitegold";
            // 
            // txt_WG_counter
            // 
            this.txt_WG_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WG_counter.Location = new System.Drawing.Point(112, 76);
            this.txt_WG_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WG_counter.Name = "txt_WG_counter";
            this.txt_WG_counter.Size = new System.Drawing.Size(193, 30);
            this.txt_WG_counter.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gold";
            // 
            // txt_G_counter
            // 
            this.txt_G_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_G_counter.Location = new System.Drawing.Point(112, 30);
            this.txt_G_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_G_counter.Name = "txt_G_counter";
            this.txt_G_counter.Size = new System.Drawing.Size(193, 30);
            this.txt_G_counter.TabIndex = 0;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(821, 314);
            this.txt_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(220, 30);
            this.txt_item.TabIndex = 28;
            this.txt_item.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(519, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 263);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(691, 257);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_update
            // 
            this.txt_update.BackColor = System.Drawing.Color.White;
            this.txt_update.Location = new System.Drawing.Point(519, 314);
            this.txt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_update.Name = "txt_update";
            this.txt_update.ReadOnly = true;
            this.txt_update.Size = new System.Drawing.Size(283, 30);
            this.txt_update.TabIndex = 19;
            this.txt_update.TextChanged += new System.EventHandler(this.txt_update_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 8);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1222, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_View);
            this.groupBox2.Controls.Add(this.txt_shop_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_shop_name);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txt_branch_name);
            this.groupBox2.Controls.Add(this.btn_shop_save);
            this.groupBox2.Location = new System.Drawing.Point(55, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(756, 211);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(127, 134);
            this.btn_View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(166, 32);
            this.btn_View.TabIndex = 33;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // txt_shop_name
            // 
            this.txt_shop_name.Location = new System.Drawing.Point(127, 22);
            this.txt_shop_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_shop_name.Name = "txt_shop_name";
            this.txt_shop_name.Size = new System.Drawing.Size(166, 30);
            this.txt_shop_name.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Branch Name";
            // 
            // lbl_shop_name
            // 
            this.lbl_shop_name.AutoSize = true;
            this.lbl_shop_name.Location = new System.Drawing.Point(6, 27);
            this.lbl_shop_name.Name = "lbl_shop_name";
            this.lbl_shop_name.Size = new System.Drawing.Size(104, 22);
            this.lbl_shop_name.TabIndex = 30;
            this.lbl_shop_name.Text = "Main Shop Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(330, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(402, 134);
            this.dataGridView2.TabIndex = 30;
            // 
            // txt_branch_name
            // 
            this.txt_branch_name.Location = new System.Drawing.Point(127, 60);
            this.txt_branch_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_branch_name.Name = "txt_branch_name";
            this.txt_branch_name.Size = new System.Drawing.Size(166, 30);
            this.txt_branch_name.TabIndex = 30;
            // 
            // btn_shop_save
            // 
            this.btn_shop_save.Location = new System.Drawing.Point(127, 97);
            this.btn_shop_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shop_save.Name = "btn_shop_save";
            this.btn_shop_save.Size = new System.Drawing.Size(166, 32);
            this.btn_shop_save.TabIndex = 30;
            this.btn_shop_save.Text = "Save";
            this.btn_shop_save.UseVisualStyleBackColor = true;
            this.btn_shop_save.Click += new System.EventHandler(this.btn_shop_save_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_sellingprice);
            this.tabPage3.Controls.Add(this.txt_sellingPrice);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 8);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1222, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "setting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_sellingprice
            // 
            this.btn_sellingprice.Location = new System.Drawing.Point(71, 112);
            this.btn_sellingprice.Name = "btn_sellingprice";
            this.btn_sellingprice.Size = new System.Drawing.Size(176, 36);
            this.btn_sellingprice.TabIndex = 2;
            this.btn_sellingprice.Text = "Selling Price";
            this.btn_sellingprice.UseVisualStyleBackColor = true;
            this.btn_sellingprice.Click += new System.EventHandler(this.btn_sellingprice_Click);
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingPrice.Location = new System.Drawing.Point(71, 60);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(176, 35);
            this.txt_sellingPrice.TabIndex = 1;
            this.txt_sellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sellingPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Selling Price";
            // 
            // txt_Time
            // 
            this.txt_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Time.AutoSize = true;
            this.txt_Time.Location = new System.Drawing.Point(46, 278);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(35, 13);
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
            this.txt_Date.Location = new System.Drawing.Point(46, 319);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(35, 13);
            this.txt_Date.TabIndex = 29;
            this.txt_Date.Text = "label8";
            this.txt_Date.Visible = false;
            // 
            // btn_product
            // 
            this.btn_product.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btn_product.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_product.IconSize = 20;
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(12, 18);
            this.btn_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(117, 38);
            this.btn_product.TabIndex = 32;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_shop
            // 
            this.btn_shop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.btn_shop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_shop.IconSize = 25;
            this.btn_shop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_shop.Location = new System.Drawing.Point(12, 69);
            this.btn_shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(117, 38);
            this.btn_shop.TabIndex = 33;
            this.btn_shop.Text = "Shop";
            this.btn_shop.UseVisualStyleBackColor = true;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btn_setting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_setting.IconSize = 25;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(12, 120);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(117, 38);
            this.btn_setting.TabIndex = 34;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // master2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 522);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_shop);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "master2";
            this.Text = "master2";
            this.Load += new System.EventHandler(this.master2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
            this.tabPage3.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btn_product;
        private FontAwesome.Sharp.IconButton btn_shop;
        private TabPage tabPage3;
        private GroupBox Gb_gp;
        private Label label8;
        private Label label7;
        private TextBox txt_salegp;
        private TextBox txt_purgp;
        private FontAwesome.Sharp.IconButton btn_setting;
        private TextBox txt_sellingPrice;
        private Label label9;
        private Button btn_sellingprice;
        protected TabControl tabControl1;
    }
}