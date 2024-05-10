namespace NotionExporter.UI.Settings
{
    partial class ModulesTab
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
            ModulesLst = new ListBox();
            ModuleSettingsBtn = new Button();
            ProcessesLbl = new Label();
            SuspendLayout();
            // 
            // ModulesLst
            // 
            ModulesLst.FormattingEnabled = true;
            ModulesLst.ItemHeight = 15;
            ModulesLst.Location = new Point(6, 6);
            ModulesLst.Name = "ModulesLst";
            ModulesLst.Size = new Size(364, 169);
            ModulesLst.TabIndex = 6;
            ModulesLst.SelectedIndexChanged += ModulesLst_SelectedIndexChanged;
            // 
            // ModuleSettingsBtn
            // 
            ModuleSettingsBtn.Enabled = false;
            ModuleSettingsBtn.FlatStyle = FlatStyle.System;
            ModuleSettingsBtn.Location = new Point(254, 395);
            ModuleSettingsBtn.Name = "ModuleSettingsBtn";
            ModuleSettingsBtn.Size = new Size(116, 23);
            ModuleSettingsBtn.TabIndex = 5;
            ModuleSettingsBtn.Text = "Module Settings...";
            ModuleSettingsBtn.UseVisualStyleBackColor = true;
            ModuleSettingsBtn.Click += ModuleSettingsBtn_Click;
            // 
            // ProcessesLbl
            // 
            ProcessesLbl.AutoSize = true;
            ProcessesLbl.Location = new Point(6, 187);
            ProcessesLbl.Name = "ProcessesLbl";
            ProcessesLbl.Size = new Size(61, 15);
            ProcessesLbl.TabIndex = 4;
            ProcessesLbl.Text = "Processes:";
            // 
            // ModulesTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ModulesLst);
            Controls.Add(ModuleSettingsBtn);
            Controls.Add(ProcessesLbl);
            Name = "ModulesTab";
            Padding = new Padding(3);
            Size = new Size(376, 424);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ModulesLst;
        private Button ModuleSettingsBtn;
        private Label ProcessesLbl;
    }
}
