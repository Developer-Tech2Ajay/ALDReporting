using ALDReporting.CustomClass;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class ucProductImg : UserControl
    {

        public string ImgBefore { get; set; }
        public string ImgAfter { get; set; }
        public string FileName { get; set; }

        public ucProductImg(string fileName)
        {
            InitializeComponent();
            btnUniformityImagesPrint.Visible = false;
            SetProperties(fileName);
        }
        public ucProductImg(string _ImgBefore, string _ImgAfter, string _fileName = "")
        {
            InitializeComponent();
            ImgBefore = _ImgBefore;
            ImgAfter = _ImgAfter;
            FileName = _fileName; 
            SetProperties(_fileName);
        }
        private void SetProperties(string fileName)
        {
            if (string.IsNullOrEmpty(FileName))
                FileName = fileName;
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

            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            var img = sc.CaptureScreen();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string folderName = FileName.Replace(' ', '-').Replace(':', '-'); ;
            string fullPath = desktopPath + "\\ALDReporting\\" + folderName;
            if (!File.Exists(fullPath))
                System.IO.Directory.CreateDirectory(fullPath);

            // capture this window, and save it
            sc.CaptureWindowToFile(this.Handle, Path.Combine(fullPath , "ProductImages.jpeg"), ImageFormat.Jpeg);



            //System.Drawing.Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            ////Creating a new Bitmap object
            //captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
            ////Graphics g = this.CreateGraphics();
            //////bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            ////bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width + 10 , Screen.PrimaryScreen.Bounds.Height+ 10, g);

            //Graphics mg = Graphics.FromImage(captureBitmap);
            //mg.CopyFromScreen(captureRectangle.Left,captureRectangle.Top, 0, 0, captureRectangle.Size);
            //printPreviewDialog1.ShowDialog();
        }
        Bitmap captureBitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(captureBitmap, 0, 0);
        }
    }
}
