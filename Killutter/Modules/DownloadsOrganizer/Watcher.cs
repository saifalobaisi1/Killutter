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
            string value = $"Created: {e.FullPath}";
            MessageBox.Show(value);
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;

        }

        


    }
}
