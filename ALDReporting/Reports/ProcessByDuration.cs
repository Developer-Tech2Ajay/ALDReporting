using ALD_DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALDReporting.Reports
{
    public partial class ProcessByDuration : Form
    {
        ReportRq ReportRq = new ReportRq();
        public ProcessByDuration()
        {
            InitializeComponent();
        }
        public ProcessByDuration(ReportRq reportRq)
        {
            ReportRq = reportRq;
            InitializeComponent();
        }

        private void ProcessByDuration_Load(object sender, EventArgs e)
        {
           

        }
        private DataTable GetProcessReportData()
        {
            var dal = new DalReport();
            var result = dal.GetProcessByDur(ReportRq);
            var dtProcessReport = CustomSystemClass.ToDataTable<ProcessReport>(result);

            return dtProcessReport;

        }

        private void rptvw_ProcByDur_Load(object sender, EventArgs e)
        {
            var dtProcessReport = GetProcessReportData();
            if (dtProcessReport == null) return;
            CommonUtils.AddDataSource(rptvw_ProcByDur, "dsProcessByDuration", dtProcessReport);
            var dtParameter = GetParameterByDur();
            if (dtParameter == null) return;
            CommonUtils.AddDataSource(rptvw_ProcByDur, "dsParameterByDuration", dtParameter);
            var dtSystemVariables = GetSystemDetails();
            if (dtSystemVariables == null) return;
            CommonUtils.AddDataSource(rptvw_ProcByDur, "dsSystemVariables", dtSystemVariables);
            this.rptvw_ProcByDur.LocalReport.DisplayName = "Process Report  " + ReportRq.StartDateTime + '-' + ReportRq.EndDateTime;
            this.rptvw_ProcByDur.RefreshReport();
        }

        private DataTable GetSystemDetails()
        {
            SystemVariables sv = new SystemVariables(string.Empty, "Admin");
            List<SystemVariables> lstsv = new List<SystemVariables>();
            lstsv.Add(sv);
            return CustomSystemClass.ToDataTable<SystemVariables>(lstsv);
        }
        private DataTable GetParameterByDur()
        {
            var dAlParameter = new DalParameter();
            var parameters = dAlParameter.D_GetParameterByDur(ReportRq);
            var dtParameter = CustomSystemClass.ToDataTable<EParameter>(parameters);
            return dtParameter;
        }
    }
}
