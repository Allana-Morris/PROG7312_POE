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
            tSMIHome = new System.Windows.Forms.ToolStripMenuItem();
            shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pBRequestStatus = new System.Windows.Forms.PictureBox();
            pBLocalEvents = new System.Windows.Forms.PictureBox();
            pBIssues = new System.Windows.Forms.PictureBox();
            tSMainMenu = new System.Windows.Forms.ToolStrip();
            btnHome = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            pnlMenu = new System.Windows.Forms.Panel();
            btnShutDown = new System.Windows.Forms.Button();
            lblReport = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pBFeedback = new System.Windows.Forms.PictureBox();
            lblFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pBRequestStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBLocalEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBIssues).BeginInit();
            tSMainMenu.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBFeedback).BeginInit();
            SuspendLayout();
            // 
            // tSMIHome
            // 
            tSMIHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tSMIHome.Image = Properties.Resources.Home;
            tSMIHome.Name = "tSMIHome";
            tSMIHome.Size = new System.Drawing.Size(92, 24);
            tSMIHome.Text = "Home";
            // 
            // shutDownToolStripMenuItem
            // 
            shutDownToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            shutDownToolStripMenuItem.Image = Properties.Resources.Shut_Down;
            shutDownToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            shutDownToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            shutDownToolStripMenuItem.Text = "Shut Down";
            // 
            // pBRequestStatus
            // 
            pBRequestStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBRequestStatus.Image = Properties.Resources.Status;
            pBRequestStatus.InitialImage = Properties.Resources.Status;
            pBRequestStatus.Location = new System.Drawing.Point(41, 266);
            pBRequestStatus.Name = "pBRequestStatus";
            pBRequestStatus.Size = new System.Drawing.Size(60, 60);
            pBRequestStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBRequestStatus.TabIndex = 2;
            pBRequestStatus.TabStop = false;
            pBRequestStatus.WaitOnLoad = true;
            pBRequestStatus.Click += pBRequestStatus_Click;
            // 
            // pBLocalEvents
            // 
            pBLocalEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBLocalEvents.Image = Properties.Resources.Local_Events;
            pBLocalEvents.InitialImage = Properties.Resources.Local_Events;
            pBLocalEvents.Location = new System.Drawing.Point(41, 144);
            pBLocalEvents.Name = "pBLocalEvents";
            pBLocalEvents.Size = new System.Drawing.Size(60, 60);
            pBLocalEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBLocalEvents.TabIndex = 1;
            pBLocalEvents.TabStop = false;
            pBLocalEvents.Click += pBLocalEvents_Click;
            // 
            // pBIssues
            // 
            pBIssues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBIssues.Image = Properties.Resources.Report_Issue;
            pBIssues.InitialImage = Properties.Resources.Report_Issue;
            pBIssues.Location = new System.Drawing.Point(38, 32);
            pBIssues.Name = "pBIssues";
            pBIssues.Size = new System.Drawing.Size(60, 60);
            pBIssues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBIssues.TabIndex = 0;
            pBIssues.TabStop = false;
            pBIssues.WaitOnLoad = true;
            pBIssues.Click += pBIssues_Click;
            // 
            // tSMainMenu
            // 
            tSMainMenu.AutoSize = false;
            tSMainMenu.BackColor = System.Drawing.Color.Gainsboro;
            tSMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tSMainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            tSMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, 0);
            tSMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            tSMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnHome, toolStripSeparator1 });
            tSMainMenu.Location = new System.Drawing.Point(0, 416);
            tSMainMenu.Name = "tSMainMenu";
            tSMainMenu.Size = new System.Drawing.Size(756, 34);
            tSMainMenu.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnHome.ForeColor = System.Drawing.Color.Black;
            btnHome.Image = Properties.Resources.Home;
            btnHome.ImageTransparentColor = System.Drawing.Color.Transparent;
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(82, 31);
            btnHome.Text = "Home";
            btnHome.Click += btnHome_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = System.Drawing.Color.Gainsboro;
            pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(btnShutDown);
            pnlMenu.Location = new System.Drawing.Point(0, 214);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new System.Drawing.Size(177, 209);
            pnlMenu.TabIndex = 10;
            pnlMenu.Visible = false;
            // 
            // btnShutDown
            // 
            btnShutDown.BackColor = System.Drawing.Color.Gainsboro;
            btnShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            btnShutDown.FlatAppearance.BorderSize = 0;
            btnShutDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            btnShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShutDown.ForeColor = System.Drawing.Color.Black;
            btnShutDown.Image = Properties.Resources.Shut_Down;
            btnShutDown.Location = new System.Drawing.Point(-11, 160);
            btnShutDown.Name = "btnShutDown";
            btnShutDown.Size = new System.Drawing.Size(190, 45);
            btnShutDown.TabIndex = 0;
            btnShutDown.Text = "Shut Down";
            btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnShutDown.UseVisualStyleBackColor = false;
            btnShutDown.Click += btnShutDown_Click;
            // 
            // lblReport
            // 
            lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblReport.Location = new System.Drawing.Point(18, 95);
            lblReport.Name = "lblReport";
            lblReport.Size = new System.Drawing.Size(115, 24);
            lblReport.TabIndex = 14;
            lblReport.Text = "Report Issues";
            lblReport.Click += lblReport_Click;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 44);
            label2.TabIndex = 15;
            label2.Text = "Local Events and Announcements";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(9, 329);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 43);
            label3.TabIndex = 16;
            label3.Text = "Service Request Status";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBFeedback
            // 
            pBFeedback.BackgroundImage = Properties.Resources.Feedback;
            pBFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pBFeedback.Location = new System.Drawing.Point(211, 32);
            pBFeedback.Name = "pBFeedback";
            pBFeedback.Size = new System.Drawing.Size(60, 60);
            pBFeedback.TabIndex = 17;
            pBFeedback.TabStop = false;
            pBFeedback.Click += pBFeedback_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFeedback.Location = new System.Drawing.Point(195, 95);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new System.Drawing.Size(97, 43);
            lblFeedback.TabIndex = 18;
            lblFeedback.Text = "Community Feedback";
            // 
            // StartUp
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoSize = true;
            BackColor = System.Drawing.Color.DarkCyan;
            ClientSize = new System.Drawing.Size(756, 450);
            Controls.Add(lblFeedback);
            Controls.Add(pBFeedback);
            Controls.Add(tSMainMenu);
            Controls.Add(pnlMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblReport);
            Controls.Add(pBRequestStatus);
            Controls.Add(pBLocalEvents);
            Controls.Add(pBIssues);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "StartUp";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += StartUp_Load;
            MouseDown += StartUp_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pBRequestStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBLocalEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBIssues).EndInit();
            tSMainMenu.ResumeLayout(false);
            tSMainMenu.PerformLayout();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBFeedback).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBFeedback;
        private System.Windows.Forms.Label lblFeedback;
    }
}