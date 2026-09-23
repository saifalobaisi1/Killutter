using Killutter.Shared;
using System.Drawing.Text;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal class Watcher
    {
        private string root;
        private string downloads;
        private FileSystemWatcher watcher;

        public Watcher()
        {
            root = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downloads = Path.Combine(root, "Downloads");
            watcher = new FileSystemWatcher(downloads);

            watcher.Created += OnCreated;

            watcher.EnableRaisingEvents = false;
        }

        public void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (Directory.Exists(e.FullPath))
                return;

            Organizer.OrganizeFile(e.FullPath, e.Name, downloads);
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
            Logger.Log(LogLevel.Info, "Watcher started");
        }




    }
}
