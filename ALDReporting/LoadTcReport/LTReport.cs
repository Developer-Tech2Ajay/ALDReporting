using ALD_DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ALDReporting.ReportMethods;
using Entities;

namespace ALDReporting.LoadTcReport
{
    public partial class LTReport : Form
    {
        public string BatchID { get; set; }
        public DataTable dtForGraph = new DataTable();
        public DataTable dtForGraphCondition = new DataTable();
        public string process_startDateTime { get; set; }
        public string process_endDateTime { get; set; }
        public int parameter_Batch_Select { get; set; }

        public LTReport()
        {
            InitializeComponent();
        }
        public LTReport(string strBatchID)
        {
            InitializeComponent();
            BatchID = strBatchID;
          //  GetProductImages();

        }

        private void GetProductImages()
        {
            try
            {
                DalProductImages dAlProductImages = new DalProductImages();
                var imgs = dAlProductImages.GetProductImages(new ReqByBatchId() { BatchId = BatchID });
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
        private void LTReport_Load(object sender, EventArgs e)
        {
            //reportViewer1.RemoveOptionToDownload();
            //reportViewer2.RemoveOptionToDownload();
            //rvRecipe.RemoveOptionToDownload();

            ReportBind();
            this.reportViewer1.RefreshReport();
            //var dataAlarm = new DataAlarm(reportViewer2, Convert.ToDateTime(process_startDateTime), Convert.ToDateTime(process_endDateTime));
            //this.reportViewer2.RefreshReport();
            //LoadChart();
            //var dataRecipe = new DataRecipe(rvRecipe, BatchID);
            //this.rvRecipe.RefreshReport();
        }

        private DataTable GetLoadTcReportData()
        {
            var dal = new DalReport();
            var result = dal.GetLoadTcDetailsByBatchId(new ReqByBatchId() { BatchId = BatchID });
            var dtUniformityReport = CustomSystemClass.ToDataTable<Entities.UniformityReport>(result);
            //Making copy for Graph
            dtForGraph = dtUniformityReport.Copy();
            return dtUniformityReport;

        }
        private DataTable GetParametersDetails()
        {
            var dAlParameter = new DalParameter();
            var parameters = dAlParameter.D_GetParameterByBatchID(new ReqByBatchId() { BatchId = BatchID });
            var dtParameter = CustomSystemClass.ToDataTable<EParameter>(parameters);
            dtForGraphCondition = dtParameter.Copy();
            process_startDateTime = parameters[0].Process_Start_Date_Time;
            process_endDateTime = parameters[0].Process_End_Date_Time;
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
            var dtProcessReport = GetLoadTcReportData();
            if (dtProcessReport == null) return;
            var dtSystemVariables =CommonUtils.GetSystemDetails(BatchID);
            if (dtSystemVariables == null) return;
            var dtParameter = GetParametersDetails();
            if (dtParameter == null) return;

            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsProcessReport", dtProcessReport));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsSystemVariables", dtSystemVariables));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsParameter", dtParameter));

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        var dataAlarm = new DataAlarm(reportViewer2, Convert.ToDateTime(process_startDateTime), Convert.ToDateTime(process_endDateTime));
                        this.reportViewer2.RefreshReport();
                        break;
                    }
                case 2:
                    {
                        GetProductImages();
                        break;
                    }
                case 3:
                    {
                        LoadChart();
                        break;
                    }
                case 4:
                    {
                        var dataRecipe = new DataRecipe(rvRecipe, BatchID);
                        this.rvRecipe.RefreshReport();
                        //LoadRecipe();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
