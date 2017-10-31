using com.haopintui;
using haopintui.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace haopintui
{
    public class AlimamaLogin
    {
        public static void login(CmsForm cmsForm, int zoneId)
        {
            bool flag = (cmsForm.checkBoxAutoLogin.Checked && !cmsForm.textBoxAlimamaAcc.Text.Trim().Equals("")) && !cmsForm.textBoxAlimamaPwd.Text.Trim().Equals("");
            bool alimama_scanLogin = cmsForm.checkBoxAutoLogin.Checked;
            AlimamaLogin.login(cmsForm, alimama_scanLogin, flag);
        }
        public static void login(CmsForm cmsForm, bool alimama_scanLogin, bool alimama_auto_login)
        {
            AlimamaLogin.login(cmsForm, alimama_scanLogin, alimama_auto_login, cmsForm.textBoxAlimamaAcc.Text.Trim(), cmsForm.textBoxAlimamaPwd.Text.Trim());
        }
        public static void login(CmsForm cmsForm, bool alimama_scanLogin, bool alimama_auto_login, String alimama_acc, String alimama_pwd)
        {
            try
            {
                if (Process.GetProcessesByName(Constants.alimama_login_exe_name).Length > 0)
                {
                    LogUtil.log_call(cmsForm, "登录窗口已经打开。。。。请稍候！");
                }
                else
                {
                    FormUtil.set_formWindowState(cmsForm, FormWindowState.Minimized);
                    LogUtil.log_call(cmsForm, "正在打开登录窗口。。。。");
                    string str0 = alimama_scanLogin ? "1" : "0";
                    string str = alimama_auto_login ? "1" : "0";
                    string str2 = " 0";
                    if (!(cmsForm.appBean.uu_username.Equals("") || cmsForm.appBean.uu_pwd.Equals("")))
                    {
                        str2 = " 1 " + cmsForm.appBean.uu_username + " " + cmsForm.appBean.uu_pwd;
                    }
                    string arguments = "\"" + cmsForm.Text + "\" " + str0 + " " + str + " " + alimama_acc + " " + alimama_pwd + " " + str2;
                    try
                    {
                        Process.Start(cmsForm.app_path + @"\" + Constants.alimama_login_exe, arguments);
                        cmsForm.appBean.alimama_login_status = false;
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
                cmsForm.appBean.alimama_login_status = true;
                FormUtil.set_formWindowState(cmsForm,FormWindowState.Normal);
                if (login_status_int ==Constants.FORM_MSG_TYPE_LOGINED)
                {
                    cmsForm.appBean.alimama_login_status = true;
                    cmsForm.appBean.taoke_cookie = cookie;
                    bool check_login = AlimamaUtil.check_login(cookie);
                    LogUtil.log_call(cmsForm, "阿里妈妈登录完成，返回状态：【" + (check_login ? "登录成功" : "登录失败") + "】！");
                    new Thread(new ParameterizedThreadStart(AlimamaAdUtil.updAliPid)).Start(new Object[]{cmsForm, zoneId});
                    if (check_login)
                    {
                        ConfigUtil.save_taoke_cookie(cmsForm);
                    }

                    if (cmsForm.thread_online != null)
                    {
                        try
                        {
                            cmsForm.thread_online.Abort();
                            cmsForm.thread_online = null;
                        }
                        catch
                        {

                        }
                    }
                    cmsForm.thread_online = new Thread(new ParameterizedThreadStart(AlimamaUtil.online));
                    cmsForm.thread_online.IsBackground = true;
                    cmsForm.thread_online.Start(cookie);

                    //BindingUtil.isBinding_call(cmsForm);
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_NOTOPEN)
                {
                    cmsForm.appBean.alimama_login_status = false;
                    LogUtil.log_call(cmsForm, "网页无法打开！");
                    if (cmsForm.checkBoxAutoLogin.Checked)
                    {
                        AlimamaLogin.login(cmsForm,  zoneId);
                    }
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_CHKTMOUT)
                {
                    cmsForm.appBean.alimama_login_status = false;
                    LogUtil.log_call(cmsForm, "检查登录成功页面超过8秒！");
                     if (cmsForm.checkBoxAutoLogin.Checked)
                    {
                        AlimamaLogin.login(cmsForm, zoneId);
                    }
                }
                else if (login_status_int ==Constants.FORM_MSG_TYPE_CLOSENOTLOGINED)
                {
                    cmsForm.appBean.alimama_login_status = false;
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
