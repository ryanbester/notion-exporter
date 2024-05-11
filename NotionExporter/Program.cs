using DarkMode.Helper;
using Microsoft.Extensions.Logging;
using NotionExporter.Core;
using NotionExporter.Core.Logging;
using NotionExporter.Core.Settings;
using NotionExporter.Properties;
using NotionExporter.UI;

namespace NotionExporter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += (_, args) =>
            {
                Logger.App?.LogCritical((Exception)args.ExceptionObject, "An unhandled exception occurred");

                var e = (Exception)args.ExceptionObject;
                var message = Resources.UnhandledException_Occurred;
                if (Logger.App != null)
                {
                    message += string.Format(Resources.UnhandledException_CheckLogs, Environment.NewLine, e.GetType(),
                        e.TargetSite, e.Message);
                }
                else
                {
                    message += string.Format("{0}{0}{1}", Environment.NewLine, e);
                }

                if (args.IsTerminating)
                    message += string.Format(Resources.UnhandledException_ApplicationQuit, Environment.NewLine);
                MessageBox.Show(null, message, Resources.NotionExporter, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            try
            {
                SettingsManager.ReadSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resources.NotionExporter_FailedToReadSettings, ex),
                    Resources.NotionExporter, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Setup logger
            Logger.InitLogger();

            // Open Log form if running in Debug mode
#if DEBUG
            var logForm = new LogForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            logForm.Show();
#endif

            var darkModeProperties = new DarkModeProperties
            {
                Theme = SettingsManager.Settings.Theme,
                ColorMap =
                {
                    [SystemColors.Control] = Color.Black,
                    [SystemColors.ControlText] = Color.White
                }
            };
            darkModeProperties.ControlOverrides[typeof(TabControl)] = control =>
            {
                foreach (TabPage tabPage in ((TabControl)control).TabPages)
                {
                    if (DarkModeHelper.DarkModeEnabledTheme())
                    {
                        tabPage.BackColor = darkModeProperties.GetMappedColor(SystemColors.Control);
                    }
                }
            };
            
            Languages.SetCulture();

            AppContext.CurrentProfile = Profiles.GetDefaultProfile();

            DarkModeHelper.AppInit(darkModeProperties);
            Application.Run(new UI.NotionExporter());
        }
    }
}