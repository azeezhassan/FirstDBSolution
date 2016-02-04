namespace FirstDBWinApp
{
    partial class frmReport
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
            this.FirstDBDataSet = new FirstDBWinApp.FirstDBDataSet();
            this.StudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentInfoTableAdapter = new FirstDBWinApp.FirstDBDataSetTableAdapters.StudentInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FirstDBWinApp.Report.ListofStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 385);
            this.reportViewer1.TabIndex = 0;
            // 
            // FirstDBDataSet
            // 
            this.FirstDBDataSet.DataSetName = "FirstDBDataSet";
            this.FirstDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentInfoBindingSource
            // 
            this.StudentInfoBindingSource.DataMember = "StudentInfo";
            this.StudentInfoBindingSource.DataSource = this.FirstDBDataSet;
            // 
            // StudentInfoTableAdapter
            // 
            this.StudentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentInfoBindingSource;
        private FirstDBDataSet FirstDBDataSet;
        private FirstDBDataSetTableAdapters.StudentInfoTableAdapter StudentInfoTableAdapter;
    }
}