using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class UpdateForm : Form
{
    private IContainer icontainer_0 = null;
    public Label label1;
    public ProgressBar progressBar1;

    public UpdateForm()
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
        this.progressBar1 = new ProgressBar();
        this.label1 = new Label();
        base.SuspendLayout();
        this.progressBar1.Location = new Point(7, 0x26);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new Size(0x13e, 0x17);
        this.progressBar1.TabIndex = 0x26;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x65, 0x11);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x4d, 12);
        this.label1.TabIndex = 0x27;
        this.label1.Text = "正在下载程序";
        base.AutoScaleDimensions = new SizeF(6f, 12f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x150, 0x4d);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.progressBar1);
        base.FormBorderStyle = FormBorderStyle.None;
        base.Name = "UpdateForm";
        base.ShowInTaskbar = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "正在更新";
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

