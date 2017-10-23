using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MoecraftFramework;

namespace MoecraftFramework
{
    public class MyPlugin :IMoePlugin
    {
        Guid gd = new Guid();
        #region 默认缺省值
        string EventType = "";
        int subType = 0;
        int sendTime = 0;
        int fromGroup = 0;
        int fromDiscuss = 0;
        int fromQQ = 0;
        string fromAnonymous = "";
        int beingOperateQQ = 0;
        string msg = "";
        int font = 0;
        string responseFlag = "";
        string file = "";
        #endregion
        public string main(string EventType, int subType, int sendTime, int fromGroup, int fromDiscuss, int fromQQ,
            string fromAnonymous, int beingOperateQQ, string msg, int font, string responseFlag, string file)
        {
             string prefix = gd.ToString().Substring(0,16);
             string rttext = prefix+CQ应用.事件预处理(EventType, subType, sendTime, fromGroup, fromDiscuss, fromQQ,
 fromAnonymous, beingOperateQQ, msg, font, responseFlag, file);
            rttext.Replace("%易语言%等于%",prefix+"等号");
            rttext.Replace("%易语言%大于%", prefix + "大于");
            rttext.Replace("%易语言%小于%", prefix + "小于");
            rttext.Replace("%易语言%且%", prefix + "且");
            return rttext;
        }
        public string test() { return ""; }
    }
}
