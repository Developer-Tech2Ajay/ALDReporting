namespace ALDReporting.UniformityReport
{
    partial class UFReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPrintTrend = new System.Windows.Forms.Button();
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
            this.printDocumentUniTrend = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SystemVariablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uniformity Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ALDReporting.UniformityReport.UniReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1181, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 596);
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
            this.reportViewer2.Size = new System.Drawing.Size(989, 590);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(995, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product Images";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 596);
            this.panel1.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Controls.Add(this.chartProcess);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(995, 596);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trend";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPrintTrend);
            this.panel5.Controls.Add(this.lblPEndTime);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblPStartDateTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(27, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 28);
            this.panel5.TabIndex = 3;
            // 
            // btnPrintTrend
            // 
            this.btnPrintTrend.Location = new System.Drawing.Point(834, 2);
            this.btnPrintTrend.Name = "btnPrintTrend";
            this.btnPrintTrend.Size = new System.Drawing.Size(120, 23);
            this.btnPrintTrend.TabIndex = 4;
            this.btnPrintTrend.Text = "Print Trend";
            this.btnPrintTrend.UseVisualStyleBackColor = true;
            this.btnPrintTrend.Click += new System.EventHandler(this.btnPrintTrend_Click);
            // 
            // lblPEndTime
            // 
            this.lblPEndTime.AutoSize = true;
            this.lblPEndTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblPEndTime.Location = new System.Drawing.Point(570, 7);
            this.lblPEndTime.Name = "lblPEndTime";
            this.lblPEndTime.Size = new System.Drawing.Size(108, 15);
            this.lblPEndTime.TabIndex = 3;
            this.lblPEndTime.Text = "Process Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(447, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Process End Date Time";
            // 
            // lblPStartDateTime
            // 
            this.lblPStartDateTime.AutoSize = true;
            this.lblPStartDateTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblPStartDateTime.Location = new System.Drawing.Point(138, 7);
            this.lblPStartDateTime.Name = "lblPStartDateTime";
            this.lblPStartDateTime.Size = new System.Drawing.Size(0, 15);
            this.lblPStartDateTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
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
            this.chartProcess.Location = new System.Drawing.Point(27, 48);
            this.chartProcess.Name = "chartProcess";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProcess.Series.Add(series1);
            this.chartProcess.Size = new System.Drawing.Size(940, 515);
            this.chartProcess.TabIndex = 2;
            this.chartProcess.Text = "chartProcess";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rvRecipe);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(995, 596);
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
            this.rvRecipe.Size = new System.Drawing.Size(995, 596);
            this.rvRecipe.TabIndex = 0;
            this.rvRecipe.Load += new System.EventHandler(this.rvRecipe_Load);
            // 
            // E_ParameterBindingSource
            // 
            this.E_ParameterBindingSource.DataSource = typeof(Entities.EParameter);
            // 
            // ProcessReportBindingSource
            // 
            this.ProcessReportBindingSource.DataSource = typeof(Entities.UniformityReport);
            // 
            // AlarmReportBindingSource
            // 
            this.AlarmReportBindingSource.DataSource = typeof(Entities.AlarmReport);
            // 
            // printDocumentUniTrend
            // 
            this.printDocumentUniTrend.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentUniTrend_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocumentUniTrend;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SystemVariablesBindingSource
            // 
            this.SystemVariablesBindingSource.DataSource = typeof(ALDReporting.SystemVariables);
            // 
            // UFReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "UFReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniformity Report";
            this.Load += new System.EventHandler(this.UFReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPStartDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProcess;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer rvRecipe;
        private System.Windows.Forms.Button btnPrintTrend;
        private System.Drawing.Printing.PrintDocument printDocumentUniTrend;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}