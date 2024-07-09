using System.Drawing;
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txt_searchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.export_excel = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_shop_preview = new System.Windows.Forms.TextBox();
            this.txt_form_perview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startdate
            // 
            this.startdate.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.startdate.Location = new System.Drawing.Point(97, 6);
            this.startdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(265, 34);
            this.startdate.TabIndex = 0;
            // 
            // enddate
            // 
            this.enddate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Location = new System.Drawing.Point(96, 49);
            this.enddate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(265, 34);
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1583, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Pyidaungsu", 9F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(385, 28);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(191, 47);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "&Search";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txt_searchbox
            // 
            this.txt_searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchbox.Location = new System.Drawing.Point(1387, 28);
            this.txt_searchbox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_searchbox.Multiline = true;
            this.txt_searchbox.Name = "txt_searchbox";
            this.txt_searchbox.Size = new System.Drawing.Size(228, 38);
            this.txt_searchbox.TabIndex = 4;
            this.txt_searchbox.TextChanged += new System.EventHandler(this.txt_searchbox_TextChanged);
            this.txt_searchbox.Enter += new System.EventHandler(this.txt_searchbox_Enter);
            this.txt_searchbox.Leave += new System.EventHandler(this.txt_searchbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // export_excel
            // 
            this.export_excel.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.export_excel.IconColor = System.Drawing.Color.Green;
            this.export_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.export_excel.IconSize = 30;
            this.export_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.export_excel.Location = new System.Drawing.Point(600, 28);
            this.export_excel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.export_excel.Name = "export_excel";
            this.export_excel.Size = new System.Drawing.Size(191, 47);
            this.export_excel.TabIndex = 6;
            this.export_excel.Text = "&Export Excel";
            this.export_excel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-5, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1867, 1);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_shop_preview
            // 
            this.txt_shop_preview.Location = new System.Drawing.Point(880, 14);
            this.txt_shop_preview.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_shop_preview.Multiline = true;
            this.txt_shop_preview.Name = "txt_shop_preview";
            this.txt_shop_preview.Size = new System.Drawing.Size(132, 38);
            this.txt_shop_preview.TabIndex = 8;
            this.txt_shop_preview.Visible = false;
            // 
            // txt_form_perview
            // 
            this.txt_form_perview.Location = new System.Drawing.Point(1036, 14);
            this.txt_form_perview.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_form_perview.Multiline = true;
            this.txt_form_perview.Name = "txt_form_perview";
            this.txt_form_perview.Size = new System.Drawing.Size(172, 38);
            this.txt_form_perview.TabIndex = 9;
            this.txt_form_perview.Visible = false;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1652, 486);
            this.Controls.Add(this.txt_form_perview);
            this.Controls.Add(this.txt_shop_preview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.export_excel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txt_searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txt_searchbox;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton export_excel;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private TextBox txt_shop_preview;
        private TextBox txt_form_perview;
    }
}