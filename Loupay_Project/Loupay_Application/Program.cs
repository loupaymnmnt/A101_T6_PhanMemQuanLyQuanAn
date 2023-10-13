using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loupay_Application.Forms.LoginForms;
using Loupay_Application.Forms.MainForms;

namespace Loupay_Application
{
    internal static class Program
    {
        public static MainForm mainForm;
        public static LoginForm loginForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}
