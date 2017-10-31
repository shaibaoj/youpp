using com.haopintui;
using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace haopintui.util
{
    public class UrlHptUtil
    {
        public static ContentItem parseContent(CmsForm cmsForm, string content, string qun_pid, bool zhuan_pid_boolean, bool apply_jihua, int url_type)
        {
            ContentItem contentItem = new ContentItem();
            contentItem.content = content;
            contentItem.memo = TaobaoUtil.toText(content);
            ArrayList urlList = UrlHptUtil.parseContentUrlList(contentItem, cmsForm, content, qun_pid, zhuan_pid_boolean, apply_jihua, url_type);
            contentItem.urlList = urlList;
            if (urlList != null)
            {
                string content_send = content;
                if (zhuan_pid_boolean)
                {
                    try
                    {
                        foreach (UrlItem urlItem in urlList)
                        {
                            if (!string.IsNullOrEmpty(urlItem.ori_url)
                                && !string.IsNullOrEmpty(urlItem.click_url))
                            {
                                content_send = content_send.Replace(urlItem.ori_url, urlItem.click_url);
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                    }
                }
                contentItem.content_send = content_send;
            }
            return contentItem;
        }

        public static ArrayList parseContentUrlList(ContentItem contentItem, CmsForm cmsForm, string content, string qun_pid, bool zhuan_pid_boolean, bool apply_jihua, int url_type)
        {
            ArrayList arrayLists;
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
                    if (zhuan_pid_boolean)
                    {
                        urlItem = UrlHptUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, 0, apply_jihua, url_type);
                    }
                    if ((urlItem == null || urlItem.url == null ? true : "".Equals(urlItem.url.Trim())))
                    {
                        urlItem = new UrlItem()
                        {
                            ori_url = match.Value.ToString(),
                            title = string.Concat("***链接转换失败，原链接：【", urlItem.ori_url, "】***")
                        };
                    }
                    arrayLists1.Add(urlItem);

                    num++;
                }
                arrayLists = arrayLists1;
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
                arrayLists = null;
            }
            return arrayLists;
        }

        public static UrlItem pareUrl(ContentItem contentItem, CmsForm cmsForm, UrlItem urlItem, string qun_pid, bool zhuan_pid_boolean, int count, bool apply_jihua, int url_type)
        {
            string url = urlItem.ori_url;
            //LogUtil.log_call(cmsForm, string.Concat("url：", url));
            if (count > 0 && !string.IsNullOrEmpty(urlItem.url))
            {
                url = urlItem.url;
            }
            if (count > 2)
            {
                return urlItem;
            }
            if (contentItem.status > 0)
            {
                return urlItem;
            }
            try
            {
                int qunfa_coupon = 0;
                int qunfa_commission = 0;
                try
                {
                    qunfa_coupon = int.Parse(cmsForm.textBox_qunfa_coupon.Text.Trim());
                    qunfa_commission = int.Parse(cmsForm.textBox_qunfa_commission.Text.Trim());
                }
                catch (Exception)
                { }
                string pid = null;
                if (!string.IsNullOrEmpty(qun_pid))
                {
                    pid = qun_pid;
                }
                else
                {
                    if (!string.IsNullOrEmpty(PidUtil.get_qq_com_pid_call(cmsForm, null)))
                    {
                        pid = PidUtil.get_qq_com_pid_call(cmsForm, cmsForm.appBean.member_id);
                    }
                    else if (!string.IsNullOrEmpty(PidUtil.get_qq_queqiao_pid_call(cmsForm, null)))
                    {
                        pid = PidUtil.get_qq_queqiao_pid_call(cmsForm, cmsForm.appBean.member_id);
                    }
                    else if (!string.IsNullOrEmpty(PidUtil.get_weixin_pid_call(cmsForm, null)))
                    {
                        pid = PidUtil.get_weixin_pid_call(cmsForm, cmsForm.appBean.member_id);
                    }
                }
                LogUtil.log_call(cmsForm, string.Concat("pid：", pid));
                int click_status = 0;

                if (((
                    url.Contains("shaquanquan.com")
                    //|| url.Contains("tmall.com")
                    //|| url.Contains("yao.95095.com")
                    )
                    //&& url.Contains("item.htm") 
                    && url.Contains("id=")
                    ))
                {
                    LogUtil.log_call(cmsForm, string.Concat("产品链接：", url));
                    urlItem.url_type = 5;
                    urlItem.url = url;
                    urlItem.num_iid = TaobaoUtil.get_product_id(url);
                    //LogUtil.log_call(cmsForm, string.Concat("id：", StringUtil.subString(url, 0, "id=", "&")));
                    //UrlUtil.remove_ali(urlItem);
                    int hours = cmsForm.appBean.qunfa_hours;
                    string out_log;
                    ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(urlItem.num_iid, hours, out out_log);
                    if (arrayList.Count > 0)
                    {
                        contentItem.status = 4;
                        return urlItem;
                    }
                    //LogUtil.log_call(cmsForm, ":" + urlItem.num_iid);
                    string click_url = ApiUtil.apply_taoke_url_item(cmsForm, contentItem, urlItem, urlItem.num_iid,pid);
                    urlItem.click_url = click_url;
                    //if (string.IsNullOrEmpty(urlItem.click_url))
                    if (click_status == 2)
                    {
                        contentItem.status = 2;
                        return urlItem;
                    }
                }
                else {
                    if (count > 0)
                    {
                        LogUtil.log_call(cmsForm, string.Concat("一般链接(无需转换)：", url));
                        urlItem.url_type = 0;
                        urlItem.url = url;
                    }
                    else
                    {
                        string str = TaobaoUtil.get_redirect_url(url, url);
                        urlItem.url = str;
                        UrlHptUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, count + 1, apply_jihua, url_type);
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                if (!exception.ToString().Contains("System.Net.WebException"))
                {
                    LogUtil.log_call(cmsForm, string.Concat("[changeUrl]出错！需要转换的链接：【", url, "】，", exception.ToString()));
                }
                else
                {
                    LogUtil.log_call(cmsForm, string.Concat("[changeUrl]出错，估计是一时网络问题，也可能是短网址问题，一般重试即可解决问题，需要转换的链接：【", url, "】，"));
                }
                UrlHptUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, count + 1, apply_jihua, url_type);
            }
            return urlItem;
        }


    }
}
