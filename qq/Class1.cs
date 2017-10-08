using Coco.Framework.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace qq
{
    public class Class1 : Plugin
    {
        Form1 form1 = null;

        public Class1()
        {
            this.PluginName = "好品推群采集";
            this.Description = "用于采集群发消息";
            this.Author = "作者：好品推平台";
        }

        public override bool Start()
        {
            this.ReceiveClusterIM += Class1_ReceiveClusterIM;
            this.ReceiveNormalIM += Class1_ReceiveNormalIM;

            if (form1 == null)
            {
                Thread.Sleep(1000);
                form1 = new Form1(this);
            }
            form1.ShowDialog();

            //return base.ShowForm();

            return base.Start();
        }

        private void Class1_ReceiveNormalIM(object sender, ReceiveNormalIMQQEventArgs e)
        {
            if (e.Message == "时间")
            {
                this.SendMessage(e.QQ, "现在时间是：" + DateTime.Now.ToString());
                e.Cancel = true;//这里需要设置，放置后面的插件重复执行。表示已经处理完成了
                return;
            }
        }

        private void Class1_ReceiveClusterIM(object sender, ReceiveClusterIMQQEventArgs e)
        {
            //MessageBox.Show("---:" + e.Message);
            LogUtil.log_call(form1, "::::"+e.Message);
            if (e.Message == "时间")
            {
                this.SendClusterMessage(e.Cluster, e.ClusterMember, "现在时间是：" + DateTime.Now.ToString());
                e.Cancel = true;//这里需要设置，放置后面的插件重复执行。表示已经处理完成了
                return;
            }
        }

        public override bool ShowForm()
        {
            if (form1 == null)
            {
                form1 = new Form1(this);
            }
            form1.ShowDialog();



            return base.ShowForm();
        }


    }
}
