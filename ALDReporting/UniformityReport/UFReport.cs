using ALD_DAL;
using ALDReporting.CustomClass;
using ALDReporting.ReportMethods;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ALDReporting.UniformityReport
{
    public partial class UFReport : Form
    {
        public string BatchId { get; set; }
        public DataTable DtForGraph = new DataTable();
        public DataTable DtForGraphCondition = new DataTable();
        public DateTime ProcessStartDateTime { get; set; }
        public DateTime ProcessEndDateTime { get; set; }
        public int ParameterBatchSelect { get; set; }
        public ucProductImg ucProductImg;


        public UFReport()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            HelperMethods.HideShowRecipe(tabControl1, tabPage5);
        }
        public UFReport(string strBatchId)
        {
            InitializeComponent();
            BatchId = strBatchId;
            WindowState = FormWindowState.Maximized;
            HelperMethods.HideShowRecipe(tabControl1, tabPage5);
            //GetProductImages();

        }


        #region Get Data For Reports - Uniformity and Draw
        private void UFReport_Load(object sender, EventArgs e)
        {
            #region
            string exportOption = "Word";
            RenderingExtension extension = reportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase));
            if (extension != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension, false);
            }
            #endregion
            ReportBind();
        }

        private DataTable GetUniformityReportData()
        {
            var dal = new DalReport();
            var result = dal.GetUniformityDetailsByBatchId(new ReqByBatchId() { BatchId = BatchId });
            var dtUniformityReport = CustomSystemClass.ToDataTable<Entities.UniformityReport>(result);
            //Making copy for Graph
            DtForGraph = dtUniformityReport.Copy();
            return dtUniformityReport;

        }
        private DataTable GetCorrectionFactor()
        {
            var dal = new DalReport();
            var result = dal.GetCorrectionFactorByBatchId(new ReqByBatchId() { BatchId = BatchId });
            return CustomSystemClass.ToDataTable<Entities.CorrectionFactor>(result); ;

        }
        private DataTable GetParametersDetails()
        {
            var dAlParameter = new DalParameter();
            var parameters = dAlParameter.D_GetParameterByBatchID(new ReqByBatchId() { BatchId = BatchId });
            var dtParameter = CustomSystemClass.ToDataTable<EParameter>(parameters);
            DtForGraphCondition = dtParameter.Copy();
            ProcessStartDateTime = Convert.ToDateTime(parameters[0].Process_Start_Date_Time);
            ProcessEndDateTime = Convert.ToDateTime(parameters[0].Process_End_Date_Time);
            ParameterBatchSelect = Convert.ToInt32(parameters[0].TC_Select);
            return dtParameter;
        }
        #endregion
        private void LoadChart()
        {
            lblPStartDateTime.Text = Convert.ToString(DtForGraphCondition.Rows[0]["Process_Start_Date_Time"]);
            lblPEndTime.Text = Convert.ToString(DtForGraphCondition.Rows[0]["Process_End_Date_Time"]);
            var chart = new DataChart(chartProcess, DtForGraph, DtForGraphCondition, ParameterBatchSelect);

        }
        private void ReportBind()
        {
            try
            {
                // TODO: This line of code loads data into the 'reportDataSet.sp_GetProcessDeatilsByBatchID' table. You can move, or remove it, as needed.
                //Get DataSet
                var dtProcessReport = GetUniformityReportData();
                if (dtProcessReport == null) return;
                var dtSystemVariables = CommonUtils.GetSystemDetails(BatchId);
                if (dtSystemVariables == null) return;
                var dtParameter = GetParametersDetails();
                if (dtParameter == null) return;
                var dtCorrectionFactor = GetCorrectionFactor();
                if (dtCorrectionFactor == null) return;
                CommonUtils.AddDataSource(reportViewer1, "dsProcessReport", dtProcessReport);
                CommonUtils.AddDataSource(reportViewer1, "dsSystemVariables", dtSystemVariables);
                CommonUtils.AddDataSource(reportViewer1, "dsParameter", dtParameter);
                CommonUtils.AddDataSource(reportViewer1, "dsCorrectionFactor", dtCorrectionFactor);
                this.reportViewer1.LocalReport.DisplayName = "Uniformity " + BatchId;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
                        var dataAlarm = new DataAlarm(reportViewer2, ProcessStartDateTime, ProcessEndDateTime);
                        this.reportViewer2.RefreshReport();
                        break;
                    }
                case 2:
                    {
                        try
                        {

                            DalProductImages dAlProductImages = new DalProductImages();
                            var imgs = dAlProductImages.GetProductImages(new ReqByBatchId() { BatchId = BatchId });
                            if (ucProductImg == null)
                            {
                                if (imgs == null)
                                    ucProductImg = new ucProductImg(BatchId);
                                else
                                    ucProductImg = new ucProductImg(imgs.ImageBefore, imgs.ImageAfter, BatchId);
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
                        var dataRecipe = new DataRecipe(rvRecipe, BatchId);
                        this.rvRecipe.RefreshReport();
                        //LoadRecipe();
                        break;
                    }
                default:
                    break;
            }
        }

        private void rvRecipe_Load(object sender, EventArgs e)
        {
            #region
            string exportOption = "Word";
            RenderingExtension extension = rvRecipe.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase));
            if (extension != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension, false);
            }
            #endregion
        }

        private void btnUniformityImagesPrint_Click(object sender, EventArgs e)
        {
            //System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            //doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(panel5);
            //doc.Print();
        }

        private void btnPrintTrend_Click(object sender, EventArgs e)
        {
            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            var img = sc.CaptureScreen();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string folderName = BatchId.Replace(' ', '-').Replace(':', '-'); ;
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
        Bitmap bmp;
        private void printDocumentUniTrend_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
