using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.TreeClass;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

///TO DO
///- add page that displays all reported issues done in session
///- allow for more than one file upload
///- add docx file support
///- show list of uploaded files (allow for add more or delete on preview of uploaded files)
///- funky-afy the progress bar
///- look into resizeable pages
///- look into moveable pages
///- user help tips
///- show preview of reported issues on selection in list of all submitions
///- jazz up AI code
///- AI declaration for code
///- Keep the Windows 95 theme running
///- Exception handling 
///- Add code references
///- Better comments 

namespace PROG7312_POE
{
    public partial class ReportIssuesForm : Form
    {
        private int totalBoxes = 4;

        private string userFileName;
        private byte[] userFileData;

        ValidationClass val = new ValidationClass();

        RequestCategory catList = new RequestCategory();

        private RedBlackTree bst = new RedBlackTree();

        List<ReportedRequest> issueList = new List<ReportedRequest>();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public ReportIssuesForm()
        {
            InitializeComponent();

            loadCategories();

            UserProgress.Minimum = 0;
            UserProgress.Maximum = totalBoxes;
            UserProgress.Value = 0;

            tBLocation.TextChanged += new EventHandler(TextBox_TextChanged);
            cBCategory.TextChanged += new EventHandler(TextBox_TextChanged);
            rTBDescription.TextChanged += new EventHandler(TextBox_TextChanged);
            tBAttachment.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void loadCategories()
        {
            cBCategory.Items.Clear(); // Clear any existing items

            foreach (var category in Enum.GetValues(typeof(RequestCategory)).Cast<RequestCategory>())
            {
                // Get the description for each enum value and add it to the ComboBox
                cBCategory.Items.Add(GetEnumDescription(category));
            }

            // Optionally set the ComboBox to the first item by default
            if (cBCategory.Items.Count > 0)
            {
                cBCategory.SelectedIndex = 0;
            }
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void tSlblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void returnToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement OpenFileDialog to attach media
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Attach Image or Document";
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Handle attachment 
                    tBAttachment.Text = openFileDialog.SafeFileName;
                    userFileName = Path.GetFileName(openFileDialog.FileName);
                    userFileData = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            { }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Check how many textboxes have more than 1 character
            int filledCount = 0;

            if (tBLocation.Text.Length > 1) filledCount++;
            if (cBCategory.Text.Length > 1 && cBCategory.Text != "Select a Category") filledCount++;
            if (rTBDescription.Text.Length > 1) filledCount++;
            if (tBAttachment.Text.Length > 1) filledCount++;

            // Update ProgressBar value
            UserProgress.Value = filledCount;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userLocation = "";
            string userCategory = "";
            string userDescription = "";
            Customer customer = null;
            RequestCategory category = RequestCategory.None;

            if (UserProgress.Value == 4)
            {
                using (CustomerInput customerInputForm = new CustomerInput())
                {
                    if (customerInputForm.ShowDialog() == DialogResult.OK)
                    {
                        customer = customerInputForm.CustomerDetails;
                    }
                }

                if (string.IsNullOrEmpty(userFileName))
                {
                    MessageBox.Show("Please upload a file before submitting the issue report");
                    return;
                }

                if (val.isString(tBLocation.Text)) userLocation = tBLocation.Text;
                if (val.isString(rTBDescription.Text)) userDescription = rTBDescription.Text;
                if (cBCategory.Text != "Select a Category") userCategory = cBCategory.Text;
                bool isMatchFound = false;


                foreach (var cat in Enum.GetValues(typeof(RequestCategory)).Cast<RequestCategory>())
                {
                    // Get the description of the enum value
                    var description = GetEnumDescription(cat);

                    if (cBCategory.Text == description)
                    {
                        category = cat;
                        isMatchFound = true; // A match was found
                        break; // Exit the loop early since we found a match
                    }
                }
                if (!isMatchFound)
                {
                    // Display an error message if no match was found
                    MessageBox.Show("The selected category does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReportedRequest issue = new ReportedRequest(customer, userDescription, category, userLocation, userFileName, userFileData);


                issueList.Add(issue);
                bst.Insert(issue);

                MessageBox.Show("Issue reported successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Issue Request");
            }
        }

        private string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void tSTopBat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture and send a message to allow dragging
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            // Process the window message for resizing
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                // Get the mouse position
                Point pt = this.PointToClient(new Point(m.LParam.ToInt32()));
                Size clientSize = this.ClientSize;

                // Determine the resize direction based on the mouse position
                if (pt.X < 5 && pt.Y < 5)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (pt.X > clientSize.Width - 5 && pt.Y < 5)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (pt.X < 5 && pt.Y > clientSize.Height - 5)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (pt.X > clientSize.Width - 5 && pt.Y > clientSize.Height - 5)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (pt.X < 5)
                    m.Result = (IntPtr)HTLEFT;
                else if (pt.X > clientSize.Width - 5)
                    m.Result = (IntPtr)HTRIGHT;
                else if (pt.Y < 5)
                    m.Result = (IntPtr)HTTOP;
                else if (pt.Y > clientSize.Height - 5)
                    m.Result = (IntPtr)HTBOTTOM;
                else
                    m.Result = (IntPtr)HTCAPTION;

                return;
            }
            base.WndProc(ref m);
        }

        // Import necessary methods for window dragging
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
