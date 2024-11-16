using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;

namespace PROG7312_POE
{
    public partial class LocalEventsAndAnnouncementsForm : Form
    {
        ValidationClass valClass = new ValidationClass();
        EventManagement em = new EventManagement();
        public List<string> categoryList = new List<string> { "Water and Sanitation", "Electricy and Loadshedding", "Roads and Potholes", "Waster Management", "Public Transport", "Community Safety and Security", "Parks and Public Spaces", "Housing", "Noise Complaints", "Environmental Health", "Traffic and Transport Infrastructure", "Animal Control and Wildlife" };

        private int[] sortStates = new int[3];  

        public LocalEventsAndAnnouncementsForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            AutoSizeControls(this); // Auto-size the controls
            AutoSizeForm(); // Auto-size the form based on the controls
            lVEventsandAnnoucements.Items.Clear();
            cLBCategory.Items.Clear();
            loadCategories();
        }

        private void tSLExitLEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> selectedCategories = new List<string>();
            List<EventClass> selectedEvents = new List<EventClass>();

            if (cLBCategory.Enabled && !dTPFromDate.Enabled)
            {


                for (int i = 0; i < cLBCategory.Items.Count; i++)
                {
                    if (cLBCategory.GetItemChecked(i))
                    {
                        selectedCategories.Add(cLBCategory.GetItemText(i));
                    }
                }

                if (valClass.allCategoriesValid(selectedCategories, categoryList))
                {
                    //Go off and get events based on selected categories
                    selectedEvents = em.CategoryFilter(selectedCategories);
                }
                else
                {

                }

            }
            else if (dTPToDate.Enabled && dTPFromDate.Enabled && !cLBCategory.Enabled)
            {
                DateTime FromDate = dTPFromDate.Value;
                DateTime ToDate = dTPToDate.Value;

                if (valClass.isValidDates(FromDate, ToDate))
                {
                    selectedEvents = em.DateFilter(FromDate, ToDate);
                }
                else
                {
                    //error
                }
            }
            else if (cLBCategory.Enabled && dTPFromDate.Enabled && dTPToDate.Enabled)
            {


                DateTime FromDate = dTPFromDate.Value;
                DateTime ToDate = dTPToDate.Value;

                for (int i = 0; i < cLBCategory.Items.Count; i++)
                {
                    if (cLBCategory.GetItemChecked(i))
                    {
                        selectedCategories.Add(cLBCategory.GetItemText(i));
                    }
                }

                if (valClass.allCategoriesValid(selectedCategories, categoryList) && valClass.isValidDates(FromDate, ToDate))
                {
                    //Go off and get events based on selected categories & Dates
                    selectedEvents = em.CategoryandDateFilter(selectedCategories, FromDate, ToDate);


                }
                else
                {

                }
            }
            else if (!(cLBCategory.Enabled && dTPFromDate.Enabled && dTPToDate.Enabled))
            {
                selectedEvents = em.GetAll();
            }

            lVEventsandAnnoucements.Items.Clear();
            lVEventsandAnnoucements.Groups.Clear();

            ListViewGroup EventGroup = new ListViewGroup("Events");
            ListViewGroup AnnounceGroup = new ListViewGroup("Announcements");

            lVEventsandAnnoucements.Groups.Add(EventGroup);
            lVEventsandAnnoucements.Groups.Add(AnnounceGroup);

            foreach (var evt in selectedEvents)
            {
                ListViewItem item = new ListViewItem(evt.EventName);
                item.SubItems.Add(evt.EventDate.ToShortDateString());
                item.SubItems.Add(evt.EventCategory);

                item.Group = EventGroup;

                lVEventsandAnnoucements.Items.Add(item);
            }
            AutoResizeColumns();
        }

        private void cBCategory_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBCategory.CheckState == CheckState.Checked)
            {
                cLBCategory.Enabled = true;
            }
            if (cBCategory.CheckState == CheckState.Unchecked)
            {
                cLBCategory.Enabled = false;
            }

        }

        private void cBDate_CheckStateChanged(object sender, EventArgs e)
        {
            if (cBDate.CheckState == CheckState.Checked)
            {
                dTPFromDate.Enabled = true;
                dTPToDate.Enabled = true;
            }
            if (cBDate.CheckState == CheckState.Unchecked)
            {
                dTPToDate.Enabled = false;
                dTPFromDate.Enabled = false;
            }
        }

        private void loadCategories()
        {
            foreach (string category in categoryList)
            {
                cLBCategory.Items.Add(category);
                tVCategories.Nodes[0].Nodes.Add(category);
            }
        }

        private void lVEventsandAnnoucements_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var eventItems = lVEventsandAnnoucements.Items.Cast<ListViewItem>().ToList();

            // Reset sort state for other columns
            for (int i = 0; i < sortStates.Length; i++)
            {
                if (i != e.Column) sortStates[i] = 2; // Reset state for other columns
            }

            // Determine sort order for the clicked column
            switch (sortStates[e.Column])
            {
                case 0: // Ascending
                    if (e.Column == 0) // Event Name
                        eventItems = eventItems.OrderBy(item => item.Text).ToList();
                    else if (e.Column == 1) // Date
                        eventItems = eventItems.OrderBy(item => DateTime.Parse(item.SubItems[1].Text)).ToList();
                    else if (e.Column == 2) // Category
                        eventItems = eventItems.OrderBy(item => item.SubItems[2].Text).ToList();

                    sortStates[e.Column] = 1; // Change to Descending
                    break;

                case 1: // Descending
                    if (e.Column == 0) // Event Name
                        eventItems = eventItems.OrderByDescending(item => item.Text).ToList();
                    else if (e.Column == 1) // Date
                        eventItems = eventItems.OrderByDescending(item => DateTime.Parse(item.SubItems[1].Text)).ToList();
                    else if (e.Column == 2) // Category
                        eventItems = eventItems.OrderByDescending(item => item.SubItems[2].Text).ToList();

                    sortStates[e.Column] = 2; // Change to Reset
                    break;

                case 2: // Reset
                        // You may want to sort based on the original order or implement custom reset logic
                    eventItems = eventItems.OrderBy(item => item.Text).ToList(); // For example, reset to Event Name sorting
                    sortStates[e.Column] = 0; // Change to Ascending for next click
                    break;
            }

            // Clear the ListView and re-add sorted items
            lVEventsandAnnoucements.Items.Clear();
            lVEventsandAnnoucements.Items.AddRange(eventItems.ToArray());
            AutoResizeColumns();
        }

        private void AutoResizeColumns()
        {
            foreach (ColumnHeader column in lVEventsandAnnoucements.Columns)
            {
                column.Width = -2; // -2 means auto size to fit the content
            }
        }


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Done By ChatGPT (There is Zero way I would even know this)
        /// </summary>
        
        private void tSTopBar_MouseDown(object sender, MouseEventArgs e)
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
            //const int HTCLIENT = 1;
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

        private void AutoSizeControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Skip controls that don't need resizing
                if (control is ToolStrip || control is MenuStrip || !control.Visible)
                    continue;

                // Customize minimum and maximum sizes for different control types
                Size preferredSize = control.GetPreferredSize(new Size(int.MaxValue, int.MaxValue));

                // Set minimum and maximum sizes based on control type
                int minWidth = 50, minHeight = 20, maxWidth = int.MaxValue, maxHeight = int.MaxValue;

                // Customize sizes for specific controls
                if (control is DateTimePicker)
                {
                    minWidth = 100;
                    minHeight = 30;
                    maxWidth = 250;
                }
                else if (control is Button)
                {
                    minWidth = 75;
                    minHeight = 30;
                    maxWidth = 150;
                    maxHeight = 50;
                }
                else if (control is CheckedListBox)
                {
                    minWidth = 150;
                    minHeight = 100;
                    maxWidth = 300;
                    maxHeight = 200;
                }
                else if (control is ListView)
                {
                    minWidth = 200;
                    minHeight = 150;
                    maxWidth = 800;
                    maxHeight = 400;
                }
                else if (control is Label)
                {
                    minWidth = 50;
                    minHeight = 20;
                    maxWidth = 400;
                    maxHeight = int.MaxValue; // Labels can expand vertically
                }

                // Set control size while respecting min and max limits
                control.Width = Math.Max(minWidth, Math.Min(maxWidth, preferredSize.Width));
                control.Height = Math.Max(minHeight, Math.Min(maxHeight, preferredSize.Height));

                // If the control contains other controls, auto-size those too
                if (control.Controls.Count > 0)
                {
                    AutoSizeControls(control); // Recursive call for child controls
                }
            }
        }

        private void AutoSizeForm()
        {
            // Calculate the required size for the form based on its contents
            int padding = 20; // Additional padding around the form
            int requiredWidth = this.Padding.Left + this.Padding.Right + this.Width;
            int requiredHeight = this.Padding.Top + this.Padding.Bottom + this.Height;

            foreach (Control control in this.Controls)
            {
                // Consider the size of the control and its location
                requiredWidth = Math.Max(requiredWidth, control.Right + this.Padding.Right);
                requiredHeight = Math.Max(requiredHeight, control.Bottom + this.Padding.Bottom);
            }

            // Set the form's size
            this.Size = new Size(requiredWidth + padding, requiredHeight + padding);
        }

        private void cBCategory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tVCategories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text != "Categories")
            {

            }
        }
    }

 
}
