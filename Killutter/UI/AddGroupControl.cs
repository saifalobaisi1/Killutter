using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Killutter.UI
{
    public partial class AddGroupControl : UserControl
    {
        private string destinationPath;

        public event EventHandler SaveClicked;
        public event EventHandler CancelClicked;

        public AddGroupControl()
        {
            InitializeComponent();

            Browse.Click += Browse_Click;
            Save.Click += Save_Click;
            CancelButton.Click += CancelButton_Click;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = dialog.SelectedPath;
                    DestValueLabel.Text = destinationPath;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Enter a group name.", "Missing name");
                return;
            }

            if (string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Choose a destination folder.", "Missing destination");
                return;
            }

            if (GetCheckedTypes().Count == 0)
            {
                MessageBox.Show("Select at least one file type.", "Missing types");
                return;
            }

            SaveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }

        public string GetGroupName()
        {
            return NameTextBox.Text.Trim();
        }

        public string GetDestinationPath()
        {
            return destinationPath;
        }

        public List<string> GetCheckedTypes()
        {
            List<string> types = new List<string>();

            CheckBox[] boxes =
            {
                PdfCheck, DocxCheck, PptxCheck, XlsxCheck,
                JpegCheck, PngCheck, GifCheck,
                Mp3Check,
                TxtCheck, CsvCheck, MdCheck, LogCheck,
                JsonCheck, PyCheck, JsCheck,
                ZipCheck, GzipCheck, JarCheck,
                ExeCheck, ApkCheck
            };

            foreach (CheckBox box in boxes)
            {
                if (box.Checked)
                    types.Add(box.Text);
            }

            return types;
        }
    }
}