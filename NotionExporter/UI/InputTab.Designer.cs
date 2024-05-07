using NotionExporter.Properties;
using NotionExporter.UI.Controls;

namespace NotionExporter.UI
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
            components = new System.ComponentModel.Container();
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
            InputRightPanel = new Panel();
            button1 = new Button();
            InputRightLst = new ListView();
            RightNameHdr = new ColumnHeader();
            RightTypeHdr = new ColumnHeader();
            InputCenterTable = new TableLayoutPanel();
            InputCenterPanel = new Panel();
            MoveDownBtn = new Button();
            MoveUpBtn = new Button();
            RemoveBtn = new Button();
            AddBtn = new Button();
            InputLeftPanel = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SaveSelProfileChk = new CheckBox();
            QueryLbl = new Label();
            QueryTxt = new TextBox();
            InputLeftLst = new CustomListView();
            LeftNameHdr = new ColumnHeader();
            LeftTypeHdr = new ColumnHeader();
            SearchBtn = new Button();
            InputTable = new TableLayoutPanel();
            InputLstMenu.SuspendLayout();
            InputRightPanel.SuspendLayout();
            InputCenterTable.SuspendLayout();
            InputCenterPanel.SuspendLayout();
            InputLeftPanel.SuspendLayout();
            InputTable.SuspendLayout();
            SuspendLayout();
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
            SizeColumnsInputLstMenu.Click += SizeColumnsInputLstMenu_Click;
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
            EditColumnsInputLstMenu.Click += EditColumnsInputLstMenu_Click;
            // 
            // InputRightPanel
            // 
            InputRightPanel.Controls.Add(button1);
            InputRightPanel.Controls.Add(InputRightLst);
            InputRightPanel.Dock = DockStyle.Fill;
            InputRightPanel.Location = new Point(521, 3);
            InputRightPanel.Name = "InputRightPanel";
            InputRightPanel.Size = new Size(388, 495);
            InputRightPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(4, 459);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = Resources.Properties;
            button1.UseVisualStyleBackColor = true;
            // 
            // InputRightLst
            // 
            InputRightLst.AllowColumnReorder = true;
            InputRightLst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputRightLst.Columns.AddRange(new ColumnHeader[] { RightNameHdr, RightTypeHdr });
            InputRightLst.FullRowSelect = true;
            InputRightLst.GridLines = true;
            InputRightLst.Location = new Point(4, 62);
            InputRightLst.Name = "InputRightLst";
            InputRightLst.Size = new Size(384, 391);
            InputRightLst.TabIndex = 4;
            InputRightLst.UseCompatibleStateImageBehavior = false;
            InputRightLst.View = View.Details;
            // 
            // RightNameHdr
            // 
            RightNameHdr.Text = Resources.Name;
            // 
            // RightTypeHdr
            // 
            RightTypeHdr.Text = Resources.Type;
            // 
            // InputCenterTable
            // 
            InputCenterTable.ColumnCount = 1;
            InputCenterTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            InputCenterTable.Controls.Add(InputCenterPanel, 0, 1);
            InputCenterTable.Dock = DockStyle.Fill;
            InputCenterTable.Location = new Point(396, 3);
            InputCenterTable.Name = "InputCenterTable";
            InputCenterTable.RowCount = 3;
            InputCenterTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            InputCenterTable.RowStyles.Add(new RowStyle());
            InputCenterTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            InputCenterTable.Size = new Size(119, 495);
            InputCenterTable.TabIndex = 2;
            // 
            // InputCenterPanel
            // 
            InputCenterPanel.AutoSize = true;
            InputCenterPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InputCenterPanel.Controls.Add(MoveDownBtn);
            InputCenterPanel.Controls.Add(MoveUpBtn);
            InputCenterPanel.Controls.Add(RemoveBtn);
            InputCenterPanel.Controls.Add(AddBtn);
            InputCenterPanel.Dock = DockStyle.Fill;
            InputCenterPanel.Location = new Point(3, 189);
            InputCenterPanel.Name = "InputCenterPanel";
            InputCenterPanel.Size = new Size(113, 116);
            InputCenterPanel.TabIndex = 1;
            // 
            // MoveDownBtn
            // 
            MoveDownBtn.FlatStyle = FlatStyle.System;
            MoveDownBtn.Location = new Point(3, 90);
            MoveDownBtn.Name = "MoveDownBtn";
            MoveDownBtn.Size = new Size(107, 23);
            MoveDownBtn.TabIndex = 3;
            MoveDownBtn.Text = Resources.MoveDown;
            MoveDownBtn.UseVisualStyleBackColor = true;
            // 
            // MoveUpBtn
            // 
            MoveUpBtn.FlatStyle = FlatStyle.System;
            MoveUpBtn.Location = new Point(3, 3);
            MoveUpBtn.Name = "MoveUpBtn";
            MoveUpBtn.Size = new Size(107, 23);
            MoveUpBtn.TabIndex = 2;
            MoveUpBtn.Text = Resources.MoveUp;
            MoveUpBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            RemoveBtn.FlatStyle = FlatStyle.System;
            RemoveBtn.Location = new Point(3, 61);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(107, 23);
            RemoveBtn.TabIndex = 1;
            RemoveBtn.Text = Resources.InputTab_RemoveBtn;
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.System;
            AddBtn.Location = new Point(3, 32);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(107, 23);
            AddBtn.TabIndex = 0;
            AddBtn.Text = Resources.InputTab_AddBtn;
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // InputLeftPanel
            // 
            InputLeftPanel.Controls.Add(checkBox2);
            InputLeftPanel.Controls.Add(checkBox1);
            InputLeftPanel.Controls.Add(comboBox1);
            InputLeftPanel.Controls.Add(label1);
            InputLeftPanel.Controls.Add(SaveSelProfileChk);
            InputLeftPanel.Controls.Add(QueryLbl);
            InputLeftPanel.Controls.Add(QueryTxt);
            InputLeftPanel.Controls.Add(InputLeftLst);
            InputLeftPanel.Controls.Add(SearchBtn);
            InputLeftPanel.Dock = DockStyle.Fill;
            InputLeftPanel.Location = new Point(3, 3);
            InputLeftPanel.Name = "InputLeftPanel";
            InputLeftPanel.Size = new Size(387, 495);
            InputLeftPanel.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(127, 109);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 20);
            checkBox2.TabIndex = 8;
            checkBox2.Text = Resources.Databases;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(58, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 20);
            checkBox1.TabIndex = 7;
            checkBox1.Text = Resources.Pages;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { Resources.Ascending, Resources.Descending });
            comboBox1.Location = new Point(58, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 83);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = Resources.SortLbl;
            // 
            // SaveSelProfileChk
            // 
            SaveSelProfileChk.AutoSize = true;
            SaveSelProfileChk.FlatStyle = FlatStyle.System;
            SaveSelProfileChk.Location = new Point(3, 3);
            SaveSelProfileChk.Name = "SaveSelProfileChk";
            SaveSelProfileChk.Size = new Size(156, 20);
            SaveSelProfileChk.TabIndex = 4;
            SaveSelProfileChk.Text = Resources.InputTab_SaveSelectionInProfile;
            SaveSelProfileChk.UseVisualStyleBackColor = true;
            // 
            // QueryLbl
            // 
            QueryLbl.AutoSize = true;
            QueryLbl.Location = new Point(10, 50);
            QueryLbl.Name = "QueryLbl";
            QueryLbl.Size = new Size(42, 15);
            QueryLbl.TabIndex = 0;
            QueryLbl.Text = Resources.QueryLbl;
            // 
            // QueryTxt
            // 
            QueryTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            QueryTxt.Location = new Point(58, 47);
            QueryTxt.Name = "QueryTxt";
            QueryTxt.Size = new Size(326, 23);
            QueryTxt.TabIndex = 1;
            // 
            // InputLeftLst
            // 
            InputLeftLst.AllowColumnReorder = true;
            InputLeftLst.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputLeftLst.Columns.AddRange(new ColumnHeader[] { LeftNameHdr, LeftTypeHdr });
            InputLeftLst.FullRowSelect = true;
            InputLeftLst.GridLines = true;
            InputLeftLst.Location = new Point(3, 147);
            InputLeftLst.Name = "InputLeftLst";
            InputLeftLst.Size = new Size(381, 345);
            InputLeftLst.TabIndex = 3;
            InputLeftLst.UseCompatibleStateImageBehavior = false;
            InputLeftLst.View = View.Details;
            InputLeftLst.ColumnHeaderRightClick += InputLeftLst_ColumnHeaderRightClick;
            // 
            // LeftNameHdr
            // 
            LeftNameHdr.Text = Resources.Name;
            // 
            // LeftTypeHdr
            // 
            LeftTypeHdr.Text = Resources.Type;
            // 
            // SearchBtn
            // 
            SearchBtn.FlatStyle = FlatStyle.System;
            SearchBtn.Location = new Point(309, 118);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = Resources.Search;
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // InputTable
            // 
            InputTable.ColumnCount = 3;
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            InputTable.Controls.Add(InputLeftPanel, 0, 0);
            InputTable.Controls.Add(InputCenterTable, 1, 0);
            InputTable.Controls.Add(InputRightPanel, 2, 0);
            InputTable.Dock = DockStyle.Fill;
            InputTable.Location = new Point(0, 0);
            InputTable.Name = "InputTable";
            InputTable.RowCount = 1;
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            InputTable.Size = new Size(912, 501);
            InputTable.TabIndex = 5;
            // 
            // InputTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InputTable);
            Name = "InputTab";
            Size = new Size(912, 501);
            Load += InputTab_Load;
            InputLstMenu.ResumeLayout(false);
            InputRightPanel.ResumeLayout(false);
            InputCenterTable.ResumeLayout(false);
            InputCenterTable.PerformLayout();
            InputCenterPanel.ResumeLayout(false);
            InputLeftPanel.ResumeLayout(false);
            InputLeftPanel.PerformLayout();
            InputTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
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
        private Panel panel2;
        private Panel InputRightPanel;
        private ListView InputRightLst;
        private TableLayoutPanel InputCenterTable;
        private Panel InputCenterPanel;
        private Button MoveDownBtn;
        private Button MoveUpBtn;
        private Button RemoveBtn;
        private Button AddBtn;
        private Panel InputLeftPanel;
        private CheckBox SaveSelProfileChk;
        private Label QueryLbl;
        private TextBox QueryTxt;
        private CustomListView InputLeftLst;
        private Button SearchBtn;
        private TableLayoutPanel InputTable;
        private ColumnHeader RightNameHdr;
        private ColumnHeader RightTypeHdr;
        private ColumnHeader LeftNameHdr;
        private ColumnHeader LeftTypeHdr;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
