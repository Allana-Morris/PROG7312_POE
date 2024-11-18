namespace PROG7312_POE
{
    partial class LocalEventsAndAnnouncementsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Categories");
            this.mSMenuBar = new System.Windows.Forms.MenuStrip();
            this.mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tSTopBar = new System.Windows.Forms.ToolStrip();
            this.tSLHeading = new System.Windows.Forms.ToolStripLabel();
            this.tSLExitLEA = new System.Windows.Forms.ToolStripLabel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBCategory = new System.Windows.Forms.CheckBox();
            this.cBDate = new System.Windows.Forms.CheckBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dTPToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cLBCategory = new System.Windows.Forms.CheckedListBox();
            this.dTPFromDate = new System.Windows.Forms.DateTimePicker();
            this.lVEventsandAnnoucements = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tCEventsandAnnouncements = new System.Windows.Forms.TabControl();
            this.tPAnnouncements = new System.Windows.Forms.TabPage();
            this.tVCategories = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tPEvents = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnReset = new System.Windows.Forms.Button();
            this.mSMenuBar.SuspendLayout();
            this.tSTopBar.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tCEventsandAnnouncements.SuspendLayout();
            this.tPAnnouncements.SuspendLayout();
            this.tPEvents.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMenuBar
            // 
            this.mSMenuBar.BackColor = System.Drawing.Color.LightGray;
            this.mSMenuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mSMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTSMIMenu});
            this.mSMenuBar.Location = new System.Drawing.Point(0, 25);
            this.mSMenuBar.Name = "mSMenuBar";
            this.mSMenuBar.Size = new System.Drawing.Size(960, 28);
            this.mSMenuBar.TabIndex = 0;
            this.mSMenuBar.Text = "menuStrip1";
            // 
            // mTSMIMenu
            // 
            this.mTSMIMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIReturnToHome});
            this.mTSMIMenu.Name = "mTSMIMenu";
            this.mTSMIMenu.Size = new System.Drawing.Size(64, 24);
            this.mTSMIMenu.Text = "Menu";
            // 
            // tSMIReturnToHome
            // 
            this.tSMIReturnToHome.BackColor = System.Drawing.Color.LightGray;
            this.tSMIReturnToHome.Image = global::PROG7312_POE.Properties.Resources.Home;
            this.tSMIReturnToHome.Name = "tSMIReturnToHome";
            this.tSMIReturnToHome.Size = new System.Drawing.Size(211, 26);
            this.tSMIReturnToHome.Text = "Return to Home";
            // 
            // tSTopBar
            // 
            this.tSTopBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.tSTopBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLHeading,
            this.tSLExitLEA});
            this.tSTopBar.Location = new System.Drawing.Point(0, 0);
            this.tSTopBar.Name = "tSTopBar";
            this.tSTopBar.Size = new System.Drawing.Size(960, 25);
            this.tSTopBar.TabIndex = 1;
            this.tSTopBar.Text = "toolStrip1";
            this.tSTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tSTopBar_MouseDown);
            // 
            // tSLHeading
            // 
            this.tSLHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSLHeading.ForeColor = System.Drawing.Color.White;
            this.tSLHeading.Image = global::PROG7312_POE.Properties.Resources.Local_Events;
            this.tSLHeading.Name = "tSLHeading";
            this.tSLHeading.Size = new System.Drawing.Size(303, 22);
            this.tSLHeading.Text = "Local Events and Annoucements";
            // 
            // tSLExitLEA
            // 
            this.tSLExitLEA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSLExitLEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSLExitLEA.ForeColor = System.Drawing.Color.Gainsboro;
            this.tSLExitLEA.Name = "tSLExitLEA";
            this.tSLExitLEA.Size = new System.Drawing.Size(19, 22);
            this.tSLExitLEA.Text = "X";
            this.tSLExitLEA.Click += new System.EventHandler(this.tSLExitLEA_Click);
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.LightGray;
            this.pSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSearch.Controls.Add(this.BtnReset);
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Controls.Add(this.groupBox1);
            this.pSearch.Controls.Add(this.lblSearchBy);
            this.pSearch.Controls.Add(this.lblTo);
            this.pSearch.Controls.Add(this.dTPToDate);
            this.pSearch.Controls.Add(this.lblFrom);
            this.pSearch.Controls.Add(this.lblCategory);
            this.pSearch.Controls.Add(this.btnSearch);
            this.pSearch.Controls.Add(this.cLBCategory);
            this.pSearch.Controls.Add(this.dTPFromDate);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSearch.Location = new System.Drawing.Point(3, 3);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(362, 492);
            this.pSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Event Finder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBCategory);
            this.groupBox1.Controls.Add(this.cBDate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(99, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cBCategory
            // 
            this.cBCategory.AutoSize = true;
            this.cBCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategory.Location = new System.Drawing.Point(6, 9);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(87, 22);
            this.cBCategory.TabIndex = 14;
            this.cBCategory.Text = "Category";
            this.cBCategory.UseVisualStyleBackColor = true;
            this.cBCategory.CheckStateChanged += new System.EventHandler(this.cBCategory_CheckStateChanged);
            // 
            // cBDate
            // 
            this.cBDate.AutoSize = true;
            this.cBDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDate.Location = new System.Drawing.Point(6, 37);
            this.cBDate.Name = "cBDate";
            this.cBDate.Size = new System.Drawing.Size(58, 22);
            this.cBDate.TabIndex = 15;
            this.cBDate.Text = "Date";
            this.cBDate.UseVisualStyleBackColor = true;
            this.cBDate.CheckStateChanged += new System.EventHandler(this.cBDate_CheckStateChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(120, 34);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(92, 20);
            this.lblSearchBy.TabIndex = 13;
            this.lblSearchBy.Text = "Search By:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(95, 356);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 20);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To:";
            // 
            // dTPToDate
            // 
            this.dTPToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPToDate.Enabled = false;
            this.dTPToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPToDate.Location = new System.Drawing.Point(99, 379);
            this.dTPToDate.Name = "dTPToDate";
            this.dTPToDate.Size = new System.Drawing.Size(189, 24);
            this.dTPToDate.TabIndex = 10;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(95, 295);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(53, 20);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "From:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(-1, 155);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(99, 431);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cLBCategory
            // 
            this.cLBCategory.BackColor = System.Drawing.Color.LightGray;
            this.cLBCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cLBCategory.CheckOnClick = true;
            this.cLBCategory.Enabled = false;
            this.cLBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLBCategory.FormattingEnabled = true;
            this.cLBCategory.Items.AddRange(new object[] {
            " "});
            this.cLBCategory.Location = new System.Drawing.Point(1, 178);
            this.cLBCategory.Name = "cLBCategory";
            this.cLBCategory.Size = new System.Drawing.Size(346, 114);
            this.cLBCategory.TabIndex = 6;
            // 
            // dTPFromDate
            // 
            this.dTPFromDate.Enabled = false;
            this.dTPFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFromDate.Location = new System.Drawing.Point(99, 329);
            this.dTPFromDate.MaxDate = new System.DateTime(2025, 10, 15, 0, 0, 0, 0);
            this.dTPFromDate.MinDate = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            this.dTPFromDate.Name = "dTPFromDate";
            this.dTPFromDate.Size = new System.Drawing.Size(189, 24);
            this.dTPFromDate.TabIndex = 5;
            this.dTPFromDate.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // lVEventsandAnnoucements
            // 
            this.lVEventsandAnnoucements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lVEventsandAnnoucements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DateHeader,
            this.CategoryHeader,
            this.LocationHeader});
            this.lVEventsandAnnoucements.Dock = System.Windows.Forms.DockStyle.Right;
            this.lVEventsandAnnoucements.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVEventsandAnnoucements.HideSelection = false;
            this.lVEventsandAnnoucements.Location = new System.Drawing.Point(353, 3);
            this.lVEventsandAnnoucements.MultiSelect = false;
            this.lVEventsandAnnoucements.Name = "lVEventsandAnnoucements";
            this.lVEventsandAnnoucements.Size = new System.Drawing.Size(592, 492);
            this.lVEventsandAnnoucements.TabIndex = 5;
            this.lVEventsandAnnoucements.UseCompatibleStateImageBehavior = false;
            this.lVEventsandAnnoucements.View = System.Windows.Forms.View.Details;
            this.lVEventsandAnnoucements.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lVEventsandAnnoucements_ColumnClick);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 100;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Date";
            this.DateHeader.Width = 100;
            // 
            // CategoryHeader
            // 
            this.CategoryHeader.Text = "Category";
            this.CategoryHeader.Width = 150;
            // 
            // tCEventsandAnnouncements
            // 
            this.tCEventsandAnnouncements.Controls.Add(this.tPAnnouncements);
            this.tCEventsandAnnouncements.Controls.Add(this.tPEvents);
            this.tCEventsandAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCEventsandAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCEventsandAnnouncements.Location = new System.Drawing.Point(0, 53);
            this.tCEventsandAnnouncements.Name = "tCEventsandAnnouncements";
            this.tCEventsandAnnouncements.SelectedIndex = 0;
            this.tCEventsandAnnouncements.Size = new System.Drawing.Size(960, 535);
            this.tCEventsandAnnouncements.TabIndex = 6;
            // 
            // tPAnnouncements
            // 
            this.tPAnnouncements.BackColor = System.Drawing.Color.Gainsboro;
            this.tPAnnouncements.Controls.Add(this.tVCategories);
            this.tPAnnouncements.Controls.Add(this.listView1);
            this.tPAnnouncements.Location = new System.Drawing.Point(4, 29);
            this.tPAnnouncements.Name = "tPAnnouncements";
            this.tPAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tPAnnouncements.Size = new System.Drawing.Size(952, 502);
            this.tPAnnouncements.TabIndex = 1;
            this.tPAnnouncements.Text = "Announcements";
            // 
            // tVCategories
            // 
            this.tVCategories.BackColor = System.Drawing.Color.Gainsboro;
            this.tVCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.tVCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVCategories.HideSelection = false;
            this.tVCategories.Location = new System.Drawing.Point(3, 3);
            this.tVCategories.Name = "tVCategories";
            treeNode1.Name = "NodeMain";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Categories";
            this.tVCategories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tVCategories.Size = new System.Drawing.Size(346, 496);
            this.tVCategories.TabIndex = 1;
            this.tVCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tVCategories_NodeMouseClick);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(349, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 496);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tPEvents
            // 
            this.tPEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.tPEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tPEvents.Controls.Add(this.lVEventsandAnnoucements);
            this.tPEvents.Controls.Add(this.pSearch);
            this.tPEvents.Location = new System.Drawing.Point(4, 29);
            this.tPEvents.Name = "tPEvents";
            this.tPEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tPEvents.Size = new System.Drawing.Size(952, 502);
            this.tPEvents.TabIndex = 0;
            this.tPEvents.Text = "Events";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(89, 28);
            // 
            // loserToolStripMenuItem
            // 
            this.loserToolStripMenuItem.Name = "loserToolStripMenuItem";
            this.loserToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.loserToolStripMenuItem.Text = "Loser";
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 100;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(203, 431);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(85, 35);
            this.BtnReset.TabIndex = 18;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LocalEventsAndAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(960, 588);
            this.Controls.Add(this.tCEventsandAnnouncements);
            this.Controls.Add(this.mSMenuBar);
            this.Controls.Add(this.tSTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mSMenuBar;
            this.Name = "LocalEventsAndAnnouncementsForm";
            this.Text = "LocalEventsAndAnnouncementsForm";
            this.mSMenuBar.ResumeLayout(false);
            this.mSMenuBar.PerformLayout();
            this.tSTopBar.ResumeLayout(false);
            this.tSTopBar.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tCEventsandAnnouncements.ResumeLayout(false);
            this.tPAnnouncements.ResumeLayout(false);
            this.tPEvents.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSMenuBar;
        private System.Windows.Forms.ToolStrip tSTopBar;
        private System.Windows.Forms.ToolStripLabel tSLHeading;
        private System.Windows.Forms.ToolStripLabel tSLExitLEA;
        private System.Windows.Forms.ToolStripMenuItem mTSMIMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMIReturnToHome;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.DateTimePicker dTPFromDate;
        private System.Windows.Forms.ListView lVEventsandAnnoucements;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ColumnHeader CategoryHeader;
        private System.Windows.Forms.CheckedListBox cLBCategory;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dTPToDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.CheckBox cBDate;
        private System.Windows.Forms.CheckBox cBCategory;
        private System.Windows.Forms.TabControl tCEventsandAnnouncements;
        private System.Windows.Forms.TabPage tPEvents;
        private System.Windows.Forms.TabPage tPAnnouncements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tVCategories;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loserToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.Button BtnReset;
    }
}