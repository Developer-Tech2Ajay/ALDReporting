using ALD_Entities.ProcessReport;
using ALD_Entities.UniformityReport;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ALD_DAL
{
    public class DAL_ProcessReport
    {

        public List<ProcessReport> GetProcessDeatilsByBatchID(ProcessReport_RQ _obj)
        {

            List<ProcessReport> lstPR = new List<ProcessReport>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _obj.BatchId);

                    lstPR = conn.Query<ProcessReport>("sp_GetProcessDeatilsByBatchID", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return lstPR;
        }
        public List<UniformityReport> GetUniformityDeatilsByBatchID(UniformityReport_RQ _obj)
        {

            List<ALD_Entities.UniformityReport.UniformityReport> lstUR = new List<ALD_Entities.UniformityReport.UniformityReport>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _obj.BatchId);

                    lstUR = conn.Query<UniformityReport>("sp_GetUniformityDeatilsByBatchID", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return lstUR;
        }
    }
}
