using System.Globalization;
using DarkMode.Helper;
using NotionExporter.Data;
using NotionExporter.Data.Settings;
using NotionExporter.Properties;

namespace NotionExporter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                SettingsManager.ReadSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read settings: " + ex, Resources.NotionExporter, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var darkModeProperties = new DarkModeProperties()
            {
                Theme = SettingsManager.Settings.Theme,
            };
            darkModeProperties.ColorMap[SystemColors.Control] = Color.Black;
            darkModeProperties.ColorMap[SystemColors.ControlText] = Color.White;
            darkModeProperties.ControlOverrides[typeof(TabControl)] = (control) =>
            {
                foreach (TabPage tabPage in ((TabControl)control).TabPages)
                {
                    if (DarkModeHelper.DarkModeEnabledTheme())
                    {
                        tabPage.BackColor = darkModeProperties.GetMappedColor(SystemColors.Control);
                    }
                }
            };

            AppContext.CurrentProfile = Profiles.GetDefaultProfile();

            // TODO: Move order
            if (!SettingsManager.Settings.UseSystemLanguage)
            {
                try
                {
                    var culture = new CultureInfo(SettingsManager.Settings.Language);
                    CultureInfo.DefaultThreadCurrentCulture = culture;
                    CultureInfo.DefaultThreadCurrentUICulture = culture;
                }
                catch (CultureNotFoundException)
                {
                    SettingsManager.Settings.Language = Languages.SupportedLanguages[0].Name;
                    var culture = new CultureInfo(SettingsManager.Settings.Language);
                    CultureInfo.DefaultThreadCurrentCulture = culture;
                    CultureInfo.DefaultThreadCurrentUICulture = culture;
                }
            }

            DarkModeHelper.AppInit(darkModeProperties);
            Application.Run(new UI.NotionExporter());
        }
    }
}