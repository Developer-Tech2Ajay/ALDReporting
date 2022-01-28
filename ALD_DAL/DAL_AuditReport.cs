using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALD_Entities.AuditReport;
using ALD_Entities.E_AlarmReport;
using Dapper;

namespace ALD_DAL
{
    public class DAL_AuditReport
    {
        public List<AuditReport> GetAuditReports(Report_RQ _req)
        {
            List<AuditReport> auditReports = new List<AuditReport>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@StartDate", _req.StartDateTime);
                    queryParameters.Add("@EndDate", _req.EndDateTime);

                    auditReports = conn.Query<AuditReport>("sp_GetAuditReport", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return auditReports;
        }
    }
}
