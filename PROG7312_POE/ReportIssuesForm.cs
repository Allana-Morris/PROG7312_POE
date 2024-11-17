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


namespace PROG7312_POE
{
    public partial class ReportIssuesForm : Form
    {
        private int totalBoxes = 4;

        private string userFileName = "";  // Initialize as an empty string
        private byte[] userFileData = new byte[0];  // Initialize as an empty byte array

        ValidationClass val = new ValidationClass();

        private RedBlackTree rbt = new RedBlackTree();

        List<ReportedRequest> issueList = new List<ReportedRequest>();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public ReportIssuesForm()
        {
            InitializeComponent();


            loadEnums();

            pBProgress.Minimum = 0;
            pBProgress.Maximum = totalBoxes;
            pBProgress.Value = 0;

            cBLocation.TextChanged += new EventHandler(TextBox_TextChanged);
            cBCategory.TextChanged += new EventHandler(TextBox_TextChanged);
            rTBDescription.TextChanged += new EventHandler(TextBox_TextChanged);
            tVFiles.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void loadEnums()
        {
            cBCategory.Items.Clear(); // Clear any existing items
            cBLocation.Items.Clear();
            string noneString = "";

            foreach (var category in Enum.GetValues(typeof(RequestCategory)).Cast<RequestCategory>())
            {
                if(category == RequestCategory.None)
                {
                    noneString = GetEnumDescription(category);
                }
                // Get the description for each enum value and add it to the ComboBox
                cBCategory.Items.Add(GetEnumDescription(category));
            }

            cBCategory.Sorted = true;
            cBCategory.Items.Remove(noneString);

            if (cBCategory.Items.Count > 0)
            {
                cBCategory.Text = noneString;
            }


            foreach (var city in Enum.GetValues(typeof(SouthAfricanCities)).Cast<SouthAfricanCities>())
            {
                if (city == SouthAfricanCities.None)
                {
                    noneString = GetEnumDescription(city);
                }
                // Get the description for each enum value and add it to the ComboBox
                cBLocation.Items.Add(GetEnumDescription(city));
            }

            cBLocation.Sorted = true;
            cBLocation.Items.Remove(noneString);

            // Optionally set the ComboBox to the first item by default
            if (cBLocation.Items.Count > 0)
            {
                cBLocation.Text = noneString;
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
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Title = "Attach Image or Document";
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder fileNames = new StringBuilder();
                    List<byte[]> fileDataList = new List<byte[]>();
                    tVFiles.Nodes.Clear();

                    TreeNode rootNode = new TreeNode("Attached Files");
                    tVFiles.Nodes.Add(rootNode);

                    foreach (string file in openFileDialog.FileNames)
                    {

                        fileNames.AppendLine(Path.GetFileName(file));  // Store the file names
                        byte[] fileData = File.ReadAllBytes(file);  // Read file data
                        fileDataList.Add(fileData);  // Store file data
                        TreeNode node = new TreeNode(Path.GetFileName(file))
                        {
                            Tag = file // Store the full file path in the Tag property
                        };

                        // Add the file node to the root node
                        rootNode.Nodes.Add(node);
                    }
                    tVFiles.ExpandAll();
                    // Store file data for future processing
                    userFileName = string.Join(", ", openFileDialog.SafeFileNames); // Set the file names
                    userFileData = fileDataList.SelectMany(fd => fd).ToArray();  // Combine all file data into a byte array
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Check how many textboxes have more than 1 character
            int filledCount = 0;

            if (cBLocation.Text.Length > 1 && cBLocation.Text != "Select Your Location") filledCount++;
            if (cBCategory.Text.Length > 1 && cBCategory.Text != "Select a Category") filledCount++;
            if (rTBDescription.Text.Length > 1) filledCount++;
            if (tVFiles.Text.Length > 1) filledCount++;

            // Update ProgressBar value
            pBProgress.Value = filledCount;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Fields to capture user inputs
            string userDescription = "";
            Customer customer = null;
            RequestCategory category = RequestCategory.None;
            SouthAfricanCities location = SouthAfricanCities.None;

            // Ensure the user has completed all steps (ProgressBar value should be 4)
            if (pBProgress.Value == 4)
            {
                // Prompt for customer details
                using (CustomerInput customerInputForm = new CustomerInput())
                {
                    if (customerInputForm.ShowDialog() == DialogResult.OK)
                    {
                        customer = customerInputForm.CustomerDetails;
                    }
                    else
                    {
                        MessageBox.Show("Customer details are required to submit the issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // Exit if customer details are not provided
                    }
                }

                // Ensure a file is uploaded before proceeding
                if (string.IsNullOrEmpty(userFileName) || userFileData == null || userFileData.Length == 0)
                {
                    MessageBox.Show("Please upload a file before submitting the issue report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if no file is uploaded
                }

                // Validate location and description inputs
                if (val.isString(rTBDescription.Text)) userDescription = rTBDescription.Text;

                // Validate and match the selected category
                bool isMatchFound = false;
                bool isMatch = false;  
                foreach (var cat in Enum.GetValues(typeof(RequestCategory)).Cast<RequestCategory>())
                {
                    var description = GetEnumDescription(cat);
                    if (cBCategory.Text == description)
                    {
                        category = cat;
                        isMatchFound = true;
                        break; // Exit the loop early since we found a match
                    }
                }

                if (!isMatchFound)
                {
                    MessageBox.Show("The selected category does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var city in Enum.GetValues(typeof(SouthAfricanCities)).Cast<SouthAfricanCities>())
                {
                    var description = GetEnumDescription(city);
                    if (cBCategory.Text == description)
                    {
                        location = city;
                        isMatch = true;
                        break; // Exit the loop early since we found a match
                    }
                }

                if (!isMatch)
                {
                    MessageBox.Show("The selected city does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the ReportedRequest object
                ReportedRequest issue = new ReportedRequest(customer, userDescription, category, location, userFileName, userFileData);

                // Add the issue to the issue list and the tree
                issueList.Add(issue);
                rbt.Insert(issue);

                Console.WriteLine($"Inserted ReportedRequest with ID: {issue.RequestId}");

                // Confirm successful submission
                MessageBox.Show("Issue reported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Invalid state for submission
                MessageBox.Show("Invalid Issue Request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //  const int HTCLIENT = 1;
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

        private void tVFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Retrieve the full file path from the Tag property
            string filePath = selectedNode.Tag as string;

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    // Use Process.Start with the full path to open the file
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath)
                    {
                        UseShellExecute = true // This ensures that the file is opened with the associated application
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file path available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tVFiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the node that was clicked on
                TreeNode selectedNode = tVFiles.GetNodeAt(e.X, e.Y);

                if (selectedNode != null)
                {
                    // Set the selected node for the context menu
                    tVFiles.SelectedNode = selectedNode;
                }
            }
        }

        private void tSMIDelete_Click(object sender, EventArgs e)
        {
            // Get the selected node
            TreeNode selectedNode = tVFiles.SelectedNode;

            if (selectedNode != null)
            {
                // Optionally, you can confirm with the user before deleting
                var confirmation = MessageBox.Show("Are you sure you want to delete this file?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    // Optionally, delete the file from the file system as well
                    string filePath = Path.Combine("yourFilePathHere", selectedNode.Text);  // Adjust the path based on your file storage logic
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);  // Delete the file from the file system
                    }

                    // Remove the node from the TreeView
                    tVFiles.Nodes.Remove(selectedNode);

                    // Optionally, update the file list or do other necessary cleanup
                    MessageBox.Show("File deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
  
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//