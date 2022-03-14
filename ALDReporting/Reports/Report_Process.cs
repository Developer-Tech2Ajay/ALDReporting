using ALD_DAL;
using ALDReporting.CustomClass;
using ALDReporting.ReportMethods;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

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
        public ucProductImg ucProductImg;

        public Report_Process()
        {
            InitializeComponent();
        }
        public Report_Process(string strBatchId)
        {
            InitializeComponent();
            BatchID = strBatchId;
        }
        public Report_Process(ReportRq reportRq)
        {
            InitializeComponent();
        }

       
        private DataTable GetProcessReportData()
        {
            var dal = new DalReport();
            var result = dal.GetProcessDetailsByBatchId(new ReqByBatchId() { BatchId = BatchID });
            var dtProcessReport = CustomSystemClass.ToDataTable<ProcessReport>(result);
            //Making copy for Graph
            dtForGraph = dtProcessReport.Copy();
            return dtProcessReport;

        }

        private DataTable GetParametersDetails()
        {
            var dAlParameter = new DalParameter();
            var parameters = dAlParameter.D_GetParameterByBatchID(new ReqByBatchId() { BatchId = BatchID });
            var dtParameter = CustomSystemClass.ToDataTable<EParameter>(parameters);
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
            var dtSystemVariables = CommonUtils.GetSystemDetails(BatchID);
            if (dtSystemVariables == null) return;
            CommonUtils.AddDataSource(reportViewer1, "dsProcessReport", dtProcessReport);
            CommonUtils.AddDataSource(reportViewer1, "dsSystemVariables", dtSystemVariables);
            CommonUtils.AddDataSource(reportViewer1, "dsParameter", dtParameter);
            this.reportViewer1.LocalReport.DisplayName = "Process Report  " + BatchID;
        }

        private void Report_Process_Load(object sender, EventArgs e)
        {
            ReportBind();
            this.reportViewer1.RefreshReport();
           
        }




        private void btnPrintProcesRpt_Click(object sender, EventArgs e)
        {
            ReportBind();
            this.reportViewer1.PrintDialog();
            AlarmReport();
            this.RV_ProcessReportAlarm.PrintDialog();
            LoadChart();
            DataRecipe = new DataRecipe(this.rvRecipe, BatchID);
            this.rvRecipe.PrintDialog();
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
            lblStartDateTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
            lblPEndDateTime.Text = Convert.ToString(dtForGraphCondition.Rows[0]["Process_End_Date_Time"]);
            var chart = new DataChart(chartProcess, dtForGraph, dtForGraphCondition, parameter_Batch_Select);
        }
        private void AlarmReport()
        {

        }

        private void RV_ProcessReportAlarm_Load(object sender, EventArgs e)
        {
            // AlarmReport();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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
                        var dataAlarm = new DataAlarm(RV_ProcessReportAlarm, process_startDateTime, process_endDateTime);
                        this.RV_ProcessReportAlarm.RefreshReport();
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            
                            DalProductImages dAlProductImages = new DalProductImages();
                            var imgs = dAlProductImages.GetProductImages(new ReqByBatchId() { BatchId = BatchID });
                            if (ucProductImg == null)
                            {
                                if (imgs == null)
                                    ucProductImg = new ucProductImg();
                                else
                                    ucProductImg = new ucProductImg(imgs.ImageBefore, imgs.ImageAfter);
                                this.tabPage3.Controls.Add(ucProductImg);
                            }
                            ucProductImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                                                                                                | System.Windows.Forms.AnchorStyles.Bottom)
                                                                                                | System.Windows.Forms.AnchorStyles.Left)
                                                                                                | System.Windows.Forms.AnchorStyles.Right)));
                            ucProductImg.Dock = DockStyle.Fill;
                            ucProductImg.Location = new System.Drawing.Point(6, 6);
                            ucProductImg.Name = "ucProductImg1";
                            ucProductImg.Size = new System.Drawing.Size(920, 536);
                            ucProductImg.TabIndex = 0;
                            ucProductImg.BringToFront();

                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
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

        private void btnPrintTrend_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }
        Bitmap bmp;
        private void printDocumentTrend_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
