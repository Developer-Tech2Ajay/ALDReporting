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
        public static List<T> GetDataByBatch<T>(string batchId, string spName, string conString)
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
        public static List<T> GetDataByDuration<T>(ReportRq reportRq, string spName, string conString)
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
            catch (Exception)
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

        public static bool GetAuth(string uname, string pswd, string spName, string conString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@uname", uname);
                    queryParameters.Add("@pswd", pswd);
                    var isAuth = conn.Query<int>(spName, queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    if (isAuth == 1)
                        return true;
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool GetInstallationDate(string conString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    var dt = conn.Query<DateTime>("sp_getValues", queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    if (dt == null)
                        dt = new DateTime(2022, 04, 07);

                    Random r = new Random();
                    int rInt = r.Next(800, 950); //for ints
                    DateTime expdate = dt.AddDays(rInt);
                    if (DateTime.Now >= expdate)
                        return false;

                    return true;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }


}
