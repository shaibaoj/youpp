using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jiankong.jk
{
    public partial class Form1 : Form
    {

        private string url = "https://h5api.m.taobao.com/h5/mtop.taobao.detail.getdetail/6.0/?jsv=2.4.8&appKey=12574478&t=&sign=&api=mtop.taobao.detail.getdetail&v=6.0&ttid=2016%40taobao_h5_2.0.0&isSec=0&ecode=0&AntiFlood=true&AntiCreep=true&H5Request=true&type=jsonp&dataType=jsonp&callback=&data=%7B%22exParams%22%3A%22%7B%5C%22ft%5C%22%3A%5C%22t%5C%22%2C%5C%22id%5C%22%3A%5C%22556044546022%5C%22%7D%22%2C%22itemNumId%22%3A%22556044546022%22%7D";
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init() {

            this.webBrowser1.Navigate(url, "_self", null, "Referer:https://www.taobao.com");

        
        }

    }
}
