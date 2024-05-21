using NotionExporter.Properties;

namespace NotionExporter.UI.ProfileManager
{
    partial class ExportProfileControls
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
            components = new System.ComponentModel.Container();
            IncludeModulesChk = new CheckBox();
            ToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // IncludeModulesChk
            // 
            IncludeModulesChk.AutoSize = true;
            IncludeModulesChk.FlatStyle = FlatStyle.System;
            IncludeModulesChk.Location = new Point(10, 10);
            IncludeModulesChk.Name = "IncludeModulesChk";
            IncludeModulesChk.Size = new Size(120, 20);
            IncludeModulesChk.TabIndex = 0;
            IncludeModulesChk.Text = Resources.ExportProfileControls_IncludeModules;
            ToolTip.SetToolTip(IncludeModulesChk, Resources.ExportProfileControls_IncludeModulesTooltip);
            IncludeModulesChk.UseVisualStyleBackColor = true;
            // 
            // ExportProfileControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IncludeModulesChk);
            Name = "ExportProfileControls";
            Padding = new Padding(7);
            Size = new Size(349, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox IncludeModulesChk;
        private ToolTip ToolTip;
    }
}
