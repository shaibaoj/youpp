using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

public class TaobaoUtil
{
    public static int int_0 = 1;
    public static int int_1 = 3;
    public static Regex regex_0 = new Regex(@"^\d+$");
    public static string string_0 = "<[^>]*>";

    public static bool smethod_0(string string_1)
    {
        string str = "";
        Directory.GetCurrentDirectory();
        string address = "https://buyertrade.taobao.com/trade/itemlist/list_bought_items.htm";
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_1);
        byte[] buffer = client.DownloadData(address);
        string str3 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str3))
        {
            return GzipUtil.zip_to_string(buffer, Encoding.GetEncoding("GB2312")).Contains("<title>已买到的宝贝</title>");
        }
        str = Encoding.GetEncoding("GB2312").GetString(buffer);
        return false;
    }

    public static CouponItem get_coupon( string coupon_url, String num_iid, String pid,out string money)
    {
        money = "";
        CouponItem class2 = null;
        if (!(coupon_url.Contains("coupon") && coupon_url.Contains("taobao.com")))
        {
            coupon_url = get_redirect_url(coupon_url, coupon_url);
        }
        coupon_url = HttpUtility.UrlDecode(coupon_url);
        coupon_url = coupon_url.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
        string seller_id = StringUtil.subString(coupon_url, 0, "sellerId=", "&");
        string activity_id = StringUtil.subString(coupon_url, 0, "activityId=", "&");

        if (!string.IsNullOrEmpty(seller_id)
            && !string.IsNullOrEmpty(activity_id)
            && !string.IsNullOrEmpty(num_iid)
             && !string.IsNullOrEmpty(pid))
        {
            class2 = new CouponItem();
            string out_log;
            string ctoken = AlimamaUtil.smethod_61(activity_id, num_iid, pid, "1", out out_log);
            string str1 = AlimamaUtil.smethod_62(ctoken, activity_id, num_iid, pid, "1", out out_log, out money);
            try
            {
                class2.money = (int)double.Parse(money);
                class2.leftCount = 100000;
            }
            catch
            {
                class2.money = 0;
            }
            return class2;
        }

        string str3 = "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}";
        string address = str3.Replace("{seller_id}", seller_id).Replace("{activity_id}", activity_id);
        WebClient client = new WebClient();
        client.Headers.Add("user-agent", "Mozilla/5.0 (iPad; U; CPU OS 3_2_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B500 Safari/531.21.10");
        byte[] buffer = client.DownloadData(address);
        string str5 = "";
        string str6 = client.ResponseHeaders["Content-Encoding"];
        if ("gzip".Equals(str6))
        {
            str5 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
        }
        else
        {
            str5 = Encoding.UTF8.GetString(buffer);
        }
         class2 = new CouponItem();
        if (!str5.Contains("该优惠券不存在或者已经过期"))
        {
            int index = str5.IndexOf("元优惠券");
            int length = 1;
            while (regex_0.IsMatch(str5.Substring(index - length, length)))
            {
                length++;
            }
            length--;
            try
            {
                class2.money = int.Parse(str5.Substring(index - length, length));
            }
            catch
            {
                class2.money = 0;
            }
            try
            {
                class2.leftCount = int.Parse(StringUtil.subString(str5, 0, "<span class=\"rest\">", "</span>"));
            }
            catch
            {
                class2.leftCount = 0;
            }
            try
            {
                class2.receiveCount = int.Parse(StringUtil.subString(str5, 0, "<span class=\"count\">", "</span>"));
            }
            catch
            {
                class2.receiveCount = 0;
            }
            class2.endTime = StringUtil.subString(str5, 0, "<dd>有效期:", "</dd>");
        }
        return class2;
    }

    public static ArrayList query_goods_comment(string string_1, string string_2, string string_3, string string_4, string string_5, int int_2, out string string_6)
    {
        string str = "";
        try
        {
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            client.Headers.Add("Cookie", string_4);
            string str2 = client.DownloadString("http://item.taobao.com:80/item.htm?id=" + string_1);
            bool flag = str2.IndexOf("天猫</title>") != -1;
            int startIndex = str2.IndexOf("sellerId") + 10;
            int length = str2.IndexOf(flag ? "\"" : ",", startIndex) - startIndex;
            string newValue = str2.Substring(startIndex, length).Replace(" ", "").Replace("'", "").Replace(":", "");
            string str4 = "https://rate.taobao.com/feedRateList.htm?auctionNumId={itemId}&userNumId={sellerId}&currentPageNum={currentPage}&pageSize=20&rateType=&orderType=feedbackdate&showContent=1&attribute=&sku=&hasSku=false&folded=0&_ksTS=1465821754822_2153&callback=jsonp_tbcrate_reviews_list";
            if (flag)
            {
                str4 = "https://rate.tmall.com/list_detail_rate.htm?sellerId={sellerId}&itemId={itemId}&order=3&currentPage={currentPage}&append=0&content=1&tagId=&posi=&picture=";
            }
            ArrayList list = new ArrayList();
            int num4 = 1;
        Label_00FC:
            Thread.Sleep(int.Parse(string_5));
            client.Headers.Clear();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            if (flag)
            {
            }
            client.Headers.Add("Referer", "https://detail.tmall.com/item.htm?id=" + string_1);
            client.Headers.Add("Cookie", string_4);
            string address = str4.Replace("{sellerId}", newValue).Replace("{itemId}", string_1).Replace("{currentPage}", num4 + "");
            str = client.DownloadString(address);
            if (!str.Contains(flag ? "\"rateList\":[]" : "\"comments\":[]"))
            {
                if (str.Contains("\"url\":\"https://sec.taobao.com"))
                {
                    string_6 = str;
                    return null;
                }
                smethod_11(flag, list, str, string_3);
                int num5 = int.Parse(StringUtil.subString(str, 0, flag ? "\"lastPage\":" : "\"maxPage\":", ","));
                if ((num4 < num5) && ((smethod_13(list, string_3) < int.Parse(string_2)) && (num4 <= int_2)))
                {
                    num4++;
                    goto Label_00FC;
                }
            }
            smethod_19(list);
            string_6 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_6 = "【" + str + "】，" + exception.ToString();
            return null;
        }
    }

    private static void smethod_11(bool bool_0, ArrayList arrayList_0, string string_1, string string_2)
    {
        // This item is obfuscated and can not be translated.
        string str = StringUtil.subString(string_1, 0, bool_0 ? "\"rateList\":[{\"" : "\"comments\":[{\"", "\"");
        str = "\"" + str + "\":";
        for (int i = 0; (i = string_1.IndexOf(str, i)) != -1; i++)
        {
            string str3;
            int index = string_1.IndexOf(str, (int) (i + 1));
            if (index == -1)
            {
                index = string_1.Length;
            }
            string str2 = string_1.Substring(i, index - i);
            int startIndex = 0;
            while (true)
            {
                if (bool_0)
                {
                }
                startIndex = str2.IndexOf("\"rateContent\":\"", startIndex);
                if (startIndex != -1)
                {
                    if (bool_0)
                    {
                        startIndex += 15;
                    }
                    else
                    {
                        startIndex += 11;
                    }
                    int num5 = str2.IndexOf("\",", startIndex);
                    int num6 = str2.IndexOf("\"},", startIndex);
                    int num7 = num5;
                    if ((num7 > num6) && (num6 != -1))
                    {
                        num7 = num6;
                    }
                    str3 = toText(str2.Substring(startIndex, num7 - startIndex));
                    if (!str3.Contains("评价方未及时做出评价") && !str3.Equals("好评！"))
                    {
                        if (str3.Length >= int.Parse(string_2))
                        {
                            break;
                        }
                        startIndex++;
                    }
                }
            }
            string str4 = StringUtil.subString(str2, 0, bool_0 ? "\"id\":" : "\"rateId\":", ",");
            string str5 = StringUtil.subString(str2, 0, bool_0 ? "\"displayUserNick\":\"" : "\"nick\":\"", "\"");
            string str6 = StringUtil.subString(str2, 0, bool_0 ? "\"rateDate\":\"" : "\"date\":\"", "\"");
            if (!bool_0)
            {
                str6 = str6.Replace("年", "-").Replace("月", "-").Replace("日", "") + ":00";
            }
            GoodsComment class2 = new GoodsComment();
            class2.string_0 = str4;
            class2.string_1 = str6;
            class2.string_2 = str5;
            class2.string_3 = str3;
            smethod_12(arrayList_0, class2);
        }
    }

    private static void smethod_12(ArrayList arrayList_0, GoodsComment gclass27_0)
    {
        bool flag = false;
        //using (IEnumerator enumerator = arrayList_0.GetEnumerator())
        IEnumerator enumerator = arrayList_0.GetEnumerator();
        {
            while (enumerator.MoveNext())
            {
                GoodsComment current = (GoodsComment) enumerator.Current;
                if (current.string_3.Equals(gclass27_0.string_3))
                {
                    goto Label_0038;
                }
            }
            goto Label_0050;
        Label_0038:
            flag = true;
        }
    Label_0050:
        if (!flag)
        {
            arrayList_0.Add(gclass27_0);
        }
    }

    private static int smethod_13(ArrayList arrayList_0, string string_1)
    {
        int num = 0;
        foreach (GoodsComment class2 in arrayList_0)
        {
            if (class2.string_3.Length >= int.Parse(string_1))
            {
                num++;
            }
        }
        return num;
    }

    public static ArrayList smethod_14(string string_1, string string_2, string string_3, string string_4, string string_5)
    {
        return smethod_15(string_1, string_2, string_3, string_4, string_5, 5);
    }

    public static ArrayList smethod_15(string string_1, string string_2, string string_3, string string_4, string string_5, int int_2)
    {
        // This item is obfuscated and can not be translated.
        WebClient client = new WebClient();
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
        client.Headers.Add("Cookie", string_4);
        string str = client.DownloadString("http://item.taobao.com:80/item.htm?id=" + string_1);
        bool flag = str.IndexOf("天猫</title>") != -1;
        int startIndex = str.IndexOf("sellerId") + 10;
        int length = str.IndexOf(flag ? "\"" : ",", startIndex) - startIndex;
        string newValue = str.Substring(startIndex, length).Replace(" ", "").Replace("'", "").Replace(":", "");
        string str3 = "https://rate.taobao.com/feedRateList.htm?auctionNumId={itemId}&userNumId={sellerId}&currentPageNum={currentPage}&pageSize=20&rateType=&orderType=feedbackdate&showContent=1&attribute=&sku=&hasSku=false&folded=0&_ksTS=1465821754822_2153&callback=jsonp_tbcrate_reviews_list";
        if (flag)
        {
            str3 = "https://rate.tmall.com/list_detail_rate.htm?sellerId={sellerId}&itemId={itemId}&order=3&currentPage={currentPage}&append=0&content=1&tagId=&posi=&picture=";
        }
        ArrayList list = new ArrayList();
        int num4 = 1;
    Label_00F3:
        Thread.Sleep(int.Parse(string_5));
        client.Headers.Clear();
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17");
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
        if (flag)
        {
        }
        client.Headers.Add("Referer", "https://detail.tmall.com/item.htm?id=" + string_1);
        client.Headers.Add("Cookie", string_4);
        string address = str3.Replace("{sellerId}", newValue).Replace("{itemId}", string_1).Replace("{currentPage}", num4 + "");
        string str5 = client.DownloadString(address);
        if (!str5.Contains(flag ? "\"rateList\":[]" : "\"comments\":[]"))
        {
            smethod_17(flag, list, str5, string_3);
            int num5 = int.Parse(StringUtil.subString(str5, 0, flag ? "\"lastPage\":" : "\"maxPage\":", ","));
            if ((num4 < num5) && ((smethod_16(list, string_3) < int.Parse(string_2)) && (num4 <= int_2)))
            {
                num4++;
                goto Label_00F3;
            }
        }
        smethod_19(list);
        return list;
    }

    private static int smethod_16(ArrayList arrayList_0, string string_1)
    {
        int num = 0;
        foreach (string str in arrayList_0)
        {
            if (str.Length >= int.Parse(string_1))
            {
                num++;
            }
        }
        return num;
    }

    private static void smethod_17(bool bool_0, ArrayList arrayList_0, string string_1, string string_2)
    {
        int num6;
        string str = bool_0 ? "\"rateContent\":\"" : "\"content\":\"";
        for (int i = 0; (i = string_1.IndexOf(str, i)) != -1; i = num6)
        {
            int startIndex = i + 11;
            if (bool_0)
            {
                startIndex += 15;
            }
            int index = string_1.IndexOf("\",", startIndex);
            int num5 = string_1.IndexOf("\"},", startIndex);
            num6 = index;
            if ((num6 > num5) && (num5 > 0))
            {
                num6 = num5;
            }
            string str2 = toText(string_1.Substring(startIndex, num6 - startIndex));
            if ((!str2.Contains("评价方未及时做出评价") && !str2.Equals("好评！")) && (str2.Length >= int.Parse(string_2)))
            {
                smethod_18(arrayList_0, str2);
            }
        }
    }

    private static void smethod_18(ArrayList arrayList_0, string string_1)
    {
        bool flag = false;
       // using (IEnumerator enumerator = arrayList_0.GetEnumerator())
        IEnumerator enumerator = arrayList_0.GetEnumerator();
        {
            while (enumerator.MoveNext())
            {
                string current = (string) enumerator.Current;
                if (current.Equals(string_1))
                {
                    goto Label_002E;
                }
            }
            goto Label_0046;
        Label_002E:
            flag = true;
        }
    Label_0046:
        if (!flag)
        {
            arrayList_0.Add(string_1);
        }
    }

    private static void smethod_19(ArrayList arrayList_0)
    {
        for (int i = 0; i < (arrayList_0.Count - 1); i++)
        {
            for (int j = i; j < arrayList_0.Count; j++)
            {
                if (arrayList_0[i].ToString().Length < arrayList_0[j].ToString().Length)
                {
                    string str = (string) arrayList_0[i];
                    arrayList_0[i] = arrayList_0[j];
                    arrayList_0[j] = str;
                }
            }
        }
    }

    public static ArrayList smethod_2(string string_1)
    {
        string str = "https://qing.taobao.com/json/tg/ajaxGetItemsV2.json?type=0&salesSite=3&platformIds=34033%2C34032&timeFilter=now&stype=rank0&psize=100&page={pageno}&callback=jsonp48";
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8,en-US;q=0.5,en;q=0.3");
        client.Headers.Add("X-Requested-With", "XMLHttpRequest");
        client.Headers.Add("Referer", "https://qing.taobao.com");
        client.Headers.Add("Cookie", string_1);
        ArrayList list = new ArrayList();
        int num2 = 1;
        while (true)
        {
            string address = str.Replace("{pageno}", num2 + "");
            string str2 = GzipUtil.zip_to_string(client.DownloadData(address), Encoding.UTF8);
            for (int i = 0; (i = str2.IndexOf("\"baseinfo\"", i)) != -1; i++)
            {
                GoodsItem1 class2 = new GoodsItem1();
                class2.num_iid = StringUtil.subString(str2, i, "\"itemId\":", ",");
                class2.title = StringUtil.subString(str2, i, "\"title\":\"", "\"");
                class2.user_num_id = StringUtil.subString(str2, i, "\"sellerId\":", ",");
                class2.price = StringUtil.subString(str2, i, "\"actPrice\":\"", "\"");
                list.Add(class2);
            }
            string s = StringUtil.subString(str2, 0, "\"totalPage\":", ",");
            if (num2 >= int.Parse(s))
            {
                return list;
            }
            num2++;
        }
    }

    public static string toText(string string_1)
    {
        return Regex.Replace(string_1, string_0, "").Replace(@"\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "").Replace("\n", "").Replace("\r", "").Replace("u0001", "").Replace("&hellip;", "...");
    }

    public static string get_redirect_url(string url, string referer_url)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        if (url.Contains("coupon") && url.Contains("taobao.com"))
        {
            request.UserAgent = "Mozilla/5.0 (iPad; U; CPU OS 3_2_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B500 Safari/531.21.10";
        }
        else
        {
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.17 (KHTML, like Gecko) Chrome/24.0.1312.57 Safari/537.17";
        }
        request.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
        request.Referer = referer_url;
        request.Headers.Add("Accept-Language", "zh-cn");
        string cookie = CookieUtil.get_cookie("http://www.taobao.com");
        request.Headers.Add("Cookie", cookie);
        request.AllowAutoRedirect = false;
        request.Method = "GET";
        request.Timeout = 0x7d0;
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string str2 = reader.ReadToEnd();
        response.Close();
        reader.Close();
        if (HttpStatusCode.Found.Equals(response.StatusCode) || HttpStatusCode.MovedPermanently.Equals(response.StatusCode))
        {
            string str3 = response.Headers.Get("Location").ToString();
            if (str3.Contains("/t_js?tu="))
            {
                return get_redirect_url(smethod_22(str3.Split(new char[] { '=' })[1]), str3);
            }
            if (str3.Contains("coupon") && str3.Contains("taobao.com"))
            {
                return str3;
            }
            if (str3.Contains("item.htm?id="))
            {
                return str3;
            }
            if (str3.Contains("detail.ju.taobao.com"))
            {
                return str3;
            }
            if ((((str3.Contains("taobao.com") || str3.Contains("tmall.com")) || str3.Contains("yao.95095.com")) && str3.Contains("item.htm")) && str3.Contains("id="))
            {
                return str3;
            }
            if (str3.Contains("shop/view_shop.htm?user_number_id="))
            {
                return str3;
            }
            return get_redirect_url(str3, str3);
        }
        if (url.Contains("m.tb.cn"))
        {
            int startIndex = str2.IndexOf("var url = '") + 11;
            int length = str2.IndexOf("'", startIndex) - startIndex;
            return get_redirect_url(str2.Substring(startIndex, length), url);
        }
        return url;
    }

    public static string smethod_22(string string_1)
    {
        if (string_1 == null)
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder();
        int length = string_1.Length;
        int index = 0;
        while (index != length)
        {
            if (Uri.IsHexEncoding(string_1, index))
            {
                builder.Append(Uri.HexUnescape(string_1, ref index));
            }
            else
            {
                builder.Append(string_1[index++]);
            }
        }
        return builder.ToString();
    }

    public static BrandItem smethod_3(string string_1, string string_2)
    {
        BrandItem class2 = new BrandItem();
        string address = "http://item.taobao.com/item.htm?spm=0.0.0.0.7NgNnN&id=" + string_1;
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.5o4qvy");
        client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
        client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
        client.Headers.Add("Cookie", string_2);
        string str2 = GzipUtil.zip_to_string(client.DownloadData(address), Encoding.GetEncoding("GB2312"));
        int index = str2.IndexOf("<ul id=\"J_AttrUL\">");
        if (index != -1)
        {
            int startIndex = str2.IndexOf("品牌:", index);
            if (startIndex != -1)
            {
                startIndex += 3;
                int num4 = str2.IndexOf("<", startIndex) - startIndex;
                if (num4 > 0)
                {
                    string str3 = smethod_4(GzipUtil.smethod_4(str2.Substring(startIndex, num4)));
                    class2.string_0 = str3;
                }
            }
            int num5 = str2.IndexOf("型号:", index);
            if (num5 != -1)
            {
                num5 += 3;
                int num6 = str2.IndexOf("<", num5) - num5;
                if (num6 > 0)
                {
                    string str4 = smethod_4(GzipUtil.smethod_4(str2.Substring(num5, num6)));
                    class2.string_1 = str4;
                }
            }
            int num7 = str2.IndexOf("货号:", index);
            if (num7 != -1)
            {
                num7 += 3;
                int num8 = str2.IndexOf("<", num7) - num7;
                if (num8 > 0)
                {
                    string str5 = smethod_4(GzipUtil.smethod_4(str2.Substring(num7, num8)));
                    class2.string_2 = str5;
                }
            }
            int length = str2.IndexOf("</ul>", index) - index;
            if (length > 0)
            {
                string str6 = smethod_4(GzipUtil.smethod_4(str2.Substring(index, length)));
                str6 = str6.Substring(0, str6.LastIndexOf("</li>") + 5) + "</ul>";
                class2.string_3 = str6;
            }
        }
        return class2;
    }

    public static string smethod_4(string string_1)
    {
        return string_1.Replace("&rsquo;", "’").Replace("&amp;", "&").Replace("&middot;", "\x00b7").Replace("&mdash;", "—").Replace("\r", "").Replace("\n", "").Replace("\t", "");
    }

    public static StoreItem1 smethod_5(string string_1, string string_2)
    {
        StoreItem1 class2 = new StoreItem1();
        string address = "http://store.taobao.com/shop/view_shop.htm?user_number_id=" + string_1;
        WebClient client = new WebClient();
        client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
        client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.5o4qvy");
        client.Headers.Add("Cookie", string_2);
        string str2 = client.DownloadString(address);
        if (str2.IndexOf("slogo-shopname") != -1)
        {
            int index = str2.IndexOf(">", str2.IndexOf("slogo-shopname"));
            int length = str2.IndexOf("</a>", index) - index;
            string str3 = toText(str2.Substring(index, length)).Replace(" ", "");
            class2.string_0 = str3;
            string str4 = StringUtil.subString(str2, str2.IndexOf("slogo-shopname"), "href=\"http://", ".tmall.");
            class2.string_3 = str4;
        }
        try
        {
            if (str2.IndexOf("公 司 名") != -1)
            {
                int startIndex = str2.IndexOf("<div class=\"right\">", str2.IndexOf("公 司 名"));
                int num5 = str2.IndexOf("</div>", startIndex) - startIndex;
                string str5 = toText(str2.Substring(startIndex, num5)).Replace(" ", "");
                class2.string_1 = str5;
            }
            if (str2.IndexOf("服务电话") != -1)
            {
                int num6 = str2.IndexOf("<div class=\"right\">", str2.IndexOf("服务电话"));
                int num7 = str2.IndexOf("</div>", num6) - num6;
                string str6 = toText(str2.Substring(num6, num7)).Replace(" ", "");
                class2.string_2 = str6;
            }
        }
        catch (Exception)
        {
        }
        return class2;
    }

    public static ShopItem smethod_6(string string_1, string string_2)
    {
        try
        {
            string address = "http://s.taobao.com/search?q=+{shopname}+&commend=all&ssid=s5-e&search_type=shop&sourceId=tb.index&spm=1.7274553.1997520841.1&initiative_id=tbindexz_20150108&app=shopsearch&q=+{shopname}+&commend=all&ssid=s5-e&search_type=shop&sourceId=tb.index&spm=1.7274553.1997520841.1&initiative_id=tbindexz_20150108";
            address = address.Replace("{shopname}", HttpUtility.UrlEncode(string_1));
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Cookie", string_2);
            string str2 = client.DownloadString(address);
            string str3 = ">";
            int startIndex = str2.IndexOf(str3, (int) (str2.IndexOf(">", str2.IndexOf("shop-info-list")) + 1)) + str3.Length;
            int length = str2.IndexOf("<", startIndex) - startIndex;
            string str4 = str2.Substring(startIndex, length).Trim();
            str3 = "class=\"J_WangWang\" data-encode=\"true\" data-nick=\"";
            int num4 = str2.IndexOf(str3) + str3.Length;
            int num5 = str2.IndexOf("\"", num4) - num4;
            string str5 = HttpUtility.UrlDecode(str2.Substring(num4, num5).Trim());
            str3 = "class=\"shop-address\">";
            int num6 = str2.IndexOf(str3) + str3.Length;
            int num7 = str2.IndexOf("<", num6) - num6;
            string str6 = str2.Substring(num6, num7).Trim();
            str3 = "target=\"_blank\">";
            int num8 = str2.IndexOf(str3, str2.IndexOf("主营:")) + str3.Length;
            int num9 = str2.IndexOf("</a>", num8) - num8;
            string str7 = GzipUtil.html_to_text(str2.Substring(num8, num9).Trim());
            str3 = "<img src=\"";
            int num10 = str2.IndexOf(str3, str2.IndexOf("list-img")) + str3.Length;
            int num11 = str2.IndexOf("\"", num10) - num10;
            string str8 = GzipUtil.html_to_text(str2.Substring(num10, num11).Trim());
            ShopItem class2 = new ShopItem();
            class2.title = str4;
            class2.nick = str5;
            class2.addr = str6;
            class2.catName = str7;
            class2.pic_url = str8;
            return class2;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public static ArrayList smethod_7(string string_1, string string_2, int int_2, out string string_3)
    {
        ArrayList list = new ArrayList();
        int num = 1;
        while (num <= int_2)
        {
            ArrayList c = smethod_8(string_1, string_2, num, out string_3);
            if (c == null)
            {
                return null;
            }
            if (c.Count == 0)
            {
                return list;
            }
            list.AddRange(c);
            if (c.Count != 0x2c)
            {
                return list;
            }
            num++;
            Thread.Sleep(0x1388);
        }
        string_3 = "";
        return list;
    }

    public static ArrayList smethod_8(string string_1, string string_2, int int_2, out string string_3)
    {
        string str = "";
        try
        {
            string address = "https://s.taobao.com/search?q={schkey}&js=1&ie=utf8&sort=sale-desc";
            if (int_2 > 1)
            {
                address = "https://s.taobao.com/search?q={schkey}&js=1&ie=utf8&sort=sale-desc&bcoffset=0&p4ppushleft=%2C44&s={pageno}";
                address = address.Replace("{pageno}", ((int_2 - 1) * 0x2c) + "");
            }
            address = address.Replace("{schkey}", HttpUtility.UrlEncode(string_1));
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36");
            client.Headers.Add("Upgrade-Insecure-Requests", "1");
            client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            client.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", string_2);
            byte[] buffer = client.DownloadData(address);
            string str3 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str3))
            {
                str = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str = Encoding.UTF8.GetString(buffer);
            }
            ArrayList list = new ArrayList();
            string str4 = StringUtil.subString(str, 0, "\"auctions\":[{\"", "\"");
            str4 = "\"" + str4 + "\":";
            for (int i = 0; (i = str.IndexOf(str4, i)) != -1; i++)
            {
                GoodsItem class2 = new GoodsItem();
                class2.num_iid = StringUtil.subString(str, i, "\"nid\":\"", "\"");
                class2.title = StringUtil.subString(str, i, "\"raw_title\":\"", "\",").Replace("'", "");
                list.Add(class2);
            }
            string_3 = "";
            return list;
        }
        catch (Exception exception)
        {
            string_3 = "【" + str + "】，" + exception.ToString();
            return null;
        }
    }

    public static ArrayList smethod_9(string string_1, string string_2, string string_3, string string_4, string string_5)
    {
        return smethod_9(string_1, string_2, string_3, string_4, string_5);
    }

    public static string get_num_iid(string url)
    {
        string str;
        if (url.Contains("item_id="))
        {
            try
            {
                int num = url.IndexOf("?item_id=");
                if (num == -1)
                {
                    num = url.IndexOf("&item_id=");
                }
                if (num != -1)
                {
                    num = num + 9;
                    int length = url.IndexOf("&", num);
                    if (length == -1)
                    {
                        length = url.Length;
                    }
                    str = url.Substring(num, length - num);
                }
                else
                {
                    str = url;
                }
            }
            catch (Exception exception)
            {
                //this.method_115(string.Concat("[getItemId]出错：", exception.ToString()));
                str = "";
            }
        }
        else if (url.Contains("itemId="))
        {
            try
            {
                int num = url.IndexOf("?itemId=");
                if (num == -1)
                {
                    num = url.IndexOf("&itemId=");
                }
                if (num != -1)
                {
                    num = num + 8;
                    int length = url.IndexOf("&", num);
                    if (length == -1)
                    {
                        length = url.Length;
                    }
                    str = url.Substring(num, length - num);
                }
                else
                {
                    str = url;
                }
            }
            catch (Exception exception)
            {
                //this.method_115(string.Concat("[getItemId]出错：", exception.ToString()));
                str = "";
            }
        }
        else { 
            try
            {
                string str1 = url.Replace("&amp;", "&").Replace("&nbsp;", "&");
                int num = str1.IndexOf("?id=");
                if (num == -1)
                {
                    num = str1.IndexOf("&id=");
                }
                if (num != -1)
                {
                    num = num + 4;
                    int length = str1.IndexOf("&", num);
                    if (length == -1)
                    {
                        length = url.Length;
                    }
                    str = str1.Substring(num, length - num);
                }
                else
                {
                    str = str1;
                }
            }
            catch (Exception exception)
            {
                //this.method_115(string.Concat("[getItemId]出错：", exception.ToString()));
                str = "";
            }
        }
        return str;
    }

    public static string get_user_num_id(string url)
    {
        string string96;
        try
        {
            int num = url.IndexOf("?user_number_id=");
            if (num == -1)
            {
                num = url.IndexOf("&user_number_id=");
            }
            if (num != -1)
            {
                num = num + 16;
                int length = url.IndexOf("&", num);
                if (length == -1)
                {
                    length = url.Length;
                }
                string96 = url.Substring(num, length - num);
            }
            else
            {
                string96 = url;
            }
        }
        catch (Exception exception)
        {
            string96 = "";
        }
        return string96;
    }


    public static string get_product_id(string url)
    {
        string string96;
        try
        {
            //int num = url.IndexOf("?id=");
            //if (num == -1)
            //{
            //    num = url.IndexOf("&id=");
            //}
            //if (num != -1)
            //{
            //    num = num + 16;
            //    int length = url.IndexOf("&", num);
            //    if (length == -1)
            //    {
            //        length = url.Length;
            //    }
            //    string96 = url.Substring(num, length - num);
            //}
            //else
            //{
            //    string96 = url;
            //}
            string96 = StringUtil.subString(url, 0, "id=", "&");
        }
        catch (Exception exception)
        {
            string96 = "";
        }
        return string96;
    }

}

