using DarkMode.Helper;
using NotionExporter.Core;
using NotionExporter.Core.Settings;
using NotionExporter.Models;
using NotionExporter.Properties;
using NotionExporter.UI.Settings;

namespace NotionExporter.UI
{
    public partial class NotionExporter : Form
    {
        private const Int32 ProfileManagerSysMenuId = 1000;
        private const Int32 SettingsSysMenuId = 1001;
        private const Int32 AboutSysMenuId = 1002;

        public NotionExporter()
        {
            InitializeComponent();

            if (Languages.IsRightToLeft) RightToLeft = RightToLeft.Yes;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SYSCOMMAND)
            {
                switch (m.WParam.ToInt32())
                {
                    case ProfileManagerSysMenuId:
                        OpenProfileManagerDlg();
                        break;
                    case SettingsSysMenuId:
                        OpenSettingsDlg();
                        break;
                    case AboutSysMenuId:
                        OpenAboutDlg();
                        break;
                }
            }

            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void NotionExporter_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);

            IntPtr systemMenuHandle = NativeMethods.GetSystemMenu(this.Handle, false);

            NativeMethods.InsertMenu(systemMenuHandle, 5, NativeMethods.MF_BYPOSITION | NativeMethods.MF_SEPARATOR, 0,
                string.Empty);
            NativeMethods.InsertMenu(systemMenuHandle, 6, NativeMethods.MF_BYPOSITION, ProfileManagerSysMenuId,
                "Profile Manager...");
            NativeMethods.InsertMenu(systemMenuHandle, 7, NativeMethods.MF_BYPOSITION, SettingsSysMenuId,
                "Settings...");
            NativeMethods.InsertMenu(systemMenuHandle, 8, NativeMethods.MF_BYPOSITION, AboutSysMenuId, "About...");

            var notionKey = SettingsManager.Settings.NotionKey;
            if (notionKey == null || notionKey.Length == 0)
            {
                var result = MessageBox.Show(this, Resources.NotionExporter_KeyMustBeConfigured, Resources.NotionExporter, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) OpenSettingsDlg();
                else Close();
            }
            else
            {
                AppContext.SetNotionKey(notionKey);
            }

            var profiles = Profiles.BuiltInProfiles.Concat(SettingsManager.Settings.Profiles).ToList();
            profiles.Sort((item1, item2) =>
            {
                return item1.Name.CompareTo(item2.Name);
            });
            ProfilesCombo.DataSource = profiles;
            ProfilesCombo.DisplayMember = "DisplayString";
            ProfilesCombo.SelectedItem = AppContext.CurrentProfile;
        }
        public void OpenProfileManagerDlg()
        {
            var profileManager = new ProfileManager.ProfileManagerForm();
            profileManager.ShowDialog();
        }

        public void OpenSettingsDlg()
        {
            var settingsFrm = new SettingsForm();
            settingsFrm.ShowDialog();
        }

        public void OpenAboutDlg()
        {
            var aboutFrm = new AboutForm();
            aboutFrm.ShowDialog();
        }

        private void ProfileManagerBtn_Click(object sender, EventArgs e)
        {
            OpenProfileManagerDlg();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            OpenAboutDlg();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            OpenSettingsDlg();
        }

        private void ProfilesCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AppContext.CurrentProfile = (Profile)((ComboBox)sender).SelectedItem;
        }
    }
}
