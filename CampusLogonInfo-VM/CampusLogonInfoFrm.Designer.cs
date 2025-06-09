namespace CampusLogonInfo_VM
{
    partial class CampusLogonInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUsername = new Label();
            lblSessionDuration = new Label();
            lblLogonTime = new Label();
            lblDomain = new Label();
            lblComputerName = new Label();
            sessionTimer = new System.Windows.Forms.Timer(components);
            menuStrip = new MenuStrip();
            kopierToolStripMenuItem = new ToolStripMenuItem();
            copyUsernameTsmi = new ToolStripMenuItem();
            copyComputernameTsmi = new ToolStripMenuItem();
            copyDomainTsmi = new ToolStripMenuItem();
            copyLogonTimeTsmi = new ToolStripMenuItem();
            copySessionDurationTsmi = new ToolStripMenuItem();
            copyAllInfoTsmi = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(13, 30);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Brugernavn: ";
            // 
            // lblSessionDuration
            // 
            lblSessionDuration.AutoSize = true;
            lblSessionDuration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSessionDuration.Location = new Point(13, 122);
            lblSessionDuration.Margin = new Padding(4, 0, 4, 0);
            lblSessionDuration.Name = "lblSessionDuration";
            lblSessionDuration.Size = new Size(142, 20);
            lblSessionDuration.TabIndex = 1;
            lblSessionDuration.Text = "Sessionsvarighed: ";
            // 
            // lblLogonTime
            // 
            lblLogonTime.AutoSize = true;
            lblLogonTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogonTime.Location = new Point(13, 99);
            lblLogonTime.Margin = new Padding(4, 0, 4, 0);
            lblLogonTime.Name = "lblLogonTime";
            lblLogonTime.Size = new Size(81, 20);
            lblLogonTime.TabIndex = 2;
            lblLogonTime.Text = "Login Tid: ";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomain.Location = new Point(13, 76);
            lblDomain.Margin = new Padding(4, 0, 4, 0);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(84, 20);
            lblDomain.TabIndex = 3;
            lblDomain.Text = "Domæne: ";
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerName.Location = new Point(13, 53);
            lblComputerName.Margin = new Padding(4, 0, 4, 0);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(121, 20);
            lblComputerName.TabIndex = 4;
            lblComputerName.Text = "Computernavn: ";
            // 
            // sessionTimer
            // 
            sessionTimer.Interval = 1000;
            sessionTimer.Tick += sessionTimer_Tick;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { kopierToolStripMenuItem });
            menuStrip.Location = new Point(12, 2);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(305, 24);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip";
            // 
            // kopierToolStripMenuItem
            // 
            kopierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyUsernameTsmi, copyComputernameTsmi, copyDomainTsmi, copyLogonTimeTsmi, copySessionDurationTsmi, copyAllInfoTsmi });
            kopierToolStripMenuItem.Name = "kopierToolStripMenuItem";
            kopierToolStripMenuItem.Size = new Size(53, 20);
            kopierToolStripMenuItem.Text = "Kopier";
            // 
            // copyUsernameTsmi
            // 
            copyUsernameTsmi.Name = "copyUsernameTsmi";
            copyUsernameTsmi.Size = new Size(201, 22);
            copyUsernameTsmi.Text = "Kopier Brugernavn";
            copyUsernameTsmi.Click += copyUsernameTsmi_Click;
            // 
            // copyComputernameTsmi
            // 
            copyComputernameTsmi.Name = "copyComputernameTsmi";
            copyComputernameTsmi.Size = new Size(201, 22);
            copyComputernameTsmi.Text = "Kopier Computernavn";
            copyComputernameTsmi.Click += copyComputerNameTsmi_Click;
            // 
            // copyDomainTsmi
            // 
            copyDomainTsmi.Name = "copyDomainTsmi";
            copyDomainTsmi.Size = new Size(201, 22);
            copyDomainTsmi.Text = "Kopier Domæne";
            copyDomainTsmi.Click += copyDomainTsmi_Click;
            // 
            // copyLogonTimeTsmi
            // 
            copyLogonTimeTsmi.Name = "copyLogonTimeTsmi";
            copyLogonTimeTsmi.Size = new Size(201, 22);
            copyLogonTimeTsmi.Text = "Kopier Login Tid";
            copyLogonTimeTsmi.Click += copyLogonTimeTsmi_Click;
            // 
            // copySessionDurationTsmi
            // 
            copySessionDurationTsmi.Name = "copySessionDurationTsmi";
            copySessionDurationTsmi.Size = new Size(201, 22);
            copySessionDurationTsmi.Text = "Kopier Sessionsvarighed";
            copySessionDurationTsmi.Click += copySessionDurationTsmi_Click;
            // 
            // copyAllInfoTsmi
            // 
            copyAllInfoTsmi.Name = "copyAllInfoTsmi";
            copyAllInfoTsmi.Size = new Size(201, 22);
            copyAllInfoTsmi.Text = "Kopier Alt Info";
            copyAllInfoTsmi.Click += copyAllInfoTsmi_Click;
            // 
            // CampusLogonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(329, 152);
            Controls.Add(lblComputerName);
            Controls.Add(lblDomain);
            Controls.Add(lblLogonTime);
            Controls.Add(lblSessionDuration);
            Controls.Add(lblUsername);
            Controls.Add(menuStrip);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CampusLogonInfo";
            Padding = new Padding(12, 2, 12, 12);
            Text = "Campus Logon Info";
            Load += CampusLogonInfo_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSessionDuration;
        private System.Windows.Forms.Label lblLogonTime;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Timer sessionTimer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem kopierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUsernameTsmi;
        private System.Windows.Forms.ToolStripMenuItem copyComputernameTsmi;
        private System.Windows.Forms.ToolStripMenuItem copyDomainTsmi;
        private System.Windows.Forms.ToolStripMenuItem copyLogonTimeTsmi;
        private System.Windows.Forms.ToolStripMenuItem copySessionDurationTsmi;
        private System.Windows.Forms.ToolStripMenuItem copyAllInfoTsmi;
    }
}
