using PROG7312_POE.Properties;

namespace PROG7312_POE
{
    partial class ReportIssuesForm
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
            btnBrowse = new System.Windows.Forms.Button();
            btnSubmit = new System.Windows.Forms.Button();
            tSTopBat = new System.Windows.Forms.ToolStrip();
            tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            tSlblExit = new System.Windows.Forms.ToolStripLabel();
            mSMenu = new System.Windows.Forms.MenuStrip();
            mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            TSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            tBAttachment = new System.Windows.Forms.TextBox();
            tBLocation = new System.Windows.Forms.TextBox();
            rTBDescription = new System.Windows.Forms.RichTextBox();
            UserProgress = new System.Windows.Forms.ProgressBar();
            lblLocation = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblAttachment = new System.Windows.Forms.Label();
            cBCategory = new System.Windows.Forms.ComboBox();
            tSTopBat.SuspendLayout();
            mSMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBrowse.Location = new System.Drawing.Point(291, 457);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(84, 29);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "&Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSubmit.Location = new System.Drawing.Point(291, 508);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(84, 29);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
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
            tSTopBat.Size = new System.Drawing.Size(387, 25);
            tSTopBat.TabIndex = 2;
            tSTopBat.Text = "toolStrip1";
            tSTopBat.MouseDown += tSTopBat_MouseDown;
            // 
            // tSlblTitle
            // 
            tSlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tSlblTitle.ForeColor = System.Drawing.Color.White;
            tSlblTitle.Image = Resources.Report_Issue;
            tSlblTitle.Name = "tSlblTitle";
            tSlblTitle.Size = new System.Drawing.Size(136, 22);
            tSlblTitle.Text = "Report Issue";
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
            // mSMenu
            // 
            mSMenu.BackColor = System.Drawing.Color.LightGray;
            mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mTSMIMenu });
            mSMenu.Location = new System.Drawing.Point(0, 25);
            mSMenu.Name = "mSMenu";
            mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mSMenu.Size = new System.Drawing.Size(387, 28);
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
            TSMIReturnToHome.Image = Resources.Home;
            TSMIReturnToHome.Name = "TSMIReturnToHome";
            TSMIReturnToHome.Size = new System.Drawing.Size(211, 26);
            TSMIReturnToHome.Text = "Return to Home";
            // 
            // tBAttachment
            // 
            tBAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tBAttachment.Location = new System.Drawing.Point(105, 458);
            tBAttachment.Multiline = true;
            tBAttachment.Name = "tBAttachment";
            tBAttachment.ReadOnly = true;
            tBAttachment.ShortcutsEnabled = false;
            tBAttachment.Size = new System.Drawing.Size(180, 29);
            tBAttachment.TabIndex = 4;
            tBAttachment.TabStop = false;
            // 
            // tBLocation
            // 
            tBLocation.BackColor = System.Drawing.SystemColors.Control;
            tBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tBLocation.Location = new System.Drawing.Point(105, 101);
            tBLocation.Name = "tBLocation";
            tBLocation.ShortcutsEnabled = false;
            tBLocation.Size = new System.Drawing.Size(270, 27);
            tBLocation.TabIndex = 5;
            // 
            // rTBDescription
            // 
            rTBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rTBDescription.Location = new System.Drawing.Point(105, 204);
            rTBDescription.Name = "rTBDescription";
            rTBDescription.Size = new System.Drawing.Size(270, 232);
            rTBDescription.TabIndex = 7;
            rTBDescription.Text = "";
            // 
            // UserProgress
            // 
            UserProgress.Dock = System.Windows.Forms.DockStyle.Top;
            UserProgress.Location = new System.Drawing.Point(0, 53);
            UserProgress.Name = "UserProgress";
            UserProgress.Size = new System.Drawing.Size(387, 23);
            UserProgress.TabIndex = 8;
            // 
            // lblLocation
            // 
            lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblLocation.Location = new System.Drawing.Point(3, 104);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new System.Drawing.Size(91, 24);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "Location";
            // 
            // lblCategory
            // 
            lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCategory.Location = new System.Drawing.Point(3, 152);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(91, 28);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDescription.Location = new System.Drawing.Point(3, 204);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(96, 21);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblAttachment
            // 
            lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAttachment.Location = new System.Drawing.Point(3, 461);
            lblAttachment.Name = "lblAttachment";
            lblAttachment.Size = new System.Drawing.Size(91, 25);
            lblAttachment.TabIndex = 12;
            lblAttachment.Text = "Attach File";
            // 
            // cBCategory
            // 
            cBCategory.BackColor = System.Drawing.SystemColors.Control;
            cBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cBCategory.FormattingEnabled = true;
            cBCategory.Location = new System.Drawing.Point(105, 152);
            cBCategory.Name = "cBCategory";
            cBCategory.Size = new System.Drawing.Size(270, 28);
            cBCategory.TabIndex = 13;
            cBCategory.Text = "Select a Category";
            // 
            // ReportIssuesForm
            // 
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(387, 549);
            Controls.Add(rTBDescription);
            Controls.Add(cBCategory);
            Controls.Add(lblAttachment);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblLocation);
            Controls.Add(UserProgress);
            Controls.Add(tBLocation);
            Controls.Add(tBAttachment);
            Controls.Add(mSMenu);
            Controls.Add(tSTopBat);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = mSMenu;
            Name = "ReportIssuesForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            tSTopBat.ResumeLayout(false);
            tSTopBat.PerformLayout();
            mSMenu.ResumeLayout(false);
            mSMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStrip tSTopBat;
        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.TextBox tBAttachment;
        private System.Windows.Forms.TextBox tBLocation;
        private System.Windows.Forms.RichTextBox rTBDescription;
        private System.Windows.Forms.ProgressBar UserProgress;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.ToolStripLabel tSlblTitle;
        private System.Windows.Forms.ToolStripLabel tSlblExit;
        private System.Windows.Forms.ToolStripMenuItem mTSMIMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMIReturnToHome;
        private System.Windows.Forms.ComboBox cBCategory;
    }
}