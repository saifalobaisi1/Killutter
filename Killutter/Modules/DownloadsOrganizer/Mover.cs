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

            try
            {
                while (Elapsed < maxWaitSeconds)
                {

                    try
                    {
                        string Folder = Path.GetDirectoryName(dest);
                        Directory.CreateDirectory(Folder);
                        File.Move(path, dest);
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
    }
}
