using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Form2 : Form
{
    private IContainer icontainer_0 = null;
    private Label label1;
    private Label label2;
    private LinkLabel linkLabel1;
    public TextBox textBoxKey;
    public TextBox textBoxMashine;

    public Form2()
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
        this.label1 = new Label();
        this.label2 = new Label();
        this.textBoxMashine = new TextBox();
        this.textBoxKey = new TextBox();
        this.linkLabel1 = new LinkLabel();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x20, 0x39);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x61, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "本机机器码：";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x1b, 0x63);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x79, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "KEY文件机器码：";
        this.textBoxMashine.Location = new Point(0x92, 0x2f);
        this.textBoxMashine.Name = "textBoxMashine";
        this.textBoxMashine.ReadOnly = true;
        this.textBoxMashine.Size = new Size(0x166, 0x19);
        this.textBoxMashine.TabIndex = 2;
        this.textBoxKey.Location = new Point(0x92, 0x60);
        this.textBoxKey.Name = "textBoxKey";
        this.textBoxKey.ReadOnly = true;
        this.textBoxKey.Size = new Size(0x166, 0x19);
        this.textBoxKey.TabIndex = 3;
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.Location = new Point(0x59, 190);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new Size(0x14f, 15);
        this.linkLabel1.TabIndex = 4;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "如有问题，任何问题请联系作者。QQ：462389496";
        base.AutoScaleDimensions = new SizeF(8f, 15f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x224, 0xd6);
        base.Controls.Add(this.linkLabel1);
        base.Controls.Add(this.textBoxKey);
        base.Controls.Add(this.textBoxMashine);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.label1);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "Form2";
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        this.Text = "注册KEY失败啦！！";
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}

