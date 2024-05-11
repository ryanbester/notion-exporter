using NotionExporter.Properties;
using NotionExporter.UI.Controls;

namespace NotionExporter.UI
{
    partial class NotionExporter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotionExporter));
            MainTabControl = new TabControl();
            InputTab = new TabPage();
            inputTab1 = new InputTab();
            tabPage2 = new TabPage();
            InputLstMenu = new ContextMenuStrip(components);
            SizeColumnsInputLstMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            nameToolStripMenuItem = new ToolStripMenuItem();
            typeToolStripMenuItem = new ToolStripMenuItem();
            createdTimeToolStripMenuItem = new ToolStripMenuItem();
            createdByToolStripMenuItem = new ToolStripMenuItem();
            lastEditedTimeToolStripMenuItem = new ToolStripMenuItem();
            lastEditedByToolStripMenuItem = new ToolStripMenuItem();
            descriptionToolStripMenuItem = new ToolStripMenuItem();
            uRLToolStripMenuItem = new ToolStripMenuItem();
            archivedToolStripMenuItem = new ToolStripMenuItem();
            parentToolStripMenuItem = new ToolStripMenuItem();
            iDToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            EditColumnsInputLstMenu = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ProfileLbl = new Label();
            ProfilesCombo = new ComboBox();
            button1 = new Button();
            ProfileManagerBtn = new Button();
            SettingsBtn = new Button();
            AboutBtn = new Button();
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            InputLeftLst = new CustomListView();
            LeftNameHdr = new ColumnHeader();
            LeftTypeHdr = new ColumnHeader();
            RightFlowLayout = new FlowLayoutPanel();
            LeftFlowLayout = new FlowLayoutPanel();
            MainTabControl.SuspendLayout();
            InputTab.SuspendLayout();
            InputLstMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            RightFlowLayout.SuspendLayout();
            LeftFlowLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(InputTab);
            MainTabControl.Controls.Add(tabPage2);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1068, 687);
            MainTabControl.TabIndex = 6;
            // 
            // InputTab
            // 
            InputTab.Controls.Add(inputTab1);
            InputTab.Location = new Point(4, 24);
            InputTab.Name = "InputTab";
            InputTab.Padding = new Padding(3);
            InputTab.Size = new Size(1060, 659);
            InputTab.TabIndex = 0;
            InputTab.Text = Resources.Input;
            InputTab.UseVisualStyleBackColor = true;
            // 
            // inputTab1
            // 
            inputTab1.Dock = DockStyle.Fill;
            inputTab1.Location = new Point(3, 3);
            inputTab1.Name = "inputTab1";
            inputTab1.Size = new Size(1054, 653);
            inputTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1060, 659);
            tabPage2.TabIndex = 1;
            tabPage2.Text = Resources.PDF;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // InputLstMenu
            // 
            InputLstMenu.Items.AddRange(new ToolStripItem[] { SizeColumnsInputLstMenu, toolStripMenuItem1, nameToolStripMenuItem, typeToolStripMenuItem, createdTimeToolStripMenuItem, createdByToolStripMenuItem, lastEditedTimeToolStripMenuItem, lastEditedByToolStripMenuItem, descriptionToolStripMenuItem, uRLToolStripMenuItem, archivedToolStripMenuItem, parentToolStripMenuItem, iDToolStripMenuItem, toolStripMenuItem2, EditColumnsInputLstMenu });
            InputLstMenu.Name = "contextMenuStrip1";
            InputLstMenu.RenderMode = ToolStripRenderMode.System;
            InputLstMenu.Size = new Size(193, 302);
            // 
            // SizeColumnsInputLstMenu
            // 
            SizeColumnsInputLstMenu.Name = "SizeColumnsInputLstMenu";
            SizeColumnsInputLstMenu.Size = new Size(192, 22);
            SizeColumnsInputLstMenu.Text = Resources.SizeAllColumnsToFit;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 6);
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Checked = true;
            nameToolStripMenuItem.CheckState = CheckState.Checked;
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(192, 22);
            nameToolStripMenuItem.Text = Resources.Name;
            // 
            // typeToolStripMenuItem
            // 
            typeToolStripMenuItem.Checked = true;
            typeToolStripMenuItem.CheckState = CheckState.Checked;
            typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            typeToolStripMenuItem.Size = new Size(192, 22);
            typeToolStripMenuItem.Text = Resources.Type;
            // 
            // createdTimeToolStripMenuItem
            // 
            createdTimeToolStripMenuItem.Name = "createdTimeToolStripMenuItem";
            createdTimeToolStripMenuItem.Size = new Size(192, 22);
            createdTimeToolStripMenuItem.Text = Resources.CreatedTime;
            // 
            // createdByToolStripMenuItem
            // 
            createdByToolStripMenuItem.Name = "createdByToolStripMenuItem";
            createdByToolStripMenuItem.Size = new Size(192, 22);
            createdByToolStripMenuItem.Text = Resources.CreatedBy;
            // 
            // lastEditedTimeToolStripMenuItem
            // 
            lastEditedTimeToolStripMenuItem.Name = "lastEditedTimeToolStripMenuItem";
            lastEditedTimeToolStripMenuItem.Size = new Size(192, 22);
            lastEditedTimeToolStripMenuItem.Text = Resources.LastEditedTime;
            // 
            // lastEditedByToolStripMenuItem
            // 
            lastEditedByToolStripMenuItem.Name = "lastEditedByToolStripMenuItem";
            lastEditedByToolStripMenuItem.Size = new Size(192, 22);
            lastEditedByToolStripMenuItem.Text = Resources.LastEditedBy;
            // 
            // descriptionToolStripMenuItem
            // 
            descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            descriptionToolStripMenuItem.Size = new Size(192, 22);
            descriptionToolStripMenuItem.Text = Resources.Description;
            // 
            // uRLToolStripMenuItem
            // 
            uRLToolStripMenuItem.Name = "uRLToolStripMenuItem";
            uRLToolStripMenuItem.Size = new Size(192, 22);
            uRLToolStripMenuItem.Text = Resources.URL;
            // 
            // archivedToolStripMenuItem
            // 
            archivedToolStripMenuItem.Name = "archivedToolStripMenuItem";
            archivedToolStripMenuItem.Size = new Size(192, 22);
            archivedToolStripMenuItem.Text = Resources.Archived;
            // 
            // parentToolStripMenuItem
            // 
            parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            parentToolStripMenuItem.Size = new Size(192, 22);
            parentToolStripMenuItem.Text = Resources.Parent;
            // 
            // iDToolStripMenuItem
            // 
            iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            iDToolStripMenuItem.Size = new Size(192, 22);
            iDToolStripMenuItem.Text = Resources.ID;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(189, 6);
            // 
            // EditColumnsInputLstMenu
            // 
            EditColumnsInputLstMenu.Name = "EditColumnsInputLstMenu";
            EditColumnsInputLstMenu.Size = new Size(192, 22);
            EditColumnsInputLstMenu.Text = Resources.EditColumns;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 731);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1569, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = Resources.Ready;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1413, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // ProfileLbl
            // 
            ProfileLbl.AutoSize = true;
            ProfileLbl.Location = new Point(0, 0);
            ProfileLbl.Margin = new Padding(0);
            ProfileLbl.MinimumSize = new Size(0, 30);
            ProfileLbl.Name = "ProfileLbl";
            ProfileLbl.Size = new Size(47, 30);
            ProfileLbl.TabIndex = 8;
            ProfileLbl.Text = Resources.ProfileLbl;
            ProfileLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProfilesCombo
            // 
            ProfilesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfilesCombo.FlatStyle = FlatStyle.System;
            ProfilesCombo.FormattingEnabled = true;
            ProfilesCombo.Location = new Point(50, 3);
            ProfilesCombo.Name = "ProfilesCombo";
            ProfilesCombo.Size = new Size(188, 23);
            ProfilesCombo.TabIndex = 9;
            ProfilesCombo.SelectionChangeCommitted += ProfilesCombo_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(244, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 10;
            button1.Text = Resources.Save;
            button1.UseVisualStyleBackColor = true;
            // 
            // ProfileManagerBtn
            // 
            ProfileManagerBtn.AutoSize = true;
            ProfileManagerBtn.FlatStyle = FlatStyle.System;
            ProfileManagerBtn.Location = new Point(325, 3);
            ProfileManagerBtn.Name = "ProfileManagerBtn";
            ProfileManagerBtn.Size = new Size(145, 24);
            ProfileManagerBtn.TabIndex = 11;
            ProfileManagerBtn.Text = Resources.ProfileManagerBtn;
            ProfileManagerBtn.UseVisualStyleBackColor = true;
            ProfileManagerBtn.Click += ProfileManagerBtn_Click;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SettingsBtn.AutoSize = true;
            SettingsBtn.FlatStyle = FlatStyle.System;
            SettingsBtn.Location = new Point(84, 3);
            SettingsBtn.Margin = new Padding(3, 3, 0, 3);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(75, 24);
            SettingsBtn.TabIndex = 12;
            SettingsBtn.Text = Resources.SettingsBtn;
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // AboutBtn
            // 
            AboutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AboutBtn.AutoSize = true;
            AboutBtn.FlatStyle = FlatStyle.System;
            AboutBtn.Location = new Point(3, 3);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(75, 24);
            AboutBtn.TabIndex = 13;
            AboutBtn.Text = Resources.About;
            AboutBtn.UseVisualStyleBackColor = true;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 41);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(MainTabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(InputLeftLst);
            splitContainer1.Size = new Size(1545, 687);
            splitContainer1.SplitterDistance = 1068;
            splitContainer1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(314, 661);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = Resources.Clear;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(395, 661);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = Resources.ExportAll;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = Resources.ExportQueue;
            // 
            // InputLeftLst
            // 
            InputLeftLst.AllowColumnReorder = true;
            InputLeftLst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputLeftLst.Columns.AddRange(new ColumnHeader[] { LeftNameHdr, LeftTypeHdr });
            InputLeftLst.FullRowSelect = true;
            InputLeftLst.GridLines = true;
            InputLeftLst.Location = new Point(2, 24);
            InputLeftLst.Name = "InputLeftLst";
            InputLeftLst.Size = new Size(470, 607);
            InputLeftLst.TabIndex = 4;
            InputLeftLst.UseCompatibleStateImageBehavior = false;
            InputLeftLst.View = View.Details;
            // 
            // LeftNameHdr
            // 
            LeftNameHdr.Text = Resources.Name;
            // 
            // LeftTypeHdr
            // 
            LeftTypeHdr.Text = Resources.Type;
            // 
            // RightFlowLayout
            // 
            RightFlowLayout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RightFlowLayout.AutoSize = true;
            RightFlowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightFlowLayout.Controls.Add(SettingsBtn);
            RightFlowLayout.Controls.Add(AboutBtn);
            RightFlowLayout.FlowDirection = FlowDirection.RightToLeft;
            RightFlowLayout.Location = new Point(1395, 5);
            RightFlowLayout.Margin = new Padding(0);
            RightFlowLayout.Name = "RightFlowLayout";
            RightFlowLayout.Size = new Size(159, 30);
            RightFlowLayout.TabIndex = 15;
            // 
            // LeftFlowLayout
            // 
            LeftFlowLayout.AutoSize = true;
            LeftFlowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LeftFlowLayout.Controls.Add(ProfileLbl);
            LeftFlowLayout.Controls.Add(ProfilesCombo);
            LeftFlowLayout.Controls.Add(button1);
            LeftFlowLayout.Controls.Add(ProfileManagerBtn);
            LeftFlowLayout.Location = new Point(12, 5);
            LeftFlowLayout.Margin = new Padding(0);
            LeftFlowLayout.Name = "LeftFlowLayout";
            LeftFlowLayout.Size = new Size(473, 30);
            LeftFlowLayout.TabIndex = 16;
            // 
            // NotionExporter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 753);
            Controls.Add(LeftFlowLayout);
            Controls.Add(RightFlowLayout);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NotionExporter";
            RightToLeftLayout = true;
            Text = Resources.NotionExporter;
            Load += NotionExporter_Load;
            MainTabControl.ResumeLayout(false);
            InputTab.ResumeLayout(false);
            InputLstMenu.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            RightFlowLayout.ResumeLayout(false);
            RightFlowLayout.PerformLayout();
            LeftFlowLayout.ResumeLayout(false);
            LeftFlowLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl MainTabControl;
        private TabPage InputTab;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label ProfileLbl;
        private ComboBox ProfilesCombo;
        private Button button1;
        private Button ProfileManagerBtn;
        private Button SettingsBtn;
        private Button AboutBtn;
        private ContextMenuStrip InputLstMenu;
        private ToolStripMenuItem SizeColumnsInputLstMenu;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem nameToolStripMenuItem;
        private ToolStripMenuItem typeToolStripMenuItem;
        private ToolStripMenuItem createdTimeToolStripMenuItem;
        private ToolStripMenuItem createdByToolStripMenuItem;
        private ToolStripMenuItem lastEditedTimeToolStripMenuItem;
        private ToolStripMenuItem lastEditedByToolStripMenuItem;
        private ToolStripMenuItem descriptionToolStripMenuItem;
        private ToolStripMenuItem uRLToolStripMenuItem;
        private ToolStripMenuItem archivedToolStripMenuItem;
        private ToolStripMenuItem parentToolStripMenuItem;
        private ToolStripMenuItem iDToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem EditColumnsInputLstMenu;
        private InputTab inputTab1;
        private SplitContainer splitContainer1;
        private Label label2;
        private CustomListView InputLeftLst;
        private ColumnHeader LeftNameHdr;
        private ColumnHeader LeftTypeHdr;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel RightFlowLayout;
        private FlowLayoutPanel LeftFlowLayout;
    }
}