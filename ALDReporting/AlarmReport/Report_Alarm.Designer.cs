namespace ALDReporting.AlarmReport
{
    partial class Report_Alarm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlarmReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmReportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ALDReporting.AlarmReport.Report_Alarm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1022, 705);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.Report_Alarm_Load);
            // 
            // AlarmReportBindingSource
            // 
            this.AlarmReportBindingSource.DataSource = typeof(Entities.AlarmReport);
            // 
            // alarmReportBindingSource1
            // 
            this.alarmReportBindingSource1.DataSource = typeof(Entities.AlarmReport);
            // 
            // Report_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 705);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report_Alarm";
            this.Text = "Alarm Report";
            this.Load += new System.EventHandler(this.Report_Alarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmReportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlarmReportBindingSource;
        private System.Windows.Forms.BindingSource alarmReportBindingSource1;
    }
}