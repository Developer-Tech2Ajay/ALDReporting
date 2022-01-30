using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entities;

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

        public static SystemMessage CheckEligibilityForUpload(ImageUploadForBatch obj)
        {
            SystemMessage systemMessage = new SystemMessage();
            try
            {
                using (SqlConnection conn = new SqlConnection(Constants.ConnStringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", obj.BatchID);
                    queryParameters.Add("@ImageType", obj.ImageType);

                    systemMessage = conn.Query<SystemMessage>(Constants.CheckImageIsExistForBatchId, queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                if (systemMessage != null)
                {
                    systemMessage.StatusCode = 2;
                    systemMessage.StatusMsg = ex.Message;
                }
            }
            return systemMessage;
        }
        public static SystemMessage InsUpdImageForBatchId(ImageUploadForBatch obj)
        {
            SystemMessage systemMessage = new SystemMessage();
            try
            {
                using (SqlConnection conn = new SqlConnection(Constants.ConnStringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); var param = new DynamicParameters();
                    param.Add("@BatchID", dbType: DbType.String, value: obj.BatchID, direction: ParameterDirection.Input);
                    param.Add("@ImageType", dbType: DbType.String, value: obj.ImageType, direction: ParameterDirection.Input);
                    param.Add("@ImageFilePath", dbType: DbType.String, value: obj.ImageFilePath, direction: ParameterDirection.Input);
                    param.Add("@IsOverWrite", dbType: DbType.Boolean, value: obj.IsOverWrite, direction: ParameterDirection.Input);

                    systemMessage = conn.Query<SystemMessage>(Constants.InsUpdImageForBatchId, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                if (systemMessage != null)
                {
                    systemMessage.StatusCode = 2;
                    systemMessage.StatusMsg = ex.Message;
                }
            }
            return systemMessage;
        }
    }

    
}
