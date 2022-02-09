using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Server;

namespace ALDReporting
{
    public static class CommonUtils
    {
        public static void RemoveOptionToDownload(this ReportViewer @this)
        {
            List<string> allowedDownloadFormate = Convert.ToString(ConfigurationManager.AppSettings["AllowedDownloadFormat"]).Split(',').ToList();
            List<RenderingExtension> extension = @this.LocalReport.ListRenderingExtensions().ToList();
            foreach (var item in extension) 
            {
                if (allowedDownloadFormate.Contains(item.Name))
                    continue;
                System.Reflection.FieldInfo fieldInfo = item.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo?.SetValue(item, false);
            }
        }

        public static void AddDataSource(ReportViewer rv, string dataTableName, DataTable dataTable)
        {
            rv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource(dataTableName, dataTable));
        }

        public static DataTable GetSystemDetails(string batchId)
        {
            SystemVariables sv = new SystemVariables(batchId, "Admin");
            List<SystemVariables> lstsv = new List<SystemVariables>();
            lstsv.Add(sv);
            return CustomSystemClass.ToDataTable<SystemVariables>(lstsv);
        }

        
    }
}
