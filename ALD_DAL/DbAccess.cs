using ALD_Entities.E_AlarmReport;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ALD_DAL
{
    public static class DbAccess
    {
        public static List<T> GetDataByBatch<T>(string batchId,string spName,string conString)
        {
            var lstObj = new List<T>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", batchId);
                    lstObj = conn.Query<T>(spName, queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return (List<T>)lstObj;
        }

        public static List<T> GetDataByDuration<T>(Report_RQ reportRq, string spName,string conString)
        {
            var lstObj = new List<T>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@StartDate", reportRq.StartDateTime);
                    queryParameters.Add("@EndDate", reportRq.EndDateTime);
                    lstObj = conn.Query<T>(spName, queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return (List<T>)lstObj;
        }
        public static List<T> GetApplicationData<T>(string spName, string conString)
        {
            var lstObj = new List<T>();
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    lstObj = conn.Query<T>(spName, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return (List<T>)lstObj;
        }
    }

    
}
