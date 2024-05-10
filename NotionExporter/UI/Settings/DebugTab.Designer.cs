namespace NotionExporter.UI.Settings
{
    partial class DebugTab
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
            LogLevelCombo = new ComboBox();
            LogLevelLbl = new Label();
            OpenLogBtn = new Button();
            SuspendLayout();
            // 
            // LogLevelCombo
            // 
            LogLevelCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            LogLevelCombo.FlatStyle = FlatStyle.System;
            LogLevelCombo.FormattingEnabled = true;
            LogLevelCombo.Items.AddRange(new object[] { "Verbose", "Debug", "Information", "Warning", "Error", "Fatal" });
            LogLevelCombo.Location = new Point(81, 44);
            LogLevelCombo.Name = "LogLevelCombo";
            LogLevelCombo.Size = new Size(121, 23);
            LogLevelCombo.TabIndex = 5;
            // 
            // LogLevelLbl
            // 
            LogLevelLbl.AutoSize = true;
            LogLevelLbl.Location = new Point(6, 47);
            LogLevelLbl.Name = "LogLevelLbl";
            LogLevelLbl.Size = new Size(60, 15);
            LogLevelLbl.TabIndex = 4;
            LogLevelLbl.Text = "Log Level:";
            // 
            // OpenLogBtn
            // 
            OpenLogBtn.FlatStyle = FlatStyle.System;
            OpenLogBtn.Location = new Point(6, 6);
            OpenLogBtn.Name = "OpenLogBtn";
            OpenLogBtn.Size = new Size(121, 23);
            OpenLogBtn.TabIndex = 3;
            OpenLogBtn.Text = "Open Log...";
            OpenLogBtn.UseVisualStyleBackColor = true;
            OpenLogBtn.Click += OpenLogBtn_Click;
            // 
            // DebugTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LogLevelCombo);
            Controls.Add(LogLevelLbl);
            Controls.Add(OpenLogBtn);
            Name = "DebugTab";
            Padding = new Padding(3);
            Size = new Size(376, 424);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LogLevelCombo;
        private Label LogLevelLbl;
        private Button OpenLogBtn;
    }
}
