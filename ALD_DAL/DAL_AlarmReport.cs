using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalAlarmReport
    {
        public List<AlarmReport> GetAlarmReports(ReportRq reportRq) 
            => DbAccess.GetDataByDuration<AlarmReport>(reportRq, Constants.GetAlarmInfo, Constants.ConnStringAlarm);
    }
}


