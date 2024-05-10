using NotionExporter.Properties;

namespace NotionExporter.UI.Settings
{
    partial class GeneralTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Click Test to view results" }, -1, SystemColors.GrayText, Color.Empty, null);
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
            NotionKeyLbl = new Label();
            NotionKeyTxt = new TextBox();
            NotionKeyTestBtn = new Button();
            NotionKeyLst = new ListView();
            PermissionHdr = new ColumnHeader();
            NotionKeyMsgLbl = new Label();
            LanguageGrp.SuspendLayout();
            ThemeGroup.SuspendLayout();
            BackupGrp.SuspendLayout();
            AuthGrp.SuspendLayout();
            SuspendLayout();
            // 
            // LanguageGrp
            // 
            LanguageGrp.Controls.Add(SystemLanguageChk);
            LanguageGrp.Controls.Add(LanguageCombo);
            LanguageGrp.Location = new Point(6, 311);
            LanguageGrp.Name = "LanguageGrp";
            LanguageGrp.Size = new Size(364, 100);
            LanguageGrp.TabIndex = 23;
            LanguageGrp.TabStop = false;
            LanguageGrp.Text = "Language";
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
            ThemeGroup.TabIndex = 22;
            ThemeGroup.TabStop = false;
            ThemeGroup.Text = "Theme";
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
            BackupGrp.TabIndex = 21;
            BackupGrp.TabStop = false;
            BackupGrp.Text = "Backup and Restore";
            // 
            // BackupRestoreLbl
            // 
            BackupRestoreLbl.Location = new Point(6, 19);
            BackupRestoreLbl.Name = "BackupRestoreLbl";
            BackupRestoreLbl.Size = new Size(352, 31);
            BackupRestoreLbl.TabIndex = 11;
            BackupRestoreLbl.Text = "Note: The backup file will contain sensitive information such as your Notion key.";
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
            AuthGrp.TabIndex = 20;
            AuthGrp.TabStop = false;
            AuthGrp.Text = "Authorization";
            // 
            // NotionKeyLbl
            // 
            NotionKeyLbl.AutoSize = true;
            NotionKeyLbl.Location = new Point(6, 25);
            NotionKeyLbl.Name = "NotionKeyLbl";
            NotionKeyLbl.Size = new Size(72, 15);
            NotionKeyLbl.TabIndex = 5;
            NotionKeyLbl.Text = "Notion Key: ";
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
            // NotionKeyTestBtn
            // 
            NotionKeyTestBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NotionKeyTestBtn.FlatStyle = FlatStyle.System;
            NotionKeyTestBtn.Location = new Point(283, 21);
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
            NotionKeyMsgLbl.Text = "The integration must have the Read Content, Read Comments, and Read User Information permissions.";
            // 
            // GeneralTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LanguageGrp);
            Controls.Add(ThemeGroup);
            Controls.Add(BackupGrp);
            Controls.Add(AuthGrp);
            Name = "GeneralTab";
            Padding = new Padding(3);
            Size = new Size(376, 424);
            Load += GeneralTab_Load;
            LanguageGrp.ResumeLayout(false);
            LanguageGrp.PerformLayout();
            ThemeGroup.ResumeLayout(false);
            ThemeGroup.PerformLayout();
            BackupGrp.ResumeLayout(false);
            AuthGrp.ResumeLayout(false);
            AuthGrp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LanguageGrp;
        private CheckBox SystemLanguageChk;
        private ComboBox LanguageCombo;
        private GroupBox ThemeGroup;
        private RadioButton ThemeFollowsSystemRad;
        private RadioButton ThemeDarkRad;
        private RadioButton ThemeLightRad;
        private GroupBox BackupGrp;
        private Label BackupRestoreLbl;
        private Button BackupSettingsBtn;
        private Button RestoreSettingsBtn;
        private GroupBox AuthGrp;
        private Label NotionKeyLbl;
        private TextBox NotionKeyTxt;
        private Button NotionKeyTestBtn;
        private ListView NotionKeyLst;
        private ColumnHeader PermissionHdr;
        private Label NotionKeyMsgLbl;
    }
}
