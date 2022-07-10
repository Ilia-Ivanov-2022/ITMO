using System;
using System.Windows.Forms;

namespace ITMO.CSAppDeb.Lab1.Exercise5._2.WindowsForms
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
            Application.Run(new Form2());    // starts with a Form2
        }
    }
}
