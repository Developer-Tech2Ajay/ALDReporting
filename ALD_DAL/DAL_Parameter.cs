using ALD_Entities;
using ALD_Entities.ProcessReport;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ALD_DAL
{
    public class DAL_Parameter
    {
        public List<E_Parameter> D_GetParameterByBatchID(ProcessReport_RQ _obj)
        {
            List<E_Parameter> e_Parameter = new List<E_Parameter>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _obj.BatchId);

                    e_Parameter = conn.Query<E_Parameter>("sp_GetParameterByBatchID", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {

            }
            return e_Parameter;
        }
    }
}
