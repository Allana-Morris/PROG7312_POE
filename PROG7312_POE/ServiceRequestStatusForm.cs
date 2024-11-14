using PROG7312_POE.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class ServiceRequestStatusForm : Form
    {
        public ServiceRequestStatusForm()
        {
            InitializeComponent();
        }

        private void TSMIReturnToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tSlblExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            var selectedRequest = GetSelectedRequest();

            if (selectedRequest != null)
            {
                // Build the text for the RichTextBox
                string requestDetails = $"Request Location: {selectedRequest.Category}\n" +   // Request Location
                                        $"Category: {selectedRequest.Category}\n" +          // Category
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

        private ReportedRequest GetSelectedRequest()
        {
            if (lVRequests.SelectedItems.Count > 0)
            {
                // Assuming the RequestId is stored in the first column of the ListView
                Guid selectedRequestId = Guid.Parse(lVRequests.SelectedItems[0].Text);

                var rm = new RequestManager();

                // Retrieve the ReportedRequest by ID from your collection or tree
                return rm.GetRequestById(selectedRequestId); // Replace with your actual method to retrieve the request
            }
            else
            {
                return null; // No item selected
            }
        }

        private void btnTrackProgress_Click(object sender, EventArgs e)
        {
            var selectedRequest = GetSelectedRequest();
            if (selectedRequest != null)
            {
                pBRequestProgress.Value = selectedRequest.Progress;         
                lblPercentage.Text = $"{selectedRequest.Progress}% Complete...";
            }
        }
    }
}
