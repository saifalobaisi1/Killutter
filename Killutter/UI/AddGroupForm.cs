using System;
using System.Windows.Forms;
using Killutter.Modules.Shared;

namespace Killutter.UI
{
    public partial class AddGroupForm : Form
    {
        private Config config;

        public AddGroupForm(Config config)
        {
            InitializeComponent();
            this.config = config;

            addGroupControl1.SaveClicked += AddGroupControl1_SaveClicked;
            addGroupControl1.CancelClicked += AddGroupControl1_CancelClicked;
        }

        private void AddGroupControl1_SaveClicked(object sender, EventArgs e)
        {
            config.AddGroup(
                addGroupControl1.GetGroupName(),
                addGroupControl1.GetDestinationPath(),
                addGroupControl1.GetCheckedTypes());

            config.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddGroupControl1_CancelClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}