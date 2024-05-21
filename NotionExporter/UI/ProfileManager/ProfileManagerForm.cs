using DarkMode.Helper;
using System.Text.Json;
using System.Text.Json.Serialization;
using NotionExporter.Core;
using NotionExporter.Core.Settings;
using NotionExporter.Models;
using NotionExporter.Properties;
using NotionExporter.UI.Controls;

namespace NotionExporter.UI.ProfileManager
{
    public partial class ProfileManagerForm : Form
    {
        public ProfileManagerForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void ProfileManagerForm_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);

            LoadData();
        }

        private void LoadData()
        {
            ProfilesLst.DataSource = null;
            var profiles = Profiles.BuiltInProfiles.Concat(SettingsManager.Settings.Profiles).ToList();
            profiles.Sort((item1, item2) =>
            {
                return item1.Name.CompareTo(item2.Name);
            });
            ProfilesLst.DataSource = profiles;
            ProfilesLst.DisplayMember = "DisplayString";
            ProfilesLst.SelectedItem = AppContext.CurrentProfile;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfilesLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem is not Profile) return;
            var builtIn = ((Profile)((ListBox)sender).SelectedItem).BuiltIn;
            RenameBtn.Enabled = !builtIn;
            DeleteBtn.Enabled = !builtIn;
        }

        private void ActivateBtn_Click(object sender, EventArgs e)
        {
            AppContext.CurrentProfile = (Profile)ProfilesLst.SelectedItem;
            LoadData();
        }

        private void ProfilesLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AppContext.CurrentProfile = (Profile)ProfilesLst.SelectedItem;
            LoadData();
            // FIXME: Check if in list area (double clicking blank space sets current to selected item)
        }

        private void SetDefaultBtn_Click(object sender, EventArgs e)
        {
            SettingsManager.Settings.DefaultProfile = ((Profile)ProfilesLst.SelectedItem).Name;
            SettingsManager.WriteSettings();
            LoadData();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            var newProfileDlg = new NewProfileForm(NewProfileForm.Action.NEW);
            newProfileDlg.ShowDialog();
            LoadData();
        }

        private void DuplicateBtn_Click(object sender, EventArgs e)
        {
            var duplicateProfileDlg = new NewProfileForm(NewProfileForm.Action.DUPLICATE, (Profile)ProfilesLst.SelectedItem);
            duplicateProfileDlg.ShowDialog();
            LoadData();
        }

        private void RenameBtn_Click(object sender, EventArgs e)
        {
            var renameProfileDlg = new NewProfileForm(NewProfileForm.Action.RENAME, (Profile)ProfilesLst.SelectedItem);
            renameProfileDlg.ShowDialog();
            LoadData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfilesLst.SelectedItem;
            var result = MessageBox.Show(this, string.Format(Resources.ProfileManagerForm_DeleteTxt, profile.Name), string.Format(Resources.ProfileManagerForm_DeleteTitle, profile.Name), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                SettingsManager.Settings.Profiles.Remove(profile);
                SettingsManager.WriteSettings();
                LoadData();
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = Resources.ProfileManagerForm_ImportProfile;
            ofd.Filter = "Notion Exporter Profile Files (*.nep)|*.nep|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var data = File.ReadAllText(ofd.FileName);
                var profile = JsonSerializer.Deserialize<Profile>(data);
                
                if (Profiles.GetProfile(profile.Name) != null)
                {
                    MessageBox.Show(this, Resources.ProfileManagerForm_ImportProfileAlreadyExists, Resources.ProfileManagerForm_ImportProfile, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // TODO: Error handling
                SettingsManager.Settings.Profiles.Add(profile);
                SettingsManager.WriteSettings();
                MessageBox.Show(this, Resources.ProfileManagerForm_ImportProfileSuccess, Resources.ProfileManagerForm_ImportProfile, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            var profile = (Profile)ProfilesLst.SelectedItem;
            var options = new ExportProfileControls();
            using var sfd = new CustomSaveDialog(new SaveFileDialog()
            {
                Title = string.Format(Resources.ProfileManagerForm_ExportTitle, profile.Name),
                FileName = $"{profile.Name}.nep",
                Filter = "Notion Exporter Profile Files (*.nep)|*.nep|All Files (*.*)|*.*"
            }, options);

            if (sfd.Dlg.ShowDialog() == DialogResult.OK)
            {
                var data = JsonSerializer.Serialize(profile);

                if (options.IncludeModulesChk.Checked)
                {
                    var exportProfile = new ProfileWithModules(profile);
                    data = JsonSerializer.Serialize(exportProfile);
                }
                
                File.WriteAllText(sfd.Dlg.FileName, data);
                MessageBox.Show(this, Resources.ProfileManagerForm_ExportProfileSuccess, Resources.ProfileManagerForm_ExportProfile, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }

    internal class ProfileWithModules : Profile
    {
        [JsonPropertyName("modules")]
        public Dictionary<string, Version> Modules { get; }

        public ProfileWithModules(Profile profile) : base(profile.Name)
        {
            Modules = new Dictionary<string, Version>();
            foreach (var module in Core.Modules.ModulesList)
            {
                Modules.Add(module.GetType().FullName!, module.GetMetadata().Version);
            }
        }
    }
}
