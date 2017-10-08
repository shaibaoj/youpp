using Dapper;
using Coco.Framework.SDK;
using Coco.Framework.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Coco.choujiang
{
    public class ChoujiangPlugin : Plugin
    {
        public ChoujiangPlugin()
        {
            this.PluginName = "抽奖";
            this.Description = "管理员指令：奖品统计 奖品名，成员默认指令：抽奖";
        }
        public override bool Start()
        {
            config = PluginConfig.FromFile<Config>();
            this.ReceiveClusterIM += Class1_ReceiveClusterIM;

            return base.Start();
        }

        static string log = Util.MapFile("抽奖记录.txt");
        static readonly object lockObj = new object();
        void Class1_ReceiveClusterIM(object sender, ReceiveClusterIMQQEventArgs e)
        {
            lock (lockObj)
            {
                if (Config.AdminQQs.Contains(e.ClusterMember.QQ) && e.Message.StartsWith("奖品统计".GetLang()))
                {
                    StringBuilder sb = new StringBuilder("统计如下：\r\n".GetLang());
                    sb.AppendFormat("抽奖总数：{0}\r\n".GetLang(), config.Items.Count);
                    var items = e.Message.Substring(4).Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    List<int> counts = new List<int>(items.Length);
                    for (int i = 0; i < items.Length; i++)
                    {
                        counts.Add(0);
                    }

                    config.Items.ForEach(t =>
                    {
                        for (int i = 0; i < items.Length; i++)
                        {
                            if (t.Contains(items[i]))
                            {
                                counts[i] += 1;
                            }
                        }
                    }
                    );

                    for (int i = 0; i < items.Length; i++)
                    {
                        sb.AppendFormat("{0} {1}个\r\n".GetLang(), items[i], counts[i]);
                    }

                    this.Reply(e, sb.ToString());
                    return;
                }
                if (!config.Status)
                    return;
                if (!config.ExternalIds.Contains(e.Cluster.ExternalId) && !config.ExternalIds.Contains(1))
                    return;

                if (e.Message == config.抽奖指令)
                {
                    if (config.Items.Count > 0)
                    {
                        var ex = CocoDb.GetExtcredits(e.Cluster.ExternalId, e.ClusterMember.QQ);
                        if (ex.Get(config.PointType) >= config.Point)
                        {
                            var item = config.Items[0].Trim();
                            config.Items.RemoveAt(0);
                            config.Save();

                            CocoDb.UpdateExtcredits(e.Cluster.ExternalId, e.ClusterMember.QQ, config.PointType, -1 * config.Point);

                            File.AppendAllText(log, DateTime.Now.ToString() + "," + e.Cluster.ExternalId + "," + e.ClusterMember.QQ + "," + item + "\r\n");
                            string result = "";
                            if (item == "#".GetLang())
                            {
                                result = config.未中奖回复;
                            }
                            else
                            {
                                result = config.中奖回复;

                                SendMail(e.ClusterMember.QQ + "@qq.com", item, item);
                                SendTempMessage(e.Cluster.ExternalId, e.ClusterMember.QQ, item);
                            }

                            result = result.Replace("[扣除]", config.Point + Config.ExtcreditsType[config.PointType]);

                            this.Reply(e, result);
                        }
                        else
                            this.Reply(e, config.积分不足);
                    }
                    else
                        this.Reply(e, config.抽奖结束);
                }
            }
        }

        public Config config { get; set; }
        public override bool ShowForm()
        {
            new Form1(this).ShowDialog();
            return true;
        }
    }
}
