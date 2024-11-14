namespace PROG7312_POE
{
    partial class CustomerInput
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
            btnSubmit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            tBName = new System.Windows.Forms.TextBox();
            tBNumber = new System.Windows.Forms.TextBox();
            tBEmail = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.SystemColors.ControlLight;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSubmit.Location = new System.Drawing.Point(13, 319);
            btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(89, 32);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Location = new System.Drawing.Point(162, 319);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(275, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = System.Drawing.Color.White;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(170, 22);
            toolStripLabel1.Text = "Enter Your Details:";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripLabel2.ForeColor = System.Drawing.Color.White;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            toolStripLabel2.Size = new System.Drawing.Size(21, 22);
            toolStripLabel2.Text = "X";
            // 
            // tBName
            // 
            tBName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            tBName.Location = new System.Drawing.Point(13, 72);
            tBName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tBName.Name = "tBName";
            tBName.Size = new System.Drawing.Size(249, 28);
            tBName.TabIndex = 4;
            // 
            // tBNumber
            // 
            tBNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            tBNumber.Location = new System.Drawing.Point(13, 153);
            tBNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tBNumber.Name = "tBNumber";
            tBNumber.Size = new System.Drawing.Size(249, 28);
            tBNumber.TabIndex = 5;
            // 
            // tBEmail
            // 
            tBEmail.Location = new System.Drawing.Point(13, 243);
            tBEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tBEmail.Name = "tBEmail";
            tBEmail.Size = new System.Drawing.Size(249, 28);
            tBEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(13, 47);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 22);
            label1.TabIndex = 8;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label2.Location = new System.Drawing.Point(13, 128);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 22);
            label2.TabIndex = 9;
            label2.Text = "Contact Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label3.Location = new System.Drawing.Point(13, 218);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 22);
            label3.TabIndex = 10;
            label3.Text = "Email:";
            // 
            // CustomerInput
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(275, 373);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBEmail);
            Controls.Add(tBNumber);
            Controls.Add(tBName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Font = new System.Drawing.Font("MS Reference Sans Serif", 10F);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CustomerInput";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CustomerInput";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBNumber;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}