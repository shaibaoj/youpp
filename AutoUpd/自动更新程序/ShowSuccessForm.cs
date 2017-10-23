namespace 自动更新程序
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ShowSuccessForm : Form
    {
        private Button buttonUpdConfirm;
        private IContainer icontainer_0 = null;
        private RichTextBox richTextBoxUpdLog;

        public ShowSuccessForm(string string_0)
        {
            this.InitializeComponent();
            this.richTextBoxUpdLog.Text = string_0;
        }

        private void buttonUpdConfirm_Click(object sender, EventArgs e)
        {
            base.Close();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ShowSuccessForm));
            this.richTextBoxUpdLog = new RichTextBox();
            this.buttonUpdConfirm = new Button();
            base.SuspendLayout();
            this.richTextBoxUpdLog.Location = new Point(3, 4);
            this.richTextBoxUpdLog.Name = "richTextBoxUpdLog";
            this.richTextBoxUpdLog.ReadOnly = true;
            this.richTextBoxUpdLog.Size = new Size(0x228, 0x179);
            this.richTextBoxUpdLog.TabIndex = 0;
            this.richTextBoxUpdLog.Text = "";
            this.buttonUpdConfirm.Font = new Font("SimSun", 12f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.buttonUpdConfirm.Location = new Point(0xdb, 0x183);
            this.buttonUpdConfirm.Name = "buttonUpdConfirm";
            this.buttonUpdConfirm.Size = new Size(0x86, 0x1f);
            this.buttonUpdConfirm.TabIndex = 1;
            this.buttonUpdConfirm.Text = "确定";
            this.buttonUpdConfirm.UseVisualStyleBackColor = true;
            this.buttonUpdConfirm.Click += new EventHandler(this.buttonUpdConfirm_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x231, 430);
            base.Controls.Add(this.buttonUpdConfirm);
            base.Controls.Add(this.richTextBoxUpdLog);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "ShowSuccessForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "更新成功！";
            base.ResumeLayout(false);
        }
    }
}

