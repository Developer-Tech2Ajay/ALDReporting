using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ALDReporting
{
    public class StartUpClass
    {
        public string system_name { get; set; }
        public string system_serial_no { get; set; }
    }
    public static class SetSystemVariable
    {
        public static StartUpClass LoadSystemData()
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\libs\\SystemDetails.json";
            var json = System.IO.File.ReadAllText(path);
            var systemvariableValues = JsonConvert.DeserializeObject<StartUpClass>(json);
            return systemvariableValues;
        }


    }
    public static class ReportClass
    {
        public static string BatchID { get; set; }
        public static string ImageType { get; set; }

    }
    public static class StaticValues
    {
        public static int MaxTC_Select = Convert.ToInt32(ConfigurationManager.AppSettings["MaxTC_Select"]);

        public static string ImageBefore = "BEFORE";
        public static string ImageAfter = "AFTER";

        public static string Image_Before = "Before";
        public static string Image_After = "After";

        public const string ReportType_Process = "Process";
        public const string ReportType_Uniformity = "Uniformity";
        public const string ReportType_LoadTC = "LoadTC";

        public const string PressUnitSelect_mBar = "mbar";
        public const string PressUnitSelect_pa = "pa";
        public const string PressUnitSelect_Torr = "torr";

        //Process Report Chart
        public const string ProcessChart_xAxis = "Time ->";
        public const string ProcessChart_yAxis = "Temperature";
        public const string ProcessChart_y2Axis = "Pressure";



    }
}
