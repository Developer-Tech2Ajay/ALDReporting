using System.Windows.Forms;

namespace ALDReporting.CustomClass
{
    public static class CustomMessageBox
    {
        public static string HeaderText = "ALD Reporting";
        public static void Custom(string MsgBody)
        {
            MessageBox.Show(MsgBody, HeaderText);
        }
        public static DialogResult ShowConfimationBox(string MsgBody)
        {
            return MessageBox.Show(MsgBody, HeaderText, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
