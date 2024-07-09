

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
            this.txt_payment_amt = new System.Windows.Forms.Label();
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
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.foreign_group = new System.Windows.Forms.GroupBox();
            this.txt_dollar_rate = new System.Windows.Forms.TextBox();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kryptonTextBox6 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox7 = new Krypton.Toolkit.KryptonTextBox();
            this.Mobile_group = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.kryptonTextBox8 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox9 = new Krypton.Toolkit.KryptonTextBox();
            this.Bank_group = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kryptonComboBox3 = new Krypton.Toolkit.KryptonComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.kryptonTextBox10 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox11 = new Krypton.Toolkit.KryptonTextBox();
            this.Cash_group = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.kryptonTextBox12 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox13 = new Krypton.Toolkit.KryptonTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foreign_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.Mobile_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            this.Bank_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).BeginInit();
            this.Cash_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_payment_amt
            // 
            this.txt_payment_amt.Font = new System.Drawing.Font("Pyidaungsu", 24F, System.Drawing.FontStyle.Bold);
            this.txt_payment_amt.Location = new System.Drawing.Point(124, 198);
            this.txt_payment_amt.Name = "txt_payment_amt";
            this.txt_payment_amt.Size = new System.Drawing.Size(168, 48);
            this.txt_payment_amt.TabIndex = 0;
            this.txt_payment_amt.Text = "0";
            this.txt_payment_amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pyidaungsu", 9.75F);
            this.label2.Location = new System.Drawing.Point(26, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Amount";
            // 
            // cash_rdo_btn
            // 
            this.cash_rdo_btn.AutoSize = true;
            this.cash_rdo_btn.Location = new System.Drawing.Point(30, 337);
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
            this.foreign_rdo_btn.Location = new System.Drawing.Point(128, 337);
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
            this.label8.Location = new System.Drawing.Point(12, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Payment Method";
            // 
            // bank_rdo_btn
            // 
            this.bank_rdo_btn.AutoSize = true;
            this.bank_rdo_btn.Location = new System.Drawing.Point(282, 337);
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
            this.MB_rdo_btn.Location = new System.Drawing.Point(397, 337);
            this.MB_rdo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MB_rdo_btn.Name = "MB_rdo_btn";
            this.MB_rdo_btn.Size = new System.Drawing.Size(98, 17);
            this.MB_rdo_btn.TabIndex = 16;
            this.MB_rdo_btn.TabStop = true;
            this.MB_rdo_btn.Text = "Mobile Banking";
            this.MB_rdo_btn.UseVisualStyleBackColor = true;
            this.MB_rdo_btn.Click += new System.EventHandler(this.MB_rdo_btn_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 10F;
            this.kryptonButton1.Location = new System.Drawing.Point(782, 319);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(310, 44);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 2F;
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Payment";
            // 
            // foreign_group
            // 
            this.foreign_group.Controls.Add(this.txt_dollar_rate);
            this.foreign_group.Controls.Add(this.kryptonComboBox1);
            this.foreign_group.Controls.Add(this.label11);
            this.foreign_group.Controls.Add(this.label12);
            this.foreign_group.Controls.Add(this.kryptonTextBox6);
            this.foreign_group.Controls.Add(this.kryptonTextBox7);
            this.foreign_group.Location = new System.Drawing.Point(782, 89);
            this.foreign_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreign_group.Name = "foreign_group";
            this.foreign_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foreign_group.Size = new System.Drawing.Size(310, 215);
            this.foreign_group.TabIndex = 22;
            this.foreign_group.TabStop = false;
            this.foreign_group.Visible = false;
            // 
            // txt_dollar_rate
            // 
            this.txt_dollar_rate.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dollar_rate.Location = new System.Drawing.Point(185, 17);
            this.txt_dollar_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dollar_rate.Name = "txt_dollar_rate";
            this.txt_dollar_rate.Size = new System.Drawing.Size(105, 35);
            this.txt_dollar_rate.TabIndex = 25;
            this.txt_dollar_rate.Enter += new System.EventHandler(this.txt_dollar_rate_Enter);
            this.txt_dollar_rate.Leave += new System.EventHandler(this.txt_dollar_rate_Leave);
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.CornerRoundingRadius = 10F;
            this.kryptonComboBox1.DropDownWidth = 115;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "USD",
            "SGD",
            "Batt"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(20, 17);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(147, 35);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 3F;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 25;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(25, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Outstanding Amount";
            // 
            // kryptonTextBox6
            // 
            this.kryptonTextBox6.CornerRoundingRadius = 10F;
            this.kryptonTextBox6.Location = new System.Drawing.Point(20, 93);
            this.kryptonTextBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox6.Name = "kryptonTextBox6";
            this.kryptonTextBox6.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox6.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox6.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox6.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox6.TabIndex = 17;
            // 
            // kryptonTextBox7
            // 
            this.kryptonTextBox7.CornerRoundingRadius = 10F;
            this.kryptonTextBox7.Location = new System.Drawing.Point(20, 164);
            this.kryptonTextBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox7.Name = "kryptonTextBox7";
            this.kryptonTextBox7.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox7.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox7.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox7.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox7.TabIndex = 19;
            // 
            // Mobile_group
            // 
            this.Mobile_group.Controls.Add(this.kryptonComboBox2);
            this.Mobile_group.Controls.Add(this.label15);
            this.Mobile_group.Controls.Add(this.label16);
            this.Mobile_group.Controls.Add(this.kryptonTextBox8);
            this.Mobile_group.Controls.Add(this.kryptonTextBox9);
            this.Mobile_group.Location = new System.Drawing.Point(783, 90);
            this.Mobile_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mobile_group.Name = "Mobile_group";
            this.Mobile_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mobile_group.Size = new System.Drawing.Size(310, 213);
            this.Mobile_group.TabIndex = 25;
            this.Mobile_group.TabStop = false;
            this.Mobile_group.Visible = false;
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.CornerRoundingRadius = 10F;
            this.kryptonComboBox2.DropDownWidth = 115;
            this.kryptonComboBox2.IntegralHeight = false;
            this.kryptonComboBox2.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.kryptonComboBox2.Location = new System.Drawing.Point(35, 20);
            this.kryptonComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(223, 35);
            this.kryptonComboBox2.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Rounding = 3F;
            this.kryptonComboBox2.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox2.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(35, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mobile Banking Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(35, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 22);
            this.label16.TabIndex = 20;
            this.label16.Text = "Outstanding Amount";
            // 
            // kryptonTextBox8
            // 
            this.kryptonTextBox8.CornerRoundingRadius = 10F;
            this.kryptonTextBox8.Location = new System.Drawing.Point(35, 89);
            this.kryptonTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox8.Name = "kryptonTextBox8";
            this.kryptonTextBox8.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox8.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox8.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox8.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox8.TabIndex = 17;
            // 
            // kryptonTextBox9
            // 
            this.kryptonTextBox9.CornerRoundingRadius = 10F;
            this.kryptonTextBox9.Location = new System.Drawing.Point(35, 162);
            this.kryptonTextBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox9.Name = "kryptonTextBox9";
            this.kryptonTextBox9.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox9.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox9.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox9.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox9.TabIndex = 19;
            // 
            // Bank_group
            // 
            this.Bank_group.Controls.Add(this.textBox1);
            this.Bank_group.Controls.Add(this.kryptonComboBox3);
            this.Bank_group.Controls.Add(this.label17);
            this.Bank_group.Controls.Add(this.label18);
            this.Bank_group.Controls.Add(this.kryptonTextBox10);
            this.Bank_group.Controls.Add(this.kryptonTextBox11);
            this.Bank_group.Location = new System.Drawing.Point(783, 90);
            this.Bank_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bank_group.Name = "Bank_group";
            this.Bank_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bank_group.Size = new System.Drawing.Size(310, 215);
            this.Bank_group.TabIndex = 25;
            this.Bank_group.TabStop = false;
            this.Bank_group.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 35);
            this.textBox1.TabIndex = 24;
            // 
            // kryptonComboBox3
            // 
            this.kryptonComboBox3.CornerRoundingRadius = 10F;
            this.kryptonComboBox3.DropDownWidth = 115;
            this.kryptonComboBox3.IntegralHeight = false;
            this.kryptonComboBox3.Items.AddRange(new object[] {
            "AYA",
            "CB",
            "KBZ",
            "UAB"});
            this.kryptonComboBox3.Location = new System.Drawing.Point(44, 15);
            this.kryptonComboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonComboBox3.Name = "kryptonComboBox3";
            this.kryptonComboBox3.Size = new System.Drawing.Size(124, 35);
            this.kryptonComboBox3.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox3.StateCommon.ComboBox.Border.Rounding = 3F;
            this.kryptonComboBox3.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox3.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox3.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(44, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 22);
            this.label17.TabIndex = 18;
            this.label17.Text = "Bank Card Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(44, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 22);
            this.label18.TabIndex = 20;
            this.label18.Text = "Outstanding Amount";
            // 
            // kryptonTextBox10
            // 
            this.kryptonTextBox10.CornerRoundingRadius = 10F;
            this.kryptonTextBox10.Location = new System.Drawing.Point(44, 86);
            this.kryptonTextBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox10.Name = "kryptonTextBox10";
            this.kryptonTextBox10.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox10.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox10.StateCommon.Border.Rounding = 3F;
            this.kryptonTextBox10.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox10.TabIndex = 17;
            // 
            // kryptonTextBox11
            // 
            this.kryptonTextBox11.CornerRoundingRadius = 10F;
            this.kryptonTextBox11.Location = new System.Drawing.Point(44, 163);
            this.kryptonTextBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox11.Name = "kryptonTextBox11";
            this.kryptonTextBox11.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox11.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox11.StateCommon.Border.Rounding = 2F;
            this.kryptonTextBox11.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox11.TabIndex = 19;
            // 
            // Cash_group
            // 
            this.Cash_group.Controls.Add(this.label13);
            this.Cash_group.Controls.Add(this.label19);
            this.Cash_group.Controls.Add(this.kryptonTextBox12);
            this.Cash_group.Controls.Add(this.kryptonTextBox13);
            this.Cash_group.Location = new System.Drawing.Point(783, 91);
            this.Cash_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_group.Name = "Cash_group";
            this.Cash_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cash_group.Size = new System.Drawing.Size(310, 213);
            this.Cash_group.TabIndex = 26;
            this.Cash_group.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(43, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cash Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(43, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 22);
            this.label19.TabIndex = 20;
            this.label19.Text = "Outstanding Amount";
            // 
            // kryptonTextBox12
            // 
            this.kryptonTextBox12.CornerRoundingRadius = 10F;
            this.kryptonTextBox12.Location = new System.Drawing.Point(43, 76);
            this.kryptonTextBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox12.Name = "kryptonTextBox12";
            this.kryptonTextBox12.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox12.StateActive.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox12.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox12.StateCommon.Border.Rounding = 2F;
            this.kryptonTextBox12.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox12.StateNormal.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox12.TabIndex = 17;
            // 
            // kryptonTextBox13
            // 
            this.kryptonTextBox13.CornerRoundingRadius = 10F;
            this.kryptonTextBox13.Location = new System.Drawing.Point(43, 147);
            this.kryptonTextBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox13.Name = "kryptonTextBox13";
            this.kryptonTextBox13.Size = new System.Drawing.Size(225, 37);
            this.kryptonTextBox13.StateActive.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox13.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox13.StateCommon.Border.Rounding = 2F;
            this.kryptonTextBox13.StateCommon.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox13.StateNormal.Content.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox13.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 160);
            this.dataGridView1.TabIndex = 27;
            // 
            // payment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cash_group);
            this.Controls.Add(this.Bank_group);
            this.Controls.Add(this.Mobile_group);
            this.Controls.Add(this.foreign_group);
            this.Controls.Add(this.kryptonButton1);
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
            this.Controls.Add(this.txt_payment_amt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "payment_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Method Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.payment_form_Load);
            this.foreign_group.ResumeLayout(false);
            this.foreign_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.Mobile_group.ResumeLayout(false);
            this.Mobile_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            this.Bank_group.ResumeLayout(false);
            this.Bank_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox3)).EndInit();
            this.Cash_group.ResumeLayout(false);
            this.Cash_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_payment_amt;
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
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private GroupBox foreign_group;
        private Label label11;
        private Label label12;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox6;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        private GroupBox Mobile_group;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private Label label15;
        private Label label16;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox9;
        private GroupBox Bank_group;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox3;
        private Label label17;
        private Label label18;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox10;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox11;
        private TextBox textBox1;
        private GroupBox Cash_group;
        private Label label13;
        private Label label19;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox12;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox13;
        private TextBox txt_dollar_rate;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private DataGridView dataGridView1;
    }
}