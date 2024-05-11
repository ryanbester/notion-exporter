using NotionExporter.Core.Settings;
using Serilog.Events;

namespace NotionExporter.UI.Settings
{
    public partial class DebugTab : UserControl, ISettingsTab
    {
        public DebugTab()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            LogLevelCombo.SelectedIndex = (int)SettingsManager.Settings.LogLevel;
        }

        public void SaveSettings()
        {
            SettingsManager.Settings.LogLevel = (LogEventLevel)LogLevelCombo.SelectedIndex;
        }

        private void OpenLogBtn_Click(object sender, EventArgs e)
        {
            var logForm = new LogForm();
            logForm.Show();
        }
    }
}
