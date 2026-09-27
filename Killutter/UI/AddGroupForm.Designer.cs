namespace Killutter.UI
{
    partial class AddGroupForm
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
            addGroupControl1 = new AddGroupControl();
            SuspendLayout();
            // 
            // addGroupControl1
            // 
            addGroupControl1.BackColor = Color.FromArgb(30, 30, 30);
            addGroupControl1.Dock = DockStyle.Fill;
            addGroupControl1.Location = new Point(0, 0);
            addGroupControl1.Name = "addGroupControl1";
            addGroupControl1.Size = new Size(692, 494);
            addGroupControl1.TabIndex = 0;
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(692, 494);
            Controls.Add(addGroupControl1);
            Name = "AddGroupForm";
            Text = "AddGroupForm";
            ResumeLayout(false);
        }

        #endregion

        private AddGroupControl addGroupControl1;
    }
}