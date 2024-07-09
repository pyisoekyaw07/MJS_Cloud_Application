namespace MJS
{
    partial class outvoucher
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.otheroutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otherout = new MJS.otherout();
            this.other_outTableAdapter = new MJS.otheroutTableAdapters.other_outTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otheroutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherout)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "otheroutvoucher";
            reportDataSource1.Value = this.otheroutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MJS.otherout.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(896, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // otheroutBindingSource
            // 
            this.otheroutBindingSource.DataMember = "other_out";
            this.otheroutBindingSource.DataSource = this.otherout;
            // 
            // otherout
            // 
            this.otherout.DataSetName = "otherout";
            this.otherout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // other_outTableAdapter
            // 
            this.other_outTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 509);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otheroutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private otherout otherout;
        private System.Windows.Forms.BindingSource otheroutBindingSource;
        private otheroutTableAdapters.other_outTableAdapter other_outTableAdapter;
    }
}

