using Sunisoft.IrisSkin;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class LoginForm : Form
{
    public bool login_status = false;
    private Button buttonLogin;
    private Button buttonReg;
    public HttpService httpService = new HttpService();
    private GroupBox groupBox1;
    public Hashtable hashtable_0 = new Hashtable();
    private IContainer icontainer = null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private LinkLabel linkLabel1;
    public long user_id = 0L;
    private SkinEngine skinEngine;
    public string user_name = "";
    public string softwarename = "";
    public string user_key = "";
    public string version = "";
    public string feetype = "";
    public string expiredate = "";
    public string app_path;
    public string user_ini_path = "";
    public string login_url = "";
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TextBox textBoxPwd;
    private TextBox textBoxPwd2;
    private TextBox textBoxPwdReg;
    private TextBox textBoxQQ;
    private TextBox textBoxUser;
    private TextBox textBoxUserReg;

    public LoginForm(string softwarename, string version)
    {
        this.InitializeComponent();
        this.softwarename = softwarename;
        this.version = version;
        this.app_path = Directory.GetCurrentDirectory();
        this.user_ini_path = this.app_path + "/config/user.ini";
        if (File.Exists(this.user_ini_path))
        {
            try
            {
                StreamReader reader = new StreamReader(this.user_ini_path);
                string str = null;
                while ((str = reader.ReadLine()) != null)
                {
                    str = CryptUtil.decrypt(str);
                    this.hashtable_0.Add(str.Split(new char[] { '=' })[0], str.Split(new char[] { '=' })[1]);
                }
                reader.Close();
                reader.Dispose();
                this.textBoxUser.Text = (string)this.hashtable_0["username"];
                this.textBoxPwd.Text = (string)this.hashtable_0["pwd"];
            }
            catch
            {
            }
        }
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        if ("".Equals(this.textBoxUser.Text.Trim()) || "".Equals(this.textBoxPwd.Text.Trim()))
        {
            MessageBox.Show("请输入用户名和密码！");
        }
        else
        {
            this.wirte_user_info();
            Hashtable hashtable = new Hashtable();
            this.user_name = this.textBoxUser.Text.Trim().Replace("'", "").Replace(" or ", "");
            string password = this.textBoxPwd.Text.Trim().Replace("'", "").Replace(" or ", "");
            string str2 = StringUtil.login(this.httpService, this.login_url, "softwarename=" + this.softwarename + "&type=login&user=" + this.user_name + "&password=" + password + "&version=" + this.version);
            str2 = str2.Trim();
            //MessageBox.Show("" + str2);
            if ("error".Equals(str2))
            {
                MessageBox.Show("发生错误请重试！");
            }
            else if ("usernotexist".Equals(str2))
            {
                MessageBox.Show("用户不存在，或者用户名密码错误！");
            }
            else if ("userlogined".Equals(str2))
            {
                MessageBox.Show("已经登录，如果已经关闭，请过2分钟再试！");
            }
            else if ("expired".Equals(str2))
            {
                MessageBox.Show("本软件为收费软件，请联系作者取得版权！！");
            }
            else if (str2.Contains("user_id"))
            {
                foreach (string str3 in str2.Split(new char[] { '&' }))
                {
                    hashtable.Add(str3.Split(new char[] { '=' })[0], str3.Split(new char[] { '=' })[1]);
                }
                this.feetype = (string) hashtable["feetype"];
                this.expiredate = (string) hashtable["expiredate"];
                this.user_id = long.Parse((string)hashtable["user_id"]);
                this.user_key = (string)hashtable["user_key"];
                this.login_status = true;
                base.Close();
            }
            else
            {
                MessageBox.Show("哪里不对了，请重新启动本程序！");
            }
        }
    }

    private void buttonReg_Click(object sender, EventArgs e)
    {
        string user_name = this.textBoxUserReg.Text.Trim();
        string password = this.textBoxPwdReg.Text.Trim();
        string password2 = this.textBoxPwd2.Text.Trim();
        string qq = this.textBoxQQ.Text.Trim();
        if ((("".Equals(user_name) || "".Equals(password)) || "".Equals(password2)) || "".Equals(qq))
        {
            MessageBox.Show("请把各项资料填满！");
        }
        else if (!password.Equals(password2))
        {
            MessageBox.Show("密码不一致！");
        }
        else if (this.check_user())
        {
            string str5 = StringUtil.login(this.httpService, this.login_url, "softwarename=" + this.softwarename + "&type=reg&user=" + user_name + "&password=" + password + "&email=" + qq);
            str5 = str5.Trim();
            //MessageBox.Show("" + str5);
            if ("ok".Equals(str5))
            {
                MessageBox.Show("注册成功！");
                this.textBoxUser.Text = user_name;
                this.textBoxPwd.Text = password;
                this.tabControl1.SelectedIndex = 0;
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
        if (disposing && (this.icontainer != null))
        {
            this.icontainer.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(LoginForm));
        this.buttonLogin = new Button();
        this.textBoxUser = new TextBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.textBoxPwd = new TextBox();
        this.linkLabel1 = new LinkLabel();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.label9 = new Label();
        this.tabPage2 = new TabPage();
        this.label8 = new Label();
        this.label7 = new Label();
        this.buttonReg = new Button();
        this.groupBox1 = new GroupBox();
        this.label5 = new Label();
        this.textBoxQQ = new TextBox();
        this.textBoxPwd2 = new TextBox();
        this.textBoxPwdReg = new TextBox();
        this.textBoxUserReg = new TextBox();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label6 = new Label();
        this.skinEngine = new SkinEngine(this);
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.groupBox1.SuspendLayout();
        base.SuspendLayout();
        this.buttonLogin.Location = new Point(0x83, 0x65);
        this.buttonLogin.Margin = new Padding(2);
        this.buttonLogin.Name = "buttonLogin";
        this.buttonLogin.Size = new Size(0x4f, 0x1a);
        this.buttonLogin.TabIndex = 0;
        this.buttonLogin.Text = "登录";
        this.buttonLogin.UseVisualStyleBackColor = true;
        this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);
        this.textBoxUser.Location = new Point(0x76, 0x20);
        this.textBoxUser.Margin = new Padding(2);
        this.textBoxUser.Name = "textBoxUser";
        this.textBoxUser.Size = new Size(0x88, 0x15);
        this.textBoxUser.TabIndex = 2;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x41, 0x22);
        this.label1.Margin = new Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x35, 12);
        this.label1.TabIndex = 3;
        this.label1.Text = "用户名：";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x41, 0x40);
        this.label2.Margin = new Padding(2, 0, 2, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x29, 12);
        this.label2.TabIndex = 4;
        this.label2.Text = "密码：";
        this.textBoxPwd.Location = new Point(0x76, 0x3b);
        this.textBoxPwd.Margin = new Padding(2);
        this.textBoxPwd.Name = "textBoxPwd";
        this.textBoxPwd.PasswordChar = '*';
        this.textBoxPwd.Size = new Size(0x88, 0x15);
        this.textBoxPwd.TabIndex = 5;
        this.linkLabel1.AutoSize = true;
        this.linkLabel1.Location = new Point(0x4f, 0xae);
        this.linkLabel1.Margin = new Padding(2, 0, 2, 0);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new Size(0xa7, 12);
        this.linkLabel1.TabIndex = 7;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "作者:好品推平台, QQ:987939309";
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.ItemSize = new Size(0x30, 0x19);
        this.tabControl1.Location = new Point(3, -2);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new Size(0x157, 0xeb);
        this.tabControl1.TabIndex = 8;
        this.tabPage1.Controls.Add(this.label9);
        this.tabPage1.Controls.Add(this.label1);
        this.tabPage1.Controls.Add(this.linkLabel1);
        this.tabPage1.Controls.Add(this.buttonLogin);
        this.tabPage1.Controls.Add(this.textBoxPwd);
        this.tabPage1.Controls.Add(this.textBoxUser);
        this.tabPage1.Controls.Add(this.label2);
        this.tabPage1.Location = new Point(4, 0x1d);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(0x14f, 0xca);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "登录";
        this.tabPage1.UseVisualStyleBackColor = true;
        this.label9.AutoSize = true;
        this.label9.ForeColor = Color.Red;
        this.label9.Location = new Point(0x81, 0x91);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0x53, 12);
        this.label9.TabIndex = 8;
        this.label9.Text = "*注册即可使用";
        this.tabPage2.Controls.Add(this.label8);
        this.tabPage2.Controls.Add(this.label7);
        this.tabPage2.Controls.Add(this.buttonReg);
        this.tabPage2.Controls.Add(this.groupBox1);
        this.tabPage2.Location = new Point(4, 0x1d);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(0x14f, 0xca);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "注册";
        this.tabPage2.UseVisualStyleBackColor = true;
        this.label8.AutoSize = true;
        this.label8.Font = new Font("SimSun", 6.6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
        this.label8.ForeColor = Color.Red;
        this.label8.Location = new Point(0x9a, 0xb1);
        this.label8.Margin = new Padding(2, 0, 2, 0);
        this.label8.Name = "label8";
        this.label8.Size = new Size(0x52, 9);
        this.label8.TabIndex = 7;
        this.label8.Text = "*英文字母和数字。";
        this.label7.AutoSize = true;
        this.label7.Font = new Font("SimSun", 6.6f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
        this.label7.ForeColor = Color.Red;
        this.label7.Location = new Point(0x9a, 0xa2);
        this.label7.Margin = new Padding(2, 0, 2, 0);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0x52, 9);
        this.label7.TabIndex = 6;
        this.label7.Text = "*全部必填，只能是";
        this.buttonReg.Location = new Point(0x55, 0x9a);
        this.buttonReg.Margin = new Padding(2);
        this.buttonReg.Name = "buttonReg";
        this.buttonReg.Size = new Size(0x40, 0x21);
        this.buttonReg.TabIndex = 5;
        this.buttonReg.Text = "注册";
        this.buttonReg.UseVisualStyleBackColor = true;
        this.buttonReg.Click += new EventHandler(this.buttonReg_Click);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.textBoxQQ);
        this.groupBox1.Controls.Add(this.textBoxPwd2);
        this.groupBox1.Controls.Add(this.textBoxPwdReg);
        this.groupBox1.Controls.Add(this.textBoxUserReg);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label6);
        this.groupBox1.Location = new Point(70, 0x15);
        this.groupBox1.Margin = new Padding(2);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Padding = new Padding(2);
        this.groupBox1.Size = new Size(0xc2, 0x7e);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "注册";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(4, 0x60);
        this.label5.Margin = new Padding(2, 0, 2, 0);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x3b, 12);
        this.label5.TabIndex = 7;
        this.label5.Text = "邮   箱：";
        this.textBoxQQ.Location = new Point(0x47, 0x60);
        this.textBoxQQ.Margin = new Padding(2);
        this.textBoxQQ.Name = "textBoxQQ";
        this.textBoxQQ.Size = new Size(0x72, 0x15);
        this.textBoxQQ.TabIndex = 6;
        this.textBoxPwd2.Location = new Point(0x47, 0x47);
        this.textBoxPwd2.Margin = new Padding(2);
        this.textBoxPwd2.Name = "textBoxPwd2";
        this.textBoxPwd2.Size = new Size(0x72, 0x15);
        this.textBoxPwd2.TabIndex = 5;
        this.textBoxPwdReg.Location = new Point(0x47, 0x2c);
        this.textBoxPwdReg.Margin = new Padding(2);
        this.textBoxPwdReg.Name = "textBoxPwdReg";
        this.textBoxPwdReg.Size = new Size(0x72, 0x15);
        this.textBoxPwdReg.TabIndex = 4;
        this.textBoxUserReg.Location = new Point(0x47, 0x13);
        this.textBoxUserReg.Margin = new Padding(2);
        this.textBoxUserReg.Name = "textBoxUserReg";
        this.textBoxUserReg.Size = new Size(0x72, 0x15);
        this.textBoxUserReg.TabIndex = 3;
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
        this.label6.AutoSize = true;
        this.label6.Location = new Point(4, 0x19);
        this.label6.Margin = new Padding(2, 0, 2, 0);
        this.label6.Name = "label6";
        this.label6.Size = new Size(0x41, 12);
        this.label6.TabIndex = 0;
        this.label6.Text = "用 户 名：";
        this.skinEngine.SerialNumber = "";
        this.skinEngine.SkinFile = null;
        base.AutoScaleDimensions = new SizeF(6f, 12f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x166, 0xef);
        base.Controls.Add(this.tabControl1);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Margin = new Padding(2);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "LoginForm";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "好品推用户登录";
        base.Load += new EventHandler(this.LoginForm_Load);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        base.ResumeLayout(false);
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        this.skinEngine.SkinFile = Application.StartupPath + @"\skin\Deep\DeepCyan.ssk";
    }

    public void wirte_user_info()
    {
        if (File.Exists(this.user_ini_path))
        {
            File.Delete(this.user_ini_path);
        }
        FileStream stream = new FileStream(this.user_ini_path, FileMode.CreateNew);
        StreamWriter writer = new StreamWriter(stream);
        writer.WriteLine(CryptUtil.encrypt("username=" + this.textBoxUser.Text));
        writer.WriteLine(CryptUtil.encrypt("pwd=" + this.textBoxPwd.Text));
        writer.Flush();
        writer.Close();
        stream.Close();
    }

    public bool check_user()
    {
        string pattern = "^[a-zA-Z0-9]+$";
        if (!((Regex.Match(this.textBoxUserReg.Text.Trim(), pattern).Success && Regex.Match(this.textBoxPwdReg.Text.Trim(), pattern).Success) ))
        {
            MessageBox.Show("只能输入英文或者数字");
            return false;
        }
        string pattern_email = @"^(\w)+(\.\w+)*@(\w)+((\.\w{2,3}){1,3})$";
        if (!( Regex.Match(this.textBoxQQ.Text.Trim(), pattern_email).Success))
        {
            MessageBox.Show("请填写正确的邮箱");
            return false;
        }
        return true;
    }
}

