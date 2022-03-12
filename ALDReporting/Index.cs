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


    }
}
