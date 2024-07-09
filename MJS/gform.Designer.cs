using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class gform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add_photo = new System.Windows.Forms.Button();
            this.cmb_itemname = new System.Windows.Forms.ComboBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.cmb_gt = new System.Windows.Forms.ComboBox();
            this.cmb_remark = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_review = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_counter = new System.Windows.Forms.TextBox();
            this.txt_pur_no = new System.Windows.Forms.TextBox();
            this.txt_voucher = new System.Windows.Forms.TextBox();
            this.txt_totalamt = new System.Windows.Forms.TextBox();
            this.txt_rep = new System.Windows.Forms.TextBox();
            this.txt_mcost = new System.Windows.Forms.TextBox();
            this.total_S = new System.Windows.Forms.TextBox();
            this.total_Y = new System.Windows.Forms.TextBox();
            this.total_P = new System.Windows.Forms.TextBox();
            this.total_K = new System.Windows.Forms.TextBox();
            this.txt_WC = new System.Windows.Forms.TextBox();
            this.txt_WY = new System.Windows.Forms.TextBox();
            this.txt_WP = new System.Windows.Forms.TextBox();
            this.txt_WK = new System.Windows.Forms.TextBox();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_goldprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_incre_pid = new System.Windows.Forms.TextBox();
            this.txt_edit_check = new System.Windows.Forms.TextBox();
            this.txt_temparray_proid = new System.Windows.Forms.TextBox();
            this.txt_ince_proid = new System.Windows.Forms.TextBox();
            this.check_language = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_temparay = new System.Windows.Forms.TextBox();
            this.txt_result_id = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Dece = new System.Windows.Forms.TextBox();
            this.txt_temparay_pid = new System.Windows.Forms.TextBox();
            this.txt_result_pid = new System.Windows.Forms.TextBox();
            this.txt_Dece_pid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enter_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purvoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gold_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coledit = new System.Windows.Forms.DataGridViewImageColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_totalgm = new System.Windows.Forms.Label();
            this.lbl_totalamt = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_shop = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btn_cart = new Krypton.Toolkit.KryptonButton();
            this.btn_reg_save = new Krypton.Toolkit.KryptonButton();
            this.btn_reg_cancel = new Krypton.Toolkit.KryptonButton();
            this.btn_reg_preview = new Krypton.Toolkit.KryptonButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_photo
            // 
            this.btn_add_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_photo.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.btn_add_photo.Location = new System.Drawing.Point(392, 72);
            this.btn_add_photo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(107, 29);
            this.btn_add_photo.TabIndex = 14;
            this.btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            // 
            // cmb_itemname
            // 
            this.cmb_itemname.DropDownHeight = 150;
            this.cmb_itemname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_itemname.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.cmb_itemname.FormattingEnabled = true;
            this.cmb_itemname.IntegralHeight = false;
            this.cmb_itemname.Location = new System.Drawing.Point(157, 223);
            this.cmb_itemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_itemname.Name = "cmb_itemname";
            this.cmb_itemname.Size = new System.Drawing.Size(330, 30);
            this.cmb_itemname.TabIndex = 5;
            this.cmb_itemname.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cmb_item
            // 
            this.cmb_item.DropDownHeight = 150;
            this.cmb_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.IntegralHeight = false;
            this.cmb_item.Location = new System.Drawing.Point(157, 178);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(330, 30);
            this.cmb_item.TabIndex = 4;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cmb_item.Click += new System.EventHandler(this.comboBox3_Click);
            this.cmb_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // cmb_gt
            // 
            this.cmb_gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gt.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.cmb_gt.FormattingEnabled = true;
            this.cmb_gt.Location = new System.Drawing.Point(356, 134);
            this.cmb_gt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_gt.Name = "cmb_gt";
            this.cmb_gt.Size = new System.Drawing.Size(131, 30);
            this.cmb_gt.TabIndex = 3;
            this.cmb_gt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cmb_gt.Click += new System.EventHandler(this.comboBox2_Click);
            this.cmb_gt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // cmb_remark
            // 
            this.cmb_remark.DropDownHeight = 150;
            this.cmb_remark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_remark.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.cmb_remark.FormattingEnabled = true;
            this.cmb_remark.IntegralHeight = false;
            this.cmb_remark.Location = new System.Drawing.Point(157, 94);
            this.cmb_remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_remark.Name = "cmb_remark";
            this.cmb_remark.Size = new System.Drawing.Size(330, 30);
            this.cmb_remark.TabIndex = 2;
            this.cmb_remark.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_remark.Click += new System.EventHandler(this.comboBox1_Click);
            this.cmb_remark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(56, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(79, 53);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 117;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label19.Location = new System.Drawing.Point(27, 566);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 22);
            this.label19.TabIndex = 115;
            this.label19.Text = "စုစုပေါင်းတန်ဖိုး";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label18.Location = new System.Drawing.Point(28, 521);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 22);
            this.label18.TabIndex = 114;
            this.label18.Text = "ပြန်လဲအရှုံးတန်ဖိုး";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label17.Location = new System.Drawing.Point(27, 479);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 113;
            this.label17.Text = "လက်ခ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label16.Location = new System.Drawing.Point(27, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 112;
            this.label16.Text = "စုစုပေါင်းရွှေချိန်";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label15.Location = new System.Drawing.Point(561, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 22);
            this.label15.TabIndex = 111;
            this.label15.Text = "ဘားကုဒ်နံပါတ်";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label14.Location = new System.Drawing.Point(561, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 22);
            this.label14.TabIndex = 110;
            this.label14.Text = "အရောင်းကောင်တာ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label12.Location = new System.Drawing.Point(18, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 22);
            this.label12.TabIndex = 108;
            this.label12.Text = "အ၀ယ်ဘောက်ချာနံပါတ်";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label11.Location = new System.Drawing.Point(-570, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 107;
            // 
            // btn_review
            // 
            this.btn_review.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.btn_review.Font = new System.Drawing.Font("Pyidaungsu", 11.25F);
            this.btn_review.ForeColor = System.Drawing.Color.White;
            this.btn_review.Image = ((System.Drawing.Image)(resources.GetObject("btn_review.Image")));
            this.btn_review.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_review.Location = new System.Drawing.Point(780, 781);
            this.btn_review.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(156, 47);
            this.btn_review.TabIndex = 106;
            this.btn_review.Text = "&Preview";
            this.btn_review.UseVisualStyleBackColor = false;
            this.btn_review.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label23.Location = new System.Drawing.Point(561, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 22);
            this.label23.TabIndex = 128;
            this.label23.Text = "စက်ဘောက်ချာနံပါတ်";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.btn_cancel.Font = new System.Drawing.Font("Pyidaungsu", 11.25F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(618, 781);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(156, 47);
            this.btn_cancel.TabIndex = 105;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Font = new System.Drawing.Font("Pyidaungsu", 11.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(456, 781);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 47);
            this.btn_save.TabIndex = 104;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label10.Location = new System.Drawing.Point(19, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 22);
            this.label10.TabIndex = 103;
            this.label10.Text = "ပစ္စည်းအမျိုးအစား";
            // 
            // txt_barcode
            // 
            this.txt_barcode.BackColor = System.Drawing.Color.White;
            this.txt_barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_barcode.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_barcode.ForeColor = System.Drawing.Color.Black;
            this.txt_barcode.Location = new System.Drawing.Point(711, 134);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_barcode.Multiline = true;
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.ReadOnly = true;
            this.txt_barcode.Size = new System.Drawing.Size(183, 30);
            this.txt_barcode.TabIndex = 102;
            this.txt_barcode.TabStop = false;
            // 
            // txt_counter
            // 
            this.txt_counter.BackColor = System.Drawing.Color.White;
            this.txt_counter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_counter.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_counter.ForeColor = System.Drawing.Color.Black;
            this.txt_counter.Location = new System.Drawing.Point(711, 54);
            this.txt_counter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_counter.Multiline = true;
            this.txt_counter.Name = "txt_counter";
            this.txt_counter.ReadOnly = true;
            this.txt_counter.Size = new System.Drawing.Size(183, 30);
            this.txt_counter.TabIndex = 100;
            this.txt_counter.TabStop = false;
            // 
            // txt_pur_no
            // 
            this.txt_pur_no.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_pur_no.Location = new System.Drawing.Point(157, 51);
            this.txt_pur_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pur_no.Name = "txt_pur_no";
            this.txt_pur_no.Size = new System.Drawing.Size(175, 30);
            this.txt_pur_no.TabIndex = 1;
            // 
            // txt_voucher
            // 
            this.txt_voucher.BackColor = System.Drawing.Color.White;
            this.txt_voucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_voucher.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_voucher.ForeColor = System.Drawing.Color.Black;
            this.txt_voucher.Location = new System.Drawing.Point(711, 16);
            this.txt_voucher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_voucher.Multiline = true;
            this.txt_voucher.Name = "txt_voucher";
            this.txt_voucher.ReadOnly = true;
            this.txt_voucher.Size = new System.Drawing.Size(183, 30);
            this.txt_voucher.TabIndex = 98;
            this.txt_voucher.TabStop = false;
            // 
            // txt_totalamt
            // 
            this.txt_totalamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.txt_totalamt.Enabled = false;
            this.txt_totalamt.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_totalamt.Location = new System.Drawing.Point(157, 563);
            this.txt_totalamt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalamt.Multiline = true;
            this.txt_totalamt.Name = "txt_totalamt";
            this.txt_totalamt.Size = new System.Drawing.Size(189, 30);
            this.txt_totalamt.TabIndex = 96;
            this.txt_totalamt.TabStop = false;
            // 
            // txt_rep
            // 
            this.txt_rep.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_rep.Location = new System.Drawing.Point(158, 518);
            this.txt_rep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rep.Name = "txt_rep";
            this.txt_rep.Size = new System.Drawing.Size(189, 30);
            this.txt_rep.TabIndex = 12;
            this.txt_rep.TextChanged += new System.EventHandler(this.txt_rep_TextChanged);
            this.txt_rep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_KeyPress);
            this.txt_rep.Leave += new System.EventHandler(this.txt_rep_Leave);
            // 
            // txt_mcost
            // 
            this.txt_mcost.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_mcost.Location = new System.Drawing.Point(158, 474);
            this.txt_mcost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mcost.Name = "txt_mcost";
            this.txt_mcost.Size = new System.Drawing.Size(189, 30);
            this.txt_mcost.TabIndex = 11;
            this.txt_mcost.TextChanged += new System.EventHandler(this.txt_mcost_TextChanged);
            this.txt_mcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mcost_KeyPress);
            this.txt_mcost.Leave += new System.EventHandler(this.txt_mcost_Leave);
            // 
            // total_S
            // 
            this.total_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.total_S.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.total_S.Location = new System.Drawing.Point(355, 429);
            this.total_S.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total_S.Multiline = true;
            this.total_S.Name = "total_S";
            this.total_S.ReadOnly = true;
            this.total_S.Size = new System.Drawing.Size(59, 30);
            this.total_S.TabIndex = 93;
            this.total_S.TabStop = false;
            this.total_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Y
            // 
            this.total_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.total_Y.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.total_Y.Location = new System.Drawing.Point(290, 428);
            this.total_Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total_Y.Multiline = true;
            this.total_Y.Name = "total_Y";
            this.total_Y.ReadOnly = true;
            this.total_Y.Size = new System.Drawing.Size(59, 30);
            this.total_Y.TabIndex = 92;
            this.total_Y.TabStop = false;
            this.total_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_P
            // 
            this.total_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.total_P.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.total_P.Location = new System.Drawing.Point(224, 428);
            this.total_P.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total_P.Multiline = true;
            this.total_P.Name = "total_P";
            this.total_P.ReadOnly = true;
            this.total_P.Size = new System.Drawing.Size(59, 30);
            this.total_P.TabIndex = 91;
            this.total_P.TabStop = false;
            this.total_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_K
            // 
            this.total_K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.total_K.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.total_K.Location = new System.Drawing.Point(158, 428);
            this.total_K.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total_K.Multiline = true;
            this.total_K.Name = "total_K";
            this.total_K.ReadOnly = true;
            this.total_K.Size = new System.Drawing.Size(59, 30);
            this.total_K.TabIndex = 90;
            this.total_K.TabStop = false;
            this.total_K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_WC
            // 
            this.txt_WC.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WC.Location = new System.Drawing.Point(354, 388);
            this.txt_WC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WC.Name = "txt_WC";
            this.txt_WC.Size = new System.Drawing.Size(59, 30);
            this.txt_WC.TabIndex = 10;
            this.txt_WC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WC.TextChanged += new System.EventHandler(this.txt_YC_TextChanged);
            this.txt_WC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YC_KeyPress);
            this.txt_WC.Leave += new System.EventHandler(this.txt_YC_Leave);
            // 
            // txt_WY
            // 
            this.txt_WY.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WY.Location = new System.Drawing.Point(289, 388);
            this.txt_WY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WY.Name = "txt_WY";
            this.txt_WY.Size = new System.Drawing.Size(59, 30);
            this.txt_WY.TabIndex = 9;
            this.txt_WY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WY.TextChanged += new System.EventHandler(this.txt_YY_TextChanged);
            this.txt_WY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YY_KeyPress);
            this.txt_WY.Leave += new System.EventHandler(this.txt_YY_Leave);
            // 
            // txt_WP
            // 
            this.txt_WP.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WP.Location = new System.Drawing.Point(223, 388);
            this.txt_WP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WP.Name = "txt_WP";
            this.txt_WP.Size = new System.Drawing.Size(59, 30);
            this.txt_WP.TabIndex = 8;
            this.txt_WP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WP.TextChanged += new System.EventHandler(this.txt_YP_TextChanged);
            this.txt_WP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YP_KeyPress);
            this.txt_WP.Leave += new System.EventHandler(this.txt_YP_Leave);
            // 
            // txt_WK
            // 
            this.txt_WK.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_WK.Location = new System.Drawing.Point(157, 388);
            this.txt_WK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_WK.Name = "txt_WK";
            this.txt_WK.Size = new System.Drawing.Size(59, 30);
            this.txt_WK.TabIndex = 7;
            this.txt_WK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_WK.TextChanged += new System.EventHandler(this.txt_YK_TextChanged);
            this.txt_WK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YK_KeyPress);
            this.txt_WK.Leave += new System.EventHandler(this.txt_YK_Leave);
            // 
            // txt_s
            // 
            this.txt_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.txt_s.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_s.Location = new System.Drawing.Point(352, 347);
            this.txt_s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_s.Multiline = true;
            this.txt_s.Name = "txt_s";
            this.txt_s.ReadOnly = true;
            this.txt_s.Size = new System.Drawing.Size(59, 30);
            this.txt_s.TabIndex = 85;
            this.txt_s.TabStop = false;
            this.txt_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_y
            // 
            this.txt_y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.txt_y.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_y.Location = new System.Drawing.Point(288, 347);
            this.txt_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_y.Multiline = true;
            this.txt_y.Name = "txt_y";
            this.txt_y.ReadOnly = true;
            this.txt_y.Size = new System.Drawing.Size(59, 30);
            this.txt_y.TabIndex = 84;
            this.txt_y.TabStop = false;
            this.txt_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_p
            // 
            this.txt_p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.txt_p.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_p.Location = new System.Drawing.Point(223, 347);
            this.txt_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_p.Multiline = true;
            this.txt_p.Name = "txt_p";
            this.txt_p.ReadOnly = true;
            this.txt_p.Size = new System.Drawing.Size(59, 30);
            this.txt_p.TabIndex = 83;
            this.txt_p.TabStop = false;
            this.txt_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 82;
            this.label3.Text = "အ၀င်စာရင်းမှတ်ချက်";
            // 
            // txt_goldprice
            // 
            this.txt_goldprice.BackColor = System.Drawing.SystemColors.Window;
            this.txt_goldprice.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_goldprice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_goldprice.Location = new System.Drawing.Point(157, 134);
            this.txt_goldprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_goldprice.Name = "txt_goldprice";
            this.txt_goldprice.Size = new System.Drawing.Size(126, 30);
            this.txt_goldprice.TabIndex = 200;
            this.txt_goldprice.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label8.Location = new System.Drawing.Point(18, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 80;
            this.label8.Text = "ရွှေစျေး";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label9.Location = new System.Drawing.Point(301, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 22);
            this.label9.TabIndex = 79;
            this.label9.Text = "ရွှေရည်";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_k
            // 
            this.txt_k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.txt_k.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_k.Location = new System.Drawing.Point(157, 347);
            this.txt_k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_k.Multiline = true;
            this.txt_k.Name = "txt_k";
            this.txt_k.ReadOnly = true;
            this.txt_k.Size = new System.Drawing.Size(59, 30);
            this.txt_k.TabIndex = 78;
            this.txt_k.TabStop = false;
            this.txt_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label7.Location = new System.Drawing.Point(27, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 77;
            this.label7.Text = "အလျော့တွက်";
            // 
            // txt_gm
            // 
            this.txt_gm.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_gm.Location = new System.Drawing.Point(157, 268);
            this.txt_gm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gm.Name = "txt_gm";
            this.txt_gm.Size = new System.Drawing.Size(125, 30);
            this.txt_gm.TabIndex = 6;
            this.txt_gm.TextChanged += new System.EventHandler(this.txt_gm_TextChanged);
            this.txt_gm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gm_KeyPress);
            this.txt_gm.Leave += new System.EventHandler(this.txt_gm_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label6.Location = new System.Drawing.Point(27, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 75;
            this.label6.Text = "ရွှေအသားတင်";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label5.Location = new System.Drawing.Point(27, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "အလေးချိန်(ဂရမ်)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label4.Location = new System.Drawing.Point(21, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "ပစ္စည်းအမျိုးအမည်";
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_time.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_time.ForeColor = System.Drawing.Color.Black;
            this.txt_time.Location = new System.Drawing.Point(353, 9);
            this.txt_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_time.Multiline = true;
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(134, 30);
            this.txt_time.TabIndex = 72;
            this.txt_time.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label2.Location = new System.Drawing.Point(301, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 71;
            this.label2.Text = "အချိန်";
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_date.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_date.ForeColor = System.Drawing.Color.Black;
            this.txt_date.Location = new System.Drawing.Point(157, 9);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Multiline = true;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(126, 30);
            this.txt_date.TabIndex = 70;
            this.txt_date.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "ရက်စွဲ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_incre_pid);
            this.groupBox1.Controls.Add(this.txt_edit_check);
            this.groupBox1.Controls.Add(this.txt_temparray_proid);
            this.groupBox1.Controls.Add(this.txt_ince_proid);
            this.groupBox1.Controls.Add(this.check_language);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txt_temparay);
            this.groupBox1.Controls.Add(this.btn_add_photo);
            this.groupBox1.Controls.Add(this.txt_result_id);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txt_Dece);
            this.groupBox1.Controls.Add(this.txt_temparay_pid);
            this.groupBox1.Controls.Add(this.txt_result_pid);
            this.groupBox1.Controls.Add(this.txt_Dece_pid);
            this.groupBox1.Location = new System.Drawing.Point(558, 632);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(531, 127);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "requirment for calculation";
            this.groupBox1.Visible = false;
            // 
            // txt_incre_pid
            // 
            this.txt_incre_pid.Location = new System.Drawing.Point(265, 90);
            this.txt_incre_pid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_incre_pid.Name = "txt_incre_pid";
            this.txt_incre_pid.Size = new System.Drawing.Size(100, 20);
            this.txt_incre_pid.TabIndex = 152;
            // 
            // txt_edit_check
            // 
            this.txt_edit_check.Location = new System.Drawing.Point(432, 17);
            this.txt_edit_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_edit_check.Name = "txt_edit_check";
            this.txt_edit_check.Size = new System.Drawing.Size(54, 20);
            this.txt_edit_check.TabIndex = 213;
            this.txt_edit_check.Text = "0";
            this.txt_edit_check.Visible = false;
            // 
            // txt_temparray_proid
            // 
            this.txt_temparray_proid.Location = new System.Drawing.Point(152, 90);
            this.txt_temparray_proid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_temparray_proid.Name = "txt_temparray_proid";
            this.txt_temparray_proid.Size = new System.Drawing.Size(107, 20);
            this.txt_temparray_proid.TabIndex = 151;
            // 
            // txt_ince_proid
            // 
            this.txt_ince_proid.Location = new System.Drawing.Point(86, 90);
            this.txt_ince_proid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ince_proid.Name = "txt_ince_proid";
            this.txt_ince_proid.Size = new System.Drawing.Size(57, 20);
            this.txt_ince_proid.TabIndex = 150;
            // 
            // check_language
            // 
            this.check_language.Location = new System.Drawing.Point(417, 44);
            this.check_language.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_language.Name = "check_language";
            this.check_language.Size = new System.Drawing.Size(100, 20);
            this.check_language.TabIndex = 149;
            this.check_language.Text = "myanmar";
            this.check_language.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 13);
            this.label28.TabIndex = 148;
            this.label28.Text = "product No";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 147;
            this.label27.Text = "invoice No";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(264, 15);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 146;
            this.label26.Text = "temparray";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(152, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 145;
            this.label24.Text = "result Id";
            // 
            // txt_temparay
            // 
            this.txt_temparay.Location = new System.Drawing.Point(264, 32);
            this.txt_temparay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_temparay.Name = "txt_temparay";
            this.txt_temparay.Size = new System.Drawing.Size(100, 20);
            this.txt_temparay.TabIndex = 144;
            // 
            // txt_result_id
            // 
            this.txt_result_id.Location = new System.Drawing.Point(151, 32);
            this.txt_result_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_id.Name = "txt_result_id";
            this.txt_result_id.Size = new System.Drawing.Size(107, 20);
            this.txt_result_id.TabIndex = 143;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(86, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 141;
            this.label25.Text = "Decre Id";
            // 
            // txt_Dece
            // 
            this.txt_Dece.Location = new System.Drawing.Point(88, 31);
            this.txt_Dece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Dece.Name = "txt_Dece";
            this.txt_Dece.Size = new System.Drawing.Size(57, 20);
            this.txt_Dece.TabIndex = 139;
            // 
            // txt_temparay_pid
            // 
            this.txt_temparay_pid.Location = new System.Drawing.Point(264, 58);
            this.txt_temparay_pid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_temparay_pid.Name = "txt_temparay_pid";
            this.txt_temparay_pid.Size = new System.Drawing.Size(100, 20);
            this.txt_temparay_pid.TabIndex = 138;
            // 
            // txt_result_pid
            // 
            this.txt_result_pid.Location = new System.Drawing.Point(152, 58);
            this.txt_result_pid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_pid.Name = "txt_result_pid";
            this.txt_result_pid.Size = new System.Drawing.Size(106, 20);
            this.txt_result_pid.TabIndex = 137;
            // 
            // txt_Dece_pid
            // 
            this.txt_Dece_pid.Location = new System.Drawing.Point(88, 58);
            this.txt_Dece_pid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Dece_pid.Name = "txt_Dece_pid";
            this.txt_Dece_pid.Size = new System.Drawing.Size(57, 20);
            this.txt_Dece_pid.TabIndex = 136;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(122)))), ((int)(((byte)(173)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Pyidaungsu", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.date,
            this.time,
            this.Voucher,
            this.enter_remark,
            this.purvoc,
            this.barcode,
            this.goldtype,
            this.gold_price,
            this.Items,
            this.item_name,
            this.gm,
            this.K,
            this.P,
            this.Y,
            this.S,
            this.wk,
            this.wp,
            this.wy,
            this.ws,
            this.tk,
            this.tp,
            this.ty,
            this.ts,
            this.mcost,
            this.repamt,
            this.total_amt,
            this.remark,
            this.employee,
            this.shop,
            this.Form,
            this.type,
            this.coledit});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Pyidaungsu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(565, 232);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Pyidaungsu", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(750, 311);
            this.dataGridView1.TabIndex = 201;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // image
            // 
            this.image.HeaderText = "ဓါတ်ပုံ";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "ရက်စွဲ";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "အချိန်";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.Width = 125;
            // 
            // Voucher
            // 
            this.Voucher.HeaderText = "ဘောက်ချာနံပါတ်";
            this.Voucher.MinimumWidth = 6;
            this.Voucher.Name = "Voucher";
            this.Voucher.Width = 150;
            // 
            // enter_remark
            // 
            this.enter_remark.HeaderText = "အ၀င်စာရင်းမှတ်ချက်";
            this.enter_remark.MinimumWidth = 6;
            this.enter_remark.Name = "enter_remark";
            this.enter_remark.Width = 132;
            // 
            // purvoc
            // 
            this.purvoc.HeaderText = "အ၀ယ်ဘောက်ချာနံပါတ်";
            this.purvoc.MinimumWidth = 6;
            this.purvoc.Name = "purvoc";
            this.purvoc.Width = 148;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "ဘားကုဒ်နံပါတ်";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.Width = 105;
            // 
            // goldtype
            // 
            this.goldtype.HeaderText = "ရွှေရည်";
            this.goldtype.MinimumWidth = 6;
            this.goldtype.Name = "goldtype";
            this.goldtype.Width = 68;
            // 
            // gold_price
            // 
            this.gold_price.HeaderText = "ရွှေစျေး";
            this.gold_price.MinimumWidth = 6;
            this.gold_price.Name = "gold_price";
            this.gold_price.Width = 68;
            // 
            // Items
            // 
            this.Items.HeaderText = "ပစ္စည်းအမျိုးအစား";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.Width = 119;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "ပစ္စည်းအမျိုးအမည်";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.Width = 122;
            // 
            // gm
            // 
            this.gm.HeaderText = "ဂရမ်ချိန်";
            this.gm.MinimumWidth = 6;
            this.gm.Name = "gm";
            this.gm.Width = 72;
            // 
            // K
            // 
            this.K.HeaderText = "ကျပ်";
            this.K.MinimumWidth = 6;
            this.K.Name = "K";
            this.K.Width = 57;
            // 
            // P
            // 
            this.P.HeaderText = "ပဲ";
            this.P.MinimumWidth = 6;
            this.P.Name = "P";
            this.P.Width = 57;
            // 
            // Y
            // 
            this.Y.HeaderText = "ရွေး";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 57;
            // 
            // S
            // 
            this.S.HeaderText = "စိတ်";
            this.S.MinimumWidth = 6;
            this.S.Name = "S";
            this.S.Width = 57;
            // 
            // wk
            // 
            this.wk.HeaderText = "ကျပ်";
            this.wk.MinimumWidth = 6;
            this.wk.Name = "wk";
            this.wk.Width = 57;
            // 
            // wp
            // 
            this.wp.HeaderText = "ပဲ";
            this.wp.MinimumWidth = 6;
            this.wp.Name = "wp";
            this.wp.Width = 57;
            // 
            // wy
            // 
            this.wy.HeaderText = "ရွေး";
            this.wy.MinimumWidth = 6;
            this.wy.Name = "wy";
            this.wy.Width = 57;
            // 
            // ws
            // 
            this.ws.HeaderText = "စိတ်";
            this.ws.MinimumWidth = 6;
            this.ws.Name = "ws";
            this.ws.Width = 57;
            // 
            // tk
            // 
            this.tk.HeaderText = "ကျပ်";
            this.tk.MinimumWidth = 6;
            this.tk.Name = "tk";
            this.tk.Width = 57;
            // 
            // tp
            // 
            this.tp.HeaderText = "ပဲ";
            this.tp.MinimumWidth = 6;
            this.tp.Name = "tp";
            this.tp.Width = 57;
            // 
            // ty
            // 
            this.ty.HeaderText = "ရွေး";
            this.ty.MinimumWidth = 6;
            this.ty.Name = "ty";
            this.ty.Width = 57;
            // 
            // ts
            // 
            this.ts.HeaderText = "စိတ်";
            this.ts.MinimumWidth = 6;
            this.ts.Name = "ts";
            this.ts.Width = 57;
            // 
            // mcost
            // 
            this.mcost.HeaderText = "လက်ခ";
            this.mcost.MinimumWidth = 6;
            this.mcost.Name = "mcost";
            this.mcost.Width = 125;
            // 
            // repamt
            // 
            this.repamt.HeaderText = "ပြန်လဲအရှုံးတန်ဖိုး";
            this.repamt.MinimumWidth = 6;
            this.repamt.Name = "repamt";
            this.repamt.Width = 125;
            // 
            // total_amt
            // 
            this.total_amt.HeaderText = "စုစုပေါင်းတန်ဖိုး";
            this.total_amt.MinimumWidth = 6;
            this.total_amt.Name = "total_amt";
            this.total_amt.Width = 125;
            // 
            // remark
            // 
            this.remark.HeaderText = "မှတ်ချက်";
            this.remark.MinimumWidth = 6;
            this.remark.Name = "remark";
            this.remark.Width = 200;
            // 
            // employee
            // 
            this.employee.HeaderText = "စာရင်းသွင်းသူအမည်";
            this.employee.MinimumWidth = 6;
            this.employee.Name = "employee";
            this.employee.Width = 150;
            // 
            // shop
            // 
            this.shop.HeaderText = "ဆိုင်အမှတ်";
            this.shop.MinimumWidth = 6;
            this.shop.Name = "shop";
            this.shop.Width = 125;
            // 
            // Form
            // 
            this.Form.HeaderText = "အသုံးပြုသည့်ဖောင်";
            this.Form.MinimumWidth = 6;
            this.Form.Name = "Form";
            this.Form.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "အရောင်းကောင်တာ";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // coledit
            // 
            this.coledit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            this.coledit.DefaultCellStyle = dataGridViewCellStyle13;
            this.coledit.Description = "Edit";
            this.coledit.HeaderText = "";
            this.coledit.Image = ((System.Drawing.Image)(resources.GetObject("coledit.Image")));
            this.coledit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.coledit.MinimumWidth = 6;
            this.coledit.Name = "coledit";
            this.coledit.Width = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label13.Location = new System.Drawing.Point(169, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 22);
            this.label13.TabIndex = 202;
            this.label13.Text = "ကျပ်";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label29.Location = new System.Drawing.Point(242, 314);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 22);
            this.label29.TabIndex = 203;
            this.label29.Text = "ပဲ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label30.Location = new System.Drawing.Point(301, 314);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 22);
            this.label30.TabIndex = 204;
            this.label30.Text = "ရွေး";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label31.Location = new System.Drawing.Point(365, 315);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 22);
            this.label31.TabIndex = 205;
            this.label31.Text = "စိတ်";
            // 
            // lbl_totalgm
            // 
            this.lbl_totalgm.BackColor = System.Drawing.Color.White;
            this.lbl_totalgm.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_totalgm.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalgm.Location = new System.Drawing.Point(137, 54);
            this.lbl_totalgm.Name = "lbl_totalgm";
            this.lbl_totalgm.Size = new System.Drawing.Size(118, 17);
            this.lbl_totalgm.TabIndex = 124;
            this.lbl_totalgm.Text = "0";
            this.lbl_totalgm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalamt
            // 
            this.lbl_totalamt.BackColor = System.Drawing.Color.White;
            this.lbl_totalamt.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_totalamt.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalamt.Location = new System.Drawing.Point(137, 20);
            this.lbl_totalamt.Name = "lbl_totalamt";
            this.lbl_totalamt.Size = new System.Drawing.Size(118, 18);
            this.lbl_totalamt.TabIndex = 124;
            this.lbl_totalamt.Text = "0";
            this.lbl_totalamt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 400;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(711, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(183, 30);
            this.textBox2.TabIndex = 214;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Gold Register";
            // 
            // txt_shop
            // 
            this.txt_shop.BackColor = System.Drawing.Color.White;
            this.txt_shop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_shop.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_shop.ForeColor = System.Drawing.Color.Black;
            this.txt_shop.Location = new System.Drawing.Point(711, 175);
            this.txt_shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_shop.Multiline = true;
            this.txt_shop.Name = "txt_shop";
            this.txt_shop.ReadOnly = true;
            this.txt_shop.Size = new System.Drawing.Size(183, 30);
            this.txt_shop.TabIndex = 213;
            this.txt_shop.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label32.Location = new System.Drawing.Point(561, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(108, 22);
            this.label32.TabIndex = 212;
            this.label32.Text = "အသုံးပြုသည့်ဖောင်";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label22.Location = new System.Drawing.Point(561, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 22);
            this.label22.TabIndex = 211;
            this.label22.Text = "ဆိုင်အမှတ်";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label20.Location = new System.Drawing.Point(27, 737);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 22);
            this.label20.TabIndex = 212;
            this.label20.Text = "မှတ်ချက်";
            // 
            // txt_remark
            // 
            this.txt_remark.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_remark.Location = new System.Drawing.Point(156, 712);
            this.txt_remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(193, 56);
            this.txt_remark.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(157, 610);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(191, 82);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label34.Location = new System.Drawing.Point(25, 632);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 22);
            this.label34.TabIndex = 217;
            this.label34.Text = "ဓါတ်ပုံ";
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.White;
            this.lbl_qty.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_qty.ForeColor = System.Drawing.Color.Black;
            this.lbl_qty.Location = new System.Drawing.Point(137, 89);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(118, 17);
            this.lbl_qty.TabIndex = 220;
            this.lbl_qty.Text = "0";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.lbl_qty);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.lbl_totalgm);
            this.groupBox3.Controls.Add(this.lbl_totalamt);
            this.groupBox3.Location = new System.Drawing.Point(1016, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(271, 120);
            this.groupBox3.TabIndex = 290;
            this.groupBox3.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label35.Location = new System.Drawing.Point(33, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 13);
            this.label35.TabIndex = 286;
            this.label35.Text = "TOTAL AMOUNT";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label37.Location = new System.Drawing.Point(33, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 13);
            this.label37.TabIndex = 288;
            this.label37.Text = "TOTALQTY";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label38.Location = new System.Drawing.Point(33, 56);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(62, 13);
            this.label38.TabIndex = 287;
            this.label38.Text = "TOTAL GM";
            // 
            // btn_cart
            // 
            this.btn_cart.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btn_cart.Location = new System.Drawing.Point(156, 788);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(193, 40);
            this.btn_cart.TabIndex = 293;
            this.btn_cart.Values.Text = "Add To Cart";
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_reg_save
            // 
            this.btn_reg_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reg_save.Location = new System.Drawing.Point(762, 563);
            this.btn_reg_save.Name = "btn_reg_save";
            this.btn_reg_save.Size = new System.Drawing.Size(170, 35);
            this.btn_reg_save.TabIndex = 294;
            this.btn_reg_save.Values.Text = "&Save";
            this.btn_reg_save.Click += new System.EventHandler(this.btn_reg_save_Click);
            // 
            // btn_reg_cancel
            // 
            this.btn_reg_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reg_cancel.Location = new System.Drawing.Point(955, 563);
            this.btn_reg_cancel.Name = "btn_reg_cancel";
            this.btn_reg_cancel.Size = new System.Drawing.Size(170, 35);
            this.btn_reg_cancel.TabIndex = 295;
            this.btn_reg_cancel.Values.Text = "&Cancel";
            this.btn_reg_cancel.Click += new System.EventHandler(this.btn_reg_cancel_Click);
            // 
            // btn_reg_preview
            // 
            this.btn_reg_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reg_preview.Location = new System.Drawing.Point(1146, 563);
            this.btn_reg_preview.Name = "btn_reg_preview";
            this.btn_reg_preview.Size = new System.Drawing.Size(170, 35);
            this.btn_reg_preview.TabIndex = 296;
            this.btn_reg_preview.Values.Text = "&Preview";
            this.btn_reg_preview.Click += new System.EventHandler(this.btn_reg_preview_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(160, 834);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 20);
            this.label21.TabIndex = 297;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(687, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(10, 13);
            this.label33.TabIndex = 298;
            this.label33.Text = "-";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(687, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(10, 13);
            this.label36.TabIndex = 299;
            this.label36.Text = "-";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(687, 98);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(10, 13);
            this.label39.TabIndex = 300;
            this.label39.Text = "-";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(687, 138);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(10, 13);
            this.label40.TabIndex = 301;
            this.label40.Text = "-";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(687, 179);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(10, 13);
            this.label41.TabIndex = 302;
            this.label41.Text = "-";
            // 
            // gform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 784);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_reg_preview);
            this.Controls.Add(this.btn_reg_cancel);
            this.Controls.Add(this.btn_reg_save);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_shop);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.cmb_gt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_voucher);
            this.Controls.Add(this.cmb_remark);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_counter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_pur_no);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalamt);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_rep);
            this.Controls.Add(this.txt_goldprice);
            this.Controls.Add(this.txt_mcost);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_WK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_WP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_WY);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.txt_WC);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.total_K);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_Y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_S);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_gm);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.cmb_itemname);
            this.Controls.Add(this.txt_s);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.gform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add_photo;
        private ComboBox cmb_itemname;
        private ComboBox cmb_item;
        private ComboBox cmb_gt;
        private ComboBox cmb_remark;
        private PictureBox pictureBox;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        private Button btn_review;
        private Label label23;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_cancel;
        private Button btn_save;
        private Label label10;
        private TextBox txt_barcode;
        private TextBox txt_counter;
        private TextBox txt_pur_no;
        private TextBox txt_voucher;
        private TextBox txt_totalamt;
        private TextBox txt_rep;
        private TextBox txt_mcost;
        private TextBox total_S;
        private TextBox total_Y;
        private TextBox total_P;
        private TextBox total_K;
        private TextBox txt_WC;
        private TextBox txt_WY;
        private TextBox txt_WP;
        private TextBox txt_WK;
        private TextBox txt_s;
        private TextBox txt_y;
        private TextBox txt_p;
        private Label label3;
        private TextBox txt_goldprice;
        private Label label8;
        private Label label9;
        private TextBox txt_k;
        private Label label7;
        private TextBox txt_gm;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_time;
        private Label label2;
        private TextBox txt_date;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_temparay_pid;
        private TextBox txt_result_pid;
        private TextBox txt_Dece_pid;
        private Label label25;
        private TextBox txt_Dece;
        private TextBox txt_result_id;
        private TextBox txt_temparay;
        private Label label24;
        private Label label28;
        private Label label27;
        private Label label26;
        private TextBox check_language;
        private TextBox txt_incre_pid;
        private TextBox txt_temparray_proid;
        private TextBox txt_ince_proid;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label lbl_totalgm;
        private Label lbl_totalamt;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer2;
        private TextBox textBox2;
        private TextBox txt_shop;
        private Label label32;
        private Label label22;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn Voucher;
        private DataGridViewTextBoxColumn enter_remark;
        private DataGridViewTextBoxColumn purvoc;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn goldtype;
        private DataGridViewTextBoxColumn gold_price;
        private DataGridViewTextBoxColumn Items;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn gm;
        private DataGridViewTextBoxColumn K;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn S;
        private DataGridViewTextBoxColumn wk;
        private DataGridViewTextBoxColumn wp;
        private DataGridViewTextBoxColumn wy;
        private DataGridViewTextBoxColumn ws;
        private DataGridViewTextBoxColumn tk;
        private DataGridViewTextBoxColumn tp;
        private DataGridViewTextBoxColumn ty;
        private DataGridViewTextBoxColumn ts;
        private DataGridViewTextBoxColumn mcost;
        private DataGridViewTextBoxColumn repamt;
        private DataGridViewTextBoxColumn total_amt;
        private DataGridViewTextBoxColumn remark;
        private DataGridViewTextBoxColumn employee;
        private DataGridViewTextBoxColumn shop;
        private DataGridViewTextBoxColumn Form;
        private DataGridViewTextBoxColumn type;
        private DataGridViewImageColumn coledit;
        private TextBox txt_edit_check;
        private Label label20;
        private TextBox txt_remark;
        private GroupBox groupBox2;
        private Label label34;
        private Label lbl_qty;
        private System.Windows.Forms.Timer timer3;
        private GroupBox groupBox3;
        private Label label35;
        private Label label37;
        private Label label38;
        private Krypton.Toolkit.KryptonButton btn_cart;
        private Krypton.Toolkit.KryptonButton btn_reg_preview;
        private Krypton.Toolkit.KryptonButton btn_reg_cancel;
        private Krypton.Toolkit.KryptonButton btn_reg_save;
        private Label label21;
        private Label label33;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label36;
    }
}