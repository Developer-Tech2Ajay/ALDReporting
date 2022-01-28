using ALD_Entities.E_AlarmReport;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ALD_Entities.Util;
using System;
using System.Globalization;

namespace ALD_DAL
{
    public class DAL_AlarmReport
    {

        public List<AlarmReport> GetAlarmReports(Report_RQ _req)
        {
            List<AlarmReport> alarmReports = new List<AlarmReport>();
            try
            {
                using (SqlConnection conn = new SqlConnection(StaticCommonVariable.connstringAlarm))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    DynamicParameters queryParameters = new DynamicParameters();
                    queryParameters.Add("@StartDate", _req.StartDateTime.ToDateTimeMMDDYYYYString());
                    queryParameters.Add("@EndDate", _req.EndDateTime.ToDateTimeMMDDYYYYString());

                    alarmReports = conn.Query<AlarmReport>("getAlarmInfo", queryParameters, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return alarmReports;
        }
    }
}
