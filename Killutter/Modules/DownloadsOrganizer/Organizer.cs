using Killutter.Shared;
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
                Logger.Log(LogLevel.Error, "Move failed for: " + fullPath);
            }
            else
            {
                Logger.Log(LogLevel.Info, $"Moved {fullPath} -> {dest}");
            }
        }

        public static void Sweep(string downloads)
        {
            Logger.Log(LogLevel.Info, "Sweep started");

            string[] files = Directory.GetFiles(downloads);

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                OrganizeFile(file, name, downloads);
            }

            Logger.Log(LogLevel.Info, "Sweep finished");
        }
    }
}