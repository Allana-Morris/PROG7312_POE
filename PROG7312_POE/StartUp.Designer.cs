namespace PROG7312_POE
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.tSMIHome = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBRequestStatus = new System.Windows.Forms.PictureBox();
            this.pBLocalEvents = new System.Windows.Forms.PictureBox();
            this.pBIssues = new System.Windows.Forms.PictureBox();
            this.tSMainMenu = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblEventsandAnnouncements = new System.Windows.Forms.Label();
            this.lblServiceRequestStatus = new System.Windows.Forms.Label();
            this.pBFeedback = new System.Windows.Forms.PictureBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBRequestStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLocalEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIssues)).BeginInit();
            this.tSMainMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // tSMIHome
            // 
            this.tSMIHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSMIHome.Image = global::PROG7312_POE.Properties.Resources.Home;
            this.tSMIHome.Name = "tSMIHome";
            this.tSMIHome.Size = new System.Drawing.Size(92, 24);
            this.tSMIHome.Text = "Home";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutDownToolStripMenuItem.Image = global::PROG7312_POE.Properties.Resources.Shut_Down;
            this.shutDownToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shutDownToolStripMenuItem.Text = "Shut Down";
            // 
            // pBRequestStatus
            // 
            this.pBRequestStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBRequestStatus.Image = global::PROG7312_POE.Properties.Resources.Status;
            this.pBRequestStatus.InitialImage = global::PROG7312_POE.Properties.Resources.Status;
            this.pBRequestStatus.Location = new System.Drawing.Point(41, 266);
            this.pBRequestStatus.Name = "pBRequestStatus";
            this.pBRequestStatus.Size = new System.Drawing.Size(60, 60);
            this.pBRequestStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBRequestStatus.TabIndex = 2;
            this.pBRequestStatus.TabStop = false;
            this.pBRequestStatus.WaitOnLoad = true;
            this.pBRequestStatus.Click += new System.EventHandler(this.pBRequestStatus_Click);
            // 
            // pBLocalEvents
            // 
            this.pBLocalEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBLocalEvents.Image = global::PROG7312_POE.Properties.Resources.Local_Events;
            this.pBLocalEvents.InitialImage = global::PROG7312_POE.Properties.Resources.Local_Events;
            this.pBLocalEvents.Location = new System.Drawing.Point(41, 144);
            this.pBLocalEvents.Name = "pBLocalEvents";
            this.pBLocalEvents.Size = new System.Drawing.Size(60, 60);
            this.pBLocalEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLocalEvents.TabIndex = 1;
            this.pBLocalEvents.TabStop = false;
            this.pBLocalEvents.Click += new System.EventHandler(this.pBLocalEvents_Click);
            // 
            // pBIssues
            // 
            this.pBIssues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBIssues.Image = global::PROG7312_POE.Properties.Resources.Report_Issue;
            this.pBIssues.InitialImage = global::PROG7312_POE.Properties.Resources.Report_Issue;
            this.pBIssues.Location = new System.Drawing.Point(38, 32);
            this.pBIssues.Name = "pBIssues";
            this.pBIssues.Size = new System.Drawing.Size(60, 60);
            this.pBIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBIssues.TabIndex = 0;
            this.pBIssues.TabStop = false;
            this.pBIssues.WaitOnLoad = true;
            this.pBIssues.Click += new System.EventHandler(this.pBIssues_Click);
            // 
            // tSMainMenu
            // 
            this.tSMainMenu.AutoSize = false;
            this.tSMainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.tSMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tSMainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.tSMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.toolStripSeparator1});
            this.tSMainMenu.Location = new System.Drawing.Point(0, 416);
            this.tSMainMenu.Name = "tSMainMenu";
            this.tSMainMenu.Size = new System.Drawing.Size(756, 34);
            this.tSMainMenu.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::PROG7312_POE.Properties.Resources.Home;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 31);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnShutDown);
            this.pnlMenu.Location = new System.Drawing.Point(0, 214);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(177, 209);
            this.pnlMenu.TabIndex = 10;
            this.pnlMenu.Visible = false;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.Black;
            this.btnShutDown.Image = global::PROG7312_POE.Properties.Resources.Shut_Down;
            this.btnShutDown.Location = new System.Drawing.Point(-11, 160);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(190, 45);
            this.btnShutDown.TabIndex = 0;
            this.btnShutDown.Text = "Shut Down";
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // lblReport
            // 
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(18, 95);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(115, 24);
            this.lblReport.TabIndex = 14;
            this.lblReport.Text = "Report Issues";
            this.lblReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // lblEventsandAnnouncements
            // 
            this.lblEventsandAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsandAnnouncements.Location = new System.Drawing.Point(12, 207);
            this.lblEventsandAnnouncements.Name = "lblEventsandAnnouncements";
            this.lblEventsandAnnouncements.Size = new System.Drawing.Size(138, 44);
            this.lblEventsandAnnouncements.TabIndex = 15;
            this.lblEventsandAnnouncements.Text = "Local Events and Announcements";
            this.lblEventsandAnnouncements.Click += new System.EventHandler(this.pBLocalEvents_Click);
            // 
            // lblServiceRequestStatus
            // 
            this.lblServiceRequestStatus.AutoEllipsis = true;
            this.lblServiceRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceRequestStatus.Location = new System.Drawing.Point(9, 329);
            this.lblServiceRequestStatus.Name = "lblServiceRequestStatus";
            this.lblServiceRequestStatus.Size = new System.Drawing.Size(134, 43);
            this.lblServiceRequestStatus.TabIndex = 16;
            this.lblServiceRequestStatus.Text = "Service Request Status";
            this.lblServiceRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblServiceRequestStatus.Click += new System.EventHandler(this.pBRequestStatus_Click);
            // 
            // pBFeedback
            // 
            this.pBFeedback.BackgroundImage = global::PROG7312_POE.Properties.Resources.Feedback;
            this.pBFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBFeedback.Location = new System.Drawing.Point(211, 32);
            this.pBFeedback.Name = "pBFeedback";
            this.pBFeedback.Size = new System.Drawing.Size(60, 60);
            this.pBFeedback.TabIndex = 17;
            this.pBFeedback.TabStop = false;
            this.pBFeedback.Click += new System.EventHandler(this.pBFeedback_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(195, 95);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(97, 43);
            this.lblFeedback.TabIndex = 18;
            this.lblFeedback.Text = "Community Feedback";
            this.lblFeedback.Click += new System.EventHandler(this.pBFeedback_Click);
            // 
            // StartUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pBFeedback);
            this.Controls.Add(this.tSMainMenu);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblServiceRequestStatus);
            this.Controls.Add(this.lblEventsandAnnouncements);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.pBRequestStatus);
            this.Controls.Add(this.pBLocalEvents);
            this.Controls.Add(this.pBIssues);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pBRequestStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLocalEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIssues)).EndInit();
            this.tSMainMenu.ResumeLayout(false);
            this.tSMainMenu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBFeedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBIssues;
        private System.Windows.Forms.PictureBox pBLocalEvents;
        private System.Windows.Forms.PictureBox pBRequestStatus;
        private System.Windows.Forms.ToolStripMenuItem tSMIHome;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tSMainMenu;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblEventsandAnnouncements;
        private System.Windows.Forms.Label lblServiceRequestStatus;
        private System.Windows.Forms.PictureBox pBFeedback;
        private System.Windows.Forms.Label lblFeedback;
    }
}