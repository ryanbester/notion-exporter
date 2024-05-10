using DarkMode.Helper;
using Notion.Client;
using NotionExporter.UI.Settings;
using static NotionExporter.UI.Controls.CustomListView;

namespace NotionExporter.UI
{
    public partial class InputTab : UserControl
    {
        public InputTab()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            DarkModeHelper.WndProc(this, m);
            base.WndProc(ref m);
        }

        private void InputTab_Load(object sender, EventArgs e)
        {
            DarkModeHelper.WndLoad(this);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var searchParams = new SearchParameters()
            {
                Query = QueryTxt.Text
            };
            AppContext.NotionClient.Search.SearchAsync(searchParams).ContinueWith(data =>
            {
                Invoke(delegate ()
                {
                    InputLeftLst.Items.Clear();
                    foreach (var item in data.Result.Results)
                    {
                        Type t = item.GetType();
                        if (t == typeof(Page))
                        {
                            var page = (Page)item;
                            var listItem = new ListViewItem(GetPageTitle(page));
                            listItem.SubItems.Insert(1, new ListViewItem.ListViewSubItem(listItem, "Page"));
                            listItem.Tag = page.Id;
                            InputLeftLst.Items.Add(listItem);
                        }
                        else if (t == typeof(Database))
                        {
                            var db = (Database)item;
                            var listItem = new ListViewItem(ParseTitle(db.Title));
                            listItem.SubItems.Insert(1, new ListViewItem.ListViewSubItem(listItem, "Database"));
                            listItem.Tag = db.Id;
                            InputLeftLst.Items.Add(listItem);
                        }
                    }
                });
            });
        }

        private string GetPageTitle(Page page)
        {
            PropertyValue? title;
            if (page.Properties.TryGetValue("title", out title) && title != null)
            {
                return ParseTitle(((TitlePropertyValue)title).Title);
            }
            else if (page.Properties.TryGetValue("Name", out title) && title != null)
            {
                return ParseTitle(((TitlePropertyValue)title).Title);
            }
            return "[Untitled]";
        }

        private string ParseTitle(List<RichTextBase> richText)
        {
            return string.Join(" ", richText.Select(item => item.PlainText));
        }

        private void InputLeftLst_ColumnHeaderRightClick(object sender, HeaderRightClickEventArgs e)
        {
            if ((string)InputLstMenu.Items[0].Tag == "SizeColumn")
            {
                InputLstMenu.Items.RemoveAt(0);
            }

            if (e.ColumnIndex >= 0)
            {
                var menuItem = new ToolStripMenuItem("Size Column to Fit");
                menuItem.Tag = "SizeColumn";
                menuItem.Click += (object? sender, EventArgs e2) =>
                {
                    InputLeftLst.Columns[e.ColumnIndex].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                };

                InputLstMenu.Items.Insert(0, menuItem);
            }

            InputLstMenu.Show(((ListView)sender).PointToScreen(e.Location));
        }

        private void EditColumnsInputLstMenu_Click(object sender, EventArgs e)
        {
            var settingsDlg = new SettingsForm(1);
            settingsDlg.ShowDialog();
        }

        private void SizeColumnsInputLstMenu_Click(object sender, EventArgs e)
        {
            foreach (ColumnHeader column in InputLeftLst.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}
