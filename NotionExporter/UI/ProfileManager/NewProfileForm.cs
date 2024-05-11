using DarkMode.Helper;
using NotionExporter.Core;
using NotionExporter.Core.Settings;
using NotionExporter.Models;
using NotionExporter.Properties;

namespace NotionExporter.UI.ProfileManager
{
    public partial class NewProfileForm : Form
    {
        public enum Action
        {
            NEW,
            DUPLICATE,
            RENAME
        }

        private Action CurrentAction { get; set; }
        private Profile? Profile { get; set; }

        private NewProfileForm()
        {
            InitializeComponent();
        }

        public NewProfileForm(Action action, Profile? profile = null) : this()
        {
            CurrentAction = action;
            Profile = profile;
            switch (action)
            {
                case Action.NEW:
                    Text = Resources.NewProfileForm_Title;
                    break;
                case Action.DUPLICATE:
                    if (profile == null)
                    {
                        Close();
                        return;
                    }
                    Text = string.Format(Resources.NewProfileForm_DuplicateTitle, profile.Name);
                    break;
                case Action.RENAME:
                    if (profile == null)
                    {
                        Close();
                        return;
                    }
                    Text = string.Format(Resources.NewProfileForm_RenameTitle, profile.Name);
                    break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void NewProfileForm_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (Profiles.GetProfile(NameTxt.Text) != null)
            {
                MessageBox.Show(this, "A profile already exists with this name.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            switch (CurrentAction)
            {
                case Action.NEW:
                    SettingsManager.Settings.Profiles.Add(new Profile(NameTxt.Text));
                    SettingsManager.WriteSettings();
                    Close();
                    break;
                case Action.DUPLICATE:
                    Profile newProfile = (Profile)(Profile?.Clone());
                    newProfile.BuiltIn = false;
                    newProfile.Name = NameTxt.Text;
                    SettingsManager.Settings.Profiles.Add(newProfile);
                    SettingsManager.WriteSettings();
                    Close();
                    break;
                case Action.RENAME:
                    Profile.Name = NameTxt.Text;
                    SettingsManager.WriteSettings();
                    Close();
                    break;
            }
        }
    }
}
