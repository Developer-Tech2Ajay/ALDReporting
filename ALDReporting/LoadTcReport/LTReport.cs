using ALD_DAL;
using ALDReporting.CustomClass;
using ALDReporting.ReportMethods;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

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
        public ucProductImg ucProductImg;


        public LTReport()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            HelperMethods.HideShowRecipe(tabControl1, tabPage5);
        }
        public LTReport(string strBatchID)
        {
            InitializeComponent();
            BatchID = strBatchID;
            WindowState = FormWindowState.Maximized;
            HelperMethods.HideShowRecipe(tabControl1, tabPage5);

        }
        
        #region Get Data For Reports - Uniformity and Draw
        private void LTReport_Load(object sender, EventArgs e)
        {

            ReportBind();
            this.reportViewer1.RefreshReport();
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
            var dtSystemVariables = CommonUtils.GetSystemDetails(BatchID);
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
                        try
                        {

                            DalProductImages dAlProductImages = new DalProductImages();
                            var imgs = dAlProductImages.GetProductImages(new ReqByBatchId() { BatchId = BatchID });

                            if (ucProductImg == null)
                            {
                                if (imgs == null)
                                    ucProductImg = new ucProductImg(BatchID);
                                else
                                    ucProductImg = new ucProductImg(imgs.ImageBefore, imgs.ImageAfter,BatchID);
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

        private void printDocumentLoadTrend_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;

        private void btnLoadTrend_Click(object sender, EventArgs e)
        {
            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            var img = sc.CaptureScreen();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string folderName = BatchID.Replace(' ', '-').Replace(':', '-'); ;
            string fullPath = desktopPath + "\\ALDReporting\\" + folderName;
            if (!File.Exists(fullPath))
                System.IO.Directory.CreateDirectory(fullPath);
            // capture this window, and save it
            sc.CaptureWindowToFile(this.Handle, Path.Combine(fullPath, "Trend.jpeg"), ImageFormat.Jpeg);
            // capture this window, and save it
            //sc.CaptureWindowToFile(this.Handle, Path.Combine(fullPath, "Trend.jpeg"), ImageFormat.Jpeg);
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();

        }
    }
}
