using ALD_DAL;
using ALDReporting.ReportMethods;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
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

        public UFReport()
        {
            InitializeComponent();
        }
        public UFReport(string strBatchId)
        {
            InitializeComponent();
            BatchId = strBatchId;
            //GetProductImages();

        }

        public void SetImage(PictureBox picbx)
        {
            //var imageSize = picbx.Image.Size;
            //var fitSize = picbx.ClientSize;
            //picbx.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
            //    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }
        private void GetProductImages()
        {
            try
            {
                DalProductImages dAlProductImages = new DalProductImages();
                var imgs = dAlProductImages.GetProductImages(new ReqByBatchId() { BatchId = BatchId });
                if (imgs == null) return;
                picBeforePStart.ImageLocation = imgs.ImageBefore;
                SetImage(picBeforePStart);
                picAfterPStart.ImageLocation = imgs.ImageAfter;
                SetImage(picBeforePStart);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //public void LoadRecipe()
        //{
        //    #region Recipe
        //    var dalRr = new DalRecipeReport();
        //    CommonUtils.AddDataSource(rvRecipe, "dsRecipeDetails", CustomSystemClass.ToDataTable<Recipe_Report>(dalRr.GetRecipeReports(new ReqByBatchId() { BatchId = BatchId })));
        //    CommonUtils.AddDataSource(rvRecipe, "dsRecipe", CustomSystemClass.ToDataTable<RecipeDetails>(dalRr.GetRecipeDetails(new ReqByBatchId() { BatchId = BatchId })));
        //    rvRecipe.LocalReport.DisplayName = "Recipe Report  " + BatchId;
        //    rvRecipe.RefreshReport();
        //    #endregion
        //}
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
    }
}
