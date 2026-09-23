namespace Killutter.Modules.DownloadsOrganizer
{
    internal static class Mover
    {
        public static bool Move(string path, string dest)
        {
            const int maxWaitSeconds = 300;
            const int maxDelayCapSeconds = 30;
            int Elapsed = 0;
            int Delay = 1;

            int attempt = 0;
            string finalDest = dest;

            try
            {
                string Folder = Path.GetDirectoryName(dest);
                Directory.CreateDirectory(Folder);

                while (File.Exists(finalDest))
                {
                    attempt++;
                    finalDest = BuildSuffixedPath(dest, attempt);
                }

                while (Elapsed < maxWaitSeconds)
                {

                    try
                    {
                        File.Move(path, finalDest);
                        return true;
                    }
                    catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
                    {

                        Thread.Sleep(Delay * 1000);
                        Elapsed += Delay;
                        Delay = Math.Min(Delay * 2, maxDelayCapSeconds);
                    }
                }
                throw new TimeoutException("The File could not be moved because it remained locked for the entire retry period.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
