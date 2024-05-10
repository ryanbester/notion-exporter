using NotionExporter.Properties;

namespace NotionExporter.UI
{
    sealed partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            ToolStrip = new ToolStrip();
            ClearBtn = new ToolStripButton();
            CopyDetailsBtn = new ToolStripButton();
            OpenLogFolderBtn = new ToolStripButton();
            FilterLbl = new ToolStripLabel();
            FilterCombo = new ToolStripComboBox();
            HighlightBtn = new ToolStripButton();
            LogLst = new ListView();
            LogLevelHdr = new ColumnHeader();
            LogMessageHdr = new ColumnHeader();
            LogTimeHdr = new ColumnHeader();
            LogSourceHdr = new ColumnHeader();
            SplitContainer = new SplitContainer();
            DetailsTxt = new RichTextBox();
            ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.Items.AddRange(new ToolStripItem[] { ClearBtn, CopyDetailsBtn, OpenLogFolderBtn, FilterLbl, FilterCombo, HighlightBtn });
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.RenderMode = ToolStripRenderMode.System;
            ToolStrip.Size = new Size(795, 25);
            ToolStrip.TabIndex = 0;
            // 
            // ClearBtn
            // 
            ClearBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ClearBtn.Image = (Image)resources.GetObject("ClearBtn.Image");
            ClearBtn.ImageTransparentColor = Color.Magenta;
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(38, 22);
            ClearBtn.Text = Resources.Clear;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // CopyDetailsBtn
            // 
            CopyDetailsBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            CopyDetailsBtn.Enabled = false;
            CopyDetailsBtn.Image = (Image)resources.GetObject("CopyDetailsBtn.Image");
            CopyDetailsBtn.ImageTransparentColor = Color.Magenta;
            CopyDetailsBtn.Name = "CopyDetailsBtn";
            CopyDetailsBtn.Size = new Size(77, 22);
            CopyDetailsBtn.Text = Resources.CopyDetails;
            CopyDetailsBtn.Click += CopyDetailsBtn_Click;
            // 
            // OpenLogFolderBtn
            // 
            OpenLogFolderBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenLogFolderBtn.Image = (Image)resources.GetObject("OpenLogFolderBtn.Image");
            OpenLogFolderBtn.ImageTransparentColor = Color.Magenta;
            OpenLogFolderBtn.Name = "OpenLogFolderBtn";
            OpenLogFolderBtn.Size = new Size(108, 22);
            OpenLogFolderBtn.Text = Resources.OpenLogFolderBtn;
            OpenLogFolderBtn.Click += OpenLogFolderBtn_Click;
            // 
            // FilterLbl
            // 
            FilterLbl.Name = "FilterLbl";
            FilterLbl.Size = new Size(39, 22);
            FilterLbl.Text = Resources.FilterLbl;
            // 
            // FilterCombo
            // 
            FilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterCombo.Items.AddRange(new object[] { Resources.Verbose, Resources.Debug, Resources.Information, Resources.Warning, Resources.Error, Resources.Fatal });
            FilterCombo.Name = "FilterCombo";
            FilterCombo.Size = new Size(121, 25);
            FilterCombo.ToolTipText = Resources.Filter;
            FilterCombo.SelectedIndexChanged += FilterCombo_SelectedIndexChanged;
            // 
            // HighlightBtn
            // 
            HighlightBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            HighlightBtn.Image = (Image)resources.GetObject("HighlightBtn.Image");
            HighlightBtn.ImageTransparentColor = Color.Magenta;
            HighlightBtn.Name = "HighlightBtn";
            HighlightBtn.Size = new Size(61, 22);
            HighlightBtn.Text = Resources.Highlight;
            HighlightBtn.Click += HighlightBtn_Click;
            // 
            // LogLst
            // 
            LogLst.Columns.AddRange(new ColumnHeader[] { LogLevelHdr, LogMessageHdr, LogTimeHdr, LogSourceHdr });
            LogLst.Dock = DockStyle.Fill;
            LogLst.FullRowSelect = true;
            LogLst.GridLines = true;
            LogLst.Location = new Point(0, 0);
            LogLst.MultiSelect = false;
            LogLst.Name = "LogLst";
            LogLst.Size = new Size(795, 328);
            LogLst.TabIndex = 1;
            LogLst.UseCompatibleStateImageBehavior = false;
            LogLst.View = View.Details;
            LogLst.ItemSelectionChanged += LogLst_ItemSelectionChanged;
            // 
            // LogLevelHdr
            // 
            LogLevelHdr.Text = Resources.Level;
            LogLevelHdr.Width = 100;
            // 
            // LogMessageHdr
            // 
            LogMessageHdr.Text = Resources.Message;
            LogMessageHdr.Width = 300;
            // 
            // LogTimeHdr
            // 
            LogTimeHdr.Text = Resources.Timestamp;
            LogTimeHdr.Width = 120;
            // 
            // LogSourceHdr
            // 
            LogSourceHdr.Text = Resources.Source;
            LogSourceHdr.Width = 100;
            // 
            // SplitContainer
            // 
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 25);
            SplitContainer.Name = "SplitContainer";
            SplitContainer.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(LogLst);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(DetailsTxt);
            SplitContainer.Size = new Size(795, 656);
            SplitContainer.SplitterDistance = 328;
            SplitContainer.TabIndex = 2;
            // 
            // DetailsTxt
            // 
            DetailsTxt.Dock = DockStyle.Fill;
            DetailsTxt.Location = new Point(0, 0);
            DetailsTxt.Name = "DetailsTxt";
            DetailsTxt.ReadOnly = true;
            DetailsTxt.Size = new Size(795, 324);
            DetailsTxt.TabIndex = 1;
            DetailsTxt.Text = "Select a log event above to view details";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 681);
            Controls.Add(SplitContainer);
            Controls.Add(ToolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogForm";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log";
            FormClosing += LogForm_FormClosing;
            Load += LogForm_Load;
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip;
        private ToolStripButton ClearBtn;
        private ListView LogLst;
        private ColumnHeader LogMessageHdr;
        private ColumnHeader LogLevelHdr;
        private ColumnHeader LogTimeHdr;
        private ColumnHeader LogSourceHdr;
        private SplitContainer SplitContainer;
        private RichTextBox DetailsTxt;
        private ToolStripButton CopyDetailsBtn;
        private ToolStripButton OpenLogFolderBtn;
        private ToolStripComboBox FilterCombo;
        private ToolStripLabel FilterLbl;
        private ToolStripButton HighlightBtn;
    }
}