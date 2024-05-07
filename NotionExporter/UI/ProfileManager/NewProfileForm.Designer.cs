using NotionExporter.Properties;

namespace NotionExporter.UI.ProfileManager
{
    partial class NewProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfileForm));
            NameLbl = new Label();
            NameTxt = new TextBox();
            OkBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(12, 15);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(42, 15);
            NameLbl.TabIndex = 0;
            NameLbl.Text = Resources.NameLbl;
            // 
            // NameTxt
            // 
            NameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTxt.Location = new Point(60, 12);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(286, 23);
            NameTxt.TabIndex = 1;
            // 
            // OkBtn
            // 
            OkBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkBtn.Location = new Point(271, 54);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(75, 23);
            OkBtn.TabIndex = 2;
            OkBtn.Text = Resources.Form_OKBtn;
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.Location = new Point(190, 54);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = Resources.Form_CancelBtn;
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // NewProfileForm
            // 
            AcceptButton = OkBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(358, 89);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewProfileForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = Resources.NewProfileForm_Title;
            Load += NewProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox NameTxt;
        private Button OkBtn;
        private Button CancelBtn;
    }
}