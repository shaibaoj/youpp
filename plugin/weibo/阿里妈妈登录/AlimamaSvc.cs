using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace 阿里妈妈登录
{
	public class AlimamaSvc
	{
		public AlimamaSvc()
		{
		}

		public static bool checkAlimamaLogin()
		{
            string out_log = "";
            return AlimamaSvc.checkAlimamaLogin(GetCookie.GetCookieString("http://weibo.com"), out out_log);
		}

		public static bool checkAlimamaLogin(string cookie,out string out_log)
		{
            out_log = "";
			bool flag;
			bool flag1;
			try
			{
                string str = "http://m.weibo.cn/msg/index?format=cards";
                str = "http://weibo.cn/msg/chat/send?rl=1";
				WebClient webClient = new WebClient();
				webClient.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
				webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                webClient.Headers.Add("Referer", "http://m.weibo.cn/");
				webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
				webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
				webClient.Headers.Add("Cookie", cookie);
				string str1 = "";
				byte[] numArray = webClient.DownloadData(str);
				str1 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : CUtil.parseHtmlGzip(numArray, Encoding.UTF8));
                out_log = str1;
                if (str1.Contains("attachment"))
				{
					flag1 = true;
				}
				else
				{
                    flag1 = false;
                    //flag1 = (!str1.Contains("status") ? true : !str1.Contains("wait"));
				}
                flag = (flag1 ? true : false);
			}
			catch
			{
				flag = false;
			}
			return flag;
		}
	}
}