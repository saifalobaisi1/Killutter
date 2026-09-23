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

            string Type = Classifier.Classify(e.FullPath);

            if (Type == "Unsorted")
                return;

            string dest = Path.Combine(downloads, Type);
            dest = Path.Combine(dest, e.Name);

            bool success = Mover.Move(e.FullPath, dest);
            if (!success)
            {
                MessageBox.Show("Move failed for: " + e.FullPath);
            }
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;

        }

        


    }
}
