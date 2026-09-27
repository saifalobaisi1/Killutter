using Killutter.Shared;

namespace Killutter.UI
{
    internal class TrayIcon
    {
        private NotifyIcon notifyIcon;
        private Config config;
        private ConfigForm configForm;

        public TrayIcon(Config config)
        {
            this.config = config;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Settings", null, OnOpenSettings);
            menu.Items.Add("Exit", null, OnExit);

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application; // temp placeholder icon
            notifyIcon.Text = "Killutter";
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = menu;
            notifyIcon.DoubleClick += OnOpenSettings;
        }

        private void OnOpenSettings(object sender, EventArgs e)
        {
            if (configForm == null || configForm.IsDisposed)
                configForm = new ConfigForm(config);

            configForm.Show();
            configForm.WindowState = FormWindowState.Normal;
            configForm.Activate();
        }

        private void OnExit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}