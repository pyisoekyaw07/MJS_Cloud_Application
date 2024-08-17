namespace MJS
{
    partial class Today_product
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
            this.btn_TPD_out = new System.Windows.Forms.Button();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TPD_out
            // 
            this.btn_TPD_out.Location = new System.Drawing.Point(55, 32);
            this.btn_TPD_out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TPD_out.Name = "btn_TPD_out";
            this.btn_TPD_out.Size = new System.Drawing.Size(175, 49);
            this.btn_TPD_out.TabIndex = 0;
            this.btn_TPD_out.Text = "Today Product Out";
            this.btn_TPD_out.UseVisualStyleBackColor = true;
            this.btn_TPD_out.Click += new System.EventHandler(this.btn_TPD_out_Click);
            // 
            // dgv_show
            // 
            this.dgv_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(55, 103);
            this.dgv_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.Size = new System.Drawing.Size(817, 181);
            this.dgv_show.TabIndex = 1;
            // 
            // Today_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 320);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.btn_TPD_out);
            this.Font = new System.Drawing.Font("Pyidaungsu", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Today_product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Today_product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TPD_out;
        private System.Windows.Forms.DataGridView dgv_show;
    }
}