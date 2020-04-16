using System;
using System.Configuration;

namespace ALD_DAL
{
    public static class StaticCommonVariable
    {
        public static string connstringReport = Convert.ToString(ConfigurationManager.AppSettings["connstringReport"]);
        public static string connstringAlarm = Convert.ToString(ConfigurationManager.AppSettings["connstringAlarm"]);

        public static string BatchType_Process = "Process";
        public static string BatchType_Uniformity = "Uniformity";
        public static string BatchType_LoadTC = "Process";

    }
}
