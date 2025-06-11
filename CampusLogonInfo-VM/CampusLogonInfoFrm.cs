using Cassia;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CampusLogonInfo_VM
{
    public partial class CampusLogonInfo : Form
    {
        // Class-level variable to store the logon time.
        // This ensures it's accessible by both the Load event and the Timer's Tick event.
        private DateTime logonTime;

        // For dragging the borderless form. This stores the mouse's position
        // relative to the title bar's corner when the drag begins.
        private Point mouseLocation;

        public CampusLogonInfo()
        {
            InitializeComponent();
        }

        private void CampusLogonInfo_Load(object sender, EventArgs e)
        {
            // Set the initial ToolTip for the TopMost toggle button.
            mainToolTip.SetToolTip(lblToggleTopMost, "Slå 'Altid øverst' til");

            // Using the ternary operator for a compact null-check.
            string userName = string.IsNullOrEmpty(Environment.UserName)
                ? "N/A"
                : Environment.UserName;
            lblValueUser.Text = userName;

            string domainName = string.IsNullOrEmpty(Environment.UserDomainName)
                ? "N/A"
                : Environment.UserDomainName;
            lblValueDomain.Text = domainName;

            string computerName = string.IsNullOrEmpty(Environment.MachineName)
                ? "N/A"
                : Environment.MachineName;
            lblValueComputer.Text = computerName;

            // Get the logon time for the CURRENT session using the simple Cassia library.
            logonTime = GetSessionLogonTime();
            lblValueLoginTime.Text = logonTime.ToString("dd/MM/yy HH:mm:ss");

            // Start the timer to continuously update the session duration.
            StartTimer();
        }

        // --- Custom Title Bar Events ---
        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // When the mouse button is pressed down on the title bar,
        // we capture the starting position for the drag operation.
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        // While the mouse is moving AND the left button is held down,
        // this event continuously updates the form's location.
        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void lblToggleTopMost_Click(object sender, EventArgs e)
        {
            // Toggles the TopMost property of the form.
            this.TopMost = !this.TopMost;

            // Update the icon, color, and tooltip to reflect the new state.
            if (this.TopMost)
            {
                lblToggleTopMost.Text = "󰆹";
                lblToggleTopMost.ForeColor = Color.FromArgb(0, 151, 230);
                mainToolTip.SetToolTip(lblToggleTopMost, "Slå 'Altid øverst' fra");
            }
            else
            {
                lblToggleTopMost.Text = "󰆸";
                lblToggleTopMost.ForeColor = Color.FromArgb(204, 204, 204);
                mainToolTip.SetToolTip(lblToggleTopMost, "Slå 'Altid øverst' til");
            }
        }

        // --- Core Application Logic ---

        /// <summary>
        /// Gets the start time of the current user's session using the Cassia library.
        /// This provides a simple, readable, and reliable way to get the logon time.
        /// </summary>
        /// <returns>A DateTime for the session start, or DateTime.Now as a fallback.</returns>
        private DateTime GetSessionLogonTime()
        {
            try
            {
                // Cassia is a library that simplifies access to Windows Terminal Services.
                // We create a manager object to interact with it.
                TerminalServicesManager manager = new TerminalServicesManager();

                // Get the current user's session directly using Cassia's helper property.
                ITerminalServicesSession? session = manager.CurrentSession;

                // The LoginTime property is nullable, so we safely check if it has a value.
                if (session?.LoginTime.HasValue == true)
                {
                    return session.LoginTime.Value;
                }
            }
            catch
            {
                // This catch block intentionally swallows any exception.
                // Logically, the fallback 'return DateTime.Now;' could be placed here.
                // However, the compiler would then complain that 'not all code paths return a value'
                // because the return inside the 'try' block is conditional.
                // Therefore, the method proceeds to the final return statement to appease the compiler.
            }

            // Fallback: If the Cassia lookup fails for any reason, return the current time.
            return DateTime.Now;
        }

        private void StartTimer()
        {
            sessionTimer.Interval = 1000;
            sessionTimer.Tick += sessionTimer_Tick;
            sessionTimer.Start();
            // Call the tick method once immediately to populate the duration label right away.
            sessionTimer_Tick(null, EventArgs.Empty);
        }

        private void sessionTimer_Tick(object? sender, EventArgs e)
        {
            // Calculate the difference between now and the stored logon time.
            TimeSpan duration = DateTime.Now - this.logonTime;

            // Format the TimeSpan into a user-friendly HH:mm:ss string.
            // The ":00" specifier ensures two digits are always shown (e.g., "07" instead of "7").
            // Only shows days if the duration is more than 24 hours.
            string durationText;
            if (duration.Days > 0)
            {
                durationText = string.Format(
                    "{0} days, {1:00}:{2:00}:{3:00}",
                    duration.Days,
                    duration.Hours,
                    duration.Minutes,
                    duration.Seconds
                );
            }
            else
            {
                durationText = string.Format(
                    "{0:00}:{1:00}:{2:00}",
                    duration.Hours,
                    duration.Minutes,
                    duration.Seconds
                );
            }
            lblValueDuration.Text = durationText;
        }
    }
}