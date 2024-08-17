

using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class payment_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_sale_amt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cash_rdo_btn = new System.Windows.Forms.RadioButton();
            this.foreign_rdo_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bank_rdo_btn = new System.Windows.Forms.RadioButton();
            this.MB_rdo_btn = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_exchange_amt = new Krypton.Toolkit.KryptonTextBox();
            this.txt_currency_rate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_currency_amt = new Krypton.Toolkit.KryptonTextBox();
            this.cmb_bankname = new Krypton.Toolkit.KryptonComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_mobilebanking_amt = new Krypton.Toolkit.KryptonTextBox();
            this.txt_POS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_bankcard_amt = new Krypton.Toolkit.KryptonTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cash_amt = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_outstanding_amt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_payment_amt = new System.Windows.Forms.Label();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.lbl_show_saleamt = new System.Windows.Forms.Label();
            this.lbl_show_payment = new System.Windows.Forms.Label();
            this.lbl_show_outstanding = new System.Windows.Forms.Label();
            this.add_data = new System.Windows.Forms.DataGridView();
            this.icobtn_payment = new FontAwesome.Sharp.IconButton();
            this.Bank_group = new System.Windows.Forms.Panel();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Mobile_group = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cash_group = new System.Windows.Forms.Panel();
            this.foreign_group = new System.Windows.Forms.Panel();
            this.cmb_currenty_type = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_show_paymethod = new System.Windows.Forms.DataGridView();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_gsale_save = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Voucher_no = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_incre_pid = new System.Windows.Forms.TextBox();
            this.txt_edit_check = new System.Windows.Forms.TextBox();
            this.txt_temparray_proid = new System.Windows.Forms.TextBox();
            this.txt_ince_proid = new System.Windows.Forms.TextBox();
            this.check_language = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_temparay = new System.Windows.Forms.TextBox();
            this.btn_add_photo = new System.Windows.Forms.Button();
            this.txt_result_id = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txt_Dece = new System.Windows.Forms.TextBox();
            this.txt_temparay_pid = new System.Windows.Forms.TextBox();
            this.txt_result_pid = new System.Windows.Forms.TextBox();
            this.txt_Dece_pid = new System.Windows.Forms.TextBox();
            this.dgv_TDP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bankname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_data)).BeginInit();
            this.Bank_group.SuspendLayout();
            this.Mobile_group.SuspendLayout();
            this.Cash_group.SuspendLayout();
            this.foreign_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TDP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sale_amt
            // 
            this.txt_sale_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sale_amt.Location = new System.Drawing.Point(47, 41);
            this.txt_sale_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sale_amt.Name = "txt_sale_amt";
            this.txt_sale_amt.Size = new System.Drawing.Size(15, 10);
            this.txt_sale_amt.TabIndex = 0;
            this.txt_sale_amt.Text = "0";
            this.txt_sale_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_sale_amt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale Amount";
            // 
            // cash_rdo_btn
            // 
            this.cash_rdo_btn.AutoSize = true;
            this.cash_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_rdo_btn.Location = new System.Drawing.Point(26, 53);
            this.cash_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cash_rdo_btn.Name = "cash_rdo_btn";
            this.cash_rdo_btn.Size = new System.Drawing.Size(57, 28);
            this.cash_rdo_btn.TabIndex = 2;
            this.cash_rdo_btn.TabStop = true;
            this.cash_rdo_btn.Text = "Cash";
            this.cash_rdo_btn.UseVisualStyleBackColor = true;
            this.cash_rdo_btn.Click += new System.EventHandler(this.cash_rdo_btn_Click);
            // 
            // foreign_rdo_btn
            // 
            this.foreign_rdo_btn.AutoSize = true;
            this.foreign_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreign_rdo_btn.Location = new System.Drawing.Point(98, 53);
            this.foreign_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.foreign_rdo_btn.Name = "foreign_rdo_btn";
            this.foreign_rdo_btn.Size = new System.Drawing.Size(131, 28);
            this.foreign_rdo_btn.TabIndex = 3;
            this.foreign_rdo_btn.TabStop = true;
            this.foreign_rdo_btn.Text = "Foreign Currency";
            this.foreign_rdo_btn.UseVisualStyleBackColor = true;
            this.foreign_rdo_btn.Click += new System.EventHandler(this.foreign_rdo_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Information";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CornerRoundingRadius = 10F;
            this.kryptonTextBox1.Location = new System.Drawing.Point(4, 107);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(152, 37);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.CornerRoundingRadius = 10F;
            this.txt_phonenumber.Location = new System.Drawing.Point(169, 107);
            this.txt_phonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(152, 37);
            this.txt_phonenumber.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_phonenumber.StateCommon.Border.Rounding = 3F;
            this.txt_phonenumber.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phonenumber.TabIndex = 10;
            this.txt_phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phonenumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.CornerRoundingRadius = 10F;
            this.kryptonTextBox3.Location = new System.Drawing.Point(334, 106);
            this.kryptonTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(228, 37);
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Payment Method";
            // 
            // bank_rdo_btn
            // 
            this.bank_rdo_btn.AutoSize = true;
            this.bank_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_rdo_btn.Location = new System.Drawing.Point(227, 53);
            this.bank_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.bank_rdo_btn.Name = "bank_rdo_btn";
            this.bank_rdo_btn.Size = new System.Drawing.Size(90, 28);
            this.bank_rdo_btn.TabIndex = 15;
            this.bank_rdo_btn.TabStop = true;
            this.bank_rdo_btn.Text = "Bank Card";
            this.bank_rdo_btn.UseVisualStyleBackColor = true;
            this.bank_rdo_btn.Click += new System.EventHandler(this.bank_rdo_btn_Click);
            // 
            // MB_rdo_btn
            // 
            this.MB_rdo_btn.AutoSize = true;
            this.MB_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MB_rdo_btn.Location = new System.Drawing.Point(328, 53);
            this.MB_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.MB_rdo_btn.Name = "MB_rdo_btn";
            this.MB_rdo_btn.Size = new System.Drawing.Size(120, 28);
            this.MB_rdo_btn.TabIndex = 16;
            this.MB_rdo_btn.TabStop = true;
            this.MB_rdo_btn.Text = "Mobile Banking";
            this.MB_rdo_btn.UseVisualStyleBackColor = true;
            this.MB_rdo_btn.Click += new System.EventHandler(this.MB_rdo_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(23, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Exchange Amount";
            // 
            // txt_exchange_amt
            // 
            this.txt_exchange_amt.CornerRoundingRadius = 10F;
            this.txt_exchange_amt.Enabled = false;
            this.txt_exchange_amt.Location = new System.Drawing.Point(24, 175);
            this.txt_exchange_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_exchange_amt.Name = "txt_exchange_amt";
            this.txt_exchange_amt.Size = new System.Drawing.Size(160, 37);
            this.txt_exchange_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_exchange_amt.StateCommon.Border.Rounding = 3F;
            this.txt_exchange_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exchange_amt.TabIndex = 26;
            this.txt_exchange_amt.Text = "0";
            // 
            // txt_currency_rate
            // 
            this.txt_currency_rate.BackColor = System.Drawing.SystemColors.Window;
            this.txt_currency_rate.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_rate.Location = new System.Drawing.Point(23, 99);
            this.txt_currency_rate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_currency_rate.Name = "txt_currency_rate";
            this.txt_currency_rate.Size = new System.Drawing.Size(161, 35);
            this.txt_currency_rate.TabIndex = 25;
            this.txt_currency_rate.Text = "0";
            this.txt_currency_rate.Enter += new System.EventHandler(this.txt_dollar_rate_Enter);
            this.txt_currency_rate.Leave += new System.EventHandler(this.txt_dollar_rate_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(218, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Currency Amount";
            // 
            // txt_currency_amt
            // 
            this.txt_currency_amt.CornerRoundingRadius = 10F;
            this.txt_currency_amt.Location = new System.Drawing.Point(219, 97);
            this.txt_currency_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_currency_amt.Name = "txt_currency_amt";
            this.txt_currency_amt.Size = new System.Drawing.Size(161, 37);
            this.txt_currency_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_currency_amt.StateCommon.Border.Rounding = 3F;
            this.txt_currency_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_amt.TabIndex = 17;
            this.txt_currency_amt.Text = "0";
            this.txt_currency_amt.TextChanged += new System.EventHandler(this.txt_currency_amt_TextChanged);
            this.txt_currency_amt.Leave += new System.EventHandler(this.txt_currency_amt_Leave);
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.CornerRoundingRadius = 10F;
            this.cmb_bankname.DropDownWidth = 115;
            this.cmb_bankname.IntegralHeight = false;
            this.cmb_bankname.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.cmb_bankname.Location = new System.Drawing.Point(123, 72);
            this.cmb_bankname.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(161, 35);
            this.cmb_bankname.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmb_bankname.StateCommon.ComboBox.Border.Rounding = 3F;
            this.cmb_bankname.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bankname.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmb_bankname.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(123, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mobile Banking Amount";
            // 
            // txt_mobilebanking_amt
            // 
            this.txt_mobilebanking_amt.CornerRoundingRadius = 10F;
            this.txt_mobilebanking_amt.Location = new System.Drawing.Point(123, 150);
            this.txt_mobilebanking_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mobilebanking_amt.Name = "txt_mobilebanking_amt";
            this.txt_mobilebanking_amt.Size = new System.Drawing.Size(161, 37);
            this.txt_mobilebanking_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_mobilebanking_amt.StateCommon.Border.Rounding = 3F;
            this.txt_mobilebanking_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobilebanking_amt.TabIndex = 17;
            this.txt_mobilebanking_amt.Text = "0";
            this.txt_mobilebanking_amt.TextChanged += new System.EventHandler(this.txt_mobilebanking_amt_TextChanged);
            // 
            // txt_POS
            // 
            this.txt_POS.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_POS.Location = new System.Drawing.Point(235, 69);
            this.txt_POS.Margin = new System.Windows.Forms.Padding(2);
            this.txt_POS.Name = "txt_POS";
            this.txt_POS.Size = new System.Drawing.Size(95, 35);
            this.txt_POS.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(56, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 22);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bank Card Amount";
            // 
            // txt_bankcard_amt
            // 
            this.txt_bankcard_amt.CornerRoundingRadius = 10F;
            this.txt_bankcard_amt.Location = new System.Drawing.Point(56, 144);
            this.txt_bankcard_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_bankcard_amt.Name = "txt_bankcard_amt";
            this.txt_bankcard_amt.Size = new System.Drawing.Size(161, 37);
            this.txt_bankcard_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bankcard_amt.StateCommon.Border.Rounding = 3F;
            this.txt_bankcard_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bankcard_amt.TabIndex = 17;
            this.txt_bankcard_amt.Text = "0";
            this.txt_bankcard_amt.TextChanged += new System.EventHandler(this.txt_bankcard_amt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(108, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cash Amount";
            // 
            // txt_cash_amt
            // 
            this.txt_cash_amt.CornerRoundingRadius = 10F;
            this.txt_cash_amt.Location = new System.Drawing.Point(109, 92);
            this.txt_cash_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cash_amt.Name = "txt_cash_amt";
            this.txt_cash_amt.Size = new System.Drawing.Size(211, 37);
            this.txt_cash_amt.StateActive.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_cash_amt.StateCommon.Border.Rounding = 2F;
            this.txt_cash_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash_amt.StateNormal.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash_amt.TabIndex = 17;
            this.txt_cash_amt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Outstanding Amount";
            // 
            // lbl_outstanding_amt
            // 
            this.lbl_outstanding_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_outstanding_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outstanding_amt.Location = new System.Drawing.Point(80, 41);
            this.lbl_outstanding_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_outstanding_amt.Name = "lbl_outstanding_amt";
            this.lbl_outstanding_amt.Size = new System.Drawing.Size(16, 10);
            this.lbl_outstanding_amt.TabIndex = 28;
            this.lbl_outstanding_amt.Text = "0";
            this.lbl_outstanding_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_outstanding_amt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "Payment Amount";
            // 
            // lbl_payment_amt
            // 
            this.lbl_payment_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_payment_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_amt.Location = new System.Drawing.Point(64, 41);
            this.lbl_payment_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_payment_amt.Name = "lbl_payment_amt";
            this.lbl_payment_amt.Size = new System.Drawing.Size(16, 10);
            this.lbl_payment_amt.TabIndex = 30;
            this.lbl_payment_amt.Text = "0";
            this.lbl_payment_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_payment_amt.Visible = false;
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(69, 14);
            this.txt_show.Margin = new System.Windows.Forms.Padding(2);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(44, 20);
            this.txt_show.TabIndex = 32;
            this.txt_show.Visible = false;
            // 
            // lbl_show_saleamt
            // 
            this.lbl_show_saleamt.AutoSize = true;
            this.lbl_show_saleamt.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_saleamt.Location = new System.Drawing.Point(171, 178);
            this.lbl_show_saleamt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_saleamt.Name = "lbl_show_saleamt";
            this.lbl_show_saleamt.Size = new System.Drawing.Size(33, 46);
            this.lbl_show_saleamt.TabIndex = 35;
            this.lbl_show_saleamt.Text = "0";
            // 
            // lbl_show_payment
            // 
            this.lbl_show_payment.AutoSize = true;
            this.lbl_show_payment.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_payment.Location = new System.Drawing.Point(171, 233);
            this.lbl_show_payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_payment.Name = "lbl_show_payment";
            this.lbl_show_payment.Size = new System.Drawing.Size(33, 46);
            this.lbl_show_payment.TabIndex = 36;
            this.lbl_show_payment.Text = "0";
            // 
            // lbl_show_outstanding
            // 
            this.lbl_show_outstanding.AutoSize = true;
            this.lbl_show_outstanding.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_outstanding.Location = new System.Drawing.Point(171, 289);
            this.lbl_show_outstanding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_outstanding.Name = "lbl_show_outstanding";
            this.lbl_show_outstanding.Size = new System.Drawing.Size(33, 46);
            this.lbl_show_outstanding.TabIndex = 37;
            this.lbl_show_outstanding.Text = "0";
            // 
            // add_data
            // 
            this.add_data.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.add_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.add_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.add_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.add_data.Location = new System.Drawing.Point(561, 9);
            this.add_data.Margin = new System.Windows.Forms.Padding(2);
            this.add_data.Name = "add_data";
            this.add_data.RowHeadersWidth = 51;
            this.add_data.Size = new System.Drawing.Size(72, 31);
            this.add_data.TabIndex = 38;
            this.add_data.Visible = false;
            // 
            // icobtn_payment
            // 
            this.icobtn_payment.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icobtn_payment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.icobtn_payment.IconColor = System.Drawing.Color.Black;
            this.icobtn_payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icobtn_payment.IconSize = 35;
            this.icobtn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icobtn_payment.Location = new System.Drawing.Point(28, 333);
            this.icobtn_payment.Margin = new System.Windows.Forms.Padding(2);
            this.icobtn_payment.Name = "icobtn_payment";
            this.icobtn_payment.Size = new System.Drawing.Size(420, 57);
            this.icobtn_payment.TabIndex = 39;
            this.icobtn_payment.Text = "Payment";
            this.icobtn_payment.UseVisualStyleBackColor = true;
            this.icobtn_payment.Click += new System.EventHandler(this.icobtn_payment_Click);
            // 
            // Bank_group
            // 
            this.Bank_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bank_group.Controls.Add(this.cmb_cardtype);
            this.Bank_group.Controls.Add(this.label20);
            this.Bank_group.Controls.Add(this.label19);
            this.Bank_group.Controls.Add(this.label9);
            this.Bank_group.Controls.Add(this.txt_POS);
            this.Bank_group.Controls.Add(this.txt_bankcard_amt);
            this.Bank_group.Controls.Add(this.label17);
            this.Bank_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Bank_group.Location = new System.Drawing.Point(28, 95);
            this.Bank_group.Margin = new System.Windows.Forms.Padding(2);
            this.Bank_group.Name = "Bank_group";
            this.Bank_group.Size = new System.Drawing.Size(420, 227);
            this.Bank_group.TabIndex = 40;
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.cmb_cardtype.Location = new System.Drawing.Point(56, 71);
            this.cmb_cardtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(161, 35);
            this.cmb_cardtype.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(235, 46);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 22);
            this.label20.TabIndex = 31;
            this.label20.Text = "POS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(56, 46);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 22);
            this.label19.TabIndex = 30;
            this.label19.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "* Please Select Bank Card Type And Choose POS";
            // 
            // Mobile_group
            // 
            this.Mobile_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mobile_group.Controls.Add(this.label21);
            this.Mobile_group.Controls.Add(this.label14);
            this.Mobile_group.Controls.Add(this.cmb_bankname);
            this.Mobile_group.Controls.Add(this.label15);
            this.Mobile_group.Controls.Add(this.txt_mobilebanking_amt);
            this.Mobile_group.Location = new System.Drawing.Point(28, 95);
            this.Mobile_group.Margin = new System.Windows.Forms.Padding(2);
            this.Mobile_group.Name = "Mobile_group";
            this.Mobile_group.Size = new System.Drawing.Size(420, 227);
            this.Mobile_group.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label21.Location = new System.Drawing.Point(124, 45);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 22);
            this.label21.TabIndex = 30;
            this.label21.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(10, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "* Please Select Mobing Banking Type";
            // 
            // Cash_group
            // 
            this.Cash_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cash_group.Controls.Add(this.label13);
            this.Cash_group.Controls.Add(this.txt_cash_amt);
            this.Cash_group.Location = new System.Drawing.Point(28, 95);
            this.Cash_group.Margin = new System.Windows.Forms.Padding(2);
            this.Cash_group.Name = "Cash_group";
            this.Cash_group.Size = new System.Drawing.Size(420, 227);
            this.Cash_group.TabIndex = 42;
            // 
            // foreign_group
            // 
            this.foreign_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foreign_group.Controls.Add(this.cmb_currenty_type);
            this.foreign_group.Controls.Add(this.label18);
            this.foreign_group.Controls.Add(this.label16);
            this.foreign_group.Controls.Add(this.label10);
            this.foreign_group.Controls.Add(this.txt_exchange_amt);
            this.foreign_group.Controls.Add(this.txt_currency_amt);
            this.foreign_group.Controls.Add(this.txt_currency_rate);
            this.foreign_group.Controls.Add(this.label11);
            this.foreign_group.Location = new System.Drawing.Point(28, 95);
            this.foreign_group.Margin = new System.Windows.Forms.Padding(2);
            this.foreign_group.Name = "foreign_group";
            this.foreign_group.Size = new System.Drawing.Size(420, 227);
            this.foreign_group.TabIndex = 43;
            // 
            // cmb_currenty_type
            // 
            this.cmb_currenty_type.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_currenty_type.FormattingEnabled = true;
            this.cmb_currenty_type.Location = new System.Drawing.Point(24, 32);
            this.cmb_currenty_type.Name = "cmb_currenty_type";
            this.cmb_currenty_type.Size = new System.Drawing.Size(161, 35);
            this.cmb_currenty_type.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(24, 6);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 22);
            this.label18.TabIndex = 29;
            this.label18.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(23, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 22);
            this.label16.TabIndex = 28;
            this.label16.Text = "Currency Rate";
            // 
            // dgv_show_paymethod
            // 
            this.dgv_show_paymethod.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_show_paymethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_show_paymethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_show_paymethod.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_show_paymethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_paymethod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_show_paymethod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_paymethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_show_paymethod.ColumnHeadersHeight = 40;
            this.dgv_show_paymethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.paytype,
            this.payamt,
            this.currate,
            this.tpos});
            this.dgv_show_paymethod.EnableHeadersVisualStyles = false;
            this.dgv_show_paymethod.Location = new System.Drawing.Point(7, 10);
            this.dgv_show_paymethod.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_show_paymethod.Name = "dgv_show_paymethod";
            this.dgv_show_paymethod.RowHeadersWidth = 51;
            this.dgv_show_paymethod.RowTemplate.Height = 30;
            this.dgv_show_paymethod.Size = new System.Drawing.Size(678, 161);
            this.dgv_show_paymethod.TabIndex = 44;
            // 
            // method
            // 
            this.method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.method.HeaderText = "Payment Method";
            this.method.MinimumWidth = 6;
            this.method.Name = "method";
            // 
            // paytype
            // 
            this.paytype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paytype.HeaderText = "Payment Type";
            this.paytype.MinimumWidth = 6;
            this.paytype.Name = "paytype";
            // 
            // payamt
            // 
            this.payamt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payamt.HeaderText = "Amount";
            this.payamt.MinimumWidth = 6;
            this.payamt.Name = "payamt";
            // 
            // currate
            // 
            this.currate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currate.HeaderText = "Currency Rate";
            this.currate.MinimumWidth = 6;
            this.currate.Name = "currate";
            // 
            // tpos
            // 
            this.tpos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tpos.HeaderText = "POS";
            this.tpos.MinimumWidth = 6;
            this.tpos.Name = "tpos";
            // 
            // btn_gsale_save
            // 
            this.btn_gsale_save.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gsale_save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_gsale_save.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(47)))), ((int)(((byte)(78)))));
            this.btn_gsale_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_gsale_save.IconSize = 35;
            this.btn_gsale_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gsale_save.Location = new System.Drawing.Point(28, 414);
            this.btn_gsale_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gsale_save.Name = "btn_gsale_save";
            this.btn_gsale_save.Size = new System.Drawing.Size(420, 57);
            this.btn_gsale_save.TabIndex = 45;
            this.btn_gsale_save.Text = "Save";
            this.btn_gsale_save.UseVisualStyleBackColor = true;
            this.btn_gsale_save.Click += new System.EventHandler(this.btn_gsale_save_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Voucher_no
            // 
            this.txt_Voucher_no.Location = new System.Drawing.Point(11, 14);
            this.txt_Voucher_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Voucher_no.Name = "txt_Voucher_no";
            this.txt_Voucher_no.Size = new System.Drawing.Size(51, 20);
            this.txt_Voucher_no.TabIndex = 46;
            this.txt_Voucher_no.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_incre_pid);
            this.groupBox1.Controls.Add(this.txt_edit_check);
            this.groupBox1.Controls.Add(this.txt_temparray_proid);
            this.groupBox1.Controls.Add(this.txt_ince_proid);
            this.groupBox1.Controls.Add(this.check_language);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.txt_temparay);
            this.groupBox1.Controls.Add(this.btn_add_photo);
            this.groupBox1.Controls.Add(this.txt_result_id);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.txt_Dece);
            this.groupBox1.Controls.Add(this.txt_temparay_pid);
            this.groupBox1.Controls.Add(this.txt_result_pid);
            this.groupBox1.Controls.Add(this.txt_Dece_pid);
            this.groupBox1.Location = new System.Drawing.Point(148, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 44);
            this.groupBox1.TabIndex = 447;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "requirment for calculation";
            this.groupBox1.Visible = false;
            // 
            // txt_incre_pid
            // 
            this.txt_incre_pid.Location = new System.Drawing.Point(149, 53);
            this.txt_incre_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_incre_pid.Name = "txt_incre_pid";
            this.txt_incre_pid.Size = new System.Drawing.Size(58, 20);
            this.txt_incre_pid.TabIndex = 152;
            // 
            // txt_edit_check
            // 
            this.txt_edit_check.Location = new System.Drawing.Point(243, 10);
            this.txt_edit_check.Margin = new System.Windows.Forms.Padding(2);
            this.txt_edit_check.Name = "txt_edit_check";
            this.txt_edit_check.Size = new System.Drawing.Size(32, 20);
            this.txt_edit_check.TabIndex = 213;
            this.txt_edit_check.Text = "0";
            this.txt_edit_check.Visible = false;
            // 
            // txt_temparray_proid
            // 
            this.txt_temparray_proid.Location = new System.Drawing.Point(86, 53);
            this.txt_temparray_proid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparray_proid.Name = "txt_temparray_proid";
            this.txt_temparray_proid.Size = new System.Drawing.Size(62, 20);
            this.txt_temparray_proid.TabIndex = 151;
            // 
            // txt_ince_proid
            // 
            this.txt_ince_proid.Location = new System.Drawing.Point(48, 53);
            this.txt_ince_proid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ince_proid.Name = "txt_ince_proid";
            this.txt_ince_proid.Size = new System.Drawing.Size(34, 20);
            this.txt_ince_proid.TabIndex = 150;
            // 
            // check_language
            // 
            this.check_language.Location = new System.Drawing.Point(75, 76);
            this.check_language.Margin = new System.Windows.Forms.Padding(2);
            this.check_language.Name = "check_language";
            this.check_language.Size = new System.Drawing.Size(58, 20);
            this.check_language.TabIndex = 149;
            this.check_language.Text = "myanmar";
            this.check_language.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 36);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 13);
            this.label40.TabIndex = 148;
            this.label40.Text = "product No";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 18);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(58, 13);
            this.label42.TabIndex = 147;
            this.label42.Text = "invoice No";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(148, 8);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 13);
            this.label43.TabIndex = 146;
            this.label43.Text = "temparray";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(86, 8);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 13);
            this.label44.TabIndex = 145;
            this.label44.Text = "result Id";
            // 
            // txt_temparay
            // 
            this.txt_temparay.Location = new System.Drawing.Point(148, 18);
            this.txt_temparay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparay.Name = "txt_temparay";
            this.txt_temparay.Size = new System.Drawing.Size(58, 20);
            this.txt_temparay.TabIndex = 144;
            // 
            // btn_add_photo
            // 
            this.btn_add_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_photo.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.btn_add_photo.Location = new System.Drawing.Point(231, 73);
            this.btn_add_photo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(60, 17);
            this.btn_add_photo.TabIndex = 14;
            this.btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            // 
            // txt_result_id
            // 
            this.txt_result_id.Location = new System.Drawing.Point(85, 18);
            this.txt_result_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result_id.Name = "txt_result_id";
            this.txt_result_id.Size = new System.Drawing.Size(62, 20);
            this.txt_result_id.TabIndex = 143;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(48, 8);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(48, 13);
            this.label45.TabIndex = 141;
            this.label45.Text = "Decre Id";
            // 
            // txt_Dece
            // 
            this.txt_Dece.Location = new System.Drawing.Point(50, 18);
            this.txt_Dece.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dece.Name = "txt_Dece";
            this.txt_Dece.Size = new System.Drawing.Size(34, 20);
            this.txt_Dece.TabIndex = 139;
            this.txt_Dece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_temparay_pid
            // 
            this.txt_temparay_pid.Location = new System.Drawing.Point(148, 34);
            this.txt_temparay_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparay_pid.Name = "txt_temparay_pid";
            this.txt_temparay_pid.Size = new System.Drawing.Size(58, 20);
            this.txt_temparay_pid.TabIndex = 138;
            // 
            // txt_result_pid
            // 
            this.txt_result_pid.Location = new System.Drawing.Point(86, 34);
            this.txt_result_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result_pid.Name = "txt_result_pid";
            this.txt_result_pid.Size = new System.Drawing.Size(61, 20);
            this.txt_result_pid.TabIndex = 137;
            // 
            // txt_Dece_pid
            // 
            this.txt_Dece_pid.Location = new System.Drawing.Point(50, 34);
            this.txt_Dece_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dece_pid.Name = "txt_Dece_pid";
            this.txt_Dece_pid.Size = new System.Drawing.Size(34, 20);
            this.txt_Dece_pid.TabIndex = 136;
            // 
            // dgv_TDP
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TDP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TDP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TDP.Location = new System.Drawing.Point(735, 628);
            this.dgv_TDP.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TDP.Name = "dgv_TDP";
            this.dgv_TDP.RowHeadersWidth = 51;
            this.dgv_TDP.RowTemplate.Height = 24;
            this.dgv_TDP.Size = new System.Drawing.Size(419, 70);
            this.dgv_TDP.TabIndex = 448;
            this.dgv_TDP.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kryptonTextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_phonenumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.kryptonTextBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_show_saleamt);
            this.panel1.Controls.Add(this.lbl_show_outstanding);
            this.panel1.Controls.Add(this.lbl_show_payment);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 359);
            this.panel1.TabIndex = 449;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_show_paymethod);
            this.panel2.Location = new System.Drawing.Point(12, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 187);
            this.panel2.TabIndex = 450;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.add_data);
            this.panel3.Controls.Add(this.txt_Voucher_no);
            this.panel3.Controls.Add(this.txt_show);
            this.panel3.Controls.Add(this.txt_sale_amt);
            this.panel3.Controls.Add(this.lbl_outstanding_amt);
            this.panel3.Controls.Add(this.lbl_payment_amt);
            this.panel3.Location = new System.Drawing.Point(51, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 80);
            this.panel3.TabIndex = 451;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.foreign_group);
            this.panel4.Controls.Add(this.Bank_group);
            this.panel4.Controls.Add(this.Mobile_group);
            this.panel4.Controls.Add(this.Cash_group);
            this.panel4.Controls.Add(this.MB_rdo_btn);
            this.panel4.Controls.Add(this.btn_gsale_save);
            this.panel4.Controls.Add(this.bank_rdo_btn);
            this.panel4.Controls.Add(this.icobtn_payment);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.foreign_rdo_btn);
            this.panel4.Controls.Add(this.cash_rdo_btn);
            this.panel4.Location = new System.Drawing.Point(772, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 511);
            this.panel4.TabIndex = 452;
            // 
            // payment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 714);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_TDP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Method Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.payment_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bankname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_data)).EndInit();
            this.Bank_group.ResumeLayout(false);
            this.Bank_group.PerformLayout();
            this.Mobile_group.ResumeLayout(false);
            this.Mobile_group.PerformLayout();
            this.Cash_group.ResumeLayout(false);
            this.Cash_group.PerformLayout();
            this.foreign_group.ResumeLayout(false);
            this.foreign_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TDP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label txt_sale_amt;
        private Label label2;
        private RadioButton cash_rdo_btn;
        private RadioButton foreign_rdo_btn;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox txt_phonenumber;
        private Label label7;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Label label8;
        private RadioButton bank_rdo_btn;
        private RadioButton MB_rdo_btn;
        private Label label11;
        private Krypton.Toolkit.KryptonTextBox txt_currency_amt;
        private Krypton.Toolkit.KryptonComboBox cmb_bankname;
        private Label label15;
        private Krypton.Toolkit.KryptonTextBox txt_mobilebanking_amt;
        private Label label17;
        private Krypton.Toolkit.KryptonTextBox txt_bankcard_amt;
        private TextBox txt_POS;
        private Label label13;
        private Krypton.Toolkit.KryptonTextBox txt_cash_amt;
        private TextBox txt_currency_rate;
        private Label label1;
        private Label lbl_outstanding_amt;
        private Label label10;
        private Krypton.Toolkit.KryptonTextBox txt_exchange_amt;
        private Label label12;
        private Label lbl_payment_amt;
        private TextBox txt_show;
        private Label lbl_show_saleamt;
        private Label lbl_show_payment;
        private Label lbl_show_outstanding;
        private DataGridView add_data;
        private FontAwesome.Sharp.IconButton icobtn_payment;
        private Panel Bank_group;
        private Label label9;
        private Panel Mobile_group;
        private Label label14;
        private Panel Cash_group;
        private Panel foreign_group;
        private Label label16;
        private Label label19;
        private Label label18;
        private Label label20;
        private Label label21;
        private DataGridView dgv_show_paymethod;
        private FontAwesome.Sharp.IconButton btn_gsale_save;
        private Timer timer1;
        private TextBox txt_Voucher_no;
        private GroupBox groupBox1;
        private TextBox txt_incre_pid;
        private TextBox txt_edit_check;
        private TextBox txt_temparray_proid;
        private TextBox txt_ince_proid;
        private TextBox check_language;
        private Label label40;
        private Label label42;
        private Label label43;
        private Label label44;
        private TextBox txt_temparay;
        private Button btn_add_photo;
        private TextBox txt_result_id;
        private Label label45;
        private TextBox txt_Dece;
        private TextBox txt_temparay_pid;
        private TextBox txt_result_pid;
        private TextBox txt_Dece_pid;
        private ComboBox cmb_cardtype;
        private DataGridView dgv_TDP;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cmb_currenty_type;
        private Panel panel4;
        private DataGridViewTextBoxColumn method;
        private DataGridViewTextBoxColumn paytype;
        private DataGridViewTextBoxColumn payamt;
        private DataGridViewTextBoxColumn currate;
        private DataGridViewTextBoxColumn tpos;
    }
}