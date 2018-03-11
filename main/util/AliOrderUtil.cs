using com.haopintui;
using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace haopintui.util
{
    public class AliOrderUtil
    {

        public static void putOrder(CmsForm cmsForm) {

            ArrayList aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie,0);
            LogUtil.log_cms_call(cmsForm, "aliOrderList:" + aliOrderList.Count);
            if (aliOrderList.Count>0)
            {
                //AliOrderUtil.submit_order_items(cmsForm, aliOrderList);
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }
            aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie, 1);
            if (aliOrderList.Count > 0)
            {
                //AliOrderUtil.submit_order_items(cmsForm, aliOrderList);
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }

            aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie, 2);
            if (aliOrderList.Count > 0)
            {
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }
            aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie, 3);
            if (aliOrderList.Count > 0)
            {
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }
            aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie, 4);
            if (aliOrderList.Count > 0)
            {
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }
            aliOrderList = ExeclUtil.query_order(cmsForm, cmsForm.appBean.taoke_cookie, 5);
            if (aliOrderList.Count > 0)
            {
                AliOrderUtil.put_order_items(cmsForm, aliOrderList);
            }
        }

        public static bool submit_order_items(CmsForm cmsForm, ArrayList items)
        {
            HttpService httpservice = cmsForm.httpService;
            //long user_id = cmsForm.appBean.user_id;
            //string app_id = cmsForm.appBean.cms_app_id;
            //String user_key = cmsForm.appBean.user_token;
            //String user_name = cmsForm.appBean.user_name;
            //String member_id = cmsForm.appBean.member_id;
            //String user_taoke_create_url = Constants.user_ali_order_create_url;
            //string datastr = String.Concat(
            //      "user_id=" + user_id
            //    , "&member_token=" + user_key
            //    , "&app_id=" + app_id
            //    , "&alimama_id=" + member_id
            //);

            //ArrayList update_arrayLists = new ArrayList();

            //for (int i = 1; i < items.Count; i++)
            //{
            //    AliOrderBean item = (AliOrderBean)items[i];

            //    String out_log;
            //    ArrayList sql_list = cmsForm.sendSqlUtil.query_order(item.num_iid, item.order_no, out out_log);
            //    if (sql_list.Count <= 0 ||
            //        !((AliOrderBean)sql_list[0]).status.Equals(item.status + item.settlement_date)
            //        )
            //    {
            //        datastr = String.Concat(
            //            datastr
            //             , "&order_time[]=" + HttpUtility.UrlEncode(item.order_time)
            //            , "&click_time[]=" + HttpUtility.UrlEncode(item.click_time)
            //            , "&title[]=" + HttpUtility.UrlEncode(item.title)
            //            , "&num_iid[]=" + HttpUtility.UrlEncode(item.num_iid)
            //            , "&nick[]=" + HttpUtility.UrlEncode(item.nick)
            //            , "&shop_title[]=" + HttpUtility.UrlEncode(item.shop_title)
            //            , "&product_num[]=" + HttpUtility.UrlEncode(item.product_num)
            //            , "&product_price[]=" + HttpUtility.UrlEncode(item.product_price)
            //            , "&status[]=" + HttpUtility.UrlEncode(item.status)
            //            , "&order_type[]=" + HttpUtility.UrlEncode(item.order_type)
            //            , "&commission_rate[]=" + HttpUtility.UrlEncode(item.commission_rate)
            //            , "&fen_rate[]=" + HttpUtility.UrlEncode(item.fen_rate)
            //            , "&price[]=" + HttpUtility.UrlEncode(item.price)
            //            , "&commission[]=" + HttpUtility.UrlEncode(item.commission)
            //            , "&settlement_price[]=" + HttpUtility.UrlEncode(item.settlement_price)
            //            , "&settlement_money[]=" + HttpUtility.UrlEncode(item.settlement_money)
            //            , "&settlement_date[]=" + HttpUtility.UrlEncode(item.settlement_date)
            //            , "&product_rate[]=" + HttpUtility.UrlEncode(item.product_rate)
            //            , "&product_money[]=" +HttpUtility.UrlEncode( item.product_money)
            //            , "&benefit_rate[]=" + HttpUtility.UrlEncode(item.benefit_rate)
            //            , "&benefit_money[]=" +HttpUtility.UrlEncode( item.benefit_money)
            //            , "&benefit_type[]=" + HttpUtility.UrlEncode(item.benefit_type)
            //            , "&order_platform[]=" + HttpUtility.UrlEncode(item.order_platform)
            //            , "&third_party_service[]=" + HttpUtility.UrlEncode(item.third_party_service)
            //            , "&order_no[]=" + HttpUtility.UrlEncode(item.order_no)
            //            , "&cate_name[]=" + HttpUtility.UrlEncode(item.cate_name)
            //            , "&site_id[]=" + HttpUtility.UrlEncode(item.site_id)
            //            , "&site_name[]=" + HttpUtility.UrlEncode(item.site_name)
            //            , "&zone_id[]=" + HttpUtility.UrlEncode(item.zone_id)
            //            , "&zone_name[]=" + HttpUtility.UrlEncode(item.zone_name)

            //            //, "&num_iid[]=" + item.num_iid
            //            //, "&url[]=" + item.url
            //            //, "&coupon_url[]=" + item.coupon_url
            //            //, "&short_url[]=" + item.short_url
            //            //, "&tao_token[]=" + item.tao_token
            //            //, "&coupon_link_tao_token[]=" + item.coupon_link_tao_token
            //        );
            //        LogUtil.log_cms_call(cmsForm, item.num_iid);
            //        update_arrayLists.Add(item);
            //    }
            //}
            //String body = httpservice.post_http(user_taoke_create_url, datastr, null);
            //LogUtil.log_cms_call(cmsForm, body);
            //if (body.IndexOf("success")>=0)
            //{
            //    for (int i = 0; i < update_arrayLists.Count; i++)
            //    {
            //        AliOrderBean item = (AliOrderBean)update_arrayLists[i];
            //        String out_log;
            //        bool s = cmsForm.sendSqlUtil.insert_order_item(item.order_no, item.num_iid, item.status + item.settlement_date, out out_log);
            //        //LogUtil.log_cms_call(cmsForm, "" + s);
            //    }

            //}

            ////LogUtil.log_cms_call(cmsForm, body);
            return true;

        }

        public static bool put_order_items(CmsForm cmsForm, ArrayList items)
        {

            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_token;
            String user_name = cmsForm.appBean.user_name;
            String member_id = cmsForm.appBean.member_id;

            ArrayList update_arrayLists = new ArrayList();

            if (!Directory.Exists(cmsForm.app_path + "/config/upload"))
            {
                Directory.CreateDirectory(cmsForm.app_path + "/config/upload");
            }
            string upload_file_name = DateTime.Now.ToString("yyMMddhhmmss") + DateTime.Now.Millisecond.ToString() + ".txt";
            string upload_file = cmsForm.app_path + "/config/upload/"+upload_file_name;
            FileStream stream = new FileStream(upload_file, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding("utf-8"));
            writer.WriteLine("");
            for (int i = 1; i < items.Count; i++)
            {
                AliOrderBean item = (AliOrderBean)items[i];

                String out_log;
                ArrayList sql_list = cmsForm.sendSqlUtil.query_order(item.num_iid, item.order_no, out out_log);
                if (sql_list.Count <= 0 ||
                    !((AliOrderBean)sql_list[0]).status.Equals(item.status + item.settlement_date)
                    )
                {
                    string datastr = String.Concat(
                         "order_time[]=" + item.order_time
                        , "&click_time[]=" + item.click_time
                        , "&title[]=" + item.title
                        , "&num_iid[]=" + item.num_iid
                        , "&nick[]=" + item.nick
                        , "&shop_title[]=" + item.shop_title
                        , "&product_num[]=" + item.product_num
                        , "&product_price[]=" + item.product_price
                        , "&status[]=" + item.status
                        , "&order_type[]=" + item.order_type
                        , "&commission_rate[]=" + item.commission_rate
                        , "&fen_rate[]=" + item.fen_rate
                        , "&price[]=" + item.price
                        , "&commission[]=" + item.commission
                        , "&settlement_price[]=" + item.settlement_price
                        , "&settlement_money[]=" + item.settlement_money
                        , "&settlement_date[]=" + item.settlement_date
                        , "&product_rate[]=" + item.product_rate
                        , "&product_money[]=" + item.product_money
                        , "&benefit_rate[]=" + item.benefit_rate
                        , "&benefit_money[]=" + item.benefit_money
                        , "&benefit_type[]=" + item.benefit_type
                        , "&order_platform[]=" + item.order_platform
                        , "&third_party_service[]=" + item.third_party_service
                        , "&order_no[]=" + item.order_no
                        , "&cate_name[]=" + item.cate_name
                        , "&site_id[]=" + item.site_id
                        , "&site_name[]=" + item.site_name
                        , "&zone_id[]=" + item.zone_id
                        , "&zone_name[]=" + item.zone_name

                        , "&user_id[]=" + user_id
                        , "&user_key[]=" + user_key
                        , "&user_token[]="
                        , "&app_id[]=" + app_id
                        , "&alimama_id[]=" + member_id

                        //, "&num_iid[]=" + item.num_iid
                        //, "&url[]=" + item.url
                        //, "&coupon_url[]=" + item.coupon_url
                        //, "&short_url[]=" + item.short_url
                        //, "&tao_token[]=" + item.tao_token
                        //, "&coupon_link_tao_token[]=" + item.coupon_link_tao_token


                    );
                    writer.WriteLine(datastr);
                    LogUtil.log_cms_call(cmsForm, item.num_iid);
                    update_arrayLists.Add(item);
                }
            }
            writer.Flush();
            writer.Close();
            writer.Dispose();
            stream.Close();
            stream.Dispose();

            string uriString = Constants.put_tools_url + "/" + upload_file_name;
            new WinFileTransporter().UpLoadFile(upload_file, uriString);
            File.Delete(upload_file);


            for (int i = 0; i < update_arrayLists.Count; i++)
            {
                AliOrderBean item = (AliOrderBean)update_arrayLists[i];
                String out_log;
                bool s = cmsForm.sendSqlUtil.insert_order_item(item.order_no, item.num_iid, item.status + item.settlement_date, out out_log);
                //LogUtil.log_cms_call(cmsForm, "" + s);
            }

            return true;
        }

    }
}
