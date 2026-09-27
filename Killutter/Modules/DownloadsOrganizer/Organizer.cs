using Killutter.Modules.Shared;
using Killutter.Shared;
using System.IO;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class Organizer
    {
        public static void OrganizeFile(string fullPath, string name, Config config)
        {
            string type = Classifier.Classify(fullPath);
            if (type == "Unsorted")
                return;

            string path = MatchGroup(type, config);
            if (path == null)
                return;

            path = Path.Combine(path, name);

             Mover.Move(fullPath, path);
            
        }

        public static void Sweep(Config config)
        {
            Logger.Log(LogLevel.Info, "Sweep started");

            string[] files = Directory.GetFiles(config.GetWatchFolder());

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                OrganizeFile(file, name, config);
            }

            Logger.Log(LogLevel.Info, "Sweep finished");
        }

        public static string MatchGroup(string type, Config config)
        {
            foreach (Group group in config.GetGroups())
            {
                if (group.RecognizedTypes.Contains(type))
                    return group.DestPath;
            }

            return null;
        }

        public static bool WaitUntilReady(string path, int maxWaitSeconds = 300, int maxDelayCapSeconds = 30)
        {
            int elapsed = 0;
            int delay = 1;

            while (elapsed < maxWaitSeconds)
            {
                try
                {
                    using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        return true;
                    }
                }
                catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
                {
                    Thread.Sleep(delay * 1000);
                    elapsed += delay;
                    delay = Math.Min(delay * 2, maxDelayCapSeconds);
                }
            }

            return false;
        }
    }
}