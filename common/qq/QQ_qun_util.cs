using System;
using System.Collections;
using System.Net;
using System.Text;

public class QQ_qun_util
{
    public static ArrayList getQunList(string cookie)
    {
        string str = smethod_2(cookie);
        string address = "http://qun.qq.com/cgi-bin/qun_mgr/get_group_list";
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("Origin", "http://qun.qq.com");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://qun.qq.com/member.html");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", cookie);
        string str3 = "";
        byte[] buffer = client.UploadData(address, "POST", Encoding.UTF8.GetBytes("bkn=" + str));
        string str4 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str4))
        {
            str3 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str3 = Encoding.UTF8.GetString(buffer);
        }
        ArrayList list = new ArrayList();
        for (int i = 0; (i = str3.IndexOf("\"gc\":", i)) != -1; i++)
        {
            QQqun class2 = new QQqun();
            class2.num = StringUtil.subString(str3, i, "\"gc\":", ",");
            class2.name = StringUtil.subString(str3, i, "\"gn\":\"", "\",\"").Replace("&nbsp;", " ");
            class2.owner = StringUtil.subString(str3, i, "\"owner\":", "}");
            list.Add(class2);
        }
        return list;
    }

    public static ArrayList query_qq_item(string qq, string groupid, string cookie)
    {
        string str = smethod_2(cookie);
        string str2 = "http://qun.qzone.qq.com/cgi-bin/get_group_member?callbackFun=_GroupMember&uin={qq}&groupid={groupid}&neednum=1&r=0.8628084792289883&g_tk={gtk}&ua=Mozilla%2F5.0%20(Windows%20NT%206.1%3B%20WOW64)%20AppleWebKit%2F537.36%20(KHTML%2C%20like%20Gecko)%20Chrome%2F31.0.1650.63%20Safari%2F537.36";
        string address = str2.Replace("{qq}", qq).Replace("{groupid}", groupid).Replace("{gtk}", str + "");
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "*/*");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Referer", "http://qun.qzone.qq.com/group");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", cookie);
        string str4 = "";
        byte[] buffer = client.DownloadData(address);
        string str5 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str5))
        {
            str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str4 = Encoding.UTF8.GetString(buffer);
        }
        ArrayList list = new ArrayList();
        for (int i = 0; (i = str4.IndexOf("\"iscreator\":", i)) != -1; i++)
        {
            QQItem qq_item = new QQItem();
            qq_item.iscreator = int.Parse(StringUtil.subString(str4, i, "\"iscreator\":", ","));
            qq_item.ismanager = int.Parse(StringUtil.subString(str4, i, "\"ismanager\":", ","));
            qq_item.nick = StringUtil.subString(str4, i, "\"nick\":\"", "\",\"").Trim();
            qq_item.uin = StringUtil.subString(str4, i, "\"uin\":", "}");
            qq_item.ingrpnum = 1;
            qq_item.string_2 = "0";
            list.Add(qq_item);
        }
        return list;
    }

    public static string smethod_2(string string_0)
    {
        string str = StringUtil.subString(string_0, 0, "skey=", ";");
        int num = 0x1505;
        for (int i = 0; i < str.Length; i++)
        {
            num += (num << 5) + char.Parse(str.Substring(i, 1));
        }
        int num3 = num & 0x7fffffff;
        return (num3 + "");
    }
}

