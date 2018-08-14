using com.haopintui;
using haopintui.entity;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using util;

namespace haopintui.util
{
    class UrlParse
    {

        public static CouponContent parseContent(CmsForm cmsForm, string content, string qun_pid)
        {
            CouponContent couponContent = new CouponContent();
            couponContent.content = content;
            couponContent.memo = TaobaoUtil.toText(content);
            UrlParse.parseContentUrlList(couponContent, cmsForm, content);
            if (!string.IsNullOrEmpty(couponContent.num_iid))
            {
                string out_log = "";
                int hours = 1;
                try
                {
                    hours = int.Parse(cmsForm.textBox_qunfa_times.Text.Trim());
                }
                catch (Exception) { }
                ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(couponContent.num_iid, hours, out out_log);
                if (arrayList.Count > 0)
                {
                    couponContent.status = 4;
                    return couponContent;
                }

                if (!string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(cmsForm, null)))
                {
                    qun_pid = PidUtil.get_qq_com_pid_call(cmsForm, cmsForm.appBean.member_id);
                }
                else if (!string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(cmsForm, null)))
                {
                    qun_pid = PidUtil.get_qq_queqiao_pid_call(cmsForm, cmsForm.appBean.member_id);
                }
                else if (!string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(cmsForm, null)))
                {
                    qun_pid = PidUtil.get_weixin_pid_call(cmsForm, cmsForm.appBean.member_id);
                }

               if (!string.IsNullOrEmpty(qun_pid)){


                   ShareItem shareItem = UrlParse.query_share(cmsForm, couponContent.num_iid,qun_pid);
                   if (shareItem != null)
                   {
                       couponContent.coupon_money = shareItem.coupon_money;
                       couponContent.price = shareItem.price;
                   }
                   else {
                        couponContent.status = 1;
                        return couponContent;
                   }
               }

            }
            return couponContent;
        }

        public static void parseContentUrlList(CouponContent contentItem, CmsForm cmsForm, string content)
        {
            try
            {
                ArrayList arrayLists1 = new ArrayList();
                MatchCollection matchCollections = (new Regex(Constants.regex_url)).Matches(content);
                int num = 1;
                foreach (Match match in matchCollections)
                {
                    LogUtil.log_call(cmsForm, string.Concat("正在处理第【", num, "】【", match.Value.ToString(), "】个链接！"));
                    UrlItem urlItem = new UrlItem()
                    {
                        ori_url = match.Value.ToString()
                    };
                    if ((urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com") && !urlItem.ori_url.Contains("uland.taobao.com/quan/detail"))
                         || (((urlItem.ori_url.Contains("taobao.com")
                            || urlItem.ori_url.Contains("tmall.com")
                            || urlItem.ori_url.Contains("yao.95095.com"))
                            && urlItem.ori_url.Contains("item.htm") && urlItem.ori_url.Contains("id="))))
                    {

                        string num_iid = TaobaoUtil.get_num_iid(urlItem.ori_url);
                        if (!string.IsNullOrEmpty(num_iid) && string.IsNullOrEmpty(contentItem.num_iid))
                        {
                            contentItem.num_iid = num_iid;
                        }
                    }
                    else
                    {
                        string str = TaobaoUtil.get_redirect_url(urlItem.ori_url, urlItem.ori_url);
                        if ((urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com") && !urlItem.ori_url.Contains("uland.taobao.com/quan/detail"))
                        || (((urlItem.ori_url.Contains("taobao.com")
                           || urlItem.ori_url.Contains("tmall.com")
                           || urlItem.ori_url.Contains("yao.95095.com"))
                           && urlItem.ori_url.Contains("item.htm") && urlItem.ori_url.Contains("id="))))
                        {

                            string num_iid = TaobaoUtil.get_num_iid(urlItem.ori_url);
                            if (!string.IsNullOrEmpty(num_iid) && string.IsNullOrEmpty(contentItem.num_iid))
                            {
                                contentItem.num_iid = num_iid;
                            }
                        }
                    }
                    num++;
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
            }
        }

        public static ShareItem query_share(CmsForm cmsForm, string num_iid, String pid)
        {
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                String user_key = cmsForm.appBean.user_token;
                String user_name = cmsForm.appBean.user_name;
                String user_goods_url = "http://"+Constants.api_url+"/zhushou/goods/share";
                String body = httpservice.post_http(user_goods_url, "user_id=" + user_id 
                    + "&num_iid=" + num_iid
                     + "&pid=" + pid 
                    + "&member_token=" + user_key, null);
                //LogUtil.log_cms_call(cmsForm, "body：" + body);
                body = body.Trim();

                ShareItem shareItem = new ShareItem();

                JsonData jo = JsonMapper.ToObject(body);
                if (jo["data"] != null
                        && jo["data"]["share"] != null)
                {
                    shareItem.title = jo["data"]["share"]["title"].ToString();
                        try {
                            shareItem.tao_token = jo["data"]["share"]["tao_token"].ToString();
                     }
                    catch (Exception) { }
                    try {
                    shareItem.coupon_money = double.Parse(jo["data"]["share"]["coupon_money"].ToString());
                    }
                    catch (Exception) { }
                    try {
                        shareItem.short_url = jo["data"]["share"]["short_url"].ToString();
                         }
                    catch (Exception) { }
                        try {
                            shareItem.uland_url = jo["data"]["share"]["taoke_url"].ToString();
                        }
                        catch (Exception) { }
                        try
                        {
                            shareItem.price = double.Parse(jo["data"]["share"]["price"].ToString());
                        }
                        catch (Exception) { }

                        try
                        {
                            shareItem.user_type_name = jo["data"]["share"]["user_type_name"].ToString();
                        }
                        catch (Exception) { }

                }
                return shareItem;
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, "---------------35555-----------"+exception.ToString());
                return null;
            }
        }


    }
}
