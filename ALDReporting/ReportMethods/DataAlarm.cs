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

        public DataAlarm(ReportViewer rptViewer, DateTime dtStart, DateTime dtEnd)
        {
            var dalAr = new DalAlarmReport();
            var result = dalAr.GetAlarmReports(new ReportRq() { StartDateTime = dtStart, EndDateTime = dtEnd });
            var dtAlarmReport = CustomSystemClass.ToDataTable<Entities.AlarmReport>(result);
            CommonUtils.AddDataSource(rptViewer, "dsReport_Alarm", dtAlarmReport);
            #region
            string exportOption = "Word";
            RenderingExtension extension = rptViewer.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase));
            if (extension != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension, false);
            }
            #endregion
        }
    }
}
