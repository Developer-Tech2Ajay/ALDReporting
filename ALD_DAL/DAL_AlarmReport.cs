using Entities;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalAlarmReport
    {
        public List<AlarmReport> GetAlarmReports(Report_RQ reportRq) 
            => DbAccess.GetDataByDuration<AlarmReport>(reportRq, Constants.GetAlarmInfo, Constants.ConnStringAlarm);
    }
}


