using System;
using System.Collections.Generic;
using System.Configuration;

namespace Entities
{
    public static class Constants
    {
        //SPs
        public static string ProcessDetailByBatchId = "sp_GetProcessDeatilsByBatchID";
        public static string UniformityDetailByBatchId = "sp_GetUniformityDeatilsByBatchID";
        public static string LoadTCDeatilsByBatchID = "sp_GetLoadTCDeatilsByBatchID";

        public static string GetAlarmInfo = "getAlarmInfo";
        public static string GetRecipeDetails = "sp_GetRecipeDetails";
        public static string GetRecipe = "sp_GetRecipe";
        public static string CheckImageIsExistForBatchId = "sp_CheckImageIsExistForBatchID";
        public static string GetImagesByBatchId = "sp_GetImagesByBatchID";
        public static string InsUpdImageForBatchId = "sp_InsUpdImageForBatchID";
        public static string GetParameterByBatchId = "sp_GetParameterByBatchID";
        public static string GetAuditReport = "sp_GetAuditReport";
        public static string GetAllBatchId = "sp_GetAllBatchID";
        public static string GetCorrectionFactorByBatchId = "sp_getCorrectionFactorByBatchId";
        public static string GetProcessDeatilsByDur = "sp_GetProcessDeatilsByTimeStamp";
        public static string GetParameterByDuration = "sp_GetParameterByDuration";
        public static string GetAuth = "sp_GetAuth";







        public static string ConnStringReport = Convert.ToString(ConfigurationManager.AppSettings["ConnStringReport"]);
        public static string ConnStringAlarm = Convert.ToString(ConfigurationManager.AppSettings["ConnStringAlarm"]);

        public static string BatchTypeProcess = "Process";
        public static string BatchTypeUniformity = "Uniformity";
        public static string BatchTypeLoadTc = "LoadTC";


        public static string PrintedBy = "Admin";


        /// <summary>
        /// All allowed PC Name
        /// </summary>
        public static List<string> machineNames = new List<string>()
        {
          "ALDIndia1040-01","ALDIndia1040-02","ALDIndia1040-03","ALDIndia1040-04",
          "ALDIndia1040-05","ALDIndia1040-06","ALDIndia1040-07","ALDIndia1040-08","ALDIndia1040-09","ALDIndia1040-10","ALDIndia1040-11","ALDIndia1042",
          "ALDIndia1043","ALDIndia1044","ALDIndia1045","ALDIndia1046","ALDIndia1047","ALDIndia1048","ALDIndia1049","ALDIndia1050",
          "ALDIndia1051","ALDIndia1052","ALDIndia1053","ALDIndia1054","ALDIndia1055","ALDIndia1056","ALDIndia1057","ALDIndia1058",
          "ALDIndia1059","ALDIndia1060","ALDIndia1061","ALDIndia1062","ALDIndia1063","ALDIndia1064","ALDIndia1065","ALDIndia1066",
          "ALDIndia1067","ALDIndia1068","ALDIndia1069","ALDIndia1070","ALDIndia1071","ALDIndia1072","ALDIndia1073","ALDIndia1074",
          "ALDIndia1075","ALDIndia1076","ALDIndia1077","ALDIndia1078","ALDIndia1079","ALDIndia1080","ALDIndia1081","ALDIndia1082",
          "ALDIndia1083","ALDIndia1084","ALDIndia1085","ALDIndia1086","ALDIndia1087","ALDIndia1088","ALDIndia1089","ALDIndia1090",
          "ALDIndia1091","ALDIndia1092","ALDIndia1093","ALDIndia1094","ALDIndia1095","ALDIndia1096","ALDIndia1097","ALDIndia1098",
          "ALDIndia1099","ALDIndia1100","DESKTP-HR8BFNM","DESKTP-4HCPKO4","FurnacePC","DESKTOP-4HCPOK4","DESKTOP-3rbGSF1","WW","DESKTOP-M9DI5PH" };

    }
}
