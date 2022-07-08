using ALDReporting.CustomClass;
using ALDReporting.Reports;
using System;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using Entities;
using ALD_DAL;
using Microsoft.Win32;

namespace ALDReporting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            lblSystemName.Text = System.Environment.MachineName;
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                this.lblVersion.Text = this.lblVersion.Text + " " + ad.CurrentVersion.ToString();
            }
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
            AesOperation.CheckUser("LeftMenu");
            //if (IsExpired())
            if (!DbAccess.GetInstallationDate(Constants.ConnStringReport))
                throw new Exception("Exception has occured. Please connect system administrator");
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
                if (DbAccess.GetAuth(txtboxUserName.Text.Trim(), txtPswd.Text.Trim(), Constants.GetAuth, Constants.ConnStringReport))
                    return true;
                else
                    sbMsg.AppendLine("Please entry a valid user name and password");
            }

            CustomMessageBox.Custom(sbMsg.ToString());
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Supports supports = new Supports();
            supports.Closed += (s, args) => this.Close();
            supports.Show();
        }

        public bool IsExpired()
        {
            RegistryKey ALDReports = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\ALDReports");
            if (ALDReports != null)
            {
                var dtInstallation = ALDReports.GetValue("InstallationDate");
                if (dtInstallation != null)
                {
                    DateTime dateTime = DateTime.Parse(dtInstallation.ToString());
                    var expDateTime = dateTime.AddDays(new Random().Next(380, 400));
                    if (expDateTime < DateTime.Now)
                        throw new Exception("Exception has occured. Please connect system administrator");
                }
                else
                    ALDReports.SetValue("InstallationDate", DateTime.Now);
            }
            return true;
        }

    }
}
