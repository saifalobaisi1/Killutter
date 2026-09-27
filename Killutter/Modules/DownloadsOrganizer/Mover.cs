using Killutter.Shared;

namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class Mover
    {
        public static bool Move(string path, string dest)
        {
            try
            {
                string folder = Path.GetDirectoryName(dest);
                Directory.CreateDirectory(folder);

                string finalDest = dest;
                int attempt = 0;
                while (File.Exists(finalDest))
                {
                    attempt++;
                    finalDest = BuildSuffixedPath(dest, attempt);
                }

                File.Move(path, finalDest);
                Logger.Log(LogLevel.Info, $"Moved {path} -> {finalDest}");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                return false;
            }
        }

        private static string BuildSuffixedPath(string dest, int attempt)
        {
            string folder = Path.GetDirectoryName(dest);
            string name = Path.GetFileNameWithoutExtension(dest);
            string ext = Path.GetExtension(dest);

            string newName = $"{name} ({attempt}){ext}";
            return Path.Combine(folder, newName);
        }
    }
}
