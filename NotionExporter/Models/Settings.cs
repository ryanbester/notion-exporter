using System.Text.Json.Serialization;
using Serilog.Events;

namespace NotionExporter.Models
{
    public partial class Settings
    {
        [JsonPropertyName("notion_key")] public string NotionKey { get; set; } = string.Empty;

        [JsonPropertyName("profiles")] public List<Profile> Profiles { get; set; } = new List<Profile>();

        [JsonPropertyName("default_profile")] public string DefaultProfile { get; set; } = "Default";

        [JsonPropertyName("theme")] public DarkMode.DarkMode.Theme Theme { get; set; }

        [JsonPropertyName("system_language")] public bool UseSystemLanguage { get; set; } = true;

        [JsonPropertyName("language")] public string Language { get; set; } = "en-US";

        [JsonPropertyName("log_level")] public LogEventLevel LogLevel { get;set;} = LogEventLevel.Information;
    }
}