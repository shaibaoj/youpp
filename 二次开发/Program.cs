using Coco.Framework;
using Coco.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coco
{
    class Program
    {
        static QQClient client;
        static void Main(string[] args)
        {
#if DEBUG
            uint qq = 976811781u;
            string pass = Console.ReadLine(); 
#else
            Console.Write("请输入QQ：");
            uint qq = uint.Parse(Console.ReadLine());
            Console.Write("请输入密码：");
            string pass = Console.ReadLine(); 
#endif

            client = new QQClient(qq, pass);
            client.User.IsUdp = true;
            client.LoginStatusChanged += client_LoginStatusChanged;
            client.ReceiveClusterIM += client_ReceiveClusterIM;
            client.ReceiveNormalIM += client_ReceiveNormalIM;
            client.AddedToCluster += client_AddedToCluster;
            client.LoginSuccessed += client_LoginSuccessed;
            client.CardChanged += client_CardChanged;
            client.ClusterAdminChanged += client_ClusterAdminChanged;
            client.AddToClusterNeedAuth += client_AddToClusterNeedAuth;
            client.AddedToClusterInvite += client_AddedToClusterInvite;
            client.Login();

            var input = Console.ReadLine();
            while (client.User.LoginStatus == Coco.Framework.Entities.LoginStatus.NeedVerifyCode)
            {
                client.SendVerifyCode(input);
                input = Console.ReadLine();
            }

            client.Logout();
        }

        static void client_AddedToClusterInvite(object sender, Framework.SDK.AddedToClusterInviteQQEventArgs e)
        {
            if (e.ClusterMember.QQ == client.User.QQ)//邀请机器人
            {
                Console.WriteLine("机器人被{0}邀请加入{1}", e.ClusterMemberAdmin, e.Cluster);
                if (DateTime.Now.Minute % 2 == 0)
                    client.AgreeAddedToClusterInvite(e.Cluster.ExternalId, false, "测试");
                else
                    client.AgreeAddedToClusterInvite(e.Cluster.ExternalId);

            }
            else
            {
                Console.WriteLine("{2}被{0}邀请加入{1}", e.ClusterMemberAdmin, e.Cluster, e.ClusterMember);

                if (DateTime.Now.Minute % 2 == 0)
                    client.AgreeJoinCluster(e.Cluster.ExternalId, e.ClusterMember.QQ, false, "测试");
                else
                    client.AgreeJoinCluster(e.Cluster.ExternalId, e.ClusterMember.QQ);
            }
        }

        static void client_AddToClusterNeedAuth(object sender, Framework.SDK.AddToClusterNeedAuthQQEventArgs e)
        {
            if (e.Message == "1")
                client.AgreeJoinCluster(e.Cluster.ExternalId, e.QQ);
            else
                client.AgreeJoinCluster(e.Cluster.ExternalId, e.QQ, false, e.Message);
        }

        static void client_ClusterAdminChanged(object sender, Framework.SDK.ClusterAdminChangedQQEventArgs e)
        {
            Console.WriteLine("{0}/{1}/{2}", e.Cluster, e.ClusterMember, e.ClusterMember.IsAdmin());
        }

        static void client_CardChanged(object sender, Framework.SDK.CardChangedQQEventArgs e)
        {
            Console.WriteLine("{0}/{1}/{2}/{3}/{4}", e.Cluster, e.ClusterMember, e.IsRobot, e.ClusterMember.OldCard, e.ClusterMember.Card);
        }

        static void client_LoginSuccessed(object sender, Framework.SDK.LoginSuccessedQQEventArgs e)
        {
            Console.WriteLine("欢迎您：{0}", client.User.NickName);
        }

        static void client_AddedToCluster(object sender, Framework.SDK.AddedToClusterQQEventArgs e)
        {
        }

        static void client_ReceiveNormalIM(object sender, Framework.SDK.ReceiveNormalIMQQEventArgs e)
        {
            Console.WriteLine("{0}/{1}", e.QQ, e.Message);

            client.DownloadQQImages(e.QQ, e.Message);
            client.DownloadQQAudios(e.QQ, e.Message);


            client.SendMessage(e.QQ, e.Message);
        }

        static void client_ReceiveClusterIM(object sender, Framework.SDK.ReceiveClusterIMQQEventArgs e)
        {
            Console.WriteLine("{0}/{1}/{2}", e.Cluster, e.ClusterMember, e.Message);

            if (e.ClusterMember.QQ == client.User.QQ)
                return;

            client.DownloadClusterImages(e.Cluster.ExternalId, e.Message);
            client.DownloadClusterAudios(e.Cluster.ExternalId, e.Message);
            var tmp = e.Message.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (tmp[0] == "踢")
            {
              var result =   client.RemoveMember(e.Cluster.ExternalId, uint.Parse(tmp[1]), false, false);
              Console.WriteLine(result);
            }
            else if (tmp[0] == "DeleteFriend")
            {
                var result = client.DeleteFriend(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "ExitCluster")
            {
                var result = client.ExitCluster(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "SendVibration")
            {
                var result = client.SendVibration(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "JoinCluster")
            {
                var result = client.JoinCluster(uint.Parse(tmp[1]), tmp[2]);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "SendAudio")
            {
                var result = client.SendAudio(uint.Parse(tmp[1]), tmp[2]);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "AddFriend")
            {
                var result = client.AddFriend(uint.Parse(tmp[1]), tmp[2]);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "SilencedALL")
            {
                var result = client.SilencedALL(uint.Parse(tmp[1]), bool.Parse(tmp[2]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "SendOfflineFile")
            {
                var result = client.SendOfflineFile(uint.Parse(tmp[1]), tmp[2]);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "ModifyRemark")
            {
                var result = client.ModifyRemark(uint.Parse(tmp[1]), tmp[2]);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "Silenced")
            {
                var result = client.Silenced(uint.Parse(tmp[1]), uint.Parse(tmp[2]), uint.Parse(tmp[3]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "GetQQInfo")
            {
                var result = client.GetQQInfo(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "SearchGroupMembers")
            {
                var result = client.SearchGroupMembers(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "GetGroupInfo")
            {
                var result = client.GetGroupInfo(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "GetQQLevel")
            {
                var result = client.GetQQLevel(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "GetGroupInfoEn")
            {
                var result = client.GetGroupInfoEn(uint.Parse(tmp[1]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "邀请")
            {
                var result = client.AddMember(uint.Parse(tmp[1]), uint.Parse(tmp[2]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "GetClusterMemberInfo")
            {
                var result = client.GetClusterMemberInfo(uint.Parse(tmp[1]), uint.Parse(tmp[2]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "好友列表")
            {
                client.User.Friends.ForEach(f => Console.WriteLine("{0}/{1}/{2}/{3}", f.GroupId, f.QQ, f.NickName, f.Remark));
            }
            else if (tmp[0] == "群列表")
            {
                client.User.Clusters.ForEach(c => Console.WriteLine("{0}/{1}/{2}/{3}", c.ExternalId, c.Name, c.GroupId, c.Creator));
            }
            else if (tmp[0] == "群成员")
            {
                var c = client.User.Clusters.FirstOrDefault(t => t.ExternalId == uint.Parse(tmp[1]));
                if (c == null)
                {
                    Console.WriteLine("没找到");
                    return;
                }

                c.members.ForEach(m => Console.WriteLine("{0}/{1}/{2}/{3}", m.QQ, m.Nick, m.Card, m.QAge));
            }
            else if (tmp[0] == "改名")
            {
                var result = client.ModifyMemberCard(e.Cluster.ExternalId, uint.Parse(tmp[1]), tmp[2], bool.Parse(tmp[3]));
                Console.WriteLine(result);
            }
            else if (tmp[0] == "设置管理员")
            {
                var result = client.SetGroupAdmin(e.Cluster.ExternalId, new uint[1] { uint.Parse(tmp[1]) }.ToList(), true);
                Console.WriteLine(result);
            }
            else if (tmp[0] == "取消管理员")
            {
                var result = client.SetGroupAdmin(e.Cluster.ExternalId, new uint[1] { uint.Parse(tmp[1]) }.ToList(), false);
                Console.WriteLine(result);
            }
            //else if (tmp[0] == "说说")
            //{
            //    var result = client.ShuoShuo(tmp[1]);
            //    Console.WriteLine(result);
            //}
            else if (tmp[0] == "学我")
                client.SendClusterMessage(e.Cluster, e.ClusterMember, e.Message);
        }

        static void client_LoginStatusChanged(object sender, Framework.SDK.LoginStatusChangedQQEventArgs e)
        {
            Console.WriteLine("{0}/{1}", e.LoginStatus, e.Other);
        }
    }
}
