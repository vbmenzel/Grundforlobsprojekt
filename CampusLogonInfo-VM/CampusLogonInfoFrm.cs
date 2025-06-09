using System.DirectoryServices.AccountManagement;
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

            logonTime = GetActiveDirectoryLogonTime();
            lblLogonTime.Text += logonTime.ToString("dd/MM/yy HH:mm:ss");

            // Start the timer to continuously update the session duration.
            StartTimer();
        }

        /// <summary>
        /// Attempts to fetch the user's last logon time from Active Directory.
        /// Returns the current time (DateTime.Now) as a fallback if the lookup fails for any reason.
        /// </summary>
        /// <returns>A DateTime object representing the logon time.</returns>
        private DateTime GetActiveDirectoryLogonTime()
        {
            try
            {
                // Establish a connection to the current domain. The 'using' statement ensures
                // the connection is properly disposed of afterwards.
                using (
                    PrincipalContext context = new PrincipalContext(ContextType.Domain)
                )
                {
                    // Find the current user's object in Active Directory by their account name.
                    UserPrincipal? userPrincipal = UserPrincipal.FindByIdentity(
                        context,
                        IdentityType.SamAccountName,
                        Environment.UserName
                    );

                    // Safely check if the user was found AND if the LastLogon property has a value.
                    if (userPrincipal?.LastLogon.HasValue == true)
                    {
                        return userPrincipal.LastLogon.Value;
                    }
                }
            }
            catch
            {
                // This catch block intentionally swallows any exception (e.g., computer not on domain,
                // network issues, permissions error). The method will then proceed to the final
                // return statement, providing a safe fallback.
            }
            // Fallback: return the current time if the AD lookup was unsuccessful.
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
        // These methods handle the click events from the MenuStrip.

        private void copyUsernameTsmi_Click(object sender, EventArgs e)
        { Clipboard.SetText(lblUsername.Text); }

        private void copyComputerNameTsmi_Click(object sender, EventArgs e)
        { Clipboard.SetText(lblComputerName.Text); }

        private void copyDomainTsmi_Click(object sender, EventArgs e)
        { Clipboard.SetText(lblDomain.Text); }

        private void copyLogonTimeTsmi_Click(object sender, EventArgs e)
        { Clipboard.SetText(lblLogonTime.Text); }

        private void copySessionDurationTsmi_Click(object sender, EventArgs e)
        { Clipboard.SetText(lblSessionDuration.Text); }

        private void copyAllInfoTsmi_Click(object sender, EventArgs e)
        {
            // Using an interpolated string ($"...") to build a multi-line string.
            Clipboard.SetText(
                $"{lblUsername.Text}\n{lblDomain.Text}\n{lblComputerName.Text}\n{lblLogonTime.Text}\n{lblSessionDuration.Text}"
            );
        }
    }
}