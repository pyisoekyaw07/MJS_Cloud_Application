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
            CS_Table = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            cmb_shop = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)CS_Table).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CS_Table
            // 
            CS_Table.AllowUserToAddRows = false;
            CS_Table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CS_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CS_Table.Location = new Point(15, 17);
            CS_Table.Name = "CS_Table";
            CS_Table.RowTemplate.Height = 30;
            CS_Table.Size = new Size(1240, 330);
            CS_Table.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(27, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(103, 38);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CS_Table);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 363);
            panel1.TabIndex = 2;
            // 
            // cmb_shop
            // 
            cmb_shop.FormattingEnabled = true;
            cmb_shop.Location = new Point(171, 28);
            cmb_shop.Name = "cmb_shop";
            cmb_shop.Size = new Size(121, 29);
            cmb_shop.TabIndex = 3;
            // 
            // closing_stock
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 524);
            Controls.Add(cmb_shop);
            Controls.Add(panel1);
            Controls.Add(iconButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "closing_stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "closing_stock";
            WindowState = FormWindowState.Maximized;
            Load += closing_stock_Load;
            ((System.ComponentModel.ISupportInitialize)CS_Table).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CS_Table;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private ComboBox cmb_shop;
    }
}