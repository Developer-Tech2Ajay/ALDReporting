using ALD_DAL;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ALDReporting.CustomClass;
using ALDReporting.ReportMethods;

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
                DalProductImages dAlProductImages = new DalProductImages();
                var imgs = dAlProductImages.GetProductImages(new ProcessReport_RQ() { BatchId = BatchID });
                if (imgs == null) return;
                picBeforePStart.ImageLocation = imgs.ImageBefore;
                picAfterPStart.ImageLocation = imgs.ImageAfter;
            }
            catch (Exception)
            {

                throw;
            }
        }


        #region Get Data For Reports - Uniformity and Draw
        private void UFReport_Load(object sender, EventArgs e)
        {

            ReportBind();
            this.reportViewer1.RemoveOptionToDownload();
            this.reportViewer1.RefreshReport();
            var dataAlarm = new DataAlarm(reportViewer2, process_startDateTime, process_endDateTime);
            this.reportViewer2.RemoveOptionToDownload();
            this.reportViewer2.RefreshReport();
            var dataRecipe = new DataRecipe(rvRecipe, BatchID);
            this.rvRecipe.RemoveOptionToDownload();
            this.rvRecipe.RefreshReport();
            LoadChart();
        }

        private DataTable GetUniformityReportData()
        {
            DalProcessReport _dal = new DalProcessReport();
            var result = _dal.GetUniformityDetailsByBatchId(new UniformityReport_RQ() { BatchId = BatchID });
            var dtUniformityReport = CustomSystemClass.ToDataTable<Entities.UniformityReport>(result);
            //Making copy for Graph
            dtForGraph = dtUniformityReport.Copy();
            return dtUniformityReport;

        }
        private DataTable GetParametersDetails()
        {
            DalParameter dAL_Parameter = new DalParameter();
            var parameters = dAL_Parameter.D_GetParameterByBatchID(new ProcessReport_RQ() { BatchId = BatchID });
            var dtParameter = CustomSystemClass.ToDataTable<EParameter>(parameters);
            dtForGraphCondition = dtParameter.Copy();
            process_startDateTime = Convert.ToDateTime(parameters[0].Process_Start_Date_Time);
            process_endDateTime = Convert.ToDateTime(parameters[0].Process_End_Date_Time);
            parameter_Batch_Select = Convert.ToInt32(parameters[0].TC_Select);
            return dtParameter;
        }
        #endregion




        private void LoadChart()
        {
            lblPStartDateTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
            lblPEndTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_End_Date_Time"]);
            var chart = new DataChart(chartProcess, dtForGraph, dtForGraphCondition, parameter_Batch_Select);

        }
        private void ReportBind()
        {
            // TODO: This line of code loads data into the 'reportDataSet.sp_GetProcessDeatilsByBatchID' table. You can move, or remove it, as needed.
            //Get DataSet
            var dtProcessReport = GetUniformityReportData();
            if (dtProcessReport == null) return;
            var dtSystemVariables = CommonUtils.GetSystemDetails(BatchID);
            if (dtSystemVariables == null) return;
            var dtParameter = GetParametersDetails();
            if (dtParameter == null) return;
            CommonUtils.AddDataSource(reportViewer1, "dsProcessReport", dtProcessReport);
            CommonUtils.AddDataSource(reportViewer1, "dsSystemVariables", dtSystemVariables);
            CommonUtils.AddDataSource(reportViewer1, "dsParameter", dtParameter);
            this.reportViewer1.LocalReport.DisplayName = "Uniformity " + BatchID;

        }
    }
}
