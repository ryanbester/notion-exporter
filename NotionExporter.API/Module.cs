using Microsoft.Extensions.Logging;

namespace NotionExporter.API
{
    public abstract class Module
    {
        public abstract void InitModule(ILogger? logger);

        public abstract string GetName();

        public abstract List<string> GetProcessesList();

        public abstract Form? GetGlobalSettingsForm();

        public abstract Form? GetPdfSettingsForm();

        public abstract Form? GetHtmlSettingsForm();

    }
}