﻿using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models.GeoClustering;
using PROG7312_POE.Class.TreeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROG7312_POE.Class.Models.Enums.SouthAfricanProvinces;

namespace PROG7312_POE
{
    public partial class ServiceRequestStatusForm : Form
    {
        private RedBlackTree redBlackTree = new RedBlackTree();
        private bool isGrouped = false;

        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            LoadRequestsFromTree(redBlackTree);
            LoadProvinces();
        }

        private void TSMIReturnToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tSlblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var selectedRequest = GetSelectedRequest();

            if (selectedRequest != null)
            {
                // Build the text for the RichTextBox
                string requestDetails = $"Request Location: {selectedRequest.UserLocation}\n" +   // Request Location
                                        $"Category: {GetEnumDescription(selectedRequest.Category)}\n" +          // Category
                                        $"Description:\n{selectedRequest.Description}\n\n" + // Description
                                        $"Customer Name: {selectedRequest.Customer.Name}\n" + // Customer Name
                                        $"Customer Contact Number: {selectedRequest.Customer.ContactNumber}"; // Customer Contact Number

                // Set the RichTextBox text to the built string
                rTBDetails.Text = requestDetails;
            }
            else
            {
                rTBDetails.Text = "No request selected.";
            }
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
                item.SubItems.Add(GetEnumDescription(request.Category));
                item.SubItems.Add(GetEnumDescription(request.UserLocation));
                item.SubItems.Add(priority);
                item.SubItems.Add(request.RequestDate.ToShortDateString());
                item.SubItems.Add(GetEnumDescription(request.Status));

                lVRequests.Items.Add(item);
            }
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        private void LoadProvinces()
        {
            cBProvince.Items.Clear();
            string noneString = "";
            foreach (var prov in Enum.GetValues(typeof(SouthAfricanProvince)).Cast<SouthAfricanProvince>())
            {
                if (prov == SouthAfricanProvince.None)
                {
                    noneString = GetEnumDescription(prov);
                }
                // Get the description for each enum value and add it to the ComboBox
                cBProvince.Items.Add(GetEnumDescription(prov));
            }

            cBProvince.Sorted = true;
            cBProvince.Items.Remove(noneString);

            // Optionally set the ComboBox to the first item by default
            if (cBProvince.Items.Count > 0)
            {
                cBProvince.Text = noneString;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Get description for Status enum
        /// </summary>
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
        /// 
        /// </summary>
        private void btnGroup_Click(object sender, EventArgs e)
        {
            if (isGrouped)
            {
                // If already grouped, reset to default (clear groups and show all requests)
                LoadProvinces();
                LoadRequestsFromTree(redBlackTree);
            }
            else
            {
                // If not grouped, group the requests by province
                GroupRequestsByProvince(redBlackTree);
            }

            // Toggle the state for the next click
            isGrouped = !isGrouped;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Method to group the requests by province
        /// </summary>
        private void GroupRequestsByProvince(RedBlackTree tree)
        {
            GeoClustering gCluster = new GeoClustering();
            var provinceCluster = gCluster.PerformClustering();
            lVRequests.Items.Clear();
            lVRequests.Columns.Clear();

            // Process each request and group it based on its UserLocation (city)
            // Perform in-order traversal to get a sorted list of ServiceRequests
            var requests = tree.GetRequestsForListView();

            // Optionally, sort requests by Category before adding to ListView
            requests = requests.OrderBy(r => r.UserLocation).ToList();

            // Add columns to the ListView for displaying data
            lVRequests.Columns.Add("Request ID", 75);
            lVRequests.Columns.Add("Category", 200);
            lVRequests.Columns.Add("Location", 125);
            lVRequests.Columns.Add("Priority", 100);
            lVRequests.Columns.Add("Date Reported", 100);
            lVRequests.Columns.Add("Status", 75);

            foreach (var request in requests)
            {
                // Get the province name based on the UserLocation (city)
                string provinceName = GetProvinceFromCity(request.UserLocation);
                // Create a new ListViewItem for this request
                var priority = request.AssignPriority(request.Category).ToString();
                var item = new ListViewItem(request.RequestName);
                item.SubItems.Add(GetEnumDescription(request.Category));
                item.SubItems.Add(GetEnumDescription(request.UserLocation));
                item.SubItems.Add(priority);
                item.SubItems.Add(request.RequestDate.ToShortDateString());
                item.SubItems.Add(GetEnumDescription(request.Status));
                if (cBProvince.Text == provinceName)
                {
                    lVRequests.Items.Add(item);
                }
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Method to get the province name based on the UserLocation (city)
        /// </summary>
        private string GetProvinceFromCity(SouthAfricanCities city)
        {
            foreach (var province in GroupedCitiesByProvince)
            {
                if (province.Value.Any(cityInfo => cityInfo.Description == GetEnumDescription(city)))
                {
                    return province.Key;
                }
            }

            return "Unknown"; // Default value if no matching province is found
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

