using System.Windows.Forms;

namespace ALDReporting.Reports
{
    public partial class Index : Form
    {
        //private ProcessReport _instanceProcessReport = null;
        public Index()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            lblWelcomeText.Text = "Welcome to the" + "\n" + "AMG Engineering ALD" + "\n" + "System Report";
        }

        private void leftMenu1_Load(object sender, System.EventArgs e)
        {

        }

        //private void CloseAllForms()
        //{
        //    if (this.ActiveMdiChild != null)
        //    {
        //        this.ActiveMdiChild.Close();
        //    }
        //}
        //private void ShowMessage()
        //{
        //    MessageBox.Show("Page is already opened in backgroud.");
        //}
        //private void instanceProcessReportHasBeenClosed(object sender, FormClosedEventArgs e)
        //{
        //    _instanceProcessReport = null;
        //}

        //private void btnVRProcess_Click(object sender, EventArgs e)
        //{
        //    if (_instanceProcessReport == null)
        //    {
        //        CloseAllForms();
        //        _instanceProcessReport = new ProcessReport();
        //        _instanceProcessReport.MdiParent = this;
        //        _instanceProcessReport.FormClosed += instanceProcessReportHasBeenClosed;
        //    }
        //    else
        //    {
        //        ShowMessage();
        //    }
        //    _instanceProcessReport.Show();
        //}
    }
}
