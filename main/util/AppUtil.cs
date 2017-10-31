using com.haopintui;
using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace haopintui.util
{
    public class AppUtil
    {
        public static string apply_taoke_url_item(CmsForm cmsForm, ContentItem contentItem, UrlItem urlItem, string num_iid, string pid, ref int click_status, bool apply_jihua, int url_type)
        {
            string out_log;
            if(string.IsNullOrEmpty(pid)){
                LogUtil.log_call(cmsForm, "pid没有配置，无法完成转换连接");
                return null;
            }
            ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + num_iid, cmsForm.appBean.taoke_cookie, out out_log);
            if (out_log.Contains("\"wait\""))
            {
                int n = 0;
                while(n<2){
                    taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                    if(out_log.Contains("\"wait\"")){
                        n++;
                        LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                        Thread.Sleep(30000);
                    }
                }
            }
            TaokeItem taokeItem = null;
            //LogUtil.log_call(cmsForm, "1:" + num_iid);
            if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
            {
                //LogUtil.log_call(cmsForm, "2:");
                taokeItem = new TaokeItem();
                taokeItem.num_iid = num_iid;
                taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;
                taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;

                taokeItem.price = ((GoodsItem2)taoke_goods_list[0]).zkPrice;
                taokeItem.userType = ""+((GoodsItem2)taoke_goods_list[0]).userType;
                taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;

                taokeItem.tkMktStatus = ((GoodsItem2)taoke_goods_list[0]).tkMktStatus;
                taokeItem.eventRate = ((GoodsItem2)taoke_goods_list[0]).eventRate;

                urlItem.taokeItem = taokeItem;
                int status = 0;
                AppUtil.apply_taoke_url_item(cmsForm, contentItem, taokeItem, ref status, pid, ref click_status,apply_jihua,  url_type);
                if(!string.IsNullOrEmpty(taokeItem.short_url)){
                    return taokeItem.short_url;
                }
            }
            return null;
        }

        public static string apply_taoke_url(CmsForm cmsForm, ContentItem contentItem, string url,string pid)
        {
            if(!string.IsNullOrEmpty(url)){
                string out_log;
                int n = 0;
            apply_click:
                LogUtil.log_call(cmsForm, "开始转化活动链接:");
                string[] pid_list = Regex.Split(pid, "_", RegexOptions.IgnoreCase);
                string adzoneid = "";
                string siteid = "";
                if (pid_list.Length > 3)
                {
                    siteid = pid_list[2];
                    adzoneid = pid_list[3];
                }
                AlimamaClick alimamaClick = AlimamaUtil.query_taoke_click(cmsForm.appBean.taoke_cookie, url, adzoneid, siteid, out out_log);
                if (alimamaClick != null)
                {
                    return alimamaClick.short_url;
                }
                else
                {
                    if (out_log.Contains("\"wait\""))
                    {
                        if (n < 10)
                        {
                            n = n + 10;
                            LogUtil.log_call(cmsForm, "申请过快，休息60秒:");
                            Thread.Sleep(60000);
                            goto apply_click;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else if (out_log.Contains("callLocation") || out_log.Contains("gen url item not found on call"))
                    {
                        //LogUtil.log_call(cmsForm, "[该链接转化失败。]");
                    }
                    else
                    {
                        if (n < 3)
                        {
                            n++;
                            LogUtil.log_call(cmsForm, "检测登录状态:");
                            AppUtil.alimama_login(cmsForm);
                            Thread.Sleep(1000);
                            goto apply_click;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

            }
            return null;
        }

        public static void apply_taoke_url_item(CmsForm cmsForm, ContentItem contentItem, TaokeItem taokeItem, ref int status, string pid, ref int click_status, bool apply_jihua, int url_type)
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

            //LogUtil.log_call(cmsForm, "taokeItem.num_iid:" + taokeItem.num_iid);
            if (!string.IsNullOrEmpty(taokeItem.num_iid))
            {
                string out_log = "";
                int n = 0;
                if(apply_jihua){
                    //LogUtil.log_call(cmsForm, "开始计划的检测:");
                campaign:
                    ArrayList goods_campaign_list = AlimamaUtil.query_campaign_list(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, out out_log);
                    CampaignItem1 campaignItem_current = null; //最高计划
                    CampaignItem1 campaignItem_current_auto = null; //最高自动计划
                    CampaignItem1 campaignItem_current_apply = null; //已经申请的计划
                    if (goods_campaign_list != null && goods_campaign_list.Count > 0)
                    {
                        foreach (CampaignItem1 campaignItem1 in goods_campaign_list)
                        {
                            if (campaignItem1.commissionRate >= taokeItem.tkRate
                                && (campaignItem_current == null
                                || campaignItem_current.commissionRate < campaignItem1.commissionRate))
                            {
                                campaignItem_current = campaignItem1;
                            }
                            if (campaignItem1.commissionRate >= taokeItem.tkRate
                                && campaignItem1.manualAudit == "0" &&
                                (campaignItem_current_auto == null
                                || campaignItem_current_auto.commissionRate < campaignItem1.commissionRate))
                            {
                                campaignItem_current_auto = campaignItem1;
                            }
                            if (campaignItem1.Exist == "true")
                            {
                                campaignItem_current_apply = campaignItem1;
                            }
                        }
                    }
                    else
                    {
                        if (out_log.Contains("\"wait\""))
                        {
                            if (n < 10)
                            {
                                n = n + 10;
                                LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                                Thread.Sleep(60000);
                                goto campaign;
                            }
                            else {
                                return;
                            }
                        }
                        else if(out_log.Contains("\"ok\":true")){
                    
                        }
                        else {
                            if (n < 3)
                            {
                                n++;
                                LogUtil.log_call(cmsForm, "检测登录状态:");
                                AppUtil.alimama_login(cmsForm);
                                Thread.Sleep(3000);
                                goto campaign;
                            }
                            else {
                                //return;
                            }
                        }
                    }

                    out_log = "";
                    n = 0;
                apply_campaign:
                    if (campaignItem_current_auto != null)
                    {
                        if (campaignItem_current_auto.Exist == "true")
                        {
                            //LogUtil.log_call(cmsForm, "定向计划【" + campaignItem_current_auto.CampaignName + "】已经申请过。本次跳过重复申请");
                        }
                        else
                        {
                            LogUtil.log_call(cmsForm, "开始申请定向计划【" + campaignItem_current_auto.CampaignName + "】");
                            AlimamaUtil.apply_campaign(cmsForm, campaignItem_current_auto.CampaignID
                                , campaignItem_current_auto.ShopKeeperID, Constants.applyreason_pre, cmsForm.appBean.applyreason, cmsForm.appBean.taoke_cookie, out out_log,"");
                            if (out_log.Contains("\"wait\""))
                            {
                                if (n < 10)
                                {
                                    n = n + 10;
                                    LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                                    Thread.Sleep(60000);
                                    goto apply_campaign;
                                }
                                else
                                {
                                    //return;
                                }
                            }
                        }
                    }
                    else if (campaignItem_current != null)
                    {
                        if (campaignItem_current.Exist == "true")
                        {
                            //LogUtil.log_call(cmsForm, "定向计划【" + campaignItem_current.CampaignName + "】已经申请过。本次跳过重复申请");
                        }
                        else
                        {
                            LogUtil.log_call(cmsForm, "开始申请定向计划【" + campaignItem_current.CampaignName + "】");
                            AlimamaUtil.apply_campaign(cmsForm, campaignItem_current.CampaignID
                                , campaignItem_current.ShopKeeperID, Constants.applyreason_pre, cmsForm.appBean.applyreason, cmsForm.appBean.taoke_cookie, out out_log, "");
                            if (out_log.Contains("\"wait\""))
                            {
                                if (n < 10)
                                {
                                    n = n + 10;
                                    LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                                    Thread.Sleep(60000);
                                    goto apply_campaign;
                                }
                                else
                                {
                                    //return;
                                }
                            }
                        }
                    }

                    out_log = "";
                    n = 0;
                apply_event:
                    GoodsItem2 goodsItem2 = AlimamaUtil.query_taoke_item_event(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, out out_log);
                    url_type = 0;
                    if (goodsItem2 != null
                        && taokeItem.tkRate < goodsItem2.eventRate
                        && (campaignItem_current_auto == null
                        || campaignItem_current_auto.commissionRate < goodsItem2.eventRate))
                    {
                        url_type = 1;
                    }
                    else
                    {
                        if (out_log.Contains("\"wait\""))
                        {
                            if (n < 10)
                            {
                                n = n + 10;
                                LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                                Thread.Sleep(60000);
                                goto apply_event;
                            }
                            else
                            {
                                //return;
                            }
                        }
                    }

                    double commission_rate = 0;
                    if (url_type == 1)
                    {
                        LogUtil.log_call(cmsForm, "通过鹊桥计划转换链接：佣金比例【" + goodsItem2.eventRate + "%】");
                        commission_rate = goodsItem2.eventRate;
                        contentItem.dx = 0;
                    }
                    else
                    {
                        contentItem.dx = 1;
                        if (campaignItem_current_auto != null)
                        {
                            LogUtil.log_call(cmsForm, "通过定向计划转换链接：佣金比例【" + campaignItem_current_auto.commissionRate + "%】");
                            commission_rate = campaignItem_current_auto.commissionRate;
                            taokeItem.auto_Rate = campaignItem_current_auto.commissionRate;
                        }
                        else
                        {
                            if (campaignItem_current != null)
                            {
                                LogUtil.log_call(cmsForm, "通过通用计划转换链接：佣金比例【" + taokeItem.tkRate + "%】 定向计划【" + campaignItem_current.CampaignName + "】审核通过后，会自动走高佣金【" + campaignItem_current.commissionRate + "%】");
                                commission_rate = taokeItem.tkRate;
                            }
                            else
                            {
                                if (campaignItem_current_apply!=null)
                                {
                                    AlimamaUtil.exitCampaign(taokeItem.user_num_id, campaignItem_current_apply.CampaignID, cmsForm.appBean.taoke_cookie, out out_log);
                                    if (!string.IsNullOrEmpty(out_log))
                                    {
                                        LogUtil.log_call(cmsForm, out_log);
                                    }
                                }
                                LogUtil.log_call(cmsForm, "通过通用计划转换链接：佣金比例【" + taokeItem.tkRate + "%】");
                                commission_rate = taokeItem.tkRate;
                            }
                        }
                    }


                    //LogUtil.log_call(cmsForm, "【commission_rate：" + commission_rate + "】");
                    if (qunfa_commission>commission_rate)
                    {
                        //LogUtil.log_call(cmsForm, "佣金比例小于设置最低佣金比例，转换失败");
                        click_status = 2;
                        //return;
                    }
                    contentItem.url_type = url_type;
                }

                out_log = "";
                n = 0;
            apply_click:
                string[] pid_list = Regex.Split(pid, "_", RegexOptions.IgnoreCase);
                string adzoneid = "";
                string siteid = "";
                if (pid_list.Length>3)
                {
                    siteid = pid_list[2];
                    adzoneid = pid_list[3];
                }
                AlimamaClick alimamaClick = AlimamaUtil.query_taoke_click(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, adzoneid, siteid, url_type, out out_log);
                if (alimamaClick != null)
                {
                    taokeItem.click_url = alimamaClick.url;
                    taokeItem.short_url = alimamaClick.short_url;
                    if (taokeItem.tkMktStatus==1
                        && !String.IsNullOrEmpty(alimamaClick.coupon_short_url)
                        && alimamaClick.coupon_short_url.Contains("http"))
                    {
                        taokeItem.click_url = alimamaClick.coupon_url;
                        taokeItem.short_url = alimamaClick.coupon_short_url;
                    }
                }
                else
                {
                    if (out_log.Contains("\"wait\""))
                    {
                        if (n < 10)
                        {
                            n = n + 10;
                            LogUtil.log_call(cmsForm, "申请过快，休息30秒:");
                            Thread.Sleep(60000);
                            goto apply_click;
                        }
                        else
                        {
                            //return;
                        }
                    }
                    else if (out_log.Contains("callLocation") || out_log.Contains("gen url item not found on call"))
                    {
                        //LogUtil.log_call(cmsForm, "[该商品已经下架或者退出了淘客推广。]");
                    }
                    else {
                        //LogUtil.log_call(cmsForm,"[转化失败的原因：]"+out_log);
                    }
                }


            }
        }

        public static void alimama_login(CmsForm cmsForm){
            int n = 0;
            while(n<10){
                if (!AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie)
                    && Process.GetProcessesByName(Constants.alimama_login_exe_name).Length <= 0)
                {
                    LogUtil.log_call(cmsForm, "阿里妈妈登录过期。正在开始重新登录");
                    if (cmsForm.checkBoxAutoLogin.Checked)
                    {
                        AlimamaLogin.login(cmsForm, 1);
                    }
                    else
                    {
                        LogUtil.log_call(cmsForm, "没有开启阿里妈妈自动登录，无法完成登录");
                        return;
                    }
                }
                else if (AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
                {
                    LogUtil.log_call(cmsForm, "阿里妈妈登录正常");
                    return;
                }
                else if (Process.GetProcessesByName(Constants.alimama_login_exe_name).Length > 0)
                {
                    LogUtil.log_call(cmsForm, "登录窗口正在运行中");
                    Thread.Sleep(3000);
                }
                n++;
            }
        }

    }
}
