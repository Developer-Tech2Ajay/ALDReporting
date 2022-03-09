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
            this.sp_GetProcessDeatilsByBatchIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new ALDReporting.ReportDataSet();
            this.AlarmReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetProcessDeatilsByBatchIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RV_ProcessReportAlarm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblS1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picAfterPStart = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picBeforePStart = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPEndDateTime = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPStartDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartProcess = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rvRecipe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrintProcesRpt = new System.Windows.Forms.Button();
            this.sp_GetProcessDeatilsByBatchIDTableAdapter = new ALDReporting.ReportDataSetTableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter();
            this.sp_GetProcessDeatilsByBatchIDTableAdapter1 = new ALDReporting.ReportDataSet1TableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetProcessDeatilsByBatchIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetProcessDeatilsByBatchIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfterPStart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBeforePStart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_GetProcessDeatilsByBatchIDBindingSource
            // 
            this.sp_GetProcessDeatilsByBatchIDBindingSource.DataMember = "sp_GetProcessDeatilsByBatchID";
            this.sp_GetProcessDeatilsByBatchIDBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reportViewer1.Location = new System.Drawing.Point(6, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(927, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // spGetProcessDeatilsByBatchIDBindingSource
            // 
            this.spGetProcessDeatilsByBatchIDBindingSource.DataMember = "sp_GetProcessDeatilsByBatchID";
            this.spGetProcessDeatilsByBatchIDBindingSource.DataSource = this.reportDataSetBindingSource;
            // 
            // reportDataSetBindingSource
            // 
            this.reportDataSetBindingSource.DataSource = this.reportDataSet;
            this.reportDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 672);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Blue;
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Process Report";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RV_ProcessReportAlarm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarm Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RV_ProcessReportAlarm
            // 
            this.RV_ProcessReportAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsReport_Alarm";
            reportDataSource2.Value = this.AlarmReportBindingSource;
            this.RV_ProcessReportAlarm.LocalReport.DataSources.Add(reportDataSource2);
            this.RV_ProcessReportAlarm.LocalReport.ReportEmbeddedResource = "ALDReporting.AlarmReport.Report_Alarm.rdlc";
            this.RV_ProcessReportAlarm.Location = new System.Drawing.Point(3, 3);
            this.RV_ProcessReportAlarm.Name = "RV_ProcessReportAlarm";
            this.RV_ProcessReportAlarm.ServerReport.BearerToken = null;
            this.RV_ProcessReportAlarm.Size = new System.Drawing.Size(933, 640);
            this.RV_ProcessReportAlarm.TabIndex = 0;
            this.RV_ProcessReportAlarm.Load += new System.EventHandler(this.RV_ProcessReportAlarm_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product Images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lblS1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(28, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 24);
            this.panel4.TabIndex = 4;
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS1.Location = new System.Drawing.Point(13, 4);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(125, 20);
            this.lblS1.TabIndex = 3;
            this.lblS1.Text = "Product Images ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(28, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 323);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.picAfterPStart);
            this.panel3.Location = new System.Drawing.Point(433, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 315);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Process Start";
            // 
            // picAfterPStart
            // 
            this.picAfterPStart.Location = new System.Drawing.Point(3, 35);
            this.picAfterPStart.Name = "picAfterPStart";
            this.picAfterPStart.Size = new System.Drawing.Size(400, 277);
            this.picAfterPStart.TabIndex = 0;
            this.picAfterPStart.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picBeforePStart);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 315);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Before Process Start";
            // 
            // picBeforePStart
            // 
            this.picBeforePStart.Location = new System.Drawing.Point(3, 32);
            this.picBeforePStart.Name = "picBeforePStart";
            this.picBeforePStart.Size = new System.Drawing.Size(421, 280);
            this.picBeforePStart.TabIndex = 1;
            this.picBeforePStart.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.chartProcess);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(939, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trend";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPEndDateTime);
            this.panel5.Controls.Add(this.lblStartDateTime);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblPStartDateTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(16, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(883, 28);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rvRecipe);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(939, 646);
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
            this.rvRecipe.Size = new System.Drawing.Size(939, 646);
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
            this.btnPrintProcesRpt.Click += new System.EventHandler(this.btnPrintProcesRpt_Click);
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
            this.ClientSize = new System.Drawing.Size(961, 691);
            this.Controls.Add(this.btnPrintProcesRpt);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report_Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Process";
            this.Load += new System.EventHandler(this.Report_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetProcessDeatilsByBatchIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetProcessDeatilsByBatchIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfterPStart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBeforePStart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).EndInit();
            this.tabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ReportDataSet1TableAdapters.sp_GetProcessDeatilsByBatchIDTableAdapter sp_GetProcessDeatilsByBatchIDTableAdapter1;
        private System.Windows.Forms.Button btnPrintProcesRpt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picAfterPStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBeforePStart;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProcess;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPStartDateTime;
        private Microsoft.Reporting.WinForms.ReportViewer RV_ProcessReportAlarm;
        private System.Windows.Forms.BindingSource AlarmReportBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rvRecipe;
        private System.Windows.Forms.Label lblPEndDateTime;
    }
}