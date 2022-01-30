using ALD_DAL;
using ALDReporting.CustomClass;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ALDReporting.ReportMethods;

namespace ALDReporting.Reports
{
    public partial class Report_Process : Form
    {
        public string BatchID { get; set; }
        public DataTable dtForGraph = new DataTable();
        public DataTable dtForGraphCondition = new DataTable();
        public DateTime process_startDateTime { get; set; }
        public DateTime process_endDateTime { get; set; }
        public int parameter_Batch_Select { get; set; }
        public DataRecipe DataRecipe;

        public Report_Process()
        {
            InitializeComponent();
        }
        public Report_Process(string strBatchId)
        {
            InitializeComponent();
            BatchID = strBatchId;
            GetProductImages();
        }
        public Report_Process(Report_RQ reportRq)
        {
            InitializeComponent();
            //BatchID = strBatchID;
            //GetProductImages();
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
        private DataTable GetProcessReportData()
        {
            DalProcessReport _dal = new DalProcessReport();
            var result = _dal.GetProcessDetailsByBatchId(new ProcessReport_RQ() { BatchId = BatchID });
            var dtProcessReport = CustomSystemClass.ToDataTable<ProcessReport>(result);
            //Making copy for Graph
            dtForGraph = dtProcessReport.Copy();
            return dtProcessReport;

        }

        private DataTable GetParametersDetails()
        {
            var dAlParameter = new DalParameter();
            var parameters = dAlParameter.D_GetParameterByBatchID(new ProcessReport_RQ() { BatchId = BatchID });
            var dtParameter = CustomSystemClass.ToDataTable<E_Parameter>(parameters);
            if (string.IsNullOrWhiteSpace(parameters[0].Process_Start_Date_Time))
            {
                CustomMessageBox.Custom(BatchID + " batch don't have start date and time. Please connect system administrators !");
                return null;
            }
            if (string.IsNullOrWhiteSpace(parameters[0].Process_End_Date_Time))
            {
                CustomMessageBox.Custom(BatchID + " batch don't have end date and time. Please connect system administrators !");
                return null;
            }
            process_startDateTime = Convert.ToDateTime(parameters[0].Process_Start_Date_Time);
            dtForGraphCondition = dtParameter.Copy();
            process_endDateTime = Convert.ToDateTime(parameters[0].Process_End_Date_Time);
            parameter_Batch_Select = Convert.ToInt32(parameters[0].TC_Select);
            return dtParameter;
        }

        private void ReportBind()
        {
            // TODO: This line of code loads data into the 'reportDataSet.sp_GetProcessDeatilsByBatchID' table. You can move, or remove it, as needed.
            //Get DataSet
            var dtParameter = GetParametersDetails();
            if (dtParameter == null) return;
            var dtProcessReport = GetProcessReportData();
            if (dtProcessReport == null) return;
            var dtSystemVariables =CommonUtils.GetSystemDetails(BatchID);
            if (dtSystemVariables == null) return;
            CommonUtils.AddDataSource(reportViewer1, "dsProcessReport", dtProcessReport);
            CommonUtils.AddDataSource(reportViewer1, "dsSystemVariables", dtSystemVariables);
            CommonUtils.AddDataSource(reportViewer1, "dsParameter", dtParameter);
            this.reportViewer1.LocalReport.DisplayName = "Process Report  " + BatchID;
        }

        private void Report_Process_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RemoveOptionToDownload();
            ReportBind();
            this.reportViewer1.RefreshReport();
            LoadChart();
            DataRecipe = new DataRecipe(rvRecipe, BatchID);
            this.rvRecipe.RefreshReport();
        }


        private void btnPrintProcesRpt_Click(object sender, EventArgs e)
        {
            ReportBind();
            this.reportViewer1.PrintDialog();
            this.RV_ProcessReportAlarm.PrintDialog();
            PageSetupDialog setupDlg = new PageSetupDialog();
            PrintDocument printDoc = new PrintDocument();
            setupDlg.Document = printDoc;
            setupDlg.AllowMargins = false;
            setupDlg.AllowOrientation = false;
            setupDlg.AllowPaper = false;
            setupDlg.AllowPrinter = false;
            setupDlg.Reset();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 210, 297);
        }
        private void LoadChart()
        {
            lblPStartDateTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
            lblPEndTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
            var chart = new DataChart(chartProcess, dtForGraph, dtForGraphCondition, parameter_Batch_Select);
        }

        private void RV_ProcessReportAlarm_Load(object sender, EventArgs e)
        {
            var dataAlarm = new DataAlarm(RV_ProcessReportAlarm, process_startDateTime, process_endDateTime);
            this.RV_ProcessReportAlarm.RefreshReport();
        }

    }
}
