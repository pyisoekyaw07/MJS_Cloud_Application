using System.Drawing;
using System.Windows.Forms;

namespace MJS
{
    partial class closing_stock
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
            this.CS_Table = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_shop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CS_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CS_Table
            // 
            this.CS_Table.AllowUserToAddRows = false;
            this.CS_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CS_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CS_Table.Location = new System.Drawing.Point(15, 11);
            this.CS_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CS_Table.Name = "CS_Table";
            this.CS_Table.RowTemplate.Height = 30;
            this.CS_Table.Size = new System.Drawing.Size(1240, 204);
            this.CS_Table.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(27, 15);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(103, 24);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CS_Table);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 225);
            this.panel1.TabIndex = 2;
            // 
            // cmb_shop
            // 
            this.cmb_shop.FormattingEnabled = true;
            this.cmb_shop.Location = new System.Drawing.Point(171, 17);
            this.cmb_shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_shop.Name = "cmb_shop";
            this.cmb_shop.Size = new System.Drawing.Size(121, 21);
            this.cmb_shop.TabIndex = 3;
            // 
            // closing_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 324);
            this.Controls.Add(this.cmb_shop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "closing_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "closing_stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.closing_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CS_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView CS_Table;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private ComboBox cmb_shop;
    }
}