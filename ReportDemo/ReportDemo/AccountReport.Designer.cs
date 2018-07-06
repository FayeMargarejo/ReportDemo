namespace ReportDemo
{
    partial class AccountReport
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
            this.rptAccounts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BsAccounts = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BsAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // rptAccounts
            // 
            reportDataSource1.Name = "DSAccounts";
            reportDataSource1.Value = this.BsAccounts;
            this.rptAccounts.LocalReport.DataSources.Add(reportDataSource1);
            this.rptAccounts.LocalReport.ReportEmbeddedResource = "ReportDemo.AccountReport.rdlc";
            this.rptAccounts.Location = new System.Drawing.Point(12, 38);
            this.rptAccounts.Name = "rptAccounts";
            this.rptAccounts.ServerReport.BearerToken = null;
            this.rptAccounts.Size = new System.Drawing.Size(725, 351);
            this.rptAccounts.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // BsAccounts
            // 
            this.BsAccounts.DataSource = typeof(ReportDemo.AccountsMdl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 401);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rptAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BsAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAccounts;
        private System.Windows.Forms.BindingSource BsAccounts;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

