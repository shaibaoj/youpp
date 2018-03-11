using haopintui.entity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace haopintui.util
{
    class CouponUtil
    {
         public static string get_pc_url(string url)
        {
            string str = HttpUtility.UrlDecode(url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
            string str1 = StringUtil.subString(str, 0, "sellerId=", "&");
            string str2 = StringUtil.subString(str, 0, "activityId=", "&");
            return "http://taoquan.taobao.com/coupon/unify_apply.htm?sellerId={seller_id}&activityId={activity_id}&scene=taobao_shop".Replace("{seller_id}", str1).Replace("{activity_id}", str2);
        }

         public static string get_m_url(string url)
        {
            string str = HttpUtility.UrlDecode(url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
            string str1 = StringUtil.subString(str, 0, "sellerId=", "&");
            string str2 = StringUtil.subString(str, 0, "activityId=", "&");
            return "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}".Replace("{seller_id}", str1).Replace("{activity_id}", str2);
        }


         public static string get_pc_url(string url,string user_num_id)
         {
             string str = HttpUtility.UrlDecode(url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
             string str2 = StringUtil.subString(str, 0, "activityId=", "&");
             return "http://taoquan.taobao.com/coupon/unify_apply.htm?sellerId={seller_id}&activityId={activity_id}&scene=taobao_shop".Replace("{seller_id}", user_num_id).Replace("{activity_id}", str2);
         }

         public static string get_m_url(string url, string user_num_id)
         {
             string str = HttpUtility.UrlDecode(url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
             string str2 = StringUtil.subString(str, 0, "activityId=", "&");
             return "http://shop.m.taobao.com/shop/coupon.htm?seller_id={seller_id}&activity_id={activity_id}".Replace("{seller_id}", user_num_id).Replace("{activity_id}", str2);
         }

        

         public static bool check_coupon_status(string activity_id, string num_iid)
         {
             string str2 = "https://uland.taobao.com/cp/coupon?ctoken=&activityId={activity_id}&pid=mm_116920901_19972504_72134191&itemId={num_iid}&src=haopintui&dx=1";
             string address = str2.Replace("{activity_id}", activity_id).Replace("{num_iid}", num_iid);
             WebClient client = new WebClient();
             client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
             client.Headers.Add("X-Requested-With", "XMLHttpRequest");
             client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
             client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
             client.Headers.Add("Referer", "http://pub.alimama.com/myunion.htm?spm=a219t.7473494.1998155389.3.M5DAMr");
             client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
             client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
             //client.Headers.Add("Cookie", cookie);
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
             if (
                 //body.Contains("\"retStatus\":1") || 
                 body.Contains("\"retStatus\":2"))
             {
                 return false;
             }
             return true;
         }

    }
}
