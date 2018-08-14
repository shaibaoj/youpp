using com.haopintui;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace haopintui
{
    public class TestUtil
    {
        internal static void put_alimama_cookie_url(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;

            try
            {
                LogUtil.log_call(cmsForm, "开始跟踪");
                while (cmsForm.appBean.alimama_cookie_put_url_status)
                {
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
                        }
                    }
                    else if (AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
                    {
                        LogUtil.log_call(cmsForm, "阿里妈妈登录正常");
                        string put_url = cmsForm.textBoxAlimamaCookieUrl.Text;
                        put_url = "http://" + Constants.api_url  + "/zhushou/pid/create";
                        String user_key = cmsForm.appBean.user_token;

                        string create_pid = cmsForm.textBoxCreatePid.Text;

                        if (!String.IsNullOrEmpty(put_url) && !String.IsNullOrEmpty(create_pid))
                        {
                            StringUtil.login(cmsForm.httpService, put_url, "key=alimama_cookie_" + cmsForm.textBoxAlimamaAcc.Text.Trim() + "&content=" + cmsForm.appBean.taoke_cookie + "&member_token=" + user_key + "&pid=" + create_pid);
                        }

                    }
                    else if (Process.GetProcessesByName(Constants.alimama_login_exe_name).Length > 0)
                    {
                        LogUtil.log_call(cmsForm, "登录窗口正在运行中");
                        Thread.Sleep(3000);
                    }

                    Thread.Sleep(100000);

                }
                LogUtil.log_call(cmsForm, "停止批量转化");
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, "[checkAutoLogin]出错！" + exception.ToString());
            }

        }

    }
}
