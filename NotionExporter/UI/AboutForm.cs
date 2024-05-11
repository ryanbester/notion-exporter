using DarkMode.Helper;
using System.Diagnostics;
using System.Text.Json;
using NotionExporter.Models;

namespace NotionExporter.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            Task.Run(LoadLicenses);
        }            

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);

            OkBtn.Focus();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.ryanbester.com")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void LoadLicenses()
        {
            try
            {
                var data = File.ReadAllText("Resources/licenses.json");
                var licenses = JsonSerializer.Deserialize<List<License>>(data);

                if (!this.IsHandleCreated) { return; }
                Invoke(() =>
                {
                    LicensesLst.Items.Clear();

                    foreach (var license in licenses)
                    {
                        LicensesLst.Items.Add(new ListViewItem(license.Name)
                        {
                            Tag = license
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                if (!this.IsHandleCreated) { return; }
                Invoke(() =>
                {
                    LicensesLst.Items.Clear();
                    LicensesLst.Items.Add(new ListViewItem("Failed to load licenses: " + ex.Message)
                    {
                        ForeColor = SystemColors.GrayText
                    });
                });
            }
        }

        private void LicensesLst_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                if (e.Item.Tag is License)
                {
                    var license = (License)e.Item.Tag;
                    PackageNameLbl.Text = license.Name;
                    PackageVersionLbl.Text = license.Version;
                    PackageUrlLbl.Text = license.Url;
                    PackageCopyrightLbl.Text = license.Copyright;
                    PackageAuthorsLbl.Text = string.Join(", ", license.Authors);
                    PackageRepoLbl.Text = license.Repo.Url;
                    PackageLicenseLbl.Text = license.LicenseUrl;
                }
            }
        }

        private void PackageUrlLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo(((LinkLabel)sender).Text)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}
