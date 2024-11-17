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
            mSMenu = new System.Windows.Forms.MenuStrip();
            mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            TSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            tSTopBat = new System.Windows.Forms.ToolStrip();
            tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            tSlblExit = new System.Windows.Forms.ToolStripLabel();
            lVRequests = new System.Windows.Forms.ListView();
            btnViewDetails = new System.Windows.Forms.Button();
            btnTrackProgress = new System.Windows.Forms.Button();
            rTBDetails = new System.Windows.Forms.RichTextBox();
            lblPercentage = new System.Windows.Forms.Label();
            pBRequestProgress = new System.Windows.Forms.ProgressBar();
            gBProgress = new System.Windows.Forms.GroupBox();
            mSMenu.SuspendLayout();
            tSTopBat.SuspendLayout();
            gBProgress.SuspendLayout();
            SuspendLayout();
            // 
            // mSMenu
            // 
            mSMenu.BackColor = System.Drawing.Color.Gainsboro;
            mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mSMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mTSMIMenu });
            mSMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            mSMenu.Location = new System.Drawing.Point(0, 25);
            mSMenu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            mSMenu.Name = "mSMenu";
            mSMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 4);
            mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            mSMenu.Size = new System.Drawing.Size(684, 30);
            mSMenu.TabIndex = 3;
            mSMenu.Text = "menuStrip1";
            // 
            // mTSMIMenu
            // 
            mTSMIMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { TSMIReturnToHome });
            mTSMIMenu.Name = "mTSMIMenu";
            mTSMIMenu.Size = new System.Drawing.Size(64, 24);
            mTSMIMenu.Text = "Menu";
            // 
            // TSMIReturnToHome
            // 
            TSMIReturnToHome.Image = Properties.Resources.Home;
            TSMIReturnToHome.Name = "TSMIReturnToHome";
            TSMIReturnToHome.Size = new System.Drawing.Size(216, 26);
            TSMIReturnToHome.Text = "Return To Home";
            // 
            // tSTopBat
            // 
            tSTopBat.BackColor = System.Drawing.Color.MidnightBlue;
            tSTopBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tSTopBat.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tSTopBat.ImageScalingSize = new System.Drawing.Size(20, 20);
            tSTopBat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tSlblTitle, tSlblExit });
            tSTopBat.Location = new System.Drawing.Point(0, 0);
            tSTopBat.Name = "tSTopBat";
            tSTopBat.Size = new System.Drawing.Size(684, 25);
            tSTopBat.TabIndex = 2;
            tSTopBat.MouseDown += tSTopBat_MouseDown;
            // 
            // tSlblTitle
            // 
            tSlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tSlblTitle.ForeColor = System.Drawing.Color.White;
            tSlblTitle.Image = Properties.Resources.Status;
            tSlblTitle.Name = "tSlblTitle";
            tSlblTitle.Size = new System.Drawing.Size(227, 22);
            tSlblTitle.Text = "Service Request Status";
            // 
            // tSlblExit
            // 
            tSlblExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tSlblExit.BackColor = System.Drawing.Color.MidnightBlue;
            tSlblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tSlblExit.ForeColor = System.Drawing.Color.Gainsboro;
            tSlblExit.Name = "tSlblExit";
            tSlblExit.Size = new System.Drawing.Size(21, 22);
            tSlblExit.Text = "X";
            tSlblExit.Click += tSlblExit_Click;
            // 
            // lVRequests
            // 
            lVRequests.FullRowSelect = true;
            lVRequests.Location = new System.Drawing.Point(12, 68);
            lVRequests.MultiSelect = false;
            lVRequests.Name = "lVRequests";
            lVRequests.Size = new System.Drawing.Size(645, 194);
            lVRequests.TabIndex = 4;
            lVRequests.UseCompatibleStateImageBehavior = false;
            lVRequests.View = System.Windows.Forms.View.Details;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = System.Drawing.Color.Gainsboro;
            btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnViewDetails.Location = new System.Drawing.Point(12, 268);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new System.Drawing.Size(135, 30);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnTrackProgress
            // 
            btnTrackProgress.BackColor = System.Drawing.Color.Gainsboro;
            btnTrackProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnTrackProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTrackProgress.Location = new System.Drawing.Point(522, 268);
            btnTrackProgress.Name = "btnTrackProgress";
            btnTrackProgress.Size = new System.Drawing.Size(135, 30);
            btnTrackProgress.TabIndex = 6;
            btnTrackProgress.Text = "Track Progress";
            btnTrackProgress.UseVisualStyleBackColor = false;
            btnTrackProgress.Click += btnTrackProgress_Click;
            // 
            // rTBDetails
            // 
            rTBDetails.BackColor = System.Drawing.SystemColors.Window;
            rTBDetails.Location = new System.Drawing.Point(12, 318);
            rTBDetails.Name = "rTBDetails";
            rTBDetails.ReadOnly = true;
            rTBDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            rTBDetails.Size = new System.Drawing.Size(645, 200);
            rTBDetails.TabIndex = 7;
            rTBDetails.Text = "";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPercentage.Location = new System.Drawing.Point(547, 32);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new System.Drawing.Size(26, 20);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "lbl";
            // 
            // pBRequestProgress
            // 
            pBRequestProgress.ForeColor = System.Drawing.Color.Green;
            pBRequestProgress.Location = new System.Drawing.Point(9, 32);
            pBRequestProgress.Name = "pBRequestProgress";
            pBRequestProgress.Size = new System.Drawing.Size(480, 26);
            pBRequestProgress.Step = 100;
            pBRequestProgress.TabIndex = 0;
            // 
            // gBProgress
            // 
            gBProgress.Controls.Add(lblPercentage);
            gBProgress.Controls.Add(pBRequestProgress);
            gBProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            gBProgress.Location = new System.Drawing.Point(12, 534);
            gBProgress.Name = "gBProgress";
            gBProgress.Size = new System.Drawing.Size(645, 70);
            gBProgress.TabIndex = 9;
            gBProgress.TabStop = false;
            gBProgress.Text = "Progress Tracker";
            // 
            // ServiceRequestStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(684, 616);
            Controls.Add(gBProgress);
            Controls.Add(rTBDetails);
            Controls.Add(btnTrackProgress);
            Controls.Add(btnViewDetails);
            Controls.Add(lVRequests);
            Controls.Add(mSMenu);
            Controls.Add(tSTopBat);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = mSMenu;
            Name = "ServiceRequestStatusForm";
            Text = "ServiceRequestStatusForm";
            mSMenu.ResumeLayout(false);
            mSMenu.PerformLayout();
            tSTopBat.ResumeLayout(false);
            tSTopBat.PerformLayout();
            gBProgress.ResumeLayout(false);
            gBProgress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}