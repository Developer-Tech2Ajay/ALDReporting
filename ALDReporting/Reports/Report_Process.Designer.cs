namespace ALDReporting.Reports
{
    partial class Report_Process
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Process));
            this.sp_GetProcessDeatilsByBatchIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlarmReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetProcessDeatilsByBatchIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.rptProc_AlarmRpt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartProcess = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPrintTrend = new System.Windows.Forms.Button();
            this.lblPEndDateTime = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPStartDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rvRecipe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrintProcesRpt = new System.Windows.Forms.Button();
            this.sp_GetParameterByBatchIDTableAdapter1 = new ALDReporting.rptdsParameterTableAdapters.sp_GetParameterByBatchIDTableAdapter();
            this.printDocumentTrend = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.reportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new ALDReporting.ReportDataSet();
            this.sp_GetProcessDeatilsByBatchIDTableAdapter = new ALDReporting.ReportDataSetTableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter();
            this.sp_GetProcessDeatilsByBatchIDTableAdapter1 = new ALDReporting.ReportDataSet1TableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetProcessDeatilsByBatchIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetProcessDeatilsByBatchIDBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AlarmReportBindingSource
            // 
            this.AlarmReportBindingSource.DataSource = typeof(Entities.AlarmReport);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_GetProcessDeatilsByBatchIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ALDReporting.Reports.Rpt_Process.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1435, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // spGetProcessDeatilsByBatchIDBindingSource
            // 
            this.spGetProcessDeatilsByBatchIDBindingSource.DataMember = "sp_GetProcessDeatilsByBatchID";
            this.spGetProcessDeatilsByBatchIDBindingSource.DataSource = this.reportDataSetBindingSource;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 596);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Process Report";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.rptProc_AlarmRpt);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1187, 570);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Alarm Report";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // rptProc_AlarmRpt
            // 
            this.rptProc_AlarmRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsReport_Alarm";
            reportDataSource2.Value = this.AlarmReportBindingSource;
            this.rptProc_AlarmRpt.LocalReport.DataSources.Add(reportDataSource2);
            this.rptProc_AlarmRpt.LocalReport.ReportEmbeddedResource = "ALDReporting.AlarmReport.Report_Alarm.rdlc";
            this.rptProc_AlarmRpt.Location = new System.Drawing.Point(0, 0);
            this.rptProc_AlarmRpt.Name = "rptProc_AlarmRpt";
            this.rptProc_AlarmRpt.ServerReport.BearerToken = null;
            this.rptProc_AlarmRpt.Size = new System.Drawing.Size(1187, 570);
            this.rptProc_AlarmRpt.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1187, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product Images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartProcess);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1187, 570);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trend";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartProcess
            // 
            this.chartProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartProcess.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.AxisY2.IsLogarithmic = true;
            chartArea1.Name = "ChartArea1";
            this.chartProcess.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            this.chartProcess.Legends.Add(legend1);
            this.chartProcess.Location = new System.Drawing.Point(16, 46);
            this.chartProcess.Name = "chartProcess";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProcess.Series.Add(series1);
            this.chartProcess.Size = new System.Drawing.Size(905, 524);
            this.chartProcess.TabIndex = 0;
            this.chartProcess.Text = "chartProcess";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPrintTrend);
            this.panel5.Controls.Add(this.lblPEndDateTime);
            this.panel5.Controls.Add(this.lblStartDateTime);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblPStartDateTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(16, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 28);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnPrintTrend
            // 
            this.btnPrintTrend.Location = new System.Drawing.Point(830, 2);
            this.btnPrintTrend.Name = "btnPrintTrend";
            this.btnPrintTrend.Size = new System.Drawing.Size(75, 23);
            this.btnPrintTrend.TabIndex = 5;
            this.btnPrintTrend.Text = "Print Trend";
            this.btnPrintTrend.UseVisualStyleBackColor = true;
            this.btnPrintTrend.Click += new System.EventHandler(this.btnPrintTrend_Click);
            // 
            // lblPEndDateTime
            // 
            this.lblPEndDateTime.AutoSize = true;
            this.lblPEndDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblPEndDateTime.Location = new System.Drawing.Point(572, 7);
            this.lblPEndDateTime.Name = "lblPEndDateTime";
            this.lblPEndDateTime.Size = new System.Drawing.Size(93, 13);
            this.lblPEndDateTime.TabIndex = 4;
            this.lblPEndDateTime.Text = "Process End Date";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.AutoSize = true;
            this.lblStartDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblStartDateTime.Location = new System.Drawing.Point(144, 7);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(96, 13);
            this.lblStartDateTime.TabIndex = 3;
            this.lblStartDateTime.Text = "Process Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(447, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Process End Date Time";
            // 
            // lblPStartDateTime
            // 
            this.lblPStartDateTime.AutoSize = true;
            this.lblPStartDateTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblPStartDateTime.Location = new System.Drawing.Point(138, 7);
            this.lblPStartDateTime.Name = "lblPStartDateTime";
            this.lblPStartDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblPStartDateTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Process Start Date Time";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rvRecipe);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1187, 570);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Recipe";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rvRecipe
            // 
            this.rvRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRecipe.LocalReport.ReportEmbeddedResource = "ALDReporting.Reports.RecipeReport.rdlc";
            this.rvRecipe.Location = new System.Drawing.Point(0, 0);
            this.rvRecipe.Name = "rvRecipe";
            this.rvRecipe.ServerReport.BearerToken = null;
            this.rvRecipe.Size = new System.Drawing.Size(1187, 570);
            this.rvRecipe.TabIndex = 0;
            // 
            // btnPrintProcesRpt
            // 
            this.btnPrintProcesRpt.Location = new System.Drawing.Point(852, 3);
            this.btnPrintProcesRpt.Name = "btnPrintProcesRpt";
            this.btnPrintProcesRpt.Size = new System.Drawing.Size(75, 23);
            this.btnPrintProcesRpt.TabIndex = 1;
            this.btnPrintProcesRpt.Text = "Print";
            this.btnPrintProcesRpt.UseVisualStyleBackColor = true;
            this.btnPrintProcesRpt.Visible = false;
            this.btnPrintProcesRpt.Click += new System.EventHandler(this.btnPrintProcesRpt_Click);
            // 
            // sp_GetParameterByBatchIDTableAdapter1
            // 
            this.sp_GetParameterByBatchIDTableAdapter1.ClearBeforeFill = true;
            // 
            // printDocumentTrend
            // 
            this.printDocumentTrend.DocumentName = "printDocumentTrend";
            this.printDocumentTrend.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentTrend_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocumentTrend;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // reportDataSetBindingSource
            // 
            this.reportDataSetBindingSource.DataSource = this.reportDataSet;
            this.reportDataSetBindingSource.Position = 0;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetProcessDeatilsByBatchIDTableAdapter
            // 
            this.sp_GetProcessDeatilsByBatchIDTableAdapter.ClearBeforeFill = true;
            // 
            // sp_GetProcessDeatilsByBatchIDTableAdapter1
            // 
            this.sp_GetProcessDeatilsByBatchIDTableAdapter1.ClearBeforeFill = true;
            // 
            // Report_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 630);
            this.Controls.Add(this.btnPrintProcesRpt);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report_Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Process";
            this.Load += new System.EventHandler(this.Report_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetProcessDeatilsByBatchIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetProcessDeatilsByBatchIDBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_GetProcessDeatilsByBatchIDBindingSource;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource reportDataSetBindingSource;
        private System.Windows.Forms.BindingSource spGetProcessDeatilsByBatchIDBindingSource;
        private ReportDataSetTableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter sp_GetProcessDeatilsByBatchIDTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ReportDataSet1TableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter sp_GetProcessDeatilsByBatchIDTableAdapter1;
        private System.Windows.Forms.Button btnPrintProcesRpt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProcess;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPStartDateTime;
        private System.Windows.Forms.BindingSource AlarmReportBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rvRecipe;
        private System.Windows.Forms.Label lblPEndDateTime;
        private rptdsParameterTableAdapters.sp_GetParameterByBatchIDTableAdapter sp_GetParameterByBatchIDTableAdapter1;
        private System.Windows.Forms.Button btnPrintTrend;
        private System.Drawing.Printing.PrintDocument printDocumentTrend;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer rptProc_AlarmRpt;
        //private ucProductImg ucProductImg1;
    }
}