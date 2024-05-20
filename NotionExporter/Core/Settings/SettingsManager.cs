using System.Text.Json;

namespace NotionExporter.Core.Settings
{
    internal static class SettingsManager
    {
        public static Models.Settings Settings { get; set; } = new();
        public static readonly string SETTINGS_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NotionExporter");
        public static readonly string SETTINGS_FILE = Path.Combine(SETTINGS_DIR, "settings.json");

        public static void ReadSettings()
        {
            if (!Directory.Exists(SETTINGS_DIR))
            {
                Directory.CreateDirectory(SETTINGS_DIR);
            }

            if (File.Exists(SETTINGS_FILE))
            {
                var data = File.ReadAllText(SETTINGS_FILE);
                var settings = JsonSerializer.Deserialize<Models.Settings>(data) ?? throw new InvalidConfigException();
                Settings = settings;
            }
            else
            {
                WriteSettings();
            }
        }

        public static void WriteSettings()
        {
            if (!Directory.Exists(SETTINGS_DIR))
            {
                Directory.CreateDirectory(SETTINGS_DIR);
            }

            var data = JsonSerializer.Serialize(Settings);
            File.WriteAllText(SETTINGS_FILE, data);
        }
    }
}
