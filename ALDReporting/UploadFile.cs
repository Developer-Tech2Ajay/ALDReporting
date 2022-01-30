using ALD_DAL;
using ALD_Entities;
using ALDReporting.CustomClass;
using System;
using System.IO;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class UploadFile : Form
    {
        public UploadFile()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        public UploadFile(string strPageHeader)
        {
            InitializeComponent();
            lblPageHeader.Text = "Upload " + strPageHeader + " Image";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        // ImageList index value for the hover image.

        private void btnClose_MouseHover(object sender, EventArgs e) => btnClose.ImageIndex = 1;

        // ImageList index value for the normal image.
        private void btnClose_MouseLeave(object sender, EventArgs e) => btnClose.ImageIndex = 0;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstFileUpload_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length > 0)
            { AddFileInList(files[0]); }
        }

        private void AddFileInList(string file)
        {
            HideShowControls(true);
            lstFileUpload.Items.Add(file);
        }

        private void HideShowControls(bool v)
        {
            btnBrowseFile.Visible = !v;
            lbl1FileUpload.Visible = !v;
            lbl2FileUpload.Visible = !v;
        }

        private void lstFileUpload_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SystemMessage sm = new SystemMessage();
            sm = ValidateAndUploadFile();
        }

        private SystemMessage ValidateAndUploadFile()
        {
            SystemMessage sm = new SystemMessage();
            try
            {
                if (lstFileUpload.Items.Count == 0)
                {
                    CustomMessageBox.Custom("Please select one file to upload.");
                }
                else if (lstFileUpload.Items.Count > 1)
                {
                    sm.StatusCode = 1;
                    sm.StatusMsg = "Can only upload single file.";
                }
                else
                {
                    //Call upload functionality 
                    sm = UploadFileAndInsertRecordInDB();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return sm;

        }

        private SystemMessage UploadFileAndInsertRecordInDB()
        {
            SystemMessage sm = new SystemMessage();
            DalProductImages _dal = new DalProductImages();
            try
            {
                if (CheckEligiabilityForUpload().StatusCode == 0)
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string filename = Convert.ToString(lstFileUpload.Items[0]).Substring(Convert.ToString(lstFileUpload.Items[0]).LastIndexOf("\\") + 1);
                    string FullPath = path + "\\ProductsImages\\" + filename;

                    if (!File.Exists(FullPath))
                    {
                        File.Copy(Convert.ToString(lstFileUpload.Items[0]), FullPath);
                    }
                    sm = _dal.D_CheckEligiabilityForUpload(new ImageUploadForBatch() { BatchID = ReportClass.BatchID, ImageFilePath = FullPath, ImageType = ReportClass.ImageType });
                    // MessageBox.Show(sm.StatusMsg);

                    if (sm.StatusCode == 1)
                    {

                        var confirmResult = CustomMessageBox.ShowConfimationBox(sm.StatusMsg + ". Are you sure to overwrite??"); // MessageBox.Show(sm.StatusMsg + " Are you sure to overwrite??", "Confirm Overwrite!!", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            sm = _dal.D_InsUpdImageForBatchID(new ImageUploadForBatch() { BatchID = ReportClass.BatchID, ImageFilePath = FullPath, ImageType = ReportClass.ImageType, IsOverWrite = true });
                        }
                        else
                        {
                            // If 'No', do something here.
                        }
                    }
                    else if (sm.StatusCode == 0)
                    {
                        sm = _dal.D_InsUpdImageForBatchID(new ImageUploadForBatch() { BatchID = ReportClass.BatchID, ImageFilePath = FullPath, ImageType = ReportClass.ImageType, IsOverWrite = false });
                    }

                    else { }

                    if (sm.StatusCode == 0)
                    {
                        MessageBox.Show(sm.StatusMsg);
                        this.Close();
                    }

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
            return sm;
        }
        /// <summary>
        /// Check file exist for selected batch id 
        /// </summary>
        /// <returns></returns>
        private SystemMessage CheckEligiabilityForUpload()
        {
            SystemMessage _sysMsg = new SystemMessage();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return _sysMsg;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Only. |*.jpeg; *.jpg; *.png; *.gif;";

            DialogResult dr = openFileDialog.ShowDialog();
            AddFileInList(openFileDialog.FileName);
        }
    }

}
