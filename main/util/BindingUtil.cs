using com.haopintui;
using entity;
using LitJson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace haopintui.util
{
    public class BindingUtil
    {

        public static void isBinding_call(CmsForm cmsForm)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    bind method = new bind(BindingUtil.isBinding_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm });
                }
                else
                {
                    BindingUtil.isBinding(cmsForm);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static bool ini_(CmsForm cmsForm)
        {
            if (!string.IsNullOrEmpty(cmsForm.appBean.alimama_id))
            {
                cmsForm.button_bind.Text = "已认证";
                return true;
            }
            return false;
        }

        public static bool isBinding(CmsForm cmsForm) {
            if (string.IsNullOrEmpty(cmsForm.appBean.alimama_id))
            {
                DialogResult dgr = MessageBox.Show(cmsForm, "是否要立即淘客认证，认证后当前账号会与登陆的阿里妈妈账号绑定", "淘客认证绑定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dgr == DialogResult.Yes)
                {
                    string out_log = "";
                    BindingUtil.binding(cmsForm, out out_log);
                    if (!string.IsNullOrEmpty(out_log))
                    {
                        LogUtil.log_call(cmsForm, out_log);
                    }
                    BindingUtil.binding_income(cmsForm);
                }
            }
            else {
                LogUtil.log_call(cmsForm, "账号已经认证过了");
                BindingUtil.binding_income(cmsForm);
            }
            return true;
        }

        public static bool binding(CmsForm cmsForm,out string out_log)
        {
            out_log = "";
            string member_id = cmsForm.appBean.member_id;
            if(string.IsNullOrEmpty(member_id)){
                out_log="先登陆阿里妈妈账号，才能完成认证工作";
                return false;
            }
            HttpService httpservice = cmsForm.httpService;
            long user_id = cmsForm.appBean.user_id;
            string app_id = cmsForm.appBean.cms_app_id;
            String user_key = cmsForm.appBean.user_key;
            String user_name = cmsForm.appBean.user_name;
            String user_binding_url = Constants.binding_url;
            string datastr = String.Concat(
                 "user_id=" + user_id
                , "&user_key=" + user_key
                , "&user_token="
                , "&app_id=" + app_id
                , "&alimama_id=" + member_id
            );
            String body = httpservice.post_http(user_binding_url, datastr, null);

            //LogUtil.log_call(cmsForm, body);
            if(!string.IsNullOrEmpty(body)){
                JsonData jo = JsonMapper.ToObject(body.Trim());
                JsonData mapItem = jo["result"]["map"];
                int status = (int)mapItem["status"];
                string status_err = mapItem["status_err"].ToString();
                //LogUtil.log_call(cmsForm, mapItem["status"].ToString());
                if (status == 1)
                {
                    cmsForm.appBean.alimama_id = cmsForm.appBean.member_id;
                    out_log = status_err;
                    return true;
                }
                else
                {
                    out_log = status_err; return false;
                }
            }

            return false;

        }

        public static void binding_income(CmsForm cmsForm)
        {
            string out_log = "";
            if (cmsForm.appBean==null
                || string.IsNullOrEmpty(cmsForm.appBean.taoke_cookie))
            {
                return;
            }
            AlimamaBean alimamaBean = AlimamaUtil.get_AlimamaBean(cmsForm.appBean.taoke_cookie,out out_log);
            //LogUtil.log_call(cmsForm, cmsForm.appBean.taoke_cookie);
            //LogUtil.log_call(cmsForm, out_log);
            if(alimamaBean!=null){
                string member_id = cmsForm.appBean.member_id;
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String user_binding_url = Constants.binding_income_url;
                string datastr = String.Concat(
                      "user_id=" + user_id
                    , "&user_key=" + user_key
                    , "&user_token="
                    , "&app_id=" + app_id
                    , "&alimama_id=" + member_id
                    , "&curMonthTotal=" + alimamaBean.curMonthTotal
                    , "&lastMonthTotal=" + alimamaBean.lastMonthTotal
                    , "&yesterdayTotal=" + alimamaBean.yesterdayTotal

                );
                String body = httpservice.post_http(user_binding_url, datastr, null);
                //LogUtil.log_call(cmsForm, body);
            }

        }

        internal static void binding_income(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
        caiji:
            try
            {
                while (true)
                {
                    BindingUtil.binding_income(cmsForm);
                    Thread.Sleep(600000);
                }
            }
            catch (Exception)
            {
                goto caiji;
            }
        }

    }
}
