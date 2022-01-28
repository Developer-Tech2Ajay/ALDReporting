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
        private Report_Process _instancePR = null;
        private UFReport _instanceUR = null;
        private LTReport _instanceLTR = null;
        private Report_Alarm _instanceAR = null;
        private Report_Audit _instanceAuditR = null;
        //public string BatchId { get; set; }


        public LeftMenu()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(0, 180, 249);
            Color temp = Color.FromArgb(0xFF00FF);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            FullAllIDWithOutParameter();
            FullAllIDWithParameter();
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
                lstDDL_Process = lstDDL.AsEnumerable().Where(x => x.Batch_Select == StaticCommonVariable.BatchType_Process || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();

            cmbProcessBatch.DataSource = lstDDL_Process;
            cmbProcessBatch.DisplayMember = "Batch_Id";
            cmbProcessBatch.ValueMember = "ID";

            //Fill Uniformity
            List<AllDropDownData> lstDDL_Uniformity = new List<AllDropDownData>();
            if (lstDDL.Count > 0)
                lstDDL_Uniformity = lstDDL.AsEnumerable().Where(x => x.Batch_Select == StaticCommonVariable.BatchType_Uniformity || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();
            cmbUniformityBatch.DataSource = lstDDL_Uniformity;
            cmbUniformityBatch.DisplayMember = "Batch_Id";
            cmbUniformityBatch.ValueMember = "ID";

            //Fill Uniformity
            List<AllDropDownData> lstDDL_LoadTC = new List<AllDropDownData>();
            if (lstDDL.Count > 0)
                lstDDL_LoadTC = lstDDL.AsEnumerable().Where(x => x.Batch_Select == StaticCommonVariable.BatchType_LoadTC || string.IsNullOrWhiteSpace(x.Batch_Select)).ToList();
            cmbLoadTCBatch.DataSource = lstDDL_LoadTC;
            cmbLoadTCBatch.DisplayMember = "Batch_Id";
            cmbLoadTCBatch.ValueMember = "ID";
        }


        private void OpenReportWindow(string strReport, string strBatchID)
        {

            switch (strReport)
            {
                case StaticValues.ReportType_Process:
                    {
                        _instancePR = new Report_Process(strBatchID);
                        _instancePR.Show();
                        break;
                    }
                case StaticValues.ReportType_Uniformity:
                    {
                        _instanceUR = new UFReport(strBatchID);
                        _instanceUR.Show();
                        break;
                    }
                case StaticValues.ReportType_LoadTC:
                    {
                        _instanceLTR = new LTReport(strBatchID);
                        _instanceLTR.Show();
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

        private SystemMessage CheckProductImages(string batchid)
        {
            SystemMessage _sMsg = new SystemMessage();
            try
            {
                DAL_ProductImages dAL_ProductImages = new DAL_ProductImages();
                var imgs = dAL_ProductImages.GetProductImages(new ProcessReport_RQ() { BatchId = batchid });
                if (imgs != null && string.IsNullOrWhiteSpace(imgs.ImageAfter) && string.IsNullOrWhiteSpace(imgs.ImageBefore))
                {
                    _sMsg.StatusCode = 2; _sMsg.StatusMsg = "Product Images are not uploaded! Want to skip ??";
                }
                else if (imgs != null && string.IsNullOrWhiteSpace(imgs.ImageBefore))
                {
                    _sMsg.StatusCode = 2; _sMsg.StatusMsg = "Product Before Image is not uploaded! Want to skip ??";
                }
                else if (imgs != null && string.IsNullOrWhiteSpace(imgs.ImageAfter))
                {
                    _sMsg.StatusCode = 2; _sMsg.StatusMsg = "Product After Image is not uploaded! Want to skip ??";
                }
                else if (imgs == null)
                {
                    _sMsg.StatusCode = 2; _sMsg.StatusMsg = "Product Image are not uploaded! Want to skip ??";
                }
                else
                {
                    _sMsg.StatusCode = 0; _sMsg.StatusMsg = "";

                }
            }
            catch (Exception)
            {

                throw;
            }
            return _sMsg;
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
            SystemMessage _sMsg = new SystemMessage();
            _sMsg = CheckBatchBeforeOpen(StaticValues.ReportType_Uniformity);
            if (_sMsg.StatusCode == 0)
            {
                OpenReportWindow(StaticValues.ReportType_Uniformity, cmbUniformityBatch.Text);
            }
            else if (_sMsg.StatusCode == 2) //Warning and confirmation box
            {
                var result = CustomMessageBox.ShowConfimationBox(_sMsg.StatusMsg);
                if (result == DialogResult.Yes)
                    OpenReportWindow(StaticValues.ReportType_Uniformity, cmbUniformityBatch.Text);

            }
            else
            {
                CustomMessageBox.Custom(_sMsg.StatusMsg);
            }
        }
        private void btnLoadTC_Click(object sender, EventArgs e)
        {
            SystemMessage _sMsg = new SystemMessage();
            _sMsg = CheckBatchBeforeOpen(StaticValues.ReportType_LoadTC);
            if (_sMsg.StatusCode == 0)
            {
                OpenReportWindow(StaticValues.ReportType_LoadTC, cmbLoadTCBatch.Text);
            }
            else if (_sMsg.StatusCode == 2) //Warning and confirmation box
            {
                var result = CustomMessageBox.ShowConfimationBox(_sMsg.StatusMsg);
                if (result == DialogResult.Yes)
                    OpenReportWindow(StaticValues.ReportType_LoadTC, cmbLoadTCBatch.Text);

            }
            else
            {
                CustomMessageBox.Custom(_sMsg.StatusMsg);
            }

        }
        private void btnTimeBaseReport_Click(object sender, EventArgs e)
        {
            DateTime dtStartDateTime = dtPStartDate.Value.Date + dtStartTime.Value.TimeOfDay;
            DateTime dtEndDateTime = dtPEndDate.Value.Date + dtEndTime.Value.TimeOfDay;

            var req = new Report_RQ() { StartDateTime = dtStartDateTime, EndDateTime = dtEndDateTime };

            if (rdbtnAlarmRpt.Checked)
            {
                _instanceAR = new Report_Alarm(req);
                _instanceAR.Show();
            }
            else if (rdbtnAuditRpt.Checked)
            {
                _instanceAuditR = new Report_Audit(req);
                _instanceAuditR.Show();
            }
            else if (rdbtnProcRpt.Checked)
            {
                _instancePR = new Report_Process(req);
                _instancePR.Show();
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
