﻿using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class preview
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
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_searchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_shop_preview = new System.Windows.Forms.TextBox();
            this.txt_form_perview = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Exp_Excel = new System.Windows.Forms.Button();
            this.Choose_Box = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startdate
            // 
            this.startdate.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.startdate.Location = new System.Drawing.Point(73, 24);
            this.startdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 30);
            this.startdate.TabIndex = 0;
            // 
            // enddate
            // 
            this.enddate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Location = new System.Drawing.Point(72, 74);
            this.enddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 30);
            this.enddate.TabIndex = 1;
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 323);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_searchbox
            // 
            this.txt_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchbox.Location = new System.Drawing.Point(1040, 60);
            this.txt_searchbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchbox.Multiline = true;
            this.txt_searchbox.Name = "txt_searchbox";
            this.txt_searchbox.Size = new System.Drawing.Size(172, 32);
            this.txt_searchbox.TabIndex = 4;
            this.txt_searchbox.TextChanged += new System.EventHandler(this.txt_searchbox_TextChanged);
            this.txt_searchbox.Enter += new System.EventHandler(this.txt_searchbox_Enter);
            this.txt_searchbox.Leave += new System.EventHandler(this.txt_searchbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-4, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1242, 2);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_shop_preview
            // 
            this.txt_shop_preview.Location = new System.Drawing.Point(530, 11);
            this.txt_shop_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_shop_preview.Multiline = true;
            this.txt_shop_preview.Name = "txt_shop_preview";
            this.txt_shop_preview.Size = new System.Drawing.Size(100, 32);
            this.txt_shop_preview.TabIndex = 8;
            this.txt_shop_preview.Visible = false;
            // 
            // txt_form_perview
            // 
            this.txt_form_perview.Location = new System.Drawing.Point(374, 11);
            this.txt_form_perview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_form_perview.Multiline = true;
            this.txt_form_perview.Name = "txt_form_perview";
            this.txt_form_perview.Size = new System.Drawing.Size(130, 32);
            this.txt_form_perview.TabIndex = 9;
            this.txt_form_perview.Visible = false;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(303, 55);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(201, 37);
            this.Btn_Search.TabIndex = 10;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Exp_Excel
            // 
            this.Btn_Exp_Excel.Location = new System.Drawing.Point(520, 55);
            this.Btn_Exp_Excel.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Exp_Excel.Name = "Btn_Exp_Excel";
            this.Btn_Exp_Excel.Size = new System.Drawing.Size(199, 37);
            this.Btn_Exp_Excel.TabIndex = 11;
            this.Btn_Exp_Excel.Text = "Export Excel";
            this.Btn_Exp_Excel.UseVisualStyleBackColor = true;
            this.Btn_Exp_Excel.Click += new System.EventHandler(this.Btn_Exp_Excel_Click);
            // 
            // Choose_Box
            // 
            this.Choose_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Choose_Box.CheckOnClick = true;
            this.Choose_Box.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Box.FormattingEnabled = true;
            this.Choose_Box.Items.AddRange(new object[] {
            "Sale",
            "Payment Method"});
            this.Choose_Box.Location = new System.Drawing.Point(73, 119);
            this.Choose_Box.Name = "Choose_Box";
            this.Choose_Box.Size = new System.Drawing.Size(161, 50);
            this.Choose_Box.TabIndex = 14;
            this.Choose_Box.Visible = false;
            this.Choose_Box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Choose_Box_ItemCheck);
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 554);
            this.Controls.Add(this.Choose_Box);
            this.Controls.Add(this.Btn_Exp_Excel);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_form_perview);
            this.Controls.Add(this.txt_shop_preview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.txt_searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private DataGridView dataGridView1;
        private TextBox txt_searchbox;
        private Label label2;
        private Label label1;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private TextBox txt_shop_preview;
        private TextBox txt_form_perview;
        private Button Btn_Search;
        private Button Btn_Exp_Excel;
        private CheckedListBox Choose_Box;
    }
}