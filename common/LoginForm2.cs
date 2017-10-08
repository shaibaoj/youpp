using Sunisoft.IrisSkin;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class LoginForm2 : Form
{
    public bool login_status = false;
    private Button buttonLogin;
    public HttpService gclass16_0 = new HttpService();
    public Hashtable hashtable_0 = new Hashtable();
    private IContainer icontainer_0 = null;
    public int int_0 = 0;
    private Label label1;
    private Label label2;
    private LinkLabel linkLabel1;
    public long user_id = 0L;
    private SkinEngine skinEngine_0;
    public string user_name = "";
    public string string_1 = "";
    public string string_2 = "";
    public string string_3 = "";
    public string feetype = "";
    public string expiredate = "";
    public string string_6;
    public string string_7 = "";
    public string login_url = "";
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TextBox textBoxPwd;
    private TextBox textBoxUser;

    public LoginForm2(string string_9, string string_10)
    {
        this.InitializeComponent();
        this.string_1 = string_9;
        this.string_3 = string_10;
        this.string_6 = Directory.GetCurrentDirectory();
        this.string_7 = this.string_6 + "/config/user.ini";
        if (File.Exists(this.string_7))
        {
            StreamReader reader = new StreamReader(this.string_7);
            string str = null;
            while ((str = reader.ReadLine()) != null)
            {
                str = CryptUtil.decrypt(str);
                this.hashtable_0.Add(str.Split(new char[] { '=' })[0], str.Split(new char[] { '=' })[1]);
            }
            reader.Close();
            reader.Dispose();
            this.textBoxUser.Text = (string) this.hashtable_0["username"];
            this.textBoxPwd.Text = (string) this.hashtable_0["pwd"];
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
            this.method_1();
            Hashtable hashtable = new Hashtable();
            this.user_name = this.textBoxUser.Text.Trim().Replace("'", "").Replace(" or ", "");
            string str = this.textBoxPwd.Text.Trim().Replace("'", "").Replace(" or ", "");
            string str2 = this.method_0(this.gclass16_0, this.login_url, string.Concat(new object[] { "softwarename=", this.string_1, "&type=login&user=", this.user_name, "&usergroup=", this.int_0, "&password=", str, "&version=", this.string_3 }));
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
            else if (str2.Contains("loginid"))
            {
                foreach (string str3 in str2.Split(new char[] { '&' }))
                {
                    hashtable.Add(str3.Split(new char[] { '=' })[0], str3.Split(new char[] { '=' })[1]);
                }
                this.feetype = (string) hashtable["feetype"];
                this.expiredate = (string) hashtable["expiredate"];
                this.user_id = long.Parse((string) hashtable["loginid"]);
                this.login_status = true;
                base.Close();
            }
            else
            {
                MessageBox.Show("哪里不对了，请重新启动本程序！");
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
        ComponentResourceManager manager = new ComponentResourceManager(typeof(LoginForm2));
        this.buttonLogin = new Button();
        this.textBoxUser = new TextBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.textBoxPwd = new TextBox();
        this.linkLabel1 = new LinkLabel();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.skinEngine_0 = new SkinEngine(this);
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
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
        this.linkLabel1.Location = new Point(0x74, 0xad);
        this.linkLabel1.Margin = new Padding(2, 0, 2, 0);
        this.linkLabel1.Name = "linkLabel1";
        this.linkLabel1.Size = new Size(0x6b, 12);
        this.linkLabel1.TabIndex = 7;
        this.linkLabel1.TabStop = true;
        this.linkLabel1.Text = "作者:闵闲电子商务";
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.ItemSize = new Size(0x30, 0x19);
        this.tabControl1.Location = new Point(3, -2);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new Size(0x157, 0xeb);
        this.tabControl1.TabIndex = 8;
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
        this.skinEngine_0.SerialNumber = "";
        this.skinEngine_0.SkinFile = null;
        base.AutoScaleDimensions = new SizeF(6f, 12f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x166, 0xef);
        base.Controls.Add(this.tabControl1);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.Margin = new Padding(2);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "LoginForm2";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "闵闲电子商务用户登录";
        base.Load += new EventHandler(this.LoginForm2_Load);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        base.ResumeLayout(false);
    }

    private void LoginForm2_Load(object sender, EventArgs e)
    {
        this.skinEngine_0.SkinFile = Application.StartupPath + @"\skin\Deep\DeepCyan.ssk";
    }

    public string method_0(HttpService gclass16_1, string string_9, string string_10)
    {
        try
        {
            return gclass16_1.post(string_9, string_10);
        }
        catch (Exception exception)
        {
            string str2 = exception.ToString();
            if (!str2.Contains("System.Net.WebException") && !str2.Contains("System.IO.IOException"))
            {
                throw exception;
            }
            return gclass16_1.post(string_9, string_10);
        }
    }

    public void method_1()
    {
        if (File.Exists(this.string_7))
        {
            File.Delete(this.string_7);
        }
        FileStream stream = new FileStream(this.string_7, FileMode.CreateNew);
        StreamWriter writer = new StreamWriter(stream);
        writer.WriteLine(CryptUtil.encrypt("username=" + this.textBoxUser.Text));
        writer.WriteLine(CryptUtil.encrypt("pwd=" + this.textBoxPwd.Text));
        writer.Flush();
        writer.Close();
        stream.Close();
    }
}

