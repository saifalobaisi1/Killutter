using System.IO;

namespace Killutter.Shared
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    internal static class Logger
    {
        private static readonly object logLock = new object();
        private static string logPath = Path.Combine(
            Path.GetTempPath(), "Killutter.log");

        public static void SetLogPath(string path)
        {
            logPath = path;
        }
        public static void Log(LogLevel level, string message)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

            lock (logLock)
            {
                File.AppendAllText(logPath, line + Environment.NewLine);
            }
        }
    }
}