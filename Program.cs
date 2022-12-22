using System;
using System.Windows.Forms;

namespace OOAD_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fChangePassword form1 = new fChangePassword();
            //form1.Size = new System.Drawing.Size(1600, 900);
            Application.Run(form1);
        }
    }
}
