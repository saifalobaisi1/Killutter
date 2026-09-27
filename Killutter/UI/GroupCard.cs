using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Killutter.UI
{
    public partial class GroupCard : UserControl
    {
        public GroupCard()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int radius = 32;
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = ClientRectangle;

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private Killutter.Modules.Shared.Group group;

        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public void SetGroup(Killutter.Modules.Shared.Group g)
        {
            group = g;
            Groupname.Text = g.Name;
            Filetypes.Text = string.Join(", ", g.RecognizedTypes);
            Foldername.Text = System.IO.Path.GetFileName(g.DestPath.TrimEnd('\\', '/'));

            Editbutton.Click -= Editbutton_Click;
            Editbutton.Click += Editbutton_Click;
            Deletebutton.Click -= Deletebutton_Click;
            Deletebutton.Click += Deletebutton_Click;
            Foldericon.Click -= Foldericon_Click;
            Foldericon.Click += Foldericon_Click;
        }

        private void Editbutton_Click(object sender, EventArgs e) => EditClicked?.Invoke(this, EventArgs.Empty);
        private void Deletebutton_Click(object sender, EventArgs e) => DeleteClicked?.Invoke(this, EventArgs.Empty);
        private void Foldericon_Click(object sender, EventArgs e)
        {
            if (group != null && System.IO.Directory.Exists(group.DestPath))
                System.Diagnostics.Process.Start("explorer.exe", group.DestPath);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
