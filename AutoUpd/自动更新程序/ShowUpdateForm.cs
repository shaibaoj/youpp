namespace 自动更新程序
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ShowUpdateForm : Form
    {
        private IContainer icontainer_0 = null;
        public Label labelDlFile;
        public Label labelDlFileName;
        public ProgressBar progressBarAll;
        public ProgressBar progressBarFile;

        public ShowUpdateForm()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelDlFileName = new Label();
            this.labelDlFile = new Label();
            this.progressBarFile = new ProgressBar();
            this.progressBarAll = new ProgressBar();
            base.SuspendLayout();
            this.labelDlFileName.AutoSize = true;
            this.labelDlFileName.Location = new Point(0x16, 11);
            this.labelDlFileName.Name = "labelDlFileName";
            this.labelDlFileName.Size = new Size(0, 12);
            this.labelDlFileName.TabIndex = 0x2d;
            this.labelDlFile.AutoSize = true;
            this.labelDlFile.Location = new Point(0x16, 0x3a);
            this.labelDlFile.Name = "labelDlFile";
            this.labelDlFile.Size = new Size(0, 12);
            this.labelDlFile.TabIndex = 0x2c;
            this.progressBarFile.Location = new Point(12, 0x4c);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new Size(490, 0x17);
            this.progressBarFile.TabIndex = 0x2b;
            this.progressBarAll.Location = new Point(12, 0x1a);
            this.progressBarAll.Name = "progressBarAll";
            this.progressBarAll.Size = new Size(490, 0x17);
            this.progressBarAll.TabIndex = 0x2a;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x20c, 0x76);
            base.Controls.Add(this.labelDlFileName);
            base.Controls.Add(this.labelDlFile);
            base.Controls.Add(this.progressBarFile);
            base.Controls.Add(this.progressBarAll);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "ShowUpdateForm";
            this.Text = "ShowUpdateForm";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

