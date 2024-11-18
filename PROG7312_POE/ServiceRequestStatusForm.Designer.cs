namespace PROG7312_POE
{
    partial class ServiceRequestStatusForm
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
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tSTopBat = new System.Windows.Forms.ToolStrip();
            this.tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            this.tSlblExit = new System.Windows.Forms.ToolStripLabel();
            this.lVRequests = new System.Windows.Forms.ListView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnTrackProgress = new System.Windows.Forms.Button();
            this.rTBDetails = new System.Windows.Forms.RichTextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.pBRequestProgress = new System.Windows.Forms.ProgressBar();
            this.gBProgress = new System.Windows.Forms.GroupBox();
            this.cBPriority = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.mSMenu.SuspendLayout();
            this.tSTopBat.SuspendLayout();
            this.gBProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMenu
            // 
            this.mSMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTSMIMenu});
            this.mSMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mSMenu.Location = new System.Drawing.Point(0, 25);
            this.mSMenu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mSMenu.Name = "mSMenu";
            this.mSMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 4);
            this.mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mSMenu.Size = new System.Drawing.Size(765, 30);
            this.mSMenu.TabIndex = 3;
            this.mSMenu.Text = "menuStrip1";
            // 
            // mTSMIMenu
            // 
            this.mTSMIMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIReturnToHome});
            this.mTSMIMenu.Name = "mTSMIMenu";
            this.mTSMIMenu.Size = new System.Drawing.Size(64, 24);
            this.mTSMIMenu.Text = "Menu";
            // 
            // TSMIReturnToHome
            // 
            this.TSMIReturnToHome.Image = global::PROG7312_POE.Properties.Resources.Home;
            this.TSMIReturnToHome.Name = "TSMIReturnToHome";
            this.TSMIReturnToHome.Size = new System.Drawing.Size(216, 26);
            this.TSMIReturnToHome.Text = "Return To Home";
            this.TSMIReturnToHome.Click += new System.EventHandler(this.TSMIReturnToHome_Click);
            // 
            // tSTopBat
            // 
            this.tSTopBat.BackColor = System.Drawing.Color.MidnightBlue;
            this.tSTopBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSTopBat.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSTopBat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSTopBat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSlblTitle,
            this.tSlblExit});
            this.tSTopBat.Location = new System.Drawing.Point(0, 0);
            this.tSTopBat.Name = "tSTopBat";
            this.tSTopBat.Size = new System.Drawing.Size(765, 25);
            this.tSTopBat.TabIndex = 2;
            this.tSTopBat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tSTopBat_MouseDown);
            // 
            // tSlblTitle
            // 
            this.tSlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSlblTitle.ForeColor = System.Drawing.Color.White;
            this.tSlblTitle.Image = global::PROG7312_POE.Properties.Resources.Status;
            this.tSlblTitle.Name = "tSlblTitle";
            this.tSlblTitle.Size = new System.Drawing.Size(227, 22);
            this.tSlblTitle.Text = "Service Request Status";
            // 
            // tSlblExit
            // 
            this.tSlblExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSlblExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.tSlblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSlblExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.tSlblExit.Name = "tSlblExit";
            this.tSlblExit.Size = new System.Drawing.Size(21, 22);
            this.tSlblExit.Text = "X";
            this.tSlblExit.Click += new System.EventHandler(this.tSlblExit_Click);
            // 
            // lVRequests
            // 
            this.lVRequests.FullRowSelect = true;
            this.lVRequests.HideSelection = false;
            this.lVRequests.Location = new System.Drawing.Point(12, 68);
            this.lVRequests.MultiSelect = false;
            this.lVRequests.Name = "lVRequests";
            this.lVRequests.Size = new System.Drawing.Size(741, 208);
            this.lVRequests.TabIndex = 4;
            this.lVRequests.UseCompatibleStateImageBehavior = false;
            this.lVRequests.View = System.Windows.Forms.View.Details;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(12, 282);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(135, 30);
            this.btnViewDetails.TabIndex = 5;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnTrackProgress
            // 
            this.btnTrackProgress.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTrackProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrackProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackProgress.Location = new System.Drawing.Point(618, 282);
            this.btnTrackProgress.Name = "btnTrackProgress";
            this.btnTrackProgress.Size = new System.Drawing.Size(135, 30);
            this.btnTrackProgress.TabIndex = 6;
            this.btnTrackProgress.Text = "Track Progress";
            this.btnTrackProgress.UseVisualStyleBackColor = false;
            this.btnTrackProgress.Click += new System.EventHandler(this.btnTrackProgress_Click);
            // 
            // rTBDetails
            // 
            this.rTBDetails.BackColor = System.Drawing.SystemColors.Window;
            this.rTBDetails.Location = new System.Drawing.Point(12, 318);
            this.rTBDetails.Name = "rTBDetails";
            this.rTBDetails.ReadOnly = true;
            this.rTBDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTBDetails.Size = new System.Drawing.Size(741, 200);
            this.rTBDetails.TabIndex = 7;
            this.rTBDetails.Text = "";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(623, 32);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(112, 20);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "% Complete...";
            // 
            // pBRequestProgress
            // 
            this.pBRequestProgress.ForeColor = System.Drawing.Color.Green;
            this.pBRequestProgress.Location = new System.Drawing.Point(64, 32);
            this.pBRequestProgress.Name = "pBRequestProgress";
            this.pBRequestProgress.Size = new System.Drawing.Size(480, 26);
            this.pBRequestProgress.Step = 100;
            this.pBRequestProgress.TabIndex = 0;
            // 
            // gBProgress
            // 
            this.gBProgress.Controls.Add(this.lblPercentage);
            this.gBProgress.Controls.Add(this.pBRequestProgress);
            this.gBProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBProgress.Location = new System.Drawing.Point(12, 534);
            this.gBProgress.Name = "gBProgress";
            this.gBProgress.Size = new System.Drawing.Size(741, 70);
            this.gBProgress.TabIndex = 9;
            this.gBProgress.TabStop = false;
            this.gBProgress.Text = "Progress Tracker";
            // 
            // cBPriority
            // 
            this.cBPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPriority.FormattingEnabled = true;
            this.cBPriority.Location = new System.Drawing.Point(179, 284);
            this.cBPriority.Name = "cBPriority";
            this.cBPriority.Size = new System.Drawing.Size(196, 28);
            this.cBPriority.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(381, 282);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(175, 30);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter By Priority";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(765, 607);
            this.Controls.Add(this.cBPriority);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.gBProgress);
            this.Controls.Add(this.rTBDetails);
            this.Controls.Add(this.btnTrackProgress);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lVRequests);
            this.Controls.Add(this.mSMenu);
            this.Controls.Add(this.tSTopBat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mSMenu;
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.mSMenu.ResumeLayout(false);
            this.mSMenu.PerformLayout();
            this.tSTopBat.ResumeLayout(false);
            this.tSTopBat.PerformLayout();
            this.gBProgress.ResumeLayout(false);
            this.gBProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.ToolStrip tSTopBat;
        private System.Windows.Forms.ToolStripMenuItem mTSMIMenu;
        private System.Windows.Forms.ToolStripLabel tSlblTitle;
        private System.Windows.Forms.ToolStripLabel tSlblExit;
        private System.Windows.Forms.ToolStripMenuItem TSMIReturnToHome;
        private System.Windows.Forms.ListView lVRequests;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnTrackProgress;
        private System.Windows.Forms.RichTextBox rTBDetails;
        private System.Windows.Forms.ProgressBar pBRequestProgress;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.GroupBox gBProgress;
        private System.Windows.Forms.ComboBox cBPriority;
        private System.Windows.Forms.Button btnFilter;
    }
}