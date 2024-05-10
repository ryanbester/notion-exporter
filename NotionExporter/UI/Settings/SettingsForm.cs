using DarkMode.Helper;
using Microsoft.Extensions.Logging;
using NotionExporter.Core;
using NotionExporter.Core.Logging;
using NotionExporter.Data.Settings;

namespace NotionExporter.UI.Settings
{
    public partial class SettingsForm : Form
    {
        private readonly ILogger? _logger = Logger.Factory?.CreateLogger<SettingsForm>();

        public SettingsForm()
        {
            InitializeComponent();

            if (Languages.IsRightToLeft) RightToLeft = RightToLeft.Yes;
        }

        public SettingsForm(int tabIndex) : this()
        {
            TabControl.SelectedTab = TabControl.TabPages[tabIndex];
        }

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);

            LoadSettings();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            foreach (TabPage tabPage in TabControl.TabPages)
            {
                tabPage.Controls.OfType<ISettingsTab>().ToList().ForEach(control => control.LoadSettings());
            }
        }

        private void SaveSettings()
        {
            foreach (TabPage tabPage in TabControl.TabPages)
            {
                tabPage.Controls.OfType<ISettingsTab>().ToList().ForEach(control => control.SaveSettings());
            }

            SettingsManager.WriteSettings();
        }
    }
}