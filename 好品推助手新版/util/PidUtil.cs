using entity;
using haopintui;
using haopintui.entity;
using System;
using System.Windows.Forms;

namespace haopintui.util
{
    public class PidUtil
    {
        public PidUtil()
        {

        }

        public static string get_kouling(CmsForm cmsForm, string uland_url, string pic, string text, string ext)
        {
            if (!cmsForm.radioButtonsetting_app_ben.Checked)
            {
                string koulingHaopintui = KoulingUtil.get_kouling_haopintui(cmsForm, uland_url, pic, text, ext);
                if (string.IsNullOrEmpty(koulingHaopintui))
                {
                    string str = StringUtil.subString(uland_url, 0, "activityId=", "&");
                    string str1 = StringUtil.subString(uland_url, 0, "itemId=", "&");
                    string str2 = StringUtil.subString(uland_url, 0, "pid=", "&");
                    string str3 = StringUtil.subString(uland_url, 0, "dx=", "&");
                    string str4 = "";
                    KoulingBean _kouling = AlimamaUtil.get_kouling(str, str1, str2, str3, out str4);
                    if (_kouling != null)
                    {
                        return _kouling.password;
                    }
                }
                return koulingHaopintui;
            }
            if (string.IsNullOrEmpty(cmsForm.textBox_setting_appId.Text.Trim()) || string.IsNullOrEmpty(cmsForm.textBox_setting_appKey.Text.Trim()))
            {
                string str5 = StringUtil.subString(uland_url, 0, "activityId=", "&");
                string str6 = StringUtil.subString(uland_url, 0, "itemId=", "&");
                string str7 = StringUtil.subString(uland_url, 0, "pid=", "&");
                string str8 = StringUtil.subString(uland_url, 0, "dx=", "&");
                string str9 = "";
                KoulingBean koulingBean = AlimamaUtil.get_kouling(str5, str6, str7, str8, out str9);
                if (koulingBean != null)
                {
                    return koulingBean.password;
                }
            }
            else
            {
                string _kouling1 = KoulingUtil.get_kouling(cmsForm.textBox_setting_appId.Text.Trim(), cmsForm.textBox_setting_appKey.Text.Trim(), uland_url, pic, text, ext);
                if (!string.IsNullOrEmpty(_kouling1))
                {
                    return StringUtil.subString(_kouling1, 0, "<model>", "</model>");
                }
            }
            return null;
        }

        public static string get_kouling_call(CmsForm cmsForm, string uland_url, string pic, string text, string ext)
        {
            string _kouling;
            try
            {
                if (!cmsForm.textBox_setting_appId.InvokeRequired)
                {
                    _kouling = PidUtil.get_kouling(cmsForm, uland_url, pic, text, ext);
                }
                else
                {
                    get_kouling getKouling = new get_kouling(PidUtil.get_kouling);
                    object[] objArray = new object[] { cmsForm, uland_url, pic, text, ext };
                    _kouling = (string)cmsForm.Invoke(getKouling, objArray);
                }
            }
            catch (Exception exception)
            {
                return "";
            }
            return _kouling;
        }

        public static string get_qq_com_pid(CmsForm cmsForm, string member_id)
        {
            if (string.IsNullOrEmpty(member_id))
            {
                member_id = "member_id";
            }
            SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
            if (selectedItem == null || selectedItem.getId() == string.Empty)
            {
                return null;
            }
            SelectedItem selectedItem1 = (SelectedItem)cmsForm.comboBox_qq_tongyong_weizhi.SelectedItem;
            if (selectedItem1 == null || selectedItem1.getId() == string.Empty)
            {
                return null;
            }
            string[] memberId = new string[] { "mm_", member_id, "_", selectedItem.getId().ToString(), "_", selectedItem1.getId().ToString() };
            return string.Concat(memberId);
        }

        public static string get_qq_com_pid_call(CmsForm cmsForm, string member_id)
        {
            string qqComPid;
            try
            {
                if (!cmsForm.comboBox_weixin_tongyong_danyuan.InvokeRequired)
                {
                    qqComPid = PidUtil.get_qq_com_pid(cmsForm, member_id);
                }
                else
                {
                    get_pid getPid = new get_pid(PidUtil.get_qq_com_pid);
                    object[] objArray = new object[] { cmsForm, member_id };
                    qqComPid = (string)cmsForm.Invoke(getPid, objArray);
                }
            }
            catch (Exception exception)
            {
                return "";
            }
            return qqComPid;
        }

        public static string get_qq_queqiao_pid(CmsForm cmsForm, string member_id)
        {
            if (string.IsNullOrEmpty(member_id))
            {
                member_id = "member_id";
            }
            SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_qq_queqiao_danyuan.SelectedItem;
            if (selectedItem == null || selectedItem.getId() == string.Empty)
            {
                return null;
            }
            SelectedItem selectedItem1 = (SelectedItem)cmsForm.comboBox_qq_queqiao_weizhi.SelectedItem;
            if (selectedItem1 == null || selectedItem1.getId() == string.Empty)
            {
                return null;
            }
            string[] memberId = new string[] { "mm_", member_id, "_", selectedItem.getId().ToString(), "_", selectedItem1.getId().ToString() };
            return string.Concat(memberId);
        }

        public static string get_qq_queqiao_pid_call(CmsForm cmsForm, string member_id)
        {
            string qqQueqiaoPid;
            try
            {
                if (!cmsForm.comboBox_weixin_tongyong_danyuan.InvokeRequired)
                {
                    qqQueqiaoPid = PidUtil.get_qq_queqiao_pid(cmsForm, member_id);
                }
                else
                {
                    get_pid getPid = new get_pid(PidUtil.get_qq_queqiao_pid);
                    object[] objArray = new object[] { cmsForm, member_id };
                    qqQueqiaoPid = (string)cmsForm.Invoke(getPid, objArray);
                }
            }
            catch (Exception exception)
            {
                return "";
            }
            return qqQueqiaoPid;
        }

        public static string get_weixin_pid(CmsForm cmsForm, string member_id)
        {
            if (string.IsNullOrEmpty(member_id))
            {
                member_id = "member_id";
            }
            SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_weixin_tongyong_danyuan.SelectedItem;
            if (selectedItem == null || selectedItem.getId() == string.Empty)
            {
                return null;
            }
            SelectedItem selectedItem1 = (SelectedItem)cmsForm.comboBox_weixin_tongyong_weizhi.SelectedItem;
            if (selectedItem1 == null || selectedItem1.getId() == string.Empty)
            {
                return null;
            }
            string[] memberId = new string[] { "mm_", member_id, "_", selectedItem.getId().ToString(), "_", selectedItem1.getId().ToString() };
            return string.Concat(memberId);
        }

        public static string get_weibo_pid(CmsForm cmsForm, string member_id)
        {
            if (string.IsNullOrEmpty(member_id))
            {
                member_id = "member_id";
            }
            SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_weibo_tongyong_danyuan.SelectedItem;
            if (selectedItem == null || selectedItem.getId() == string.Empty)
            {
                return null;
            }
            SelectedItem selectedItem1 = (SelectedItem)cmsForm.comboBox_weibo_tongyong_weizhi.SelectedItem;
            if (selectedItem1 == null || selectedItem1.getId() == string.Empty)
            {
                return null;
            }
            string[] memberId = new string[] { "mm_", member_id, "_", selectedItem.getId().ToString(), "_", selectedItem1.getId().ToString() };
            return string.Concat(memberId);
        }

        public static string get_weixin_pid_call(CmsForm cmsForm, string member_id)
        {
            string weixinPid;
            try
            {
                if (!cmsForm.comboBox_weixin_tongyong_danyuan.InvokeRequired)
                {
                    weixinPid = PidUtil.get_weixin_pid(cmsForm, member_id);
                }
                else
                {
                    get_pid getPid = new get_pid(PidUtil.get_weixin_pid);
                    object[] objArray = new object[] { cmsForm, member_id };
                    weixinPid = (string)cmsForm.Invoke(getPid, objArray);
                }
            }
            catch (Exception exception)
            {
                return "";
            }
            return weixinPid;
        }

        public static string get_weibo_pid_call(CmsForm cmsForm, string member_id)
        {
            string weixinPid;
            try
            {
                if (!cmsForm.comboBox_weibo_tongyong_danyuan.InvokeRequired)
                {
                    weixinPid = PidUtil.get_weibo_pid(cmsForm, member_id);
                }
                else
                {
                    get_pid getPid = new get_pid(PidUtil.get_weibo_pid);
                    object[] objArray = new object[] { cmsForm, member_id };
                    weixinPid = (string)cmsForm.Invoke(getPid, objArray);
                }
            }
            catch (Exception exception)
            {
                return "";
            }
            return weixinPid;
        }

        public static string get_qq_pid_qun(CmsForm cmsForm, string name, string member_id, out string weiba)
        {
            weiba = "";
            if(cmsForm.appBean.pid_qq_list!=null&&cmsForm.appBean.pid_qq_list.Count>0){
                foreach (PidBean pidBean in cmsForm.appBean.pid_qq_list)
                {
                    if (pidBean.qun_name.Equals(name))
                    {
                        weiba = pidBean.weiba;
                        return pidBean.qun_pid;
                    }
                }
            }
            return null;
        }
        public static string get_weixin_pid_qun(CmsForm cmsForm, string name, string member_id,out string weiba)
        {
            weiba = "";
            if (cmsForm.appBean.pid_weixin_list != null && cmsForm.appBean.pid_weixin_list.Count > 0)
            {
                foreach (PidBean pidBean in cmsForm.appBean.pid_weixin_list)
                {
                    if (pidBean.qun_name.Equals(name))
                    {
                        weiba = pidBean.weiba;
                        return pidBean.qun_pid;
                    }
                }
            }
            return null;
        }

    }
}

public delegate string get_pid(CmsForm cmsForm, String content);
public delegate string get_kouling(CmsForm cmsForm, string uland_url, string pic, string text, string ext);
