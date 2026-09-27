using Killutter.Modules.DownloadsOrganizer;
using Killutter.Shared;
using Killutter.UI;

namespace Killutter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool isNewInstance;
            using (Mutex mutex = new Mutex(true, "Killutter_SingleInstance_Mutex", out isNewInstance))
            {
                if (!isNewInstance)
                {
                    MessageBox.Show("Killutter is already running.");
                    return;
                }

                ApplicationConfiguration.Initialize();

                Config config = Config.Load();
                Logger.SetLogPath(config.GetLogPath());

                Watcher watcher = new Watcher(config);
                Organizer.Sweep(config);
                watcher.Start();

                TrayIcon tray = new TrayIcon(config);

                Application.Run();
            }
        }
    }
}