using NotionExporter.Properties;

namespace NotionExporter.UI.Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            ApplyBtn = new Button();
            CancelBtn = new Button();
            OkBtn = new Button();
            TabControl = new TabControl();
            GeneralTabPage = new TabPage();
            generalTab1 = new GeneralTab();
            InputTabPage = new TabPage();
            inputTab1 = new InputTab();
            ModulesTabPage = new TabPage();
            modulesTab1 = new ModulesTab();
            DebugTabPage = new TabPage();
            debugTab1 = new DebugTab();
            TabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            InputTabPage.SuspendLayout();
            ModulesTabPage.SuspendLayout();
            DebugTabPage.SuspendLayout();
            SuspendLayout();
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
            TabControl.Controls.Add(ModulesTabPage);
            TabControl.Controls.Add(DebugTabPage);
            TabControl.Location = new Point(10, 10);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(384, 452);
            TabControl.TabIndex = 8;
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.Controls.Add(generalTab1);
            GeneralTabPage.Location = new Point(4, 24);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new Padding(3);
            GeneralTabPage.Size = new Size(376, 424);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = Resources.Settings_General;
            GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // generalTab1
            // 
            generalTab1.Location = new Point(0, 0);
            generalTab1.Name = "generalTab1";
            generalTab1.Padding = new Padding(3);
            generalTab1.Size = new Size(384, 428);
            generalTab1.TabIndex = 0;
            // 
            // InputTabPage
            // 
            InputTabPage.Controls.Add(inputTab1);
            InputTabPage.Location = new Point(4, 24);
            InputTabPage.Name = "InputTabPage";
            InputTabPage.Padding = new Padding(3);
            InputTabPage.Size = new Size(376, 424);
            InputTabPage.TabIndex = 1;
            InputTabPage.Text = Resources.Input;
            InputTabPage.UseVisualStyleBackColor = true;
            // 
            // inputTab1
            // 
            inputTab1.Location = new Point(0, 0);
            inputTab1.Name = "inputTab1";
            inputTab1.Padding = new Padding(3);
            inputTab1.Size = new Size(376, 424);
            inputTab1.TabIndex = 0;
            // 
            // ModulesTabPage
            // 
            ModulesTabPage.Controls.Add(modulesTab1);
            ModulesTabPage.Location = new Point(4, 24);
            ModulesTabPage.Name = "ModulesTabPage";
            ModulesTabPage.Size = new Size(376, 424);
            ModulesTabPage.TabIndex = 2;
            ModulesTabPage.Text = "Modules";
            ModulesTabPage.UseVisualStyleBackColor = true;
            // 
            // modulesTab1
            // 
            modulesTab1.Location = new Point(0, 0);
            modulesTab1.Name = "modulesTab1";
            modulesTab1.Padding = new Padding(3);
            modulesTab1.Size = new Size(376, 424);
            modulesTab1.TabIndex = 0;
            // 
            // DebugTabPage
            // 
            DebugTabPage.Controls.Add(debugTab1);
            DebugTabPage.Location = new Point(4, 24);
            DebugTabPage.Name = "DebugTabPage";
            DebugTabPage.Padding = new Padding(3);
            DebugTabPage.Size = new Size(376, 424);
            DebugTabPage.TabIndex = 3;
            DebugTabPage.Text = "Debug";
            DebugTabPage.UseVisualStyleBackColor = true;
            // 
            // debugTab1
            // 
            debugTab1.Location = new Point(0, 0);
            debugTab1.Name = "debugTab1";
            debugTab1.Padding = new Padding(3);
            debugTab1.Size = new Size(380, 424);
            debugTab1.TabIndex = 3;
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
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += SettingsForm_Load;
            TabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            InputTabPage.ResumeLayout(false);
            ModulesTabPage.ResumeLayout(false);
            DebugTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button ApplyBtn;
        private Button CancelBtn;
        private Button OkBtn;
        private TabControl TabControl;
        private TabPage GeneralTabPage;
        private TabPage InputTabPage;
        private TabPage ModulesTabPage;
        private TabPage DebugTabPage;
        private UI.Settings.DebugTab debugTab1;
        private GeneralTab generalTab1;
        private InputTab inputTab1;
        private ModulesTab modulesTab1;
    }
}