using System.Windows.Forms;
using NotionExporter.Properties;

namespace NotionExporter.UI
{
    partial class AboutForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Loading Items..." }, -1, SystemColors.GrayText, Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            OkBtn = new Button();
            TitleLbl = new Label();
            AboutLbl = new Label();
            WebsiteLink = new LinkLabel();
            AboutTabControl = new TabControl();
            AboutTabPage = new TabPage();
            LicensesTabPage = new TabPage();
            LicensesTable = new TableLayoutPanel();
            LicensesLst = new ListView();
            PackageNameHdr = new ColumnHeader();
            LicenseDetailsTable = new TableLayoutPanel();
            PackageAuthorsHdrLbl = new Label();
            PackageNameHdrLbl = new Label();
            PackageNameLbl = new Label();
            PackageVersionHdrLbl = new Label();
            PackageUrlHdrLbl = new Label();
            PackageCopyrightHdrLbl = new Label();
            PackageRepoHdrLbl = new Label();
            PackageLicenseHdrLbl = new Label();
            PackageVersionLbl = new Label();
            PackageCopyrightLbl = new Label();
            PackageAuthorsLbl = new Label();
            PackageUrlLbl = new LinkLabel();
            PackageRepoLbl = new LinkLabel();
            PackageLicenseLbl = new LinkLabel();
            LicensesLbl = new Label();
            AboutTabControl.SuspendLayout();
            AboutTabPage.SuspendLayout();
            LicensesTabPage.SuspendLayout();
            LicensesTable.SuspendLayout();
            LicenseDetailsTable.SuspendLayout();
            SuspendLayout();
            // 
            // OkBtn
            // 
            OkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkBtn.FlatStyle = FlatStyle.System;
            OkBtn.Location = new Point(501, 267);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(75, 23);
            OkBtn.TabIndex = 0;
            OkBtn.Text = Resources.Form_OKBtn;
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLbl.Location = new Point(12, 9);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(160, 30);
            TitleLbl.TabIndex = 1;
            TitleLbl.Text = Resources.NotionExporter;
            TitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutLbl
            // 
            AboutLbl.AutoSize = true;
            AboutLbl.Location = new Point(6, 13);
            AboutLbl.Name = "AboutLbl";
            AboutLbl.Size = new Size(290, 75);
            AboutLbl.TabIndex = 2;
            AboutLbl.Text = $"{Resources.About_TxtLine1}\r\n\r\n{Resources.About_TxtLine2}\r\n\r\n{Resources.About_TxtLine3}";
            // 
            // WebsiteLink
            // 
            WebsiteLink.AutoSize = true;
            WebsiteLink.Location = new Point(6, 102);
            WebsiteLink.Name = "WebsiteLink";
            WebsiteLink.Size = new Size(119, 15);
            WebsiteLink.TabIndex = 4;
            WebsiteLink.TabStop = true;
            WebsiteLink.Text = "www.ryanbester.com";
            WebsiteLink.LinkClicked += WebsiteLink_LinkClicked;
            // 
            // AboutTabControl
            // 
            AboutTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AboutTabControl.Controls.Add(AboutTabPage);
            AboutTabControl.Controls.Add(LicensesTabPage);
            AboutTabControl.Location = new Point(12, 50);
            AboutTabControl.Name = "AboutTabControl";
            AboutTabControl.SelectedIndex = 0;
            AboutTabControl.Size = new Size(564, 211);
            AboutTabControl.TabIndex = 6;
            // 
            // AboutTabPage
            // 
            AboutTabPage.Controls.Add(AboutLbl);
            AboutTabPage.Controls.Add(WebsiteLink);
            AboutTabPage.Location = new Point(4, 24);
            AboutTabPage.Name = "AboutTabPage";
            AboutTabPage.Padding = new Padding(3);
            AboutTabPage.Size = new Size(556, 183);
            AboutTabPage.TabIndex = 0;
            AboutTabPage.Text = Resources.About;
            AboutTabPage.UseVisualStyleBackColor = true;
            // 
            // LicensesTabPage
            // 
            LicensesTabPage.Controls.Add(LicensesTable);
            LicensesTabPage.Controls.Add(LicensesLbl);
            LicensesTabPage.Location = new Point(4, 24);
            LicensesTabPage.Name = "LicensesTabPage";
            LicensesTabPage.Padding = new Padding(3);
            LicensesTabPage.Size = new Size(556, 183);
            LicensesTabPage.TabIndex = 1;
            LicensesTabPage.Text = Resources.About_Licenses;
            LicensesTabPage.UseVisualStyleBackColor = true;
            // 
            // LicensesTable
            // 
            LicensesTable.ColumnCount = 2;
            LicensesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LicensesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LicensesTable.Controls.Add(LicensesLst, 0, 0);
            LicensesTable.Controls.Add(LicenseDetailsTable, 1, 0);
            LicensesTable.Location = new Point(6, 34);
            LicensesTable.Name = "LicensesTable";
            LicensesTable.RowCount = 1;
            LicensesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LicensesTable.Size = new Size(544, 146);
            LicensesTable.TabIndex = 4;
            // 
            // LicensesLst
            // 
            LicensesLst.Columns.AddRange(new ColumnHeader[] { PackageNameHdr });
            LicensesLst.Dock = DockStyle.Fill;
            LicensesLst.FullRowSelect = true;
            LicensesLst.HeaderStyle = ColumnHeaderStyle.None;
            LicensesLst.Items.AddRange(new ListViewItem[] { listViewItem1 });
            LicensesLst.Location = new Point(3, 3);
            LicensesLst.MultiSelect = false;
            LicensesLst.Name = "LicensesLst";
            LicensesLst.Size = new Size(266, 140);
            LicensesLst.TabIndex = 0;
            LicensesLst.TileSize = new Size(228, 16);
            LicensesLst.UseCompatibleStateImageBehavior = false;
            LicensesLst.View = View.Tile;
            LicensesLst.ItemSelectionChanged += LicensesLst_ItemSelectionChanged;
            // 
            // LicenseDetailsTable
            // 
            LicenseDetailsTable.ColumnCount = 2;
            LicenseDetailsTable.ColumnStyles.Add(new ColumnStyle());
            LicenseDetailsTable.ColumnStyles.Add(new ColumnStyle());
            LicenseDetailsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LicenseDetailsTable.Controls.Add(PackageAuthorsHdrLbl, 0, 4);
            LicenseDetailsTable.Controls.Add(PackageNameHdrLbl, 0, 0);
            LicenseDetailsTable.Controls.Add(PackageNameLbl, 1, 0);
            LicenseDetailsTable.Controls.Add(PackageVersionHdrLbl, 0, 1);
            LicenseDetailsTable.Controls.Add(PackageUrlHdrLbl, 0, 2);
            LicenseDetailsTable.Controls.Add(PackageCopyrightHdrLbl, 0, 3);
            LicenseDetailsTable.Controls.Add(PackageRepoHdrLbl, 0, 5);
            LicenseDetailsTable.Controls.Add(PackageLicenseHdrLbl, 0, 6);
            LicenseDetailsTable.Controls.Add(PackageVersionLbl, 1, 1);
            LicenseDetailsTable.Controls.Add(PackageCopyrightLbl, 1, 3);
            LicenseDetailsTable.Controls.Add(PackageAuthorsLbl, 1, 4);
            LicenseDetailsTable.Controls.Add(PackageUrlLbl, 1, 2);
            LicenseDetailsTable.Controls.Add(PackageRepoLbl, 1, 5);
            LicenseDetailsTable.Controls.Add(PackageLicenseLbl, 1, 6);
            LicenseDetailsTable.Dock = DockStyle.Fill;
            LicenseDetailsTable.Location = new Point(275, 3);
            LicenseDetailsTable.Name = "LicenseDetailsTable";
            LicenseDetailsTable.RowCount = 7;
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.RowStyles.Add(new RowStyle());
            LicenseDetailsTable.Size = new Size(266, 140);
            LicenseDetailsTable.TabIndex = 1;
            // 
            // PackageAuthorsHdrLbl
            // 
            PackageAuthorsHdrLbl.AutoSize = true;
            PackageAuthorsHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageAuthorsHdrLbl.Location = new Point(3, 72);
            PackageAuthorsHdrLbl.Name = "PackageAuthorsHdrLbl";
            PackageAuthorsHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageAuthorsHdrLbl.Size = new Size(54, 18);
            PackageAuthorsHdrLbl.TabIndex = 7;
            PackageAuthorsHdrLbl.Text = Resources.About_AuthorsLbl;
            // 
            // PackageNameHdrLbl
            // 
            PackageNameHdrLbl.AutoSize = true;
            PackageNameHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageNameHdrLbl.Location = new Point(3, 0);
            PackageNameHdrLbl.Name = "PackageNameHdrLbl";
            PackageNameHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageNameHdrLbl.Size = new Size(43, 18);
            PackageNameHdrLbl.TabIndex = 0;
            PackageNameHdrLbl.Text = Resources.NameLbl;
            // 
            // PackageNameLbl
            // 
            PackageNameLbl.AutoSize = true;
            PackageNameLbl.Location = new Point(79, 0);
            PackageNameLbl.Name = "PackageNameLbl";
            PackageNameLbl.Padding = new Padding(0, 0, 0, 3);
            PackageNameLbl.Size = new Size(0, 18);
            PackageNameLbl.TabIndex = 1;
            // 
            // PackageVersionHdrLbl
            // 
            PackageVersionHdrLbl.AutoSize = true;
            PackageVersionHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageVersionHdrLbl.Location = new Point(3, 18);
            PackageVersionHdrLbl.Name = "PackageVersionHdrLbl";
            PackageVersionHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageVersionHdrLbl.Size = new Size(51, 18);
            PackageVersionHdrLbl.TabIndex = 2;
            PackageVersionHdrLbl.Text = Resources.VersionLbl;
            // 
            // PackageUrlHdrLbl
            // 
            PackageUrlHdrLbl.AutoSize = true;
            PackageUrlHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageUrlHdrLbl.Location = new Point(3, 36);
            PackageUrlHdrLbl.Name = "PackageUrlHdrLbl";
            PackageUrlHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageUrlHdrLbl.Size = new Size(33, 18);
            PackageUrlHdrLbl.TabIndex = 3;
            PackageUrlHdrLbl.Text = Resources.URLLbl;
            // 
            // PackageCopyrightHdrLbl
            // 
            PackageCopyrightHdrLbl.AutoSize = true;
            PackageCopyrightHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageCopyrightHdrLbl.Location = new Point(3, 54);
            PackageCopyrightHdrLbl.Name = "PackageCopyrightHdrLbl";
            PackageCopyrightHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageCopyrightHdrLbl.Size = new Size(64, 18);
            PackageCopyrightHdrLbl.TabIndex = 4;
            PackageCopyrightHdrLbl.Text = Resources.About_CopyrightLbl;
            // 
            // PackageRepoHdrLbl
            // 
            PackageRepoHdrLbl.AutoSize = true;
            PackageRepoHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageRepoHdrLbl.Location = new Point(3, 90);
            PackageRepoHdrLbl.Name = "PackageRepoHdrLbl";
            PackageRepoHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageRepoHdrLbl.Size = new Size(70, 18);
            PackageRepoHdrLbl.TabIndex = 8;
            PackageRepoHdrLbl.Text = Resources.RepositoryLbl;
            // 
            // PackageLicenseHdrLbl
            // 
            PackageLicenseHdrLbl.AutoSize = true;
            PackageLicenseHdrLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PackageLicenseHdrLbl.Location = new Point(3, 108);
            PackageLicenseHdrLbl.Name = "PackageLicenseHdrLbl";
            PackageLicenseHdrLbl.Padding = new Padding(0, 0, 0, 3);
            PackageLicenseHdrLbl.Size = new Size(51, 18);
            PackageLicenseHdrLbl.TabIndex = 9;
            PackageLicenseHdrLbl.Text = Resources.About_LicenseLbl;
            // 
            // PackageVersionLbl
            // 
            PackageVersionLbl.AutoSize = true;
            PackageVersionLbl.Location = new Point(79, 18);
            PackageVersionLbl.Name = "PackageVersionLbl";
            PackageVersionLbl.Padding = new Padding(0, 0, 0, 3);
            PackageVersionLbl.Size = new Size(0, 18);
            PackageVersionLbl.TabIndex = 10;
            // 
            // PackageCopyrightLbl
            // 
            PackageCopyrightLbl.AutoSize = true;
            PackageCopyrightLbl.Location = new Point(79, 54);
            PackageCopyrightLbl.Name = "PackageCopyrightLbl";
            PackageCopyrightLbl.Padding = new Padding(0, 0, 0, 3);
            PackageCopyrightLbl.Size = new Size(0, 18);
            PackageCopyrightLbl.TabIndex = 11;
            // 
            // PackageAuthorsLbl
            // 
            PackageAuthorsLbl.AutoSize = true;
            PackageAuthorsLbl.Location = new Point(79, 72);
            PackageAuthorsLbl.Name = "PackageAuthorsLbl";
            PackageAuthorsLbl.Padding = new Padding(0, 0, 0, 3);
            PackageAuthorsLbl.Size = new Size(0, 18);
            PackageAuthorsLbl.TabIndex = 12;
            // 
            // PackageUrlLbl
            // 
            PackageUrlLbl.AutoSize = true;
            PackageUrlLbl.Location = new Point(79, 36);
            PackageUrlLbl.Name = "PackageUrlLbl";
            PackageUrlLbl.Padding = new Padding(0, 0, 0, 3);
            PackageUrlLbl.Size = new Size(0, 18);
            PackageUrlLbl.TabIndex = 13;
            PackageUrlLbl.LinkClicked += PackageUrlLbl_LinkClicked;
            // 
            // PackageRepoLbl
            // 
            PackageRepoLbl.AutoSize = true;
            PackageRepoLbl.Location = new Point(79, 90);
            PackageRepoLbl.Name = "PackageRepoLbl";
            PackageRepoLbl.Padding = new Padding(0, 0, 0, 3);
            PackageRepoLbl.Size = new Size(0, 18);
            PackageRepoLbl.TabIndex = 14;
            PackageRepoLbl.LinkClicked += PackageUrlLbl_LinkClicked;
            // 
            // PackageLicenseLbl
            // 
            PackageLicenseLbl.AutoSize = true;
            PackageLicenseLbl.Location = new Point(79, 108);
            PackageLicenseLbl.Name = "PackageLicenseLbl";
            PackageLicenseLbl.Padding = new Padding(0, 0, 0, 3);
            PackageLicenseLbl.Size = new Size(0, 18);
            PackageLicenseLbl.TabIndex = 15;
            PackageLicenseLbl.LinkClicked += PackageUrlLbl_LinkClicked;
            // 
            // LicensesLbl
            // 
            LicensesLbl.AutoSize = true;
            LicensesLbl.Location = new Point(6, 13);
            LicensesLbl.Name = "LicensesLbl";
            LicensesLbl.Size = new Size(390, 15);
            LicensesLbl.TabIndex = 3;
            LicensesLbl.Text = Resources.About_LicensesTxt;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = OkBtn;
            ClientSize = new Size(588, 302);
            Controls.Add(AboutTabControl);
            Controls.Add(TitleLbl);
            Controls.Add(OkBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = Resources.About_Title;
            Load += AboutForm_Load;
            AboutTabControl.ResumeLayout(false);
            AboutTabPage.ResumeLayout(false);
            AboutTabPage.PerformLayout();
            LicensesTabPage.ResumeLayout(false);
            LicensesTabPage.PerformLayout();
            LicensesTable.ResumeLayout(false);
            LicenseDetailsTable.ResumeLayout(false);
            LicenseDetailsTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkBtn;
        private Label TitleLbl;
        private Label AboutLbl;
        private LinkLabel WebsiteLink;
        private TabControl AboutTabControl;
        private TabPage AboutTabPage;
        private TabPage LicensesTabPage;
        private Label LicensesLbl;
        private TableLayoutPanel LicensesTable;
        private ListView LicensesLst;
        private TableLayoutPanel LicenseDetailsTable;
        private Label PackageNameHdrLbl;
        private Label PackageNameLbl;
        private Label PackageVersionHdrLbl;
        private Label PackageUrlHdrLbl;
        private Label PackageAuthorsHdrLbl;
        private Label PackageCopyrightHdrLbl;
        private Label PackageRepoHdrLbl;
        private Label PackageLicenseHdrLbl;
        private Label PackageVersionLbl;
        private Label PackageCopyrightLbl;
        private Label PackageAuthorsLbl;
        private LinkLabel PackageUrlLbl;
        private LinkLabel PackageRepoLbl;
        private LinkLabel PackageLicenseLbl;
        private ColumnHeader PackageNameHdr;
    }
}