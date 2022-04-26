using System;
using System.Windows.Forms;

namespace ZulrahLearner
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int num = 0;

            if (num == 0)
                Application.Run(new Zulrah());
            else
                Application.Run(new ZulrahPhaseGenerator());
        }
    }
}
