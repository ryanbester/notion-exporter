using NotionExporter.Properties;

namespace NotionExporter.UI.ProfileManager
{
    partial class ProfileManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileManagerForm));
            ProfilesLst = new ListBox();
            NewBtn = new Button();
            DuplicateBtn = new Button();
            RenameBtn = new Button();
            DeleteBtn = new Button();
            SetDefaultBtn = new Button();
            ActivateBtn = new Button();
            ImportBtn = new Button();
            ExportBtn = new Button();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // ProfilesLst
            // 
            ProfilesLst.FormattingEnabled = true;
            ProfilesLst.ItemHeight = 15;
            ProfilesLst.Location = new Point(10, 10);
            ProfilesLst.Name = "ProfilesLst";
            ProfilesLst.Size = new Size(355, 199);
            ProfilesLst.TabIndex = 0;
            ProfilesLst.SelectedIndexChanged += ProfilesLst_SelectedIndexChanged;
            ProfilesLst.MouseDoubleClick += ProfilesLst_MouseDoubleClick;
            // 
            // NewBtn
            // 
            NewBtn.FlatStyle = FlatStyle.System;
            NewBtn.Location = new Point(371, 10);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(75, 23);
            NewBtn.TabIndex = 1;
            NewBtn.Text = Resources.New;
            NewBtn.UseVisualStyleBackColor = true;
            NewBtn.Click += NewBtn_Click;
            // 
            // DuplicateBtn
            // 
            DuplicateBtn.FlatStyle = FlatStyle.System;
            DuplicateBtn.Location = new Point(452, 10);
            DuplicateBtn.Name = "DuplicateBtn";
            DuplicateBtn.Size = new Size(75, 23);
            DuplicateBtn.TabIndex = 2;
            DuplicateBtn.Text = Resources.ProfileManager_Duplicate;
            DuplicateBtn.UseVisualStyleBackColor = true;
            DuplicateBtn.Click += DuplicateBtn_Click;
            // 
            // RenameBtn
            // 
            RenameBtn.FlatStyle = FlatStyle.System;
            RenameBtn.Location = new Point(371, 39);
            RenameBtn.Name = "RenameBtn";
            RenameBtn.Size = new Size(75, 23);
            RenameBtn.TabIndex = 3;
            RenameBtn.Text = Resources.Rename;
            RenameBtn.UseVisualStyleBackColor = true;
            RenameBtn.Click += RenameBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.FlatStyle = FlatStyle.System;
            DeleteBtn.Location = new Point(452, 39);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = Resources.Delete;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SetDefaultBtn
            // 
            SetDefaultBtn.FlatStyle = FlatStyle.System;
            SetDefaultBtn.Location = new Point(371, 68);
            SetDefaultBtn.Name = "SetDefaultBtn";
            SetDefaultBtn.Size = new Size(75, 23);
            SetDefaultBtn.TabIndex = 5;
            SetDefaultBtn.Text = Resources.SetDefault;
            SetDefaultBtn.UseVisualStyleBackColor = true;
            SetDefaultBtn.Click += SetDefaultBtn_Click;
            // 
            // ActivateBtn
            // 
            ActivateBtn.FlatStyle = FlatStyle.System;
            ActivateBtn.Location = new Point(371, 186);
            ActivateBtn.Name = "ActivateBtn";
            ActivateBtn.Size = new Size(75, 23);
            ActivateBtn.TabIndex = 6;
            ActivateBtn.Text =Resources.ProfileManager_Activate;
            ActivateBtn.UseVisualStyleBackColor = true;
            ActivateBtn.Click += ActivateBtn_Click;
            // 
            // ImportBtn
            // 
            ImportBtn.FlatStyle = FlatStyle.System;
            ImportBtn.Location = new Point(371, 127);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(75, 23);
            ImportBtn.TabIndex = 7;
            ImportBtn.Text = Resources.Import;
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.FlatStyle = FlatStyle.System;
            ExportBtn.Location = new Point(452, 127);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(75, 23);
            ExportBtn.TabIndex = 8;
            ExportBtn.Text = Resources.Export;
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.FlatStyle = FlatStyle.System;
            CloseBtn.Location = new Point(452, 186);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 9;
            CloseBtn.Text = Resources.Form_CloseBtn;
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // ProfileManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 221);
            Controls.Add(CloseBtn);
            Controls.Add(ExportBtn);
            Controls.Add(ImportBtn);
            Controls.Add(ActivateBtn);
            Controls.Add(SetDefaultBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(RenameBtn);
            Controls.Add(DuplicateBtn);
            Controls.Add(NewBtn);
            Controls.Add(ProfilesLst);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileManagerForm";
            Padding = new Padding(7);
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = Resources.ProfileManager;
            Load += ProfileManagerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ProfilesLst;
        private Button NewBtn;
        private Button DuplicateBtn;
        private Button RenameBtn;
        private Button DeleteBtn;
        private Button SetDefaultBtn;
        private Button ActivateBtn;
        private Button ImportBtn;
        private Button ExportBtn;
        private Button CloseBtn;
    }
}