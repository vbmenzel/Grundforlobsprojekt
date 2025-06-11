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
            sessionTimer = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
            lblToggleTopMost = new Label();
            lblClose = new Label();
            lblTitle = new Label();
            flpMain = new FlowLayoutPanel();
            tlpData = new TableLayoutPanel();
            lblGroupIdentity = new Label();
            lblIconUser = new Label();
            lblTitleUser = new Label();
            lblValueUser = new Label();
            lblIconComputer = new Label();
            lblTitleComputer = new Label();
            lblValueComputer = new Label();
            lblIconDomain = new Label();
            lblTitleDomain = new Label();
            lblValueDomain = new Label();
            lblGroupSession = new Label();
            lblIconLoginTime = new Label();
            lblTitleLoginTime = new Label();
            lblValueLoginTime = new Label();
            lblIconDuration = new Label();
            lblTitleDuration = new Label();
            lblValueDuration = new Label();
            mainToolTip = new ToolTip(components);
            pnlTitleBar.SuspendLayout();
            flpMain.SuspendLayout();
            tlpData.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(45, 45, 48);
            pnlTitleBar.Controls.Add(lblToggleTopMost);
            pnlTitleBar.Controls.Add(lblClose);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(1, 1);
            pnlTitleBar.Margin = new Padding(0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(378, 32);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            // 
            // lblToggleTopMost
            // 
            lblToggleTopMost.Dock = DockStyle.Right;
            lblToggleTopMost.Font = new Font("0xProto Nerd Font", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToggleTopMost.Location = new Point(298, 0);
            lblToggleTopMost.Name = "lblToggleTopMost";
            lblToggleTopMost.Padding = new Padding(0, 2, 0, 0);
            lblToggleTopMost.Size = new Size(40, 32);
            lblToggleTopMost.TabIndex = 2;
            lblToggleTopMost.Text = "󰆸";
            lblToggleTopMost.TextAlign = ContentAlignment.MiddleCenter;
            lblToggleTopMost.Click += lblToggleTopMost_Click;
            // 
            // lblClose
            // 
            lblClose.Dock = DockStyle.Right;
            lblClose.Font = new Font("Segoe UI", 12F);
            lblClose.Location = new Point(338, 0);
            lblClose.Name = "lblClose";
            lblClose.Padding = new Padding(0, 2, 0, 0);
            lblClose.Size = new Size(40, 32);
            lblClose.TabIndex = 1;
            lblClose.Text = "✕";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
            lblClose.Click += lblClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("0xProto Nerd Font", 10F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "  Brugerinformation";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.MouseDown += pnlTitleBar_MouseDown;
            lblTitle.MouseMove += pnlTitleBar_MouseMove;
            // 
            // flpMain
            // 
            flpMain.AutoSize = true;
            flpMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpMain.BackColor = Color.FromArgb(45, 45, 48);
            flpMain.Controls.Add(tlpData);
            flpMain.Dock = DockStyle.Fill;
            flpMain.FlowDirection = FlowDirection.TopDown;
            flpMain.Location = new Point(1, 33);
            flpMain.Name = "flpMain";
            flpMain.Padding = new Padding(15, 10, 15, 15);
            flpMain.Size = new Size(378, 186);
            flpMain.TabIndex = 1;
            flpMain.WrapContents = false;
            // 
            // tlpData
            // 
            tlpData.AutoSize = true;
            tlpData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpData.BackColor = Color.Transparent;
            tlpData.ColumnCount = 3;
            tlpData.ColumnStyles.Add(new ColumnStyle());
            tlpData.ColumnStyles.Add(new ColumnStyle());
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpData.Controls.Add(lblGroupIdentity, 0, 0);
            tlpData.Controls.Add(lblIconUser, 0, 1);
            tlpData.Controls.Add(lblTitleUser, 1, 1);
            tlpData.Controls.Add(lblValueUser, 2, 1);
            tlpData.Controls.Add(lblIconComputer, 0, 2);
            tlpData.Controls.Add(lblTitleComputer, 1, 2);
            tlpData.Controls.Add(lblValueComputer, 2, 2);
            tlpData.Controls.Add(lblIconDomain, 0, 3);
            tlpData.Controls.Add(lblTitleDomain, 1, 3);
            tlpData.Controls.Add(lblValueDomain, 2, 3);
            tlpData.Controls.Add(lblGroupSession, 0, 4);
            tlpData.Controls.Add(lblIconLoginTime, 0, 5);
            tlpData.Controls.Add(lblTitleLoginTime, 1, 5);
            tlpData.Controls.Add(lblValueLoginTime, 2, 5);
            tlpData.Controls.Add(lblIconDuration, 0, 6);
            tlpData.Controls.Add(lblTitleDuration, 1, 6);
            tlpData.Controls.Add(lblValueDuration, 2, 6);
            tlpData.Location = new Point(18, 13);
            tlpData.Name = "tlpData";
            tlpData.RowCount = 7;
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.RowStyles.Add(new RowStyle());
            tlpData.Size = new Size(342, 132);
            tlpData.TabIndex = 4;
            // 
            // lblGroupIdentity
            // 
            tlpData.SetColumnSpan(lblGroupIdentity, 3);
            lblGroupIdentity.Dock = DockStyle.Fill;
            lblGroupIdentity.Font = new Font("0xProto Nerd Font", 10F, FontStyle.Bold);
            lblGroupIdentity.ForeColor = Color.Gray;
            lblGroupIdentity.Location = new Point(3, 0);
            lblGroupIdentity.Margin = new Padding(3, 0, 3, 5);
            lblGroupIdentity.Name = "lblGroupIdentity";
            lblGroupIdentity.Size = new Size(336, 16);
            lblGroupIdentity.TabIndex = 0;
            lblGroupIdentity.Text = "IDENTITET";
            // 
            // lblIconUser
            // 
            lblIconUser.Anchor = AnchorStyles.Left;
            lblIconUser.AutoSize = true;
            lblIconUser.ForeColor = Color.FromArgb(0, 151, 230);
            lblIconUser.Location = new Point(3, 21);
            lblIconUser.Name = "lblIconUser";
            lblIconUser.Size = new Size(26, 18);
            lblIconUser.TabIndex = 2;
            lblIconUser.Text = " ";
            // 
            // lblTitleUser
            // 
            lblTitleUser.Anchor = AnchorStyles.Left;
            lblTitleUser.AutoSize = true;
            lblTitleUser.ForeColor = Color.FromArgb(170, 170, 170);
            lblTitleUser.Location = new Point(35, 21);
            lblTitleUser.Name = "lblTitleUser";
            lblTitleUser.Size = new Size(107, 18);
            lblTitleUser.TabIndex = 3;
            lblTitleUser.Text = "Brugernavn:";
            // 
            // lblValueUser
            // 
            lblValueUser.Anchor = AnchorStyles.Left;
            lblValueUser.AutoSize = true;
            lblValueUser.Font = new Font("0xProto Nerd Font", 11F, FontStyle.Bold);
            lblValueUser.ForeColor = Color.White;
            lblValueUser.Location = new Point(202, 21);
            lblValueUser.Name = "lblValueUser";
            lblValueUser.Size = new Size(118, 18);
            lblValueUser.TabIndex = 4;
            lblValueUser.Text = "(henter...)";
            // 
            // lblIconComputer
            // 
            lblIconComputer.Anchor = AnchorStyles.Left;
            lblIconComputer.AutoSize = true;
            lblIconComputer.ForeColor = Color.FromArgb(0, 151, 230);
            lblIconComputer.Location = new Point(3, 39);
            lblIconComputer.Name = "lblIconComputer";
            lblIconComputer.Size = new Size(26, 18);
            lblIconComputer.TabIndex = 5;
            lblIconComputer.Text = " ";
            // 
            // lblTitleComputer
            // 
            lblTitleComputer.Anchor = AnchorStyles.Left;
            lblTitleComputer.AutoSize = true;
            lblTitleComputer.ForeColor = Color.FromArgb(170, 170, 170);
            lblTitleComputer.Location = new Point(35, 39);
            lblTitleComputer.Name = "lblTitleComputer";
            lblTitleComputer.Size = new Size(125, 18);
            lblTitleComputer.TabIndex = 6;
            lblTitleComputer.Text = "Computernavn:";
            // 
            // lblValueComputer
            // 
            lblValueComputer.Anchor = AnchorStyles.Left;
            lblValueComputer.AutoSize = true;
            lblValueComputer.Font = new Font("0xProto Nerd Font", 11F, FontStyle.Bold);
            lblValueComputer.ForeColor = Color.White;
            lblValueComputer.Location = new Point(202, 39);
            lblValueComputer.Name = "lblValueComputer";
            lblValueComputer.Size = new Size(118, 18);
            lblValueComputer.TabIndex = 7;
            lblValueComputer.Text = "(henter...)";
            // 
            // lblIconDomain
            // 
            lblIconDomain.Anchor = AnchorStyles.Left;
            lblIconDomain.AutoSize = true;
            lblIconDomain.ForeColor = Color.FromArgb(0, 151, 230);
            lblIconDomain.Location = new Point(3, 57);
            lblIconDomain.Name = "lblIconDomain";
            lblIconDomain.Size = new Size(26, 18);
            lblIconDomain.TabIndex = 8;
            lblIconDomain.Text = "󰌗 ";
            // 
            // lblTitleDomain
            // 
            lblTitleDomain.Anchor = AnchorStyles.Left;
            lblTitleDomain.AutoSize = true;
            lblTitleDomain.ForeColor = Color.FromArgb(170, 170, 170);
            lblTitleDomain.Location = new Point(35, 57);
            lblTitleDomain.Name = "lblTitleDomain";
            lblTitleDomain.Size = new Size(71, 18);
            lblTitleDomain.TabIndex = 9;
            lblTitleDomain.Text = "Domæne:";
            // 
            // lblValueDomain
            // 
            lblValueDomain.Anchor = AnchorStyles.Left;
            lblValueDomain.AutoSize = true;
            lblValueDomain.Font = new Font("0xProto Nerd Font", 11F, FontStyle.Bold);
            lblValueDomain.ForeColor = Color.White;
            lblValueDomain.Location = new Point(202, 57);
            lblValueDomain.Name = "lblValueDomain";
            lblValueDomain.Size = new Size(118, 18);
            lblValueDomain.TabIndex = 10;
            lblValueDomain.Text = "(henter...)";
            // 
            // lblGroupSession
            // 
            tlpData.SetColumnSpan(lblGroupSession, 3);
            lblGroupSession.Dock = DockStyle.Fill;
            lblGroupSession.Font = new Font("0xProto Nerd Font", 10F, FontStyle.Bold);
            lblGroupSession.ForeColor = Color.Gray;
            lblGroupSession.Location = new Point(3, 75);
            lblGroupSession.Margin = new Padding(3, 0, 3, 5);
            lblGroupSession.Name = "lblGroupSession";
            lblGroupSession.Size = new Size(336, 16);
            lblGroupSession.TabIndex = 2;
            lblGroupSession.Text = "SESSION";
            // 
            // lblIconLoginTime
            // 
            lblIconLoginTime.Anchor = AnchorStyles.Left;
            lblIconLoginTime.AutoSize = true;
            lblIconLoginTime.ForeColor = Color.FromArgb(0, 151, 230);
            lblIconLoginTime.Location = new Point(3, 96);
            lblIconLoginTime.Name = "lblIconLoginTime";
            lblIconLoginTime.Size = new Size(26, 18);
            lblIconLoginTime.TabIndex = 12;
            lblIconLoginTime.Text = "󰥔 ";
            // 
            // lblTitleLoginTime
            // 
            lblTitleLoginTime.Anchor = AnchorStyles.Left;
            lblTitleLoginTime.AutoSize = true;
            lblTitleLoginTime.ForeColor = Color.FromArgb(170, 170, 170);
            lblTitleLoginTime.Location = new Point(35, 96);
            lblTitleLoginTime.Name = "lblTitleLoginTime";
            lblTitleLoginTime.Size = new Size(98, 18);
            lblTitleLoginTime.TabIndex = 14;
            lblTitleLoginTime.Text = "Login Tid:";
            // 
            // lblValueLoginTime
            // 
            lblValueLoginTime.Anchor = AnchorStyles.Left;
            lblValueLoginTime.AutoSize = true;
            lblValueLoginTime.Font = new Font("0xProto Nerd Font", 11F, FontStyle.Bold);
            lblValueLoginTime.ForeColor = Color.White;
            lblValueLoginTime.Location = new Point(202, 96);
            lblValueLoginTime.Name = "lblValueLoginTime";
            lblValueLoginTime.Size = new Size(118, 18);
            lblValueLoginTime.TabIndex = 15;
            lblValueLoginTime.Text = "(henter...)";
            // 
            // lblIconDuration
            // 
            lblIconDuration.Anchor = AnchorStyles.Left;
            lblIconDuration.AutoSize = true;
            lblIconDuration.ForeColor = Color.FromArgb(0, 151, 230);
            lblIconDuration.Location = new Point(3, 114);
            lblIconDuration.Name = "lblIconDuration";
            lblIconDuration.Size = new Size(26, 18);
            lblIconDuration.TabIndex = 13;
            lblIconDuration.Text = "󰔛 ";
            // 
            // lblTitleDuration
            // 
            lblTitleDuration.Anchor = AnchorStyles.Left;
            lblTitleDuration.AutoSize = true;
            lblTitleDuration.ForeColor = Color.FromArgb(170, 170, 170);
            lblTitleDuration.Location = new Point(35, 114);
            lblTitleDuration.Name = "lblTitleDuration";
            lblTitleDuration.Size = new Size(161, 18);
            lblTitleDuration.TabIndex = 16;
            lblTitleDuration.Text = "Sessionsvarighed:";
            // 
            // lblValueDuration
            // 
            lblValueDuration.Anchor = AnchorStyles.Left;
            lblValueDuration.AutoSize = true;
            lblValueDuration.Font = new Font("0xProto Nerd Font", 11F, FontStyle.Bold);
            lblValueDuration.ForeColor = Color.White;
            lblValueDuration.Location = new Point(202, 114);
            lblValueDuration.Name = "lblValueDuration";
            lblValueDuration.Size = new Size(118, 18);
            lblValueDuration.TabIndex = 17;
            lblValueDuration.Text = "(henter...)";
            // 
            // mainToolTip
            // 
            mainToolTip.BackColor = Color.FromArgb(45, 45, 48);
            mainToolTip.ForeColor = Color.White;
            mainToolTip.ToolTipTitle = "Info";
            // 
            // CampusLogonInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(50, 50, 55);
            ClientSize = new Size(380, 220);
            Controls.Add(flpMain);
            Controls.Add(pnlTitleBar);
            Font = new Font("0xProto Nerd Font", 11F);
            ForeColor = Color.FromArgb(204, 204, 204);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CampusLogonInfo";
            Padding = new Padding(1);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brugerinformation";
            Load += CampusLogonInfo_Load;
            pnlTitleBar.ResumeLayout(false);
            flpMain.ResumeLayout(false);
            flpMain.PerformLayout();
            tlpData.ResumeLayout(false);
            tlpData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer sessionTimer;
        private FlowLayoutPanel flpMain;
        private Label lblGroupIdentity;
        private TableLayoutPanel tlpData;
        private Label lblIconUser;
        private Label lblTitleUser;
        private Label lblValueUser;
        private Label lblIconComputer;
        private Label lblTitleComputer;
        private Label lblValueComputer;
        private Label lblIconDomain;
        private Label lblTitleDomain;
        private Label lblValueDomain;
        private Label lblGroupSession;
        private Label lblIconLoginTime;
        private Label lblIconDuration;
        private Label lblTitleLoginTime;
        private Label lblValueLoginTime;
        private Label lblTitleDuration;
        private Label lblValueDuration;
        private Panel pnlTitleBar;
        private Label lblClose;
        private Label lblTitle;
        private Label lblToggleTopMost;
        private ToolTip mainToolTip;
    }
}
