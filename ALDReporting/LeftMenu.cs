using ALD_DAL;
using ALD_Entities;
using ALDReporting.Reports;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class LeftMenu : UserControl
    {

        public LeftMenu()
        {
            InitializeComponent();
            FullAllIDWithOutParameter();
            FullAllIDWithParameter();

        }
        private void SetDateFormate()
        {
            dtPStartDate.Format = DateTimePickerFormat.Custom;
            dtPStartDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            dtPEndDate.Format = DateTimePickerFormat.Custom;
            dtPEndDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
        private void FullAllIDWithParameter()
        {
            SetDateFormate();

        }

        private void FullAllIDWithOutParameter()
        {
            SetDateFormate();
            FillAllData();
        }

        private void FillAllData()
        {
            //Call Procedure
            ALD_DAL.DropDownForBatchID dal_batchid = new DropDownForBatchID();
            List<AllDropDownData> lstDDL = dal_batchid.GetAllDropDownValues();



            //Fill Process Drop Down
            List<AllDropDownData> lstDDL_Process = new List<AllDropDownData>();
            if (lstDDL.Count > 0)
                lstDDL_Process = lstDDL.AsEnumerable().Where(x => x.Batch_Select == StaticCommonVariable.BatchType_Process).ToList();
            cmbProcessBatch.DataSource = lstDDL_Process;
            cmbProcessBatch.DisplayMember = "Batch_Id";
            cmbProcessBatch.ValueMember = "ID";
            cmbProcessBatch.SelectedIndex = 0;

            //Fill Uniformity
            List<AllDropDownData> lstDDL_Uniformity = new List<AllDropDownData>();
            if (lstDDL.Count > 0)
                lstDDL_Uniformity = lstDDL.AsEnumerable().Where(x => x.Batch_Select == StaticCommonVariable.BatchType_Uniformity).ToList();
            cmbUniformityBatch.DataSource = lstDDL_Uniformity;
            cmbUniformityBatch.DisplayMember = "Batch_Id";
            cmbUniformityBatch.ValueMember = "ID";
            cmbUniformityBatch.SelectedIndex = 0;
        }

        private void btnVRProcess_Click(object sender, System.EventArgs e)
        {
            Form parent = (Form)this.Parent;
            parent.Hide();
            ProcessReport processReport = new ProcessReport();
            processReport.Closed += (s, args) => parent.Close();
            processReport.Show();

        }

        private void btnUploadImagesBefore_Click(object sender, System.EventArgs e)
        {
            UploadFile uploadFile = new UploadFile();
            uploadFile.ShowDialog();
        }
    }
}
