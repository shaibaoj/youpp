using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace haopintui.util
{
    class KoulingUtil
    {
        public static string get_kouling(string appid, string appkey
            , string url, string pic, string text, string ext)
        {
            ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest	", appid, appkey);
            WirelessShareTpwdCreateRequest req = new WirelessShareTpwdCreateRequest();
            WirelessShareTpwdCreateRequest.IsvTpwdInfoDomain obj1 = new WirelessShareTpwdCreateRequest.IsvTpwdInfoDomain();
            if (!string.IsNullOrEmpty(ext))
            {
            obj1.Ext = ext;            
            }
            if (!string.IsNullOrEmpty(pic))
            {
            obj1.Logo = pic;
            }
            if (!string.IsNullOrEmpty(text))
            {
                obj1.Text = text;
            }
            obj1.Url = url;
            obj1.UserId = 24234234234L;

            obj1.Ext = "{\"xx\":\"xx\"}";
            //obj1.Logo = "http://m.taobao.com/xxx.jpg";
            //obj1.Text = "超值活动，惊喜活动多多";
            //obj1.Url = "http://m.taobao.com";
            //obj1.UserId = 24234234234L;

            req.TpwdParam_ = obj1;
            WirelessShareTpwdCreateResponse rsp = client.Execute(req);
            string body = rsp.Body;
            //Console.WriteLine(rsp.Body);
            return rsp.Body;
        }

        public static string get_kouling_haopintui(CmsForm cmsForm
           , string url, string pic, string text, string ext)
        {
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String kouling_url = com.haopintui.Constants.kouling_url;
                String body = httpservice.post_http(kouling_url, 
                      "user_id=" + user_id 
                    + "&app_id=" + app_id
                    + "&user_key=" + user_key
                    + "&url=" + HttpUtility.UrlEncode(url)
                    + "&text=" + text
                    + "&pic=" + HttpUtility.UrlEncode(pic) 
                    + "&user_token=", null);

                //LogUtil.log_call(cmsForm, "user_data：" + "user_id=" + user_id
                //    + "&app_id=" + app_id
                //    + "&user_key=" + user_key
                //    + "&url=" + HttpUtility.UrlEncode(url)
                //    + "&text=" + text
                //    + "&pic=" + HttpUtility.UrlEncode(pic)
                //    + "&user_token=");
                //LogUtil.log_call(cmsForm, "user_kouling：" + body);
                if (body.Contains("<model>"))
                {
                    string content = StringUtil.subString(body, 0, "<model>", "</model>");
                    return content;
                }
            }
            catch (Exception ex)
            {

                //LogUtil.log_call(cmsForm, "user_kouling：" + ex.ToString());
            }
            return "";

        }

    }
}
