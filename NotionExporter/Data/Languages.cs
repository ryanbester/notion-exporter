using System.Globalization;

namespace NotionExporter.Data;

public static class Languages
{
    public static readonly List<CultureInfo> SupportedLanguages = new()
    {
        new CultureInfo("en-US"),
        new CultureInfo("en-GB"),
        new CultureInfo("de")
    };
}