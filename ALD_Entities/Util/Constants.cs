using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALD_Entities.Util
{
    public static class Constants
    {
        //SPs
        public static string ProcessDetailByBatchId = "sp_GetProcessDeatilsByBatchID";
        public static string UniformityDetailByBatchId = "sp_GetUniformityDeatilsByBatchID";
        public static string GetAlarmInfo = "getAlarmInfo";
        public static string GetRecipeDetails = "sp_GetRecipeDetails";
        public static string GetRecipe = "sp_GetRecipe";
        public static string CheckImageIsExistForBatchId = "sp_CheckImageIsExistForBatchID";
        public static string GetImagesByBatchId = "sp_GetImagesByBatchID";
        public static string InsUpdImageForBatchId = "sp_InsUpdImageForBatchID";
        public static string GetParameterByBatchId = "sp_GetParameterByBatchID";
        public static string GetAuditReport = "sp_GetAuditReport";
        public static string GetAllBatchId = "sp_GetAllBatchID";




        public static string ConnStringReport = Convert.ToString(ConfigurationManager.AppSettings["ConnStringReport"]);
        public static string ConnStringAlarm = Convert.ToString(ConfigurationManager.AppSettings["ConnStringAlarm"]);

        public static string BatchTypeProcess = "Process";
        public static string BatchTypeUniformity = "Uniformity";
        public static string BatchTypeLoadTc = "Process";

    }
}
