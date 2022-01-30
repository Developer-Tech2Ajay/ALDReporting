using ALD_DAL;
using Entities;
using System;
using System.Windows.Forms;

namespace ALDReporting.Reports
{
    public partial class ReportAudit : Form
    {
        public DateTime SDateTime { get; set; }
        public DateTime EDateTime { get; set; }
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
            reportViewer1.RemoveOptionToDownload();
            ReportBind();
            this.reportViewer1.RefreshReport();
        }

        private void ReportBind()
        {
            try
            {
                var dal = new DalAuditReport();
                var result = dal.GetAuditReports(new Report_RQ() { StartDateTime = SDateTime, EndDateTime = EDateTime });
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
