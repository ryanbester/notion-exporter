using System.Globalization;
using Microsoft.Extensions.Logging;
using NotionExporter.Core.Logging;
using NotionExporter.Core.Settings;

namespace NotionExporter.Core;

public static class Languages
{
    public static readonly List<CultureInfo> SupportedLanguages = new()
    {
        new CultureInfo("en-US"),
        new CultureInfo("en-GB"),
        new CultureInfo("de")
    };
    
    public static bool IsRightToLeft { get; private set; }

    public static void SetCulture()
    {
        if (SettingsManager.Settings.UseSystemLanguage) return;

        var cultureName = SettingsManager.Settings.Language;
        
        // qps-plocm is unknown, use qps-ploc instead for mirrored layouts
        if (cultureName.ToLower() == "qps-plocm") cultureName = "qps-Ploc";
        
        try
        {
            var culture =  new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            
            // Explicitly set right to left for qps-plocm culture
            IsRightToLeft = SettingsManager.Settings.Language.ToLower() == "qps-plocm" || culture.TextInfo.IsRightToLeft;
        }
        catch (CultureNotFoundException ex)
        {
            Logger.App?.LogWarning(ex, "Invalid culture");
            
            // Set default language
            SettingsManager.Settings.Language = SupportedLanguages[0].Name;
            var culture = new CultureInfo(SettingsManager.Settings.Language);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            IsRightToLeft = culture.TextInfo.IsRightToLeft;
        }
    }
}
