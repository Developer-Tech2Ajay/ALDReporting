using ALD_DAL;
using ALD_Entities;
using ALD_Entities.E_AlarmReport;
using ALD_Entities.ProcessReport;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ALDReporting.CustomClass;

namespace ALDReporting.UniformityReport
{
    public partial class UFReport : Form
    {
        public string BatchID { get; set; }
        public DataTable dtForGraph = new DataTable();
        public DataTable dtForGraphCondition = new DataTable();
        public DateTime process_startDateTime { get; set; }
        public DateTime process_endDateTime { get; set; }
        public int parameter_Batch_Select { get; set; }

        public UFReport()
        {
            InitializeComponent();
        }
        public UFReport(string strBatchID)
        {
            InitializeComponent();
            BatchID = strBatchID;
            GetProductImages();

        }

        private void GetProductImages()
        {
            try
            {
                DAL_ProductImages dAL_ProductImages = new DAL_ProductImages();
                var imgs = dAL_ProductImages.GetProductImages(new ProcessReport_RQ() { BatchId = BatchID });
                if (imgs != null)
                {
                    picBeforePStart.ImageLocation = imgs.ImageBefore;
                    picAfterPStart.ImageLocation = imgs.ImageAfter;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        #region Get Data For Reports - Uniformity and Draw
        private void UFReport_Load(object sender, EventArgs e)
        {
            List<string> allowedDownloadFormates = Convert.ToString(ConfigurationManager.AppSettings["AllowedDownloadFormate"]).Split(',').ToList();
            List<RenderingExtension> extension = reportViewer1.LocalReport.ListRenderingExtensions().ToList();
            if (extension != null)
            {
                foreach (var item in extension)
                {
                    if (allowedDownloadFormates.Contains(item.Name))
                        continue;
                    System.Reflection.FieldInfo fieldInfo = item.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                    fieldInfo.SetValue(item, false);
                }

            }
            ReportBind();
            this.reportViewer1.RefreshReport();
            ReportBind_Alarm();
            this.reportViewer2.RefreshReport();
            RecipeBind();
            this.rvRecipe.RefreshReport();

            LoadChart();
            this.rvRecipe.RefreshReport();
        }

        private void RecipeBind()
        {
            List<string> allowedDownloadFormates = Convert.ToString(ConfigurationManager.AppSettings["AllowedDownloadFormate"]).Split(',').ToList();
            List<RenderingExtension> extension = this.rvRecipe.LocalReport.ListRenderingExtensions().ToList();
            if (extension != null)
            {
                foreach (var item in extension)
                {
                    if (allowedDownloadFormates.Contains(item.Name))
                        continue;
                    System.Reflection.FieldInfo fieldInfo = item.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                    fieldInfo.SetValue(item, false);
                }

            }
            var dal_rr = new DAL_RecipeReport();
            var RecipeReports = dal_rr.GetRecipeReports(new ProcessReport_RQ() { BatchId = BatchID });
            var RecipeDetails = dal_rr.GetRecipeDetails(new ProcessReport_RQ() { BatchId = BatchID });

            var dtRecipeReports = CustomSystemClass.ToDataTable<ALD_Entities.Recipe.Recipe_Report>(RecipeReports);
            var dtRecipeDetails = CustomSystemClass.ToDataTable<ALD_Entities.Recipe.RecipeDetails>(RecipeDetails);
            this.rvRecipe.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRecipeDetails", dtRecipeReports));
            this.rvRecipe.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRecipe", dtRecipeDetails));
            this.rvRecipe.LocalReport.DisplayName = "Recipe Report  " + BatchID;
        }

        private DataTable GetSystemDetails()
        {
            SystemVariables _sv = new SystemVariables(BatchID, "Admin");
            List<SystemVariables> lstsv = new List<SystemVariables>();
            lstsv.Add(_sv);
            return CustomSystemClass.ToDataTable<SystemVariables>(lstsv);
        }
        private DataTable GetUniformityReportData()
        {
            DAL_ProcessReport _dal = new DAL_ProcessReport();
            var result = _dal.GetUniformityDeatilsByBatchID(new ALD_Entities.UniformityReport.UniformityReport_RQ() { BatchId = BatchID });
            var dtUniformityReport = CustomSystemClass.ToDataTable<ALD_Entities.UniformityReport.UniformityReport>(result);
            //Making copy for Graph
            dtForGraph = dtUniformityReport.Copy();
            return dtUniformityReport;

        }
        private DataTable GetParametersDetails()
        {
            DAL_Parameter dAL_Parameter = new DAL_Parameter();
            var parameters = dAL_Parameter.D_GetParameterByBatchID(new ALD_Entities.ProcessReport.ProcessReport_RQ() { BatchId = BatchID });
            var dtParameter = CustomSystemClass.ToDataTable<E_Parameter>(parameters);
            dtForGraphCondition = dtParameter.Copy();
            process_startDateTime = Convert.ToDateTime(parameters[0].Process_Start_Date_Time);
            process_endDateTime = Convert.ToDateTime(parameters[0].Process_End_Date_Time);
            parameter_Batch_Select = Convert.ToInt32(parameters[0].TC_Select);
            return dtParameter;
        }
        #endregion

        private DataTable RemoveNotReqiredColumn()
        {
            dtForGraph.Columns.Remove("SrNo");
            dtForGraph.Columns.Remove("ProfileStatus");
            string strPressUnitSelect = Convert.ToString(dtForGraphCondition.Rows[0]["Press_Unit_Select"]).ToLower();
            if (strPressUnitSelect == StaticValues.PressUnitSelect_mBar)
            {
                dtForGraph.Columns.Remove("PressTorr");
                dtForGraph.Columns.Remove("PressPa");
            }
            else if (strPressUnitSelect == StaticValues.PressUnitSelect_pa)
            {
                dtForGraph.Columns.Remove("PressmBar");
                dtForGraph.Columns.Remove("PressTorr");
            }
            else if (strPressUnitSelect == StaticValues.PressUnitSelect_Torr)
            {
                dtForGraph.Columns.Remove("PressmBar");
                dtForGraph.Columns.Remove("PressPa");
            }
            dtForGraph.Columns.Remove("EventName");
            for (int i = parameter_Batch_Select; i < StaticValues.MaxTC_Select; i++)
            {
                dtForGraph.Columns.Remove("Control" + (i + 1));
            }
            return dtForGraph;
        }


        private void LoadChart()
        {
            try
            {
                lblPStartDateTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
                lblPEndTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_End_Date_Time"]);

                //Remove unwanted column
                RemoveNotReqiredColumn();
                var maxY2Values = "0.00E+0";
                chartProcess.Series.RemoveAt(0);
                chartProcess.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;


                foreach (DataColumn dc in dtForGraph.Columns)
                {
                    if (dc.ColumnName != "ProcessDate")
                    {
                        chartProcess.Series.Add(dc.ColumnName);
                        chartProcess.Series[dc.ColumnName].ChartType = SeriesChartType.Spline;
                        foreach (DataRow item in dtForGraph.Rows)
                        {
                            var x = Convert.ToString(item["ProcessDate"]).Split(' ')[1];
                            var y = Convert.ToString(item[dc.ColumnName]);

                            if (y != "0.00E+0")
                                maxY2Values = y;
                            DataPoint point = new DataPoint();
                            point.SetValueXY(x, y);
                            point.ToolTip = string.Format("{0}, {1}", Convert.ToString(item["ProcessDate"]), y);
                            chartProcess.Series[dc.ColumnName].Points.Add(point);
                        }
                    }

                }

                //if (maxY2Values == "0")
                //{
                //    CustomMessageBox.Custom(BatchID + " batch don't have start date and time. Please connect system administrators !");
                //    return;
                //}

                //chartProcess.ChartAreas[0].AxisY2.IsLogarithmic = true;
                //chartProcess.ChartAreas[0].AxisY2.LogarithmBase = Math.E;
                chartProcess.ChartAreas[0].AxisY2.LabelStyle.Format = "0.00E+0";

                chartProcess.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chartProcess.ChartAreas[0].AxisX.LabelStyle.Interval = 2;
                chartProcess.ChartAreas[0].AxisX.Title = StaticValues.ProcessChart_xAxis;
                chartProcess.ChartAreas[0].AxisY.Title = StaticValues.ProcessChart_yAxis;
                chartProcess.ChartAreas[0].AxisY2.Title = StaticValues.ProcessChart_y2Axis;

                chartProcess.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                chartProcess.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

                chartProcess.Series[0].YAxisType = AxisType.Secondary;
                for (int i = 0; i < chartProcess.Series.Count(); i++)
                    chartProcess.Series[i].BorderWidth = 3;
                chartProcess.Legends["Legend1"].Docking = Docking.Bottom;
                chartProcess.DataSource = dtForGraph;
                chartProcess.DataBind();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void ReportBind()
        {
            // TODO: This line of code loads data into the 'reportDataSet.sp_GetProcessDeatilsByBatchID' table. You can move, or remove it, as needed.
            //Get DataSet
            var dtProcessReport = GetUniformityReportData();
            if (dtProcessReport == null) return;
            var dtSystemVariables = GetSystemDetails();
            if (dtSystemVariables == null) return;
            var dtParameter = GetParametersDetails();
            if (dtParameter == null) return;
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsProcessReport", dtProcessReport));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsSystemVariables", dtSystemVariables));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsParameter", dtParameter));
            this.reportViewer1.LocalReport.DisplayName = "Uniformity " + BatchID;

        }
        private void ReportBind_Alarm()
        {
            DAL_AlarmReport dal_Ar = new DAL_AlarmReport();
            //var result = dal_Ar.GetAlarmReports(new Report_RQ() { StartDateTime = Convert.ToString(Convert.ToDateTime("2020/03/01 12:00:00")), EndDateTime = Convert.ToString(Convert.ToDateTime("2020/03/25 12:00:00")) });
            var result = dal_Ar.GetAlarmReports(new Report_RQ() { StartDateTime = process_startDateTime, EndDateTime = process_endDateTime });
            var dtAlarmReport = CustomSystemClass.ToDataTable<ALD_Entities.E_AlarmReport.AlarmReport>(result);
            this.reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsReport_Alarm", dtAlarmReport));
        }

    }
}
