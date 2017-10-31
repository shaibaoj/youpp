using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using haopintui;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;
using LitJson;

namespace haopintui
{
    public partial class FormLogin : BaseForm
    {

        public string user_name = "";
        public string softwarename = "";
        public string user_key = "";
        public string version = "";
        public string feetype = "";
        public string expiredate = "";
        public string app_path;
        public string user_ini_path = "";
        public string login_url = "";
        public string qunfa = "";
        public string alimama_id = "";
        public string qunfa_date = "";
        public string user_type_name = "";

        public Hashtable hashtable_0 = new Hashtable();
        public long user_id = 0L;
        public HttpService httpService = new HttpService(); 
        public bool login_status = false;


        #region Constructor
        public FormLogin(string softwarename, string version)
        {
            InitializeComponent();
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
        #endregion

        private void FormExIni()
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            SetStyles();
        }
        private void SetStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                try
                {
                    JsonData jo = JsonMapper.ToObject(str2);
                    if (jo["result"]!=null
                        && jo["result"]["map"] != null
                        && jo["result"]["map"]["item"] != null)
                    {
                        string msg = jo["result"]["map"]["item"]["msg"].ToString();
                        if ("error".Equals(msg))
                        {
                            MessageBox.Show("发生错误请重试！");
                        }
                        else if ("usernotexist".Equals(msg))
                        {
                            MessageBox.Show("用户不存在，或者用户名密码错误！");
                        }
                        else if ("userlogined".Equals(msg))
                        {
                            MessageBox.Show("已经登录，如果已经关闭，请过2分钟再试！");
                        }
                        else if ("expired".Equals(msg))
                        {
                            MessageBox.Show("本软件为收费软件，请联系作者取得版权！！");
                        }
                        else if (msg.Equals("ok"))
                        {

                            this.feetype = jo["result"]["map"]["item"]["feetype"].ToString();
                            this.expiredate = jo["result"]["map"]["item"]["expiredate"].ToString();
                            this.user_id = long.Parse(jo["result"]["map"]["item"]["user_id"].ToString());
                            this.user_key = jo["result"]["map"]["item"]["user_key"].ToString();
                            this.qunfa = jo["result"]["map"]["item"]["qunfa"].ToString();
                            this.alimama_id = jo["result"]["map"]["item"]["alimama_id"].ToString();
                            this.qunfa_date = jo["result"]["map"]["item"]["qunfa_date"].ToString();
                            this.user_type_name = jo["result"]["map"]["item"]["user_type_name"].ToString();

                            this.login_status = true;
                            base.Close();

                            //foreach (string str3 in str2.Split(new char[] { '&' }))
                            //{
                            //    hashtable.Add(str3.Split(new char[] { '=' })[0], str3.Split(new char[] { '=' })[1]);
                            //}
                            //this.feetype = (string)hashtable["feetype"];
                            //this.expiredate = (string)hashtable["expiredate"];
                            //this.user_id = long.Parse((string)hashtable["user_id"]);
                            //this.user_key = (string)hashtable["user_key"];
                            //this.qunfa = (string)hashtable["qunfa"];
                            //this.alimama_id = (string)hashtable["alimama_id"];
                            //this.login_status = true;
                            //base.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("哪里不对了，好像您的网络不通哦，请重新启动本程序！");
                }
            }
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
            //string pattern = "^[a-zA-Z0-9]+$";
            //if (!((Regex.Match(this.textBoxUserReg.Text.Trim(), pattern).Success && Regex.Match(this.textBoxPwdReg.Text.Trim(), pattern).Success)))
            //{
            //    MessageBox.Show("只能输入英文或者数字");
            //    return false;
            //}
            //string pattern_email = @"^(\w)+(\.\w+)*@(\w)+((\.\w{2,3}){1,3})$";
            //if (!(Regex.Match(this.textBoxQQ.Text.Trim(), pattern_email).Success))
            //{
            //    MessageBox.Show("请填写正确的邮箱");
            //    return false;
            //}
            return true;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //base.OnMouseDown(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.haopintui.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
