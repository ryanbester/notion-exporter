using DarkMode.Helper;
using System.Diagnostics;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using NotionExporter.Core;
using NotionExporter.Core.Logging;
using NotionExporter.Models;
using NotionExporter.Properties;

namespace NotionExporter.UI
{
    public partial class AboutForm : Form
    {
        private readonly ILogger? _logger = Logger.Factory?.CreateLogger<AboutForm>();

        public AboutForm()
        {
            InitializeComponent();

            if (Languages.IsRightToLeft) RightToLeft = RightToLeft.Yes;

            Task.Run(LoadLicenses);
        }

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        #region Private Methods

        private void LoadLicenses()
        {
            try
            {
                _logger?.LogInformation("Loading license text...");

                var data = File.ReadAllText("Resources/LICENSE");
                if (!IsHandleCreated) return;
                Invoke(() => LicenseTxt.Text = data);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Failed to load license text");

                if (!IsHandleCreated) return;
                Invoke(() => LicenseTxt.Text = Resources.About_FailedToLoadLicense);
            }

            try
            {
                _logger?.LogInformation("Loading licenses...");

                var data = File.ReadAllText("Resources/licenses.json");
                var licenses = JsonSerializer.Deserialize<List<License>>(data);

                if (!IsHandleCreated) return;
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
                _logger?.LogError(ex, "Failed to load licenses");

                if (!IsHandleCreated) return;
                Invoke(() =>
                {
                    LicensesLst.Items.Clear();
                    LicensesLst.Items.Add(new ListViewItem(Resources.About_FailedToLoadLicenses)
                    {
                        ForeColor = SystemColors.GrayText
                    });
                });
            }
        }

        private void OpenLink(string link)
        {
            var ps = new ProcessStartInfo(link)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        #endregion

        #region Event Handlers

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
            OpenLink("https://go.ryanbester.com/notion-exporter");
        }
        
        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/ryanbester/notion-exporter");
        }

        private void LicensesLst_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            if (e.Item?.Tag is not License license) return;

            PackageNameLbl.Text = license.Name;
            PackageVersionLbl.Text = license.Version;
            PackageUrlLbl.Text = license.Url;
            PackageCopyrightLbl.Text = license.Copyright;
            PackageAuthorsLbl.Text = string.Join(", ", license.Authors);
            PackageRepoLbl.Text = license.Repo.Url;
            PackageLicenseLbl.Text = license.LicenseUrl;
        }

        private void PackageUrlLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(((LinkLabel)sender).Text);
        }

        #endregion

    }
}