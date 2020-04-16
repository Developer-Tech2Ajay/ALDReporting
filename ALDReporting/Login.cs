using ALDReporting.Reports;
using System;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;



        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (IsAuthenticated())
            {
                //Setting system Details from system file
                LoadSystemDetails();
                this.Hide();
                Index index = new Index();
                index.Closed += (s, args) => this.Close();
                index.Show();



            }
        }

        private void LoadSystemDetails()
        {
            try
            {
                SetSystemVariable.LoadSystemData();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool IsAuthenticated()
        {
            return true;
        }


    }
}
