
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tSTopBat = new System.Windows.Forms.ToolStrip();
            this.tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            this.tSlblExit = new System.Windows.Forms.ToolStripLabel();
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tBAttachment = new System.Windows.Forms.TextBox();
            this.tBLocation = new System.Windows.Forms.TextBox();
            this.rTBDescription = new System.Windows.Forms.RichTextBox();
            this.UserProgress = new System.Windows.Forms.ProgressBar();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.cBCategory = new System.Windows.Forms.ComboBox();
            this.tSTopBat.SuspendLayout();
            this.mSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(291, 457);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(291, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 29);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
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
            this.tSTopBat.Size = new System.Drawing.Size(387, 25);
            this.tSTopBat.TabIndex = 2;
            this.tSTopBat.Text = "toolStrip1";
            this.tSTopBat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tSTopBat_MouseDown);
            // 
            // tSlblTitle
            // 
            this.tSlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSlblTitle.ForeColor = System.Drawing.Color.White;
            this.tSlblTitle.Image = global::PROG7312_POE.Properties.Resources.Report_Issue;
            this.tSlblTitle.Name = "tSlblTitle";
            this.tSlblTitle.Size = new System.Drawing.Size(136, 22);
            this.tSlblTitle.Text = "Report Issue";
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
            this.tSlblExit.Click += new System.EventHandler(this.tSlblExit_Click_1);
            // 
            // mSMenu
            // 
            this.mSMenu.BackColor = System.Drawing.Color.LightGray;
            this.mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTSMIMenu});
            this.mSMenu.Location = new System.Drawing.Point(0, 25);
            this.mSMenu.Name = "mSMenu";
            this.mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mSMenu.Size = new System.Drawing.Size(387, 28);
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
            this.TSMIReturnToHome.Size = new System.Drawing.Size(211, 26);
            this.TSMIReturnToHome.Text = "Return to Home";
            // 
            // tBAttachment
            // 
            this.tBAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAttachment.Location = new System.Drawing.Point(105, 458);
            this.tBAttachment.Multiline = true;
            this.tBAttachment.Name = "tBAttachment";
            this.tBAttachment.ReadOnly = true;
            this.tBAttachment.ShortcutsEnabled = false;
            this.tBAttachment.Size = new System.Drawing.Size(180, 29);
            this.tBAttachment.TabIndex = 4;
            this.tBAttachment.TabStop = false;
            // 
            // tBLocation
            // 
            this.tBLocation.BackColor = System.Drawing.SystemColors.Control;
            this.tBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLocation.Location = new System.Drawing.Point(105, 101);
            this.tBLocation.Name = "tBLocation";
            this.tBLocation.ShortcutsEnabled = false;
            this.tBLocation.Size = new System.Drawing.Size(270, 27);
            this.tBLocation.TabIndex = 5;
            // 
            // rTBDescription
            // 
            this.rTBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBDescription.Location = new System.Drawing.Point(105, 204);
            this.rTBDescription.Name = "rTBDescription";
            this.rTBDescription.Size = new System.Drawing.Size(270, 232);
            this.rTBDescription.TabIndex = 7;
            this.rTBDescription.Text = "";
            // 
            // UserProgress
            // 
            this.UserProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserProgress.Location = new System.Drawing.Point(0, 53);
            this.UserProgress.Name = "UserProgress";
            this.UserProgress.Size = new System.Drawing.Size(387, 23);
            this.UserProgress.TabIndex = 8;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 104);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(91, 24);
            this.lblLocation.TabIndex = 9;
            this.lblLocation.Text = "Location";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 152);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 28);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 204);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 21);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblAttachment
            // 
            this.lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(3, 461);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(91, 25);
            this.lblAttachment.TabIndex = 12;
            this.lblAttachment.Text = "Attach File";
            // 
            // cBCategory
            // 
            this.cBCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategory.FormattingEnabled = true;
            this.cBCategory.Location = new System.Drawing.Point(105, 152);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(270, 28);
            this.cBCategory.TabIndex = 13;
            this.cBCategory.Text = "Select a Category";
            // 
            // ReportIssuesForm
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(387, 549);
            this.Controls.Add(this.rTBDescription);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.UserProgress);
            this.Controls.Add(this.tBLocation);
            this.Controls.Add(this.tBAttachment);
            this.Controls.Add(this.mSMenu);
            this.Controls.Add(this.tSTopBat);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mSMenu;
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tSTopBat.ResumeLayout(false);
            this.tSTopBat.PerformLayout();
            this.mSMenu.ResumeLayout(false);
            this.mSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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