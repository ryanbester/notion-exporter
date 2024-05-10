using DarkMode.Helper;
using NotionExporter.Data.Settings;
using System.Runtime.InteropServices;
using NotionExporter.Core;
using NotionExporter.Data;
using NotionExporter.Data.Models;
using NotionExporter.Properties;

namespace NotionExporter.UI
{
    public partial class NotionExporter : Form
    {
        #region Win32 API

        // Define the Win32 API methods we are going to use
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);

        /// Define our Constants we will use
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 MF_SEPARATOR = 0x800;
        public const Int32 MF_BYPOSITION = 0x400;
        public const Int32 MF_STRING = 0x0;

        #endregion

        public const Int32 _ProfileManagerSysMenuID = 1000;
        public const Int32 _SettingsSysMenuID = 1001;
        public const Int32 _AboutSysMenuID = 1002;

        public NotionExporter()
        {
            InitializeComponent();

            if (Languages.IsRightToLeft) RightToLeft = RightToLeft.Yes;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                switch (m.WParam.ToInt32())
                {
                    case _ProfileManagerSysMenuID:
                        OpenProfileManagerDlg();
                        break;
                    case _SettingsSysMenuID:
                        OpenSettingsDlg();
                        break;
                    case _AboutSysMenuID:
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

            IntPtr systemMenuHandle = GetSystemMenu(this.Handle, false);

            InsertMenu(systemMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(systemMenuHandle, 6, MF_BYPOSITION, _ProfileManagerSysMenuID, "Profile Manager...");
            InsertMenu(systemMenuHandle, 7, MF_BYPOSITION, _SettingsSysMenuID, "Settings...");
            InsertMenu(systemMenuHandle, 8, MF_BYPOSITION, _AboutSysMenuID, "About...");

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
