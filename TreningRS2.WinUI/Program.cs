using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreningRS2.WinUI.ApplicationUser;

namespace TreningRS2.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //APIService.Username = "imeime";
            //APIService.Password = "imeime";
           // Application.Run(new frmIndex());

        }
    }
}
