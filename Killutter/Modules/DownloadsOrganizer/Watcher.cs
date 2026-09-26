using Killutter.Modules.Shared;
using Killutter.Shared;
using System.Drawing.Text;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal class Watcher
    {
        private Config config;
        private FileSystemWatcher watcher;

        public Watcher(Config config)
        {
            this.config = config;
            watcher = new FileSystemWatcher(config.GetWatchFolder());

            watcher.NotifyFilter = NotifyFilters.FileName;

            watcher.Created += OnCreated;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = false;
        }

        public void OnCreated(object sender, FileSystemEventArgs e)
        {
            Organizer.OrganizeFile(e.FullPath, e.Name, config);
        }
        
        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            Organizer.OrganizeFile(e.FullPath, e.Name, config);
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
            Logger.Log(LogLevel.Info, "Watcher started");
        }




    }
}
