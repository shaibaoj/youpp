using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

public class VipUtil
{
    public HttpService httpService = new HttpService();
    public Hashtable hashtable = new Hashtable();
    public int sleeptime = 0x1d4c0;
    public int onlinememnum = 0;
    public int ordertask = 0;
    public int orderdltask = 0;
    public int usergroup = 0;
    public int visits = 0;
    public long user_id = 0L;
    public string user_name = "";
    public string user_key = "";
    public string login_url = "";
    public string softwarename = "";
    public string main_exe = "";
    public string version = "";
    public string feetype = "";
    public string expiredate = "";
    public string md5 = "";

    public bool login(string softwarename, string main_exe, string version)
    {
        this.softwarename = softwarename;
        this.main_exe = main_exe;
        this.version = version;
        LoginForm form = new LoginForm(softwarename, version);
        form.login_url = this.login_url;
        form.ShowDialog();
        this.user_id = form.user_id;
        this.user_key = form.user_key;
        this.user_name = form.user_name;
        this.feetype = form.feetype;
        this.expiredate = form.expiredate;
        return form.login_status;
    }

    public bool login1(string softwarename, string main_exe, string version)
    {
        this.softwarename = softwarename;
        this.main_exe = main_exe;
        this.version = version;
        LoginForm2 form = new LoginForm2(softwarename, version);
        form.login_url = this.login_url;
        form.int_0 = this.usergroup;
        form.ShowDialog();
        this.user_id = form.user_id;
        this.user_name = form.user_name;
        this.feetype = form.feetype;
        this.expiredate = form.expiredate;
        return form.login_status;
    }

    public void online()
    {
        while (true)
        {
            try
            {
                string str = "";
                string str2 = this.httpService.post(this.login_url, string.Concat(new object[] { "softwarename=", this.softwarename, "&type=heartbeat&version=", this.version, "&user=", this.user_name, "&usergroup=", this.usergroup, "&loginid=", this.user_id, "&md5=", this.md5 }));
                if (str2.StartsWith("result="))
                {
                    foreach (string str3 in str2.Split(new char[] { '&' }))
                    {
                        string[] strArray3 = str3.Split(new char[] { '=' });
                        if (this.hashtable.ContainsKey(strArray3[0]))
                        {
                            this.hashtable[strArray3[0]] = strArray3[1];
                        }
                        else
                        {
                            this.hashtable.Add(strArray3[0], strArray3[1]);
                        }
                    }
                    str = this.hashtable["result"].ToString();
                    try
                    {
                        this.onlinememnum = int.Parse(this.hashtable["onlinememnum"].ToString());
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.ordertask = int.Parse(this.hashtable["ordertask"].ToString());
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.orderdltask = int.Parse(this.hashtable["orderdltask"].ToString());
                        goto Label_01C9;
                    }
                    catch
                    {
                        goto Label_01C9;
                    }
                }
                str = str2;
            Label_01C9:
                if ("ok".Equals(str))
                {
                    this.visits = 0;
                }
                else
                {
                    System.Timers.Timer timer;
                    Random random;
                    if ("expired".Equals(str))
                    {
                        timer = new System.Timers.Timer();
                        timer.Interval = 60000.0;
                        timer.Elapsed += new ElapsedEventHandler(this.method_3);
                        timer.Start();
                        MessageBox.Show("软件已过期，请续费(软件在1分钟内退出)！");
                        break;
                    }
                    if ("notmatch".Equals(str) || "notlogined".Equals(str))
                    {
                        random = new Random();
                        timer = new System.Timers.Timer();
                        timer.Interval = random.Next(0x2bf20);
                        timer.Elapsed += new ElapsedEventHandler(this.method_4);
                        timer.Start();
                        MessageBox.Show("登录异常！");
                        break;
                    }
                    if ("error".Equals(str))
                    {
                        this.visits++;
                        if (this.visits > 3)
                        {
                            random = new Random();
                            timer = new System.Timers.Timer();
                            timer.Interval = random.Next(0xea60);
                            timer.Elapsed += new ElapsedEventHandler(this.method_3);
                            timer.Start();
                            MessageBox.Show("貌似发生点问题，请重新登录！！");
                            break;
                        }
                    }
                }
            }
            catch
            {
            }
            Thread.Sleep(this.sleeptime);
        }
    }

    public void method_3(object sender, ElapsedEventArgs e)
    {
        Environment.Exit(Environment.ExitCode);
    }

    public void method_4(object sender, ElapsedEventArgs e)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        FileStream stream = new FileStream(currentDirectory + @"\config\update.cmd", FileMode.Create);
        StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding("GB2312"));
        writer.WriteLine("taskkill /f /im " + this.main_exe);
        writer.WriteLine("del \"" + currentDirectory + @"\" + this.main_exe + "\"");
        writer.WriteLine("del \"" + currentDirectory + "\\common.dll\"");
        writer.WriteLine("ping -n 1 127.1>nul");
        writer.WriteLine("exit");
        writer.Flush();
        writer.Close();
        writer.Dispose();
        stream.Close();
        stream.Dispose();
        Environment.Exit(Environment.ExitCode);
    }

    public void login()
    {
        StringUtil.login(this.httpService, this.login_url, string.Concat(new object[] { "softwarename=", this.softwarename, "&type=logout&user=", this.user_name, "&loginid=", this.user_id }));
    }
}

