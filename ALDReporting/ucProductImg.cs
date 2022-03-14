using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class ucProductImg : UserControl
    {

        public string ImgBefore { get; set; }
        public string ImgAfter { get; set; }
        public string FileName { get; set; }

        public ucProductImg()
        {
            InitializeComponent();
            btnUniformityImagesPrint.Visible = false;
            SetProperties();
        }
        public ucProductImg(string _ImgBefore, string _ImgAfter, string _fileName = "")
        {
            InitializeComponent();
            ImgBefore = _ImgBefore;
            ImgAfter = _ImgAfter;
            FileName = _fileName + ".pdf";
            SetProperties();
        }
        private void SetProperties()
        {
            var path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            var fullPath = Path.Combine(path + "\\images\\NotImageUploaded.png");
            if (ImgBefore == null)
                picBeforePStart.Image = System.Drawing.Image.FromFile(fullPath);
            else
                picBeforePStart.Image = System.Drawing.Image.FromFile(ImgBefore);
            if (ImgAfter == null)
                picAfterPStart.Image = System.Drawing.Image.FromFile(fullPath);
            else
                picAfterPStart.Image = System.Drawing.Image.FromFile(ImgAfter);

            ScaleImage();

        }
        private void ScaleImage()
        {
            if (picBeforePStart.Image == null)
                return;

            if (picBeforePStart.Image.Width > picBeforePStart.Width || picBeforePStart.Image.Height > picBeforePStart.Height)
                picBeforePStart.SizeMode = PictureBoxSizeMode.Zoom;
            else
                picBeforePStart.SizeMode = PictureBoxSizeMode.Normal;

            if (picAfterPStart.Image == null)
                return;

            if (picAfterPStart.Image.Width > picAfterPStart.Width || picAfterPStart.Image.Height > picAfterPStart.Height)
                picAfterPStart.SizeMode = PictureBoxSizeMode.Zoom;
            else
                picAfterPStart.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnUniformityImagesPrint_Click(object sender, System.EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
