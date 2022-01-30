using ALD_Entities;
using ALD_Entities.ProcessReport;
using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ALD_Entities.Util;

namespace ALD_DAL
{
    public class DalProductImages
    {
        public SystemMessage D_CheckEligiabilityForUpload(ImageUploadForBatch obj)
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


        public SystemMessage D_InsUpdImageForBatchID(ImageUploadForBatch obj)
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

        public ProductImages GetProductImages(ProcessReport_RQ obj)
        {
            var lst = DbAccess.GetDataByBatch<ProductImages>(obj.BatchId, Constants.GetImagesByBatchId,
                Constants.ConnStringReport);
            return lst.FirstOrDefault();
        }
    }
}
