using com.haopintui;
using haopintui.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace haopintui.util
{
    public class WeiboLogin
    {
        public static void login(CmsForm cmsForm,WeiboBean weiboBean)
        {
            //WeiboLogin.login(cmsForm, weiboBean.user_name.Trim(), weiboBean.pwd.Trim());
            string out_cookie = "";
           string body =  WeiboUtil.login(cmsForm, weiboBean.user_name.Trim(), weiboBean.pwd.Trim(),out out_cookie);
           if (!string.IsNullOrEmpty(out_cookie))
           {
               WeiboUtil.update_weibo_list(cmsForm, weiboBean.user_name, out_cookie);
           }
           //LogUtil.log_call(cmsForm,"----"+ body);

           //HttpUpload httpUpload = new HttpUpload();
           //httpUpload.SetFieldValue("type","json");
           //FileStream fs = new FileStream(@"E:\work\cs\好品推\Release\config\临时文件夹\selhotshare\20161101091218\20161102010514273.jpg", FileMode.Open);
           //byte[] buffer = new byte[fs.Length];
           //httpUpload.SetFieldValue("pic", "20161102010514273.jpg", "image/png", buffer);

           //string cotent = "";
           //httpUpload.Upload("http://m.weibo.cn/mblogDeal/addPic", out_cookie, out body);
           //LogUtil.log_call(cmsForm, "----" + body);

           //LogUtil.log_call(cmsForm, "----" + fs.Length);

           //Dictionary<string, string> formDataDic = new Dictionary<string, string>();
           //formDataDic.Add("type", "json");
           //body = HttpUpload.CreateHttpUploadFile(cmsForm,"http://m.weibo.cn/mblogDeal/addPic", fs, "pic", "image/png"
           //   , out_cookie, formDataDic
           //);
           //LogUtil.log_call(cmsForm, "----" + body);

           ////LogUtil.log_call(cmsForm, "----" + out_cookie);
           //body = WeiboUtil.post(cmsForm, "aadfasdfsd","", out_cookie);
           //LogUtil.log_call(cmsForm, "----" + body);

        }
         public static void login(CmsForm cmsForm, String user_name, String pwd)
        {
            try
            {
                if (Process.GetProcessesByName(Constants.weibo_login_exe_name).Length > 0)
                {
                    LogUtil.log_call(cmsForm, "登录窗口已经打开。。。。请稍候！");
                }
                else
                {
                    FormUtil.set_formWindowState(cmsForm, FormWindowState.Minimized);
                    LogUtil.log_call(cmsForm, "正在打开登录窗口。。。。");
                    string str = "0";
                    string str2 = " 0";
                    if (!(cmsForm.appBean.uu_username.Equals("") || cmsForm.appBean.uu_pwd.Equals("")))
                    {
                        str2 = " 1 " + cmsForm.appBean.uu_username + " " + cmsForm.appBean.uu_pwd;
                    }
                    string arguments = "\"" + cmsForm.Text + "\" " + str + " " + user_name + " " + pwd + " " + str2;
                    try
                    {
                        Process.Start(cmsForm.app_path + @"\" + Constants.weibo_login_exe, arguments);
                        cmsForm.appBean.weibo_login_status = false;
                        cmsForm.appBean.weibo_login_name =user_name ;
                    }
                    catch
                    {
                        //if (File.Exists(cmsForm.app_path + @"\" + Constants.alimama_login_exe))
                        //{
                        //    File.Delete(cmsForm.app_path + @"\" + Constants.alimama_login_exe);
                        //}
                        //try
                        //{
                        //    cmsForm.webClient.DownloadFile(Constants.software_url + "/update/" + Constants.alimama_login_exe, cmsForm.app_path + @"\" + Constants.alimama_login_exe);
                        //}
                        //catch
                        //{
                        //    cmsForm.webClient.DownloadFile(Constants.software_url + "/update/" + Constants.alimama_login_exe, cmsForm.app_path + @"\" + Constants.alimama_login_exe);
                        //}
                        //Process.Start(cmsForm.app_path + @"\" + Constants.alimama_login_exe, arguments);
                        //cmsForm.appBean.alimama_login_status = false;
                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[openLoginForm]出错，" + exception.ToString());
            }
        }

        public static void log_login(CmsForm cmsForm, int login_status_int, string cookie, int zoneId)
        {
            try
            {
                cmsForm.appBean.weibo_login_status = true;
                //FormUtil.set_formWindowState(cmsForm,FormWindowState.Normal);
                if (login_status_int ==Constants.FORM_MSG_TYPE_LOGINED)
                {
                    cmsForm.appBean.weibo_login_status = true;
                    cmsForm.appBean.taoke_cookie = cookie;

                    cmsForm.appBean.hashtable_weibo.Add(cmsForm.appBean.weibo_login_name, cookie);

                    //LogUtil.log_call(cmsForm, "微博登录完成，返回状态：【" + (AlimamaUtil.check_login(cookie) ? "登录成功" : "登录失败") + "】！");

                    //if (cmsForm.thread_online != null)
                    //{
                    //    try
                    //    {
                    //        cmsForm.thread_online.Abort();
                    //        cmsForm.thread_online = null;
                    //    }
                    //    catch
                    //    {
                    //    }
                    //}
                    //cmsForm.thread_online = new Thread(new ParameterizedThreadStart(AlimamaUtil.online));
                    //cmsForm.thread_online.IsBackground = true;
                    //cmsForm.thread_online.Start(cookie);

                    //BindingUtil.isBinding_call(cmsForm);
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_NOTOPEN)
                {
                    cmsForm.appBean.weibo_login_status = false;
                    LogUtil.log_call(cmsForm, "网页无法打开！");
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_CHKTMOUT)
                {
                    cmsForm.appBean.weibo_login_status = false;
                    LogUtil.log_call(cmsForm, "检查登录成功页面超时！");
                   
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_CLOSENOTLOGINED)
                {
                    cmsForm.appBean.weibo_login_status = false;
                    LogUtil.log_call(cmsForm, "登录窗口被手动关闭，并且没有登录成功！");
                }
            }
            catch (Exception exception)
            {
                 LogUtil.log_call(cmsForm, "[processFormMsg]出错，" + exception.ToString());
            }
        }

       
    }
}
