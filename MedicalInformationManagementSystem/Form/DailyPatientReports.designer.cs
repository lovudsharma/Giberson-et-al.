﻿namespace MedicalInformationManagementSystem
{
    partial class DailyPatientReports
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
            this.getDailyPatientsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyReportDataSet = new HealthInformaticSystem.DataSet.DailyReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getDailyPatientsReportTableAdapter = new HealthInformaticSystem.DataSet.DailyReportDataSetTableAdapters.GetDailyPatientsReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getDailyPatientsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // getDailyPatientsReportBindingSource
            // 
            this.getDailyPatientsReportBindingSource.DataMember = "GetDailyPatientsReport";
            this.getDailyPatientsReportBindingSource.DataSource = this.dailyReportDataSet;
            // 
            // dailyReportDataSet
            // 
            this.dailyReportDataSet.DataSetName = "DailyReportDataSet";
            this.dailyReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DailyReportDataSet";
            reportDataSource1.Value = this.getDailyPatientsReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalInformationManagementSystem.Reports.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // getDailyPatientsReportTableAdapter
            // 
            this.getDailyPatientsReportTableAdapter.ClearBeforeFill = true;
            // 
            // DailyPatientReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DailyPatientReports";
            this.Text = "DailyPatientReports";
            this.Load += new System.EventHandler(this.DailyPatientReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getDailyPatientsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getDailyPatientsReportBindingSource;
        private HealthInformaticSystem.DataSet.DailyReportDataSet dailyReportDataSet;
        private HealthInformaticSystem.DataSet.DailyReportDataSetTableAdapters.GetDailyPatientsReportTableAdapter getDailyPatientsReportTableAdapter;
    }
}