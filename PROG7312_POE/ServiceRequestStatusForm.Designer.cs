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
            listView1 = new System.Windows.Forms.ListView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
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
            mSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            mSMenu.Size = new System.Drawing.Size(912, 28);
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
            tSTopBat.Size = new System.Drawing.Size(912, 25);
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
            // listView1
            // 
            listView1.Location = new System.Drawing.Point(12, 105);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(888, 186);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(166, 297);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 29);
            button1.TabIndex = 5;
            button1.Text = "View Details";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(598, 297);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(118, 29);
            button2.TabIndex = 6;
            button2.Text = "Track Progress";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(0, 333);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            richTextBox1.Size = new System.Drawing.Size(912, 145);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar1);
            panel1.Location = new System.Drawing.Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(912, 56);
            panel1.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(363, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(459, 29);
            progressBar1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(21, 437);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ServiceRequestStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(912, 647);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(mSMenu);
            Controls.Add(tSTopBat);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}