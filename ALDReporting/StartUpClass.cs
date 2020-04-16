using Newtonsoft.Json;
using System;
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
}
