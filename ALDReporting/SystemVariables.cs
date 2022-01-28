using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Reflection;

namespace ALDReporting
{
    public class SystemVariables
    {
        public string SystemName { get; set; }
        public string SystemSerialNo { get; set; }
        public string PrintedBy { get; set; }
        public string PrintDate { get; set; }
        public string BatchID { get; set; }

        public SystemVariables(string strBatchId, string printedBy)
        {
            BatchID = strBatchId;
            PrintedBy = printedBy;
            PrintDate = DateTime.Now.ToString();
            SystemName = Convert.ToString(ConfigurationManager.AppSettings["SystemName"]);
            SystemSerialNo = Convert.ToString(ConfigurationManager.AppSettings["SystemSerialNo"]);
        }

        public DataTable SystemVariableToTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("SystemName");
            dataTable.Columns.Add("SystemSerialNo");
            dataTable.Columns.Add("PrintedBy");
            dataTable.Columns.Add("PrintDate");
            dataTable.Columns.Add("BatchID");

            DataRow toInsert = dataTable.NewRow();
            toInsert["SystemName"] = this.SystemName;
            toInsert["SystemSerialNo"] = this.SystemSerialNo;
            toInsert["PrintedBy"] = this.PrintedBy;
            toInsert["PrintDate"] = this.PrintDate;
            toInsert["BatchID"] = this.BatchID;
            dataTable.Rows.Add(toInsert);
            return dataTable;
        }
    }
    public static class CustomSystemClass
    {
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        //internal static object ToDataTable<T>(List<ALD_Entities.UniformityReport.UniformityReport> result)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static object ToDataTable<T>(List<ALD_Entities.E_AlarmReport.AlarmReport> result)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
