using Cassia;

namespace CampusLogonInfo_VM
{
    public partial class CampusLogonInfo : Form
    {
        // Class-level variable to store the logon time.
        // This ensures it's accessible by both the Load event and the Timer's Tick event.
        private DateTime logonTime;

        public CampusLogonInfo()
        {
            InitializeComponent();
        }

        private void CampusLogonInfo_Load(object sender, EventArgs e)
        {
            // Using the ternary operator for a compact null-check.
            string userName = string.IsNullOrEmpty(Environment.UserName)
                ? "N/A"
                : Environment.UserName;
            lblUsername.Text += userName;

            string domainName = string.IsNullOrEmpty(Environment.UserDomainName)
                ? "N/A"
                : Environment.UserDomainName;
            lblDomain.Text += domainName;

            string computerName = string.IsNullOrEmpty(Environment.MachineName)
                ? "N/A"
                : Environment.MachineName;
            lblComputerName.Text += computerName;

            // Get the logon time for the CURRENT session using the simple Cassia library.
            logonTime = GetSessionLogonTime();
            lblLogonTime.Text += logonTime.ToString("dd/MM/yy HH:mm:ss");

            // Start the timer to continuously update the session duration.
            StartTimer();
        }

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
            lblSessionDuration.Text = string.Format(
                "Sessionsvarighed: {0} dage, {1:00}:{2:00}:{3:00}",
                duration.Days,
                duration.Hours,
                duration.Minutes,
                duration.Seconds
            );
        }

        // --- Clipboard Copy Methods ---
        // (These are unchanged)
        private void copyUsernameTsmi_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblUsername.Text);
        }

        private void copyComputerNameTsmi_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblComputerName.Text);
        }

        private void copyDomainTsmi_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblDomain.Text);
        }

        private void copyLogonTimeTsmi_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblLogonTime.Text);
        }

        private void copySessionDurationTsmi_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblSessionDuration.Text);
        }

        private void copyAllInfoTsmi_Click(object sender, EventArgs e)
        {
            // Using an interpolated string ($"...") to build a multi-line string.
            Clipboard.SetText(
                $"{lblUsername.Text}\n{lblDomain.Text}\n{lblComputerName.Text}\n{lblLogonTime.Text}\n{lblSessionDuration.Text}"
            );
        }
    }
}
