using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class RegisterForm : Form
{
    public bool bool_0 = false;
    private Button buttonReg;
    private HttpService httpService = new HttpService();
    private GroupBox groupBox1;
    private IContainer icontainer_0 = null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label8;
    public string string_0 = "";
    public string string_1 = "";
    public string string_2 = "";
    public string string_3 = "";
    private TextBox textBoxPwd;
    private TextBox textBoxPwd2;
    private TextBox textBoxQQ;
    private TextBox textBoxUser;

    public RegisterForm(string string_4, string string_5)
    {
        this.InitializeComponent();
        this.string_2 = string_4;
        this.string_3 = string_5;
    }

    private void buttonReg_Click(object sender, EventArgs e)
    {
        string text = this.textBoxUser.Text;
        string str2 = this.textBoxPwd.Text;
        string str3 = this.textBoxPwd2.Text;
        string str4 = this.textBoxQQ.Text;
        if ((("".Equals(text) || "".Equals(str2)) || "".Equals(str3)) || "".Equals(str4))
        {
            MessageBox.Show("请把各项资料填满！");
        }
        else if (!str2.Equals(str3))
        {
            MessageBox.Show("密码不一致！");
        }
        else if (this.method_0())
        {
            string str5 = this.httpService.post(this.string_3, "softwarename=" + this.string_2 + "&type=reg&user=" + text + "&password=" + str2 + "&qq=" + str4);
            if ("ok".Equals(str5))
            {
                this.bool_0 = true;
                this.string_0 = text;
                this.string_1 = str2;
                MessageBox.Show("注册成功！");
                base.Close();
            }
            else if ("dup".Equals(str5))
            {
                MessageBox.Show("用户已存在！");
            }
            else if ("error".Equals(str5))
            {
                MessageBox.Show("发生错误，请重试！");
            }
        }
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(RegisterForm));
        this.label1 = new Label();
        this.groupBox1 = new GroupBox();
        this.label5 = new Label();
        this.textBoxQQ = new TextBox();
        this.textBoxPwd2 = new TextBox();
        this.textBoxPwd = new TextBox();
        this.textBoxUser = new TextBox();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.buttonReg = new Button();
        this.label6 = new Label();
        this.label8 = new Label();
        this.groupBox1.SuspendLayout();
        base.SuspendLayout();
        this.label1.AutoSize = true;
        this.label1.BackColor = SystemColors.Control;
        this.label1.Font = new Font("SimSun", 10.8f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
        this.label1.ForeColor = SystemColors.Highlight;
        this.label1.Location = new Point(0x39, 14);
        this.label1.Margin = new Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x67, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "注册飞豹用户";
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.textBoxQQ);
        this.groupBox1.Controls.Add(this.textBoxPwd2);
        this.groupBox1.Controls.Add(this.textBoxPwd);
        this.groupBox1.Controls.Add(this.textBoxUser);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Location = new Point(9, 0x1f);
        this.groupBox1.Margin = new Padding(2, 2, 2, 2);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Padding = new Padding(2, 2, 2, 2);
        this.groupBox1.Size = new Size(0xc2, 0x7e);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "注册";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(4, 0x60);
        this.label5.Margin = new Padding(2, 0, 2, 0);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x3b, 12);
        this.label5.TabIndex = 7;
        this.label5.Text = "QQ   号：";
        this.textBoxQQ.Location = new Point(0x47, 0x60);
        this.textBoxQQ.Margin = new Padding(2, 2, 2, 2);
        this.textBoxQQ.Name = "textBoxQQ";
        this.textBoxQQ.Size = new Size(0x72, 0x15);
        this.textBoxQQ.TabIndex = 6;
        this.textBoxPwd2.Location = new Point(0x47, 0x47);
        this.textBoxPwd2.Margin = new Padding(2, 2, 2, 2);
        this.textBoxPwd2.Name = "textBoxPwd2";
        this.textBoxPwd2.Size = new Size(0x72, 0x15);
        this.textBoxPwd2.TabIndex = 5;
        this.textBoxPwd.Location = new Point(0x47, 0x2c);
        this.textBoxPwd.Margin = new Padding(2, 2, 2, 2);
        this.textBoxPwd.Name = "textBoxPwd";
        this.textBoxPwd.Size = new Size(0x72, 0x15);
        this.textBoxPwd.TabIndex = 4;
        this.textBoxUser.Location = new Point(0x47, 0x13);
        this.textBoxUser.Margin = new Padding(2, 2, 2, 2);
        this.textBoxUser.Name = "textBoxUser";
        this.textBoxUser.Size = new Size(0x72, 0x15);
        this.textBoxUser.TabIndex = 3;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(4, 0x4a);
        this.label4.Margin = new Padding(2, 0, 2, 0);
        this.label4.Name = "label4";
        this.label4.Size = new Size(0x41, 12);
        this.label4.TabIndex = 2;
        this.label4.Text = "确认密码：";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(4, 0x31);
        this.label3.Margin = new Padding(2, 0, 2, 0);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x41, 12);
        this.label3.TabIndex = 1;
        this.label3.Text = "密    码：";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(4, 0x19);
        this.label2.Margin = new Padding(2, 0, 2, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x41, 12);
        this.label2.TabIndex = 0;
        this.label2.Text = "用 户 名：";
        this.buttonReg.Location = new Point(0x3f, 0xa2);
        this.buttonReg.Margin = new Padding(2, 2, 2, 2);
        this.buttonReg.Name = "buttonReg";
        this.buttonReg.Size = new Size(0x40, 0x21);
        this.buttonReg.TabIndex = 0;
        this.buttonReg.Text = "注册";
        this.buttonReg.UseVisualStyleBackColor = true;
        this.buttonReg.Click += new EventHandler(this.buttonReg_Click);
        this.label6.AutoSize = true;
        this.label6.Font = new Font("SimSun", 6.6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
        this.label6.ForeColor = Color.Red;
        this.label6.Location = new Point(0x84, 170);
        this.label6.Margin = new Padding(2, 0, 2, 0);
        this.label6.Name = "label6";
        this.label6.Size = new Size(0x52, 9);
        this.label6.TabIndex = 2;
        this.label6.Text = "*全部必填，只能是";
        this.label8.AutoSize = true;
        this.label8.Font = new Font("SimSun", 6.6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
        this.label8.ForeColor = Color.Red;
        this.label8.Location = new Point(0x84, 0xb9);
        this.label8.Margin = new Padding(2, 0, 2, 0);
        this.label8.Name = "label8";
        this.label8.Size = new Size(0x52, 9);
        this.label8.TabIndex = 4;
        this.label8.Text = "*英文字母和数字。";
        base.AutoScaleDimensions = new SizeF(6f, 12f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0xda, 200);
        base.Controls.Add(this.label8);
        base.Controls.Add(this.label6);
        base.Controls.Add(this.buttonReg);
        base.Controls.Add(this.groupBox1);
        base.Controls.Add(this.label1);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Margin = new Padding(2, 2, 2, 2);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "RegisterForm";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "飞豹注册窗口";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    public bool method_0()
    {
        string pattern = "^[a-zA-Z0-9]+$";
        if (!((Regex.Match(this.textBoxUser.Text, pattern).Success && Regex.Match(this.textBoxPwd.Text, pattern).Success) && Regex.Match(this.textBoxQQ.Text, pattern).Success))
        {
            MessageBox.Show("只能输入英文或者数字");
            return false;
        }
        return true;
    }
}

