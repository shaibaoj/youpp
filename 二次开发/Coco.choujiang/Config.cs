using Coco.Framework.SDK;
using Coco.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coco.choujiang
{
    public class Config : PluginConfig
    {
        /// <summary>
        /// 开关
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 群号
        /// </summary>
        public List<uint> ExternalIds { get; set; }
        /// <summary>
        /// 奖项
        /// </summary>
        public List<string> Items { get; set; }

        /// <summary>
        /// 消耗积分类型
        /// </summary>
        public int PointType { get; set; }
        /// <summary>
        /// 消耗积分数量
        /// </summary>
        public long Point { get; set; }


        public string 抽奖指令 { get; set; }
        public string 抽奖结束 { get; set; }
        public string 积分不足 { get; set; }
        public string 中奖回复 { get; set; }
        public string 未中奖回复 { get; set; }

        public Config()
        {
            this.Status = false;
            this.Point = 100;
            this.PointType = 2;
            this.抽奖指令 = "抽奖";
            this.抽奖结束 = @"奖品已领完。敬请关注下次抽奖";
            this.积分不足 = @"积分不足，积分可通过手机加我好友后，“QQ转账”给我充值。";
            this.中奖回复 = @"恭喜您中奖，奖品已私聊发给您，同时发送到您的QQ邮箱，请查收！本次扣除积分[扣除]";
            this.未中奖回复 = @"感谢您的支持，本次差一点中奖，再接再厉！本次扣除积分[扣除]";
            this.Items = @"#
测试奖品自己改
#
美团电子消费券xxxxx
月卡xxxxx
测试奖品自己改
#
测试奖品自己改".Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            this.ExternalIds = Util.ToUintList("1");
        }
    }
}
