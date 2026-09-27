namespace Killutter.UI
{
    partial class GroupCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Groupname = new Label();
            Filetypes = new Label();
            Foldericon = new LinkLabel();
            Foldername = new Label();
            Editbutton = new Button();
            Deletebutton = new Button();
            SuspendLayout();
            // 
            // Groupname
            // 
            Groupname.AutoSize = true;
            Groupname.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            Groupname.ForeColor = SystemColors.ButtonFace;
            Groupname.Location = new Point(17, 17);
            Groupname.Name = "Groupname";
            Groupname.Size = new Size(212, 45);
            Groupname.TabIndex = 0;
            Groupname.Text = "Group Name";
            Groupname.TextAlign = ContentAlignment.MiddleCenter;
            Groupname.Click += label1_Click;
            // 
            // Filetypes
            // 
            Filetypes.AutoSize = true;
            Filetypes.ForeColor = Color.FromArgb(138, 138, 138);
            Filetypes.Location = new Point(22, 62);
            Filetypes.Name = "Filetypes";
            Filetypes.Size = new Size(58, 15);
            Filetypes.TabIndex = 1;
            Filetypes.Text = "File Types";
            Filetypes.Click += label2_Click;
            // 
            // Foldericon
            // 
            Foldericon.ActiveLinkColor = Color.FromArgb(48, 48, 48);
            Foldericon.AutoSize = true;
            Foldericon.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Foldericon.LinkColor = Color.FromArgb(64, 64, 64);
            Foldericon.Location = new Point(28, 89);
            Foldericon.Name = "Foldericon";
            Foldericon.Size = new Size(63, 43);
            Foldericon.TabIndex = 2;
            Foldericon.TabStop = true;
            Foldericon.Text = "📁";
            // 
            // Foldername
            // 
            Foldername.AutoSize = true;
            Foldername.ForeColor = Color.FromArgb(201, 201, 201);
            Foldername.Location = new Point(22, 143);
            Foldername.Name = "Foldername";
            Foldername.Size = new Size(74, 15);
            Foldername.TabIndex = 3;
            Foldername.Text = "WatchFolder";
            Foldername.Click += label3_Click;
            // 
            // Editbutton
            // 
            Editbutton.BackColor = Color.FromArgb(58, 58, 58);
            Editbutton.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            Editbutton.FlatAppearance.BorderSize = 3;
            Editbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            Editbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            Editbutton.FlatStyle = FlatStyle.Flat;
            Editbutton.Location = new Point(198, 98);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(94, 42);
            Editbutton.TabIndex = 4;
            Editbutton.Text = "Edit";
            Editbutton.UseVisualStyleBackColor = false;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.FromArgb(58, 58, 58);
            Deletebutton.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            Deletebutton.FlatAppearance.BorderSize = 3;
            Deletebutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            Deletebutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            Deletebutton.FlatStyle = FlatStyle.Flat;
            Deletebutton.Location = new Point(322, 98);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 42);
            Deletebutton.TabIndex = 6;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            Controls.Add(Deletebutton);
            Controls.Add(Editbutton);
            Controls.Add(Foldername);
            Controls.Add(Foldericon);
            Controls.Add(Filetypes);
            Controls.Add(Groupname);
            Cursor = Cursors.No;
            ForeColor = SystemColors.ControlText;
            Name = "UserControl1";
            Size = new Size(457, 173);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Groupname;
        private Label Filetypes;
        private LinkLabel Foldericon;
        private Label Foldername;
        private Button Editbutton;
        private Button Deletebutton;
    }
}
