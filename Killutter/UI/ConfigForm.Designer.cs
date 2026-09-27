namespace Killutter.UI
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Watchpath = new Label();
            Watchfolder = new Label();
            Logfile = new Label();
            Logpath = new Label();
            ChangeWatchPath = new Button();
            ChangeLogPath = new Button();
            Foldericon = new LinkLabel();
            linkLabel1 = new LinkLabel();
            AddGroup = new Button();
            RunAtStartup = new CheckBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupCard1 = new GroupCard();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Watchpath
            // 
            Watchpath.AutoSize = true;
            Watchpath.ForeColor = SystemColors.ButtonFace;
            Watchpath.Location = new Point(102, 48);
            Watchpath.Name = "Watchpath";
            Watchpath.Size = new Size(40, 15);
            Watchpath.TabIndex = 0;
            Watchpath.Text = "Path...";
            // 
            // Watchfolder
            // 
            Watchfolder.AutoSize = true;
            Watchfolder.ForeColor = Color.FromArgb(138, 138, 138);
            Watchfolder.Location = new Point(92, 21);
            Watchfolder.Name = "Watchfolder";
            Watchfolder.Size = new Size(75, 15);
            Watchfolder.TabIndex = 1;
            Watchfolder.Text = "Watch folder";
            Watchfolder.Click += label2_Click;
            // 
            // Logfile
            // 
            Logfile.AutoSize = true;
            Logfile.ForeColor = Color.FromArgb(138, 138, 138);
            Logfile.Location = new Point(92, 83);
            Logfile.Name = "Logfile";
            Logfile.Size = new Size(46, 15);
            Logfile.TabIndex = 3;
            Logfile.Text = "Log file";
            // 
            // Logpath
            // 
            Logpath.AutoSize = true;
            Logpath.ForeColor = SystemColors.ButtonFace;
            Logpath.Location = new Point(102, 110);
            Logpath.Name = "Logpath";
            Logpath.Size = new Size(40, 15);
            Logpath.TabIndex = 6;
            Logpath.Text = "Path...";
            // 
            // ChangeWatchPath
            // 
            ChangeWatchPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeWatchPath.BackColor = Color.FromArgb(58, 58, 58);
            ChangeWatchPath.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            ChangeWatchPath.FlatAppearance.BorderSize = 3;
            ChangeWatchPath.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            ChangeWatchPath.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            ChangeWatchPath.FlatStyle = FlatStyle.Flat;
            ChangeWatchPath.Location = new Point(807, 21);
            ChangeWatchPath.Name = "ChangeWatchPath";
            ChangeWatchPath.Size = new Size(94, 42);
            ChangeWatchPath.TabIndex = 7;
            ChangeWatchPath.Text = "Change...";
            ChangeWatchPath.UseVisualStyleBackColor = false;
            // 
            // ChangeLogPath
            // 
            ChangeLogPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChangeLogPath.BackColor = Color.FromArgb(58, 58, 58);
            ChangeLogPath.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            ChangeLogPath.FlatAppearance.BorderSize = 3;
            ChangeLogPath.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            ChangeLogPath.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            ChangeLogPath.FlatStyle = FlatStyle.Flat;
            ChangeLogPath.Location = new Point(807, 83);
            ChangeLogPath.Name = "ChangeLogPath";
            ChangeLogPath.Size = new Size(94, 42);
            ChangeLogPath.TabIndex = 8;
            ChangeLogPath.Text = "Change...";
            ChangeLogPath.UseVisualStyleBackColor = false;
            // 
            // Foldericon
            // 
            Foldericon.ActiveLinkColor = Color.FromArgb(48, 48, 48);
            Foldericon.AutoSize = true;
            Foldericon.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Foldericon.LinkColor = Color.FromArgb(64, 64, 64);
            Foldericon.Location = new Point(23, 20);
            Foldericon.Name = "Foldericon";
            Foldericon.Size = new Size(63, 43);
            Foldericon.TabIndex = 9;
            Foldericon.TabStop = true;
            Foldericon.Text = "📁";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(48, 48, 48);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(23, 87);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 43);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "📁";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AddGroup
            // 
            AddGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddGroup.BackColor = Color.FromArgb(58, 58, 58);
            AddGroup.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            AddGroup.FlatAppearance.BorderSize = 3;
            AddGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            AddGroup.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            AddGroup.FlatStyle = FlatStyle.Flat;
            AddGroup.Location = new Point(807, 519);
            AddGroup.Name = "AddGroup";
            AddGroup.Size = new Size(94, 42);
            AddGroup.TabIndex = 11;
            AddGroup.Text = "Add Group";
            AddGroup.UseVisualStyleBackColor = false;
            // 
            // RunAtStartup
            // 
            RunAtStartup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RunAtStartup.AutoSize = true;
            RunAtStartup.Font = new Font("Segoe UI", 12F);
            RunAtStartup.ForeColor = Color.FromArgb(138, 138, 138);
            RunAtStartup.Location = new Point(23, 527);
            RunAtStartup.Name = "RunAtStartup";
            RunAtStartup.Size = new Size(130, 25);
            RunAtStartup.TabIndex = 14;
            RunAtStartup.Text = "Run At Startup";
            RunAtStartup.UseVisualStyleBackColor = true;
            RunAtStartup.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(23, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 357);
            panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(groupCard1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(878, 357);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupCard1
            // 
            groupCard1.BackColor = Color.FromArgb(43, 43, 43);
            groupCard1.ForeColor = SystemColors.ControlText;
            groupCard1.Location = new Point(3, 3);
            groupCard1.Name = "groupCard1";
            groupCard1.Size = new Size(429, 174);
            groupCard1.TabIndex = 0;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(924, 584);
            Controls.Add(panel1);
            Controls.Add(RunAtStartup);
            Controls.Add(AddGroup);
            Controls.Add(linkLabel1);
            Controls.Add(Foldericon);
            Controls.Add(ChangeLogPath);
            Controls.Add(ChangeWatchPath);
            Controls.Add(Logpath);
            Controls.Add(Logfile);
            Controls.Add(Watchfolder);
            Controls.Add(Watchpath);
            Name = "ConfigForm";
            Text = "ConfigForm";
            Load += ConfigForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Watchpath;
        private Label Watchfolder;
        private Label Logfile;
        private Label Logpath;
        private Button ChangeWatchPath;
        private Button ChangeLogPath;
        private LinkLabel Foldericon;
        private LinkLabel linkLabel1;
        private Button AddGroup;
        private CheckBox RunAtStartup;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupCard groupCard1;
    }
}