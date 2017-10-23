using Coco.Framework;
using Coco.Framework.Entities;
using Coco.Framework.SDK;
using Coco.Framework.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Coco.WebPlugin
{
    public class WebPlugin : Plugin
    {
        public WebPlugin()
        {
            this.PluginName = "Web接口";
            this.Description = "机器人Web接口，机器人事件POST给web接口，本地监听Web请求";
        }

        public override bool ShowForm()
        {
            if (new FormMain(config).ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StartWebServer();
                StartGetWeb();
            }
            return base.ShowForm();
        }

        WebConfig config = null;
        public override bool Start()
        {
            config = PluginConfig.FromFile<WebConfig>();

            this.AddedToCluster += sdk_AddedToCluster;
            this.AddedToClusterInvite += sdk_AddedToClusterInvite;
            this.AddMeFriend += sdk_AddMeFriend;
            this.AddMeFriendNeedAuth += sdk_AddMeFriendNeedAuth;
            this.AddToClusterNeedAuth += sdk_AddToClusterNeedAuth;
            this.CardChanged += sdk_CardChanged;
            this.ClusterAdminChanged += sdk_ClusterAdminChanged;
            this.KeepAlive += sdk_KeepAlive;
            this.Licence += sdk_Licence;
            this.LoginSuccessed += sdk_LoginSuccessed;
            this.LostConnection += sdk_LostConnection;
            this.MemberExitCluster += sdk_MemberExitCluster;
            this.QQLevel += sdk_QQLevel;
            this.ReceiveClusterIM += sdk_ReceiveClusterIM;
            this.ReceiveNormalIM += sdk_ReceiveNormalIM;
            this.ReceiveTempIM += sdk_ReceiveTempIM;
            this.ReceiveSubjectIM += sdk_ReceiveSubjectIM;
            this.ReceiveVibration += sdk_ReceiveVibration;
            this.RejectJoinCluster += sdk_RejectJoinCluster;
            this.SignatureChanged += sdk_SignatureChanged;
            this.StatusChanged += sdk_StatusChanged;
            this.ClusterEvent += sdk_ClusterEvent;
            this.QQPayEvent += WebPlugin_QQPayEvent;
            this.SilencedQQEvent += WebPlugin_SilencedQQEvent;

            StartWebServer();
            StartGetWeb();

            return base.Start();
        }

        void WebPlugin_SilencedQQEvent(object sender, SilencedQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "SilencedQQEvent", "ExternalId", e.Cluster.ExternalId, "QQ", e.QQ, "Time", e.Time);            
        }

        void WebPlugin_QQPayEvent(object sender, QQPayEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "QQPayEvent", "QQ", e.QQ, "Fee", e.Fee, "Intro", e.Intro, "Id", e.Id);
        }

        void sdk_ClusterEvent(object sender, ClusterEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "ClusterEvent", "ExternalId", e.Cluster.ExternalId, "ClusterName", e.Cluster.Name, "QQ", friend.QQ, "NickName", friend.NickName, "DateTime", e.DateTime.ToString(), "XML", e.XML);
        }

        void sdk_ReceiveSubjectIM(object sender, ReceiveSubjectIMQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "ReceiveSubjectIM", "ClusterId", e.ClusterId, "QQ", friend.QQ, "NickName", friend.NickName, "Message", e.Message);
        }

        void sdk_StatusChanged(object sender, StatusChangedQQEventArgs e)
        {
            var Friend = e.friend;
            var friend = this.GetFriend(Friend.QQ);
            e.Cancel = SendToWeb("Event", "StatusChanged", "QQ", friend.QQ, "NickName", friend.NickName, "QQStatus", Friend.QQStatus.ToString());
        }

        void sdk_SignatureChanged(object sender, SignatureChangedQQEventArgs e)
        {
            var Friend = e.friend;
            var friend = this.GetFriend(Friend.QQ);
            e.Cancel = SendToWeb("Event", "SignatureChanged", "QQ", friend.QQ, "NickName", friend.NickName, "Signature", Friend.Signature.Sig);
        }

        void sdk_RejectJoinCluster(object sender, RejectJoinClusterQQEventArgs e)
        {
            var Cluster = e.Cluster;
            var friend = this.GetFriend(e.ClusterMemberAdmin.QQ);
            e.Cancel = SendToWeb("Event", "RejectJoinCluster", "ExternalId", Cluster.ExternalId, "Name", Cluster.Name, "QQ", friend.QQ, "NickName", friend.NickName, "Message", e.Message);
        }

        void sdk_ReceiveVibration(object sender, ReceiveVibrationQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "ReceiveVibration", "QQ", friend.QQ, "NickName", friend.NickName, "First", e.First);
        }

        void sdk_ReceiveTempIM(object sender, ReceiveTempIMQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "ReceiveTempIM", "ExternalId", e.ExternalId, "QQ", friend.QQ, "NickName", friend.NickName, "Message", e.Message);
        }

        void sdk_ReceiveNormalIM(object sender, ReceiveNormalIMQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "ReceiveNormalIM", "QQ", friend.QQ, "NickName", friend.NickName, "Message", e.Message);
        }

        void sdk_ReceiveClusterIM(object sender, ReceiveClusterIMQQEventArgs e)
        {
            var Cluster = e.Cluster;
            var ClusterMember = e.ClusterMember;
            e.Cancel = SendToWeb("Event", "ReceiveClusterIM", "ExternalId", Cluster.ExternalId, "Name", Cluster.Name, "QQ", ClusterMember.QQ, "Nick", ClusterMember.Nick, "Card", ClusterMember.Card, "Message", e.Message);
        }

        void sdk_QQLevel(object sender, QQLevelQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "QQLevel", "VIP", e.VIP, "Level", e.Level, "ActiveDays", e.ActiveDays, "UpgradeDays", e.UpgradeDays);
        }

        void sdk_MemberExitCluster(object sender, MemberExitClusterQQEventArgs e)
        {
            if (e.ClusterMemberAdmin != null)
                e.Cancel = SendToWeb("Event", "MemberExitCluster", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMember.QQ, "NickName", e.ClusterMember.Nick, "Card", e.ClusterMember.Card, "AdminQQ", e.ClusterMemberAdmin.QQ, "AdminNickName", e.ClusterMemberAdmin.Nick, "AdminCard", e.ClusterMemberAdmin.Card);
            else
                e.Cancel = SendToWeb("Event", "MemberExitCluster", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMember.QQ, "NickName", e.ClusterMember.Nick, "Card", e.ClusterMember.Card);
        }

        void sdk_LostConnection(object sender, LostConnectionQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "LostConnection", "QQ", this.User.QQ, "Message", e.Message);
        }

        void sdk_LoginSuccessed(object sender, LoginSuccessedQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "LoginSuccessed", "QQ", this.User.QQ);
        }

        void sdk_Licence(object sender, LicenceQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "Licence", "t", e.ExpTime);
        }

        void sdk_KeepAlive(object sender, KeepAliveQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "KeepAlive", "AliveCount", e.AliveCount, "ServerTime", e.ServerTime, "Cookies", this.User.Cookies.GetCookieHeader(new Uri("http://qq.com")), "BKN", this.User.Bkn);
        }

        void sdk_ClusterAdminChanged(object sender, ClusterAdminChangedQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "ClusterAdminChanged", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMember.QQ, "NickName", e.ClusterMember.Nick, "Card", e.ClusterMember.Card, "IsAdmin", e.ClusterMember.IsAdmin());
        }

        void sdk_CardChanged(object sender, CardChangedQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "CardChanged", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMember.QQ, "NickName", e.ClusterMember.Nick, "Card", e.ClusterMember.Card);
        }

        void sdk_AddToClusterNeedAuth(object sender, AddToClusterNeedAuthQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "AddToClusterNeedAuth", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.QQ, "Message", e.Message);
        }

        void sdk_AddMeFriendNeedAuth(object sender, AddMeFriendNeedAuthQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "AddMeFriendNeedAuth", "QQ", e.QQ, "NickName", friend.NickName, "Message", e.Message);
        }

        void sdk_AddMeFriend(object sender, AddMeFriendQQEventArgs e)
        {
            var friend = this.GetFriend(e.QQ);
            e.Cancel = SendToWeb("Event", "AddMeFriend", "QQ", e.QQ, "NickName", friend.NickName);
        }

        void sdk_AddedToClusterInvite(object sender, AddedToClusterInviteQQEventArgs e)
        {
            e.Cancel = SendToWeb("Event", "AddedToClusterInvite", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMemberAdmin.QQ, "Nick", e.ClusterMemberAdmin.Nick);
        }

        void sdk_AddedToCluster(object sender, AddedToClusterQQEventArgs e)
        {
            var f = this.GetFriend(e.ClusterMember.QQ);
            e.Cancel = SendToWeb("Event", "AddedToCluster", "ExternalId", e.Cluster.ExternalId, "Name", e.Cluster.Name, "QQ", e.ClusterMember.QQ, "Nick", e.ClusterMember.Nick, "Gender", f != null ? f.Gender.ToString() : "", "QQAge", f != null ? f.QQAge.ToString() : "", "Card", e.ClusterMember.Card, "AdminQQ", e.ClusterMemberAdmin.QQ, "AdminNick", e.ClusterMemberAdmin.Nick, "AdminCard", e.ClusterMemberAdmin.Card);
        }

        public override bool Stop()
        {
            StopGetWeb();
            StopWebServer();
            return base.Stop();
        }

        /// <summary>
        /// 发送到web接口，并处理返回指令
        /// </summary>
        /// <param name="args"></param>
        bool SendToWeb(params object[] args)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(config.Url) && config.Url.Length > 10)
                {
                    string[] urls = config.Url.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string url in urls)
                    {
                        if (SendToWebUrl(url, args))//如果处理了
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                OnLog("发送web接口异常：{0}\n{1}", ex.Message, ex.StackTrace);
            }

            return false;
        }

        bool SendToWebUrl(string url, params object[] args)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(url) && url.StartsWith("http", StringComparison.CurrentCultureIgnoreCase) && url.Length > 10)
                {
                    Encoding encoding = Encoding.GetEncoding(config.Encode);
                    OnLog("发送给接口：{0}", string.Join(",", args));
                    string result = Post(url, encoding, args);
                    OnLog("收到返回：{0}", result);
                    ExecuteCommand(result);
                    if (!string.IsNullOrWhiteSpace(result) && (result.Contains("<&&>") || result.Contains("<&>")))
                        return config.Cancel;
                }
                else
                    OnLog("【Web接口插件】中接口地址设置错误，无法发送到接口，请正确设置接口地址");
            }
            catch (Exception ex)
            {
                OnLog("发送web接口异常：{0}", ex.Message, ex.StackTrace);
            }

            return false;
        }

        /// <summary>
        /// 提交给web
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        string Post(string url, Encoding encoding, params object[] args)
        {
            string result;
            try
            {
                StringBuilder sb = new StringBuilder();
                if (string.IsNullOrWhiteSpace(config.CustomData))
                    sb.AppendFormat("RobotQQ={0}&Key={1}", this.User.QQ, config.Key);
                else
                    sb.AppendFormat("{2}&RobotQQ={0}&Key={1}", this.User.QQ, config.Key, config.CustomData);

                for (int i = 0; i < args.Length; i = i + 2)
                {
                    if (args[i + 1] != null)
                        sb.AppendFormat("&{0}={1}", args[i], HttpUtility.UrlEncode(args[i + 1].ToString(), encoding));
                    else
                        sb.AppendFormat("&{0}=", args[i]);
                }
                System.Net.ServicePointManager.DefaultConnectionLimit = 20;
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.ContentType = "application/x-www-form-urlencoded;charset=" + encoding.BodyName;
                request.Method = "POST";
                byte[] B = Encoding.ASCII.GetBytes(sb.ToString());
                request.ContentLength = B.Length;
                using (System.IO.Stream SW = request.GetRequestStream())
                {
                    SW.Write(B, 0, B.Length);
                    SW.Close();
                }
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream(), encoding);
                result = reader.ReadToEnd();

                request.Abort();
                if (reader != null)
                    reader.Dispose();
                if (response != null)
                    response.Close();
            }
            catch (Exception ex)
            {
                OnLog("发送到web接口异常【请检查web接口】：{0}\n{1}", ex.Message, ex.StackTrace);
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// 执行收到的指令，支持多个指令
        /// </summary>
        /// <param name="result"></param>
        dynamic ExecuteCommand(string result)
        {
            var ret = new { desc = "ok", result = new List<object>() };
            try
            {
                if (!string.IsNullOrWhiteSpace(result))
                {
                    result.Trim().Split(new string[] { "<&&>" }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(p1 =>
                    {
                        string[] p = p1.Trim().Split(new string[] { "<&>" }, StringSplitOptions.None);
                        if (p != null && p.Length > 0)
                        {
                            switch (p[0])
                            {
                                case "GetWebData":
                                    {
                                        string cookie = this.User.Cookies.GetCookieHeader(new Uri("http://qun.qq.com"));
                                        ret.result.Add(new { Cookie = cookie, Bkn = this.User.Bkn, Gtk = this.User.Gtk });
                                    }
                                    break;
                                case "AddFriend":
                                    {
                                        var tmp = this.AddFriend(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "AgreeAddedToClusterInvite":
                                    {
                                        var tmp = this.AgreeAddedToClusterInvite(uint.Parse(p[1]), bool.Parse(p[2]), p[3]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "AgreeFriendInvite":
                                    {
                                        this.AgreeFriendInvite(uint.Parse(p[1]), byte.Parse(p[2]), p[3]);
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "AgreeJoinCluster":
                                    {
                                        var tmp = this.AgreeJoinCluster(uint.Parse(p[1]), uint.Parse(p[2]), bool.Parse(p[3]), p[4]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "ChangeQQStatus":
                                    {
                                        var tmp = this.ChangeQQStatus((QQStatus)Enum.Parse(typeof(QQStatus), p[1]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "ExitCluster":
                                    {
                                        var tmp = this.ExitCluster(uint.Parse(p[1]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "GetCluster":
                                    {
                                        var tmp = this.GetCluster(uint.Parse(p[1]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "GetClusterMemberInfo":
                                    {
                                        var tmp = this.GetClusterMemberInfo(uint.Parse(p[1]), uint.Parse(p[2]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "GetFriend":
                                    {
                                        var tmp = this.GetFriend(uint.Parse(p[1]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "JoinCluster":
                                    {
                                        var tmp = this.JoinCluster(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "Logout":
                                    {
                                        this.Logout();
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "ModifyMemberCard":
                                    {
                                        this.ModifyMemberCard(uint.Parse(p[1]), uint.Parse(p[2]), p[3]);
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "ModifySignature":
                                    {
                                        this.ModifySignature(p[1]);
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "RemoveMember":
                                    {
                                        var tmp = this.RemoveMember(uint.Parse(p[1]), uint.Parse(p[2]));
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendClusterMessage":
                                    if (uint.Parse(p[1]) == 1)
                                    {
                                        this.User.Clusters.ForEach(c =>
                                        {
                                            this.SendClusterMessage(c.ExternalId, p[2]);
                                        }
                                        );
                                        ret.result.Add("ok");
                                    }
                                    else if(p.Length == 3)
                                    {
                                        var tmp = this.SendClusterMessage(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    else if (p.Length > 3)
                                    {
                                        var tmp = this.SendClusterMessage(uint.Parse(p[1]), uint.Parse(p[2]), p[3]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendMessage":
                                    {
                                        var tmp = this.SendMessage(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendSubjectMessage":
                                    {
                                        var tmp = this.SendSubjectMessage(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendOfflineFile":
                                    {
                                        var tmp = this.SendOfflineFile(uint.Parse(p[1]), p[2]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendTempMessage":
                                    {
                                        var tmp = this.SendTempMessage(uint.Parse(p[1]), uint.Parse(p[2]), p[3]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendVerifyCode":
                                    {
                                        var tmp = this.SendVerifyCode(p[1]);
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "SendVibration":
                                    {
                                        this.SendVibration(uint.Parse(p[1]));
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "Sleep":
                                    {
                                        Thread.Sleep(int.Parse(p[1]));
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "GetClusters":
                                    {
                                        var tmp = this.User.Clusters;
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "GetFriends":
                                    {
                                        var tmp = this.User.Friends;
                                        ret.result.Add(tmp);
                                    }
                                    break;
                                case "GetExtcredits":
                                    {
                                        var c = Dapper.CocoDb.GetExtcredits(uint.Parse(p[1]), uint.Parse(p[2]));//查询群里成员积分
                                        SendToWeb("Event", "GetExtcredits", "Extcredits0", c.Extcredits0, "Extcredits1", c.Extcredits1, "Extcredits2", c.Extcredits2, "Extcredits3", c.Extcredits3, "Extcredits4", c.Extcredits4, "Extcredits5", c.Extcredits5, "Extcredits6", c.Extcredits6, "Extcredits7", c.Extcredits7, "Extcredits8", c.Extcredits8, "Extcredits9", c.Extcredits9);
                                        ret.result.Add(c);
                                    }

                                    break;
                                case "UpdateExtcredits":
                                    {
                                        Dapper.CocoDb.UpdateExtcredits(long.Parse(p[1]), long.Parse(p[2]), long.Parse(p[3]), long.Parse(p[4]));
                                        ret.result.Add("ok");
                                    }
                                    break;
                                case "Silenced":
                                    this.Silenced(uint.Parse(p[1]), uint.Parse(p[2]), uint.Parse(p[3]));
                                    break;
                                case "SilencedALL":
                                    this.SilencedALL(uint.Parse(p[1]), bool.Parse(p[2]));
                                    break;
                                //case "GetUser":
                                //    {
                                //        var tmp = this.User;
                                //        ret.result.Add(tmp);
                                //    }
                                //    break;
                                //case "Init":
                                //    InitEntities();
                                //    break;
                                default:
                                    OnLog("Web接口无法识别指令：{0}", p[0]);
                                    break;
                            }
                        }
                    }
                    );
                }
            }
            catch (Exception ex)
            {
                OnLog("Web接口执行指令错误【这不是机器人的故障，请检查接口返回值】：{0}\n{1}", ex.Message, ex.StackTrace);
                ret = new { desc = "err", result = new List<object>() };
                ret.result.Add(ex);
            }


            return ret;
        }

        Timer timerGetWeb;
        void StopGetWeb()
        {
            if (timerGetWeb != null)
                timerGetWeb.Dispose();
        }
        void StartGetWeb()
        {
            try
            {
                StopGetWeb();
                if (string.IsNullOrWhiteSpace(config.Url) || string.IsNullOrWhiteSpace(config.Encode) || string.IsNullOrWhiteSpace(config.Key) || config.Url.Length < 10)
                    return;
                Encoding encoding = Encoding.GetEncoding(config.Encode);

                string[] urls = config.Url.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (string.IsNullOrWhiteSpace(config.CustomData))
                {
                    for (int i = 0; i < urls.Length; i++)
                    {
                        urls[i] = string.Format("{0}{1}RobotQQ={2}&Key={3}", urls[i], urls[i].Contains('?') ? "&" : "?", this.User.QQ, config.Key);
                    }
                }
                else
                {
                    for (int i = 0; i < urls.Length; i++)
                    {
                        urls[i] = string.Format("{0}{1}{2}&RobotQQ={3}&Key={4}", urls[i], urls[i].Contains('?') ? "&" : "?", config.CustomData, this.User.QQ, config.Key);
                    }
                }

                timerGetWeb = new Timer(new TimerCallback((o) =>
                {
                    try
                    {
                        if (this.User.LoginStatus != LoginStatus.Login)
                            return;

                        //OnLog("{0} 读取接口数据\n", DateTime.Now);
                        Parallel.ForEach(urls, (url) =>
                        {
                            try
                            {
                                string result = encoding.GetString(new HttpWebClient().DownloadData(url));
                                if (!string.IsNullOrWhiteSpace(result))
                                {
                                    OnLog("读取到：{0}", result);
                                    ExecuteCommand(result);
                                }
                            }
                            catch (Exception ex1)
                            {
                                OnLog("web接口请求{2}失败：{0}\n{1}", ex1.Message, ex1.StackTrace, url);
                            }
                        }
                        );
                    }
                    catch (Exception ex)
                    {
                        OnLog("web接口请求失败：{0}\n{1}", ex.Message, ex.StackTrace);
                    }
                }), null, config.Sleep * 1000, config.Sleep * 1000);
            }
            catch (Exception ex)
            {
                OnLog("Web接口启动故障：{0}\n{1}", ex.Message, ex.StackTrace);
            }
        }

        HttpListener listener = null;
        void StartWebServer()
        {
            try
            {
                StopWebServer();
                if (config.Port <= 0)
                    return;
                if (!HttpListener.IsSupported)
                {
                    OnLog("当前系统不支持HttpListener");
                    return;
                }
                listener = new HttpListener();
                listener.Prefixes.Add(string.Format("http://+:{0}/", config.Port));
                listener.Start();
                Task.Factory.StartNew(() =>
                {
                    while (listener != null && config.Port > 0)
                    {
                        try
                        {
                            HttpListenerContext context = listener.GetContext();
                            Encoding encoding = Encoding.GetEncoding(config.Encode);
                            var result = new { desc = "err", result = new List<object>() };
                            // 取得请求对象  
                            HttpListenerRequest request = context.Request;
                            string key = request.QueryString["key"];
                            if (!string.IsNullOrWhiteSpace(key) && key.Equals(config.Key))
                            {
                                string a = request.QueryString["a"];
                                if (string.IsNullOrWhiteSpace(a))
                                {
                                    using (var read = new StreamReader(request.InputStream))
                                    {
                                        a = read.ReadToEnd();
                                        a = a.Substring(2);
                                    }
                                }
                                a = HttpUtility.UrlDecode(a, encoding);
                                OnLog("本地监听接收：{0}", a);
                                result = ExecuteCommand(a);
                            }
                            //获取回应对象  
                            HttpListenerResponse response = context.Response;
                            var ret = JSON.Serialize(result);
                            OnLog("本地监听返回：{0}", ret);
                            response.ContentLength64 = encoding.GetByteCount(ret);
                            response.ContentType = "text/html; charset=" + encoding.BodyName;//设置输出类型  
                            using (StreamWriter writer = new System.IO.StreamWriter(response.OutputStream))
                            {
                                writer.Write(ret);
                                writer.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            OnLog("GetContext异常 {0}\n{1}", ex.Message, ex.StackTrace);
                        }
                    }
                }
                );
            }
            catch (Exception ex)
            {
                OnLog("本地监听启动失败：{0}\n{1}", ex.Message, ex.StackTrace);
            }
        }

        void StopWebServer()
        {
            if (listener != null)
                listener.Abort();

            listener = null;
        }
    }
}
