using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp_RegularDataSourceKPI
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());     
        }
    }
}
