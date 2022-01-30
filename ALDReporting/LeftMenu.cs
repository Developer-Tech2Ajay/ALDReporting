using ALD_DAL;
using ALD_Entities;
using ALD_Entities.E_AlarmReport;
using ALD_Entities.ProcessReport;
using ALDReporting.AlarmReport;
using ALDReporting.CustomClass;
using ALDReporting.LoadTcReport;
using ALDReporting.Reports;
using ALDReporting.UniformityReport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ALD_Entities.Util;

namespace ALDReporting
{
    public partial class LeftMenu : UserControl
    {
        private Report_Process _instancePr = null;
        private UFReport _instanceUr = null;
        private LTReport _instanceLtr = null;
        private Report_Alarm _instanceAr = null;
        private ReportAudit _instanceAuditR = null;
        //public string BatchId { get; set; }


        public LeftMenu()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(0, 180, 249);
            Color temp = Color.FromArgb(0xFF00FF);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            FullAllIdWithOutParameter();
            FullAllIdWithParameter();
            AesOperation.CheckUser("LeftMenu");

        }
        private void CloseAllForms()
        {

        }
        private void ShowMessage()
        {
            MessageBox.Show("Page is already opened in backgroud.");
        }
        private void SetDateFormate()
        {
            dtPStartDate.Format = DateTimePickerFormat.Custom;
            dtPStartDate.CustomFormat = "yyyy/MM/dd";

            dtPEndDate.Format = DateTimePickerFormat.Custom;
            dtPEndDate.CustomFormat = "yyyy/MM/dd";

            dtStartTime.Format = DateTimePickerFormat.Time;
            dtStartTime.ShowUpDown = true;
            dtEndTime.Format = DateTimePickerFormat.Time;
            dtEndTime.ShowUpDown = true;


        }
        private void FullAllIdWithParameter()
        {
            SetDateFormate();

        }

        private void FullAllIdWithOutParameter()
        {
            SetDateFormate();
            FillAllData();
        }

        private void FillAllData()
        {
            //Call Procedure
            DropDownForBatchId dalBatchid;
            dalBatchid = new DropDownForBatchId();
            List<AllDropDownData> lstDdl = dalBatchid.GetAllDropDownValues();


            //Fill Process Drop Down
            var lstDdlProcess = new List<AllDropDownData>();
            if (lstDdl.Count > 0)
                lstDdlProcess = lstDdl.AsEnumerable().Where(x => x.Batch_Select == Constants.BatchTypeProcess || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();

            cmbProcessBatch.DataSource = lstDdlProcess;
            cmbProcessBatch.DisplayMember = "Batch_Id";
            cmbProcessBatch.ValueMember = "ID";

            //Fill Uniformity
            var lstDdlUniformity = new List<AllDropDownData>();
            if (lstDdl.Count > 0)
                lstDdlUniformity = lstDdl.AsEnumerable().Where(x => x.Batch_Select == Constants.BatchTypeUniformity || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();
            cmbUniformityBatch.DataSource = lstDdlUniformity;
            cmbUniformityBatch.DisplayMember = "Batch_Id";
            cmbUniformityBatch.ValueMember = "ID";

            //Fill Uniformity
            var lstDdlLoadTc = new List<AllDropDownData>();
            if (lstDdl.Count > 0)
                lstDdlLoadTc = lstDdl.AsEnumerable().Where(x => x.Batch_Select ==Constants.BatchTypeLoadTc || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();
            cmbLoadTCBatch.DataSource = lstDdlLoadTc;
            cmbLoadTCBatch.DisplayMember = "Batch_Id";
            cmbLoadTCBatch.ValueMember = "ID";
        }


        private void OpenReportWindow(string strReport, string strBatchId)
        {

            switch (strReport)
            {
                case StaticValues.ReportType_Process:
                    {
                        _instancePr = new Report_Process(strBatchId);
                        _instancePr.Show();
                        break;
                    }
                case StaticValues.ReportType_Uniformity:
                    {
                        _instanceUr = new UFReport(strBatchId);
                        _instanceUr.Show();
                        break;
                    }
                case StaticValues.ReportType_LoadTC:
                    {
                        _instanceLtr = new LTReport(strBatchId);
                        _instanceLtr.Show();
                        break;
                    }
            }


        }

        private SystemMessage CheckBatchBeforeOpen(string reportType)
        {
            SystemMessage _sMsg = new SystemMessage();
            try
            {
                switch (reportType)
                {
                    case StaticValues.ReportType_Process:
                        {
                            if (cmbProcessBatch.SelectedIndex == 0)
                            {
                                _sMsg.StatusCode = 1;
                                _sMsg.StatusMsg = "Please select batch to see report !!";
                            }
                            else
                            {
                                _sMsg = CheckProductImages(cmbProcessBatch.Text);
                            }
                            break;
                        }
                    case StaticValues.ReportType_Uniformity:
                        {
                            if (cmbUniformityBatch.SelectedIndex == 0)
                            {
                                _sMsg.StatusCode = 1;
                                _sMsg.StatusMsg = "Please select batch to see report !!";
                            }
                            else
                            {
                                _sMsg = CheckProductImages(cmbUniformityBatch.Text);
                            }
                            break;
                        }
                    case StaticValues.ReportType_LoadTC:
                        {
                            if (cmbLoadTCBatch.SelectedIndex == 0)
                            {
                                _sMsg.StatusCode = 1;
                                _sMsg.StatusMsg = "Please select batch to see report !!";
                            }
                            else
                            {
                                _sMsg = CheckProductImages(cmbLoadTCBatch.Text);
                            }
                            break;
                        }

                }

            }
            catch (Exception)
            {

                throw;
            }
            return _sMsg;
        }

        private SystemMessage CheckProductImages(string BatchId)
        {
            SystemMessage sMsg = new SystemMessage();
            try
            {
                DalProductImages dAlProductImages = new DalProductImages();
                if (dAlProductImages == null) throw new ArgumentNullException(nameof(dAlProductImages));
                var images = dAlProductImages.GetProductImages(new ProcessReport_RQ() { BatchId = BatchId });
                sMsg.StatusCode = 2;
                if (images != null && string.IsNullOrWhiteSpace(images.ImageAfter) && string.IsNullOrWhiteSpace(images.ImageBefore))
                     sMsg.StatusMsg = "Product Images are not uploaded! Want to skip ??";
                else if (images != null && string.IsNullOrWhiteSpace(images.ImageBefore))
                     sMsg.StatusMsg = "Product Before Image is not uploaded! Want to skip ??";
                else if (images != null && string.IsNullOrWhiteSpace(images.ImageAfter))
                     sMsg.StatusMsg = "Product After Image is not uploaded! Want to skip ??";
                else if (images == null)
                    sMsg.StatusMsg = "Product Image are not uploaded! Want to skip ??";
                else
                {
                    sMsg.StatusCode = 0; sMsg.StatusMsg = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return sMsg;
        }

        private void btnUploadImagesBefore_Click(object sender, System.EventArgs e)
        {
            SystemMessage sm = new SystemMessage();
            sm = CheckSelectedBatch(StaticValues.Image_Before);
            if (sm.StatusCode == 0)
            {
                UploadFile uploadFile = new UploadFile(StaticValues.Image_Before);
                ReportClass.ImageType = StaticValues.ImageBefore; //Set Image type
                uploadFile.ShowDialog();
            }
            else
            {
                CustomMessageBox.Custom(sm.StatusMsg);
            }
        }

        private SystemMessage CheckSelectedBatch(string from)
        {
            SystemMessage systemMessage = new SystemMessage();
            ReportClass.BatchID = string.Empty;
            if (cmbProcessBatch.SelectedIndex > 0)
                ReportClass.BatchID = cmbProcessBatch.Text;
            else if (cmbUniformityBatch.SelectedIndex > 0)
                ReportClass.BatchID = cmbUniformityBatch.Text;
            else if (cmbLoadTCBatch.SelectedIndex > 0)
                ReportClass.BatchID = cmbLoadTCBatch.Text;

            if (ReportClass.BatchID == string.Empty)
            {
                systemMessage.StatusCode = 1;
                systemMessage.StatusMsg = "Please select batch " + from + " upload images.";
            }

            return systemMessage;
        }

        private void btnUploadImagesAfter_Click(object sender, System.EventArgs e)
        {
            SystemMessage sm = new SystemMessage();
            sm = CheckSelectedBatch(StaticValues.Image_After);
            if (sm.StatusCode == 0)
            {
                ReportClass.ImageType = StaticValues.ImageAfter; //Set Image type
                UploadFile uploadFile = new UploadFile(StaticValues.Image_After);
                uploadFile.ShowDialog();
            }
            else
            {
                CustomMessageBox.Custom(sm.StatusMsg);
            }
        }


        public void SetIndex(List<ComboBox> lstComboBoxes)
        {
            if (lstComboBoxes != null)
            {
                foreach (var comboBox in lstComboBoxes)
                {
                    if (comboBox == null) continue;
                    if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;
                }
            }

        }

        public void ResetBatchIDs(string RptType)
        {
            var lstCKBox = new List<ComboBox>();
            lstCKBox.Add(cmbProcessBatch);
            lstCKBox.Add(cmbUniformityBatch);
            lstCKBox.Add(cmbLoadTCBatch);

            switch (RptType)
            {
                case StaticValues.ReportType_Process:
                    {
                        lstCKBox.Remove(cmbProcessBatch);
                        SetIndex(lstCKBox);
                        break;
                    }
                case StaticValues.ReportType_Uniformity:
                    {
                        lstCKBox.Remove(cmbUniformityBatch);
                        SetIndex(lstCKBox);
                        break;
                    }
                case StaticValues.ReportType_LoadTC:
                    {
                        lstCKBox.Remove(cmbLoadTCBatch);
                        SetIndex(lstCKBox);
                        break;
                    }
                default:
                    break;
            }
        }


        #region -====******* View Report button Click Events ***************======
        private void btnVRProcess_Click(object sender, System.EventArgs e)
        {
            AesOperation.CheckUser("LeftMenu");
            SystemMessage _sMsg = new SystemMessage();
            _sMsg = CheckBatchBeforeOpen(StaticValues.ReportType_Process);
            if (_sMsg.StatusCode == 0)
            {
                OpenReportWindow(StaticValues.ReportType_Process, cmbProcessBatch.Text);
            }
            else if (_sMsg.StatusCode == 2) //Warning and confirmation box
            {
                var result = CustomMessageBox.ShowConfimationBox(_sMsg.StatusMsg);
                if (result == DialogResult.Yes)
                    OpenReportWindow(StaticValues.ReportType_Process, cmbProcessBatch.Text);

            }
            else
            {
                CustomMessageBox.Custom(_sMsg.StatusMsg);
            }

        }
        private void btnUniFormity_Click(object sender, EventArgs e)
        {
            SystemMessage sMsg = new SystemMessage();
            sMsg = CheckBatchBeforeOpen(StaticValues.ReportType_Uniformity);
            if (sMsg.StatusCode == 0)
                OpenReportWindow(StaticValues.ReportType_Uniformity, cmbUniformityBatch.Text);
            else if (sMsg.StatusCode == 2) //Warning and confirmation box
            {
                var result = CustomMessageBox.ShowConfimationBox(sMsg.StatusMsg);
                if (result == DialogResult.Yes)
                    OpenReportWindow(StaticValues.ReportType_Uniformity, cmbUniformityBatch.Text);

            }
            else
            {
                CustomMessageBox.Custom(sMsg.StatusMsg);
            }
        }
        private void btnLoadTC_Click(object sender, EventArgs e)
        {
            SystemMessage sMsg = new SystemMessage();
            sMsg = CheckBatchBeforeOpen(StaticValues.ReportType_LoadTC);
            if (sMsg.StatusCode == 0)
            {
                OpenReportWindow(StaticValues.ReportType_LoadTC, cmbLoadTCBatch.Text);
            }
            else if (sMsg.StatusCode == 2) //Warning and confirmation box
            {
                var result = CustomMessageBox.ShowConfimationBox(sMsg.StatusMsg);
                if (result == DialogResult.Yes)
                    OpenReportWindow(StaticValues.ReportType_LoadTC, cmbLoadTCBatch.Text);

            }
            else
            {
                CustomMessageBox.Custom(sMsg.StatusMsg);
            }

        }
        private void btnTimeBaseReport_Click(object sender, EventArgs e)
        {
            DateTime dtStartDateTime = dtPStartDate.Value.Date + dtStartTime.Value.TimeOfDay;
            DateTime dtEndDateTime = dtPEndDate.Value.Date + dtEndTime.Value.TimeOfDay;

            var req = new Report_RQ() { StartDateTime = dtStartDateTime, EndDateTime = dtEndDateTime };

            if (rdbtnAlarmRpt.Checked)
            {
                _instanceAr = new Report_Alarm(req);
                _instanceAr.Show();
            }
            else if (rdbtnAuditRpt.Checked)
            {
                _instanceAuditR = new ReportAudit(req);
                _instanceAuditR.Show();
            }
            else if (rdbtnProcRpt.Checked)
            {
                _instancePr = new Report_Process(req);
                _instancePr.Show();
            }
            else
            {
                CustomMessageBox.Custom("Please select any one report to view.");
                return;
            }


        }
        #endregion

        private void cmbProcessBatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResetBatchIDs(StaticValues.ReportType_Process);
        }

        private void cmbUniformityBatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResetBatchIDs(StaticValues.ReportType_Uniformity);

        }

        private void cmbLoadTCBatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ResetBatchIDs(StaticValues.ReportType_LoadTC);
        }
    }
}
