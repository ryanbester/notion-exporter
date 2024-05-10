using Notion.Client;
using NotionExporter.Core;
using NotionExporter.Data.Settings;
using System.Globalization;
using System.IO.Compression;

namespace NotionExporter.UI.Settings
{
    public partial class GeneralTab : UserControl, ISettingsTab
    {
        public GeneralTab()
        {
            InitializeComponent();
        }

        private void GeneralTab_Load(object sender, EventArgs e)
        {
            NotionKeyLst.SmallImageList = SetupImageList();
            NotionKeyLst.LargeImageList = SetupImageList();
        }

        const int IMG_LOADING = 0;
        const int IMG_POSITIVE = 1;
        const int IMG_NEGATIVE = 2;

        const string NOTION_ERR = "\n\nCheck your internet connection and your Notion API Key.";

        private ImageList SetupImageList()
        {
            var imageSize = 64;
            var imageLst = new ImageList();

            Bitmap loading = new Bitmap(imageSize, imageSize);
            using (Graphics g = Graphics.FromImage(loading))
            {
                using (Pen b = new Pen(System.Drawing.Color.Gray, 5.0f))
                {
                    g.DrawEllipse(b, 5, 5, imageSize - 10, imageSize - 10);
                }
            }

            imageLst.Images.Add(loading);

            Bitmap positive = new Bitmap(imageSize, imageSize);
            using (Graphics g = Graphics.FromImage(positive))
            {
                using (Brush b = new SolidBrush(System.Drawing.Color.Green))
                {
                    g.FillEllipse(b, 0, 0, imageSize, imageSize);
                }
            }

            imageLst.Images.Add(positive);

            Bitmap negative = new Bitmap(imageSize, imageSize);
            using (Graphics g = Graphics.FromImage(negative))
            {
                using (Brush b = new SolidBrush(System.Drawing.Color.Red))
                {
                    g.FillEllipse(b, 0, 0, imageSize, imageSize);
                }
            }

            imageLst.Images.Add(negative);

            return imageLst;
        }

        public void LoadSettings()
        {
            NotionKeyTxt.Text = SettingsManager.Settings.NotionKey;

            switch (SettingsManager.Settings.Theme)
            {
                case DarkMode.DarkMode.Theme.SYSTEM:
                    ThemeFollowsSystemRad.Checked = true;
                    break;
                case DarkMode.DarkMode.Theme.LIGHT:
                    ThemeLightRad.Checked = true;
                    break;
                case DarkMode.DarkMode.Theme.DARK:
                    ThemeDarkRad.Checked = true;
                    break;
            }

            SystemLanguageChk.Checked = SettingsManager.Settings.UseSystemLanguage;

            LanguageCombo.DataSource = Languages.SupportedLanguages;
            LanguageCombo.DisplayMember = "DisplayName";


            var culture = SettingsManager.Settings.Language.ToLower() == "qps-plocm"
                ? new CultureInfo("qps-Ploc")
                : new CultureInfo(SettingsManager.Settings.Language);
            if (Languages.SupportedLanguages.Contains(culture))
            {
                LanguageCombo.SelectedItem = culture;
            }
            else
            {
                var languages = new List<CultureInfo>(Languages.SupportedLanguages) { culture };
                LanguageCombo.DataSource = languages;
                LanguageCombo.SelectedItem = culture;
            }
        }

        public void SaveSettings()
        {
            SettingsManager.Settings.NotionKey = NotionKeyTxt.Text;
            AppContext.SetNotionKey(NotionKeyTxt.Text);

            if (ThemeFollowsSystemRad.Checked) SettingsManager.Settings.Theme = DarkMode.DarkMode.Theme.SYSTEM;
            else if (ThemeLightRad.Checked) SettingsManager.Settings.Theme = DarkMode.DarkMode.Theme.LIGHT;
            else if (ThemeDarkRad.Checked) SettingsManager.Settings.Theme = DarkMode.DarkMode.Theme.DARK;

            SettingsManager.Settings.UseSystemLanguage = SystemLanguageChk.Checked;
            SettingsManager.Settings.Language = ((CultureInfo)LanguageCombo.SelectedItem).Name;
        }


        private void NotionKeyTestBtn_Click(object sender, EventArgs e)
        {
            Task.Run(TestNotionKey);
        }

        private async Task TestReadPage()
        {
            try
            {
                var searchParams = new SearchParameters();
                var searchResults = await AppContext.NotionClient.Search.SearchAsync(searchParams);

                if (searchResults.Results.Count <= 0)
                {
                    MessageBox.Show(this,
                        "Cannot read page content or comments since there are no pages in your Notion.",
                        "Test Notion Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var testPage = searchResults.Results[0];

                // Success
                Invoke(() => NotionKeyLst.Items[0].ImageIndex = IMG_POSITIVE);

                await TestReadComments(testPage.Id);
            }
            catch (NotionApiException ex)
            {
                // Error reading page
                Invoke(() =>
                {
                    NotionKeyLst.Items[0].ImageIndex = IMG_NEGATIVE;

                    if (ex.NotionAPIErrorCode != NotionAPIErrorCode.RestrictedResource)
                    {
                        MessageBox.Show(this,
                            "Cannot read page content: " + ex.NotionAPIErrorCode.ToString() + NOTION_ERR,
                            "Test Notion Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private async Task TestReadComments(string testPageId)
        {
            try
            {
                var commentsResult = await AppContext.NotionClient.Comments.RetrieveAsync(
                    new RetrieveCommentsParameters()
                    {
                        BlockId = testPageId,
                    });

                // Success
                Invoke(() => NotionKeyLst.Items[1].ImageIndex = IMG_POSITIVE);
            }
            catch (NotionApiException ex)
            {
                // Error reading comments
                Invoke(() =>
                {
                    NotionKeyLst.Items[1].ImageIndex = IMG_NEGATIVE;

                    if (ex.NotionAPIErrorCode != NotionAPIErrorCode.RestrictedResource)
                    {
                        MessageBox.Show(this, "Cannot read comments: " + ex.NotionAPIErrorCode.ToString() + NOTION_ERR,
                            "Test Notion Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private async Task TestReadUserInfo()
        {
            try
            {
                var userResult = await AppContext.NotionClient.Users.ListAsync();

                // Success
                Invoke(() => NotionKeyLst.Items[2].ImageIndex = IMG_POSITIVE);
            }
            catch (NotionApiException ex)
            {
                Invoke(() =>
                {
                    NotionKeyLst.Items[2].ImageIndex = IMG_NEGATIVE;

                    if (ex.NotionAPIErrorCode != NotionAPIErrorCode.RestrictedResource)
                    {
                        MessageBox.Show(this,
                            "Cannot read user information: " + ex.NotionAPIErrorCode.ToString() + NOTION_ERR,
                            "Test Notion Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private async void TestNotionKey()
        {
            Invoke(() =>
            {
                Cursor = Cursors.WaitCursor;
                NotionKeyLst.Items.Clear();
                NotionKeyLst.Items.Add(new ListViewItem("Read Content", IMG_LOADING));
                NotionKeyLst.Items.Add(new ListViewItem("Read Comments", IMG_LOADING));
                NotionKeyLst.Items.Add(new ListViewItem("Read User Information", IMG_LOADING));
            });

            // Store old key
            var oldKey = SettingsManager.Settings.NotionKey;
            AppContext.SetNotionKey(NotionKeyTxt.Text);

            // Read page
            await TestReadPage();
            await TestReadUserInfo();

            // Restore old key
            AppContext.SetNotionKey(oldKey);

            Invoke(() => Cursor = Cursors.Default);
        }

        private void NotionKeyLst_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        private void BackupSettingsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "The backup file will contain sensitive information, such as your Notion key. Do not distribute this file.",
                "Backup Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var sfd = new SaveFileDialog();
            sfd.Title = "Backup Settings";
            sfd.Filter = "Zip Archives (*.zip)|*.zip";
            sfd.FileName = "NotionExporterBackup.zip";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ZipFile.CreateFromDirectory(SettingsManager.SETTINGS_DIR, sfd.FileName);
                    MessageBox.Show(this, "Backup created successfully", "Backup Settings", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to create backup: " + ex.Message, "Backup Settings",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RestoreSettingsBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Restore Settings";
            ofd.Filter = "Zip Archives (*.zip)|*.zip";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show(this,
                        string.Format("Restore all settings in {0}. This will overwrite all local data.", ofd.FileName),
                        "Restore Settings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) !=
                    DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    if (Directory.Exists(SettingsManager.SETTINGS_DIR))
                    {
                        Directory.Delete(SettingsManager.SETTINGS_DIR, true);
                    }

                    ZipFile.ExtractToDirectory(ofd.FileName, SettingsManager.SETTINGS_DIR);
                    MessageBox.Show(this, "Backup restored successfully. Please restart Notion Exporter.",
                        "Restore Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to restore backup: " + ex.Message, "Restore Settings",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SystemLanguageChk_CheckedChanged(object sender, EventArgs e)
        {
            LanguageCombo.Enabled = !SystemLanguageChk.Checked;
        }
    }
}
