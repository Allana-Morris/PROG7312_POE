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
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tSTopBat = new System.Windows.Forms.ToolStrip();
            this.tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            this.tSlblExit = new System.Windows.Forms.ToolStripLabel();
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.mTSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            this.rTBDescription = new System.Windows.Forms.RichTextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.cBCategory = new System.Windows.Forms.ComboBox();
            this.tVFiles = new System.Windows.Forms.TreeView();
            this.cMSRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cBLocation = new System.Windows.Forms.ComboBox();
            this.pBProgress = new System.Windows.Forms.ProgressBar();
            this.tSTopBat.SuspendLayout();
            this.mSMenu.SuspendLayout();
            this.cMSRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(105, 593);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(291, 633);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 29);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
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
            this.tSTopBat.Size = new System.Drawing.Size(413, 25);
            this.tSTopBat.TabIndex = 2;
            this.tSTopBat.Text = "toolStrip1";
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
            this.tSlblExit.Click += new System.EventHandler(this.TSlblExit_Click);
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
            this.mSMenu.Size = new System.Drawing.Size(413, 28);
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
            this.TSMIReturnToHome.Click += new System.EventHandler(this.ReturnToHomeToolStripMenuItem_Click);
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
            // tVFiles
            // 
            this.tVFiles.ContextMenuStrip = this.cMSRightClick;
            this.tVFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVFiles.Location = new System.Drawing.Point(105, 461);
            this.tVFiles.Name = "tVFiles";
            this.tVFiles.Size = new System.Drawing.Size(270, 126);
            this.tVFiles.TabIndex = 15;
            // 
            // cMSRightClick
            // 
            this.cMSRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMSRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIDelete});
            this.cMSRightClick.Name = "contextMenuStrip1";
            this.cMSRightClick.Size = new System.Drawing.Size(123, 28);
            this.cMSRightClick.Text = "Options";
            // 
            // tSMIDelete
            // 
            this.tSMIDelete.Name = "tSMIDelete";
            this.tSMIDelete.Size = new System.Drawing.Size(122, 24);
            this.tSMIDelete.Text = "Delete";
            this.tSMIDelete.Click += new System.EventHandler(this.TSMIDelete_Click);
            // 
            // cBLocation
            // 
            this.cBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBLocation.FormattingEnabled = true;
            this.cBLocation.Location = new System.Drawing.Point(105, 104);
            this.cBLocation.Name = "cBLocation";
            this.cBLocation.Size = new System.Drawing.Size(270, 28);
            this.cBLocation.TabIndex = 16;
            // 
            // pBProgress
            // 
            this.pBProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBProgress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pBProgress.Location = new System.Drawing.Point(0, 53);
            this.pBProgress.MarqueeAnimationSpeed = 10;
            this.pBProgress.Name = "pBProgress";
            this.pBProgress.Size = new System.Drawing.Size(413, 23);
            this.pBProgress.TabIndex = 17;
            // 
            // ReportIssuesForm
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(413, 674);
            this.Controls.Add(this.pBProgress);
            this.Controls.Add(this.cBLocation);
            this.Controls.Add(this.tVFiles);
            this.Controls.Add(this.rTBDescription);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
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
            this.cMSRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStrip tSTopBat;
        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.RichTextBox rTBDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.ToolStripLabel tSlblTitle;
        private System.Windows.Forms.ToolStripLabel tSlblExit;
        private System.Windows.Forms.ToolStripMenuItem mTSMIMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMIReturnToHome;
        private System.Windows.Forms.ComboBox cBCategory;
        private System.Windows.Forms.TreeView tVFiles;
        private System.Windows.Forms.ContextMenuStrip cMSRightClick;
        private System.Windows.Forms.ToolStripMenuItem tSMIDelete;
        private System.Windows.Forms.ComboBox cBLocation;
        private System.Windows.Forms.ProgressBar pBProgress;
    }
}