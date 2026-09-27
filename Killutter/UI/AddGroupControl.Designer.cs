using System.Drawing;
using System.Windows.Forms;

namespace Killutter.UI
{
    partial class AddGroupControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TitleLabel = new Label();
            TypesLabel = new Label();
            DocumentsBox = new GroupBox();
            PdfCheck = new CheckBox();
            DocxCheck = new CheckBox();
            PptxCheck = new CheckBox();
            XlsxCheck = new CheckBox();
            PicturesBox = new GroupBox();
            JpegCheck = new CheckBox();
            PngCheck = new CheckBox();
            GifCheck = new CheckBox();
            AudioBox = new GroupBox();
            Mp3Check = new CheckBox();
            TextBox_Box = new GroupBox();
            TxtCheck = new CheckBox();
            CsvCheck = new CheckBox();
            MdCheck = new CheckBox();
            LogCheck = new CheckBox();
            CodeBox = new GroupBox();
            JsonCheck = new CheckBox();
            PyCheck = new CheckBox();
            JsCheck = new CheckBox();
            ArchivesBox = new GroupBox();
            ZipCheck = new CheckBox();
            GzipCheck = new CheckBox();
            JarCheck = new CheckBox();
            InstallersBox = new GroupBox();
            ExeCheck = new CheckBox();
            ApkCheck = new CheckBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            DestLabel = new Label();
            DestValueLabel = new Label();
            Save = new Button();
            CancelButton = new Button();
            Browse = new Button();
            DocumentsBox.SuspendLayout();
            PicturesBox.SuspendLayout();
            AudioBox.SuspendLayout();
            TextBox_Box.SuspendLayout();
            CodeBox.SuspendLayout();
            ArchivesBox.SuspendLayout();
            InstallersBox.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.FromArgb(240, 240, 240);
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(125, 30);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Add group";
            // 
            // TypesLabel
            // 
            TypesLabel.AutoSize = true;
            TypesLabel.Font = new Font("Segoe UI", 9F);
            TypesLabel.ForeColor = Color.FromArgb(138, 138, 138);
            TypesLabel.Location = new Point(0, 40);
            TypesLabel.Name = "TypesLabel";
            TypesLabel.Size = new Size(56, 15);
            TypesLabel.TabIndex = 1;
            TypesLabel.Text = "File types";
            // 
            // DocumentsBox
            // 
            DocumentsBox.BackColor = Color.FromArgb(43, 43, 43);
            DocumentsBox.Controls.Add(PdfCheck);
            DocumentsBox.Controls.Add(DocxCheck);
            DocumentsBox.Controls.Add(PptxCheck);
            DocumentsBox.Controls.Add(XlsxCheck);
            DocumentsBox.ForeColor = Color.FromArgb(240, 240, 240);
            DocumentsBox.Location = new Point(14, 132);
            DocumentsBox.Name = "DocumentsBox";
            DocumentsBox.Size = new Size(140, 116);
            DocumentsBox.TabIndex = 2;
            DocumentsBox.TabStop = false;
            DocumentsBox.Text = "Documents";
            // 
            // PdfCheck
            // 
            PdfCheck.AutoSize = true;
            PdfCheck.ForeColor = Color.FromArgb(240, 240, 240);
            PdfCheck.Location = new Point(10, 20);
            PdfCheck.Name = "PdfCheck";
            PdfCheck.Size = new Size(44, 19);
            PdfCheck.TabIndex = 0;
            PdfCheck.Text = "pdf";
            // 
            // DocxCheck
            // 
            DocxCheck.AutoSize = true;
            DocxCheck.ForeColor = Color.FromArgb(240, 240, 240);
            DocxCheck.Location = new Point(10, 44);
            DocxCheck.Name = "DocxCheck";
            DocxCheck.Size = new Size(51, 19);
            DocxCheck.TabIndex = 1;
            DocxCheck.Text = "docx";
            // 
            // PptxCheck
            // 
            PptxCheck.AutoSize = true;
            PptxCheck.ForeColor = Color.FromArgb(240, 240, 240);
            PptxCheck.Location = new Point(10, 68);
            PptxCheck.Name = "PptxCheck";
            PptxCheck.Size = new Size(49, 19);
            PptxCheck.TabIndex = 2;
            PptxCheck.Text = "pptx";
            // 
            // XlsxCheck
            // 
            XlsxCheck.AutoSize = true;
            XlsxCheck.ForeColor = Color.FromArgb(240, 240, 240);
            XlsxCheck.Location = new Point(10, 92);
            XlsxCheck.Name = "XlsxCheck";
            XlsxCheck.Size = new Size(44, 19);
            XlsxCheck.TabIndex = 3;
            XlsxCheck.Text = "xlsx";
            // 
            // PicturesBox
            // 
            PicturesBox.BackColor = Color.FromArgb(43, 43, 43);
            PicturesBox.Controls.Add(JpegCheck);
            PicturesBox.Controls.Add(PngCheck);
            PicturesBox.Controls.Add(GifCheck);
            PicturesBox.ForeColor = Color.FromArgb(240, 240, 240);
            PicturesBox.Location = new Point(170, 131);
            PicturesBox.Name = "PicturesBox";
            PicturesBox.Size = new Size(140, 117);
            PicturesBox.TabIndex = 3;
            PicturesBox.TabStop = false;
            PicturesBox.Text = "Pictures";
            // 
            // JpegCheck
            // 
            JpegCheck.AutoSize = true;
            JpegCheck.ForeColor = Color.FromArgb(240, 240, 240);
            JpegCheck.Location = new Point(10, 20);
            JpegCheck.Name = "JpegCheck";
            JpegCheck.Size = new Size(49, 19);
            JpegCheck.TabIndex = 0;
            JpegCheck.Text = "jpeg";
            // 
            // PngCheck
            // 
            PngCheck.AutoSize = true;
            PngCheck.ForeColor = Color.FromArgb(240, 240, 240);
            PngCheck.Location = new Point(10, 44);
            PngCheck.Name = "PngCheck";
            PngCheck.Size = new Size(47, 19);
            PngCheck.TabIndex = 1;
            PngCheck.Text = "png";
            // 
            // GifCheck
            // 
            GifCheck.AutoSize = true;
            GifCheck.ForeColor = Color.FromArgb(240, 240, 240);
            GifCheck.Location = new Point(10, 68);
            GifCheck.Name = "GifCheck";
            GifCheck.Size = new Size(40, 19);
            GifCheck.TabIndex = 2;
            GifCheck.Text = "gif";
            // 
            // AudioBox
            // 
            AudioBox.BackColor = Color.FromArgb(43, 43, 43);
            AudioBox.Controls.Add(Mp3Check);
            AudioBox.ForeColor = Color.FromArgb(240, 240, 240);
            AudioBox.Location = new Point(326, 132);
            AudioBox.Name = "AudioBox";
            AudioBox.Size = new Size(144, 117);
            AudioBox.TabIndex = 4;
            AudioBox.TabStop = false;
            AudioBox.Text = "Audio";
            // 
            // Mp3Check
            // 
            Mp3Check.AutoSize = true;
            Mp3Check.ForeColor = Color.FromArgb(240, 240, 240);
            Mp3Check.Location = new Point(10, 20);
            Mp3Check.Name = "Mp3Check";
            Mp3Check.Size = new Size(50, 19);
            Mp3Check.TabIndex = 0;
            Mp3Check.Text = "mp3";
            // 
            // TextBox_Box
            // 
            TextBox_Box.BackColor = Color.FromArgb(43, 43, 43);
            TextBox_Box.Controls.Add(TxtCheck);
            TextBox_Box.Controls.Add(CsvCheck);
            TextBox_Box.Controls.Add(MdCheck);
            TextBox_Box.Controls.Add(LogCheck);
            TextBox_Box.ForeColor = Color.FromArgb(240, 240, 240);
            TextBox_Box.Location = new Point(14, 268);
            TextBox_Box.Name = "TextBox_Box";
            TextBox_Box.Size = new Size(140, 118);
            TextBox_Box.TabIndex = 5;
            TextBox_Box.TabStop = false;
            TextBox_Box.Text = "Text";
            // 
            // TxtCheck
            // 
            TxtCheck.AutoSize = true;
            TxtCheck.ForeColor = Color.FromArgb(240, 240, 240);
            TxtCheck.Location = new Point(10, 20);
            TxtCheck.Name = "TxtCheck";
            TxtCheck.Size = new Size(39, 19);
            TxtCheck.TabIndex = 0;
            TxtCheck.Text = "txt";
            // 
            // CsvCheck
            // 
            CsvCheck.AutoSize = true;
            CsvCheck.ForeColor = Color.FromArgb(240, 240, 240);
            CsvCheck.Location = new Point(10, 44);
            CsvCheck.Name = "CsvCheck";
            CsvCheck.Size = new Size(43, 19);
            CsvCheck.TabIndex = 1;
            CsvCheck.Text = "csv";
            // 
            // MdCheck
            // 
            MdCheck.AutoSize = true;
            MdCheck.ForeColor = Color.FromArgb(240, 240, 240);
            MdCheck.Location = new Point(10, 68);
            MdCheck.Name = "MdCheck";
            MdCheck.Size = new Size(44, 19);
            MdCheck.TabIndex = 2;
            MdCheck.Text = "md";
            // 
            // LogCheck
            // 
            LogCheck.AutoSize = true;
            LogCheck.ForeColor = Color.FromArgb(240, 240, 240);
            LogCheck.Location = new Point(10, 92);
            LogCheck.Name = "LogCheck";
            LogCheck.Size = new Size(43, 19);
            LogCheck.TabIndex = 3;
            LogCheck.Text = "log";
            // 
            // CodeBox
            // 
            CodeBox.BackColor = Color.FromArgb(43, 43, 43);
            CodeBox.Controls.Add(JsonCheck);
            CodeBox.Controls.Add(PyCheck);
            CodeBox.Controls.Add(JsCheck);
            CodeBox.ForeColor = Color.FromArgb(240, 240, 240);
            CodeBox.Location = new Point(170, 268);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(140, 117);
            CodeBox.TabIndex = 6;
            CodeBox.TabStop = false;
            CodeBox.Text = "Code";
            // 
            // JsonCheck
            // 
            JsonCheck.AutoSize = true;
            JsonCheck.ForeColor = Color.FromArgb(240, 240, 240);
            JsonCheck.Location = new Point(10, 20);
            JsonCheck.Name = "JsonCheck";
            JsonCheck.Size = new Size(48, 19);
            JsonCheck.TabIndex = 0;
            JsonCheck.Text = "json";
            // 
            // PyCheck
            // 
            PyCheck.AutoSize = true;
            PyCheck.ForeColor = Color.FromArgb(240, 240, 240);
            PyCheck.Location = new Point(10, 44);
            PyCheck.Name = "PyCheck";
            PyCheck.Size = new Size(39, 19);
            PyCheck.TabIndex = 1;
            PyCheck.Text = "py";
            // 
            // JsCheck
            // 
            JsCheck.AutoSize = true;
            JsCheck.ForeColor = Color.FromArgb(240, 240, 240);
            JsCheck.Location = new Point(10, 68);
            JsCheck.Name = "JsCheck";
            JsCheck.Size = new Size(34, 19);
            JsCheck.TabIndex = 2;
            JsCheck.Text = "js";
            // 
            // ArchivesBox
            // 
            ArchivesBox.BackColor = Color.FromArgb(43, 43, 43);
            ArchivesBox.Controls.Add(ZipCheck);
            ArchivesBox.Controls.Add(GzipCheck);
            ArchivesBox.Controls.Add(JarCheck);
            ArchivesBox.ForeColor = Color.FromArgb(240, 240, 240);
            ArchivesBox.Location = new Point(326, 268);
            ArchivesBox.Name = "ArchivesBox";
            ArchivesBox.Size = new Size(144, 117);
            ArchivesBox.TabIndex = 7;
            ArchivesBox.TabStop = false;
            ArchivesBox.Text = "Archives";
            // 
            // ZipCheck
            // 
            ZipCheck.AutoSize = true;
            ZipCheck.ForeColor = Color.FromArgb(240, 240, 240);
            ZipCheck.Location = new Point(10, 20);
            ZipCheck.Name = "ZipCheck";
            ZipCheck.Size = new Size(41, 19);
            ZipCheck.TabIndex = 0;
            ZipCheck.Text = "zip";
            // 
            // GzipCheck
            // 
            GzipCheck.AutoSize = true;
            GzipCheck.ForeColor = Color.FromArgb(240, 240, 240);
            GzipCheck.Location = new Point(10, 44);
            GzipCheck.Name = "GzipCheck";
            GzipCheck.Size = new Size(48, 19);
            GzipCheck.TabIndex = 1;
            GzipCheck.Text = "gzip";
            // 
            // JarCheck
            // 
            JarCheck.AutoSize = true;
            JarCheck.ForeColor = Color.FromArgb(240, 240, 240);
            JarCheck.Location = new Point(10, 68);
            JarCheck.Name = "JarCheck";
            JarCheck.Size = new Size(39, 19);
            JarCheck.TabIndex = 2;
            JarCheck.Text = "jar";
            // 
            // InstallersBox
            // 
            InstallersBox.BackColor = Color.FromArgb(43, 43, 43);
            InstallersBox.Controls.Add(ExeCheck);
            InstallersBox.Controls.Add(ApkCheck);
            InstallersBox.ForeColor = Color.FromArgb(240, 240, 240);
            InstallersBox.Location = new Point(487, 210);
            InstallersBox.Name = "InstallersBox";
            InstallersBox.Size = new Size(138, 117);
            InstallersBox.TabIndex = 8;
            InstallersBox.TabStop = false;
            InstallersBox.Text = "Installers";
            // 
            // ExeCheck
            // 
            ExeCheck.AutoSize = true;
            ExeCheck.ForeColor = Color.FromArgb(240, 240, 240);
            ExeCheck.Location = new Point(10, 20);
            ExeCheck.Name = "ExeCheck";
            ExeCheck.Size = new Size(43, 19);
            ExeCheck.TabIndex = 0;
            ExeCheck.Text = "exe";
            // 
            // ApkCheck
            // 
            ApkCheck.AutoSize = true;
            ApkCheck.ForeColor = Color.FromArgb(240, 240, 240);
            ApkCheck.Location = new Point(70, 20);
            ApkCheck.Name = "ApkCheck";
            ApkCheck.Size = new Size(45, 19);
            ApkCheck.TabIndex = 1;
            ApkCheck.Text = "apk";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F);
            NameLabel.ForeColor = Color.FromArgb(138, 138, 138);
            NameLabel.Location = new Point(24, 66);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(73, 15);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Group name";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(43, 43, 43);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = Color.FromArgb(240, 240, 240);
            NameTextBox.Location = new Point(14, 93);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(300, 23);
            NameTextBox.TabIndex = 10;
            // 
            // DestLabel
            // 
            DestLabel.AutoSize = true;
            DestLabel.Font = new Font("Segoe UI", 9F);
            DestLabel.ForeColor = Color.FromArgb(138, 138, 138);
            DestLabel.Location = new Point(14, 424);
            DestLabel.Name = "DestLabel";
            DestLabel.Size = new Size(101, 15);
            DestLabel.TabIndex = 11;
            DestLabel.Text = "Destination folder";
            // 
            // DestValueLabel
            // 
            DestValueLabel.AutoSize = true;
            DestValueLabel.ForeColor = Color.FromArgb(240, 240, 240);
            DestValueLabel.Location = new Point(14, 449);
            DestValueLabel.Name = "DestValueLabel";
            DestValueLabel.Size = new Size(103, 15);
            DestValueLabel.TabIndex = 12;
            DestValueLabel.Text = "No folder selected";
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(58, 58, 58);
            Save.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            Save.FlatAppearance.BorderSize = 3;
            Save.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            Save.FlatStyle = FlatStyle.Flat;
            Save.Location = new Point(468, 430);
            Save.Name = "Save";
            Save.Size = new Size(94, 42);
            Save.TabIndex = 16;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(58, 58, 58);
            CancelButton.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            CancelButton.FlatAppearance.BorderSize = 3;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Location = new Point(579, 430);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 42);
            CancelButton.TabIndex = 17;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // Browse
            // 
            Browse.BackColor = Color.FromArgb(58, 58, 58);
            Browse.FlatAppearance.BorderColor = Color.FromArgb(74, 74, 74);
            Browse.FlatAppearance.BorderSize = 3;
            Browse.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            Browse.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
            Browse.FlatStyle = FlatStyle.Flat;
            Browse.Location = new Point(216, 430);
            Browse.Name = "Browse";
            Browse.Size = new Size(94, 42);
            Browse.TabIndex = 18;
            Browse.Text = "Browse...";
            Browse.UseVisualStyleBackColor = false;
            // 
            // AddGroupControl
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(Browse);
            Controls.Add(CancelButton);
            Controls.Add(Save);
            Controls.Add(TitleLabel);
            Controls.Add(TypesLabel);
            Controls.Add(DocumentsBox);
            Controls.Add(PicturesBox);
            Controls.Add(AudioBox);
            Controls.Add(TextBox_Box);
            Controls.Add(CodeBox);
            Controls.Add(ArchivesBox);
            Controls.Add(InstallersBox);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(DestLabel);
            Controls.Add(DestValueLabel);
            Name = "AddGroupControl";
            Size = new Size(700, 500);
            DocumentsBox.ResumeLayout(false);
            DocumentsBox.PerformLayout();
            PicturesBox.ResumeLayout(false);
            PicturesBox.PerformLayout();
            AudioBox.ResumeLayout(false);
            AudioBox.PerformLayout();
            TextBox_Box.ResumeLayout(false);
            TextBox_Box.PerformLayout();
            CodeBox.ResumeLayout(false);
            CodeBox.PerformLayout();
            ArchivesBox.ResumeLayout(false);
            ArchivesBox.PerformLayout();
            InstallersBox.ResumeLayout(false);
            InstallersBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label TitleLabel;
        private Label TypesLabel;
        private GroupBox DocumentsBox;
        private CheckBox PdfCheck, DocxCheck, PptxCheck, XlsxCheck;
        private GroupBox PicturesBox;
        private CheckBox JpegCheck, PngCheck, GifCheck;
        private GroupBox AudioBox;
        private CheckBox Mp3Check;
        private GroupBox TextBox_Box;
        private CheckBox TxtCheck, CsvCheck, MdCheck, LogCheck;
        private GroupBox CodeBox;
        private CheckBox JsonCheck, PyCheck, JsCheck;
        private GroupBox ArchivesBox;
        private CheckBox ZipCheck, GzipCheck, JarCheck;
        private GroupBox InstallersBox;
        private CheckBox ExeCheck, ApkCheck;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label DestLabel;
        private Label DestValueLabel;
        private Button Save;
        private Button CancelButton;
        private Button Browse;
    }
}