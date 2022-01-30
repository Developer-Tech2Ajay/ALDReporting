using System.Collections.Generic;
using Entities;

namespace ALD_DAL
{
    public class DalAuditReport
    {
        public List<AuditReport> GetAuditReports(Report_RQ req)
        => DbAccess.GetDataByDuration<AuditReport>(req, Constants.GetAuditReport, Constants.ConnStringReport);
    }
}
