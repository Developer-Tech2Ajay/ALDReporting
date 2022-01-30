using ALD_DAL;
using ALD_Entities.AuditReport;
using ALD_Entities.E_AlarmReport;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace ALDReporting.Reports
{
    public partial class ReportAudit : Form
    {
        public DateTime SDateTime { get; set; }
        public DateTime EDateTime{ get; set; }
        public ReportAudit()
        {
            InitializeComponent();
        }
        public ReportAudit(Report_RQ reportRq)
        {
            InitializeComponent();
            SDateTime = reportRq.StartDateTime;
            EDateTime = reportRq.EndDateTime;
        }

        private void Report_Audit_Load(object sender, EventArgs e)
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

        private void ReportBind()
        {
            try
            {
                DalAuditReport dal = new DalAuditReport();
               var result = dal.GetAuditReports(new Report_RQ() { StartDateTime =SDateTime , EndDateTime = EDateTime });
                var dtAuditReport = CustomSystemClass.ToDataTable<AuditReport>(result);
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsAuditReport", dtAuditReport));
                this.reportViewer1.LocalReport.DisplayName = "Audit Report";

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
