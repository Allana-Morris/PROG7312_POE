namespace PROG7312_POE
{
    partial class UserFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFeedback));
            this.tSTopbar = new System.Windows.Forms.ToolStrip();
            this.tSlblTitle = new System.Windows.Forms.ToolStripLabel();
            this.tSlblExit = new System.Windows.Forms.ToolStripLabel();
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.TSMIMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIReturnToHome = new System.Windows.Forms.ToolStripMenuItem();
            this.CLBSatisfied = new System.Windows.Forms.CheckedListBox();
            this.lblSatisfied = new System.Windows.Forms.Label();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tSTopbar.SuspendLayout();
            this.mSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSTopbar
            // 
            this.tSTopbar.BackColor = System.Drawing.Color.MidnightBlue;
            this.tSTopbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSTopbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSTopbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tSTopbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSlblTitle,
            this.tSlblExit});
            this.tSTopbar.Location = new System.Drawing.Point(0, 0);
            this.tSTopbar.Name = "tSTopbar";
            this.tSTopbar.Size = new System.Drawing.Size(410, 31);
            this.tSTopbar.TabIndex = 0;
            this.tSTopbar.Text = "toolStrip1";
            // 
            // tSlblTitle
            // 
            this.tSlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSlblTitle.ForeColor = System.Drawing.Color.White;
            this.tSlblTitle.Image = global::PROG7312_POE.Properties.Resources.Feedback;
            this.tSlblTitle.Name = "tSlblTitle";
            this.tSlblTitle.Size = new System.Drawing.Size(93, 28);
            this.tSlblTitle.Text = "Feedback";
            // 
            // tSlblExit
            // 
            this.tSlblExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSlblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSlblExit.ForeColor = System.Drawing.Color.White;
            this.tSlblExit.Name = "tSlblExit";
            this.tSlblExit.Size = new System.Drawing.Size(21, 28);
            this.tSlblExit.Text = "X";
            this.tSlblExit.Click += new System.EventHandler(this.tSlblExit_Click);
            // 
            // mSMenu
            // 
            this.mSMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mSMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIMenu});
            this.mSMenu.Location = new System.Drawing.Point(0, 31);
            this.mSMenu.Name = "mSMenu";
            this.mSMenu.Size = new System.Drawing.Size(410, 30);
            this.mSMenu.TabIndex = 1;
            this.mSMenu.Text = "menuStrip1";
            // 
            // TSMIMenu
            // 
            this.TSMIMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIReturnToHome});
            this.TSMIMenu.Name = "TSMIMenu";
            this.TSMIMenu.Size = new System.Drawing.Size(64, 26);
            this.TSMIMenu.Text = "Menu";
            // 
            // tSMIReturnToHome
            // 
            this.tSMIReturnToHome.Name = "tSMIReturnToHome";
            this.tSMIReturnToHome.Size = new System.Drawing.Size(224, 26);
            this.tSMIReturnToHome.Text = "Return to Home";
            // 
            // CLBSatisfied
            // 
            this.CLBSatisfied.BackColor = System.Drawing.Color.Gainsboro;
            this.CLBSatisfied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLBSatisfied.ColumnWidth = 75;
            this.CLBSatisfied.FormattingEnabled = true;
            this.CLBSatisfied.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CLBSatisfied.Location = new System.Drawing.Point(20, 126);
            this.CLBSatisfied.MultiColumn = true;
            this.CLBSatisfied.Name = "CLBSatisfied";
            this.CLBSatisfied.Size = new System.Drawing.Size(342, 17);
            this.CLBSatisfied.TabIndex = 2;
            // 
            // lblSatisfied
            // 
            this.lblSatisfied.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSatisfied.AutoSize = true;
            this.lblSatisfied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisfied.Location = new System.Drawing.Point(16, 85);
            this.lblSatisfied.Name = "lblSatisfied";
            this.lblSatisfied.Size = new System.Drawing.Size(328, 20);
            this.lblSatisfied.TabIndex = 3;
            this.lblSatisfied.Text = "How Satisfied Are You With Our Services?";
            this.lblSatisfied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdvice
            // 
            this.txtAdvice.Location = new System.Drawing.Point(20, 220);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(343, 132);
            this.txtAdvice.TabIndex = 4;
            // 
            // lblAdvice
            // 
            this.lblAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.Location = new System.Drawing.Point(23, 197);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(273, 20);
            this.lblAdvice.TabIndex = 5;
            this.lblAdvice.Text = "Let Us Know How We Can Improve";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(310, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserFeedback
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(410, 421);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.lblSatisfied);
            this.Controls.Add(this.CLBSatisfied);
            this.Controls.Add(this.mSMenu);
            this.Controls.Add(this.tSTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mSMenu;
            this.Name = "UserFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tSTopbar.ResumeLayout(false);
            this.tSTopbar.PerformLayout();
            this.mSMenu.ResumeLayout(false);
            this.mSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnToHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tSTopbar;
        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.ToolStripLabel tSlblTitle;
        private System.Windows.Forms.ToolStripLabel tSlblExit;
        private System.Windows.Forms.ToolStripMenuItem TSMIMenu;
        private System.Windows.Forms.ToolStripMenuItem tSMIReturnToHome;
        private System.Windows.Forms.CheckedListBox CLBSatisfied;
        private System.Windows.Forms.Label lblSatisfied;
        private System.Windows.Forms.TextBox txtAdvice;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnSubmit;
    }
}