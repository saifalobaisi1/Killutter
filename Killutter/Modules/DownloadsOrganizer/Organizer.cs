using System.IO;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class Organizer
    {
        public static void OrganizeFile(string fullPath, string name, string downloads)
        {
            string type = Classifier.Classify(fullPath);

            if (type == "Unsorted")
                return;

            string dest = Path.Combine(downloads, type);
            dest = Path.Combine(dest, name);

            bool success = Mover.Move(fullPath, dest);
            if (!success)
            {
                MessageBox.Show("Move failed for: " + fullPath);
            }
        }

        public static void Sweep(string downloads)
        {
            string[] files = Directory.GetFiles(downloads);

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                OrganizeFile(file, name, downloads);
            }
        }
    }
}