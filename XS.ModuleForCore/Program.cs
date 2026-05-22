using System.Threading;

namespace XS.ModuleForCore
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "XS.ModuleForCore");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Main());
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("只允许运行一个实例！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}