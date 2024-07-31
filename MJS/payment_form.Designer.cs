

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_payment = new Krypton.Toolkit.KryptonButton();
            this.foreign_group = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_exchange_amt = new Krypton.Toolkit.KryptonTextBox();
            this.txt_currency_rate = new System.Windows.Forms.TextBox();
            this.cmb_currenty_type = new Krypton.Toolkit.KryptonComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_currency_amt = new Krypton.Toolkit.KryptonTextBox();
            this.Mobile_group = new System.Windows.Forms.GroupBox();
            this.cmb_bankname = new Krypton.Toolkit.KryptonComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_mobilebanking_amt = new Krypton.Toolkit.KryptonTextBox();
            this.Bank_group = new System.Windows.Forms.GroupBox();
            this.txt_POS = new System.Windows.Forms.TextBox();
            this.cmb_cardtype = new Krypton.Toolkit.KryptonComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_bankcard_amt = new Krypton.Toolkit.KryptonTextBox();
            this.Cash_group = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cash_amt = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_outstanding_amt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_payment_amt = new System.Windows.Forms.Label();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.btn_payment_save = new Krypton.Toolkit.KryptonButton();
            this.dgv_show_paymethod = new System.Windows.Forms.DataGridView();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_show_saleamt = new System.Windows.Forms.Label();
            this.lbl_show_payment = new System.Windows.Forms.Label();
            this.lbl_show_outstanding = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.foreign_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_currenty_type)).BeginInit();
            this.Mobile_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bankname)).BeginInit();
            this.Bank_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cardtype)).BeginInit();
            this.Cash_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sale_amt
            // 
            this.txt_sale_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sale_amt.Location = new System.Drawing.Point(561, 21);
            this.txt_sale_amt.Name = "txt_sale_amt";
            this.txt_sale_amt.Size = new System.Drawing.Size(33, 21);
            this.txt_sale_amt.TabIndex = 0;
            this.txt_sale_amt.Text = "0";
            this.txt_sale_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_sale_amt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label2.Location = new System.Drawing.Point(15, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale Amount";
            // 
            // cash_rdo_btn
            // 
            this.cash_rdo_btn.AutoSize = true;
            this.cash_rdo_btn.Location = new System.Drawing.Point(19, 428);
            this.cash_rdo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cash_rdo_btn.Name = "cash_rdo_btn";
            this.cash_rdo_btn.Size = new System.Drawing.Size(49, 17);
            this.cash_rdo_btn.TabIndex = 2;
            this.cash_rdo_btn.TabStop = true;
            this.cash_rdo_btn.Text = "Cash";
            this.cash_rdo_btn.UseVisualStyleBackColor = true;
            this.cash_rdo_btn.Click += new System.EventHandler(this.cash_rdo_btn_Click);
            // 
            // foreign_rdo_btn
            // 
            this.foreign_rdo_btn.AutoSize = true;
            this.foreign_rdo_btn.Location = new System.Drawing.Point(117, 428);
            this.foreign_rdo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreign_rdo_btn.Name = "foreign_rdo_btn";
            this.foreign_rdo_btn.Size = new System.Drawing.Size(105, 17);
            this.foreign_rdo_btn.TabIndex = 3;
            this.foreign_rdo_btn.TabStop = true;
            this.foreign_rdo_btn.Text = "Foreign Currency";
            this.foreign_rdo_btn.UseVisualStyleBackColor = true;
            this.foreign_rdo_btn.Click += new System.EventHandler(this.foreign_rdo_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Information";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CornerRoundingRadius = 10F;
            this.kryptonTextBox1.Location = new System.Drawing.Point(12, 92);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(187, 37);
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
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(227, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.CornerRoundingRadius = 10F;
            this.txt_phonenumber.Location = new System.Drawing.Point(223, 92);
            this.txt_phonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(174, 37);
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
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(429, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.CornerRoundingRadius = 10F;
            this.kryptonTextBox3.Location = new System.Drawing.Point(425, 92);
            this.kryptonTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(291, 37);
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
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Payment Method";
            // 
            // bank_rdo_btn
            // 
            this.bank_rdo_btn.AutoSize = true;
            this.bank_rdo_btn.Location = new System.Drawing.Point(261, 428);
            this.bank_rdo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bank_rdo_btn.Name = "bank_rdo_btn";
            this.bank_rdo_btn.Size = new System.Drawing.Size(75, 17);
            this.bank_rdo_btn.TabIndex = 15;
            this.bank_rdo_btn.TabStop = true;
            this.bank_rdo_btn.Text = "Bank Card";
            this.bank_rdo_btn.UseVisualStyleBackColor = true;
            this.bank_rdo_btn.Click += new System.EventHandler(this.bank_rdo_btn_Click);
            // 
            // MB_rdo_btn
            // 
            this.MB_rdo_btn.AutoSize = true;
            this.MB_rdo_btn.Location = new System.Drawing.Point(386, 428);
            this.MB_rdo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MB_rdo_btn.Name = "MB_rdo_btn";
            this.MB_rdo_btn.Size = new System.Drawing.Size(98, 17);
            this.MB_rdo_btn.TabIndex = 16;
            this.MB_rdo_btn.TabStop = true;
            this.MB_rdo_btn.Text = "Mobile Banking";
            this.MB_rdo_btn.UseVisualStyleBackColor = true;
            this.MB_rdo_btn.Click += new System.EventHandler(this.MB_rdo_btn_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.CornerRoundingRadius = 10F;
            this.btn_payment.Location = new System.Drawing.Point(764, 396);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(225, 44);
            this.btn_payment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_payment.StateCommon.Border.Rounding = 2F;
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Values.Text = "Payment";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // foreign_group
            // 
            this.foreign_group.Controls.Add(this.label10);
            this.foreign_group.Controls.Add(this.txt_exchange_amt);
            this.foreign_group.Controls.Add(this.txt_currency_rate);
            this.foreign_group.Controls.Add(this.cmb_currenty_type);
            this.foreign_group.Controls.Add(this.label11);
            this.foreign_group.Controls.Add(this.txt_currency_amt);
            this.foreign_group.Location = new System.Drawing.Point(716, 163);
            this.foreign_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreign_group.Name = "foreign_group";
            this.foreign_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreign_group.Size = new System.Drawing.Size(310, 217);
            this.foreign_group.TabIndex = 22;
            this.foreign_group.TabStop = false;
            this.foreign_group.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Exchange Amount";
            // 
            // txt_exchange_amt
            // 
            this.txt_exchange_amt.CornerRoundingRadius = 10F;
            this.txt_exchange_amt.Location = new System.Drawing.Point(20, 163);
            this.txt_exchange_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_exchange_amt.Name = "txt_exchange_amt";
            this.txt_exchange_amt.Size = new System.Drawing.Size(225, 37);
            this.txt_exchange_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_exchange_amt.StateCommon.Border.Rounding = 3F;
            this.txt_exchange_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exchange_amt.TabIndex = 26;
            // 
            // txt_currency_rate
            // 
            this.txt_currency_rate.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_rate.Location = new System.Drawing.Point(185, 17);
            this.txt_currency_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_currency_rate.Name = "txt_currency_rate";
            this.txt_currency_rate.Size = new System.Drawing.Size(105, 35);
            this.txt_currency_rate.TabIndex = 25;
            this.txt_currency_rate.Enter += new System.EventHandler(this.txt_dollar_rate_Enter);
            this.txt_currency_rate.Leave += new System.EventHandler(this.txt_dollar_rate_Leave);
            // 
            // cmb_currenty_type
            // 
            this.cmb_currenty_type.CornerRoundingRadius = 10F;
            this.cmb_currenty_type.DropDownWidth = 115;
            this.cmb_currenty_type.IntegralHeight = false;
            this.cmb_currenty_type.Items.AddRange(new object[] {
            "USD",
            "SGD",
            "Batt"});
            this.cmb_currenty_type.Location = new System.Drawing.Point(20, 17);
            this.cmb_currenty_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_currenty_type.Name = "cmb_currenty_type";
            this.cmb_currenty_type.Size = new System.Drawing.Size(147, 35);
            this.cmb_currenty_type.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmb_currenty_type.StateCommon.ComboBox.Border.Rounding = 3F;
            this.cmb_currenty_type.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_currenty_type.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmb_currenty_type.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(25, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Currency Amount";
            // 
            // txt_currency_amt
            // 
            this.txt_currency_amt.CornerRoundingRadius = 10F;
            this.txt_currency_amt.Location = new System.Drawing.Point(20, 93);
            this.txt_currency_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_currency_amt.Name = "txt_currency_amt";
            this.txt_currency_amt.Size = new System.Drawing.Size(225, 37);
            this.txt_currency_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_currency_amt.StateCommon.Border.Rounding = 3F;
            this.txt_currency_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_amt.TabIndex = 17;
            this.txt_currency_amt.TextChanged += new System.EventHandler(this.txt_currency_amt_TextChanged);
            // 
            // Mobile_group
            // 
            this.Mobile_group.Controls.Add(this.cmb_bankname);
            this.Mobile_group.Controls.Add(this.label15);
            this.Mobile_group.Controls.Add(this.txt_mobilebanking_amt);
            this.Mobile_group.Location = new System.Drawing.Point(716, 163);
            this.Mobile_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mobile_group.Name = "Mobile_group";
            this.Mobile_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mobile_group.Size = new System.Drawing.Size(310, 217);
            this.Mobile_group.TabIndex = 25;
            this.Mobile_group.TabStop = false;
            this.Mobile_group.Visible = false;
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
            this.cmb_bankname.Location = new System.Drawing.Point(48, 31);
            this.cmb_bankname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(223, 35);
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
            this.label15.Location = new System.Drawing.Point(44, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mobile Banking Amount";
            // 
            // txt_mobilebanking_amt
            // 
            this.txt_mobilebanking_amt.CornerRoundingRadius = 10F;
            this.txt_mobilebanking_amt.Location = new System.Drawing.Point(48, 111);
            this.txt_mobilebanking_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobilebanking_amt.Name = "txt_mobilebanking_amt";
            this.txt_mobilebanking_amt.Size = new System.Drawing.Size(225, 37);
            this.txt_mobilebanking_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_mobilebanking_amt.StateCommon.Border.Rounding = 3F;
            this.txt_mobilebanking_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobilebanking_amt.TabIndex = 17;
            // 
            // Bank_group
            // 
            this.Bank_group.Controls.Add(this.txt_POS);
            this.Bank_group.Controls.Add(this.cmb_cardtype);
            this.Bank_group.Controls.Add(this.label17);
            this.Bank_group.Controls.Add(this.txt_bankcard_amt);
            this.Bank_group.Location = new System.Drawing.Point(716, 163);
            this.Bank_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bank_group.Name = "Bank_group";
            this.Bank_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bank_group.Size = new System.Drawing.Size(310, 217);
            this.Bank_group.TabIndex = 25;
            this.Bank_group.TabStop = false;
            this.Bank_group.Visible = false;
            // 
            // txt_POS
            // 
            this.txt_POS.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_POS.Location = new System.Drawing.Point(178, 31);
            this.txt_POS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_POS.Name = "txt_POS";
            this.txt_POS.Size = new System.Drawing.Size(86, 35);
            this.txt_POS.TabIndex = 24;
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.CornerRoundingRadius = 10F;
            this.cmb_cardtype.DropDownWidth = 115;
            this.cmb_cardtype.IntegralHeight = false;
            this.cmb_cardtype.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.cmb_cardtype.Location = new System.Drawing.Point(39, 29);
            this.cmb_cardtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(124, 35);
            this.cmb_cardtype.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmb_cardtype.StateCommon.ComboBox.Border.Rounding = 3F;
            this.cmb_cardtype.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cardtype.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmb_cardtype.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(35, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 22);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bank Card Amount";
            // 
            // txt_bankcard_amt
            // 
            this.txt_bankcard_amt.CornerRoundingRadius = 10F;
            this.txt_bankcard_amt.Location = new System.Drawing.Point(35, 111);
            this.txt_bankcard_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bankcard_amt.Name = "txt_bankcard_amt";
            this.txt_bankcard_amt.Size = new System.Drawing.Size(225, 37);
            this.txt_bankcard_amt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bankcard_amt.StateCommon.Border.Rounding = 3F;
            this.txt_bankcard_amt.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bankcard_amt.TabIndex = 17;
            // 
            // Cash_group
            // 
            this.Cash_group.Controls.Add(this.label13);
            this.Cash_group.Controls.Add(this.txt_cash_amt);
            this.Cash_group.Location = new System.Drawing.Point(716, 163);
            this.Cash_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_group.Name = "Cash_group";
            this.Cash_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_group.Size = new System.Drawing.Size(310, 217);
            this.Cash_group.TabIndex = 30;
            this.Cash_group.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(44, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cash Amount";
            // 
            // txt_cash_amt
            // 
            this.txt_cash_amt.CornerRoundingRadius = 10F;
            this.txt_cash_amt.Location = new System.Drawing.Point(44, 110);
            this.txt_cash_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cash_amt.Name = "txt_cash_amt";
            this.txt_cash_amt.Size = new System.Drawing.Size(225, 37);
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
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label1.Location = new System.Drawing.Point(15, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Outstanding Amount";
            // 
            // lbl_outstanding_amt
            // 
            this.lbl_outstanding_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_outstanding_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outstanding_amt.Location = new System.Drawing.Point(637, 21);
            this.lbl_outstanding_amt.Name = "lbl_outstanding_amt";
            this.lbl_outstanding_amt.Size = new System.Drawing.Size(34, 21);
            this.lbl_outstanding_amt.TabIndex = 28;
            this.lbl_outstanding_amt.Text = "0";
            this.lbl_outstanding_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_outstanding_amt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label12.Location = new System.Drawing.Point(15, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Payment Amount";
            // 
            // lbl_payment_amt
            // 
            this.lbl_payment_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_payment_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_amt.Location = new System.Drawing.Point(600, 21);
            this.lbl_payment_amt.Name = "lbl_payment_amt";
            this.lbl_payment_amt.Size = new System.Drawing.Size(34, 21);
            this.lbl_payment_amt.TabIndex = 30;
            this.lbl_payment_amt.Text = "0";
            this.lbl_payment_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_payment_amt.Visible = false;
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(445, 22);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(100, 20);
            this.txt_show.TabIndex = 32;
            this.txt_show.Visible = false;
            // 
            // btn_payment_save
            // 
            this.btn_payment_save.CornerRoundingRadius = 10F;
            this.btn_payment_save.Location = new System.Drawing.Point(764, 460);
            this.btn_payment_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_payment_save.Name = "btn_payment_save";
            this.btn_payment_save.Size = new System.Drawing.Size(225, 44);
            this.btn_payment_save.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_payment_save.StateCommon.Border.Rounding = 2F;
            this.btn_payment_save.TabIndex = 33;
            this.btn_payment_save.Values.Text = "Save";
            // 
            // dgv_show_paymethod
            // 
            this.dgv_show_paymethod.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_paymethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_show_paymethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_paymethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment,
            this.type,
            this.amount,
            this.rate,
            this.pos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_show_paymethod.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_show_paymethod.Location = new System.Drawing.Point(19, 460);
            this.dgv_show_paymethod.Name = "dgv_show_paymethod";
            this.dgv_show_paymethod.Size = new System.Drawing.Size(563, 153);
            this.dgv_show_paymethod.TabIndex = 34;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment Method";
            this.payment.Name = "payment";
            // 
            // type
            // 
            this.type.HeaderText = "Payment Type";
            this.type.Name = "type";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // rate
            // 
            this.rate.HeaderText = "Curreny Rate";
            this.rate.Name = "rate";
            // 
            // pos
            // 
            this.pos.HeaderText = "POS";
            this.pos.Name = "pos";
            // 
            // lbl_show_saleamt
            // 
            this.lbl_show_saleamt.AutoSize = true;
            this.lbl_show_saleamt.Font = new System.Drawing.Font("Pyidaungsu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_saleamt.Location = new System.Drawing.Point(165, 163);
            this.lbl_show_saleamt.Name = "lbl_show_saleamt";
            this.lbl_show_saleamt.Size = new System.Drawing.Size(36, 50);
            this.lbl_show_saleamt.TabIndex = 35;
            this.lbl_show_saleamt.Text = "0";
            // 
            // lbl_show_payment
            // 
            this.lbl_show_payment.AutoSize = true;
            this.lbl_show_payment.Font = new System.Drawing.Font("Pyidaungsu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_payment.Location = new System.Drawing.Point(165, 222);
            this.lbl_show_payment.Name = "lbl_show_payment";
            this.lbl_show_payment.Size = new System.Drawing.Size(0, 50);
            this.lbl_show_payment.TabIndex = 36;
            // 
            // lbl_show_outstanding
            // 
            this.lbl_show_outstanding.AutoSize = true;
            this.lbl_show_outstanding.Font = new System.Drawing.Font("Pyidaungsu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_outstanding.Location = new System.Drawing.Point(165, 281);
            this.lbl_show_outstanding.Name = "lbl_show_outstanding";
            this.lbl_show_outstanding.Size = new System.Drawing.Size(0, 50);
            this.lbl_show_outstanding.TabIndex = 37;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(736, 8);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Size = new System.Drawing.Size(491, 150);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.Visible = false;
            // 
            // payment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 625);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_show_outstanding);
            this.Controls.Add(this.lbl_show_payment);
            this.Controls.Add(this.lbl_show_saleamt);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.dgv_show_paymethod);
            this.Controls.Add(this.Mobile_group);
            this.Controls.Add(this.btn_payment_save);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.Bank_group);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Cash_group);
            this.Controls.Add(this.lbl_payment_amt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_outstanding_amt);
            this.Controls.Add(this.foreign_group);
            this.Controls.Add(this.MB_rdo_btn);
            this.Controls.Add(this.bank_rdo_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kryptonTextBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foreign_rdo_btn);
            this.Controls.Add(this.cash_rdo_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sale_amt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "payment_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Method Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.payment_form_Load);
            this.foreign_group.ResumeLayout(false);
            this.foreign_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_currenty_type)).EndInit();
            this.Mobile_group.ResumeLayout(false);
            this.Mobile_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bankname)).EndInit();
            this.Bank_group.ResumeLayout(false);
            this.Bank_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cardtype)).EndInit();
            this.Cash_group.ResumeLayout(false);
            this.Cash_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Krypton.Toolkit.KryptonButton btn_payment;
        private GroupBox foreign_group;
        private Label label11;
        private Krypton.Toolkit.KryptonTextBox txt_currency_amt;
        private GroupBox Mobile_group;
        private Krypton.Toolkit.KryptonComboBox cmb_bankname;
        private Label label15;
        private Krypton.Toolkit.KryptonTextBox txt_mobilebanking_amt;
        private GroupBox Bank_group;
        private Krypton.Toolkit.KryptonComboBox cmb_cardtype;
        private Label label17;
        private Krypton.Toolkit.KryptonTextBox txt_bankcard_amt;
        private TextBox txt_POS;
        private GroupBox Cash_group;
        private Label label13;
        private Krypton.Toolkit.KryptonTextBox txt_cash_amt;
        private TextBox txt_currency_rate;
        private Krypton.Toolkit.KryptonComboBox cmb_currenty_type;
        private Label label1;
        private Label lbl_outstanding_amt;
        private Label label10;
        private Krypton.Toolkit.KryptonTextBox txt_exchange_amt;
        private Label label12;
        private Label lbl_payment_amt;
        private TextBox txt_show;
        private Krypton.Toolkit.KryptonButton btn_payment_save;
        private DataGridView dgv_show_paymethod;
        private Label lbl_show_saleamt;
        private Label lbl_show_payment;
        private Label lbl_show_outstanding;
        private DataGridViewTextBoxColumn payment;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewTextBoxColumn pos;
        private DataGridView dataGridView2;
    }
}