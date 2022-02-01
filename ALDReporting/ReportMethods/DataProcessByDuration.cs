using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;

namespace ALDReporting.ReportMethods
{
    public class DataProcessByDuration
    {
        private ReportRq _reportRq;
        public DataProcessByDuration(ReportRq reportRq)
        {
            this._reportRq = reportRq;
        }

        public List<ProcessReport> GetProcessReportsData()
        {
            return new List<ProcessReport>();
        }
        public List<EParameter> GetProcessParameters()
        {
            return new List<EParameter>();
        }
        public DataTable GetSystemDetails()
        {
            return CustomSystemClass.ToDataTable<AppDetails>(new List<AppDetails>()
            {
                new AppDetails(_reportRq)
            });
        }
    }

    public class AppDetails
    {
        public string SystemName { get; set; }
        public string SystemSerialNo { get; set; }
        public string PrintedBy { get; set; }
        public string PrintDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public AppDetails(ReportRq reportRq)
        {
            StartDateTime = reportRq.StartDateTime;
            EndDateTime = reportRq.EndDateTime;
            PrintedBy = Constants.PrintedBy;
            PrintDate = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            SystemName = Convert.ToString(ConfigurationManager.AppSettings["SystemName"]);
            SystemSerialNo = Convert.ToString(ConfigurationManager.AppSettings["SystemSerialNo"]);
        }
    }
}
