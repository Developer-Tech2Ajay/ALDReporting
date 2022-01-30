using ALD_DAL;
using ALD_Entities.E_AlarmReport;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace ALDReporting.AlarmReport
{
    public partial class Report_Alarm : Form
    {
        public DateTime AR_StartDateTime { get; set; }
        public DateTime AR_EndDateTime { get; set; }
        public Report_Alarm()
        {
            InitializeComponent();
        }
        public Report_Alarm(Report_RQ _obj)
        {
            InitializeComponent();
            AR_StartDateTime = _obj.StartDateTime;
            AR_EndDateTime = _obj.EndDateTime;
        }
        private void Report_Alarm_Load(object sender, EventArgs e)
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
        }
        //private void Report_Alarm_PreRender(object sender, EventArgs e)
        //{
        //    DisableUnwantedExportFormat((ReportViewer)sender, "Excel");
        //    DisableUnwantedExportFormat((ReportViewer)sender, "Word");
        //}


        //public void DisableUnwantedExportFormat(ReportViewer ReportViewerID, string strFormatName)
        //{
        //    FieldInfo info;
        //    foreach (RenderingExtension extension in ReportViewerID.LocalReport.ListRenderingExtensions())
        //    {
        //        if (extension.Name.Trim().ToUpper() == strFormatName.Trim().ToUpper())
        //        {
        //            info = extension.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
        //            info.SetValue(extension, false);
        //        }
        //    }

        //}
        private void ReportBind()
        {
            try
            {
                DalAlarmReport dal_Ar = new DalAlarmReport();
                RemoveExportOptionOtherThanPDF();
                var result = dal_Ar.GetAlarmReports(new Report_RQ() { StartDateTime = AR_StartDateTime, EndDateTime = AR_EndDateTime });
                var dtAlarmReport = CustomSystemClass.ToDataTable<ALD_Entities.E_AlarmReport.AlarmReport>(result);
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsReport_Alarm", dtAlarmReport));
                this.reportViewer1.LocalReport.DisplayName = "Alarm Report";

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void RemoveExportOptionOtherThanPDF()
        {
            try
            {
                for (int i = 0; i < this.reportViewer1.LocalReport.ListRenderingExtensions().Length; i++)
                {
                    if (this.reportViewer1.LocalReport.ListRenderingExtensions()[i].Name != "Pdf")
                    {
                        //this.reportViewer1.LocalReport.ListRenderingExtensions()[i].Visible = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
