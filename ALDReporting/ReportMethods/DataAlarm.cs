using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALD_DAL;
using Entities;
using Microsoft.Reporting.WinForms;

namespace ALDReporting.ReportMethods
{
    public class DataAlarm
    {
        public DataAlarm()
        {
            
        }

        public DataAlarm(ReportViewer rptViewer, DateTime dtStart,DateTime dtEnd)
        {
            rptViewer.RemoveOptionToDownload();
            var dalAr = new DalAlarmReport();
            var result = dalAr.GetAlarmReports(new ReportRq() { StartDateTime = dtStart, EndDateTime = dtEnd });
            var dtAlarmReport = CustomSystemClass.ToDataTable<Entities.AlarmReport>(result);
            CommonUtils.AddDataSource(rptViewer, "dsReport_Alarm", dtAlarmReport);
        }
    }
}
