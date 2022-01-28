using ALD_Entities;
using ALD_Entities.ProcessReport;
using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ALD_DAL
{
    public class DAL_ProductImages
    {
        public SystemMessage D_CheckEligiabilityForUpload(ImageUploadForBatch _obj)
        {
            SystemMessage systemMessage = new SystemMessage();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _obj.BatchID);
                    queryParameters.Add("@ImageType", _obj.ImageType);

                    systemMessage = conn.Query<SystemMessage>("sp_CheckImageIsExistForBatchID", queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    //if (systemMessage.StatusCode == 0)
                    //    systemMessage = D_InsUpdImageForBatchID(_obj);
                }
            }
            catch (Exception ex)
            {
                systemMessage.StatusCode = 2;
                systemMessage.StatusMsg = ex.Message;
            }
            return systemMessage;
        }


        public SystemMessage D_InsUpdImageForBatchID(ImageUploadForBatch _obj)
        {
            SystemMessage systemMessage = new SystemMessage();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); var param = new DynamicParameters();
                    param.Add("@BatchID", dbType: DbType.String, value: _obj.BatchID, direction: ParameterDirection.Input);
                    param.Add("@ImageType", dbType: DbType.String, value: _obj.ImageType, direction: ParameterDirection.Input);
                    param.Add("@ImageFilePath", dbType: DbType.String, value: _obj.ImageFilePath, direction: ParameterDirection.Input);
                    param.Add("@IsOverWrite", dbType: DbType.Boolean, value: _obj.IsOverWrite, direction: ParameterDirection.Input);

                    systemMessage = conn.Query<SystemMessage>("sp_InsUpdImageForBatchID", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (System.Exception ex)
            {
                systemMessage.StatusCode = 2;
                systemMessage.StatusMsg = ex.Message;
            }
            return systemMessage;
        }

        public ProductImages GetProductImages(ProcessReport_RQ _obj)
        {
            ProductImages pi = new ProductImages();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringReport))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@BatchID", _obj.BatchId);

                    pi = conn.Query<ProductImages>("sp_GetImagesByBatchID", queryParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return pi;
        }
    }
}
