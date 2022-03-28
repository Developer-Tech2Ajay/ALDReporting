using Entities;

namespace ALDReporting.LoadTcReport
{
    partial class LTReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LTReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLoadTrend = new System.Windows.Forms.Button();
            this.lblPEndTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPStartDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartProcess = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rvRecipe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.E_ParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcessReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlarmReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocumentLoadTrend = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SystemVariablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_ParameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemVariablesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 596);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Load TC Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ALDReporting.LoadTcReport.LTReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1151, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1187, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarm Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ALDReporting.AlarmReport.Report_Alarm.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1181, 564);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1187, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product Images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.chartProcess);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1187, 570);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trands";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLoadTrend);
            this.panel5.Controls.Add(this.lblPEndTime);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblPStartDateTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(133, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(883, 28);
            this.panel5.TabIndex = 5;
            // 
            // btnLoadTrend
            // 
            this.btnLoadTrend.Location = new System.Drawing.Point(783, 3);
            this.btnLoadTrend.Name = "btnLoadTrend";
            this.btnLoadTrend.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTrend.TabIndex = 4;
            this.btnLoadTrend.Text = "Print Trend";
            this.btnLoadTrend.UseVisualStyleBackColor = true;
            this.btnLoadTrend.Visible = false;
            this.btnLoadTrend.Click += new System.EventHandler(this.btnLoadTrend_Click);
            // 
            // lblPEndTime
            // 
            this.lblPEndTime.AutoSize = true;
            this.lblPEndTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblPEndTime.Location = new System.Drawing.Point(570, 7);
            this.lblPEndTime.Name = "lblPEndTime";
            this.lblPEndTime.Size = new System.Drawing.Size(96, 13);
            this.lblPEndTime.TabIndex = 3;
            this.lblPEndTime.Text = "Process Start Date";
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
            chartArea2.AxisY2.IsLogarithmic = true;
            chartArea2.Name = "ChartArea1";
            this.chartProcess.ChartAreas.Add(chartArea2);
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            this.chartProcess.Legends.Add(legend2);
            this.chartProcess.Location = new System.Drawing.Point(123, 54);
            this.chartProcess.Name = "chartProcess";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProcess.Series.Add(series2);
            this.chartProcess.Size = new System.Drawing.Size(940, 499);
            this.chartProcess.TabIndex = 4;
            this.chartProcess.Text = "chartProcess";
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
            // E_ParameterBindingSource
            // 
            this.E_ParameterBindingSource.DataSource = typeof(Entities.EParameter);
            // 
            // ProcessReportBindingSource
            // 
            this.ProcessReportBindingSource.DataSource = typeof(Entities.ProcessReport);
            // 
            // AlarmReportBindingSource
            // 
            this.AlarmReportBindingSource.DataSource = typeof(Entities.AlarmReport);
            // 
            // printDocumentLoadTrend
            // 
            this.printDocumentLoadTrend.DocumentName = "printDocumentLoadTrend";
            this.printDocumentLoadTrend.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLoadTrend_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocumentLoadTrend;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SystemVariablesBindingSource
            // 
            this.SystemVariablesBindingSource.DataSource = typeof(ALDReporting.SystemVariables);
            // 
            // LTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "LTReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load TC Report";
            this.Load += new System.EventHandler(this.LTReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcess)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.E_ParameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemVariablesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SystemVariablesBindingSource;
        private System.Windows.Forms.BindingSource E_ParameterBindingSource;
        private System.Windows.Forms.BindingSource ProcessReportBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource AlarmReportBindingSource;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPStartDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProcess;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rvRecipe;
        private System.Drawing.Printing.PrintDocument printDocumentLoadTrend;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnLoadTrend;
    }
}