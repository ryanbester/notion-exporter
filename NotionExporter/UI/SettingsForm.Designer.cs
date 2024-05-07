using NotionExporter.Properties;

namespace NotionExporter.UI
{
    partial class SettingsForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Click Test to view results" }, -1, SystemColors.GrayText, Color.Empty, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            NotionKeyLbl = new Label();
            ApplyBtn = new Button();
            NotionKeyTxt = new TextBox();
            CancelBtn = new Button();
            OkBtn = new Button();
            TabControl = new TabControl();
            GeneralTabPage = new TabPage();
            LanguageGrp = new GroupBox();
            SystemLanguageChk = new CheckBox();
            LanguageCombo = new ComboBox();
            ThemeGroup = new GroupBox();
            ThemeFollowsSystemRad = new RadioButton();
            ThemeDarkRad = new RadioButton();
            ThemeLightRad = new RadioButton();
            BackupGrp = new GroupBox();
            BackupRestoreLbl = new Label();
            BackupSettingsBtn = new Button();
            RestoreSettingsBtn = new Button();
            AuthGrp = new GroupBox();
            NotionKeyTestBtn = new Button();
            NotionKeyLst = new ListView();
            PermissionHdr = new ColumnHeader();
            NotionKeyMsgLbl = new Label();
            InputTabPage = new TabPage();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            TabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            LanguageGrp.SuspendLayout();
            ThemeGroup.SuspendLayout();
            BackupGrp.SuspendLayout();
            AuthGrp.SuspendLayout();
            InputTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // NotionKeyLbl
            // 
            NotionKeyLbl.AutoSize = true;
            NotionKeyLbl.Location = new Point(6, 25);
            NotionKeyLbl.Name = "NotionKeyLbl";
            NotionKeyLbl.Size = new Size(69, 15);
            NotionKeyLbl.TabIndex = 5;
            NotionKeyLbl.Text = Resources.SettingsForm_NotionKeyLbl;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyBtn.FlatStyle = FlatStyle.System;
            ApplyBtn.Location = new Point(319, 468);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(75, 23);
            ApplyBtn.TabIndex = 7;
            ApplyBtn.Text = Resources.Apply;
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // NotionKeyTxt
            // 
            NotionKeyTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NotionKeyTxt.Location = new Point(81, 22);
            NotionKeyTxt.Name = "NotionKeyTxt";
            NotionKeyTxt.PasswordChar = '*';
            NotionKeyTxt.Size = new Size(196, 23);
            NotionKeyTxt.TabIndex = 4;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.FlatStyle = FlatStyle.System;
            CancelBtn.Location = new Point(238, 468);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = Resources.Form_CancelBtn;
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            OkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkBtn.FlatStyle = FlatStyle.System;
            OkBtn.Location = new Point(157, 468);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(75, 23);
            OkBtn.TabIndex = 5;
            OkBtn.Text = Resources.Form_OKBtn;
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(GeneralTabPage);
            TabControl.Controls.Add(InputTabPage);
            TabControl.Location = new Point(10, 10);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(384, 452);
            TabControl.TabIndex = 8;
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.Controls.Add(LanguageGrp);
            GeneralTabPage.Controls.Add(ThemeGroup);
            GeneralTabPage.Controls.Add(BackupGrp);
            GeneralTabPage.Controls.Add(AuthGrp);
            GeneralTabPage.Location = new Point(4, 24);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new Padding(3);
            GeneralTabPage.Size = new Size(376, 424);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = Resources.Settings_General;
            GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // LanguageGrp
            // 
            LanguageGrp.Controls.Add(SystemLanguageChk);
            LanguageGrp.Controls.Add(LanguageCombo);
            LanguageGrp.Location = new Point(6, 311);
            LanguageGrp.Name = "LanguageGrp";
            LanguageGrp.Size = new Size(364, 100);
            LanguageGrp.TabIndex = 19;
            LanguageGrp.TabStop = false;
            LanguageGrp.Text = Resources.Language;
            // 
            // SystemLanguageChk
            // 
            SystemLanguageChk.AutoSize = true;
            SystemLanguageChk.Location = new Point(6, 22);
            SystemLanguageChk.Name = "SystemLanguageChk";
            SystemLanguageChk.Size = new Size(141, 19);
            SystemLanguageChk.TabIndex = 19;
            SystemLanguageChk.Text = Resources.UseSystemLanguage;
            SystemLanguageChk.UseVisualStyleBackColor = true;
            SystemLanguageChk.CheckedChanged += SystemLanguageChk_CheckedChanged;
            // 
            // LanguageCombo
            // 
            LanguageCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageCombo.FlatStyle = FlatStyle.System;
            LanguageCombo.FormattingEnabled = true;
            LanguageCombo.Location = new Point(6, 47);
            LanguageCombo.Name = "LanguageCombo";
            LanguageCombo.Size = new Size(237, 23);
            LanguageCombo.TabIndex = 18;
            // 
            // ThemeGroup
            // 
            ThemeGroup.Controls.Add(ThemeFollowsSystemRad);
            ThemeGroup.Controls.Add(ThemeDarkRad);
            ThemeGroup.Controls.Add(ThemeLightRad);
            ThemeGroup.Location = new Point(6, 251);
            ThemeGroup.Name = "ThemeGroup";
            ThemeGroup.Size = new Size(364, 54);
            ThemeGroup.TabIndex = 16;
            ThemeGroup.TabStop = false;
            ThemeGroup.Text = Resources.Theme;
            // 
            // ThemeFollowsSystemRad
            // 
            ThemeFollowsSystemRad.AutoSize = true;
            ThemeFollowsSystemRad.FlatStyle = FlatStyle.System;
            ThemeFollowsSystemRad.Location = new Point(6, 22);
            ThemeFollowsSystemRad.Name = "ThemeFollowsSystemRad";
            ThemeFollowsSystemRad.Size = new Size(112, 20);
            ThemeFollowsSystemRad.TabIndex = 13;
            ThemeFollowsSystemRad.Text = Resources.SettingsForm_ThemeFollowsSystem;
            ThemeFollowsSystemRad.UseVisualStyleBackColor = true;
            // 
            // ThemeDarkRad
            // 
            ThemeDarkRad.AutoSize = true;
            ThemeDarkRad.FlatStyle = FlatStyle.System;
            ThemeDarkRad.Location = new Point(188, 22);
            ThemeDarkRad.Name = "ThemeDarkRad";
            ThemeDarkRad.Size = new Size(55, 20);
            ThemeDarkRad.TabIndex = 15;
            ThemeDarkRad.Text = Resources.SettingsForm_ThemeDark;
            ThemeDarkRad.UseVisualStyleBackColor = true;
            // 
            // ThemeLightRad
            // 
            ThemeLightRad.AutoSize = true;
            ThemeLightRad.FlatStyle = FlatStyle.System;
            ThemeLightRad.Location = new Point(124, 22);
            ThemeLightRad.Name = "ThemeLightRad";
            ThemeLightRad.Size = new Size(58, 20);
            ThemeLightRad.TabIndex = 14;
            ThemeLightRad.Text = Resources.SettingsForm_ThemeLight;
            ThemeLightRad.UseVisualStyleBackColor = true;
            // 
            // BackupGrp
            // 
            BackupGrp.Controls.Add(BackupRestoreLbl);
            BackupGrp.Controls.Add(BackupSettingsBtn);
            BackupGrp.Controls.Add(RestoreSettingsBtn);
            BackupGrp.Location = new Point(6, 162);
            BackupGrp.Name = "BackupGrp";
            BackupGrp.Size = new Size(364, 83);
            BackupGrp.TabIndex = 12;
            BackupGrp.TabStop = false;
            BackupGrp.Text = Resources.Settings_BackupAndRestore;
            // 
            // BackupRestoreLbl
            // 
            BackupRestoreLbl.Location = new Point(6, 19);
            BackupRestoreLbl.Name = "BackupRestoreLbl";
            BackupRestoreLbl.Size = new Size(352, 31);
            BackupRestoreLbl.TabIndex = 11;
            BackupRestoreLbl.Text = Resources.SettingsForm_BackupRestoreTxt;
            // 
            // BackupSettingsBtn
            // 
            BackupSettingsBtn.FlatStyle = FlatStyle.System;
            BackupSettingsBtn.Location = new Point(34, 53);
            BackupSettingsBtn.Name = "BackupSettingsBtn";
            BackupSettingsBtn.Size = new Size(146, 23);
            BackupSettingsBtn.TabIndex = 9;
            BackupSettingsBtn.Text = Resources.Settings_BackupSettings;
            BackupSettingsBtn.UseVisualStyleBackColor = true;
            BackupSettingsBtn.Click += BackupSettingsBtn_Click;
            // 
            // RestoreSettingsBtn
            // 
            RestoreSettingsBtn.FlatStyle = FlatStyle.System;
            RestoreSettingsBtn.Location = new Point(186, 53);
            RestoreSettingsBtn.Name = "RestoreSettingsBtn";
            RestoreSettingsBtn.Size = new Size(146, 23);
            RestoreSettingsBtn.TabIndex = 10;
            RestoreSettingsBtn.Text = Resources.RestoreSettings;
            RestoreSettingsBtn.UseVisualStyleBackColor = true;
            RestoreSettingsBtn.Click += RestoreSettingsBtn_Click;
            // 
            // AuthGrp
            // 
            AuthGrp.Controls.Add(NotionKeyLbl);
            AuthGrp.Controls.Add(NotionKeyTxt);
            AuthGrp.Controls.Add(NotionKeyTestBtn);
            AuthGrp.Controls.Add(NotionKeyLst);
            AuthGrp.Controls.Add(NotionKeyMsgLbl);
            AuthGrp.Location = new Point(6, 6);
            AuthGrp.Name = "AuthGrp";
            AuthGrp.Size = new Size(364, 150);
            AuthGrp.TabIndex = 11;
            AuthGrp.TabStop = false;
            AuthGrp.Text = Resources.Settings_Authorization;
            // 
            // NotionKeyTestBtn
            // 
            NotionKeyTestBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NotionKeyTestBtn.FlatStyle = FlatStyle.System;
            NotionKeyTestBtn.Location = new Point(283, 22);
            NotionKeyTestBtn.Name = "NotionKeyTestBtn";
            NotionKeyTestBtn.Size = new Size(75, 23);
            NotionKeyTestBtn.TabIndex = 6;
            NotionKeyTestBtn.Text = Resources.SettingsForm_Test;
            NotionKeyTestBtn.UseVisualStyleBackColor = true;
            NotionKeyTestBtn.Click += NotionKeyTestBtn_Click;
            // 
            // NotionKeyLst
            // 
            NotionKeyLst.Columns.AddRange(new ColumnHeader[] { PermissionHdr });
            NotionKeyLst.FullRowSelect = true;
            NotionKeyLst.HeaderStyle = ColumnHeaderStyle.None;
            NotionKeyLst.HideSelection = true;
            NotionKeyLst.Items.AddRange(new ListViewItem[] { listViewItem1 });
            NotionKeyLst.Location = new Point(6, 82);
            NotionKeyLst.MultiSelect = false;
            NotionKeyLst.Name = "NotionKeyLst";
            NotionKeyLst.Size = new Size(352, 61);
            NotionKeyLst.TabIndex = 7;
            NotionKeyLst.TileSize = new Size(228, 16);
            NotionKeyLst.UseCompatibleStateImageBehavior = false;
            NotionKeyLst.View = View.Tile;
            NotionKeyLst.ItemSelectionChanged += NotionKeyLst_ItemSelectionChanged;
            // 
            // PermissionHdr
            // 
            PermissionHdr.Text = Resources.SettingsForm_Permission;
            // 
            // NotionKeyMsgLbl
            // 
            NotionKeyMsgLbl.Location = new Point(6, 48);
            NotionKeyMsgLbl.Name = "NotionKeyMsgLbl";
            NotionKeyMsgLbl.Size = new Size(352, 31);
            NotionKeyMsgLbl.TabIndex = 8;
            NotionKeyMsgLbl.Text = Resources.SettingsForm_NotionKeyTxt;
            // 
            // InputTabPage
            // 
            InputTabPage.Controls.Add(checkedListBox1);
            InputTabPage.Controls.Add(checkBox1);
            InputTabPage.Controls.Add(label1);
            InputTabPage.Location = new Point(4, 24);
            InputTabPage.Name = "InputTabPage";
            InputTabPage.Padding = new Padding(3);
            InputTabPage.Size = new Size(376, 424);
            InputTabPage.TabIndex = 1;
            InputTabPage.Text = Resources.Input;
            InputTabPage.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] {Resources.Name, Resources.ID, Resources.Type });
            checkedListBox1.Location = new Point(6, 29);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(360, 94);
            checkedListBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(6, 129);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 20);
            checkBox1.TabIndex = 2;
            checkBox1.Text = Resources.SettingsForm_LoadIcons;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = Resources.Settings_ColumnsLbl;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(404, 501);
            Controls.Add(TabControl);
            Controls.Add(OkBtn);
            Controls.Add(CancelBtn);
            Controls.Add(ApplyBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Padding = new Padding(7);
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = Resources.SettingsForm_Title;
            Load += SettingsForm_Load;
            TabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            LanguageGrp.ResumeLayout(false);
            LanguageGrp.PerformLayout();
            ThemeGroup.ResumeLayout(false);
            ThemeGroup.PerformLayout();
            BackupGrp.ResumeLayout(false);
            AuthGrp.ResumeLayout(false);
            AuthGrp.PerformLayout();
            InputTabPage.ResumeLayout(false);
            InputTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label NotionKeyLbl;
        private Button ApplyBtn;
        private TextBox NotionKeyTxt;
        private Button CancelBtn;
        private Button OkBtn;
        private TabControl TabControl;
        private TabPage GeneralTabPage;
        private Button NotionKeyTestBtn;
        private ListView NotionKeyLst;
        private ColumnHeader PermissionHdr;
        private Label NotionKeyMsgLbl;
        private TabPage InputTabPage;
        private Label label1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private Button RestoreSettingsBtn;
        private Button BackupSettingsBtn;
        private GroupBox AuthGrp;
        private GroupBox BackupGrp;
        private Label BackupRestoreLbl;
        private RadioButton ThemeDarkRad;
        private RadioButton ThemeLightRad;
        private RadioButton ThemeFollowsSystemRad;
        private GroupBox ThemeGroup;
        private ComboBox LanguageCombo;
        private GroupBox LanguageGrp;
        private CheckBox SystemLanguageChk;
    }
}