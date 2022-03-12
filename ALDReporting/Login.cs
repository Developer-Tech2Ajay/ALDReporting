using ALDReporting.CustomClass;
using ALDReporting.Reports;
using System;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using Entities;
using ALD_DAL;

namespace ALDReporting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lblSystemNameValue.Text = System.Environment.MachineName; 
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
                //  SetSystemVariable.LoadSystemData();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool IsAuthenticated()
        {
            var sbMsg = new StringBuilder();
            if (String.IsNullOrWhiteSpace(Convert.ToString(txtboxUserName.Text)))
            {
                sbMsg.AppendLine("Please entry a user name");
            }
            //else if (Convert.ToString(txtboxUserName.Text) != Convert.ToString(ConfigurationManager.AppSettings["username"]))
            //{
            //    sbMsg.AppendLine("Please entry a valid username");
            //}
            AesOperation.CheckUser(txtboxUserName.Text);
            if (String.IsNullOrWhiteSpace(Convert.ToString(txtPswd.Text)))
            {
                sbMsg.AppendLine("Please entry a password");
            }
            //else if (Convert.ToString(txtPswd.Text) != Convert.ToString(ConfigurationManager.AppSettings["password"]))
            //{
            //    sbMsg.AppendLine("Please entry a valid password");
            //}

            if (sbMsg.Length == 0)
            {
                if (DbAccess.GetAuth(txtboxUserName.Text.Trim(), txtPswd.Text.Trim(), Constants.GetAuth,Constants.ConnStringReport))
                    return true;
                else
                    sbMsg.AppendLine("Please entry a valid user name and password");
            }

            CustomMessageBox.Custom(sbMsg.ToString());
            return false;
        }



    }
}
