using PROG7312_POE.Class;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class StartUp : Form
    {
        private int shutdownCount = 0;

        EventManagement ev = new EventManagement();
        ReportedRequest rr = new ReportedRequest();
        private DateTime now = DateTime.Now;
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public StartUp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ev.LoadEvents();
            rr.LoadExampleRequests();
            string formattedTime = now.ToString("h:mm tt").ToUpper();
            lblTime.Text = formattedTime;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Opens a Start Menu
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (shutdownCount == 0)
            {
                pnlMenu.Visible = true;
                shutdownCount++;
            }
            else
            {
                pnlMenu.Visible = false;
                shutdownCount--;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Opens the ReportIssues Form
        /// </summary>
        private void pBIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm Form = new ReportIssuesForm();
            Form.ShowDialog();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Plays Shutdown Sound and then closes program
        /// There was no Specific Shutdown sound but according to research the default set sound for shut down was this audio (tada.wav) [Which has been renamed to Windows 95 Shutdown in Resources.resx]
        /// </summary>
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            byte[] soundData = Properties.Resources.Windows_95_Shutdown;  // Get the byte array from resources

            using (MemoryStream memoryStream = new MemoryStream(soundData))
            {
                SoundPlayer soundPlayer = new SoundPlayer(memoryStream);
                soundPlayer.PlaySync();  // Play the sound asynchronously
            }
            this.Close();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Opens Local Events and Announcements Form
        /// </summary>
        private void pBLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsAndAnnouncementsForm LEAA = new LocalEventsAndAnnouncementsForm();
            LEAA.ShowDialog();
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Opens Service Request Status Form
        /// </summary>
        private void pBRequestStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm SRS = new ServiceRequestStatusForm();
            SRS.ShowDialog();

        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Windows 95 Start up sound on startup
        /// </summary>
        private void StartUp_Load(object sender, EventArgs e)
        {
            byte[] soundData = Properties.Resources.Windows_95_Startup;  // Get the byte array from resources

            using (MemoryStream memoryStream = new MemoryStream(soundData))
            {
                SoundPlayer soundPlayer = new SoundPlayer(memoryStream);
                soundPlayer.Play();  // Play the sound asynchronously
            }

        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Feedback page as its User Engagement Feature
        /// </summary>
        private void pBFeedback_Click(object sender, EventArgs e)
        {
            UserFeedback uFeedback = new UserFeedback();
            uFeedback.Show();
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

        private void StartUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture and send a message to allow dragging
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Timer that updates clock in the right corner
        /// </summary>
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedTime = now.ToString("h:mm tt").ToUpper();
            lblTime.Text = formattedTime;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//