using NotionExporter.Properties;

namespace NotionExporter.UI.Settings
{
    partial class InputTab
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
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { Resources.Name, Resources.ID, Resources.Type });
            checkedListBox1.Location = new Point(6, 21);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(364, 94);
            checkedListBox1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(6, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 20);
            checkBox1.TabIndex = 5;
            checkBox1.Text = Resources.SettingsForm_LoadIcons;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Columns: ";
            // 
            // InputTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "InputTab";
            Padding = new Padding(3);
            Size = new Size(376, 424);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Label label1;
    }
}
