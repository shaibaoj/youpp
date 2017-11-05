using com.haopintui;
using entity;
using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace haopintui.util
{
    public class UrlUtil
    {
        public static UrlItem pareUrl(ContentItem contentItem,CmsForm cmsForm,UrlItem urlItem,string qun_pid,bool zhuan_pid_boolean,int count,bool apply_jihua,int url_type)
	    {
		    string url = urlItem.ori_url;
            //LogUtil.log_call(cmsForm, string.Concat("url：", url));
            if (count > 0 && !string.IsNullOrEmpty(urlItem.url))
            {
                url = urlItem.url;
            }
            if (count>2)
            {
                return urlItem;
            }
            if (contentItem.status>0)
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
                {}
                string pid = null;
                if (!string.IsNullOrEmpty(qun_pid))
                {
                    pid = qun_pid;
                }
                else {
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
                if (url.Contains("activityId") && url.Contains("uland.taobao.com"))
                {
                    LogUtil.log_call(cmsForm, string.Concat("二合一链接：", url));
                    urlItem.url_type = 4;
                    urlItem.url = url;
                    urlItem.num_iid = TaobaoUtil.get_num_iid(url);

                    int hours =cmsForm.appBean.qunfa_hours;
                    string out_log;
                    ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(urlItem.num_iid, hours, out out_log);
                    if (arrayList.Count > 0)
                    {
                        contentItem.status = 4;
                        return urlItem;
                    }
                    if (urlItem.taokeItem != null)
                    {
                        urlItem.pc_url = CouponUtil.get_pc_url(url, urlItem.taokeItem.user_num_id);
                        urlItem.m_url = CouponUtil.get_m_url(url, urlItem.taokeItem.user_num_id);
                    }
                    else {
                        ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + urlItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                        if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                        {
                            TaokeItem taokeItem = new TaokeItem();
                            taokeItem.num_iid = urlItem.num_iid;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;
                            taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                            taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;

                            taokeItem.price = ((GoodsItem2)taoke_goods_list[0]).zkPrice;
                            taokeItem.userType = "" + ((GoodsItem2)taoke_goods_list[0]).userType;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;

                            taokeItem.tkMktStatus = ((GoodsItem2)taoke_goods_list[0]).tkMktStatus;
                            taokeItem.eventRate = ((GoodsItem2)taoke_goods_list[0]).eventRate;

                            urlItem.taokeItem = taokeItem;
                            //urlItem.tkMktStatus = taokeItem.tkMktStatus;

                            urlItem.pc_url = CouponUtil.get_pc_url(url, urlItem.taokeItem.user_num_id);
                            urlItem.m_url = CouponUtil.get_m_url(url, urlItem.taokeItem.user_num_id);

                        }
                    }
                    //LogUtil.log_call(cmsForm, string.Concat("二合一链接urlItem.m_url：", urlItem.m_url));
                    if (qunfa_coupon>0)
                    {
                        string money;
                        CouponItem couponItem = TaobaoUtil.get_coupon(cmsForm,urlItem.m_url, contentItem.num_iid, pid, out money);
                        LogUtil.log_call(cmsForm, string.Concat("优惠券信息：", couponItem.ToString()));
                        urlItem.couponItem = couponItem;
                        if (couponItem == null || couponItem.leftCount < qunfa_coupon)
                        {
                            contentItem.status = 1;
                            return urlItem;
                        }
                    }

                    //LogUtil.log_call(cmsForm, string.Concat("二合一链接urlItem.num_iid：", urlItem.num_iid));
                    string click_url = AppUtil.apply_taoke_url_item(cmsForm, contentItem, urlItem, urlItem.num_iid, pid, ref click_status, apply_jihua, url_type);
                    urlItem.click_url = click_url;
                    //LogUtil.log_call(cmsForm, string.Concat("二合一链接urlItem.click_url：", urlItem.click_url));

                    //KoulingBean koulingBean = UrlUtil.get_koulingBean(urlItem, pid, contentItem.dx);
                    //if (koulingBean != null 
                    //    && !string.IsNullOrEmpty(koulingBean.url))
                    //{
                    //    urlItem.click_url = koulingBean.url;
                    //}

                    string num_iid = urlItem.num_iid;
                    string coupon_url = urlItem.m_url;
                    coupon_url = HttpUtility.UrlDecode(coupon_url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
                    string activityId = StringUtil.subString(coupon_url, 0, "activityId=", "&");
                    string sellerId = StringUtil.subString(coupon_url, 0, "sellerId=", "&");
                    string uland_url = Constants.uland_url.Replace("{activityId}", activityId).Replace("{pid}", pid).Replace("{itemId}", num_iid).Replace("{dx}", "" + contentItem.dx);

                    string api_uland_url = UserUtil.query_ali_api_url(cmsForm, num_iid, pid, activityId);
                    if (!string.IsNullOrEmpty(api_uland_url))
                    {
                        uland_url = api_uland_url;
                        LogUtil.log_call(cmsForm, string.Concat("高佣金接口转化链接：", api_uland_url));
                    }

                    urlItem.click_url = UserUtil.query_short_url(cmsForm,uland_url);

                    if (urlItem.taokeItem!=null
                        &&urlItem.taokeItem.tkMktStatus == 1
                        &&urlItem.taokeItem.tkRate>urlItem.taokeItem.eventRate
                        &&urlItem.taokeItem.tkRate > urlItem.taokeItem.auto_Rate
                        )
                    {
                        urlItem.click_url = urlItem.taokeItem.short_url;
                        urlItem.tkMktStatus = urlItem.taokeItem.tkMktStatus;
                    }

                    //else if (string.IsNullOrEmpty(urlItem.click_url))
                        if (click_status == 2)
                    {
                        contentItem.status = 2;
                        return urlItem;
                    }
                }
                else if (url.Contains("coupon") && url.Contains("taobao.com"))
                {
                    LogUtil.log_call(cmsForm, string.Concat("优惠券链接：", url));
                    urlItem.url_type = 1;
                    urlItem.url = url;
                    urlItem.pc_url = CouponUtil.get_pc_url(url);
                    urlItem.m_url = CouponUtil.get_m_url(url);

                    if (qunfa_coupon > 0)
                    {
                        string money;
                        CouponItem couponItem = TaobaoUtil.get_coupon(cmsForm, url, contentItem.num_iid, pid, out money);
                        LogUtil.log_call(cmsForm, string.Concat("money：", money));
                        LogUtil.log_call(cmsForm, string.Concat("优惠券信息：", couponItem.ToString()));
                        urlItem.couponItem = couponItem;
                        if (couponItem ==null|| couponItem.leftCount < qunfa_coupon)
                        {
                            contentItem.status = 1;
                            return urlItem;
                        }
                    }
                }
			    else if (((url.Contains("taobao.com") 
                    || url.Contains("tmall.com") 
                    || url.Contains("yao.95095.com")) 
                    && url.Contains("item.htm")&&url.Contains("id=")))
			    {
				    LogUtil.log_call(cmsForm, string.Concat("产品链接：", url));
				    urlItem.url_type = 2;
                    urlItem.url = url;
                    urlItem.num_iid = TaobaoUtil.get_num_iid(url);
                    UrlUtil.remove_ali(urlItem);
                    int hours = cmsForm.appBean.qunfa_hours;
                    string out_log;
                    ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(urlItem.num_iid, hours, out out_log);
                    if (arrayList.Count > 0)
                    {
                        contentItem.status = 4;
                        return urlItem;
                    }
                    //LogUtil.log_call(cmsForm, ":" + urlItem.num_iid);

                    string click_url = "";
                    string api_uland_url = UserUtil.query_ali_api_url(cmsForm, urlItem.num_iid, pid, activityId);
                    if (!string.IsNullOrEmpty(api_uland_url))
                    {
                        uland_url = api_uland_url;
                        LogUtil.log_call(cmsForm, string.Concat("高佣金接口转化链接：", api_uland_url));
                    }

                    string click_url = AppUtil.apply_taoke_url_item(cmsForm, contentItem, urlItem, urlItem.num_iid, pid, ref click_status,apply_jihua,  url_type);
                    urlItem.click_url = click_url;
                    if (urlItem.taokeItem!=null
                        && urlItem.taokeItem.tkMktStatus==1
                        && urlItem.taokeItem.tkRate > urlItem.taokeItem.eventRate
                        && urlItem.taokeItem.tkRate > urlItem.taokeItem.auto_Rate
                        )
                    {
                        urlItem.click_url = urlItem.taokeItem.short_url;
                        urlItem.tkMktStatus = urlItem.taokeItem.tkMktStatus;
                    }
                    //if (string.IsNullOrEmpty(urlItem.click_url))
                    if (click_status == 2)
                    {
                        contentItem.status = 2;
                        return urlItem;
                    }
			    }
                else if (((url.Contains("s.click.taobao.com")
                //|| url.Contains("tmall.com")
                //|| url.Contains("yao.95095.com")
                    )
                    && url.Contains("pid=mm_0_0_0")))
                {
                    LogUtil.log_call(cmsForm, string.Concat("产品链接：", url));
                    urlItem.url_type = 6;
                    urlItem.url = url;
                    ApiUtil.parseUtl_market(url, urlItem);
                    //urlItem.num_iid = TaobaoUtil.get_num_iid(url);
                    UrlUtil.remove_ali(urlItem);
                    int hours = cmsForm.appBean.qunfa_hours;
                    string out_log;
                    ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(urlItem.num_iid, hours, out out_log);
                    if (arrayList.Count > 0)
                    {
                        contentItem.status = 4;
                        return urlItem;
                    }

                    if (urlItem.couponItem == null || urlItem.couponItem.leftCount < qunfa_coupon)
                    {
                        contentItem.status = 1;
                        return urlItem;
                    }

                    if (urlItem.taokeItem==null)
                    {
                        ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + urlItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                        if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                        {
                            TaokeItem taokeItem = new TaokeItem();
                            taokeItem.num_iid = urlItem.num_iid;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;
                            taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                            taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;

                            taokeItem.price = ((GoodsItem2)taoke_goods_list[0]).zkPrice;
                            taokeItem.userType = "" + ((GoodsItem2)taoke_goods_list[0]).userType;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;

                            taokeItem.tkMktStatus = ((GoodsItem2)taoke_goods_list[0]).tkMktStatus;
                            taokeItem.eventRate = ((GoodsItem2)taoke_goods_list[0]).eventRate;

                            urlItem.taokeItem = taokeItem;

                        }
                    }

                    //LogUtil.log_call(cmsForm, ":" + urlItem.num_iid);
                    string click_url = url.Replace("mm_0_0_0", pid);
                    urlItem.click_url = click_url;
                    //if (string.IsNullOrEmpty(urlItem.click_url))
                    contentItem.market_url = url;

                    if (click_status == 2)
                    {
                        contentItem.status = 2;
                        return urlItem;
                    }
                }
			    else if (url.Contains("detail.ju.taobao.com"))
			    {
				    LogUtil.log_call(cmsForm, string.Concat("聚划算链接：", url));
                    urlItem.url_type = 2;
                    urlItem.url = url;
                    urlItem.num_iid = TaobaoUtil.get_num_iid(url);
                    UrlUtil.remove_ali(urlItem);
                    int hours = cmsForm.appBean.qunfa_hours;
                    string out_log;
                    ArrayList arrayList = cmsForm.sendSqlUtil.query_send_item(urlItem.num_iid, hours, out out_log);
                    if (arrayList.Count > 0)
                    {
                        contentItem.status = 4;
                        return urlItem;
                    }
                    string click_url = AppUtil.apply_taoke_url_item(cmsForm, contentItem, urlItem, urlItem.num_iid, pid, ref click_status,apply_jihua,  url_type);
                    urlItem.click_url = click_url;
                    if (click_status == 2)
                    //if (string.IsNullOrEmpty(urlItem.click_url))
                    {
                        contentItem.status = 2;
                        return urlItem;
                    }
			    }
                else if (url.Contains("shop/view_shop.htm?user_number_id="))
				{
					LogUtil.log_call(cmsForm, string.Concat("店铺推广链接：", url));
                    urlItem.url_type = 3;
                    urlItem.url = url;
                    urlItem.user_num_id = TaobaoUtil.get_user_num_id(url);
                    UrlUtil.remove_ali(urlItem);
                    string click_url = AppUtil.apply_taoke_url(cmsForm, contentItem, urlItem.url, pid);
                    urlItem.click_url = click_url;
                    if (string.IsNullOrEmpty(urlItem.click_url))
                    {
                        contentItem.status = 3;
                        return urlItem;
                    }

				}
                else if (url.Contains("temai.taobao.com"))
				{
					LogUtil.log_call(cmsForm, string.Concat("鹊桥链接(无法转换)：", url));
					urlItem.url_type = 0;
					urlItem.url = url;
				}
				else if (url.Contains("err.taobao.com"))
				{
					LogUtil.log_call(cmsForm, string.Concat("淘宝错误页面：", url));
                    urlItem.url_type = 0;
                    urlItem.url = url;
				}
                else if ((url.Contains("pages.tmall.com")
                    || url.Contains("1111.tmall.com")
                    || url.Contains("huodong.taobao.com")
                    || url.Contains("ju.taobao.com")
                    ))
				{
                    LogUtil.log_call(cmsForm, string.Concat("活动推广链接：", url)); 
                    urlItem.url_type = 3;
                    urlItem.url = url;
                    UrlUtil.remove_ali(urlItem);
                    //LogUtil.log_call(cmsForm, string.Concat("urlItem：", urlItem.url));
                    string click_url = AppUtil.apply_taoke_url(cmsForm, contentItem, urlItem.url, pid);
                    urlItem.click_url = click_url;
                    if (string.IsNullOrEmpty(urlItem.click_url))
                    {
                        contentItem.status = 3;
                        return urlItem;
                    }
				}
                else if ((url.Contains("alitrip.com")
                    ))
                {
                    LogUtil.log_call(cmsForm, string.Concat("阿里旅游：", url));
                    urlItem.url_type = 3;
                    urlItem.url = url;
                    UrlUtil.remove_ali(urlItem);
                    string click_url = AppUtil.apply_taoke_url(cmsForm, contentItem, urlItem.url, pid);
                    urlItem.click_url = click_url;
                    if (string.IsNullOrEmpty(urlItem.click_url))
                    {
                        contentItem.status = 3;
                        return urlItem;
                    }
                }
                else{
                    if(count>0){
                        LogUtil.log_call(cmsForm, string.Concat("一般链接(无需转换)：", url));
					    urlItem.url_type = 0;
					    urlItem.url = url;
                    }else{
                        string str = TaobaoUtil.get_redirect_url(url, url);
                        urlItem.url = str;
                        UrlUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, count + 1, apply_jihua, url_type);
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
                UrlUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, count + 1, apply_jihua, url_type);
		    }
		    return urlItem;
	    }

        public static void remove_ali(UrlItem urlItem)
	    {
            string url = urlItem.url;
            url = CommonUtil.remove_ali_trackid(url);
            url = CommonUtil.remove_pid(url);
            if (url.Contains("pvid="))
		    {
                string str = string.Concat("&pvid=", StringUtil.subString(url, 0, "pvid=", "&"));
                url = url.Replace(str, "");
		    }
            urlItem.url = url;
	    }

        public static ArrayList parseContentUrlList(ContentItem contentItem, CmsForm cmsForm, string content, string qun_pid, bool zhuan_pid_boolean,bool apply_jihua,int url_type)
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
                    if ((urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com"))
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
                    else {
                        string str = TaobaoUtil.get_redirect_url(urlItem.ori_url, urlItem.ori_url);
                        if ((urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com"))
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
                num = 1;

                foreach (Match match in matchCollections)
                {
                    LogUtil.log_call(cmsForm, string.Concat("正在处理第【", num, "】【", match.Value.ToString(), "】个链接！"));
                    UrlItem urlItem = new UrlItem()
                    {
                        ori_url = match.Value.ToString()
                    };
                    if ((urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com"))
                         ||(
                            urlItem.ori_url.Contains("coupon") && urlItem.ori_url.Contains("taobao.com")
                         )){
                        if (zhuan_pid_boolean)
                        {
                            urlItem = UrlUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, 0, apply_jihua, url_type);
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
                    }
                    num++;
                }
                num = 1;
                foreach (Match match in matchCollections)
                {
                    LogUtil.log_call(cmsForm, string.Concat("正在处理第【", num, "】【", match.Value.ToString(), "】个链接！"));
                    UrlItem urlItem = new UrlItem()
                    {
                        ori_url = match.Value.ToString()
                    };
                    if (!(urlItem.ori_url.Contains("activityId") && urlItem.ori_url.Contains("uland.taobao.com"))
                         && !(
                            urlItem.ori_url.Contains("coupon") && urlItem.ori_url.Contains("taobao.com")
                         ))
                    {
                        if (zhuan_pid_boolean)
                        {
                            urlItem = UrlUtil.pareUrl(contentItem, cmsForm, urlItem, qun_pid, zhuan_pid_boolean, 0, apply_jihua, url_type);
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
                    }
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

        public static UrlItem parseContentUrlType(CmsForm cmsForm, ArrayList urlList,int url_type)
        {
            try
            {
                foreach (UrlItem urlItem in urlList)
                {
                    if (urlItem.url_type == url_type)
                    {
                        return urlItem;
                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
            }
            return null;
        }

        public static string remove_ali_trackid(string url)
        {
            if (url.Contains("ali_trackid="))
            {
                string oldValue = "&ali_trackid=" + StringUtil.subString(url, 0, "&ali_trackid=", "&");
                return url.Replace(oldValue, "");
            }
            return url;
        }

        public static string copyImgContent(CmsForm cmsForm, string content,string create_date_str) {
            string follow_path = "";
            if (string.IsNullOrEmpty(create_date_str))
            {
                create_date_str = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                follow_path = string.Concat(cmsForm.appBean.weixin_path_img, @"\" + create_date_str + @"\");
            }
            else {
                follow_path = string.Concat(cmsForm.appBean.follow_path, @"\" + create_date_str + @"\") ;
            }

            bool flag;
            content = content.Replace("<img", "<IMG");
            int num = 0;
            while (true)
            {
                int num1 = content.IndexOf("<IMG", num);
                num = num1;
                if (num1 == -1)
                {
                    break;
                }
                int num2 = content.IndexOf("src", num);
                int num3 = content.IndexOf("SRC", num);
                int num4 = num2;
                if (num4 == -1)
                {
                    flag = false;
                }
                else
                {
                    flag = (num4 <= num3 ? true : num3 == -1);
                }
                if (!flag)
                {
                    num4 = num3;
                }
                int num5 = content.IndexOf("\"", num4) + 1;
                string str2 = content.Substring(num5, content.IndexOf("\"", num5) - num5);
                if (str2.Contains("http://") || str2.Contains("https://"))
                {
                    if (UrlUtil.IsExist(str2))
                    {
                        DateTime now = DateTime.Now;
                        string str4 = string.Concat(follow_path, now.ToString("yyyyMMddHHmmssfff"), ".jpg");
                        try
                        {
                            if (!Directory.Exists(follow_path))
                            {
                                Directory.CreateDirectory(follow_path);
                            }
                            (new WebClient()).DownloadFile(str2, str4);
                            str4 = string.Concat("file:///", str4);
                            content = content.Replace(str2, str4);
                            str2 = str4;
                        }
                        catch (Exception exception)
                        {
                            LogUtil.log_call(cmsForm, "下载图片！");
                        }
                    }
                    else {
                        DateTime now = DateTime.Now;
                        string str4 = string.Concat(follow_path, now.ToString("yyyyMMddHHmmssfff"), ".jpg");
                        try
                        {
                            if (!Directory.Exists(follow_path))
                            {
                                Directory.CreateDirectory(follow_path);
                            }
                            (new WebClient()).DownloadFile("http://img.alicdn.com/tps/TB1dx.UMpXXXXboXVXXXXXXXXXX-102-100.png", str4);
                            str4 = string.Concat("file:///", str4);
                            content = content.Replace(str2, str4);
                            str2 = str4;
                        }
                        catch (Exception exception)
                        {
                            LogUtil.log_call(cmsForm, "下载图片！");
                        }
                    }

                }
                string str3 = HttpUtility.UrlDecode(str2.Replace("file:///", "").Replace("/", "\\"));
                //LogUtil.log_call(cmsForm, "str3：" + str3);
                if (!str3.Contains(cmsForm.appBean.follow_path))
                {
                    DateTime now = DateTime.Now;
                    string str4 = string.Concat(follow_path, now.ToString("yyyyMMddHHmmssfff"), str3.Substring(str3.LastIndexOf(".")));
                    try
                    {
                        if (!Directory.Exists(follow_path))
                        {
                            Directory.CreateDirectory(follow_path);
                        }
                        //LogUtil.log_call(cmsForm, "str3：" + str3);
                        //LogUtil.log_call(cmsForm, "str4：" + str4);
                        File.Copy(str3, str4);
                        string str5 = string.Concat("file:///", str4.Replace(" ", "%20").Replace("{", "%7b").Replace("}", "%7d").Replace("\\", "/"));
                        content = content.Replace(str2, str5);
                    }
                    catch (Exception exception)
                    {
                        LogUtil.log_call(cmsForm, "复制图片出错，请用先删除编辑区图片，再用QQ截图单独拷贝图片！");
                    }
                    num++;

                }
                else
                {
                    num++;
                }
            }
            return content;
        }

        public static string parseImg(CmsForm cmsForm, string content)
        {
            string string96;
            bool flag;
            try
            {
                content = content.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
                int num = 0;
                while (true)
                {
                    int num1 = content.IndexOf("<IMG", num);
                    num = num1;
                    if (num1 == -1)
                    {
                        break;
                    }
                    string str = "";
                    int num2 = content.IndexOf("src", num);
                    int num3 = content.IndexOf("SRC", num);
                    int num4 = num2;
                    if (num4 == -1)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = (num4 <= num3 ? true : num3 == -1);
                    }
                    if (!flag)
                    {
                        num4 = num3;
                    }
                    int num5 = content.IndexOf("\"", num4) + 1;
                    string str1 = content.Substring(num5, content.IndexOf("\"", num5) - num5);
                    str = string.Concat("{image}", str1, "{/image}");
                    int num6 = content.IndexOf(">", num) - num;
                    string str2 = content.Substring(num, num6 + 1);
                    content = content.Replace(str2, str);
                    //string_96 = string_96.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
                }
                string96 = content;
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, string.Concat("[processImageTag]出错：", exception.ToString()));
                string96 = null;
            }
            return string96;
        }

        public static string parseContentWenan(CmsForm cmsForm, string content)
        {
            try
            {
                content = UrlUtil.parseImg(cmsForm, content);
                content = content.Replace("<", " <").Replace(">", "> ").Replace("&nbsp;", " ");
                content = content.Replace("<img", "<IMG").Replace("<br/>", "<BR/>").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>").Replace("<p>", "<P>").Replace("</p>", "</P>");
                content = content.Replace("</span>", "</SPAN>")
                    .Replace("</div>", "</DIV>")
                    .Replace("<img", "<IMG")
                    //.Replace("\n", "")
                    //.Replace("\r", "")
                    .Replace("<br>", "\n")
                    .Replace("<BR>", "\n")
                    .Replace("<BR", "\n<BR")
                    .Replace("</DIV>", "\n")
                    .Replace("</SPAN>", "\n")
                    .Replace("<P>", "\n")
                    .Replace("<p>", "\n")
                    .Replace("</P>", "\n")
                    .Replace("</p>", "\n");
                content = CommonUtil.toText(content);
                content = content.Replace("\n", "<BR>");
                content = content.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, string.Concat("[parseContentWenan]出错：", exception.ToString()));
            }
            return content;
        }

        public static ContentItem parseContent(CmsForm cmsForm, string content, string qun_pid, bool zhuan_pid_boolean,bool apply_jihua, int url_type)
        {
            ContentItem contentItem = new ContentItem();
            contentItem.content = content;
            contentItem.memo = TaobaoUtil.toText(content);
            ArrayList urlList = UrlUtil.parseContentUrlList(contentItem,cmsForm, content, qun_pid,zhuan_pid_boolean, apply_jihua, url_type);
            contentItem.urlList = urlList;
            contentItem.couponUrlItem = UrlUtil.parseContentUrlType(cmsForm, urlList, 1);
            contentItem.goodsUrlItem = UrlUtil.parseContentUrlType(cmsForm,urlList,2);
            if (contentItem.couponUrlItem == null)
            {
                contentItem.couponUrlItem = UrlUtil.parseContentUrlType(cmsForm, urlList, 4);
            }
            if (contentItem.goodsUrlItem == null)
            {
                contentItem.goodsUrlItem = UrlUtil.parseContentUrlType(cmsForm, urlList, 4);
            }

            if (contentItem.couponUrlItem == null)
            {
                contentItem.couponUrlItem = UrlUtil.parseContentUrlType(cmsForm, urlList, 6);
            }
            if (contentItem.goodsUrlItem == null)
            {
                contentItem.goodsUrlItem = UrlUtil.parseContentUrlType(cmsForm, urlList, 6);
            }

            if (contentItem.goodsUrlItem!=null)
            {
                contentItem.num_iid = contentItem.goodsUrlItem.num_iid;
            }
            if (contentItem.couponUrlItem != null)
            {
                contentItem.coupon_url = contentItem.couponUrlItem.url;
            }

            if(urlList!=null){
                string content_send = content;
                if (zhuan_pid_boolean)
                {                
                    try
                    {
                        foreach (UrlItem urlItem in urlList)
                        {
                            if(!string.IsNullOrEmpty(urlItem.ori_url)
                                &&!string.IsNullOrEmpty(urlItem.click_url)){
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

        public static void parseContent_weixin(CmsForm cmsForm, ContentItem contentItem, string pid, bool zhuan_pid_boolean)
        {
            string content = contentItem.content;
            string out_log;
            ContentWeixin contentWeixin = WeixinUtil.get_weixin_content(cmsForm, content, out out_log);
            string[] sArray = Regex.Split(contentWeixin.content_weixin, "<BR>", RegexOptions.IgnoreCase);
            string content_weixin = "";
            string content_title = "";
            foreach (string i in sArray)
            {
                string str = i.Trim();
                if (!str.Contains("http:") && !str.Contains("https:"))
                {
                    content_weixin = content_weixin + str;
                }
                if (!str.Contains("http:") && !str.Contains("https:") && string.IsNullOrEmpty(content_title))
                {
                    content_title = content_title + str;
                }
            }

            if (zhuan_pid_boolean)
            {
                string weixin_pid = PidUtil.get_weixin_pid_call(cmsForm, cmsForm.appBean.member_id);
                if (!string.IsNullOrEmpty(pid))
                {
                    weixin_pid = pid;
                }
                if(!string.IsNullOrEmpty(weixin_pid)
                    &&!string.IsNullOrEmpty(contentItem.num_iid)
                    &&!string.IsNullOrEmpty(contentItem.coupon_url)){
                    string coupon_url = contentItem.coupon_url;
                    coupon_url =coupon_url.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
                    string activityId = StringUtil.subString(coupon_url, 0, "activityId=", "&");
                    string uland_url = Constants.uland_url.Replace("{activityId}", activityId).Replace("{pid}", weixin_pid).Replace("{itemId}", contentItem.num_iid).Replace("{dx}", "" + contentItem.dx);
                    if (contentItem.goodsUrlItem != null
                                && contentItem.goodsUrlItem.tkMktStatus == 1
                                && !string.IsNullOrEmpty(contentItem.goodsUrlItem.click_url))
                    {
                        uland_url = contentItem.goodsUrlItem.click_url;
                    }
                    string kouling = PidUtil.get_kouling_call(cmsForm, uland_url, "", content_title, "");
                    if (!string.IsNullOrEmpty(kouling))
                    {
                        string weiba = Constants.kouling_template
                            .Replace("#手淘短网址#", "")
                            .Replace("#淘口令#", kouling);

                        if (contentItem.couponUrlItem!=null
                            &&contentItem.couponUrlItem.couponItem!=null)
                        {
                            weiba = weiba.Replace("#优惠券面额#", "" + contentItem.couponUrlItem.couponItem.money);
                        }
                        else
                        {
                            weiba = weiba.Replace("#优惠券面额#", "");
                        }
                        content_weixin = content_weixin + weiba;
                    }

                }
            }
            contentItem.content_weixin = content_weixin;
            contentItem.content_weixin_img = contentWeixin.content_weixin_img;
            contentItem.imgList = contentWeixin.imgList;
        }

        public static string parseContent_kouling(CmsForm cmsForm, ContentItem contentItem,string pid, bool zhuan_pid_boolean)
        {
            string content = contentItem.content;
            string out_log;
            ContentWeixin contentWeixin = WeixinUtil.get_weixin_content(cmsForm, content, out out_log);
            string[] sArray = Regex.Split(contentWeixin.content_weixin, "<BR>", RegexOptions.IgnoreCase);
            string content_title = "";
            foreach (string i in sArray)
            {
                string str = i.Trim();
                if (!str.Contains("http:") && !str.Contains("https:") && string.IsNullOrEmpty(content_title))
                {
                    content_title = content_title + str;
                }
            }
            if (zhuan_pid_boolean)
            {
                if (!string.IsNullOrEmpty(pid)
                    && !string.IsNullOrEmpty(contentItem.num_iid)
                    && !string.IsNullOrEmpty(contentItem.coupon_url))
                {
                    string coupon_url = contentItem.coupon_url;
                    coupon_url = coupon_url.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
                    string activityId = StringUtil.subString(coupon_url, 0, "activityId=", "&");
                    string uland_url = Constants.uland_url.Replace("{activityId}", activityId).Replace("{pid}", pid).Replace("{itemId}", contentItem.num_iid).Replace("{dx}", "" + contentItem.dx);
                    //LogUtil.log_call(cmsForm, "---uland_url------" + uland_url);
                    string kouling = PidUtil.get_kouling_call(cmsForm, uland_url, "", content_title, "");
                    if (!string.IsNullOrEmpty(kouling))
                    {
                        string weiba = Constants.kouling_template
                            .Replace("#手淘短网址#", "")
                            .Replace("#淘口令#", kouling);
                        if (contentItem.couponUrlItem != null
                            && contentItem.couponUrlItem.couponItem != null)
                        {
                            weiba = weiba.Replace("#优惠券面额#", "" + contentItem.couponUrlItem.couponItem.money);
                        }
                        else {
                            weiba = weiba.Replace("#优惠券面额#", "");
                        }
                        return weiba;
                    }

                }
            }
            return "";
        }

        public static string template_qq(CmsForm cmsForm, ContentItem contentItem, string pid, bool zhuan_pid_boolean
            ,string qq_template)
        {
            string content_send = contentItem.content_send;

            //string content = contentItem.content_send;
            string out_log;
            ContentWeixin contentWeixin = WeixinUtil.get_weixin_content(cmsForm, content_send, out out_log);
            string[] sArray = Regex.Split(contentWeixin.content_weixin, "<BR>", RegexOptions.IgnoreCase);
            string content_title = "";
            string content_wenan = "";
            foreach (string i in sArray)
            {
                string str = i.Trim();
                if (!str.Contains("http:") && !str.Contains("https:") && string.IsNullOrEmpty(content_title))
                {
                    content_title = content_title + str;
                }
                if (!str.Contains("http:") && !str.Contains("https:"))
                {
                    content_wenan = content_wenan + str;
                }
                else {
                    content_wenan = "";
                }
            }
            if (zhuan_pid_boolean)
            {
                if (!string.IsNullOrEmpty(qq_template))
                {
                    string content = qq_template;
                    string goods_price = "";
                    string coupon_money = "";
                    string buy_goods_price = "";
                    string click_url = "";
                    string wenan = content_wenan;
                    string goods_title = "";
                    string goods_img = "";
                    string goods_type_name = "";
                    string u_land_short_url = "";
                    if (contentItem.couponUrlItem != null
                        && contentItem.couponUrlItem.couponItem != null)
                    {
                        coupon_money = "" + contentItem.couponUrlItem.couponItem.money;
                    }
                    if (contentItem.goodsUrlItem != null)
                    {
                        goods_price = "" + contentItem.goodsUrlItem.taokeItem.price;
                    }
                    if (contentItem.goodsUrlItem != null
                        && contentItem.couponUrlItem != null
                        && contentItem.couponUrlItem.couponItem != null)
                    {
                        buy_goods_price = "" + (contentItem.goodsUrlItem.taokeItem.price - contentItem.couponUrlItem.couponItem.money);
                    }
                    if (contentItem.goodsUrlItem != null)
                    {
                        click_url = "" + contentItem.goodsUrlItem.click_url;
                    }
                    if (contentItem.goodsUrlItem != null)
                    {
                        goods_title = "" + contentItem.goodsUrlItem.taokeItem.title;
                    }
                    if (contentWeixin.imgList != null && contentWeixin.imgList.Count>0)
                    {
                        goods_img =  "<IMG src=\""+contentWeixin.imgList[0]+ "\">" ;
                    }
                    if (contentItem.goodsUrlItem != null)
                    {
                        goods_type_name =  "1".Equals(contentItem.goodsUrlItem.taokeItem.userType)?"天猫":"淘宝";
                    }

                    if (!string.IsNullOrEmpty(pid)
                        && !string.IsNullOrEmpty(contentItem.num_iid)
                        && 
                        (
                        !string.IsNullOrEmpty(contentItem.coupon_url)
                        ||
                        !string.IsNullOrEmpty(contentItem.market_url)
                        )
                        )
                    {
                        string kouling = "";

                        string pc_coupon_url = "";
                        string m_coupon_url = "";
                        if (!string.IsNullOrEmpty(contentItem.market_url))
                        {
                            if (content.Contains("#淘口令#"))
                            {
                                string market_click_url = contentItem.market_url.Replace("mm_0_0_0", pid);
                                kouling = PidUtil.get_kouling_call(cmsForm, market_click_url, "", content_title, "");
                            }
                            if (content.Contains("#二合一短网址#"))
                            {
                                if (cmsForm.appBean.qunfa_duanlian)
                                {
                                    string market_click_url = contentItem.market_url.Replace("mm_0_0_0", pid);
                                    //u_land_short_url = ShortUrlUtil.get_url(cmsForm, uland_url);
                                    u_land_short_url = market_click_url;
                                }
                            }
                        }
                        else { 
                            string coupon_url = contentItem.coupon_url;
                            coupon_url = coupon_url.Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
                            string activityId = StringUtil.subString(coupon_url, 0, "activityId=", "&");
                            string sellerId = StringUtil.subString(coupon_url, 0, "sellerId=", "&");
                            string uland_url = Constants.uland_url.Replace("{activityId}", activityId).Replace("{pid}", pid).Replace("{itemId}", contentItem.num_iid).Replace("{dx}", "" + contentItem.dx);
                            //LogUtil.log_call(cmsForm, "---uland_url------" + uland_url);

                            if (contentItem.goodsUrlItem != null
                                && contentItem.goodsUrlItem.tkMktStatus==1
                                && !string.IsNullOrEmpty(contentItem.goodsUrlItem.click_url))
                            {
                                uland_url = contentItem.goodsUrlItem.click_url;
                            }

                            string api_uland_url = UserUtil.query_ali_api_url(cmsForm, contentItem.num_iid,pid,activityId);
                            if (!string.IsNullOrEmpty(api_uland_url))
                            {
                                uland_url = api_uland_url;

                                LogUtil.log_call(cmsForm, string.Concat("高佣金接口转化链接：", api_uland_url));
                            }

                            pc_coupon_url = Constants.coupon_url_pc.Replace("{seller_id}", sellerId).Replace("{activity_id}", activityId);
                            m_coupon_url = Constants.coupon_url_m.Replace("{seller_id}", sellerId).Replace("{activity_id}", activityId);

                            if (content.Contains("#淘口令#"))
                            {
                                kouling = PidUtil.get_kouling_call(cmsForm, uland_url, "", content_title, "");
                            }

                            if (content.Contains("#二合一短网址#"))
                            {
                                //if(cmsForm.appBean.qunfa_duanlian){
                                //    u_land_short_url = ShortUrlUtil.get_url(cmsForm, uland_url);
                                //}
                                u_land_short_url = UserUtil.query_short_url(cmsForm, uland_url);

                                //if(string.IsNullOrEmpty(u_land_short_url)){                            
                                //    KoulingBean koulingBean = AlimamaUtil.get_kouling(activityId, contentItem.num_iid, pid,""+ contentItem.dx, out  out_log);
                                //    if (!string.IsNullOrEmpty(koulingBean.url))
                                //    {
                                //       u_land_short_url =  koulingBean.url;
                                //    }
                                //}
                            }
                        }

                        content = content.Replace("\n", "<BR>");
                        content = content.Replace("#优惠券面额#", coupon_money);
                        content = content.Replace("#原价#", goods_price);
                        content = content.Replace("#淘口令#", kouling);
                        content = content.Replace("#券后价#", "" + buy_goods_price);
                        content = content.Replace("#优惠券电脑连接#", pc_coupon_url);
                        content = content.Replace("#优惠券手机连接#", m_coupon_url);
                        content = content.Replace("#商品地址#", click_url);
                        content = content.Replace("#文案#", wenan);
                        content = content.Replace("#二合一短网址#", u_land_short_url);
                        content = content.Replace("#商品标题#", goods_title);
                        content = content.Replace("#主图片#", goods_img);
                        content = content.Replace("#商品类型#", goods_type_name);
                        content = content.Replace("#视频介绍#", "");

                        content_send = content;

                        ContentWeixin contentWeixin_template = WeixinUtil.get_weixin_content(cmsForm, content, out out_log);
                        contentItem.content_weixin = contentWeixin_template.content_weixin;
                        contentItem.content_weixin_img = contentWeixin_template.content_weixin_img;
                        contentItem.imgList = contentWeixin_template.imgList;

                    }

                }
            }
            return content_send;
        }

        public static KoulingBean get_koulingBean(UrlItem urlItem, string pid, int dx)
        {

            string num_iid = urlItem.num_iid;
            string coupon_url = urlItem.m_url;
            coupon_url = HttpUtility.UrlDecode(coupon_url).Replace("seller_id=", "sellerId=").Replace("activity_id=", "activityId=");
            string activityId = StringUtil.subString(coupon_url, 0, "activityId=", "&");
            string sellerId = StringUtil.subString(coupon_url, 0, "sellerId=", "&");
            string uland_url = Constants.uland_url.Replace("{activityId}", activityId).Replace("{pid}", pid).Replace("{itemId}", num_iid).Replace("{dx}", "" + dx);

            string out_log;
            KoulingBean koulingBean = AlimamaUtil.get_kouling(activityId, num_iid, pid, "" + dx, out  out_log);
            return koulingBean;
        }

        public static bool isPrice(CmsForm cmsForm,double price)
        {
            if(price>0){
                if (cmsForm.appBean.qun_price1>0)
                {
                    if (cmsForm.appBean.qun_price1>price)
                    {
                        return false;
                    }
                }
                if (cmsForm.appBean.qun_price2 > 0)
                {
                    if (cmsForm.appBean.qun_price2 < price)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsExist(string uri)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(uri);
                req.Method = "HEAD";
                req.Timeout = 5000;
                res = (HttpWebResponse)req.GetResponse();
                return (res.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (res != null)
                {
                    res.Close();
                    res = null;
                }
                if (req != null)
                {
                    req.Abort();
                    req = null;
                }
            }
        }

       
    }
}
