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
            panel1 = new System.Windows.Forms.Panel();
            lblPercentage = new System.Windows.Forms.Label();
            lblProgressTracker = new System.Windows.Forms.Label();
            pBRequestProgress = new System.Windows.Forms.ProgressBar();
            button3 = new System.Windows.Forms.Button();
            mSMenu.SuspendLayout();
            tSTopBat.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mSMenu
            // 
            mSMenu.BackColor = System.Drawing.Color.LightGray;
            mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mTSMIMenu });
            mSMenu.Location = new System.Drawing.Point(0, 25);
            mSMenu.Name = "mSMenu";
            mSMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mSMenu.Size = new System.Drawing.Size(927, 28);
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
            tSTopBat.Size = new System.Drawing.Size(927, 25);
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
            lVRequests.Location = new System.Drawing.Point(14, 68);
            lVRequests.Name = "lVRequests";
            lVRequests.Size = new System.Drawing.Size(896, 194);
            lVRequests.TabIndex = 4;
            lVRequests.UseCompatibleStateImageBehavior = false;
            lVRequests.View = System.Windows.Forms.View.Details;
            // 
            // btnViewDetails
            // 
            btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnViewDetails.Location = new System.Drawing.Point(182, 267);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new System.Drawing.Size(126, 26);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnTrackProgress
            // 
            btnTrackProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnTrackProgress.Location = new System.Drawing.Point(673, 267);
            btnTrackProgress.Name = "btnTrackProgress";
            btnTrackProgress.Size = new System.Drawing.Size(133, 26);
            btnTrackProgress.TabIndex = 6;
            btnTrackProgress.Text = "Track Progress";
            btnTrackProgress.UseVisualStyleBackColor = true;
            btnTrackProgress.Click += btnTrackProgress_Click;
            // 
            // rTBDetails
            // 
            rTBDetails.BackColor = System.Drawing.SystemColors.Window;
            rTBDetails.Location = new System.Drawing.Point(14, 299);
            rTBDetails.Name = "rTBDetails";
            rTBDetails.ReadOnly = true;
            rTBDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            rTBDetails.Size = new System.Drawing.Size(896, 157);
            rTBDetails.TabIndex = 7;
            rTBDetails.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPercentage);
            panel1.Controls.Add(lblProgressTracker);
            panel1.Controls.Add(pBRequestProgress);
            panel1.Location = new System.Drawing.Point(0, 474);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(910, 31);
            panel1.TabIndex = 8;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new System.Drawing.Point(760, 6);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new System.Drawing.Size(46, 18);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "label2";
            // 
            // lblProgressTracker
            // 
            lblProgressTracker.AutoSize = true;
            lblProgressTracker.Location = new System.Drawing.Point(24, 6);
            lblProgressTracker.Name = "lblProgressTracker";
            lblProgressTracker.Size = new System.Drawing.Size(124, 18);
            lblProgressTracker.TabIndex = 1;
            lblProgressTracker.Text = "Progress Tracker";
            // 
            // pBRequestProgress
            // 
            pBRequestProgress.ForeColor = System.Drawing.Color.Green;
            pBRequestProgress.Location = new System.Drawing.Point(182, 3);
            pBRequestProgress.Name = "pBRequestProgress";
            pBRequestProgress.Size = new System.Drawing.Size(516, 26);
            pBRequestProgress.Step = 100;
            pBRequestProgress.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(24, 393);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(106, 26);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // ServiceRequestStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(927, 517);
            Controls.Add(panel1);
            Controls.Add(rTBDetails);
            Controls.Add(button3);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pBRequestProgress;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblProgressTracker;
        private System.Windows.Forms.Label lblPercentage;
    }
}