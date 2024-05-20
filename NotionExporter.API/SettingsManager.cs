using System.Text.Json;

namespace NotionExporter.API
{
    public class SettingsManager
    {
        public delegate JsonElement SerializeCallback();

        public delegate void DeserializeCallback(JsonElement json);

        public Form? GlobalSettingsForm = null;
        public Form? PdfSettingsForm = null;
        public Form? HtmlSettingsForm = null;

        public object? GlobalSettings = null;
        public object? ProfileSettings = null;

        public SerializeCallback? SerializeGlobalSettings = null;
        public SerializeCallback? SerializeProfileSettings = null;

        public DeserializeCallback? DeserializeGlobalSettings = null;
        public DeserializeCallback? DeserializeProfileSettings = null;
    }
}