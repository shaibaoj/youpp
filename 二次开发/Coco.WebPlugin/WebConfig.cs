using Coco.Framework.SDK;
using Coco.Framework.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Coco.WebPlugin
{
    public class WebConfig : PluginConfig
    {
        public string Url { get; set; }
        public string Encode { get; set; }
        public string Key { get; set; }
        public int Port { get; set; }
        public int Sleep { get; set; }
        public bool Cancel { get; set; }
        /// <summary>
        /// 自定义数据
        /// </summary>
        public string CustomData { get; set; }

        public WebConfig()
        {
            this.Url = "http://";
            this.Sleep = 10;
            this.Cancel = true;
        }
    }
}
