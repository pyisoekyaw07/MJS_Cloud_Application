

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
            this.txt_sale_amt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cash_rdo_btn = new System.Windows.Forms.RadioButton();
            this.foreign_rdo_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bank_rdo_btn = new System.Windows.Forms.RadioButton();
            this.MB_rdo_btn = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_currency_rate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_POS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_outstanding_amt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_payment_amt = new System.Windows.Forms.Label();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.lbl_show_saleamt = new System.Windows.Forms.Label();
            this.lbl_show_payment = new System.Windows.Forms.Label();
            this.lbl_show_outstanding = new System.Windows.Forms.Label();
            this.add_data = new System.Windows.Forms.DataGridView();
            this.txt_bankcard_amt = new System.Windows.Forms.TextBox();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_bankname = new System.Windows.Forms.ComboBox();
            this.txt_mobilebanking_amt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cash_amt = new System.Windows.Forms.TextBox();
            this.txt_currency_amt = new System.Windows.Forms.TextBox();
            this.txt_exchange_amt = new System.Windows.Forms.TextBox();
            this.cmb_currenty_type = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_show_paymethod = new System.Windows.Forms.DataGridView();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.payment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Pay = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.add_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TDP)).BeginInit();
            this.panel1.SuspendLayout();
            this.payment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sale_amt
            // 
            this.txt_sale_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sale_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sale_amt.Location = new System.Drawing.Point(35, 31);
            this.txt_sale_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_sale_amt.Name = "txt_sale_amt";
            this.txt_sale_amt.Size = new System.Drawing.Size(12, 8);
            this.txt_sale_amt.TabIndex = 0;
            this.txt_sale_amt.Text = "0";
            this.txt_sale_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_sale_amt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale Amount";
            // 
            // cash_rdo_btn
            // 
            this.cash_rdo_btn.AutoSize = true;
            this.cash_rdo_btn.Checked = true;
            this.cash_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_rdo_btn.Location = new System.Drawing.Point(261, 22);
            this.cash_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cash_rdo_btn.Name = "cash_rdo_btn";
            this.cash_rdo_btn.Size = new System.Drawing.Size(68, 33);
            this.cash_rdo_btn.TabIndex = 2;
            this.cash_rdo_btn.TabStop = true;
            this.cash_rdo_btn.Text = "Cash";
            this.cash_rdo_btn.UseVisualStyleBackColor = true;
            this.cash_rdo_btn.Visible = false;
            this.cash_rdo_btn.Click += new System.EventHandler(this.cash_rdo_btn_Click);
            // 
            // foreign_rdo_btn
            // 
            this.foreign_rdo_btn.AutoSize = true;
            this.foreign_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreign_rdo_btn.Location = new System.Drawing.Point(329, 22);
            this.foreign_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.foreign_rdo_btn.Name = "foreign_rdo_btn";
            this.foreign_rdo_btn.Size = new System.Drawing.Size(157, 33);
            this.foreign_rdo_btn.TabIndex = 3;
            this.foreign_rdo_btn.Text = "Foreign Currency";
            this.foreign_rdo_btn.UseVisualStyleBackColor = true;
            this.foreign_rdo_btn.Visible = false;
            this.foreign_rdo_btn.Click += new System.EventHandler(this.foreign_rdo_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pyidaungsu", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pyidaungsu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pyidaungsu", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(719, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 38);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Payment Method";
            // 
            // bank_rdo_btn
            // 
            this.bank_rdo_btn.AutoSize = true;
            this.bank_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank_rdo_btn.Location = new System.Drawing.Point(461, 22);
            this.bank_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.bank_rdo_btn.Name = "bank_rdo_btn";
            this.bank_rdo_btn.Size = new System.Drawing.Size(107, 33);
            this.bank_rdo_btn.TabIndex = 15;
            this.bank_rdo_btn.Text = "Bank Card";
            this.bank_rdo_btn.UseVisualStyleBackColor = true;
            this.bank_rdo_btn.Visible = false;
            this.bank_rdo_btn.Click += new System.EventHandler(this.bank_rdo_btn_Click);
            // 
            // MB_rdo_btn
            // 
            this.MB_rdo_btn.AutoSize = true;
            this.MB_rdo_btn.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MB_rdo_btn.Location = new System.Drawing.Point(555, 22);
            this.MB_rdo_btn.Margin = new System.Windows.Forms.Padding(2);
            this.MB_rdo_btn.Name = "MB_rdo_btn";
            this.MB_rdo_btn.Size = new System.Drawing.Size(143, 33);
            this.MB_rdo_btn.TabIndex = 16;
            this.MB_rdo_btn.Text = "Mobile Banking";
            this.MB_rdo_btn.UseVisualStyleBackColor = true;
            this.MB_rdo_btn.Visible = false;
            this.MB_rdo_btn.Click += new System.EventHandler(this.MB_rdo_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(38, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "Exchange Amount";
            // 
            // txt_currency_rate
            // 
            this.txt_currency_rate.BackColor = System.Drawing.SystemColors.Window;
            this.txt_currency_rate.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_rate.Location = new System.Drawing.Point(42, 124);
            this.txt_currency_rate.Margin = new System.Windows.Forms.Padding(2);
            this.txt_currency_rate.Name = "txt_currency_rate";
            this.txt_currency_rate.Size = new System.Drawing.Size(175, 41);
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
            this.label11.Location = new System.Drawing.Point(222, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Currency Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(35, 147);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 29);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mobile Banking Amount";
            // 
            // txt_POS
            // 
            this.txt_POS.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_POS.Location = new System.Drawing.Point(227, 90);
            this.txt_POS.Margin = new System.Windows.Forms.Padding(2);
            this.txt_POS.Name = "txt_POS";
            this.txt_POS.Size = new System.Drawing.Size(72, 41);
            this.txt_POS.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(25, 149);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 29);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bank Card Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(122, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cash Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Outstanding Amount";
            // 
            // lbl_outstanding_amt
            // 
            this.lbl_outstanding_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_outstanding_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outstanding_amt.Location = new System.Drawing.Point(60, 31);
            this.lbl_outstanding_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_outstanding_amt.Name = "lbl_outstanding_amt";
            this.lbl_outstanding_amt.Size = new System.Drawing.Size(12, 8);
            this.lbl_outstanding_amt.TabIndex = 28;
            this.lbl_outstanding_amt.Text = "0";
            this.lbl_outstanding_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_outstanding_amt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "Payment Amount";
            // 
            // lbl_payment_amt
            // 
            this.lbl_payment_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_payment_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment_amt.Location = new System.Drawing.Point(48, 31);
            this.lbl_payment_amt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_payment_amt.Name = "lbl_payment_amt";
            this.lbl_payment_amt.Size = new System.Drawing.Size(12, 8);
            this.lbl_payment_amt.TabIndex = 30;
            this.lbl_payment_amt.Text = "0";
            this.lbl_payment_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_payment_amt.Visible = false;
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(54, 10);
            this.txt_show.Margin = new System.Windows.Forms.Padding(2);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(55, 36);
            this.txt_show.TabIndex = 32;
            this.txt_show.Visible = false;
            // 
            // lbl_show_saleamt
            // 
            this.lbl_show_saleamt.AutoSize = true;
            this.lbl_show_saleamt.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_saleamt.Location = new System.Drawing.Point(181, 200);
            this.lbl_show_saleamt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_saleamt.Name = "lbl_show_saleamt";
            this.lbl_show_saleamt.Size = new System.Drawing.Size(40, 55);
            this.lbl_show_saleamt.TabIndex = 35;
            this.lbl_show_saleamt.Text = "0";
            // 
            // lbl_show_payment
            // 
            this.lbl_show_payment.AutoSize = true;
            this.lbl_show_payment.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_payment.Location = new System.Drawing.Point(181, 253);
            this.lbl_show_payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_payment.Name = "lbl_show_payment";
            this.lbl_show_payment.Size = new System.Drawing.Size(40, 55);
            this.lbl_show_payment.TabIndex = 36;
            this.lbl_show_payment.Text = "0";
            // 
            // lbl_show_outstanding
            // 
            this.lbl_show_outstanding.AutoSize = true;
            this.lbl_show_outstanding.Font = new System.Drawing.Font("Pyidaungsu", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_outstanding.Location = new System.Drawing.Point(181, 306);
            this.lbl_show_outstanding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_show_outstanding.Name = "lbl_show_outstanding";
            this.lbl_show_outstanding.Size = new System.Drawing.Size(40, 55);
            this.lbl_show_outstanding.TabIndex = 37;
            this.lbl_show_outstanding.Text = "0";
            // 
            // add_data
            // 
            this.add_data.AllowUserToAddRows = false;
            this.add_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_data.Location = new System.Drawing.Point(421, 7);
            this.add_data.Margin = new System.Windows.Forms.Padding(2);
            this.add_data.Name = "add_data";
            this.add_data.RowHeadersWidth = 51;
            this.add_data.Size = new System.Drawing.Size(54, 24);
            this.add_data.TabIndex = 38;
            this.add_data.Visible = false;
            // 
            // txt_bankcard_amt
            // 
            this.txt_bankcard_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bankcard_amt.Location = new System.Drawing.Point(21, 185);
            this.txt_bankcard_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_bankcard_amt.Name = "txt_bankcard_amt";
            this.txt_bankcard_amt.Size = new System.Drawing.Size(175, 41);
            this.txt_bankcard_amt.TabIndex = 33;
            this.txt_bankcard_amt.Text = "0";
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
            this.cmb_cardtype.Location = new System.Drawing.Point(19, 92);
            this.cmb_cardtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(175, 41);
            this.cmb_cardtype.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(223, 64);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 29);
            this.label20.TabIndex = 31;
            this.label20.Text = "POS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(24, 61);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 29);
            this.label19.TabIndex = 30;
            this.label19.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(10, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "* Please Select Bank Card Type And Choose POS";
            // 
            // cmb_bankname
            // 
            this.cmb_bankname.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bankname.FormattingEnabled = true;
            this.cmb_bankname.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.cmb_bankname.Location = new System.Drawing.Point(33, 96);
            this.cmb_bankname.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_bankname.Name = "cmb_bankname";
            this.cmb_bankname.Size = new System.Drawing.Size(175, 41);
            this.cmb_bankname.TabIndex = 32;
            // 
            // txt_mobilebanking_amt
            // 
            this.txt_mobilebanking_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobilebanking_amt.Location = new System.Drawing.Point(34, 183);
            this.txt_mobilebanking_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mobilebanking_amt.Name = "txt_mobilebanking_amt";
            this.txt_mobilebanking_amt.Size = new System.Drawing.Size(175, 41);
            this.txt_mobilebanking_amt.TabIndex = 31;
            this.txt_mobilebanking_amt.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label21.Location = new System.Drawing.Point(35, 65);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 29);
            this.label21.TabIndex = 30;
            this.label21.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(15, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(336, 33);
            this.label14.TabIndex = 26;
            this.label14.Text = "* Please Select Mobing Banking Type";
            // 
            // txt_cash_amt
            // 
            this.txt_cash_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash_amt.Location = new System.Drawing.Point(120, 130);
            this.txt_cash_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cash_amt.Name = "txt_cash_amt";
            this.txt_cash_amt.Size = new System.Drawing.Size(175, 41);
            this.txt_cash_amt.TabIndex = 19;
            this.txt_cash_amt.Text = "0";
            // 
            // txt_currency_amt
            // 
            this.txt_currency_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currency_amt.Location = new System.Drawing.Point(226, 124);
            this.txt_currency_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_currency_amt.Name = "txt_currency_amt";
            this.txt_currency_amt.Size = new System.Drawing.Size(174, 41);
            this.txt_currency_amt.TabIndex = 453;
            this.txt_currency_amt.Text = "0";
            this.txt_currency_amt.TextChanged += new System.EventHandler(this.txt_currency_amt_TextChanged);
            // 
            // txt_exchange_amt
            // 
            this.txt_exchange_amt.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exchange_amt.Location = new System.Drawing.Point(42, 202);
            this.txt_exchange_amt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_exchange_amt.Name = "txt_exchange_amt";
            this.txt_exchange_amt.Size = new System.Drawing.Size(175, 41);
            this.txt_exchange_amt.TabIndex = 454;
            this.txt_exchange_amt.Text = "0";
            // 
            // cmb_currenty_type
            // 
            this.cmb_currenty_type.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_currenty_type.FormattingEnabled = true;
            this.cmb_currenty_type.Items.AddRange(new object[] {
            "USD",
            "SGD",
            "Bath"});
            this.cmb_currenty_type.Location = new System.Drawing.Point(42, 42);
            this.cmb_currenty_type.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_currenty_type.Name = "cmb_currenty_type";
            this.cmb_currenty_type.Size = new System.Drawing.Size(175, 41);
            this.cmb_currenty_type.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(38, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 29);
            this.label18.TabIndex = 29;
            this.label18.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(38, 91);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 29);
            this.label16.TabIndex = 28;
            this.label16.Text = "Currency Rate";
            // 
            // dgv_show_paymethod
            // 
            this.dgv_show_paymethod.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_show_paymethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_show_paymethod.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_show_paymethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_show_paymethod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_show_paymethod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_show_paymethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_show_paymethod.ColumnHeadersHeight = 40;
            this.dgv_show_paymethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.method,
            this.paytype,
            this.payamt,
            this.currate,
            this.tpos});
            this.dgv_show_paymethod.EnableHeadersVisualStyles = false;
            this.dgv_show_paymethod.Location = new System.Drawing.Point(10, 414);
            this.dgv_show_paymethod.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_show_paymethod.Name = "dgv_show_paymethod";
            this.dgv_show_paymethod.RowHeadersWidth = 51;
            this.dgv_show_paymethod.RowTemplate.Height = 30;
            this.dgv_show_paymethod.Size = new System.Drawing.Size(640, 192);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Voucher_no
            // 
            this.txt_Voucher_no.Location = new System.Drawing.Point(8, 11);
            this.txt_Voucher_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Voucher_no.Name = "txt_Voucher_no";
            this.txt_Voucher_no.Size = new System.Drawing.Size(39, 36);
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
            this.groupBox1.Location = new System.Drawing.Point(111, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(228, 34);
            this.groupBox1.TabIndex = 447;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "requirment for calculation";
            this.groupBox1.Visible = false;
            // 
            // txt_incre_pid
            // 
            this.txt_incre_pid.Location = new System.Drawing.Point(112, 41);
            this.txt_incre_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_incre_pid.Name = "txt_incre_pid";
            this.txt_incre_pid.Size = new System.Drawing.Size(44, 36);
            this.txt_incre_pid.TabIndex = 152;
            // 
            // txt_edit_check
            // 
            this.txt_edit_check.Location = new System.Drawing.Point(182, 8);
            this.txt_edit_check.Margin = new System.Windows.Forms.Padding(2);
            this.txt_edit_check.Name = "txt_edit_check";
            this.txt_edit_check.Size = new System.Drawing.Size(25, 36);
            this.txt_edit_check.TabIndex = 213;
            this.txt_edit_check.Text = "0";
            this.txt_edit_check.Visible = false;
            // 
            // txt_temparray_proid
            // 
            this.txt_temparray_proid.Location = new System.Drawing.Point(64, 41);
            this.txt_temparray_proid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparray_proid.Name = "txt_temparray_proid";
            this.txt_temparray_proid.Size = new System.Drawing.Size(48, 36);
            this.txt_temparray_proid.TabIndex = 151;
            // 
            // txt_ince_proid
            // 
            this.txt_ince_proid.Location = new System.Drawing.Point(36, 41);
            this.txt_ince_proid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ince_proid.Name = "txt_ince_proid";
            this.txt_ince_proid.Size = new System.Drawing.Size(26, 36);
            this.txt_ince_proid.TabIndex = 150;
            // 
            // check_language
            // 
            this.check_language.Location = new System.Drawing.Point(56, 58);
            this.check_language.Margin = new System.Windows.Forms.Padding(2);
            this.check_language.Name = "check_language";
            this.check_language.Size = new System.Drawing.Size(44, 36);
            this.check_language.TabIndex = 149;
            this.check_language.Text = "myanmar";
            this.check_language.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 28);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(93, 29);
            this.label40.TabIndex = 148;
            this.label40.Text = "product No";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(2, 14);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 29);
            this.label42.TabIndex = 147;
            this.label42.Text = "invoice No";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(111, 6);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(87, 29);
            this.label43.TabIndex = 146;
            this.label43.Text = "temparray";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(64, 6);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 29);
            this.label44.TabIndex = 145;
            this.label44.Text = "result Id";
            // 
            // txt_temparay
            // 
            this.txt_temparay.Location = new System.Drawing.Point(111, 14);
            this.txt_temparay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparay.Name = "txt_temparay";
            this.txt_temparay.Size = new System.Drawing.Size(44, 36);
            this.txt_temparay.TabIndex = 144;
            // 
            // btn_add_photo
            // 
            this.btn_add_photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_photo.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.btn_add_photo.Location = new System.Drawing.Point(173, 56);
            this.btn_add_photo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(45, 13);
            this.btn_add_photo.TabIndex = 14;
            this.btn_add_photo.Text = "ပုံထည့်သွင်းရန်";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            // 
            // txt_result_id
            // 
            this.txt_result_id.Location = new System.Drawing.Point(64, 14);
            this.txt_result_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result_id.Name = "txt_result_id";
            this.txt_result_id.Size = new System.Drawing.Size(48, 36);
            this.txt_result_id.TabIndex = 143;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(36, 6);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(73, 29);
            this.label45.TabIndex = 141;
            this.label45.Text = "Decre Id";
            // 
            // txt_Dece
            // 
            this.txt_Dece.Location = new System.Drawing.Point(38, 14);
            this.txt_Dece.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dece.Name = "txt_Dece";
            this.txt_Dece.Size = new System.Drawing.Size(26, 36);
            this.txt_Dece.TabIndex = 139;
            this.txt_Dece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_temparay_pid
            // 
            this.txt_temparay_pid.Location = new System.Drawing.Point(111, 26);
            this.txt_temparay_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_temparay_pid.Name = "txt_temparay_pid";
            this.txt_temparay_pid.Size = new System.Drawing.Size(44, 36);
            this.txt_temparay_pid.TabIndex = 138;
            // 
            // txt_result_pid
            // 
            this.txt_result_pid.Location = new System.Drawing.Point(64, 26);
            this.txt_result_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result_pid.Name = "txt_result_pid";
            this.txt_result_pid.Size = new System.Drawing.Size(47, 36);
            this.txt_result_pid.TabIndex = 137;
            // 
            // txt_Dece_pid
            // 
            this.txt_Dece_pid.Location = new System.Drawing.Point(38, 26);
            this.txt_Dece_pid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dece_pid.Name = "txt_Dece_pid";
            this.txt_Dece_pid.Size = new System.Drawing.Size(26, 36);
            this.txt_Dece_pid.TabIndex = 136;
            // 
            // dgv_TDP
            // 
            this.dgv_TDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TDP.Location = new System.Drawing.Point(344, 7);
            this.dgv_TDP.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TDP.Name = "dgv_TDP";
            this.dgv_TDP.RowHeadersWidth = 51;
            this.dgv_TDP.RowTemplate.Height = 24;
            this.dgv_TDP.Size = new System.Drawing.Size(74, 28);
            this.dgv_TDP.TabIndex = 448;
            this.dgv_TDP.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.txt_time);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.Btn_Pay);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.dgv_show_paymethod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MB_rdo_btn);
            this.panel1.Controls.Add(this.bank_rdo_btn);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.foreign_rdo_btn);
            this.panel1.Controls.Add(this.cash_rdo_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_show_saleamt);
            this.panel1.Controls.Add(this.lbl_show_outstanding);
            this.panel1.Controls.Add(this.lbl_show_payment);
            this.panel1.Font = new System.Drawing.Font("Pyidaungsu", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 621);
            this.panel1.TabIndex = 449;
            // 
            // payment
            // 
            this.payment.Controls.Add(this.tabPage1);
            this.payment.Controls.Add(this.tabPage2);
            this.payment.Controls.Add(this.tabPage3);
            this.payment.Controls.Add(this.tabPage4);
            this.payment.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(721, 135);
            this.payment.Name = "payment";
            this.payment.SelectedIndex = 0;
            this.payment.Size = new System.Drawing.Size(488, 276);
            this.payment.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.payment.TabIndex = 458;
            this.payment.SelectedIndexChanged += new System.EventHandler(this.payment_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txt_cash_amt);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cash";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_currency_amt);
            this.tabPage2.Controls.Add(this.cmb_currenty_type);
            this.tabPage2.Controls.Add(this.txt_exchange_amt);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txt_currency_rate);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Foreign Currency";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_bankcard_amt);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.cmb_cardtype);
            this.tabPage3.Controls.Add(this.txt_POS);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(416, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bank Card";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_mobilebanking_amt);
            this.tabPage4.Controls.Add(this.cmb_bankname);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(416, 237);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mobile Banking";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_time
            // 
            this.txt_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_time.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_time.Location = new System.Drawing.Point(1106, 7);
            this.txt_time.Multiline = true;
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(184, 28);
            this.txt_time.TabIndex = 456;
            this.txt_time.TabStop = false;
            this.txt_time.Text = "time";
            // 
            // txt_date
            // 
            this.txt_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_date.BackColor = System.Drawing.Color.White;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.txt_date.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_date.Location = new System.Drawing.Point(994, 7);
            this.txt_date.Multiline = true;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(197, 28);
            this.txt_date.TabIndex = 457;
            this.txt_date.TabStop = false;
            this.txt_date.Text = "date";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dgv_TDP);
            this.panel3.Controls.Add(this.add_data);
            this.panel3.Controls.Add(this.txt_Voucher_no);
            this.panel3.Controls.Add(this.txt_show);
            this.panel3.Controls.Add(this.txt_sale_amt);
            this.panel3.Controls.Add(this.lbl_outstanding_amt);
            this.panel3.Controls.Add(this.lbl_payment_amt);
            this.panel3.Location = new System.Drawing.Point(726, 546);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 60);
            this.panel3.TabIndex = 451;
            this.panel3.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(778, 481);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(316, 41);
            this.Btn_Save.TabIndex = 454;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Pay
            // 
            this.Btn_Pay.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pay.Location = new System.Drawing.Point(778, 429);
            this.Btn_Pay.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Pay.Name = "Btn_Pay";
            this.Btn_Pay.Size = new System.Drawing.Size(316, 41);
            this.Btn_Pay.TabIndex = 453;
            this.Btn_Pay.Text = "Payment";
            this.Btn_Pay.UseVisualStyleBackColor = true;
            this.Btn_Pay.Click += new System.EventHandler(this.Btn_Pay_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(303, 135);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 41);
            this.textBox3.TabIndex = 455;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(160, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 41);
            this.textBox2.TabIndex = 454;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 41);
            this.textBox1.TabIndex = 453;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // payment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 641);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment_form";
            this.Text = "Payment Method Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.payment_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_paymethod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TDP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.payment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label txt_sale_amt;
        private Label label2;
        private RadioButton cash_rdo_btn;
        private RadioButton foreign_rdo_btn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton bank_rdo_btn;
        private RadioButton MB_rdo_btn;
        private Label label11;
        private Label label15;
        private Label label17;
        private TextBox txt_POS;
        private Label label13;
        private TextBox txt_currency_rate;
        private Label label1;
        private Label lbl_outstanding_amt;
        private Label label10;
        private Label label12;
        private Label lbl_payment_amt;
        private TextBox txt_show;
        private Label lbl_show_saleamt;
        private Label lbl_show_payment;
        private Label lbl_show_outstanding;
        private DataGridView add_data;
        private Label label9;
        private Label label14;
        private Label label16;
        private Label label19;
        private Label label18;
        private Label label20;
        private Label label21;
        private DataGridView dgv_show_paymethod;
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
        private Panel panel3;
        private ComboBox cmb_currenty_type;
        private DataGridViewTextBoxColumn method;
        private DataGridViewTextBoxColumn paytype;
        private DataGridViewTextBoxColumn payamt;
        private DataGridViewTextBoxColumn currate;
        private DataGridViewTextBoxColumn tpos;
        private Button Btn_Pay;
        private Button Btn_Save;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txt_currency_amt;
        private TextBox txt_bankcard_amt;
        private ComboBox cmb_bankname;
        private TextBox txt_mobilebanking_amt;
        private TextBox txt_exchange_amt;
        private TextBox txt_cash_amt;
        private TextBox txt_time;
        private TextBox txt_date;
        private Timer timer2;
        private TabControl payment;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}