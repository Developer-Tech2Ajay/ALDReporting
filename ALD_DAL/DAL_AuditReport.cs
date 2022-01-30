using ALD_Entities.AuditReport;
using ALD_Entities.E_AlarmReport;
using ALD_Entities.Util;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DalAuditReport
    {
        public List<AuditReport> GetAuditReports(Report_RQ req)
        => DbAccess.GetDataByDuration<AuditReport>(req, Constants.GetAuditReport, Constants.ConnStringReport);
    }
}
