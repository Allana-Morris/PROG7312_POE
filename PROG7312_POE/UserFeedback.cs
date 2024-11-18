using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROG7312_POE
{
    public partial class UserFeedback : Form
    {
        ValidationClass val = new ValidationClass();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public UserFeedback()
        {
            InitializeComponent();
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Submits and Stores the User's Feedback
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtAdvice.Text)) || (CLBSatisfied.SelectedIndex < 0))
            {
                MessageBox.Show("Please provide us with some valuable feedback" +
                    "\nThis will be used to better our services");
            }
            else
            {
                string userAdvice = txtAdvice.Text;
                string userSatisfied = CLBSatisfied.SelectedItem.ToString();
                FeedbackClass feedback = new FeedbackClass(userSatisfied, userAdvice);
                this.Close();
            }
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Exits/ Closes Form
        /// </summary>
        private void tSlblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//