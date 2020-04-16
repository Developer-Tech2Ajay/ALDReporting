using System.Windows.Forms;

namespace ALDReporting.Reports
{
    public partial class ProcessReport : Form
    {
        //private ProcessReport _instanceProcessReport = null;
        public ProcessReport()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            lblWelcomeText.Text = "Welcome to the" + "\n" + "AMG Engineering ALD" + "\n" + "System Report";
        }
    }
}
