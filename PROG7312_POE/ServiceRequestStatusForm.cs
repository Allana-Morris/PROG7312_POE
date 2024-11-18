using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class ServiceRequestStatusForm : Form
    {
        private RedBlackTree redBlackTree = new RedBlackTree();
        private bool isFilter = false;
        private MinHeap minHeap = new MinHeap();
        EnumManager enumManager;

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            LoadRequestsFromTree(redBlackTree);
            minHeap.loadHeap(redBlackTree);
            loadCB();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Exits/ Closes Form
        /// </summary>
        private void TSMIReturnToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Exits/ Closes Form
        /// </summary>
        private void tSlblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Loads values into Priority Combobox
        /// </summary>
        public void loadCB()
        {
            cBPriority.Items.Clear(); // Clear any existing items

            foreach (var priority in Enum.GetValues(typeof(RequestPriority)).Cast<RequestPriority>())
            {
                // Get the description for each enum value and add it to the ComboBox
                cBPriority.Items.Add(priority.ToString());
            }
            cBPriority.SelectedItem = RequestPriority.All.ToString();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Adds details of the ReportedRequest Selected
        /// </summary>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var selectedRequest = GetSelectedRequest();

            if (selectedRequest != null)
            {
                // Build the text for the RichTextBox
                string requestDetails = $"Request Location: {selectedRequest.UserLocation}\n" +   // Request Location
                                        $"Category: {enumManager.GetEnumDescription(selectedRequest.Category)}\n" +          // Category
                                        $"Description:\n{selectedRequest.Description}\n\n" + // Description
                                        $"Customer Name: {selectedRequest.Customer.Name}\n" + // Customer Name
                                        $"Customer Contact Number: {selectedRequest.Customer.ContactNumber}"; // Customer Contact Number

                // Set the RichTextBox text to the built string
                rTBDetails.Text = requestDetails;
                rTBDetails.Refresh();
            }
            else
            {
                rTBDetails.Text = "No request selected.";
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Gets the ReportedRequest object of the selected Item in the Listview
        /// </summary>
        private ReportedRequest GetSelectedRequest()
        {
            if (lVRequests.SelectedItems.Count > 0)
            {

                string selectedRequestname = lVRequests.SelectedItems[0].Text;

                var rbt = new RedBlackTree();

                return rbt.nameSearch(selectedRequestname);
            }
            else
            {
                return null;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Gets the progress of the ReportedRequest and Displays it visually
        /// </summary>
        private void btnTrackProgress_Click(object sender, EventArgs e)
        {
            var selectedRequest = GetSelectedRequest();
            if (selectedRequest != null)
            {
                pBRequestProgress.Value = selectedRequest.Progress;
                lblPercentage.Text = $"{selectedRequest.Progress}% Complete...";
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Loads ReportedRequests from tree into List view
        /// </summary>
        public void LoadRequestsFromTree(RedBlackTree tree)
        {
            // Clear existing items and columns in the ListView
            lVRequests.Items.Clear();
            lVRequests.Columns.Clear();

            // Perform in-order traversal to get a sorted list of ServiceRequests
            var requests = tree.GetRequestsForListView();

            // Optionally, sort requests by Category before adding to ListView
            requests = requests.OrderBy(r => r.RequestName).ToList(); // Sort by Request Name

            // Set up the ListView to display details
            lVRequests.View = View.Details;

            // Add columns to the ListView for displaying data
            lVRequests.Columns.Add("Request ID", 75);
            lVRequests.Columns.Add("Category", 200);
            lVRequests.Columns.Add("Location", 125);
            lVRequests.Columns.Add("Priority", 100);
            lVRequests.Columns.Add("Date Reported", 100);
            lVRequests.Columns.Add("Status", 75);

            // Add each request to the ListView
            foreach (var request in requests)
            {
                var priority = request.AssignPriority(request.Category).ToString();
                var item = new ListViewItem(request.RequestName);
                item.SubItems.Add(enumManager.GetEnumDescription(request.Category));
                item.SubItems.Add(enumManager.GetEnumDescription(request.UserLocation));
                item.SubItems.Add(priority);
                item.SubItems.Add(request.RequestDate.ToShortDateString());
                item.SubItems.Add(enumManager.GetEnumDescription(request.Status));

                lVRequests.Items.Add(item);
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Not Accessable
        /// Updates Status of an Item in the Listview
        /// </summary>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReportedRequest sRequest = GetSelectedRequest();
            Random rand = new Random();

            // Generate random values for the hour, minute, and second
            int hour = rand.Next(0, 24);    // Random hour between 0 and 23
            int minute = rand.Next(0, 60);  // Random minute between 0 and 59
            int second = rand.Next(0, 60);  // Random second between 0 and 59

            // Create a random time with today's date, but with the random time values
            DateTime randomTime = DateTime.Today.AddHours(hour).AddMinutes(minute).AddSeconds(second);
            int prog = rand.Next(0, 100);
            sRequest.UpdateStatus(prog, randomTime);
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// adds all the ReportedRequests where the Filtered Priority applies to the Listview
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                cBPriority.Text = RequestPriority.All.ToString();
                LoadRequestsFromTree(redBlackTree);
            }
            else
            {
                string selectedPriority = cBPriority.SelectedItem.ToString();

                // Convert the selected priority to the RequestPriority enum
                RequestPriority priority = selectedPriority switch
                {
                    "High" => RequestPriority.High,
                    "Medium" => RequestPriority.Medium,
                    "Low" => RequestPriority.Low,
                    _ => RequestPriority.All // Default to High if "All" is selected
                };

                if (priority == RequestPriority.All)
                {
                    LoadRequestsFromTree(redBlackTree);
                }
                else
                {
                    // Filter the ListView based on the selected priority
                    FilterByPriority(priority);
                }
            }

            // Toggle the state for the next click
            isFilter = !isFilter;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Returns all the ReportedRequests that fall under the selected Priority
        /// </summary>
        private void FilterByPriority(RequestPriority priorityFilter)
        {
            // Clear the existing items
            lVRequests.Items.Clear();
            lVRequests.Columns.Clear();

            lVRequests.View = View.Details;

            // Add columns to the ListView for displaying data
            lVRequests.Columns.Add("Request ID", 75);
            lVRequests.Columns.Add("Category", 200);
            lVRequests.Columns.Add("Location", 125);
            lVRequests.Columns.Add("Priority", 100);
            lVRequests.Columns.Add("Date Reported", 100);
            lVRequests.Columns.Add("Status", 75);

            // Loop through the heap and add each item to the ListView based on priority filter
            foreach (var request in minHeap.GetHeapContent())
            {
                // Get the priority of the current request
                RequestPriority priority = request.AssignPriority(request.Category);

                // Only add items that match the filter, or show all if filter is "All"
                if (priority == priorityFilter)
                {
                    var itempriority = request.AssignPriority(request.Category).ToString();
                    var item = new ListViewItem(request.RequestName);
                    item.SubItems.Add(enumManager.GetEnumDescription(request.Category));
                    item.SubItems.Add(enumManager.GetEnumDescription(request.UserLocation));
                    item.SubItems.Add(itempriority);
                    item.SubItems.Add(request.RequestDate.ToShortDateString());
                    item.SubItems.Add(enumManager.GetEnumDescription(request.Status));

                    // Add the item to the ListView
                    lVRequests.Items.Add(item);
                }
            }
        }

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
            // const int HTCLIENT = 1;
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
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//