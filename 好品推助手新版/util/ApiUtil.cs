using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace haopintui.util
{
    public class ApiUtil
    {
        public static string apply_taoke_url_item(CmsForm cmsForm, ContentItem contentItem
            , UrlItem urlItem, string id, string pid)
        {

           string click_url = UserUtil.query_click_url(cmsForm, pid, id, urlItem.url);
           urlItem.click_url = click_url;

           return click_url;
        }

        public static string redictUrl(string originalAddress)
        {
            WebRequest myRequest = WebRequest.Create(originalAddress);
            myRequest.Timeout = 5000;//5秒超时
            WebResponse myResponse = myRequest.GetResponse();
            string redirectUrl = myResponse.ResponseUri.ToString();
            myResponse.Close();

            return redirectUrl;
        }

        public static void parseUtl_market(string url, UrlItem urlItem)
        {
            string redirectUrl = ApiUtil.redictUrl(url);
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                string me = StringUtil.subString(redirectUrl, 0, "me=", "&pid=");
                if (!string.IsNullOrEmpty(me))
                {
                    string str = "https://uland.taobao.com/cp/coupon?me={me}";
                    str = str.Replace("{me}", me);

                    WebClient webClient = new WebClient();
                    webClient.Headers.Add("Accept", "*/*");
                    webClient.Headers.Add("X-Requested-With", "XMLHttpRequest");
                    webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                    webClient.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
                    webClient.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                    webClient.Headers.Add("Referer", url);
                    //webClient.Headers.Add("Cookie", string.Concat("thw=cn; ctoken=", string_3));
                    string str2 = "";
                    byte[] numArray = webClient.DownloadData(str);
                    str2 = (!"gzip".Equals(webClient.ResponseHeaders["Content-Encoding"]) ? Encoding.UTF8.GetString(numArray) : StringUtil.byte_to_str(numArray, Encoding.UTF8));

                    string str3 = StringUtil.subString(str2, 0, "\"title\":\"", "\",");
                    string str4 = StringUtil.subString(str2, 0, "\"discountPrice\":", ",");
                    string str5 = StringUtil.subString(str2, 0, "\"amount\":", ",");
                    string[] strArrays = new string[] { str3, "原价", str4, "元，抢券立省", str5, "元" };

                    string num_iid = StringUtil.subString(str2, 0, "\"itemId\":", ",");
                    urlItem.num_iid = num_iid;

                    string money = StringUtil.subString(str2, 0, "\"amount\":", ",");
                    CouponItem couponItem = new CouponItem();
                    couponItem.money = (int)double.Parse(money);
                    couponItem.leftCount = 100000;
                    urlItem.couponItem = couponItem;

                }
            }

        }

    }
}
