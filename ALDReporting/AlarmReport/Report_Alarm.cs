using ALD_DAL;
using Entities;
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
        public DateTime ArStartDateTime { get; set; }
        public DateTime ArEndDateTime { get; set; }
        public Report_Alarm()
        {
            InitializeComponent();
        }
        public Report_Alarm(ReportRq obj)
        {
            InitializeComponent();
            ArStartDateTime = obj.StartDateTime;
            ArEndDateTime = obj.EndDateTime;
        }
        private void Report_Alarm_Load(object sender, EventArgs e)
        {
           // reportViewer1.RemoveOptionToDownload();
            ReportBind();
            this.reportViewer1.RefreshReport();
        }
      
        private void ReportBind()
        {
            try
            {
                var dalAr = new DalAlarmReport();
                var result = dalAr.GetAlarmReports(new ReportRq() { StartDateTime = ArStartDateTime, EndDateTime = ArEndDateTime });
                var dtAlarmReport = CustomSystemClass.ToDataTable<Entities.AlarmReport>(result);
                CommonUtils.AddDataSource(reportViewer1, "dsReport_Alarm", dtAlarmReport);
                this.reportViewer1.LocalReport.DisplayName = "Alarm Report";

            }
            catch (Exception ex)
            {
                throw;
            }
        }

      
    }
}
