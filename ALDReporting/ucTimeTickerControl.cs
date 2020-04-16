using System;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class ucTimeTickerControl : UserControl
    {
        public ucTimeTickerControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimerTick.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
