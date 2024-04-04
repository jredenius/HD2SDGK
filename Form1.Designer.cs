namespace HD2SDGK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lblEvents = new Label();
            lblSDinfo = new Label();
            lblConfig = new Label();
            lblStratimages = new Label();
            lblWebInterface = new Label();
            lblStratcombos = new Label();
            groupBox2 = new GroupBox();
            Logtb = new TextBox();
            formMenu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            openWebInterfaceToolStripMenuItem = new ToolStripMenuItem();
            openInstallFolderToolStripMenuItem = new ToolStripMenuItem();
            openGitHubProjectToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            currentVersionToolStripMenuItem = new ToolStripMenuItem();
            downloadNewVersionToolStripMenuItem = new ToolStripMenuItem();
            checkNewVersionToolStripMenuItem = new ToolStripMenuItem();
            stratagemsToolStripMenuItem = new ToolStripMenuItem();
            lastUpdateToolStripMenuItem = new ToolStripMenuItem();
            downloadNewStratagemsToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            formMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblEvents);
            groupBox1.Controls.Add(lblSDinfo);
            groupBox1.Controls.Add(lblConfig);
            groupBox1.Controls.Add(lblStratimages);
            groupBox1.Controls.Add(lblWebInterface);
            groupBox1.Controls.Add(lblStratcombos);
            groupBox1.Location = new Point(14, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.ImageAlign = ContentAlignment.MiddleLeft;
            lblEvents.Location = new Point(6, 126);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(100, 20);
            lblEvents.TabIndex = 5;
            lblEvents.Text = "    Commands";
            // 
            // lblSDinfo
            // 
            lblSDinfo.AutoSize = true;
            lblSDinfo.ImageAlign = ContentAlignment.MiddleLeft;
            lblSDinfo.Location = new Point(6, 106);
            lblSDinfo.Name = "lblSDinfo";
            lblSDinfo.Size = new Size(109, 20);
            lblSDinfo.TabIndex = 4;
            lblSDinfo.Text = "    Stream Deck";
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.ImageAlign = ContentAlignment.MiddleLeft;
            lblConfig.Location = new Point(6, 86);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new Size(116, 20);
            lblConfig.TabIndex = 3;
            lblConfig.Text = "    Configuration";
            // 
            // lblStratimages
            // 
            lblStratimages.AutoSize = true;
            lblStratimages.ImageAlign = ContentAlignment.MiddleLeft;
            lblStratimages.Location = new Point(6, 66);
            lblStratimages.Name = "lblStratimages";
            lblStratimages.Size = new Size(146, 20);
            lblStratimages.TabIndex = 2;
            lblStratimages.Text = "    Stratagem Images";
            // 
            // lblWebInterface
            // 
            lblWebInterface.AutoSize = true;
            lblWebInterface.ImageAlign = ContentAlignment.MiddleLeft;
            lblWebInterface.Location = new Point(6, 26);
            lblWebInterface.Name = "lblWebInterface";
            lblWebInterface.Size = new Size(117, 20);
            lblWebInterface.TabIndex = 1;
            lblWebInterface.Text = "    Web Interface";
            // 
            // lblStratcombos
            // 
            lblStratcombos.AutoSize = true;
            lblStratcombos.ImageAlign = ContentAlignment.MiddleLeft;
            lblStratcombos.Location = new Point(6, 46);
            lblStratcombos.Name = "lblStratcombos";
            lblStratcombos.Size = new Size(153, 20);
            lblStratcombos.TabIndex = 0;
            lblStratcombos.Text = "    Stratagem Combos";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(Logtb);
            groupBox2.Location = new Point(180, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 166);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // Logtb
            // 
            Logtb.Dock = DockStyle.Fill;
            Logtb.Location = new Point(3, 23);
            Logtb.Multiline = true;
            Logtb.Name = "Logtb";
            Logtb.ReadOnly = true;
            Logtb.ScrollBars = ScrollBars.Vertical;
            Logtb.Size = new Size(314, 140);
            Logtb.TabIndex = 0;
            // 
            // formMenu
            // 
            formMenu.ImageScalingSize = new Size(20, 20);
            formMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, versionToolStripMenuItem, stratagemsToolStripMenuItem });
            formMenu.Location = new Point(0, 0);
            formMenu.Name = "formMenu";
            formMenu.Size = new Size(512, 28);
            formMenu.TabIndex = 8;
            formMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWebInterfaceToolStripMenuItem, openInstallFolderToolStripMenuItem, openGitHubProjectToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // openWebInterfaceToolStripMenuItem
            // 
            openWebInterfaceToolStripMenuItem.Name = "openWebInterfaceToolStripMenuItem";
            openWebInterfaceToolStripMenuItem.Size = new Size(211, 26);
            openWebInterfaceToolStripMenuItem.Text = "Web Interface";
            openWebInterfaceToolStripMenuItem.Click += openWebInterfaceToolStripMenuItem_Click;
            // 
            // openInstallFolderToolStripMenuItem
            // 
            openInstallFolderToolStripMenuItem.Name = "openInstallFolderToolStripMenuItem";
            openInstallFolderToolStripMenuItem.Size = new Size(211, 26);
            openInstallFolderToolStripMenuItem.Text = "Installation Folder";
            openInstallFolderToolStripMenuItem.Click += openInstallFolderToolStripMenuItem_Click;
            // 
            // openGitHubProjectToolStripMenuItem
            // 
            openGitHubProjectToolStripMenuItem.Name = "openGitHubProjectToolStripMenuItem";
            openGitHubProjectToolStripMenuItem.Size = new Size(211, 26);
            openGitHubProjectToolStripMenuItem.Text = "GitHub Project";
            openGitHubProjectToolStripMenuItem.Click += openGitHubProjectToolStripMenuItem_Click;
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentVersionToolStripMenuItem, downloadNewVersionToolStripMenuItem, checkNewVersionToolStripMenuItem });
            versionToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(75, 24);
            versionToolStripMenuItem.Text = "Version ";
            // 
            // currentVersionToolStripMenuItem
            // 
            currentVersionToolStripMenuItem.Enabled = false;
            currentVersionToolStripMenuItem.Name = "currentVersionToolStripMenuItem";
            currentVersionToolStripMenuItem.Size = new Size(243, 26);
            currentVersionToolStripMenuItem.Text = "Version x.x";
            // 
            // downloadNewVersionToolStripMenuItem
            // 
            downloadNewVersionToolStripMenuItem.Name = "downloadNewVersionToolStripMenuItem";
            downloadNewVersionToolStripMenuItem.Size = new Size(243, 26);
            downloadNewVersionToolStripMenuItem.Text = "Download new version";
            downloadNewVersionToolStripMenuItem.Visible = false;
            downloadNewVersionToolStripMenuItem.Click += downloadNewVersionToolStripMenuItem_Click;
            // 
            // checkNewVersionToolStripMenuItem
            // 
            checkNewVersionToolStripMenuItem.Name = "checkNewVersionToolStripMenuItem";
            checkNewVersionToolStripMenuItem.Size = new Size(243, 26);
            checkNewVersionToolStripMenuItem.Text = "Check for new version";
            checkNewVersionToolStripMenuItem.Click += checkNewVersionToolStripMenuItem_Click;
            // 
            // stratagemsToolStripMenuItem
            // 
            stratagemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lastUpdateToolStripMenuItem, downloadNewStratagemsToolStripMenuItem, checkForUpdateToolStripMenuItem });
            stratagemsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            stratagemsToolStripMenuItem.Name = "stratagemsToolStripMenuItem";
            stratagemsToolStripMenuItem.Size = new Size(102, 24);
            stratagemsToolStripMenuItem.Text = "Stratagems ";
            // 
            // lastUpdateToolStripMenuItem
            // 
            lastUpdateToolStripMenuItem.Enabled = false;
            lastUpdateToolStripMenuItem.Name = "lastUpdateToolStripMenuItem";
            lastUpdateToolStripMenuItem.Size = new Size(274, 26);
            lastUpdateToolStripMenuItem.Text = "Version";
            // 
            // downloadNewStratagemsToolStripMenuItem
            // 
            downloadNewStratagemsToolStripMenuItem.Name = "downloadNewStratagemsToolStripMenuItem";
            downloadNewStratagemsToolStripMenuItem.Size = new Size(274, 26);
            downloadNewStratagemsToolStripMenuItem.Text = "Download New Stratagems";
            downloadNewStratagemsToolStripMenuItem.Visible = false;
            downloadNewStratagemsToolStripMenuItem.Click += downloadNewStratagemsToolStripMenuItem_Click;
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new Size(274, 26);
            checkForUpdateToolStripMenuItem.Text = "Check for update";
            checkForUpdateToolStripMenuItem.Click += checkForUpdateToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 202);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(formMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = formMenu;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "HD2SDGK";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            formMenu.ResumeLayout(false);
            formMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblStratcombos;
        private TextBox Logtb;
        private Label lblStratimages;
        private Label lblWebInterface;
        private Label lblConfig;
        private Label lblSDinfo;
        private Label lblEvents;
        private MenuStrip formMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem openWebInterfaceToolStripMenuItem;
        private ToolStripMenuItem openInstallFolderToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private ToolStripMenuItem stratagemsToolStripMenuItem;
        private ToolStripMenuItem currentVersionToolStripMenuItem;
        private ToolStripMenuItem checkNewVersionToolStripMenuItem;
        private ToolStripMenuItem downloadNewVersionToolStripMenuItem;
        private ToolStripMenuItem openGitHubProjectToolStripMenuItem;
        private ToolStripMenuItem lastUpdateToolStripMenuItem;
        private ToolStripMenuItem downloadNewStratagemsToolStripMenuItem;
        private ToolStripMenuItem checkForUpdateToolStripMenuItem;
    }
}