using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace haopintui.util
{
    public class WeiboUtil
    {

        public static void send(CmsForm cmsForm, string content, string content_img, ArrayList imgList, string content_org, int url_type,int goods_type)
        {
            string out_log = "";
            try
            {
                if (cmsForm.appBean.weibo_list == null || cmsForm.appBean.weibo_list.Count == 0)
                {
                    LogUtil.log_call(cmsForm, "没有微博账号！");
                    return;
                }
                int i = 0;
                while (i < cmsForm.appBean.weibo_list.Count)
                {
                    if (!cmsForm.appBean.send_status && !cmsForm.appBean.qunfa_genfa_qunfa_status)
                    {
                        out_log = "群发被强制停止";
                        return;
                    }
                    else
                    {
                        WeiboBean item = (WeiboBean)cmsForm.appBean.weibo_list[i];
                        if (item.status ==1)
                        {
                            string picId = "";
                            if (imgList != null && imgList.Count>0)
                            {
                                int img_i = 0;
                                while (img_i < imgList.Count)
                                {
                                    string item_img = (string)imgList[img_i];
                                    string pic_id = WeiboUtil.upload(cmsForm,item_img,item.cookie);
                                    if (!string.IsNullOrEmpty(pic_id))
                                    {
                                        if (!string.IsNullOrEmpty(picId))
                                        {
                                            picId = picId + ",";
                                        }
                                        picId = picId + pic_id;
                                    }
                                    img_i =  + 1;
                                }
                            }
                            content = content.Replace( "<BR>","\n");
                            WeiboUtil.post(cmsForm, string.Concat(content, QqUtil.weiba(cmsForm, out out_log)),picId, item.cookie);
                        }
                    }
                    i = i + 1;
                }
                LogUtil.log_call(cmsForm, "微博发完成！");
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, string.Concat("[autoSendweibo]出错：", exception.ToString()));
            }
            return;
        }

        public static string login(CmsForm cmsForm,string user_name,string pwd,out string out_cookie)
        {
            HttpService httpservice = cmsForm.httpService;
            String cms_url = "https://passport.weibo.cn/sso/login";
            //LogUtil.log_call(cmsForm, "user_id=" + user_id + "&user_name=" + user_name + "&user_key=" + user_key + "&user_token=");

            String body = httpservice.post_http_cookie(cms_url, "username=" + user_name
                + "&password=" + pwd
                + "&savestate=1"
                + "&r=http://m.weibo.cn/"
                + "&ec=0"
                + "&pagerefer=http://m.weibo.cn/"
                + "&entry=mweibo"
                + "&wentry="
                + "&loginfrom="
                + "&client_id="
                + "&code="
                + "&qq="
                + "&mainpageflag=1"
                + "&hff="
                + "&hfp=" ,null,out out_cookie
                );
            //LogUtil.log_call(cmsForm, "query_cms_list：" + body);

            //UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

            //ArrayList list = new ArrayList();
            //for (int i = body.IndexOf("items"); (i = body.IndexOf("\"app_id\"", i)) != -1; i++)
            //{
            //    UserCms userCms = new UserCms();
            //    userCms.app_id = StringUtil.subString(body, i, "\"app_id\":\"", "\"");
            //    userCms.user_id = StringUtil.subString(body, i, "\"user_id\":\"", "\"");
            //    String cms_title = StringUtil.subString(body, i, "\"title\":\"", "\"");
            //    cms_title = UnicodeUtil.Unicode2String(cms_title);
            //    userCms.title = cms_title;

            //    list.Add(userCms);
            //}
            return body;

        }


        public static string post(CmsForm cmsForm, string content, string picId, string cookie)
        {
            HttpService httpservice = cmsForm.httpService;
            String cms_url = "http://m.weibo.cn/mblogDeal/addAMblog";

            String body = httpservice.post_http(cms_url, "content=" + content
                + "&annotations="
                + "&st=1"
                + "&picId=" + picId
                , cookie
                );
            return body;

        }

        public static string upload(CmsForm cmsForm, string pic_url, string cookie)
        {
           
            return "";

        }

        public static void update_weibo_list(CmsForm cmsForm, string user_name, string cookie) {
            if (!string.IsNullOrEmpty(cookie) && !string.IsNullOrEmpty(user_name))
            {
                int i=0;
                while (i < cmsForm.appBean.weibo_list.Count)
                { 
                    WeiboBean item = (WeiboBean)cmsForm.appBean.weibo_list[i];
                    if (item.user_name.Equals(user_name))
                    {
                        LogUtil.log_call(cmsForm, "user_name：" + user_name);
                        item.cookie = cookie;
                        item.status = 1;
                    }
                    i = i + 1;
                }

                i = 0;
                while (cmsForm.dataGridView_weibo.Rows.Count > i)
                {
                    WeiboBean tag = (WeiboBean)cmsForm.dataGridView_weibo[0, i].Tag;
                    if (tag.user_name.Equals(user_name))
                    {
                        LogUtil.log_call(cmsForm, "user_name：" + user_name);
                        tag.cookie = cookie;
                        tag.status = 1;
                        cmsForm.dataGridView_weibo[1, i].Value = "已经登陆";
                    }
                    i = i + 1;
                }

            }
        }


    }
}
