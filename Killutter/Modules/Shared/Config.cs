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
    }
}