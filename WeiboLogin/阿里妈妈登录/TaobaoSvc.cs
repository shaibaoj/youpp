using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace 阿里妈妈登录
{
	public class TaobaoSvc
	{
		public TaobaoSvc()
		{
		}

		public static bool checkTaobaoLogin(string cookie)
		{
			bool flag;
			string str = "";
			Directory.GetCurrentDirectory();
			string str1 = "https://buyertrade.taobao.com/trade/itemlist/list_bought_items.htm";
			WebClient webClient = new WebClient();
			webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
			webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
			webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
			webClient.Headers.Add("Cookie", cookie);
			byte[] numArray = webClient.DownloadData(str1);
			if (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]))
			{
				str = Encoding.GetEncoding("GB2312").GetString(numArray);
				flag = false;
			}
			else
			{
				flag = (!CUtil.parseHtmlGzip(numArray, Encoding.GetEncoding("GB2312")).Contains("<title>已买到的宝贝</title>") ? false : true);
			}
			return flag;
		}
	}
}