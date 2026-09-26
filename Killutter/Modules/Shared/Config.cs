using System.Text.Json;

namespace Killutter.Modules.Shared
{
    public class Config
    {
        public string WatchFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        public string LogPath = Path.Combine(Path.GetTempPath(), "Killutter.log");
        public List<Group> Groups = new List<Group>();

        private static readonly string configPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Killutter", "config.json");

        public static Config Load()
        {
            if (!File.Exists(configPath))
            {
                Config defaultConfig = new Config();
                defaultConfig.Save();
                return defaultConfig;
            }

            string json = File.ReadAllText(configPath);
            return JsonSerializer.Deserialize<Config>(json);
        }

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(configPath));
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(configPath, json);
        }

        public string GetWatchFolder()
        {
            return WatchFolder;
        }

        public void SetWatchFolder(string path)
        {
            WatchFolder = path;
        }

        public string GetLogPath()
        {
            return LogPath;
        }

        public void SetLogPath(string path)
        {
            LogPath = path;
        }

        public List<Group> GetGroups()
        {
            return new List<Group>(Groups);
        }

        public Group GetGroup(Guid id)
        {
            return Groups.Find(g => g.Id == id);
        }
    }
}