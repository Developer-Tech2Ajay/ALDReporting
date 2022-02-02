using System;
using System.Threading;
using System.Windows.Forms;

namespace ALDReporting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;
            using (Mutex mutex = new Mutex(true, "MyRunningApp", out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Login());
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("Application instance is already running");
                }
            }
           
        }
    }
}
