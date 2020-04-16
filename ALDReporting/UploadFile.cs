using System;
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
        // ImageList index value for the hover image.

        private void btnClose_MouseHover(object sender, EventArgs e) => btnClose.ImageIndex = 1;

        // ImageList index value for the normal image.
        private void btnClose_MouseLeave(object sender, EventArgs e) => btnClose.ImageIndex = 0;
        private void pnlFileUpload_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtFileUpload_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
