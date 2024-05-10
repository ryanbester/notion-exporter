using Serilog.Events;
using System.Diagnostics;
using NotionExporter.Core;
using NotionExporter.Core.Logging;
using NotionExporter.Properties;

namespace NotionExporter.UI
{
    public sealed partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();

            if (Languages.IsRightToLeft) RightToLeft = RightToLeft.Yes;
        }

        private readonly ImageList _imageList = new();

        private readonly List<string> _logLevels = new()
        {
            Resources.Verbose,
            Resources.Debug,
            Resources.Information,
            Resources.Warning,
            Resources.Error,
            Resources.Fatal
        };

        #region Private Methods

        private void RedrawList()
        {
            RedrawList(_ => true);
        }

        private void RedrawList(Func<LogEvent, bool> filter)
        {
            LogLst.Items.Clear();
            Logger.MemorySink.Events.ToList().Where(filter).ToList().ForEach(AddLogEvent);
            ScrollToBottom();
        }
        
        private void ScrollToBottom()
        {
            if (LogLst.Items.Count > 1) LogLst.TopItem = LogLst.Items[^1];
        }

        private void ReceiveLogEvent(LogEvent logEvent)
        {
            AddLogEvent(logEvent);
            ScrollToBottom();
        }

        private void AddLogEvent(LogEvent logEvent)
        {
            var logMessage = logEvent.RenderMessage();

            var listItem = new ListViewItem(_logLevels[(int)logEvent.Level])
            {
                Tag = logEvent
            };
            SetImageAndColor(logEvent.Level, listItem, HighlightBtn.Checked);
            listItem.SubItems.Insert(1, new ListViewItem.ListViewSubItem(listItem, logMessage));
            listItem.SubItems.Insert(2, new ListViewItem.ListViewSubItem(listItem, logEvent.Timestamp.ToString()));
            listItem.SubItems.Insert(3,
                new ListViewItem.ListViewSubItem(listItem,
                    logEvent.Properties.GetValueOrDefault("SourceContext", new ScalarValue("")).ToString()));
            LogLst.Items.Add(listItem);
        }

        private void SetImageAndColor(LogEventLevel level, ListViewItem item, bool highlight)
        {
            switch (level)
            {
                case LogEventLevel.Error:
                case LogEventLevel.Fatal:
                    item.ImageKey = "error";
                    if (highlight) item.BackColor = Color.Red;
                    break;
                case LogEventLevel.Information:
                    item.ImageKey = "info";
                    if (highlight) item.BackColor = Color.LightBlue;
                    break;
                case LogEventLevel.Warning:
                    item.ImageKey = "warn";
                    if (highlight) item.BackColor = Color.Yellow;
                    break;
            }
        }
        
        private void ShowErrorDetails(LogEvent logEvent)
        {
            AppendDetailsSection(Resources.Level, _logLevels[(int)logEvent.Level]);
            AppendDetailsSection(Resources.Timestamp, logEvent.Timestamp.ToString());
            AppendDetailsSection(Resources.Source,
                logEvent.Properties.GetValueOrDefault("SourceContext", new ScalarValue("")).ToString());
            AppendDetailsSection(Resources.Message, logEvent.RenderMessage());

            if (logEvent.Exception != null)
            {
                AppendDetailsSection(Resources.Exception, logEvent.Exception.ToString());
            }

            List<string> properties = new();
            foreach (var property in logEvent.Properties)
            {
                properties.Add($"{property.Key}: {property.Value}");
            }

            AppendDetailsSection(Resources.Properties, string.Join("\n", properties));
        }

        private void AppendDetailsSection(string header, string body)
        {
            DetailsTxt.SelectionIndent = 0;
            DetailsTxt.SelectionFont = new Font(DetailsTxt.SelectionFont, FontStyle.Bold);
            DetailsTxt.AppendText($"{header}\n");
            DetailsTxt.SelectionFont = new Font(DetailsTxt.SelectionFont, FontStyle.Regular);
            DetailsTxt.SelectionIndent = 8;
            DetailsTxt.AppendText($"{body}\n");
        }

        #endregion

        #region Event Handlers

        private void LogForm_Load(object sender, EventArgs e)
        {
            _imageList.Images.Clear();
            _imageList.Images.Add("info", SystemIcons.Information);
            _imageList.Images.Add("warn", SystemIcons.Warning);
            _imageList.Images.Add("error", SystemIcons.Error);
            LogLst.SmallImageList = _imageList;

            RedrawList();

            Logger.MemorySink.Watchers.Add(ReceiveLogEvent);
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.MemorySink.Watchers.Remove(ReceiveLogEvent);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Logger.MemorySink.Events.Clear();
            LogLst.Items.Clear();
        }

        private void LogLst_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selectedItems = LogLst.SelectedItems;
            if (selectedItems.Count > 0)
            {
                CopyDetailsBtn.Enabled = true;
                var logEvent = (LogEvent)selectedItems[0].Tag;
                DetailsTxt.Text = "";
                ShowErrorDetails(logEvent);
            }
            else
            {
                DetailsTxt.Text = Resources.SelectLogEvent_DetailsTxt;
                CopyDetailsBtn.Enabled = false;
            }
        }
        
        private void CopyDetailsBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DetailsTxt.Text);
        }

        private void OpenLogFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Environment.CurrentDirectory, "logs"));
        }

        private void FilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawList(ev => (int)ev.Level >= FilterCombo.SelectedIndex);
        }
        
        private void HighlightBtn_Click(object sender, EventArgs e)
        {
            HighlightBtn.Checked = !HighlightBtn.Checked;
            RedrawList(ev => (int)ev.Level >= FilterCombo.SelectedIndex);
        }

        #endregion
    }
}