using entity;
using LitJson;
using System;
using System.Collections;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

public class AlimamaUtil
{
    private static string string_0 = "http://pub.alimama.com/event/squareList.json?orderType=3&key=&toPage={pageno}&perPageSize=100&platformType=-1&catId=-1&commissionRangeType=-1&eventStatus=-1&highQuality=-1&promotionType=-1&_tb_token_={tbtoken}&_input_charset=utf-8";
    private static string string_1 = "http://pub.alimama.com/event/detail.json?eventId={brdgId}&_tb_token_={tbtoken}&_input_charset=utf-8";
    private static string string_2 = "http://temai.taobao.com/event/items.json?toPage={pageno}&perPageSize=2000&catId=&tagId=&pid={pid}&unid=&platformType=&isPreview=0&id={brdgId}&t={t}&pvid={pvid}";

    public static bool check_login()
    {
        return check_login(CookieUtil.get_cookie("http://www.alimama.com"));
    }

    public static bool check_login(string cookie)
    {
        try
        {
            string format = "http://pub.alimama.com/pubauc/searchAuctionList.json?q={0}&toPage=1&perPagesize=40&_input_charset=utf-8";

            format = "http://pub.alimama.com/common/getUnionPubContextInfo.json";
            string address = string.Format(format, "ABC");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string str3 = "";
            byte[] buffer = client.DownloadData(address);
            string str4 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str4))
            {
                str3 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str3 = Encoding.UTF8.GetString(buffer);
            }
            if (str3.Contains("\"message\":\"nologin\"") || (str3.Contains("status") && str3.Contains("wait")))
            {
                return false;
            }
            if (str3.Contains("\"nologin\"")||str3.Contains("\"noLogin\""))
            {
                return false;
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static void smethod_10(string string_3, string string_4, string string_5, string string_6, out string string_7)
    {
        try
        {
            string newValue = StringUtil.subString(string_6, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.jLGE9b");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_6);
            string address = "http://pub.alimama.com/common/site/generalize/guideAdd.json";
            string s = "name={name}&categoryId={categoryId}&account1={account}&t={timestamp}&pvid=&_tb_token_={token}";
            s = s.Replace("{name}", string_3).Replace("{categoryId}", string_4).Replace("{account}", string_5).Replace("{token}", newValue).Replace("{timestamp}", current_time() + "");
            byte[] buffer = client.UploadData(address, "POST", Encoding.UTF8.GetBytes(s));
            string str4 = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
            if (str4.Contains("\"message\":null") && str4.Contains("\"ok\":true"))
            {
                string_7 = "自动创建推广渠道成功！";
            }
            else
            {
                string str6 = StringUtil.subString(str4, 0, "\"message\":\"", "\"");
                string_7 = "自动创建推广渠道【失败】！失败原因：【" + str6 + "】";
            }
        }
        catch (Exception exception)
        {
            string_7 = "出错啦！！！" + exception.ToString();
        }
    }

    public static void smethod_11(string string_3, string string_4, string string_5, string string_6, out string string_7)
    {
        try
        {
            string newValue = StringUtil.subString(string_6, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.jLGE9b");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_6);
            string address = "http://pub.alimama.com/common/adzone/selfAdzoneCreate.json";
            string s = "promotion_type={promottype}%23{promottype}&gcid=8&siteid={siteid}&selectact=add&newadzonename={newadzonename}&channelIds=&t={timestamp}&pvid={pvid}&_tb_token_={token}";
            s = s.Replace("{promottype}", string_3).Replace("{siteid}", string_4).Replace("{newadzonename}", string_5).Replace("{token}", newValue).Replace("{timestamp}", current_time() + "").Replace("{pvid}", query_pvid(string_6));
            byte[] buffer = client.UploadData(address, "POST", Encoding.UTF8.GetBytes(s));
            string str4 = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
            if (str4.Contains("\"message\":null") && str4.Contains("\"ok\":true"))
            {
                string_7 = "自动创建推广位成功！";
            }
            else
            {
                string str6 = StringUtil.subString(str4, 0, "\"message\":\"", "\"");
                string_7 = "自动创建推广位【失败】！失败原因：【" + str6 + "】";
            }
        }
        catch (Exception exception)
        {
            string_7 = "出错啦！！！" + exception.ToString();
        }
    }

    public static ArrayList smethod_12(string string_3, string string_4, string string_5, string string_6, out string string_7)
    {
        try
        {
            string newValue = StringUtil.subString(string_6, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_6);
            string address = "http://pub.alimama.com/report/getTbkPaymentDetails.json?startTime={startTime}&endTime={endTime}&payStatus=&queryType=1&toPage={toPage}&perPageSize=20&total=&_tb_token_={_tb_token_}&_input_charset=utf-8";
            address = address.Replace("{startTime}", string_3).Replace("{endTime}", string_4).Replace("{toPage}", string_5).Replace("{_tb_token_}", newValue);
            string str3 = "";
            byte[] buffer = client.DownloadData(address);
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
            for (int i = str3.IndexOf("paymentList"); (i = smethod_13(str3, i)) != -1; i++)
            {
                PayOrder class2 = new PayOrder();
                class2.taobaoTradeParentId = StringUtil.subString(str3, i, "\"taobaoTradeParentId\":", ",");
                class2.num_iid = StringUtil.subString(str3, i, "\"auctionId\":", ",");
                class2.title = StringUtil.subString(str3, i, "\"auctionTitle\":\"", "\"");
                class2.shop_title = StringUtil.subString(str3, i, "\"exShopTitle\":\"", "\"");
                class2.payStatus = StringUtil.subString(str3, i, "\"payStatus\":", ",");
                class2.auctionNum = StringUtil.subString(str3, i, "\"auctionNum\":", ",");
                class2.totalAlipayFeeString = StringUtil.subString(str3, i, "\"totalAlipayFeeString\":\"", "\"");
                class2.feeString = StringUtil.subString(str3, i, "\"feeString\":\"", "\"");
                class2.discountAndSubsidyToString = StringUtil.subString(str3, i, "\"discountAndSubsidyToString\":\"", "\"");
                class2.createTime = StringUtil.subString(str3, i, "\"createTime\":\"", "\"");
                class2.earningTime = StringUtil.subString(str3, i, "\"earningTime\":", ",");
                if (class2.earningTime.Contains("null"))
                {
                    class2.earningTime = "";
                }
                else
                {
                    class2.earningTime = class2.earningTime.Replace("\"", "");
                }
                class2.terminalType = StringUtil.subString(str3, i, "\"terminalType\":\"", "\"");
                list.Add(class2);
            }
            string_7 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_7 = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    private static int smethod_13(string string_3, int int_0)
    {
        int index = string_3.IndexOf("{\"auctionUrl\"", int_0);
        if (index == -1)
        {
            index = string_3.IndexOf("{\"createTime\"", int_0);
        }
        return index;
    }

    public static StoreItem2 smethod_14(string string_3, string string_4, out string string_5)
    {
        try
        {
            string str = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_4);
            string str2 = "";
            byte[] buffer = client.DownloadData("http://pub.alimama.com/shopdetail/shopinfo.json?oriMemberId=" + string_3 + "&_tb_token_=" + str + "&_input_charset=utf-8");
            string str3 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str3))
            {
                str2 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str2 = Encoding.UTF8.GetString(buffer);
            }
            string str4 = StringUtil.subString(str2, 0, "\"shopTitle\":\"", "\"");
            string str5 = StringUtil.subString(str2, 0, "\"shopCatName\":\"", "\"");
            if ((str5 == null) || "".Equals(str5))
            {
                str5 = StringUtil.subString(str2, 0, "\"Ind\":[\"", "\"");
            }
            StoreItem2 class2 = new StoreItem2();
            class2.string_0 = str4;
            class2.string_1 = str5;
            class2.string_2 = StringUtil.subString(str2, 0, "\"extNick\":\"", "\"");
            string_5 = "";
            return class2;
        }
        catch (Exception exception)
        {
            string_5 = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static ArrayList smethod_15(string string_3, string string_4, out string string_5)
    {
        string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_4);
        string address = "http://pub.alimama.com/items/search.json?q={schKey}&auctionTag=&perPageSize=40&shopTag=&t={timestamp}&_tb_token_={tbToken}&pvid={pvid}";
        address = address.Replace("{schKey}", HttpUtility.UrlEncode(string_3)).Replace("{tbToken}", newValue).Replace("{timestamp}", current_time() + "").Replace("{pvid}", query_pvid(string_4));
        string str3 = "";
        byte[] buffer = client.DownloadData(address);
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
        if (str3.IndexOf("\"length\":0") != -1)
        {
            string_5 = "";
            return list;
        }
        string str5 = "\"" + StringUtil.subString(str3, 0, "\"pagelist\":[{\"", "\"") + "\"";
        int startIndex = 0;
        while (true)
        {
            startIndex = str3.IndexOf(str5, startIndex);
            if (startIndex == -1)
            {
                break;
            }
            GoodsItem5 class2 = new GoodsItem5();
            class2.user_num_id = StringUtil.subString(str3, startIndex, "\"userNumberId\":\"", "\"");
            if ("".Equals(class2.user_num_id))
            {
                class2.user_num_id = StringUtil.subString(str3, startIndex, "\"userNumberId\":", ",");
            }
            class2.title = GzipUtil.html_to_text(StringUtil.subString(str3, startIndex, "\"title\":\"", "\","));
            class2.pic_url = GzipUtil.html_to_text(StringUtil.subString(str3, startIndex, "\"pictUrl\":\"", "\","));
            class2.price = StringUtil.subString(str3, startIndex, "\"zkPrice\":", ",");
            class2.ori_price = StringUtil.subString(str3, startIndex, "\"reservePrice\":", ",");
            class2.user_type = StringUtil.subString(str3, startIndex, "\"userType\":", ",");
            class2.nick = StringUtil.subString(str3, startIndex, "\"nick\":\"", "\"");
            class2.num_iid = StringUtil.subString(str3, startIndex, "\"auctionId\":\"", "\"");
            if ("".Equals(class2.num_iid))
            {
                class2.num_iid = StringUtil.subString(str3, startIndex, "\"auctionId\":", ",");
            }
            class2.commissionRatePercent = StringUtil.subString(str3, startIndex, "\"commissionRatePercent\":", ",");
            try
            {
                class2.volume = int.Parse(StringUtil.subString(str3, startIndex, "\"totalNum\":", ","));
            }
            catch
            {
            }
            list.Add(class2);
            startIndex++;
        }
        if (list.Count == 0)
        {
            string_5 = str3;
        }
        else
        {
            string_5 = "";
        }
        return list;
    }

    public static ArrayList smethod_16(string string_3, string string_4, string string_5, int int_0, string string_6, out string string_7)
    {
        if (string_4.Equals(""))
        {
            string_4 = "_totalfee";
        }
        return smethod_19("&user_type=", string_3, string_4, string_5, int_0, string_6, out string_7);
    }

    public static ArrayList smethod_17(string string_3, string string_4, string string_5, int int_0, string string_6, out string string_7)
    {
        if (string_4.Equals(""))
        {
            string_4 = "_totalfee";
        }
        return smethod_19("&user_type=1", string_3, string_4, string_5, int_0, string_6, out string_7);
    }

    public static ArrayList smethod_18(string string_3, string string_4, string string_5, int int_0, string string_6, out string string_7)
    {
        if (string_4.Equals(""))
        {
            string_4 = "_totalfee";
        }
        return smethod_19("&user_type=0", string_3, string_4, string_5, int_0, string_6, out string_7);
    }

    public static ArrayList smethod_19(string string_3, string string_4, string string_5, string string_6, int int_0, string string_7, out string string_8)
    {
        string str = "http://pub.alimama.com/pubauc/searchAuctionList.json?q={pSchKey}&toPage={toPage}&sort={sort}{type}&perPagesize=40{schCond}";
        return smethod_21(str.Replace("{pSchKey}", HttpUtility.UrlEncode(string_4)).Replace("{sort}", string_5).Replace("{toPage}", int_0 + "").Replace("{type}", string_3).Replace("{schCond}", string_6), string_7, out string_8);
    }

    public static string smethod_2(string string_3, string string_4, string string_5, string string_6)
    {
        string newValue = StringUtil.subString(string_6, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/urltrans/urltrans.json?siteid={siteid}&adzoneid={adzoneid}&promotionURL={promotionURL}&t={t}&pvid={pvid}&_tb_token_={_tb_token_}&_input_charset=utf-8";
        string address = str2.Replace("{siteid}", string_3).Replace("{adzoneid}", string_4).Replace("{promotionURL}", HttpUtility.UrlEncode(string_5)).Replace("{t}", current_time() + "").Replace("{pvid}", query_pvid(string_6)).Replace("{_tb_token_}", newValue);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7900221.a214tr8.4.tS8Am0");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_6);
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
        return StringUtil.subString(str4, 0, "\"shortLinkUrl\":\"", "\"");
    }

    public static ArrayList smethod_20(string string_3, string string_4, out string string_5)
    {
        string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/pubauc/searchAuctionList.json?q=https%3A%2F%2Fitem.taobao.com%2Fitem.htm%3Fid%3D{itemid}&toPage=1&perPagesize=40&t={timestamp}&_tb_token_={tbToken}&_input_charset=utf-8";
        return smethod_21(str2.Replace("{itemid}", string_3).Replace("{tbToken}", newValue).Replace("{timestamp}", current_time() + ""), string_4, out string_5);
    }

    public static ArrayList smethod_21(string string_3, string string_4, out string string_5)
    {
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_4);
        string str = "";
        byte[] buffer = client.DownloadData(string_3);
        string str2 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str2))
        {
            str = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str = Encoding.UTF8.GetString(buffer);
        }
        ArrayList list = new ArrayList();
        if (str.IndexOf("\"length\":0") != -1)
        {
            string_5 = "";
            return list;
        }
        string str3 = "\"" + StringUtil.subString(str, 0, "\"pagelist\":[{\"", "\"") + "\"";
        int startIndex = 0;
        while (true)
        {
            startIndex = str.IndexOf(str3, startIndex);
            if (startIndex == -1)
            {
                break;
            }
            GoodsItem5 class2 = new GoodsItem5();
            class2.user_num_id = StringUtil.subString(str, startIndex, "\"userNumberId\":\"", "\"");
            if ("".Equals(class2.user_num_id))
            {
                class2.user_num_id = StringUtil.subString(str, startIndex, "\"userNumberId\":", ",");
            }
            class2.title = GzipUtil.html_to_text(StringUtil.subString(str, startIndex, "\"title\":\"", "\","));
            class2.pic_url = GzipUtil.html_to_text(StringUtil.subString(str, startIndex, "\"pictUrl\":\"", "\","));
            class2.price = StringUtil.subString(str, startIndex, "\"zkPrice\":", ",");
            class2.ori_price = StringUtil.subString(str, startIndex, "\"reservePrice\":", ",");
            class2.user_type = StringUtil.subString(str, startIndex, "\"userType\":", ",");
            class2.nick = StringUtil.subString(str, startIndex, "\"nick\":\"", "\"");
            class2.num_iid = StringUtil.subString(str, startIndex, "\"auctionId\":\"", "\"");
            if ("".Equals(class2.num_iid))
            {
                class2.num_iid = StringUtil.subString(str, startIndex, "\"auctionId\":", ",");
            }
            class2.commissionRatePercent = StringUtil.subString(str, startIndex, "\"commissionRatePercent\":", ",");
            try
            {
                class2.volume = int.Parse(StringUtil.subString(str, startIndex, "\"totalNum\":", ","));
            }
            catch
            {
            }
            list.Add(class2);
            startIndex++;
        }
        if (list.Count == 0)
        {
            string_5 = str;
        }
        else
        {
            string_5 = "";
        }
        return list;
    }

    public static ArrayList smethod_22(string string_3, string string_4)
    {
        string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/shopdetail/shopinfo.json?oriMemberId={memberId}&_tb_token_={tbToken}&_input_charset=utf-8";
        string address = str2.Replace("{shopid}", string_3).Replace("{tbToken}", newValue);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.OaHsHE");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_4);
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
        for (int i = 0; (i = str4.IndexOf("\"memberID\"", i)) != -1; i++)
        {
            Store class2 = new Store();
            class2.member_id = StringUtil.subString(str4, i, "\"memberID\":", ",");
            class2.ori_member_id = StringUtil.subString(str4, i, "\"oriMemberId\":", ",");
            class2.shop_url = StringUtil.subString(str4, i, "\"shopUrl\":\"", "\"");
            class2.title = StringUtil.subString(str4, i, "\"shopTitle\":\"", "\"");
            class2.avg_commission = float.Parse(StringUtil.subString(str4, i, "\"shopCommissionRate\":", ",")) / 100f;
            list.Add(class2);
        }
        return list;
    }

    public static ArrayList smethod_23(string string_3, string string_4)
    {
        return smethod_26("", string_3, string_4);
    }

    public static ArrayList smethod_24(string string_3, string string_4)
    {
        return smethod_26("&shopType=2", string_3, string_4);
    }

    public static ArrayList smethod_25(string string_3, string string_4)
    {
        return smethod_26("&shopType=1", string_3, string_4);
    }

    public static ArrayList smethod_26(string string_3, string string_4, string string_5)
    {
        string format = "http://pub.alimama.com/shopsearch/shopList.json?spm=a219t.7473494.1998155389.3.2x0qLl&q={0}{1}&toPage=1&sort=_totalAction&perPagesize=40";
        string address = string.Format(format, HttpUtility.UrlEncode(string_4), string_3);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_5);
        string str3 = "";
        byte[] buffer = client.DownloadData(address);
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
        for (int i = 0; (i = str3.IndexOf("\"memberID\"", i)) != -1; i++)
        {
            Store class2 = new Store();
            class2.member_id = StringUtil.subString(str3, i, "\"memberID\":", ",");
            class2.ori_member_id = StringUtil.subString(str3, i, "\"oriMemberId\":", ",");
            class2.shop_url = StringUtil.subString(str3, i, "\"shopUrl\":\"", "\"");
            class2.title = StringUtil.subString(str3, i, "\"shopTitle\":\"", "\"");
            class2.avg_commission = float.Parse(StringUtil.subString(str3, i, "\"shopCommissionRate\":", ",")) / 100f;
            list.Add(class2);
        }
        return list;
    }

    public static string smethod_27(string string_3, string string_4, string string_5, string string_6)
    {
        string str = StringUtil.subString(string_6, 0, "_tb_token_=", ";");
        string format = "http://pub.alimama.com/common/code/getShopCode.json?orimemberid={0}&adzoneid={1}&siteid={2}&_tb_token_={3}&_input_charset=utf-8";
        string address = string.Format(format, new object[] { string_3, string_4, string_5, str });
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_6);
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
        string str6 = "";
        try
        {
            int startIndex = str4.IndexOf("clickUrl") + 11;
            int length = (str4.IndexOf("pid") - startIndex) - 3;
            str6 = str4.Substring(startIndex, length);
        }
        catch
        {
        }
        return str6;
    }

    public static string query_pvid(string taoke_cookie)
    {
        try
        {
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", taoke_cookie);
            string str2 = "";
            string address = "http://pub.alimama.com/items/channel/qqhd.json?q=https://item.taobao.com/item.htm?id=52742091987&channel=qqhd&perPageSize=50&shopTag=&_tb_token_={token}";
            address = address.Replace("{token}", newValue);
            byte[] buffer = client.DownloadData(address);
            string str4 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str4))
            {
                str2 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str2 = Encoding.UTF8.GetString(buffer);
            }
            return StringUtil.subString(str2, 0, "\"message\":null,\"pvid\":\"", "\"");
        }
        catch (Exception)
        {
            
        }
        return "";
    }

    public static string query_taoke_item_click(string num_iid, string adzoneid, string siteid, string taoke_cookie)
    {
        string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid={auctionid}&adzoneid={adzoneid}&siteid={siteid}&t={t}&pvid={pvid}&_tb_token_={token}&_input_charset=utf-8";
        string address = str2.Replace("{auctionid}", num_iid).Replace("{adzoneid}", adzoneid).Replace("{siteid}", siteid).Replace("{t}", current_time() + "").Replace("{pvid}", query_pvid(taoke_cookie)).Replace("{token}", newValue);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", taoke_cookie);
        byte[] buffer = client.DownloadData(address);
        string str5 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str5))
        {
            return GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        return Encoding.UTF8.GetString(buffer);
    }

    public static ArrayList smethod_3(string string_3)
    {
        string newValue = StringUtil.subString(string_3, 0, "_tb_token_=", ";");
        string address = "http://pub.alimama.com/common/site/generalize/guideList.json?t={timestamp}&pvid=&_tb_token_={_tb_token_}&_input_charset=utf-8";
        address = address.Replace("{timestamp}", current_time() + "").Replace("{_tb_token_}", newValue);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_3);
        string str3 = "";
        byte[] buffer = client.DownloadData(address);
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
        string str5 = "\"" + StringUtil.subString(str3, 0, "\"guideList\":[{\"", "\"") + "\"";
        for (int i = 0; (i = str3.IndexOf(str5, i)) != -1; i++)
        {
            GuideItem class2 = new GuideItem();
            class2.string_0 = StringUtil.subString(str3, i, "\"name\":\"", "\"");
            class2.string_1 = StringUtil.subString(str3, i, "\"memberID\":", ",");
            class2.string_2 = StringUtil.subString(str3, i, "\"guideID\":", ",");
            class2.string_3 = StringUtil.subString(str3, i, "\"siteType\":\"", "\"");
            class2.string_4 = StringUtil.subString(str3, i, "\"category2\":\"", "\"");
            class2.string_5 = StringUtil.subString(str3, i, "\"category3\":\"", "\"");
            class2.string_6 = StringUtil.subString(str3, i, "\"account1\":[", "\"]") + "\"";
            class2.string_7 = StringUtil.subString(str3, i, "\"account2\":[", "\"]") + "\"";
            class2.string_8 = StringUtil.subString(str3, i, "\"account3\":[", "\"]") + "\"";
            list.Add(class2);
        }
        return list;
    }

    public static string smethod_30(string string_3)
    {
        return StringUtil.subString(string_3, 0, "\"clickUrl\":\"", "\"");
    }

    public static string smethod_31(string string_3)
    {
        return StringUtil.subString(string_3, 0, "\"shortLinkUrl\":\"", "\"");
    }

    public static string smethod_32(string string_3)
    {
        return StringUtil.subString(string_3, 0, "\"eliteUrl\":\"", "\"");
    }

    public static ArrayList smethod_33(string string_3)
    {
        ArrayList list = new ArrayList();
        int num = 1;
        bool flag = true;
        while (flag)
        {
            ArrayList c = smethod_34(num, out flag, string_3);
            list.AddRange(c);
            num++;
            Thread.Sleep(10);
        }
        return list;
    }

    public static ArrayList smethod_34(int int_0, out bool bool_0, string string_3)
    {
        string newValue = StringUtil.subString(string_3, 0, "_tb_token_=", ";");
        ArrayList list = new ArrayList();
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_3);
        string address = string_0.Replace("{pageno}", int_0 + "").Replace("{tbtoken}", newValue);
        string str3 = GzipUtil.zip_to_string(client.DownloadData(address), Encoding.UTF8);
        int num2 = int.Parse(StringUtil.subString(str3, 0, "\"totalPages\":", ","));
        if (int_0 >= num2)
        {
            bool_0 = false;
        }
        else
        {
            bool_0 = true;
        }
        for (int i = 0; (i = str3.IndexOf("\"protocol\"", i)) != -1; i++)
        {
            EventItem class2 = new EventItem();
            class2.event_id = StringUtil.subString(str3, i, "\"eventId\":", ",");
            class2.start_time = int.Parse(StringUtil.subString(str3, i, "\"startTime\":\"", "\",").Replace("-", ""));
            class2.end_time = int.Parse(StringUtil.subString(str3, i, "\"endTime\":\"", "\",").Replace("-", ""));
            class2.avg_commission = double.Parse(StringUtil.subString(str3, i, "\"avgCommission\":\"", "\","));
            class2.share_rate = double.Parse(StringUtil.subString(str3, i, "\"shareRate\":\"", "\","));
            list.Add(class2);
        }
        return list;
    }

    public static ArrayList smethod_35(string string_3, string string_4)
    {
        string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_4);
        ArrayList list = new ArrayList();
        string address = string_1.Replace("{brdgId}", string_3).Replace("{tbtoken}", newValue);
        string str3 = GzipUtil.zip_to_string(client.DownloadData(address), Encoding.UTF8);
        for (int i = 0; (i = str3.IndexOf("\"protocol\"", i)) != -1; i++)
        {
            EventItem class2 = new EventItem();
            class2.event_id = StringUtil.subString(str3, i, "\"eventId\":", ",");
            class2.start_time = int.Parse(StringUtil.subString(str3, i, "\"startTime\":\"", "\",").Replace("-", ""));
            class2.end_time = int.Parse(StringUtil.subString(str3, i, "\"endTime\":\"", "\",").Replace("-", ""));
            class2.avg_commission = smethod_36(StringUtil.subString(str3, i, "\"catRule\":\"", "\","));
            class2.share_rate = double.Parse(StringUtil.subString(str3, i, "\"shareRate\":\"", "\","));
            list.Add(class2);
        }
        return list;
    }

    public static double smethod_36(string string_3)
    {
        int num2 = 0;
        double num3 = 0.0;
        for (int i = 0; (i = string_3.IndexOf("≥", i)) != -1; i++)
        {
            num3 += double.Parse(StringUtil.subString(string_3, i, "≥", "%"));
            num2++;
        }
        return (num3 / ((double) num2));
    }

    public static ArrayList smethod_37(string event_id, string string_4, string string_5, out string string_6)
    {
        WebClient client = new WebClient();
        string_6 = "";
        ArrayList list = new ArrayList();
        int num2 = 1;
        while (true)
        {
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://temai.taobao.com/event" + event_id + ".htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_5);
            string address = string_2.Replace("{brdgId}", event_id + "").Replace("{pid}", string_4).Replace("{pageno}", num2 + "").Replace("{t}", current_time() + "").Replace("{pvid}", query_pvid(string_5));
            byte[] bytes = client.DownloadData(address);
            string str = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if (!"gzip".Equals(str5))
            {
                str = Encoding.UTF8.GetString(bytes);
            }
            else
            {
                str = GzipUtil.zip_to_string(bytes, Encoding.UTF8);
            }
            if (str.Contains("\"result\":[]"))
            {
                return list;
            }
            string_6 = string_6.Equals("") ? str : (string_6 + "\n" + str);
            for (int i = 0; (i = str.IndexOf("\"itemId\":", i)) != -1; i++)
            {
                EventGoods event_goods = new EventGoods();
                event_goods.event_id = event_id;
                event_goods.num_iid = StringUtil.subString(str, i, "\"itemId\":", ",");
                event_goods.title = StringUtil.subString(str, i, "\"itemTitle\":\"", ",\"");
                event_goods.title = event_goods.title.Substring(0, event_goods.title.Length - 1);
                event_goods.url = "http:" + StringUtil.subString(str, i, "\"href\":\"", "\",");
                event_goods.user_num_id = StringUtil.subString(str, i, "\"sellerId\":", ",");
                event_goods.pic_url = "http:" + StringUtil.subString(str, i, "\"picUrl\":\"", "\",");
                event_goods.commission_rate = double.Parse(StringUtil.subString(str, i, "\"commissionRate\":", ",")) / 100.0;
                event_goods.is_sold_out = bool.Parse(StringUtil.subString(str, i, "\"isSoldOut\":", ",")) ? 1 : 0;
                event_goods.price = double.Parse(StringUtil.subString(str, i, "\"discountPrice\":\"", "\","));
                event_goods.ori_price = StringUtil.subString(str, i, "\"auctionPrice\":\"", "\",");
                event_goods.discount_rate = StringUtil.subString(str, i, "\"discountRate\":\"", "\",");
                if (event_goods.discount_rate.Equals(""))
                {
                    event_goods.discount_rate = "0";
                }
                event_goods.volume = int.Parse(StringUtil.subString(str, i, "\"soldQuantity\":", ","));
                event_goods.is_mall = bool.Parse(StringUtil.subString(str, i, "\"mall\":", "}")) ? 1 : 0;
                list.Add(event_goods);
            }
            string str2 = StringUtil.subString(str, 0, "\"hasNext\":", ",");
            string str3 = StringUtil.subString(str, 0, "\"nextPage\":", ",");
            if ("0".Equals(str2) && (num2 + "").Equals(str3))
            {
                return list;
            }
            num2++;
        }
    }

    public static ArrayList smethod_38(int int_0, string string_3, out string string_4)
    {
        try
        {
            string newValue = StringUtil.subString(string_3, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.4Qcyc0");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_3);
            string str2 = "http://pub.alimama.com/campaign/joinedCampaigns.json?toPage={pageNo}&perPageSize=40&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str2.Replace("{pageNo}", int_0 + "").Replace("{tbtoken}", newValue);
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
            ArrayList list = smethod_40(str4);
            string_4 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_4 = "出错啦！！！" + exception.ToString();
            return new ArrayList();
        }
    }

    public static ArrayList smethod_39(string string_3, string string_4, out string string_5)
    {
        try
        {
            string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.4Qcyc0");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_4);
            string str2 = "http://pub.alimama.com/campaign/joinedCampaigns.json?toPage=1&nickname={nickname}&perPageSize=40&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str2.Replace("{nickname}", HttpUtility.UrlEncode(string_3)).Replace("{tbtoken}", newValue);
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
            ArrayList list = smethod_40(str4);
            string_5 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_5 = "出错啦！！！" + exception.ToString();
            return new ArrayList();
        }
    }

    public static string query_member_id(string taoke_cookie)
    {
        string address = "http://pub.alimama.com/common/getUnionPubContextInfo.json";
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", taoke_cookie);
        string str2 = "";
        byte[] buffer = client.DownloadData(address);
        string str3 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str3))
        {
            str2 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str2 = Encoding.UTF8.GetString(buffer);
        }
        return StringUtil.subString(str2, 0, "\"memberid\":", ",");
    }

    public static ArrayList smethod_40(string string_3)
    {
        ArrayList list = new ArrayList();
        string str = "\"" + StringUtil.subString(string_3, 0, "\"pagelist\":[{\"", "\"") + "\"";
        for (int i = 0; (i = string_3.IndexOf(str, i)) != -1; i++)
        {
            CampaignBean campaignBean = new CampaignBean();
            int index = string_3.IndexOf("\"id\"", (int) (i + 1));
            int length = string_3.Length - i;
            if (index != -1)
            {
                length = index - i;
            }
            string str2 = string_3.Substring(i, length);
            campaignBean.id = StringUtil.subString(str2, 0, "\"id\":", ",");
            campaignBean.campaign_id = StringUtil.subString(str2, 0, "\"campaignId\":", ",");
            campaignBean.shop_keeper_id = StringUtil.subString(str2, 0, "\"shopKeeperId\":", ",");
            campaignBean.user_num_id = StringUtil.subString(str2, 0, "\"oriMemberId\":", ",");
            campaignBean.campaign_name = StringUtil.subString(str2, 0, "\"campaignName\":\"", "\",");
            campaignBean.status = StringUtil.subString(str2, 0, "\"status\":", ",");
            campaignBean.campaign_type = StringUtil.subString(str2, 0, "\"campaignType\":", ",");
            campaignBean.invalide_campaign = bool.Parse(StringUtil.subString(str2, 0, "\"invalideCampaign\":", ","));
            campaignBean.campaign_status = StringUtil.subString(str2, 0, "\"campaignStatus\":", ",");
            if ("null".Equals(campaignBean.campaign_type))
            {
                campaignBean.campaign_type = "";
            }
            list.Add(campaignBean);
        }
        return list;
    }

    public static ArrayList smethod_41(string string_3, string string_4, out string string_5)
    {
        try
        {
            string newValue = StringUtil.subString(string_4, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.4Qcyc0");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_4);
            string str2 = "http://pub.alimama.com/shopdetail/campaigns.json?oriMemberId={oriMemberid}&t={timestamp}&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str2.Replace("{oriMemberid}", string_3).Replace("{timestamp}", current_time() + "").Replace("{tbtoken}", newValue);
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
            ArrayList list = query_campaign(str4, string_3, string_4);
            string_5 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_5 = "出错啦！！！" + exception.ToString();
            return new ArrayList();
        }
    }

    public static bool apply_campaign(string campid, string keeperid, string applyreason_pre, string applyreason, string taoke_cookie, out string out_log)
    {
        try
        {
            applyreason_pre = DateTime.Now.ToString() + applyreason_pre;
            out_log = "";
            string str = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", taoke_cookie);
            string s = "campId=" + campid + "&keeperid=" + keeperid + "&applyreason=" + HttpUtility.UrlEncode(applyreason_pre + applyreason) + "&_tb_token_=" + str;
            byte[] buffer = client.UploadData("http://pub.alimama.com/pubauc/applyForCommonCampaign.json", "POST", Encoding.UTF8.GetBytes(s));
            string str4 = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
            if (str4.Contains("\"message\":null") && str4.Contains("\"ok\":true"))
            {
                out_log = "申请高佣金计划【成功】！高佣金计划ID：【" + campid + "】";
                return true;
            }
            if (str4.Contains("\"url\":\"http"))
            {
                string code_url = StringUtil.subString(str4, 0, "\"url\":\"", "\"");
                if (!String.IsNullOrEmpty(code_url))
                {
                    bool check_code = AlimamaCodeUtil.check_code(0, code_url, taoke_cookie,out out_log);
                    if (check_code)
                    {
                        return AlimamaUtil.apply_campaign(campid, keeperid, applyreason_pre, applyreason,taoke_cookie, out out_log);
                    }
                }
            }
            //string str6 = StringUtil.subString(str4, 0, "\"message\":\"", "\"");
            //if (String.IsNullOrEmpty(str6))
            //{
            //    out_log = "申请高佣金计划【失败】！高佣金计划ID：【" + campid + "】，失败原因：【" + str4 + "】。";
            //}
            //else
            //{
            //    out_log = "申请高佣金计划【失败】！高佣金计划ID：【" + campid + "】，失败原因：【" + str6 + "】。";
            //}
            return false;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return false;
        }
    }

    public static void exitCampaign(string campain_id, string cookie, out string out_log)
    {
        try
        {
            string newValue = StringUtil.subString(cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.75 Safari/537.36 QQBrowser/4.1.4132.400");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.jLGE9b");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string address = "http://pub.alimama.com/campaign/exitCampaign.json";
            string s = "pubCampaignid={cmpid}&_tb_token_={token}".Replace("{cmpid}", campain_id).Replace("{token}", newValue);
            byte[] buffer = client.UploadData(address, "POST", Encoding.UTF8.GetBytes(s));
            string content = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                content = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                content = Encoding.UTF8.GetString(buffer);
            }
            if (content.Contains("\"ok\":true"))
            {
                out_log = "退出高佣金计划【成功】！高佣金计划ID：【" + campain_id + "】";
            }
            else
            {
                //string str6 = StringUtil.subString(content, 0, "\"message\":\"", "\"");
                out_log = "退出高佣金计划【失败】！高佣金计划ID：【" + campain_id + "】，失败原因：【" + content + "】";
            }
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
        }
    }

    public static void smethod_44(string user_num_id, string applyreason, string cookie, out string out_log)
    {
        query_campain_detail(user_num_id, applyreason, false, cookie, out out_log);
    }

    public static void query_campain_detail(string user_num_id, string applyreason, bool bool_0, string cookie, out string out_log)
    {
        try
        {
            out_log = "";
            string newValue = StringUtil.subString(cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string str2 = "http://pub.alimama.com/shopdetail/campaigns.json?oriMemberId={oriMemberid}&&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str2.Replace("{oriMemberid}", user_num_id).Replace("{tbtoken}", newValue);
            string content = "";
            byte[] buffer = client.DownloadData(address);
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                content = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                content = Encoding.UTF8.GetString(buffer);
            }
            CampaignBean campaignBean = null;
            double num2 = 0.0;
            int startIndex = 0;
            ArrayList list = new ArrayList();
        Label_0153:
            if ((startIndex = content.IndexOf("\"campaignName\":\"", startIndex)) == -1)
            {
                goto Label_0215;
            }
            CampaignBean class3 = new CampaignBean();
            class3.campaign_name = StringUtil.subString(content, startIndex, "\"campaignName\":\"", "\",");
            try
            {
                class3.avg_commission = float.Parse(StringUtil.subString(content, startIndex, "\"avgCommission\":", ",")) / 100f;
            }
            catch
            {
                class3.avg_commission = 0.0;
            }
            goto Label_0203;
        Label_01CB:
            num2 = class3.avg_commission;
        Label_01D4:
            list.Add(class3);
            if ("通用计划".Equals(class3.campaign_name))
            {
                campaignBean = class3;
            }
            startIndex++;
            goto Label_0153;
        Label_0203:
            if (num2 >= class3.avg_commission)
            {
                goto Label_01D4;
            }
            goto Label_01CB;
        Label_0215:
            if (list.Count == 0)
            {
                out_log = "【" + user_num_id + "】，该店铺没有淘客佣金！";
            }
            else if (list.Count == 1)
            {
                out_log = "【" + user_num_id + "】，该店铺没有高佣金计划，不需要申请！";
            }
            else if (num2 <= campaignBean.avg_commission)
            {
                out_log = "【" + user_num_id + "】，该店铺的【通用计划】佣金最高，不需要申请！";
            }
            else
            {
                string str6;
                ArrayList list2 = query_campaign(content, user_num_id, cookie);
                if (smethod_52(list2))
                {
                    if (bool_0)
                    {
                        foreach (CampaignBean class4 in list2)
                        {
                            if (class4.string_7.Equals("true"))
                            {
                                str6 = "";
                                exitCampaign(class4.id, cookie, out str6);
                                out_log = out_log.Equals("") ? str6 : (out_log + "\n" + str6);
                            }
                        }
                    }
                    else
                    {
                        out_log = "【" + user_num_id + "】，已经申请该店铺的高佣金计划！";
                        return;
                    }
                }
                Thread.Sleep(50);
                client.Headers.Clear();
                client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
                client.Headers.Add("Origin", "http://pub.alimama.com");
                client.Headers.Add("X-Requested-With", "XMLHttpRequest");
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
                client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
                client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                client.Headers.Add("Cookie", cookie);
                CampaignBean class5 = (CampaignBean) list2[0];
                string str7 = class5.campaign_id;
                string str8 = class5.shop_keeper_id;
                string s = "campId=" + str7 + "&keeperid=" + str8 + "&applyreason=" + HttpUtility.UrlEncode(applyreason) + "&_tb_token_=" + newValue;
                byte[] bytes = client.UploadData("http://pub.alimama.com/pubauc/applyForCommonCampaign.json", "POST", Encoding.UTF8.GetBytes(s));
                string str10 = Encoding.UTF8.GetString(bytes);
                if (str10.Contains("\"message\":null") && str10.Contains("\"ok\":true"))
                {
                    str6 = string.Concat(new object[] { "【", user_num_id, "】，申请高佣金计划【成功】！高佣金计划：【", class5.campaign_name, "】，平均佣金：【", class5.avg_commission, "】" });
                    out_log = out_log.Equals("") ? str6 : (out_log + "\n" + str6);
                }
                else
                {
                    string str11 = StringUtil.subString(str10, 0, "\"message\":\"", "\"");
                    str6 = "【" + user_num_id + "】，申请高佣金计划【失败】！高佣金计划：【" + class5.campaign_name + "】，失败原因：【" + str11 + "】";
                    out_log = out_log.Equals("") ? str6 : (out_log + "\n" + str6);
                }
            }
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
        }
    }

    public static ArrayList query_campaign(string string_3, string string_4, string string_5)
    {
        CampaignBean class2;
        int num5;
        string str3;
        string str = "";
        smethod_14(string_4, string_5, out str);
        ArrayList list = new ArrayList();
        int index = string_3.IndexOf("exsitApplyList");
        if (index != -1)
        {
            int length = string_3.IndexOf("campaignList") - index;
            string str2 = string_3.Substring(index, length);
            for (int i = 0; (i = str2.IndexOf("\"id\":", i)) != -1; i++)
            {
                class2 = new CampaignBean();
                num5 = str2.IndexOf("}", i) - i;
                str3 = string_3.Substring(i, num5);
                class2.id = StringUtil.subString(str3, 0, "\"id\":", ",");
                class2.campaign_id = StringUtil.subString(str3, 0, "\"campaignId\":", ",");
                class2.status = StringUtil.subString(str3, 0, "\"status\":", ",");
                class2.string_10 = StringUtil.subString(str3, 0, "\"refuseComments\":\"", "\",");
                list.Add(class2);
            }
        }
        ArrayList list2 = new ArrayList();
        string str4 = string_3.Substring(string_3.IndexOf("campaignList"));
        int startIndex = 0;
    Label_0125:
        if ((startIndex = str4.IndexOf("properties", startIndex)) == -1)
        {
            for (int j = 0; j < (list2.Count - 1); j++)
            {
                for (int k = j; k < list2.Count; k++)
                {
                    if (((CampaignBean) list2[j]).avg_commission < ((CampaignBean) list2[k]).avg_commission)
                    {
                        CampaignBean class4 = (CampaignBean) list2[j];
                        list2[j] = list2[k];
                        list2[k] = class4;
                    }
                }
            }
            return list2;
        }
        class2 = new CampaignBean();
        int num7 = str4.IndexOf("properties", (int) (startIndex + 1));
        num5 = str4.Length - startIndex;
        if (num7 != -1)
        {
            num5 = num7 - startIndex;
        }
        str3 = str4.Substring(startIndex, num5);
        class2.campaign_id = StringUtil.subString(str3, 0, "\"campaignId\":", ",");
        class2.campaign_name = StringUtil.subString(str3, 0, "\"campaignName\":\"", "\",");
        class2.campaign_type = StringUtil.subString(str3, 0, "\"campaignType\":", ",");
        string s = StringUtil.subString(str3, 0, "\"avgCommissionToString\":\"", "\",").Replace("%", "").Replace(" ", "");
        try
        {
            class2.avg_commission = float.Parse(s);
        }
        catch
        {
        }
        class2.string_11 = StringUtil.subString(str3, 0, "\"campaignComments\":\"", "\",");
        //using (IEnumerator enumerator = list.GetEnumerator())
        IEnumerator enumerator = list.GetEnumerator();
        {
            CampaignBean current;
            while (enumerator.MoveNext())
            {
                current = (CampaignBean) enumerator.Current;
                if (current.campaign_id.Equals(class2.campaign_id))
                {
                    goto Label_024C;
                }
            }
            goto Label_029C;
        Label_024C:
            class2.id = current.id;
            class2.string_7 = "true";
            class2.status = current.status;
            class2.string_10 = current.string_10;
        }
    Label_029C:
        class2.shop_keeper_id = StringUtil.subString(str3, 0, "\"shopKeeperId\":", ",");
        class2.user_num_id = string_4;
        class2.string_9 = StringUtil.subString(str3, 0, "properties\":", ",");
        list2.Add(class2);
        startIndex++;
        goto Label_0125;
    }

    public static CampaignItem query_campain_detail(string cookie, string campaign_id, string sho_keeper_id, out string out_log)
    {
        try
        {
            out_log = "";
            string tb_token = StringUtil.subString(cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string str2 = "http://pub.alimama.com/campaign/campaignDetail.json?campaignId={campaignId}&shopkeeperId={shopkeeperId}&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str2.Replace("{campaignId}", campaign_id).Replace("{shopkeeperId}", sho_keeper_id).Replace("{tbtoken}", tb_token);
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
            if (str4.Contains("nologin"))
            {
                out_log = "";
                return null;
            }
            CampaignItem class3 = new CampaignItem();
            class3.campaignComments = StringUtil.subString(str4, 0, "\"campaignComments\":\"", "\",");
            class3.campaign_name = StringUtil.subString(str4, 0, "\"campaignName\":\"", "\",");
            class3.string_2 = StringUtil.subString(str4, 0, "\"campaignComments\":\"", "\",");
            class3.status = StringUtil.subString(str4, 0, "\"status\":", ",");
            return class3;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static ArrayList smethod_48(string taoke_cookie, string campaignId, string shopkeeperId, string userNumberId, out string string_7)
    {
        ArrayList list2;
        try
        {
            string str3;
            GoodsItem5 goodsItem5;
            string_7 = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            ArrayList list = new ArrayList();
            int num2 = 1;
        Label_002F:
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.aMV6Mc");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", taoke_cookie);
            string str4 = "http://pub.alimama.com/campaign/merchandiseDetail.json?spm=a219t.7473494.1998155389.3.aMV6Mc&campaignId={campaignId}&shopkeeperId={shopkeeperId}&userNumberId={userNumberId}&tab=2&omid={userNumberId}&toPage={pageNo}&perPagesize=10&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str4.Replace("{pageNo}", num2 + "").Replace("{campaignId}", campaignId).Replace("{shopkeeperId}", shopkeeperId).Replace("{userNumberId}", userNumberId).Replace("{tbtoken}", newValue);
            string str2 = "";
            byte[] bytes = client.DownloadData(address);
            string str6 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str6))
            {
                goto Label_02C1;
            }
            str2 = Encoding.UTF8.GetString(bytes);
        Label_0175:
            str3 = StringUtil.subString(str2, 0, "\"pagelist\":[{", @"\:");
            int startIndex = 0;
        Label_018C:
            if ((startIndex = str2.IndexOf(str3, startIndex)) != -1)
            {
                goodsItem5 = new GoodsItem5();
                goodsItem5.user_type = StringUtil.subString(str2, startIndex, "\"userType\":", ",");
                goodsItem5.user_num_id = StringUtil.subString(str2, startIndex, "\"userNumberId\":", ",");
                goodsItem5.num_iid = StringUtil.subString(str2, startIndex, "\"auctionId\":", ",");
                goodsItem5.title = StringUtil.subString(str2, startIndex, "\"title\":\"", "\",");
                goodsItem5.pic_url = StringUtil.subString(str2, startIndex, "\"pictUrl\":\"", "\",");
                goodsItem5.price = StringUtil.subString(str2, startIndex, "\"zkPrice\":", ",");
                goodsItem5.ori_price = StringUtil.subString(str2, startIndex, "\"reservePrice\":", ",");
                try
                {
                    goodsItem5.volume = int.Parse(StringUtil.subString(str2, startIndex, "\"totalNum\":", ","));
                }
                catch
                {
                    goodsItem5.volume = 0;
                }
                goto Label_02D4;
            }
            int num4 = int.Parse(StringUtil.subString(str2, 0, "\"pages\":", ","));
            if (num2 >= num4)
            {
                goto Label_031C;
            }
            Thread.Sleep(10);
            num2++;
            goto Label_002F;
        Label_02C1:
            str2 = GzipUtil.zip_to_string(bytes, Encoding.UTF8);
            goto Label_0175;
        Label_02D4:
            goodsItem5.commissionRatePercent = StringUtil.subString(str2, startIndex, "\"commissionRatePercent\":", ",");
            goodsItem5.nick = StringUtil.subString(str2, startIndex, "\"nick\":\"", "\",");
            list.Add(goodsItem5);
            startIndex++;
            goto Label_018C;
        Label_031C:
            list2 = list;
        }
        catch (Exception exception)
        {
            string_7 = "出错啦！！！" + exception.ToString();
            list2 = new ArrayList();
        }
        return list2;
    }

    public static GoodsItem5 smethod_49(string string_3, string string_4, string string_5, string string_6, string string_7, out string string_8)
    {
        return smethod_50(string_3, string_4, string_5, string_6, string_7, 3, out string_8);
    }

    public static AdzoneBean query_AdzoneBean(string tag, string cookie)
    {
        string newValue = StringUtil.subString(cookie, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/common/adzone/newSelfAdzone2.json?tag={tag}&_tb_token_={_tb_token_}&_input_charset=utf-8";
        string address = str2.Replace("{_tb_token_}", newValue).Replace("{tag}", tag);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", cookie);
        string body = "";
        byte[] buffer = client.DownloadData(address);
        string str5 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str5))
        {
            body = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            body = Encoding.UTF8.GetString(buffer);
        }
        AdzoneBean adzoneBean = new AdzoneBean();
        adzoneBean.memberid = query_member_id(cookie);
        //adzoneBean.otherAdzones_List = parse_Adzone(body, 3);
        adzoneBean.qqAdzones_List = parse_Adzone(body, 3);
        adzoneBean.weixinAdzones_List = parse_Adzone(body, 4);
        adzoneBean.weiboAdzones_List = parse_Adzone(body, 5);

        adzoneBean.appAdzones_List = parse_Adzone(body, 2);

        adzoneBean.webAdzones_List = parse_Adzone(body, 1);
        return adzoneBean;
    }

    public static GoodsItem5 smethod_50(string taoke_cookie, string num_iid, string campaignId, string shopkeeperId, string userNumberId, int int_0, out string out_log)
    {
        try
        {
            string str3;
            int num4;
            out_log = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            new ArrayList();
            int num2 = 1;
        Label_002E:
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.aMV6Mc");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", taoke_cookie);
            string str4 = "http://pub.alimama.com/campaign/merchandiseDetail.json?spm=a219t.7473494.1998155389.3.aMV6Mc&campaignId={campaignId}&shopkeeperId={shopkeeperId}&userNumberId={userNumberId}&tab=2&omid={userNumberId}&toPage={pageNo}&perPagesize=10&_tb_token_={tbtoken}&_input_charset=utf-8";
            string address = str4.Replace("{pageNo}", num2 + "").Replace("{campaignId}", campaignId).Replace("{shopkeeperId}", shopkeeperId).Replace("{userNumberId}", userNumberId).Replace("{tbtoken}", newValue);
            string str2 = "";
            byte[] bytes = client.DownloadData(address);
            string str6 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str6))
            {
                goto Label_02DD;
            }
            str2 = Encoding.UTF8.GetString(bytes);
        Label_0174:
            str3 = StringUtil.subString(str2, 0, "\"pagelist\":[{", ":");
            int startIndex = 0;
        Label_018B:
            if ((startIndex = str2.IndexOf(str3, startIndex)) == -1)
            {
                goto Label_0298;
            }
            GoodsItem5 class2 = new GoodsItem5();
            class2.user_type = StringUtil.subString(str2, startIndex, "\"userType\":", ",");
            class2.user_num_id = StringUtil.subString(str2, startIndex, "\"userNumberId\":", ",");
            class2.num_iid = StringUtil.subString(str2, startIndex, "\"auctionId\":", ",");
            class2.title = StringUtil.subString(str2, startIndex, "\"title\":\"", "\",");
            class2.pic_url = StringUtil.subString(str2, startIndex, "\"pictUrl\":\"", "\",");
            class2.price = StringUtil.subString(str2, startIndex, "\"zkPrice\":", ",");
            class2.ori_price = StringUtil.subString(str2, startIndex, "\"reservePrice\":", ",");
            try
            {
                class2.volume = int.Parse(StringUtil.subString(str2, startIndex, "\"totalNum\":", ","));
            }
            catch
            {
                class2.volume = 0;
            }
            goto Label_02F0;
        Label_028D:
            startIndex++;
            goto Label_018B;
        Label_0298:
            num4 = int.Parse(StringUtil.subString(str2, 0, "\"pages\":", ","));
            if (num2 >= num4)
            {
                return null;
            }
            if ((num2 >= int_0) && (int_0 != -1))
            {
                return null;
            }
            Thread.Sleep(500);
            num2++;
            goto Label_002E;
        Label_02DD:
            str2 = GzipUtil.zip_to_string(bytes, Encoding.UTF8);
            goto Label_0174;
        Label_02F0:
            class2.commissionRatePercent = StringUtil.subString(str2, startIndex, "\"commissionRatePercent\":", ",");
            class2.nick = StringUtil.subString(str2, startIndex, "\"nick\":\"", "\",");
            if (!num_iid.Equals(class2.num_iid))
            {
                goto Label_028D;
            }
            return class2;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static ArrayList smethod_51(string string_3, string string_4)
    {
        try
        {
            StringUtil.subString(string_4, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_4);
            string address = "http://pub.alimama.com/campaign/joinedCampaigns.json?toPage=1&status=&nickname={nickname}&perPageSize=40&_input_charset=utf-8".Replace("{nickname}", HttpUtility.UrlEncode(string_3));
            string str3 = "";
            byte[] buffer = client.DownloadData(address);
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
            string str5 = str3.Substring(str3.IndexOf("pagelist"));
            for (int i = 0; (i = str5.IndexOf("\"id\"", i)) != -1; i++)
            {
                CampaignBean class2 = new CampaignBean();
                int index = str5.IndexOf("\"id\"", (int) (i + 1));
                int length = str5.Length - i;
                if (index != -1)
                {
                    length = index - i;
                }
                string str6 = str5.Substring(i, length);
                class2.campaign_id = StringUtil.subString(str6, 0, "\"campaignId\":", ",");
                class2.campaign_name = StringUtil.subString(str6, 0, "\"status\":", ",");
                class2.campaign_type = StringUtil.subString(str6, 0, "\"refuseComments\":", ",\"").Replace("\"", "");
                if ("null".Equals(class2.campaign_type))
                {
                    class2.campaign_type = "";
                }
                list.Add(class2);
            }
            return list;
        }
        catch
        {
            return new ArrayList();
        }
    }

    public static bool smethod_52(ArrayList arrayList_0)
    {
        foreach (CampaignBean class2 in arrayList_0)
        {
            if (class2.string_7.Equals("true"))
            {
                return true;
            }
        }
        return false;
    }

    public static ArrayList query_campaign_list(string taoke_cookie, string num_iid, out string out_log)
    {
        string str = "";
        try
        {
            out_log = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            ArrayList list = new ArrayList();
            long num2 = current_time();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/search/index.htm?q=https%3A%2F%2Fitem.taobao.com%2Fitem.htm%3Fid%3D{itemId}&_t={timestamp}".Replace("{itemId}", num_iid).Replace("{timestamp}", (num2 + 0x834L) + ""));
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            client.Headers.Add("Cookie", taoke_cookie);
            string str3 = "http://pub.alimama.com/pubauc/getCommonCampaignByItemId.json?itemId={itemId}&t={timestamp}&_tb_token_={tbtoken}";
            string address = str3.Replace("{itemId}", num_iid).Replace("{timestamp}", num2 + "").Replace("{tbtoken}", newValue);
            byte[] buffer = client.DownloadData(address);
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str = Encoding.UTF8.GetString(buffer);
            }
            if ((str.Contains("\"data\":{}") || str.Contains("\"data\":[]")) || str.Contains("\"data\":null"))
            {
                out_log = str;
                return list;
            }
            if (str.Contains("\"wait\""))
            {
                out_log = str;
                return list;
            }
            out_log = str;

            string str6 = StringUtil.subString(str, 0, "{\"data\":[{", ":");
            int startIndex = 0;
            while (true)
            {
                startIndex = str.IndexOf(str6, startIndex);
                if (startIndex == -1)
                {
                    break;
                }
                CampaignItem1 CampaignItem = new CampaignItem1();
                CampaignItem.commissionRate = double.Parse(StringUtil.subString(str, startIndex, "\"commissionRate\":", ","));
                CampaignItem.CampaignID = StringUtil.subString(str, startIndex, "\"CampaignID\":", ",");
                CampaignItem.CampaignName = StringUtil.subString(str, startIndex, "\"CampaignName\":\"", "\",");
                CampaignItem.CampaignType = StringUtil.subString(str, startIndex, "\"CampaignType\":\"", "\",");
                string AvgCommission = StringUtil.subString(str, startIndex, "\"AvgCommission\":\"", "\",");
                try
                {
                    CampaignItem.AvgCommission = double.Parse(AvgCommission.Replace("%", "").Replace(" ", ""));
                }
                catch
                {
                    CampaignItem.AvgCommission = 0.0;
                }
                CampaignItem.Exist = StringUtil.subString(str, startIndex, "\"Exist\":", ",");
                CampaignItem.ShopKeeperID = StringUtil.subString(str, startIndex, "\"ShopKeeperID\":", ",");
                CampaignItem.Properties = StringUtil.subString(str, startIndex, "\"Properties\":", "\"");
                CampaignItem.manualAudit = StringUtil.subString(str, startIndex, "\"manualAudit\":", ",");
                list.Add(CampaignItem);
                startIndex++;
            }
            //out_log = "";
            return list;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + str + "\n" + exception.ToString();
            return null;
        }
    }

    public static long current_time()
    {
        DateTime time = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(0x7b2, 1, 1, 0, 0, 0, 0));
        TimeSpan span = (TimeSpan) (DateTime.Now - time);
        return (long) span.TotalMilliseconds;
    }

    public static AlimamaClick query_taoke_click(string taoke_cookie, string num_iid, string adzoneid, string siteid, int url_type, out string out_log)
    {
        try
        {
            out_log = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            long num2 = current_time();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/search/index.htm?q=https%3A%2F%2Fitem.taobao.com%2Fitem.htm%3Fid%3D{itemId}&_t={timestamp}".Replace("{itemId}", num_iid).Replace("{timestamp}", (num2 - 0x1004L) + ""));
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            client.Headers.Add("Cookie", taoke_cookie);

            string str2 = "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid={itemId}&adzoneid={adzoneid}&siteid={siteid}&scenes=1&t={timestamp}&pvid={pvid}&_tb_token_={tbtoken}&_input_charset=utf-8";
            if(url_type==1){
                str2 = "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid={itemId}&adzoneid={adzoneid}&siteid={siteid}&scenes=3&channel=tk_qqhd&t={timestamp}&_tb_token_={tbtoken}&pvid={pvid}";
            }

            string address = str2.Replace("{itemId}", num_iid).Replace("{adzoneid}", adzoneid).Replace("{siteid}", siteid).Replace("{timestamp}", num2 + "").Replace("{tbtoken}", newValue).Replace("{pvid}", query_pvid(taoke_cookie));
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
            if (str4.Contains("\"info\":{\"message\":null,\"ok\":true},\"ok\":true"))
            {
                AlimamaClick class2 = new AlimamaClick();
                class2.url = StringUtil.subString(str4, 0, "\"clickUrl\":\"", "\"");
                class2.coupon_url = StringUtil.subString(str4, 0, "\"couponLink\":\"", "\"");
                class2.short_url = StringUtil.subString(str4, 0, "\"shortLinkUrl\":\"", "\"");
                class2.tao_token = StringUtil.subString(str4, 0, "\"taoToken\":\"", "\"");
                class2.coupon_link_tao_token = StringUtil.subString(str4, 0, "\"couponLinkTaoToken\":\"", "\"");
                class2.num_iid = num_iid;
                out_log = "";
                return class2;
            }
            out_log = str4;
            return null;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static AlimamaClick query_taoke_click(string taoke_cookie, string url, string adzoneid, string siteid, out string out_log)
    {
        try
        {
            out_log = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            long num2 = current_time();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7900221/1.1998910419.dbb742793.nMYfWP&_t={timestamp}".Replace("{timestamp}", (num2 - 0x1004L) + ""));
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            client.Headers.Add("Cookie", taoke_cookie);

            string str2 = "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid={itemId}&adzoneid={adzoneid}&siteid={siteid}&scenes=1&t={timestamp}&pvid={pvid}&_tb_token_={tbtoken}&_input_charset=utf-8";
            str2 = "http://pub.alimama.com/urltrans/urltrans.json?siteid={siteid}&adzoneid={adzoneid}&promotionURL={url}&t={timestamp}&pvid={pvid}&_tb_token_={tbtoken}&_input_charset=utf-8";

            string address = str2.Replace("{url}",  HttpUtility.UrlEncode(url)).Replace("{adzoneid}", adzoneid).Replace("{siteid}", siteid).Replace("{timestamp}", num2 + "").Replace("{tbtoken}", newValue).Replace("{pvid}", query_pvid(taoke_cookie));
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
            if (str4.Contains("\"info\":{\"message\":null,\"ok\":true},\"ok\":true"))
            {
                AlimamaClick class2 = new AlimamaClick();
                class2.url = StringUtil.subString(str4, 0, "\"sclick\":\"", "\"");
                class2.short_url = StringUtil.subString(str4, 0, "\"shortLinkUrl\":\"", "\"");
                class2.tao_token = StringUtil.subString(str4, 0, "\"taoToken\":\"", "\"");
                //class2.num_iid = num_iid;
                out_log = "";
                return class2;
            }
            out_log = str4;
            return null;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static GoodsItem2 query_taoke_item_event(string taoke_cookie, string num_iid, out string out_log)
    {
        ArrayList list = query_taoke_item_event_list(taoke_cookie, "&q=" + HttpUtility.UrlEncode("https://item.taobao.com/item.htm?id=" + num_iid), out out_log);
        if ((list != null) && (list.Count != 0))
        {
            return (GoodsItem2) list[0];
        }
        return null;
    }

    public static ArrayList query_taoke_item_event_list(string taoke_cookie, string string_4, out string out_log)
    {
        try
        {
            out_log = "";
            string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
            WebClient client = new WebClient();
            long num2 = current_time();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/item/channel/index.htm?channel=qqhd&_t={timestamp}{schCon}".Replace("{timestamp}", num2 + "").Replace("{schCon}", string_4));
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
            client.Headers.Add("Cookie", taoke_cookie);
            string str2 = "http://pub.alimama.com/items/channel/qqhd.json?channel=qqhd&perPageSize=50&shopTag=&t={timestamp}{schCon}&_tb_token_={tbtoken}";
            string address = str2.Replace("{timestamp}", num2 + "").Replace("{schCon}", string_4).Replace("{tbtoken}", newValue);
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
            int startIndex = 0;
            ArrayList list = new ArrayList();
            while ((startIndex = str4.IndexOf("tkSpecialCampaignIdRateMap", startIndex)) != -1)
            {
                GoodsItem2 goodsItem = new GoodsItem2();
                goodsItem.num_iid = StringUtil.smethod_1(str4, startIndex, "\"auctionId\":", ",", "}");
                goodsItem.title = GzipUtil.html_to_text(StringUtil.smethod_1(str4, startIndex, "\"title\":\"", "\",", "}"));
                goodsItem.shop_title = StringUtil.smethod_1(str4, startIndex, "\"shopTitle\":\"", "\",", "}");
                goodsItem.user_num_id = StringUtil.smethod_1(str4, startIndex, "\"sellerId\":", ",", "}");
                goodsItem.pictUrl = StringUtil.smethod_1(str4, startIndex, "\"pictUrl\":\"", "\",", "}");
                goodsItem.dayLeft = int.Parse(StringUtil.smethod_1(str4, startIndex, "\"dayLeft\":", ",", "}"));
                goodsItem.userType = int.Parse(StringUtil.smethod_1(str4, startIndex, "\"userType\":", ",", "}"));
                goodsItem.biz30day = int.Parse(StringUtil.smethod_1(str4, startIndex, "\"biz30day\":", ",", "}"));
                goodsItem.zkPrice = double.Parse(StringUtil.smethod_1(str4, startIndex, "\"zkPrice\":", ",", "}"));
                goodsItem.eventRate = double.Parse(StringUtil.smethod_1(str4, startIndex, "\"eventRate\":", ",", "}"));
                goodsItem.tkCommFee = double.Parse(StringUtil.smethod_1(str4, startIndex, "\"tkCommFee\":", ",", "}"));
                goodsItem.couponAmount = double.Parse(StringUtil.smethod_1(str4, startIndex, "\"couponAmount\":", ",", "}"));
                goodsItem.couponStartFee = double.Parse(StringUtil.smethod_1(str4, startIndex, "\"couponStartFee\":", ",", "}"));
                goodsItem.couponTotalCount = int.Parse(StringUtil.smethod_1(str4, startIndex, "\"couponTotalCount\":", ",", "}"));
                goodsItem.couponLeftCount = int.Parse(StringUtil.smethod_1(str4, startIndex, "\"couponLeftCount\":", ",", "}"));
                list.Add(goodsItem);
                startIndex++;
            }
            out_log = str4;
            return list;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

    public static ArrayList smethod_58(string string_3)
    {
        string newValue = StringUtil.subString(string_3, 0, "_tb_token_=", ";");
        string address = "http://pub.alimama.com/common/site/generalize/guideList.json?t={timestamp}&pvid=&_tb_token_={_tb_token_}&_input_charset=utf-8";
        address = address.Replace("{timestamp}", current_time() + "").Replace("{_tb_token_}", newValue);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_3);
        string str3 = "";
        byte[] buffer = client.DownloadData(address);
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
        string str5 = "\"" + StringUtil.subString(str3, 0, "\"guideList\":[{\"", "\"") + "\"";
        for (int i = 0; (i = str3.IndexOf(str5, i)) != -1; i++)
        {
            GuideItem class2 = new GuideItem();
            class2.string_0 = StringUtil.subString(str3, i, "\"name\":\"", "\"");
            class2.string_1 = StringUtil.subString(str3, i, "\"memberID\":", ",");
            class2.string_2 = StringUtil.subString(str3, i, "\"guideID\":", ",");
            class2.string_3 = StringUtil.subString(str3, i, "\"siteType\":\"", "\"");
            class2.string_4 = StringUtil.subString(str3, i, "\"category2\":\"", "\"");
            class2.string_5 = StringUtil.subString(str3, i, "\"category3\":\"", "\"");
            list.Add(class2);
        }
        return list;
    }

    public static ArrayList parse_Adzone(string body, int ad_type)
    {

        ArrayList list3 = new ArrayList();
        //JObject jo = (JObject)JsonConvert.DeserializeObject(body);
        try
        {
            JsonData jo = JsonMapper.ToObject(body);
            if (ad_type == 1)
            {
                //JArray webList = (JArray)jo["data"]["webAdzones"];
                JsonData webList = jo["data"]["webAdzones"];
                for (int i = 0; i < webList.Count; i++)
                {
                    JsonData jo_item = (JsonData)webList[i];

                    AdZonesItem adZonesItem = new AdZonesItem();
                    adZonesItem.id = jo_item["id"].ToString();
                    adZonesItem.name = jo_item["name"].ToString();

                    ArrayList subItemList = new ArrayList();
                    if(((IDictionary)jo_item).Contains("sub"))
                    {
                        JsonData subList = jo_item["sub"];
                        for (int j = 0; j < subList.Count; j++)
                        {
                            JsonData sub_item = subList[j];
                            AdZonesSubItem adZonesSubItem = new AdZonesSubItem();
                            adZonesSubItem.id = sub_item["id"].ToString();
                            adZonesSubItem.name = sub_item["name"].ToString();
                            subItemList.Add(adZonesSubItem);
                        }
                    }
                    adZonesItem.sub_list = subItemList;
                    list3.Add(adZonesItem);

                }
            }

            if (ad_type == 3 || ad_type == 4 || ad_type == 5)
            {
                JsonData otherList = jo["data"]["otherList"];
                for (int i = 0; i < otherList.Count; i++)
                {
                    JsonData jo_item = otherList[i];
                    string type = "";
                    if (ad_type == 3) { type = "13"; }
                    if (ad_type == 4) { type = "14"; }
                    if (ad_type == 5) { type = "20"; }
                    if (jo_item["type"].ToString() == type)
                    {
                        JsonData otherAdzones = jo["data"]["otherAdzones"];
                        for (int ii = 0; ii < otherAdzones.Count; ii++)
                        {
                            JsonData jo_item_adzones = otherAdzones[ii];
                            if (jo_item_adzones["id"].ToString() == jo_item["siteid"].ToString())
                            {
                                AdZonesItem adZonesItem = new AdZonesItem();
                                adZonesItem.id = jo_item_adzones["id"].ToString();
                                adZonesItem.name = jo_item_adzones["name"].ToString();
                                ArrayList subItemList = new ArrayList();
                                if (((IDictionary)jo_item_adzones).Contains("sub"))
                                {
                                    JsonData subList = jo_item_adzones["sub"];
                                    for (int j = 0; j < subList.Count; j++)
                                    {
                                        JsonData sub_item = subList[j];
                                        AdZonesSubItem adZonesSubItem = new AdZonesSubItem();
                                        adZonesSubItem.id = sub_item["id"].ToString();
                                        adZonesSubItem.name = sub_item["name"].ToString();
                                        subItemList.Add(adZonesSubItem);
                                    }
                                }
                                adZonesItem.sub_list = subItemList;
                                list3.Add(adZonesItem);

                            }
                        }
                    }

                }
            }
        }
        catch (Exception)
        {
            
        }

        //ArrayList list3 = new ArrayList();
        //JObject jo = (JObject)JsonConvert.DeserializeObject(body);
        //if (ad_type == 1)
        //{
        //    JArray webList = (JArray)jo["data"]["webAdzones"];
        //    for (int i = 0; i < webList.Count;i++ )
        //    {
        //        JObject jo_item = (JObject)webList[i];

        //        AdZonesItem adZonesItem = new AdZonesItem();
        //        adZonesItem.id = jo_item["id"].ToString();
        //        adZonesItem.name = jo_item["name"].ToString();

        //        ArrayList subItemList = new ArrayList();
        //        if (jo_item["sub"]!=null)
        //        {
        //            JArray subList = (JArray)jo_item["sub"];
        //            for (int j = 0; j < subList.Count; j++)
        //            {
        //                JObject sub_item = (JObject)subList[j];
        //                AdZonesSubItem adZonesSubItem = new AdZonesSubItem();
        //                adZonesSubItem.id = sub_item["id"].ToString();
        //                adZonesSubItem.name = sub_item["name"].ToString();
        //                subItemList.Add(adZonesSubItem);
        //            }
        //        }
        //        adZonesItem.sub_list = subItemList;
        //        list3.Add(adZonesItem);

        //    }
        //}
        //if (ad_type == 3 || ad_type == 4)
        //{
        //    JArray otherList = (JArray)jo["data"]["otherList"];
        //    for (int i = 0; i < otherList.Count; i++)
        //    {
        //       JObject jo_item = (JObject)otherList[i];
        //       string type = "";
        //       if (ad_type == 3) { type = "13"; }
        //       if (ad_type == 4) { type = "14"; }
        //       if (jo_item["type"].ToString() == type)
        //       {
        //           JArray otherAdzones = (JArray)jo["data"]["otherAdzones"];
        //           for (int ii = 0; ii < otherAdzones.Count; ii++)
        //           {
        //               JObject jo_item_adzones = (JObject)otherAdzones[ii];
        //               if (jo_item_adzones[ii]["id"].ToString() == jo_item["siteid"].ToString())
        //               {
        //                   AdZonesItem adZonesItem = new AdZonesItem();
        //                   adZonesItem.id = jo_item_adzones["id"].ToString();
        //                   adZonesItem.name = jo_item_adzones["name"].ToString();

        //                   ArrayList subItemList = new ArrayList();
        //                   if (jo_item_adzones["sub"] != null)
        //                   {
        //                       JArray subList = (JArray)jo_item_adzones["sub"];
        //                       for (int j = 0; j < subList.Count; j++)
        //                       {
        //                           JObject sub_item = (JObject)subList[j];
        //                           AdZonesSubItem adZonesSubItem = new AdZonesSubItem();
        //                           adZonesSubItem.id = sub_item["id"].ToString();
        //                           adZonesSubItem.name = sub_item["name"].ToString();
        //                           subItemList.Add(adZonesSubItem);
        //                       }
        //                   }
        //                   adZonesItem.sub_list = subItemList;
        //                   list3.Add(adZonesItem);

        //               }
        //           }
        //       }

        //    }
        //}

        //string str = "";
        //if (ad_type == 1)
        //{
        //    str = "\"webAdzones\":[";
        //}
        //if (ad_type == 2)
        //{
        //    str = "\"appAdzones\":[";
        //}
        //if (ad_type == 3)
        //{
        //    str = "\"otherAdzones\":[";
        //}
        //if (body.IndexOf(str) == -1)
        //{
        //    return new ArrayList();
        //}
        //string str2 = smethod_7(body, str, "[", "]");
        //ArrayList list2 = new ArrayList();
        //while (str2.StartsWith("{"))
        //{
        //    string oldValue = "{" + smethod_7(str2, "{", "{", "}") + "}";
        //    str2 = str2.Replace(oldValue, "").Replace("{}", "");
        //    if (str2.StartsWith(","))
        //    {
        //        str2 = str2.Substring(1);
        //    }
        //    list2.Add(oldValue);
        //}
        //foreach (string str4 in list2)
        //{
        //    string str5 = smethod_7(str4, "\"sub\":[", "[", "]");
        //    if (str5.Equals(""))
        //    {
        //        str5 = "\"sub\":[]";
        //    }
        //    string str6 = str4.Replace(str5, "");
        //    AdZonesItem adZonesItem = new AdZonesItem();
        //    adZonesItem.id = StringUtil.smethod_1(str6, 0, "\"id\":\"", "\"", "}");
        //    adZonesItem.name = StringUtil.subString(str6, 0, "\"name\":\"", "\"");
        //    ArrayList list4 = new ArrayList();
        //    string str7 = "\"" + StringUtil.subString(str5, 0, "{\"", "\"") + "\"";
        //    for (int i = 0; (i = str5.IndexOf(str7, i)) != -1; i++)
        //    {
        //        AdZonesSubItem class3 = new AdZonesSubItem();
        //        class3.id = StringUtil.smethod_1(str5, i, "\"id\":", ",", "}");
        //        class3.name = StringUtil.subString(str5, i, "\"name\":\"", "\"");
        //        list4.Add(class3);
        //    }
        //    adZonesItem.sub_list = list4;
        //    list3.Add(adZonesItem);
        //}
        return list3;
    }

    public static string smethod_7(string string_3, string string_4, string string_5, string string_6)
    {
        try
        {
        int startIndex = string_3.IndexOf(string_4) + string_4.Length;
        if (startIndex == (string_4.Length - 1))
        {
            return "";
        }
        int num2 = 0;
        int num3 = 0;
        for (int i = startIndex; i < string_3.Length; i++)
        {
            string str2 = string_3.Substring(i, 1);
            if (str2.Equals(string_5))
            {
                num3--;
            }
            if (str2.Equals(string_6))
            {
                num3++;
            }
            if (num3 == 1)
            {
                num2 = i;
                break;
            }
        }
        return string_3.Substring(startIndex, num2 - startIndex);
        }
        catch (Exception)
        {
            
        }
        return "";
    }

    public static ArrayList smethod_8(string string_3, string string_4)
    {
        string format = "http://pub.alimama.com/pubshop/shopKeeperHotProducts.json?sortField=_totalnum&oid={0}";
        string address = string.Format(format, string_3);
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_4);
        string str3 = "";
        byte[] buffer = client.DownloadData(address);
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
        for (int i = 0; (i = str3.IndexOf("\"title\"", i)) != -1; i++)
        {
            GoodsItem3 class2 = new GoodsItem3();
            class2.title = StringUtil.subString(str3, i, "\"title\":\"", "\"");
            class2.num_iid = StringUtil.subString(str3, i, "\"auctionId\":\"", "\"");
            list.Add(class2);
        }
        return list;
    }

    public static ArrayList query_taoke_goods_list(string url, string taoke_cookie,out string out_log)
    {
        string newValue = StringUtil.subString(taoke_cookie, 0, "_tb_token_=", ";");
        string str2 = "http://pub.alimama.com/items/search.json?q={seachkey}&t={timestamp}&auctionTag=&perPageSize=40&shopTag=&t={timestamp}&_tb_token_={token}&pvid={pvid}";
        str2 = "http://pub.alimama.com/items/search.json?q={seachkey}&_t={timestamp}&auctionTag=&perPageSize=40&shopTag=&t={timestamp}&_tb_token_={token&pvid={pvid}";
        str2 = "http://pub.alimama.com/items/search.json?q={seachkey}&_t={timestamp}&auctionTag=&perPageSize=40&shopTag=&t={timestamp}&_tb_token_=test&pvid={pvid}";
        string address = str2.Replace("{seachkey}", HttpUtility.UrlEncode(url)).Replace("{timestamp}", current_time() + "").Replace("{token}", newValue).Replace("{pvid}", query_pvid(taoke_cookie));
        string str4 = "http://pub.alimama.com/promo/search/index.htm?q={seachkey}&_t={timestamp}";
        string str5 = str4.Replace("{seachkey}", HttpUtility.UrlEncode(url)).Replace("{timestamp}", current_time() + "");
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36");
        client.Headers.Add("Referer", str5);
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        //client.Headers.Add("Cookie", taoke_cookie);
        string str6 = "";
        byte[] buffer = client.DownloadData(address);
        string str7 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str7))
        {
            str6 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str6 = Encoding.UTF8.GetString(buffer);
        }
        ArrayList list = new ArrayList();
        for (int i = 0; (i = str6.IndexOf("\"tkSpecialCampaignIdRateMap\"", i)) != -1; i++)
        {
            GoodsItem2 class2 = new GoodsItem2();
            class2.num_iid = StringUtil.smethod_1(str6, i, "\"auctionId\":", ",", "}");
            class2.title = StringUtil.smethod_1(str6, i, "\"title\":\"", "\",", "}");
            class2.shop_title = StringUtil.smethod_1(str6, i, "\"shopTitle\":\"", "\",", "}");
            class2.user_num_id = StringUtil.smethod_1(str6, i, "\"sellerId\":", ",", "}");
            class2.pictUrl = StringUtil.smethod_1(str6, i, "\"pictUrl\":\"", "\",", "}");
            class2.dayLeft = int.Parse(StringUtil.smethod_1(str6, i, "\"dayLeft\":", ",", "}"));
            class2.userType = int.Parse(StringUtil.smethod_1(str6, i, "\"userType\":", ",", "}"));
            class2.biz30day = int.Parse(StringUtil.smethod_1(str6, i, "\"biz30day\":", ",", "}"));
            class2.zkPrice = double.Parse(StringUtil.smethod_1(str6, i, "\"zkPrice\":", ",", "}"));
            //class2.eventRate = double.Parse(StringUtil.smethod_1(str6, i, "\"eventRate\":", ",", "}"));
            class2.tkCommFee = double.Parse(StringUtil.smethod_1(str6, i, "\"tkCommFee\":", ",", "}"));
            class2.tkRate = double.Parse(StringUtil.smethod_1(str6, i, "\"tkRate\":", ",", "}"));
            list.Add(class2);
        }
        out_log = str6;
        return list;
    }

    public static ArrayList smethod_17(string string_3, string string_4, out string string_5)
    {
        ArrayList arrayLists = AlimamaUtil.smethod_19(string.Concat("http://item.taobao.com/item.htm?id=", string_3), "", string_4, out string_5);
        return arrayLists;
    }

    public static ArrayList smethod_19(string string_3, string string_4, string string_5, out string string_6)
    {
        ArrayList arrayLists;
        string str = StringUtil.subString(string_5, 0, "_tb_token_=", ";");
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
        webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
        webClient.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm");
        webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        webClient.Headers.Add("Cookie", string_5);
        string str1 = "http://pub.alimama.com/items/search.json?q={schKey}&auctionTag={pageNo}&perPageSize=40&shopTag=&t={timestamp}&_tb_token_={tbToken}&pvid={pvid}";
        //str1 = str1.Replace("{schKey}", HttpUtility.UrlEncode(string_3)).Replace("{pageNo}", string_4).Replace("{tbToken}", str).Replace("{timestamp}", string.Concat(GClass43.smethod_57(), "")).Replace("{pvid}", GClass43.smethod_28(string_5));
        string str2 = "";
        byte[] numArray = webClient.DownloadData(str1);
        //str2 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : GClass35.smethod_2(numArray, Encoding.UTF8));
        ArrayList arrayLists1 = new ArrayList();
        if (str2.IndexOf("\"length\":0") == -1)
        {
            //string str3 = string.Concat("\"", StringUtil.smethod_2(str2, 0, "\"pageList\":[{\"", "\""), "\"");
            //int num = 0;
            //while (true)
            //{
            //    int num1 = str2.IndexOf(str3, num);
            //    num = num1;
            //    if (num1 == -1)
            //    {
            //        break;
            //    }
            //    GoodsItem5 goodsItem5 = new GoodsItem5()
            //    {
            //        string_0 = StringUtil.subString(str2, num, "\"sellerId\":\"", "\"")
            //    };
            //    if ("".Equals(gClass54.string_0))
            //    {
            //        gClass54.string_0 = StringUtil.subString(str2, num, "\"sellerId\":", ",");
            //    }
            //    goodsItem5.string_1 = GClass35.smethod_1(StringUtil.subString(str2, num, "\"title\":\"", "\","));
            //    goodsItem5.string_2 = GClass35.smethod_1(StringUtil.subString(str2, num, "\"pictUrl\":\"", "\","));
            //    goodsItem5.string_4 = StringUtil.subString(str2, num, "\"zkPrice\":", ",");
            //    goodsItem5.string_3 = StringUtil.subString(str2, num, "\"reservePrice\":", ",");
            //    goodsItem5.string_5 = StringUtil.subString(str2, num, "\"userType\":", ",");
            //    goodsItem5.string_6 = StringUtil.subString(str2, num, "\"nick\":\"", "\"");
            //    goodsItem5.string_7 = StringUtil.subString(str2, num, "\"auctionId\":\"", "\"");
            //    if ("".Equals(goodsItem5.string_7))
            //    {
            //        goodsItem5.string_7 = StringUtil.subString(str2, num, "\"auctionId\":", ",");
            //    }
            //    goodsItem5.string_8 = StringUtil.subString(str2, num, "\"tkRate\":", ",");
            //    try
            //    {
            //        goodsItem5.int_0 = int.Parse(StringUtil.subString(str2, num, "\"includeDxjh\":", ","));
            //    }
            //    catch
            //    {
            //    }
            //    try
            //    {
            //        goodsItem5.int_1 = int.Parse(StringUtil.subString(str2, num, "\"totalNum\":", ","));
            //    }
            //    catch
            //    {
            //    }
            //    arrayLists1.Add(gClass54);
            //    num++;
            //}
            //if (arrayLists1.Count != 0)
            //{
            //    string_6 = "";
            //}
            //else
            //{
            string_6 = str2;
            //}
            arrayLists = arrayLists1;
        }
        else
        {
            string_6 = "";
            arrayLists = arrayLists1;
        }
        return arrayLists;
    }

    public static void online(object cookie)
    {
        string object0 = (string)cookie;
        ArrayList arrayLists = new ArrayList();
        arrayLists.Add("http://pub.alimama.com/myunion.htm?spm=a219t.7900221/1.1998910419.dbb742793.6C0fHO#!/manage/site/site");
        arrayLists.Add("http://media.alimama.com/account/overview.htm?spm=0.0.0.0.BG2JPN");
        arrayLists.Add("http://media.alimama.com/violation/violation_list.htm?spm=0.0.0.0.mWzIgu");
        arrayLists.Add("http://media.alimama.com/user/base_info.htm?spm=0.0.0.0.n95eyQ");
        arrayLists.Add("http://media.alimama.com/account/account.htm?spm=0.0.0.0.Bgl2E0");
        arrayLists.Add("http://media.alimama.com/account/drawback_search.htm?spm=0.0.0.0.2eOKdb");
        arrayLists.Add("http://media.alimama.com/taokedai/taokedai.htm?spm=0.0.0.0.sXFDwV");
        arrayLists.Add("http://pub.alimama.com/manage/selection/list.htm?spm=a219t.7664554.a214tr8.3.ua1D9x");
        arrayLists.Add("http://pub.alimama.com/promo/search/index.htm?spm=a219t.7900221/1.1998910419.de727cf05.tU5rv3&toPage=1&queryType=2");
        arrayLists.Add("http://pub.alimama.com/manage/zhaoshang/list.htm?spm=a219t.7900221%2F10.a214tr8.4.m9suYn");
        arrayLists.Add("http://pub.alimama.com/tkschool.htm?spm=a219t.7900221/11.1998910419.3.Lv1zS9");
        arrayLists.Add("http://open.alimama.com/?spm=a219t.7677381.a3341.4.wJBypu");
        arrayLists.Add("http://open.alimama.com/api/tdjdemo.php");
        arrayLists.Add("http://club.alimama.com/?spm=a219t.7677381.a3341.5.wJBypu");

        string newValue = StringUtil.subString(object0, 0, "_tb_token_=", ";");

        Random random = new Random();
        string str = "";
        while (true)
        {
            try
            {
                int num = random.Next(0, arrayLists.Count);
                string item = (string)arrayLists[num];
                if (str.Equals(""))
                {
                    str = "http://www.alimama.com/index.htm?spm=a2320.7388781.a214tr8.d006.dDoVNS";
                }
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                webClient.Headers.Add("Referer", str);
                webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                webClient.Headers.Add("Cookie", object0);
                byte[] numArray = webClient.DownloadData(item);
                if (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]))
                {
                    Encoding.UTF8.GetString(numArray);
                }
                else
                {
                    GzipUtil.zip_to_string(numArray, Encoding.UTF8);
                }

                item = "http://pub.alimama.com/common/auths.json?authIds=1%2C4%2C5&t={timestamp}&pvid={pvid}&_tb_token_={token}&_input_charset=utf-8";
                item = item.Replace("{timestamp}", current_time() + "").Replace("{token}", newValue).Replace("{pvid}", query_pvid(object0));
                webClient = new WebClient();
                webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                webClient.Headers.Add("Referer", str);
                webClient.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                webClient.Headers.Add("Cookie", object0);
                numArray = webClient.DownloadData(item);
                if (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]))
                {
                    Encoding.UTF8.GetString(numArray);
                }
                else
                {
                    GzipUtil.zip_to_string(numArray, Encoding.UTF8);
                }

                str = item;
            }
            catch
            {
            }
            Thread.Sleep(300000);
        }
    }

    public static KoulingBean get_kouling(string activityId, string itemId, string pid, string dx, out string out_log)
    {
        out_log = "";
        string money;
        string ctoken = AlimamaUtil.smethod_61(activityId, itemId, pid, dx, out out_log);
        string str1 = AlimamaUtil.smethod_62(ctoken, activityId, itemId, pid, dx, out out_log, out money);
        string str2 = AlimamaUtil.smethod_63(ctoken, activityId, itemId, pid, str1, dx, out out_log);
        string str3 = StringUtil.subString(str2, 0, "_m_h5_tk=", ";");
        string str4 = AlimamaUtil.smethod_64(ctoken, activityId, itemId, pid, str1, dx, str3, str2, out out_log);
        KoulingBean koulingBean = new KoulingBean()
        {
            password = StringUtil.subString(str4, 0, "\"password\":\"", "\""),
            url = StringUtil.subString(str4, 0, "\"url\":\"", "\"")
        };
        return koulingBean;
    }


    public static string smethod_61(string activityId, string itemId, string pid, string dx, out string out_log)
    {
        out_log = "";
        string str = "https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=haopintui&dx={dx}";
        str = str.Replace("{activityId}", activityId).Replace("{itemId}", itemId).Replace("{pid}", pid).Replace("{dx}", dx);
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        webClient.Headers.Add("Cookie", "thw=cn");
        string str1 = "";
        byte[] numArray = webClient.DownloadData(str);
        string item = webClient.ResponseHeaders["Set-Cookie"];
        string str2 = StringUtil.subString(item, 0, "ctoken=", ";");
        str1 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : StringUtil.byte_to_str(numArray, Encoding.UTF8));
        out_log = str1;
        return str2;
    }

    public static string smethod_62(string string_3, string string_4, string string_5, string string_6, string string_7, out string string_8, out string money)
    {
        string_8 = "";
        money = "";
        string str = "https://uland.taobao.com/cp/coupon?ctoken={ctoken}&activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}";
        str = str.Replace("{ctoken}", string_3).Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{dx}", string_7);
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Accept", "*/*");
        webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        string str1 = "https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}";
        str1 = str1.Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{dx}", string_7);
        webClient.Headers.Add("Referer", str1);
        webClient.Headers.Add("Cookie", string.Concat("thw=cn; ctoken=", string_3));
        string str2 = "";
        byte[] numArray = webClient.DownloadData(str);
        str2 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : StringUtil.byte_to_str(numArray, Encoding.UTF8));
        string_8 = str2;
        string str3 = StringUtil.subString(str2, 0, "\"title\":\"", "\",");
        string str4 = StringUtil.subString(str2, 0, "\"discountPrice\":", ",");
        string str5 = StringUtil.subString(str2, 0, "\"amount\":", ",");
        money = str5;
        string[] strArrays = new string[] { str3, "原价", str4, "元，抢券立省", str5, "元" };
        return string.Concat(strArrays);
    }

    private static string smethod_63(string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, out string string_9)
    {
        string_9 = "";
        string str = "{\"url\":\"https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}\",\"passwordType\":\"tao\",\"sourceType\":\"other\",\"title\":\"{title}\",\"bizId\":\"mama-taobaolianmeng\"}";
        str = str.Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{title}", string_6).Replace("{dx}", string_8);
        string str1 = "https://api.m.taobao.com/h5/mtop.taobao.wireless.share.password.getpasswordshareinfo/1.0/?v=1.0&api=mtop.taobao.wireless.share.password.getpasswordshareinfo&appKey=12574478&t={timestamp}&callback=mtopjsonp1&type=jsonp&sign=6084fb5b61299b17dad1b2c7410e9040&data={data}";
        str1 = str1.Replace("{timestamp}", string.Concat(AlimamaUtil.current_time(), "")).Replace("{data}", HttpUtility.UrlEncode(str));
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        string str2 = "https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}";
        str2 = str2.Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{dx}", string_8);
        webClient.Headers.Add("Referer", str2);
        webClient.Headers.Add("Cookie", string.Concat("thw=cn; ctoken=", string_3));
        string str3 = "";
        byte[] numArray = webClient.DownloadData(str1);
        str3 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : StringUtil.byte_to_str(numArray, Encoding.UTF8));
        string_9 = str3;
        string item = webClient.ResponseHeaders["Set-Cookie"];
        string str4 = StringUtil.subString(item, 0, "_m_h5_tk=", ";");
        string str5 = StringUtil.subString(item, 0, "_m_h5_tk_enc=", ";");
        return string.Concat("_m_h5_tk=", str4, "; _m_h5_tk_enc=", str5);
    }

    private static string smethod_64(string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, out string string_11)
    {
        string_11 = "";
        string str = "{\"url\":\"https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}\",\"passwordType\":\"tao\",\"sourceType\":\"other\",\"title\":\"{title}\",\"bizId\":\"mama-taobaolianmeng\"}";
        str = str.Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{title}", string_7).Replace("{dx}", string_8);
        string str1 = string.Concat(AlimamaUtil.current_time(), "");
        string str2 = AlimamaUtil.smethod_65(string_9, str1, str);
        string str3 = "https://api.m.taobao.com/h5/mtop.taobao.wireless.share.password.getpasswordshareinfo/1.0/?v=1.0&api=mtop.taobao.wireless.share.password.getpasswordshareinfo&appKey=12574478&t={timestamp}&callback=mtopjsonp1&type=jsonp&sign={sign}&data={data}";
        str3 = str3.Replace("{timestamp}", string.Concat(str1, "")).Replace("{sign}", str2).Replace("{data}", HttpUtility.UrlEncode(str));
        WebClient webClient = new WebClient();
        webClient.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        webClient.Headers.Add("Upgrade-Insecure-Requests", "1");
        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        string str4 = "https://uland.taobao.com/coupon/edetail?activityId={activityId}&pid={pid}&itemId={itemId}&src=hpt_hptzs&dx={dx}";
        str4 = str4.Replace("{activityId}", string_4).Replace("{itemId}", string_5).Replace("{pid}", string_6).Replace("{dx}", string_8);
        webClient.Headers.Add("Referer", str4);
        string str5 = CookieUtil.get_cookie("http://www.taobao.com");
        string_11 = string.Concat("taobaoCookie：【", str5, "】");
        string str6 = "";
        string str7 = "";
        string str8 = "";
        try
        {
            str6 = StringUtil.subString(str5, 0, "l=", ";");
            str7 = StringUtil.subString(str5, 0, "cna=", ";");
            str8 = StringUtil.subString(str5, 0, "isg=", ";");
        }
        catch
        {
        }
        WebHeaderCollection headers = webClient.Headers;
        string[] string3 = new string[] { "thw=cn; ctoken=", string_3, "; ", string_10, "; l=", str6, "; cna=", str7, " ; isg=", str8 };
        headers.Add("Cookie", string.Concat(string3));
        string str9 = "";
        byte[] numArray = webClient.DownloadData(str3);
        str9 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : StringUtil.byte_to_str(numArray, Encoding.UTF8));
        string_11 = string.Concat(string_11, str9);
        return str9;
    }

    public static string smethod_65(string string_3, string string_4, string string_5)
    {
        char[] chrArray = new char[] { '\u005F' };
        string_3 = string_3.Split(chrArray)[0];
        MD5 mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
        string[] string3 = new string[] { string_3, "&", string_4, "&12574478&", string_5 };
        string str = string.Concat(string3);
        byte[] numArray = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(str));
        Encoding.UTF8.GetString(numArray);
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < (int)numArray.Length; i++)
        {
            stringBuilder.Append(numArray[i].ToString("x2"));
        }
        return stringBuilder.ToString();
    }

    public static AlimamaBean get_AlimamaBean( string cookie, out string out_log)
    {
        try
        {
            string tb_token = StringUtil.subString(cookie, 0, "_tb_token_=", ";");
            string str1 = string.Concat(AlimamaUtil.current_time(), "");
            WebClient client = new WebClient();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string body = "";
            byte[] buffer = client.DownloadData("http://pub.alimama.com/overview/unionaccountinfo.json?t=" + str1 + "&pvid=&_tb_token_=" + tb_token + "&_input_charset=utf-8");
            string str3 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str3))
            {
                body = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                body = Encoding.UTF8.GetString(buffer);
            }
            if (body.Contains("curMonthTotal"))
            {
                AlimamaBean alimamaBean = new AlimamaBean();
                alimamaBean.lastMonthTotal = StringUtil.subString(body, 0, "\"lastMonthTotal\":", ",");
                alimamaBean.curMonthTotal = StringUtil.subString(body, 0, "\"curMonthTotal\":", ",");
                alimamaBean.yesterdayTotal = StringUtil.subString(body, 0, "\"yesterdayTotal\":", ",");
                //class2.num_iid = num_iid;
                out_log = "";
                return alimamaBean;
            }
            out_log = body;
            return null;
        }
        catch (Exception exception)
        {
            out_log = "出错啦！！！" + exception.ToString();
            return null;
        }
    }

}

