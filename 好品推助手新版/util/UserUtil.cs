using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using util;
using System.Net;
using com.haopintui;
using haopintui.entity;
using System.Windows.Forms;
using System.Diagnostics;
using LitJson;
using System.Threading;

namespace haopintui
{
    public class UserUtil
    {
        public static ArrayList query_cms_list(CmsForm cmsForm)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String cms_url = Constants.cms_url;
            //LogUtil.log_call(cmsForm, "user_id=" + user_id + "&user_name=" + user_name + "&user_key=" + user_key + "&user_token=");
            String body = httpservice.post_http(cms_url, "user_id=" + user_id + "&user_name=" + user_name + "&user_key=" + user_key + "&user_token=", null);
            //LogUtil.log_call(cmsForm, "query_cms_list：" + body);

            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

            ArrayList list = new ArrayList();
            for (int i = body.IndexOf("items"); (i = body.IndexOf("\"app_id\"",i)) != -1; i++)
            {
                UserCms userCms = new UserCms();
                userCms.app_id = StringUtil.subString(body, i, "\"app_id\":\"", "\"");
                userCms.user_id = StringUtil.subString(body, i, "\"user_id\":\"", "\"");
                String cms_title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                cms_title = UnicodeUtil.Unicode2String(cms_title);
                userCms.title = cms_title;
                
                list.Add(userCms);
            }
            return list;

        }

        public static ArrayList query_taoke_item_list(CmsForm cmsForm)
        {
            ArrayList list = new ArrayList();
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_taoke_url = Constants.user_taoke_url;
                //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
                String body = httpservice.post_http(user_taoke_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
                //LogUtil.log_cms_call(cmsForm, "query_taoke_item_list：" + body);

                for (int i = body.IndexOf("items"); (i = body.IndexOf("\"num_iid\"", i)) != -1; i++)
                {
                    TaokeItem taokeItem = new TaokeItem();
                    taokeItem.num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");
                    taokeItem.user_id = StringUtil.subString(body, i, "\"user_id\":\"", "\"");
                    taokeItem.app_id = StringUtil.subString(body, i, "\"app_id\":\"", "\"");
                    taokeItem.activity_id = StringUtil.subString(body, i, "\"activity_id\":\"", "\"");
                    taokeItem.user_num_id = StringUtil.subString(body, i, "\"user_num_id\":\"", "\"");
                    taokeItem.pic_url = StringUtil.subString(body, i, "\"pic_url\":\"", "\"");
                    //taokeItem.title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                    String goods_title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                    goods_title = UnicodeUtil.Unicode2String(goods_title);
                    taokeItem.title = goods_title;

                    taokeItem.tkRate = double.Parse(StringUtil.subString(body, i, "\"common_commission_rate\":\"", "\""));
                    taokeItem.taoke_status = int.Parse(StringUtil.subString(body, i, "\"taoke_status\":", ","));
                    //taokeItem.taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                    String taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                    taoke_status_err = UnicodeUtil.Unicode2String(taoke_status_err);
                    taokeItem.taoke_status_err = taoke_status_err;
                    list.Add(taokeItem);
                }
            }
            catch (Exception)
            {
                
            }
            return list;

        }

        public static UserCmsBean query_taoke_item_list_html(CmsForm cmsForm)
        {
            UserCmsBean userCmsBean = new UserCmsBean();
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_taoke_url = "http://" + Constants.user_cms_data_url +"/"+ app_id + ".html";
                //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
                String body = httpservice.get(user_taoke_url,null);
                //LogUtil.log_cms_call(cmsForm, "query_taoke_item_list：" + body);

                string code = StringUtil.subString(body, 0, "<data>", "</data>");
                //LogUtil.log_cms_call(cmsForm, "code：" + code);
                if(!string.IsNullOrEmpty(code)){
                    userCmsBean.app_id = app_id;
                    userCmsBean.user_id = ""+user_id;
                    ArrayList itemList = new ArrayList();

                    JsonData jo = JsonMapper.ToObject(code);
                    //string app_id = (String)jo["app_id"];
                    //string user_id = (String)jo["user_id"];
                    JsonData itemsList = jo["items"];
                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        JsonData jo_item = (String)itemsList[i];

                        CmsPlanItem cmsPlanItem = new CmsPlanItem();
                        cmsPlanItem.num_iid = jo_item.ToString();

                        itemList.Add(cmsPlanItem);
                        //LogUtil.log_cms_call(cmsForm, "jo_item：" + jo_item);
                    }
                    userCmsBean.items = itemList;
                }
            }
            catch (Exception)
            {

            }
            cmsForm.appBean.userCmsBean = userCmsBean;
            return userCmsBean;

        }

        public static UserCmsBean query_taoke_item_list_html_online(CmsForm cmsForm)
        {
            UserCmsBean userCmsBean = new UserCmsBean();
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_taoke_url = "http://" + Constants.user_cms_data_url + "/" + app_id + "_.html";
                //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
                String body = httpservice.get(user_taoke_url, null);
                //LogUtil.log_cms_call(cmsForm, "query_taoke_item_list：" + body);

                string code = StringUtil.subString(body, 0, "<data>", "</data>");
                //LogUtil.log_cms_call(cmsForm, "code：" + code);
                if (!string.IsNullOrEmpty(code))
                {
                    userCmsBean.app_id = app_id;
                    userCmsBean.user_id = "" + user_id;
                    ArrayList itemList = new ArrayList();

                    JsonData jo = JsonMapper.ToObject(code);
                    //string app_id = (String)jo["app_id"];
                    //string user_id = (String)jo["user_id"];
                    JsonData itemsList = jo["items_pid"];
                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        //JsonData jo_item = (String)itemsList[i];
                        JsonData jo_item = itemsList[i];
                        string num_iid = (string)jo_item["num_iid"];
                        string pid = (string)jo_item["pid"];

                        CmsPlanItem cmsPlanItem = new CmsPlanItem();
                        cmsPlanItem.num_iid = num_iid;
                        cmsPlanItem.pid = pid;

                        string out_log;
                        ArrayList arrayList = cmsForm.sendSqlUtil.query_cms_item_plan(cmsPlanItem.num_iid + cmsPlanItem.pid, 6, out out_log);
                        if (arrayList.Count <= 0)
                        {
                            //itemList.Add(jo_item.ToString());
                            itemList.Add(cmsPlanItem);
                        }
                        //LogUtil.log_cms_call(cmsForm, "jo_item：" + jo_item);
                    }
                    userCmsBean.items = itemList;
                }
            }
            catch (Exception)
            {

            }
            cmsForm.appBean.userCmsBean_user = userCmsBean;
            return userCmsBean;

        }

        public static UserCmsBean query_taoke_item_list_user(CmsForm cmsForm)
        {
            UserCmsBean userCmsBean = new UserCmsBean();
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_taoke_url = Constants.user_taoke_url_user;
                //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
                //String body = httpservice.get(user_taoke_url, null);
                String body = httpservice.post_http(user_taoke_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);

                //LogUtil.log_cms_call(cmsForm, "query_taoke_item_list：" + body);

                //string code = StringUtil.subString(body, 0, "<data>", "</data>");
                //LogUtil.log_cms_call(cmsForm, "code：" + code);
                if (!string.IsNullOrEmpty(body))
                {
                    userCmsBean.app_id = app_id;
                    userCmsBean.user_id = "" + user_id;
                    ArrayList itemList = new ArrayList();

                    //JsonData jo = JsonMapper.ToObject(body);
                    ////string app_id = (String)jo["app_id"];
                    ////string user_id = (String)jo["user_id"];
                    //JsonData itemsList = jo["result"]["map"]["items"];
                    //for (int i = 0; i < itemsList.Count; i++)
                    //{
                    //    JsonData jo_item = (JsonData)itemsList[i];
                    //    itemList.Add(jo_item["num_iid"].ToString());
                    //    //LogUtil.log_cms_call(cmsForm, "jo_item：" + jo_item);
                    //}
                    for (int i = body.IndexOf("items"); (i = body.IndexOf("\"num_iid\"", i)) != -1; i++)
                    {
                        string num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");

                        CmsPlanItem cmsPlanItem = new CmsPlanItem();
                        cmsPlanItem.num_iid = num_iid;
                        //cmsPlanItem.pid = pid;

                        itemList.Add(cmsPlanItem);
                    }
                    userCmsBean.items = itemList;
                }
            }
            catch (Exception ex)
            {
                //LogUtil.log_cms_call(cmsForm, "query_taoke_item_list：" + ex.ToString());
            }
            cmsForm.appBean.userCmsBean_user = userCmsBean;
            return userCmsBean;

        }

        public static bool submit_taoke_item(CmsForm cmsForm,AlimamaClick alimamaClick)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_taoke_create_url = Constants.user_taoke_create_url;
            string datastr = String.Concat(
                 "user_id="+user_id
                ,"&user_key="+user_key
                ,"&user_token="
                ,"&app_id=" + app_id
                , "&num_iid=" + alimamaClick.num_iid
                , "&url=" + alimamaClick.url
                , "&coupon_url=" + alimamaClick.coupon_url
                , "&short_url=" + alimamaClick.short_url
                , "&tao_token=" + alimamaClick.tao_token
                , "&coupon_link_tao_token=" + alimamaClick.coupon_link_tao_token
            );
            //LogUtil.log_str(cmsForm, datastr);
            String body = httpservice.post_http(user_taoke_create_url, datastr, null);
            return true;

        }
        public static bool submit_taoke_items(CmsForm cmsForm, ArrayList items)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_taoke_create_url = Constants.user_taoke_create_url;
            string datastr = String.Concat(
                 "user_id=" + user_id
                , "&user_key=" + user_key
                , "&user_token="
                , "&app_id=" + app_id
            );

             for (int i = 0; i < items.Count; i++)
            {
                AlimamaClick item = (AlimamaClick)items[i];

                datastr = String.Concat(
                    datastr
                    , "&num_iid[]=" + item.num_iid
                    , "&url[]=" + item.url
                    , "&coupon_url[]=" + item.coupon_url
                    , "&short_url[]=" + item.short_url
                    , "&tao_token[]=" + item.tao_token
                    , "&coupon_link_tao_token[]=" + item.coupon_link_tao_token
                );
            }

             //LogUtil.log_cms_call(cmsForm, datastr);
            String body = httpservice.post_http(user_taoke_create_url, datastr, null);
            //LogUtil.log_cms_call(cmsForm, body);
            return true;

        }

        public static bool submit_taoke_item_plan(CmsForm cmsForm, TaokeItem taokeItem)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_taoke_create_url_plan = Constants.user_taoke_create_url_plan;
            string datastr = String.Concat(
                 "user_id=" + user_id
                , "&user_key=" + user_key
                , "&user_token="
                , "&app_id=" + app_id
                , "&num_iid=" + taokeItem.num_iid
                , "&pid=" + taokeItem.pid
                , "&url=" + taokeItem.short_url
                , "&tao_token=" + taokeItem.tao_token
                , "&market_create_date=" + taokeItem.couponEffectiveStartTime
                , "&market_end_date=" + taokeItem.couponEffectiveEndTime
            );
            //LogUtil.log_cms_call(cmsForm, datastr);
            String body = httpservice.post_http(user_taoke_create_url_plan, datastr, null);

            //CmsUtil.add_queue_taoke_plan_url(cmsForm, taokeItem);
            return true;

        }

        public static GoodsItem query_goods(CmsForm cmsForm, string num_iid,out string out_log)
        {
            try
            {
                //LogUtil.log_cms_call(cmsForm, ".num_iid：" + num_iid);

                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_goods_url = Constants.user_goods_url;
                //LogUtil.log_cms_call(cmsForm, "user_goods_url：" + user_goods_url);
                //LogUtil.log_cms_call(cmsForm, "user_id=" + user_id + "&num_iid=" + num_iid + "&user_key=" + user_key + "&user_token=");
                String body = httpservice.post_http(user_goods_url, "user_id=" + user_id + "&num_iid=" + num_iid + "&user_key=" + user_key + "&user_token=", null);
                //LogUtil.log_cms_call(cmsForm, "query_goods：" + body);
                if (body.Contains("\"num_iid\":"))
                {
                    GoodsItem goodsItem = new GoodsItem();
                    //goodsItem.title = StringUtil.subString(body, 0, "\"title\":\"", "\"");
                    String cms_title = StringUtil.subString(body, 0, "\"title\":\"", "\"");
                    cms_title = UnicodeUtil.Unicode2String(cms_title);
                    goodsItem.title = cms_title;

                    goodsItem.num_iid = num_iid;
                    out_log = "";
                    return goodsItem;
                }
                out_log = body;
                return null;
            }
            catch (Exception exception)
            {
                //LogUtil.log_cms_call(cmsForm, "query_goods：" + "出错啦！！！" + exception.ToString());
                out_log = "出错啦！！！" + exception.ToString();
                return null;
            }
        }

        public static UserCmsTongji query_user_cms_tongji(CmsForm cmsForm, out string out_log)
        {
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String cms_tongji_url = Constants.cms_tongji_url;
                String body = httpservice.post_http(cms_tongji_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
                //LogUtil.log_cms_call(cmsForm, "body：" + body);
                if (body.Contains("\"all\":"))
                {
                    UserCmsTongji userCmsTongji = new UserCmsTongji();
                    userCmsTongji.all = int.Parse(StringUtil.subString(body, 0, "\"all\":\"", "\","));
                    userCmsTongji.have = int.Parse(StringUtil.subString(body, 0, "\"have\":\"", "\""));
                    out_log = "";
                    return userCmsTongji;
                }
                out_log = body;
                return null;
            }
            catch (Exception exception)
            {
                //LogUtil.log_cms_call(cmsForm, "query_goods：" + "出错啦！！！" + exception.ToString());
                out_log = "出错啦！！！" + exception.ToString();
                return null;
            }
        }

        public static ArrayList query_gengfa_item_list(CmsForm cmsForm)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_qunfa_url = Constants.user_qunfa_url;
            //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
            String body = httpservice.post_http(user_qunfa_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
            //LogUtil.log_call(cmsForm, "query_taoke_item_list：" + body);

            ArrayList list = new ArrayList();
            for (int i = body.IndexOf("items"); (i = body.IndexOf("\"create_date_str\"", i)) != -1; i++)
            {
                //TaokeItem taokeItem = new TaokeItem();
                //taokeItem.num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");
                //taokeItem.user_id = StringUtil.subString(body, i, "\"user_id\":\"", "\"");
                //taokeItem.app_id = StringUtil.subString(body, i, "\"app_id\":\"", "\"");
                //taokeItem.activity_id = StringUtil.subString(body, i, "\"activity_id\":\"", "\"");
                //taokeItem.user_num_id = StringUtil.subString(body, i, "\"user_num_id\":\"", "\"");
                //taokeItem.pic_url = StringUtil.subString(body, i, "\"pic_url\":\"", "\"");
                ////taokeItem.title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //String goods_title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //goods_title = UnicodeUtil.Unicode2String(goods_title);
                //taokeItem.title = goods_title;

                //taokeItem.tkRate = double.Parse(StringUtil.subString(body, i, "\"common_commission_rate\":\"", "\""));
                //taokeItem.taoke_status = int.Parse(StringUtil.subString(body, i, "\"taoke_status\":", ","));
                ////taokeItem.taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                //String taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                //taoke_status_err = UnicodeUtil.Unicode2String(taoke_status_err);
                //taokeItem.taoke_status_err = taoke_status_err;

                GengfaItem gengfaItem = new GengfaItem();
                gengfaItem.create_date_str = StringUtil.subString(body, i, "\"create_date_str\":\"", "\",");
                gengfaItem.num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");
                //gengfaItem.price = StringUtil.subString(body, i, "\"price\":\"", "\"");
                //gengfaItem.money = StringUtil.subString(body, i, "\"money\":\"", "\"");
                //gengfaItem.user_num_id = StringUtil.subString(body, i, "\"user_num_id\":\"", "\"");
                //gengfaItem.title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //gengfaItem.activity_id = StringUtil.subString(body, i, "\"activity_id\":\"", "\"");
                //gengfaItem.pic_url = StringUtil.subString(body, i, "\"pic_url\":\"", "\"");

                string content = StringUtil.subString(body, i, "\"content\":\"", "\",");
                content = content.Replace(@"\/", @"/");
                content = content.Replace("\\\"", "\"");
                content = UnicodeUtil.Unicode2String(content);
                gengfaItem.content = content;

                string from = StringUtil.subString(body, i, "\"from\":\"", "\",");
                from = UnicodeUtil.Unicode2String(from);
                gengfaItem.from = from;

                string goods_type = StringUtil.subString(body, i, "\"goods_type\":\"", "\",");
                gengfaItem.goods_type = goods_type;

                int type =  int.Parse(StringUtil.subString(body, i, "\"type\":", ","));
                gengfaItem.type = type;

                list.Add(gengfaItem);

            }
            return list;

        }

        public static ArrayList query_gengfa_top_item_list(CmsForm cmsForm)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_qunfa_url = "http://"+Constants.top_data_plug_url+"/top1.html";
            //user_qunfa_url = "http://api2.open.huopinjie.com/top1.html";
            //user_qunfa_url = "http://api.open.huopinjie.com/index.php?action=index&type=top1&appkey=yr57d3jhah&v=utf-8";
            //user_qunfa_url = "http://api.open.huopinjie.com/index.php?action=index&type=top1&appkey=yr57d3jhah&v=utf-8";
            //LogUtil.log_str(cmsForm, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=");
            //String body = httpservice.post_http(user_qunfa_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
            //LogUtil.log_call(cmsForm, "user_qunfa_url：" + user_qunfa_url);

            String body = httpservice.get(user_qunfa_url, null);

            ArrayList list = new ArrayList();
            for (int i = body.IndexOf("items"); (i = body.IndexOf("\"create_date_str\"", i)) != -1; i++)
            {
                //TaokeItem taokeItem = new TaokeItem();
                //taokeItem.num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");
                //taokeItem.user_id = StringUtil.subString(body, i, "\"user_id\":\"", "\"");
                //taokeItem.app_id = StringUtil.subString(body, i, "\"app_id\":\"", "\"");
                //taokeItem.activity_id = StringUtil.subString(body, i, "\"activity_id\":\"", "\"");
                //taokeItem.user_num_id = StringUtil.subString(body, i, "\"user_num_id\":\"", "\"");
                //taokeItem.pic_url = StringUtil.subString(body, i, "\"pic_url\":\"", "\"");
                ////taokeItem.title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //String goods_title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //goods_title = UnicodeUtil.Unicode2String(goods_title);
                //taokeItem.title = goods_title;

                //taokeItem.tkRate = double.Parse(StringUtil.subString(body, i, "\"common_commission_rate\":\"", "\""));
                //taokeItem.taoke_status = int.Parse(StringUtil.subString(body, i, "\"taoke_status\":", ","));
                ////taokeItem.taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                //String taoke_status_err = StringUtil.subString(body, i, "\"taoke_status_err\":\"", "\"");
                //taoke_status_err = UnicodeUtil.Unicode2String(taoke_status_err);
                //taokeItem.taoke_status_err = taoke_status_err;

                GengfaItem gengfaItem = new GengfaItem();
                gengfaItem.create_date_str = StringUtil.subString(body, i, "\"create_date_str\":\"", "\",");
                gengfaItem.num_iid = StringUtil.subString(body, i, "\"num_iid\":\"", "\"");
                //gengfaItem.price = StringUtil.subString(body, i, "\"price\":\"", "\"");
                //gengfaItem.money = StringUtil.subString(body, i, "\"money\":\"", "\"");
                //gengfaItem.user_num_id = StringUtil.subString(body, i, "\"user_num_id\":\"", "\"");
                //gengfaItem.title = StringUtil.subString(body, i, "\"title\":\"", "\"");
                //gengfaItem.activity_id = StringUtil.subString(body, i, "\"activity_id\":\"", "\"");
                //gengfaItem.pic_url = StringUtil.subString(body, i, "\"pic_url\":\"", "\"");

                string content = StringUtil.subString(body, i, "\"content\":\"", "\",");
                content = content.Replace(@"\/", @"/");
                content = content.Replace("\\\"", "\"");
                content = UnicodeUtil.Unicode2String(content);
                gengfaItem.content = content;

                string from = StringUtil.subString(body, i, "\"from\":\"", "\",");
                from = UnicodeUtil.Unicode2String(from);
                gengfaItem.from = from;

                string goods_type = StringUtil.subString(body, i, "\"goods_type\":\"", "\",");
                gengfaItem.goods_type = goods_type;

                int type = int.Parse(StringUtil.subString(body, i, "\"type\":", ","));
                gengfaItem.type = type;

                list.Add(gengfaItem);

            }
            return list;

        }

        public static bool isQuanfa(CmsForm cmsForm){
            if (cmsForm.appBean.qunfa=="1")
            {
                return true;
            }
            string content = UserUtil.query_user_sms(cmsForm);
            if (string.IsNullOrEmpty(content))
            {
                content = "群发功能暂时未开通";
            }
            MessageBox.Show(content, "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Process.Start("http://www.haopintui.net/user_info.php?action=user&mod=function");
            return false;
        }

        public static string query_user_sms(CmsForm cmsForm)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String sms_url = Constants.sms_url;
            String body = httpservice.post_http(sms_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
            //LogUtil.log_call(cmsForm, "query_user_sms：" + body);
            if (body.Contains("<content>"))
            {
                string content = StringUtil.subString(body, 0, "<content>", "</content>");
                return content;
            }
            return "";
        }
        public static void query_user_cms_tongzhi(CmsForm cmsForm, out string out_log)
        {
            out_log = "";
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String cms_tongzhi_url = Constants.cms_tongzhi_url;
                String body = httpservice.post_http(cms_tongzhi_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);
            }
            catch (Exception exception)
            {
                out_log = "出错啦！！！" + exception.ToString();
            }
        }


        public static void updata_user_info(Object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            while(true){
                if (!string.IsNullOrEmpty(cmsForm.appBean.qunfa)
                &&int.Parse(cmsForm.appBean.qunfa)>0)
                {
                    string url = Constants.login_user_url;
                    string str2 = cmsForm.httpService.post_http(url, "user_id=" + cmsForm.appBean.user_id, null);
                    str2 = str2.Trim();
                    try
                    {
                        JsonData jo = JsonMapper.ToObject(str2);
                        if (jo["result"] != null
                            && jo["result"]["map"] != null
                            && jo["result"]["map"]["item"] != null)
                        {
                            string msg = jo["result"]["map"]["item"]["msg"].ToString();
                            if (msg.Equals("ok"))
                            {

                                //cmsForm.appBean.feetype = jo["result"]["map"]["item"]["feetype"].ToString();
                                //cmsForm.appBean.expiredate = jo["result"]["map"]["item"]["expiredate"].ToString();
                                cmsForm.appBean.user_id = long.Parse(jo["result"]["map"]["item"]["user_id"].ToString());
                                cmsForm.appBean.user_key = jo["result"]["map"]["item"]["user_key"].ToString();
                                cmsForm.appBean.qunfa = jo["result"]["map"]["item"]["qunfa"].ToString();
                                cmsForm.appBean.alimama_id = jo["result"]["map"]["item"]["alimama_id"].ToString();
                                cmsForm.appBean.qunfa_date = jo["result"]["map"]["item"]["qunfa_date"].ToString();
                                cmsForm.appBean.user_type_name = jo["result"]["map"]["item"]["user_type_name"].ToString();

                            }
                        }
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("哪里不对了，好像您的网络不通哦，请重新启动本程序！");
                    }
                }
                Thread.Sleep(3600*1000);
            }
        }

        public static string query_click_url(CmsForm cmsForm
            ,string pid,string id,string url)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String click_url = Constants.user_goods_click_url;
            String body = httpservice.post_http(click_url
                , "user_id=" + user_id 
                + "&app_id=" + app_id
                + "&user_key=" + user_key
                + "&pid=" + pid
                + "&id=" + id
                + "&user_token="
                + "&url=" + System.Web.HttpUtility.UrlEncode(url, System.Text.Encoding.Unicode)
                , null);

            //LogUtil.log_call(cmsForm, "query_click_url——啊啊啊：" + "user_id=" + user_id
            //    + "&app_id=" + app_id
            //    + "&user_key=" + user_key
            //    + "&pid=" + pid
            //    + "&id=" + id
            //    + "&user_token="
            //    + "&url=" + System.Web.HttpUtility.UrlEncode(url, System.Text.Encoding.Unicode));
            //LogUtil.log_call(cmsForm, "query_click_url：" + body);
            if (body.Contains("<content>"))
            {
                string content = StringUtil.subString(body, 0, "<content>", "</content>");
                return content;
            }
            return "";
        }


        public static string query_short_url(CmsForm cmsForm
            , string url)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String click_url = Constants.user_short_url;
            String body = httpservice.post_http(click_url
                , "user_id=" + user_id
                + "&app_id=" + app_id
                + "&user_key=" + user_key
                + "&user_token="
                + "&url=" + System.Web.HttpUtility.UrlEncode(url, System.Text.Encoding.UTF8)
                , null);

            if (body.Contains("<content>"))
            {
                string content = StringUtil.subString(body, 0, "<content>", "</content>");
                return content;
            }
            return "";
        }

        public static string query_ali_api_url(CmsForm cmsForm
           , string num_iid, string pid, string activity_id)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String click_url = Constants.goods_api_url;
            String body = httpservice.post_http(click_url
                , "user_id=" + user_id
                + "&app_id=" + app_id
                + "&user_key=" + user_key
                + "&user_token="
                + "&num_iid=" + num_iid
                + "&pid=" + pid
                + "&activity_id=" + activity_id
                , null);

            if (body.Contains("<content>"))
            {
                string content = StringUtil.subString(body, 0, "<content>", "</content>");
                return content;
            }
            return "";
        }

        public static CouponStatusBean query_coupon_status(CmsForm cmsForm)
        {
            CouponStatusBean couponStatusBean = new CouponStatusBean();
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_coupon_status_url = Constants.user_coupon_status_url;
                String body = httpservice.post_http(user_coupon_status_url, "user_id=" + user_id + "&app_id=" + app_id + "&user_key=" + user_key + "&user_token=", null);

                //LogUtil.log_cms_call(cmsForm, "user_coupon_status_url：" + body);

                if (!string.IsNullOrEmpty(body))
                {
                    //couponStatusBean.app_id = app_id;
                    //couponStatusBean.user_id = "" + user_id;

                    JsonData jo = JsonMapper.ToObject(body.Trim());
                    couponStatusBean.activity_id = (String)jo["result"]["map"]["item"]["activity_id"];
                    couponStatusBean.user_num_id = (String)jo["result"]["map"]["item"]["user_num_id"];
                    couponStatusBean.num_iid = (String)jo["result"]["map"]["item"]["num_iid"];
                    couponStatusBean.times = (int)jo["result"]["map"]["times"];
                }
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, "" + exception.ToString());
            }
            return couponStatusBean;

        }


        public static void update_coupon_status(CmsForm cmsForm
            , string activity_id
            , int coupon_status)
        {
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_coupon_status_submit_url = Constants.user_coupon_status_submit_url;
            String body = httpservice.post_http(user_coupon_status_submit_url, "user_id=" + user_id 
                + "&user_name=" + user_name
                + "&user_key=" + user_key
                + "&activity_id=" + activity_id
                + "&coupon_status=" + coupon_status 
                + "&user_token=", null);
        }


    }
}
