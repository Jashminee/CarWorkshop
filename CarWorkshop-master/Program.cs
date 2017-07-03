using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    static class Program
    {
        public static MainWindow mainWindow;
        public static Form loginWindow;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
			// Application.Run(new Laboratorium());
		}

        public static void CloseApp(Object sender, FormClosingEventArgs e)
        {
            mainWindow?.Dispose();
            loginWindow?.Dispose();
        }
    }
}
