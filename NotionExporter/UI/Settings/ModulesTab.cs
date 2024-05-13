using NotionExporter.API;
using NotionExporter.Core;

namespace NotionExporter.UI.Settings
{
    public partial class ModulesTab : UserControl, ISettingsTab
    {
        public ModulesTab()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            // Load modules
            Modules.LoadModules();

            ModulesLst.DataSource = Modules.ModulesList;
        }

        public void SaveSettings()
        {
        }


        private void ModulesLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Module)ModulesLst.SelectedItem;
            if (selectedItem != null)
            {
                ProcessesLbl.Text = "Processes: \n\n" + string.Join(", ", selectedItem.GetProcessesList());

                var settingsForm = selectedItem.GetGlobalSettingsForm();
                if (settingsForm != null)
                {
                    ModuleSettingsBtn.Enabled = true;
                }
                else
                {
                    ModuleSettingsBtn.Enabled = false;
                }
            }
            else
            {
                ProcessesLbl.Text = "Processes:";
                ModuleSettingsBtn.Enabled = false;
            }
        }

        private void ModuleSettingsBtn_Click(object sender, EventArgs e)
        {
            if (ModulesLst.SelectedItem != null)
            {
                var settingsForm = ((Module)ModulesLst.SelectedItem).GetGlobalSettingsForm();
                if (settingsForm != null)
                {
                    settingsForm.ShowDialog();
                }
            }
        }
    }
}
