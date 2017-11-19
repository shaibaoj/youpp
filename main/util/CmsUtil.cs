using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using com.haopintui.util;
using com.haopintui;
using haopintui.util;
using System.Net;
using LitJson;
using haopintui.entity;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace haopintui
{
    public class CmsUtil
    {
        public static void view_cms(CmsForm cmsForm, int zone_id)
        {
            if (zone_id==1)
            {            
                if (cmsForm.comboBoxCmPPos.Enabled == false) { return; }
                if (cmsForm.comboBoxCmPUnit.Enabled == false) { return; }

                SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBoxCmPUnit.SelectedItem;
                int select_index = 0,n=0;

                cmsForm.comboBoxCmPUnit.Items.Clear();
                //cmsForm.comboBoxCmPPos.Items.Clear();
                foreach (AdZonesItem adZonesItem in cmsForm.adzoneBean.webAdzones_List)
                {

                    SelectedItem selectedItem = new SelectedItem();
                    selectedItem.setId(adZonesItem.id);
                    selectedItem.setLabel(adZonesItem.name);
                    selectedItem.setValue(adZonesItem.sub_list);

                    cmsForm.comboBoxCmPUnit.Items.Add(selectedItem);
                    if (selectedItem_init != null 
                        && selectedItem_init.getId().Equals(selectedItem.getId()))
                    {
                        select_index = n;
                    }
                    n++;
                }

                if (cmsForm.comboBoxCmPUnit.Items.Count > 0)
                {
                    cmsForm.comboBoxCmPUnit.SelectedIndex = select_index;
                }
            }
            else if (zone_id == 2)
            {
                if (cmsForm.comboBox_qq_tongyong_danyuan.Enabled == false) { return; }
                if (cmsForm.comboBox_qq_tongyong_weizhi.Enabled == false) { return; }

                SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
                int select_index = 0, n = 0;

                cmsForm.comboBox_qq_tongyong_danyuan.Items.Clear();
                //cmsForm.comboBox_qq_tongyong_weizhi.Items.Clear();

                foreach (AdZonesItem adZonesItem in cmsForm.adzoneBean.qqAdzones_List)
                {

                    SelectedItem selectedItem = new SelectedItem();
                    selectedItem.setId(adZonesItem.id);
                    selectedItem.setLabel(adZonesItem.name);
                    selectedItem.setValue(adZonesItem.sub_list);

                    cmsForm.comboBox_qq_tongyong_danyuan.Items.Add(selectedItem); 
                    if (selectedItem_init != null
                        && selectedItem_init.getId().Equals(selectedItem.getId()))
                    {
                        select_index = n;
                    }
                    n++;
                }

                if (cmsForm.comboBox_qq_tongyong_danyuan.Items.Count > 0)
                {
                    cmsForm.comboBox_qq_tongyong_danyuan.SelectedIndex = select_index;
                }
            }
            else if (zone_id == 3)
            {
                if (cmsForm.comboBox_qq_queqiao_danyuan.Enabled == false) { return; }
                if (cmsForm.comboBox_qq_queqiao_weizhi.Enabled == false) { return; }

                SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_qq_queqiao_danyuan.SelectedItem;
                int select_index = 0, n = 0;

                cmsForm.comboBox_qq_queqiao_danyuan.Items.Clear();
                //cmsForm.comboBox_qq_queqiao_weizhi.Items.Clear();

                foreach (AdZonesItem adZonesItem in cmsForm.adzoneBean.qqAdzones_List)
                {

                    SelectedItem selectedItem = new SelectedItem();
                    selectedItem.setId(adZonesItem.id);
                    selectedItem.setLabel(adZonesItem.name);
                    selectedItem.setValue(adZonesItem.sub_list);

                    cmsForm.comboBox_qq_queqiao_danyuan.Items.Add(selectedItem);
                    if (selectedItem_init != null
                        && selectedItem_init.getId().Equals(selectedItem.getId()))
                    {
                        select_index = n;
                    }
                    n++;
                }

                if (cmsForm.comboBox_qq_queqiao_danyuan.Items.Count > 0)
                {
                    cmsForm.comboBox_qq_queqiao_danyuan.SelectedIndex = select_index;
                }
            }
            else if (zone_id == 4)
            {
                if (cmsForm.comboBox_weixin_tongyong_danyuan.Enabled == false) { return; }
                if (cmsForm.comboBox_weixin_tongyong_weizhi.Enabled == false) { return; }

                SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_weixin_tongyong_danyuan.SelectedItem;
                int select_index = 0, n = 0;

                cmsForm.comboBox_weixin_tongyong_danyuan.Items.Clear();
                //cmsForm.comboBox_weixin_tongyong_weizhi.Items.Clear();

                foreach (AdZonesItem adZonesItem in cmsForm.adzoneBean.weixinAdzones_List)
                {

                    SelectedItem selectedItem = new SelectedItem();
                    selectedItem.setId(adZonesItem.id);
                    selectedItem.setLabel(adZonesItem.name);
                    selectedItem.setValue(adZonesItem.sub_list);

                    cmsForm.comboBox_weixin_tongyong_danyuan.Items.Add(selectedItem);
                    if (selectedItem_init != null
                        && selectedItem_init.getId().Equals(selectedItem.getId()))
                    {
                        select_index = n;
                    }
                    n++;
                }

                if (cmsForm.comboBox_weixin_tongyong_danyuan.Items.Count > 0)
                {
                    cmsForm.comboBox_weixin_tongyong_danyuan.SelectedIndex = select_index;
                }
            }

            else if (zone_id == 5)
            {
                if (cmsForm.comboBox_weibo_tongyong_danyuan.Enabled == false) { return; }
                if (cmsForm.comboBox_weibo_tongyong_weizhi.Enabled == false) { return; }

                SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_weibo_tongyong_danyuan.SelectedItem;
                int select_index = 0, n = 0;

                cmsForm.comboBox_weibo_tongyong_danyuan.Items.Clear();
                //cmsForm.comboBox_weixin_tongyong_weizhi.Items.Clear();

                foreach (AdZonesItem adZonesItem in cmsForm.adzoneBean.weiboAdzones_List)
                {

                    SelectedItem selectedItem = new SelectedItem();
                    selectedItem.setId(adZonesItem.id);
                    selectedItem.setLabel(adZonesItem.name);
                    selectedItem.setValue(adZonesItem.sub_list);

                    cmsForm.comboBox_weibo_tongyong_danyuan.Items.Add(selectedItem);
                    if (selectedItem_init != null
                        && selectedItem_init.getId().Equals(selectedItem.getId()))
                    {
                        select_index = n;
                    }
                    n++;
                }

                if (cmsForm.comboBox_weibo_tongyong_danyuan.Items.Count > 0)
                {
                    cmsForm.comboBox_weibo_tongyong_danyuan.SelectedIndex = select_index;
                }
            }
            
        }

        public static void view_cms_call(CmsForm cmsForm,int zone_id)
        {            
            if (cmsForm.comboBoxCmPUnit.InvokeRequired)
            {
                view_cms_call d = new view_cms_call(CmsUtil.view_cms_call);
                cmsForm.Invoke(d, new object[] { cmsForm, zone_id });
            }
            else
            {
                CmsUtil.view_cms(cmsForm, zone_id);
            }

        }

        public static void comboBoxBrdgPUnit_SelectedIndexChanged(CmsForm cmsForm,int zone_id)
        {
            try
            {
                if (zone_id==1)
                {
                    //SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBoxCmPPos.SelectedItem;
                    int select_index = 0, n = 0;

                    cmsForm.comboBoxCmPPos.Items.Clear();
                    //cmsForm.comboBoxCmPPos.Text = "";
                    SelectedItem selectedItem = (SelectedItem)cmsForm.comboBoxCmPUnit.SelectedItem;
                    ArrayList list = (ArrayList)selectedItem.getValue();
                    if (list!=null)
                    {
                        foreach (AdZonesSubItem adZonesSubItem in list)
                        {
                            SelectedItem item = new SelectedItem();
                            item.setLabel(adZonesSubItem.name);
                            item.setId(adZonesSubItem.id);
                            cmsForm.comboBoxCmPPos.Items.Add(item);

                            if (cmsForm.appBean.cms_adzoneid != null
                                && cmsForm.appBean.cms_adzoneid.Equals(item.getId().ToString()))
                            {
                                select_index = n;
                            }
                            n++;
                        }
                    }
                    if (cmsForm.comboBoxCmPPos.Items.Count>0)
                    {
                        cmsForm.comboBoxCmPPos.SelectedIndex = select_index;
                    }
                }
                else if (zone_id == 2)
                {
                    //SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_qq_tongyong_weizhi.SelectedItem;
                    int select_index = 0, n = 0;

                    cmsForm.comboBox_qq_tongyong_weizhi.Items.Clear();
                    //cmsForm.comboBoxCmPPos.Text = "";
                    SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
                    ArrayList list = (ArrayList)selectedItem.getValue();
                    if (list != null)
                    { 
                        foreach (AdZonesSubItem adZonesSubItem in list)
                        {
                            SelectedItem item = new SelectedItem();
                            item.setLabel(adZonesSubItem.name);
                            item.setId(adZonesSubItem.id);
                            cmsForm.comboBox_qq_tongyong_weizhi.Items.Add(item);

                            if (cmsForm.appBean.qq_com_aid != null
                                && cmsForm.appBean.qq_com_aid.Equals(item.getId().ToString()))
                            {
                                select_index = n;
                            }
                            n++;
                        }
                    }
                    if (cmsForm.comboBox_qq_tongyong_weizhi.Items.Count > 0)
                    {
                        cmsForm.comboBox_qq_tongyong_weizhi.SelectedIndex = select_index;
                    }
                }
                else if (zone_id == 3)
                {
                    //SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_qq_queqiao_weizhi.SelectedItem;
                    int select_index = 0, n = 0;

                    cmsForm.comboBox_qq_queqiao_weizhi.Items.Clear();
                    //cmsForm.comboBoxCmPPos.Text = "";
                    SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_qq_tongyong_danyuan.SelectedItem;
                    ArrayList list = (ArrayList)selectedItem.getValue();
                    if (list != null)
                    {
                        foreach (AdZonesSubItem adZonesSubItem in list)
                        {
                            SelectedItem item = new SelectedItem();
                            item.setLabel(adZonesSubItem.name);
                            item.setId(adZonesSubItem.id);
                            cmsForm.comboBox_qq_queqiao_weizhi.Items.Add(item);

                            if (cmsForm.appBean.qq_queqiao_aid != null
                                && cmsForm.appBean.qq_queqiao_aid.Equals(item.getId().ToString()))
                            {
                                select_index = n;
                            }
                            n++;
                        }
                    }
                    if (cmsForm.comboBox_qq_queqiao_weizhi.Items.Count > 0)
                    {
                        cmsForm.comboBox_qq_queqiao_weizhi.SelectedIndex = select_index;
                    }
                }
                else if (zone_id == 4)
                {
                    //SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_weixin_tongyong_weizhi.SelectedItem;
                    int select_index = 0, n = 0;

                    cmsForm.comboBox_weixin_tongyong_weizhi.Items.Clear();
                    //cmsForm.comboBoxCmPPos.Text = "";
                    SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_weixin_tongyong_danyuan.SelectedItem;
                    ArrayList list = (ArrayList)selectedItem.getValue();
                    if (list != null)
                    {
                        foreach (AdZonesSubItem adZonesSubItem in list)
                        {
                            SelectedItem item = new SelectedItem();
                            item.setLabel(adZonesSubItem.name);
                            item.setId(adZonesSubItem.id);
                            cmsForm.comboBox_weixin_tongyong_weizhi.Items.Add(item);

                            if (cmsForm.appBean.weixin_aid != null
                                && cmsForm.appBean.weixin_aid.Equals(item.getId().ToString()))
                            {
                                select_index = n;
                            }
                            n++;
                        }
                        if (cmsForm.comboBox_weixin_tongyong_weizhi.Items.Count > 0)
                        {
                            cmsForm.comboBox_weixin_tongyong_weizhi.SelectedIndex = select_index;
                        }
                    }
                }
                else if (zone_id == 5)
                {
                    //SelectedItem selectedItem_init = (SelectedItem)cmsForm.comboBox_weixin_tongyong_weizhi.SelectedItem;
                    int select_index = 0, n = 0;

                    cmsForm.comboBox_weibo_tongyong_weizhi.Items.Clear();
                    //cmsForm.comboBoxCmPPos.Text = "";
                    SelectedItem selectedItem = (SelectedItem)cmsForm.comboBox_weibo_tongyong_danyuan.SelectedItem;
                    ArrayList list = (ArrayList)selectedItem.getValue();
                    if (list != null)
                    {
                        foreach (AdZonesSubItem adZonesSubItem in list)
                        {
                            SelectedItem item = new SelectedItem();
                            item.setLabel(adZonesSubItem.name);
                            item.setId(adZonesSubItem.id);
                            cmsForm.comboBox_weibo_tongyong_weizhi.Items.Add(item);

                            if (cmsForm.appBean.weibo_aid != null
                                && cmsForm.appBean.weibo_aid.Equals(item.getId().ToString()))
                            {
                                select_index = n;
                            }
                            n++;
                        }
                        if (cmsForm.comboBox_weibo_tongyong_weizhi.Items.Count > 0)
                        {
                            cmsForm.comboBox_weibo_tongyong_weizhi.SelectedIndex = select_index;
                        }
                    }
                }
            }
            catch (Exception exception)
            {           
                LogUtil.log_call(cmsForm, "[comboBoxBrdgPUnit_SelectedIndexChanged]出错：" + exception.ToString());
            }
        }
            
        internal static void update_cms_list(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            ArrayList cms_list =  UserUtil.query_cms_list(cmsForm);
            cmsForm.comboBoxCmsList.Items.Clear();
            //LogUtil.log_call(cmsForm, "[update_cms_list]");

            foreach (UserCms userCms in cms_list)
            {
                SelectedItem selectedItem = new SelectedItem();
                selectedItem.setId(userCms.app_id);
                selectedItem.setLabel(userCms.title);

                cmsForm.comboBoxCmsList.Items.Add(selectedItem);
            }

            if (cmsForm.comboBoxCmsList.Items.Count > 0)
            {
                cmsForm.comboBoxCmsList.SelectedIndex = 0;
            }

        }
        internal static void update_cms_list_call(Object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            while (!cmsForm.IsHandleCreated)
            {
                ;
            }
            if (cmsForm.comboBoxCmsList.InvokeRequired)
            {
                update_cms_list_call d = new update_cms_list_call(CmsUtil.update_cms_list_call);
                cmsForm.Invoke(d, new object[] { cmsForm });
            }
            else
            {
                CmsUtil.update_cms_list(cmsForm);
                IEVersion.BrowserEmulationSet();
            }

        }

        public static void cms_apply_taoke_url(CmsForm cmsForm,int apply_type) {
            if (apply_type == 1)
            {
                SelectedItem selectedItem_unit = (SelectedItem)cmsForm.comboBoxCmPUnit.SelectedItem;
                if (selectedItem_unit == null)
                {
                    selectedItem_unit = new SelectedItem();
                }

                //string str = string.Concat(new object[] { "\"sid\":", selectedItem.getId(), ",\"sname\":\"", selectedItem.getLabel(), "\"" });
                SelectedItem selectedItem_pos = (SelectedItem)cmsForm.comboBoxCmPPos.SelectedItem;
                if (selectedItem_pos == null)
                {
                    selectedItem_pos = new SelectedItem();
                }
                SelectedItem selectedItem_cms = (SelectedItem)cmsForm.comboBoxCmsList.SelectedItem;
                if (selectedItem_cms == null)
                {
                    selectedItem_cms = new SelectedItem();
                }
                LogUtil.log_call(cmsForm, "" + selectedItem_cms.getLabel());

                if (selectedItem_unit.getId() == string.Empty)
                {
                    MessageBox.Show( "推广单元不能为空！");
                    return;
                }
                if (selectedItem_pos.getId() == string.Empty)
                {
                    MessageBox.Show("推广位不能为空！");
                    return;
                }
                if (selectedItem_cms.getId() == string.Empty)
                {
                    MessageBox.Show("CMS不能为空！");
                    return;
                }
                cmsForm.button_cms_click_apply.Text = "停止自动申请";
                cmsForm.button_cms_click_apply.BackColor = System.Drawing.Color.Gray;
                cmsForm.button_cms_click_apply.ForeColor = System.Drawing.Color.Black;

                cmsForm.appBean.apply_taoke_url_status = true;
                cmsForm.appBean.applyreason = cmsForm.textBoxAppCmsReson.Text;

                cmsForm.comboBoxCmPUnit.Enabled = false;
                cmsForm.comboBoxCmPPos.Enabled = false;
                cmsForm.comboBoxCmsList.Enabled = false;

                cmsForm.appBean.cms_siteid = (String)selectedItem_unit.getId();
                cmsForm.appBean.cms_adzoneid = (String)selectedItem_pos.getId();
                cmsForm.appBean.cms_app_id = (String)selectedItem_cms.getId();

                //Thread thread = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url));
                //thread.IsBackground = true;
                //thread.Start(cmsForm);

                //Thread thread_tongji = new Thread(new ParameterizedThreadStart(CmsUtil.tongji_user_cms));
                //thread_tongji.IsBackground = true;
                //thread_tongji.Start(cmsForm);

                if(cmsForm.appBean.cms_xianshi){
                    //cmsForm.thread_cms = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url));
                    //cmsForm.thread_cms.IsBackground = true;
                    //cmsForm.thread_cms.Start(cmsForm);

                    //cmsForm.thread_cms_tongji = new Thread(new ParameterizedThreadStart(CmsUtil.tongji_user_cms));
                    //cmsForm.thread_cms_tongji.IsBackground = true;
                    //cmsForm.thread_cms_tongji.Start(cmsForm);
                }

                cmsForm.thread_cms_user = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url_user));
                cmsForm.thread_cms_user.IsBackground = true;
                cmsForm.thread_cms_user.Start(cmsForm);

                cmsForm.thread_cms_alimama_login = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url_alimama_login));
                cmsForm.thread_cms_alimama_login.IsBackground = true;
                cmsForm.thread_cms_alimama_login.Start(cmsForm);

                //cmsForm.thread_cms_user_KeepAlive = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url_user_KeepAlive));
                //cmsForm.thread_cms_user_KeepAlive.IsBackground = true;
                //cmsForm.thread_cms_user_KeepAlive.Start(cmsForm);

                //cmsForm.thread_cms_user_Receive = new Thread(new ParameterizedThreadStart(CmsUtil.apply_cms_url_user_Receive));
                //cmsForm.thread_cms_user_Receive.IsBackground = true;
                //cmsForm.thread_cms_user_Receive.Start(cmsForm);

                //cmsForm.thread_cms_user_submit_taokeitem = new Thread(new ParameterizedThreadStart(CmsUtil.submit_taoke_plan_url));
                //cmsForm.thread_cms_user_submit_taokeitem.IsBackground = true;
                //cmsForm.thread_cms_user_submit_taokeitem.Start(cmsForm);
                
                //string str2 = string.Concat(new object[] { "\"aid\":", class3.getId(), ",\"aname\":\"", class3.getLabel(), "\"" });
                //return ("\"memid\":" + this.string_32 + "," + str + "," + str2);
            }
            else {

                cmsForm.button_cms_click_apply.Text = "开始自动申请";
                cmsForm.button_cms_click_apply.UseVisualStyleBackColor = true;
                cmsForm.button_cms_click_apply.BackColor = System.Drawing.Color.Green;
                cmsForm.button_cms_click_apply.ForeColor = System.Drawing.Color.White;

                cmsForm.appBean.apply_taoke_url_status = false;
                try
                {
                    cmsForm.thread_cms.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_user.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_tongji.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_alimama_login.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_user_KeepAlive.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_user_Receive.Abort();
                }
                catch (Exception)
                {
                }
                try
                {
                    cmsForm.thread_cms_user_submit_taokeitem.Abort();
                }
                catch (Exception)
                {
                }
                cmsForm.comboBoxCmPUnit.Enabled = true;
                cmsForm.comboBoxCmPPos.Enabled = true;
                cmsForm.comboBoxCmsList.Enabled = true;

            }
        }

        internal static void apply_cms_url_user(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;

            try
            {
                LogUtil.log_cms_call(cmsForm, "开始自动实时申请");
                int apply_alimama_status = 0;
                TaokeItem taoke_item_init = null;
                int count_xunhuan = 0;
                while (cmsForm.appBean.apply_taoke_url_status)
                {
                    try
                    {
                        if (apply_alimama_status == 0)
                        {
                            if (taoke_item_init == null)
                            {
                                count_xunhuan = 0;
                            }
                            CmsUtil.apply_taoke_url_user(cmsForm, ref apply_alimama_status, ref taoke_item_init, ref count_xunhuan);
                            if (apply_alimama_status == 1)
                            {
                                //LogUtil.log_cms_call(cmsForm, "转化失败。检查是否阿里妈妈登录过期");
                            }
                        }

                        if (apply_alimama_status == 1)
                        {
                            if (!AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie)
                                && Process.GetProcessesByName(Constants.alimama_login_exe_name).Length <= 0)
                            {
                                LogUtil.log_cms_call(cmsForm, "阿里妈妈登录过期。正在开始重新登录");
                                if (cmsForm.checkBoxAutoLogin.Checked)
                                {
                                    AlimamaLogin.login(cmsForm, 1);
                                }
                                else
                                {
                                    LogUtil.log_cms_call(cmsForm, "没有开启阿里妈妈自动登录，无法完成登录");
                                }
                            }
                            else if (AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
                            {
                                LogUtil.log_cms_call(cmsForm, "阿里妈妈登录正常");
                                apply_alimama_status = 0;
                            }
                            else if (Process.GetProcessesByName(Constants.alimama_login_exe_name).Length > 0)
                            {
                                LogUtil.log_cms_call(cmsForm, "登录窗口正在运行中");
                                Thread.Sleep(3000);
                            }
                        }
                        else if (apply_alimama_status == 2)
                        {
                            LogUtil.log_cms_call(cmsForm, "申请过快，休息30秒继续");
                            Thread.Sleep(30000);
                            apply_alimama_status = 0;
                        }

                        //Thread.Sleep(cmsForm.appBean.alimama_request_url_time * 1000);
                    }
                    catch (Exception exception)
                    {
                        //LogUtil.log_call(cmsForm, "" + exception.ToString());
                    }
                }
                LogUtil.log_cms_call(cmsForm, "停止自动实时申请");
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm,"[checkAutoLogin]出错！" + exception.ToString());
            }

        }

        internal static void apply_cms_url(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;

            try
            {
                LogUtil.log_cms_call(cmsForm, "开始自动申请");
                int apply_alimama_status = 0;
                TaokeItem taoke_item_init = null;
                int count_xunhuan = 0;
                while (cmsForm.appBean.apply_taoke_url_status)
                {
                    try {
                        if (apply_alimama_status == 0)
                        {
                            if (taoke_item_init == null)
                            {
                                count_xunhuan = 0;
                            }
                            CmsUtil.apply_taoke_url(cmsForm, ref apply_alimama_status, ref taoke_item_init, ref count_xunhuan);
                            if (apply_alimama_status == 1)
                            {
                                LogUtil.log_cms_call(cmsForm, "转化失败。检查是否阿里妈妈登录过期");
                            }
                        }

                        if (apply_alimama_status == 1)
                        {
                            if (!AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie)
                                && Process.GetProcessesByName(Constants.alimama_login_exe_name).Length <= 0)
                            {
                                LogUtil.log_cms_call(cmsForm, "阿里妈妈登录过期。正在开始重新登录");
                                if (cmsForm.checkBoxAutoLogin.Checked)
                                {
                                    AlimamaLogin.login(cmsForm, 1);
                                }
                                else
                                {
                                    LogUtil.log_cms_call(cmsForm, "没有开启阿里妈妈自动登录，无法完成登录");
                                }
                            }
                            else if (AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
                            {
                                LogUtil.log_cms_call(cmsForm, "阿里妈妈登录正常");
                                apply_alimama_status = 0;
                            }
                            else if (Process.GetProcessesByName(Constants.alimama_login_exe_name).Length > 0)
                            {
                                LogUtil.log_cms_call(cmsForm, "登录窗口正在运行中");
                                Thread.Sleep(3000);
                            }
                        }
                        else if (apply_alimama_status == 2)
                        {
                            LogUtil.log_cms_call(cmsForm, "申请过快，休息30秒继续");
                            Thread.Sleep(30000);
                            apply_alimama_status = 0;
                        }

                        Thread.Sleep(cmsForm.appBean.alimama_request_url_time*1000);
                    }
                    catch (Exception exception)
                    {
                        //LogUtil.log_call(cmsForm, "" + exception.ToString());
                    }
                }
                LogUtil.log_cms_call(cmsForm, "停止自动申请");
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm,"[checkAutoLogin]出错！" + exception.ToString());
            }

        }

        public static void apply_taoke_url_user(CmsForm cmsForm, ref int status, ref TaokeItem taoke_item_init, ref int count_xunhuan)
        {
            if (taoke_item_init != null)
            {
                count_xunhuan++;
                TaokeItem taokeItem = taoke_item_init;
                string out_log = "";
                if (!string.IsNullOrEmpty(taokeItem.title))
                {
                    LogUtil.log_cms_call(cmsForm, "商品：【" + taokeItem.title + "】");
                    LogUtil.log_cms_call(cmsForm, "id：【" + taokeItem.num_iid + "】");
                    CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                }
                else
                {
                    status = 0;
                }
                if (status == 0)
                {
                    taoke_item_init = null;
                }
            }
            else
            {
                UserCmsItemBean userCmsItemBean = null;
                //userCmsItemBean = CmsUtil.get_user_cms_data_num_iid_user_queue(cmsForm);
                userCmsItemBean = CmsUtil.get_user_cms_data_num_iid_user(cmsForm);
                if (userCmsItemBean == null)
                {
                    UserUtil.query_taoke_item_list_html_online(cmsForm);
                    //LogUtil.log_cms_call(cmsForm, "商品：【" + cmsForm.appBean.userCmsBean_user + "】");
                    //userCmsItemBean = CmsUtil.get_user_cms_data_num_iid_user_queue(cmsForm);
                    userCmsItemBean = CmsUtil.get_user_cms_data_num_iid_user(cmsForm);
                }
                if (userCmsItemBean != null)
                {
                    //LogUtil.log_cms_call(cmsForm, "商品：【】");
                    TaokeItem taokeItem = new TaokeItem();
                    taokeItem.app_id = userCmsItemBean.app_id;
                    taokeItem.user_id = userCmsItemBean.user_id;
                    taokeItem.num_iid = userCmsItemBean.num_iid;
                    taokeItem.pid = userCmsItemBean.pid;
                    taoke_item_init = taokeItem;

                    string out_log = "";
                    ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + taokeItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                    if (out_log.Contains("\"wait\""))
                    {
                        status = 2;
                    }
                    else
                    {
                        if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                        {
                            taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                            taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;
                            taokeItem.tkMktStatus = ((GoodsItem2)taoke_goods_list[0]).tkMktStatus;
                            taokeItem.couponEffectiveStartTime = ((GoodsItem2)taoke_goods_list[0]).couponEffectiveStartTime;
                            taokeItem.couponEffectiveEndTime = ((GoodsItem2)taoke_goods_list[0]).couponEffectiveEndTime;
                            taokeItem.eventRate = ((GoodsItem2)taoke_goods_list[0]).eventRate;

                            if (!string.IsNullOrEmpty(taokeItem.title))
                            {
                                LogUtil.log_cms_call(cmsForm, "商品：【" + taokeItem.title + "】");
                                LogUtil.log_cms_call(cmsForm, "id：【" + taokeItem.num_iid + "】");
                                if (taokeItem.tkMktStatus == 1)
                                {
                                    LogUtil.log_cms_call(cmsForm, "【该产品为营销计划：" + taokeItem.couponEffectiveStartTime + "---" + taokeItem.couponEffectiveEndTime + "】");
                                }
                                CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                                //LogUtil.log_cms_call(cmsForm, "status：【" + status + "】");
                            }
                            else
                            {
                                status = 0;
                            }
                            if (status == 0)
                            {
                                cmsForm.sendSqlUtil.insert_cms_item_plan(taokeItem.num_iid + taokeItem.pid, out out_log);
                                taoke_item_init = null;
                            }
                        }
                    }
                }
                else {
                    LogUtil.log_cms_call(cmsForm, "实时商品购物监控中。。。。");
                    Thread.Sleep(500);
                }

            }

        }

        public static void apply_taoke_url(CmsForm cmsForm, ref int status, ref TaokeItem taoke_item_init, ref int count_xunhuan)
        {
            if (taoke_item_init != null)
            {
                count_xunhuan++;
                TaokeItem taokeItem = taoke_item_init;
                string out_log = "";
                //GoodsItem goodsItem = UserUtil.query_goods(cmsForm, taokeItem.num_iid, out out_log);
                //if ((goodsItem != null))
                //{
                //    taokeItem.title = goodsItem.title;
                //    LogUtil.log_cms_call(cmsForm, "获取新的转化商品【" + taokeItem.title + "】【id：" + taokeItem.num_iid + "】");
                //    CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                //}

                //ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + taokeItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                //if (out_log.Contains("\"wait\""))
                //{
                //    status = 2;
                //    LogUtil.log_cms_call(cmsForm, "query:" + out_log);
                //}
                //else
                //{
                //    if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                //    {
                //        taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                //        taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;
                        if (!string.IsNullOrEmpty(taokeItem.title))
                        {
                            LogUtil.log_cms_call(cmsForm, "商品：【" + taokeItem.title + "】");
                            LogUtil.log_cms_call(cmsForm, "id：【" + taokeItem.num_iid + "】");
                            CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                        }
                        else {
                            status = 0;
                        }
                        if (status == 0)

                        {
                            taoke_item_init = null;
                        }
                //    }
                //    else
                //    {
                //        taoke_item_init = null;
                //    }
                //}
                //if (taoke_item_init!=null&&count_xunhuan>2)
                //{
                //    taoke_item_init = null;
                //}
            }
            else {
                //ArrayList taoke_item_list = UserUtil.query_taoke_item_list(cmsForm);
                //ArrayList taoke_item_list = UserUtil.query_taoke_item_list_html(cmsForm);
                UserCmsItemBean userCmsItemBean = CmsUtil.get_user_cms_data_num_iid(cmsForm);
                if (userCmsItemBean==null)
                {
                    //LogUtil.log_cms_call(cmsForm, "userCmsItemBean:");
                    UserUtil.query_taoke_item_list_html(cmsForm);
                    string out_log = "";
                    UserUtil.query_user_cms_tongzhi(cmsForm, out out_log);
                    userCmsItemBean = CmsUtil.get_user_cms_data_num_iid(cmsForm);
                }
                if (userCmsItemBean != null)
                {
                    TaokeItem taokeItem = new TaokeItem();
                    taokeItem.app_id = userCmsItemBean.app_id;
                    taokeItem.user_id = userCmsItemBean.user_id;
                    taokeItem.num_iid = userCmsItemBean.num_iid;
                    taokeItem.pid = userCmsItemBean.pid;
                    taoke_item_init = taokeItem;

                    string out_log = "";
                    ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + taokeItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                    if (out_log.Contains("\"wait\""))
                    {
                        status = 2;
                        //LogUtil.log_cms_call(cmsForm, "query:" + out_log);
                    }
                    else {
                        if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                        {
                            taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                            taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;
                            taokeItem.user_num_id = ((GoodsItem2)taoke_goods_list[0]).user_num_id;
                            taokeItem.tkMktStatus = ((GoodsItem2)taoke_goods_list[0]).tkMktStatus;
                            taokeItem.couponEffectiveStartTime = ((GoodsItem2)taoke_goods_list[0]).couponEffectiveStartTime;
                            taokeItem.couponEffectiveEndTime = ((GoodsItem2)taoke_goods_list[0]).couponEffectiveEndTime;
                            taokeItem.eventRate = ((GoodsItem2)taoke_goods_list[0]).eventRate;

                            if (!string.IsNullOrEmpty(taokeItem.title))
                            {
                                LogUtil.log_cms_call(cmsForm, "商品：【" + taokeItem.title + "】");
                                LogUtil.log_cms_call(cmsForm, "id：【" + taokeItem.num_iid + "】");
                                if (taokeItem.tkMktStatus==1)
                                {
                                    LogUtil.log_cms_call(cmsForm, "【该产品为营销计划：" + taokeItem.couponEffectiveStartTime + "---" + taokeItem.couponEffectiveEndTime + "】");
                                }
                                CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                            }
                            else {
                                status = 0;
                            }
                            if (status == 0)
                            {
                                taoke_item_init = null;
                            }
                        }
                    }
                }

                //if (taoke_item_list != null && taoke_item_list.Count > 0)
                //{
                //    foreach (TaokeItem taokeItem in taoke_item_list)
                //    {
                //        taoke_item_init = taokeItem;
                //        string out_log = "";

                //        if (taokeItem.taoke_status==0)
                //        {
                //            LogUtil.log_cms_call(cmsForm, "商品【" + taokeItem.title + "】【id：" + taokeItem.num_iid + "】【" + taokeItem.taoke_status_err + "】");
                //             taoke_item_init = null;
                //        }else{
                //        //ArrayList taoke_goods_list = AlimamaUtil.query_taoke_goods_list("https://item.taobao.com/item.htm?id=" + taokeItem.num_iid, cmsForm.appBean.taoke_cookie, out out_log);
                //        //if (out_log.Contains("\"wait\""))
                //        //{
                //        //    status = 2;
                //        //    LogUtil.log_cms_call(cmsForm, "query:" + out_log);
                //        //}
                //        //else
                //        //{
                //        //    if ((taoke_goods_list != null) && (taoke_goods_list.Count != 0))
                //        //    {
                //        //        taokeItem.title = ((GoodsItem2)taoke_goods_list[0]).title;
                //        //        taokeItem.tkRate = ((GoodsItem2)taoke_goods_list[0]).tkRate;
                //                LogUtil.log_cms_call(cmsForm, "获取新的转化商品【" + taokeItem.title + "】【id：" + taokeItem.num_iid + "】");
                //                CmsUtil.apply_taoke_url_item(cmsForm, taokeItem, ref status);
                //                if (status == 0)
                //                {
                //                    taoke_item_init = null;
                //                }
                //        //    }
                //        //    else
                //        //    {
                //        //        taoke_item_init = null;
                //        //    }
                //        //}
                //        }
                //    }
                //}
            }
        
        }

        public static void apply_taoke_url_item(CmsForm cmsForm, TaokeItem taokeItem, ref int status)
        {
            if (taokeItem.num_iid != string.Empty)
            {
                string out_log = "";
                ArrayList goods_campaign_list = AlimamaUtil.query_campaign_list(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, out out_log);
                //LogUtil.log_cms_call(cmsForm, "[goods_campaign_list:]" + out_log);
                CampaignItem1 campaignItem_current=null;
                CampaignItem1 campaignItem_current_auto = null;
                CampaignItem1 campaignItem_current_apply = null; //已经申请的计划

                //LogUtil.log_cms_call(cmsForm, "[tkRate:]" + taokeItem.tkRate);

                if (goods_campaign_list != null && goods_campaign_list.Count > 0)
                {
                    foreach (CampaignItem1 campaignItem1 in goods_campaign_list)
                    {
                        //LogUtil.log_cms_call(cmsForm, "[campaignItem1:]" + campaignItem1.commissionRate);

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
                else {
                    if (out_log.Contains("\"wait\""))
                    {
                        status = 2;
                        LogUtil.log_cms_call(cmsForm, "[query_campaign:]" + out_log);
                        return;
                    }
                    else if (out_log.Contains("\"nologin\""))
                    {
                        status = 1;
                        return;
                    }
                }
                out_log = "";
                if (campaignItem_current_auto!=null)
                {
                    if (campaignItem_current_auto.Exist == "true")
                    {
                        //LogUtil.log_cms_call(cmsForm, "定向计划【" + campaignItem_current_auto.CampaignName + "】佣金比例【" + campaignItem_current_auto.commissionRate + "%】已经申请过已经申请过。本次跳过重复申请");
                        LogUtil.log_cms_call(cmsForm, "定向计划【" + campaignItem_current_auto.CampaignName + "】佣金比例【" + campaignItem_current_auto.commissionRate + "%】");
                    }
                    else {
                        LogUtil.log_cms_call(cmsForm, "开始申请定向计划【" + campaignItem_current_auto.CampaignName + "】佣金比例【" + campaignItem_current_auto.commissionRate + "%】");
                        AlimamaUtil.apply_campaign(cmsForm, campaignItem_current_auto.CampaignID
                            , campaignItem_current_auto.ShopKeeperID, Constants.applyreason_pre, cmsForm.appBean.applyreason, cmsForm.appBean.taoke_cookie, out out_log, "");
                        if (out_log.Contains("\"wait\""))
                        {
                            status = 2;
                            //LogUtil.log_cms_call(cmsForm, "[apply_campaign_auto:]" + out_log);
                            return;
                        }
                    }
                }
                else if (campaignItem_current != null)
                {
                    if (campaignItem_current.Exist == "true")
                    {
                        //LogUtil.log_cms_call(cmsForm, "定向计划【" + campaignItem_current.CampaignName + "】佣金比例【" + campaignItem_current.commissionRate + "%】已经申请过。本次跳过重复申请");
                        LogUtil.log_cms_call(cmsForm, "定向计划【" + campaignItem_current.CampaignName + "】佣金比例【" + campaignItem_current.commissionRate + "%】");
                    }
                    else
                    {
                        LogUtil.log_cms_call(cmsForm, "开始申请定向计划【" + campaignItem_current.CampaignName + "】佣金比例【" + campaignItem_current.commissionRate + "%】");
                        AlimamaUtil.apply_campaign(cmsForm, campaignItem_current.CampaignID
                            , campaignItem_current.ShopKeeperID, Constants.applyreason_pre, cmsForm.appBean.applyreason, cmsForm.appBean.taoke_cookie, out out_log, "");
                        if (out_log.Contains("\"wait\""))
                        {
                            status = 2;
                            //LogUtil.log_cms_call(cmsForm, "[apply_campaign:]" + out_log);
                            return;
                        }
                    }
                }

                if (out_log != null && out_log != "")
                {
                    LogUtil.log_cms_call(cmsForm, out_log);
                }

                GoodsItem2 goodsItem2 = AlimamaUtil.query_taoke_item_event(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, out out_log);
                int url_type = 0;
                if (goodsItem2 != null
                    && taokeItem.tkRate < goodsItem2.eventRate
                    && (campaignItem_current_auto == null
                    || campaignItem_current_auto.commissionRate < goodsItem2.eventRate))
                {
                    url_type = 1;
                }
                else {
                    if (out_log.Contains("\"wait\""))
                    {
                        status = 2;
                        //LogUtil.log_cms_call(cmsForm, "[query_campaign:]" + out_log);
                        return;
                    }
                }

                if (url_type==1)
                {
                    if (!cmsForm.appBean.cms_jihua)
                    {
                        LogUtil.log_cms_call(cmsForm, "通过鹊桥计划转换链接：佣金比例【" + goodsItem2.eventRate + "%】");
                    }
                    else {
                        LogUtil.log_cms_call(cmsForm, "鹊桥计划：佣金比例【" + goodsItem2.eventRate + "%】");
                    }
                }else{
                    if (campaignItem_current_auto != null)
                    {
                        if (!cmsForm.appBean.cms_jihua)
                        {
                            LogUtil.log_cms_call(cmsForm, "通过定向计划转换链接：佣金比例【" + campaignItem_current_auto.commissionRate + "%】");
                        }
                        else {
                            LogUtil.log_cms_call(cmsForm, "定向计划：佣金比例【" + campaignItem_current_auto.commissionRate + "%】");
                        }
                        taokeItem.auto_Rate = campaignItem_current_auto.commissionRate;
                    }
                    else {
                        if (campaignItem_current!=null)
                        {
                            if (!cmsForm.appBean.cms_jihua)
                            {
                                LogUtil.log_cms_call(cmsForm, "通过通用计划转换链接：佣金比例【" + taokeItem.tkRate + "%】 定向计划【" + campaignItem_current.CampaignName + "】审核通过后，会自动走高佣金【" + campaignItem_current.commissionRate + "%】");
                            }
                        }else{
                            if (campaignItem_current_apply != null)
                            {
                                AlimamaUtil.exitCampaign(taokeItem.user_num_id, campaignItem_current_apply.CampaignID, cmsForm.appBean.taoke_cookie, out out_log);
                                if (!string.IsNullOrEmpty(out_log))
                                {
                                    LogUtil.log_cms_call(cmsForm, out_log);
                                }
                            }
                            if (taokeItem.tkMktStatus == 1)
                            {
                                LogUtil.log_cms_call(cmsForm, "通过营销计划转换链接：佣金比例【" + taokeItem.tkRate + "%】");
                            }
                            else { 
                                LogUtil.log_cms_call(cmsForm, "通过通用计划转换链接：佣金比例【" + taokeItem.tkRate+ "%】");
                            }
                        }
                    }
                }

                AlimamaClick alimamaClick = null;
                if (!cmsForm.appBean.cms_jihua||taokeItem.tkMktStatus==1)
                {
                    if(!string.IsNullOrEmpty(taokeItem.pid)
                        && taokeItem.tkMktStatus == 1)
                    {
                        string[] pid_list = Regex.Split(taokeItem.pid, "_", RegexOptions.IgnoreCase);
                        string adzoneid = "";
                        string siteid = "";
                        if (pid_list.Length>2)
                        {
                            siteid = pid_list[1];
                            adzoneid = pid_list[2];
                        }
                        alimamaClick = AlimamaUtil.query_taoke_click(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, adzoneid, siteid, url_type, out out_log);
                    }else{                        
                        alimamaClick = AlimamaUtil.query_taoke_click(cmsForm.appBean.taoke_cookie, taokeItem.num_iid, cmsForm.appBean.cms_adzoneid, cmsForm.appBean.cms_siteid, url_type, out out_log);
                    }
                    if (alimamaClick != null)
                    {
                        taokeItem.click_url = alimamaClick.url;
                        taokeItem.short_url = alimamaClick.short_url;
                        taokeItem.tao_token = alimamaClick.tao_token;

                        if (taokeItem.tkMktStatus == 1
                            && !String.IsNullOrEmpty(taokeItem.pid)
                            && !String.IsNullOrEmpty(alimamaClick.coupon_short_url)
                            && alimamaClick.coupon_short_url.Contains("http"))
                        {
                            taokeItem.click_url = alimamaClick.coupon_url;
                            taokeItem.short_url = alimamaClick.coupon_short_url;
                            taokeItem.tao_token = alimamaClick.coupon_link_tao_token;

                        }
                        if (taokeItem.tkMktStatus == 1
                            && taokeItem.tkRate > taokeItem.eventRate
                            && taokeItem.tkRate > taokeItem.auto_Rate)
                        {
                            //如果是营销计划，提交口令和链接到云端
                            UserUtil.submit_taoke_item_plan(cmsForm, taokeItem);
                        }

                        //string coupon_url = Constants.coupon_url_m.Replace("{seller_id}", taokeItem.user_num_id).Replace("{activity_id}", taokeItem.activity_id);
                        //CouponItem coupon_item = TaobaoUtil.get_coupon(coupon_url);
                        //if (coupon_item.leftCount < 1)
                        //{
                        //    LogUtil.log_cms_call(cmsForm, "【优惠券过期，无法获取二合一淘口令】");
                        //}
                        //else {
                        //    LogUtil.log_cms_call(cmsForm, "【优惠券信息："+coupon_item.ToString()+"】");
                        //    //LogUtil.log_cms_call(cmsForm, "【通过接口获取口令：" + KoulingUtil.get_kouling(
                        //    //    "233742161", "1"
                        //    //   , coupon_url, taokeItem.pic_url, taokeItem.title, "") + "】");
                        //    //string coupon_link_tao_token = CmsUtil.apply_cms_taokouling_url(cmsForm, taokeItem.num_iid, taokeItem.activity_id, "mm_" + cmsForm.appBean.member_id + "_" + cmsForm.appBean.cms_siteid + "_" + cmsForm.appBean.cms_adzoneid + "");
                        //    //if (!String.IsNullOrEmpty(coupon_link_tao_token))
                        //    //{
                        //    //    LogUtil.log_cms_call(cmsForm, "获取到淘口令：[" + coupon_link_tao_token + "]");
                        //    //    alimamaClick.coupon_link_tao_token = coupon_link_tao_token;
                        //    //    Constants.set_ie_boolean = true;
                        //    //}
                        //    //else
                        //    //{
                        //        alimamaClick.coupon_link_tao_token = "";
                        //    //    if (Constants.set_ie_boolean == false)
                        //    //    {
                        //    //        LogUtil.log_cms_call(cmsForm, "***********提醒：[可能是配置淘口令环境未成功，请右键一以管理员身份运行助手目录下的“配置淘口令环境”程序]*********当前IE版本：[" + cmsForm.webBrowserQuanAlimama.Version.ToString() + "]");
                        //    //    }
                        //    //}
                        //        LogUtil.log_cms_call(cmsForm, "【二合一淘口令会通过云平台生成】");
                        //}

                    }
                    else
                    {
                        if (out_log.Contains("\"wait\""))
                        {
                            status = 2;
                            //LogUtil.log_cms_call(cmsForm, "[click:]" + out_log);
                        }
                        else if (out_log.Contains("callLocation") || out_log.Contains("gen url item not found on call"))
                        {
                            //LogUtil.log_cms_call(cmsForm, "[该商品已经下架或者退出了淘客推广。后期系统将会将此商家列为黑名单商家:]");
                        }
                        else if (out_log.Contains("invalidKey\":\"adzoneid"))
                        {
                            //LogUtil.log_cms_call(cmsForm, "[该商品已经下架或者退出了淘客推广。后期系统将会将此商家列为黑名单商家:]");
                        }
                        else
                        {
                            status = 1;
                            //if (out_log != null && out_log != "")
                            //{
                            //    LogUtil.log_cms_call(cmsForm, out_log);
                            //}
                        }
                    }

                }
                else {
                    alimamaClick = new AlimamaClick();
                    alimamaClick.num_iid = taokeItem.num_iid;
                }
                if (alimamaClick != null)
                {
                    LogUtil.log_cms_call(cmsForm, "【二合一淘口令已通过云平台生成】");
                    //UserUtil.submit_taoke_item(cmsForm, alimamaClick);
                    CmsUtil.add_taoke_item(cmsForm, alimamaClick);
                }
            }
        }

        internal static void tongji_user_cms(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            try
            {
                LogUtil.log_call(cmsForm, "统计开始");
                while (cmsForm.appBean.apply_taoke_url_status)
                {
                    string out_log;
                    UserCmsTongji userCmsTongji = UserUtil.query_user_cms_tongji(cmsForm, out out_log);
                    if (userCmsTongji!=null)
                    {
                        CmsUtil.update_cms_tongji_call(cmsForm, userCmsTongji);
                        //LogUtil.log_cms_call(cmsForm, "【商品转化统计】：已经转化：【" + userCmsTongji.have + "】------ 剩余商品：【" + userCmsTongji.all + "】");
                    }
                    Thread.Sleep(3000);
                }
                LogUtil.log_call(cmsForm, "统计停止");
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm, "[checkAutoLogin]出错！" + exception.ToString());
            }

        }

        internal static void update_cms_tongji_call(CmsForm cmsForm,UserCmsTongji userCmsTongji)
        {

            if (cmsForm.label_tongji_all.InvokeRequired)
            {
                update_cms_tongji_call d = new update_cms_tongji_call(CmsUtil.update_cms_tongji_call);
                cmsForm.Invoke(d, new object[] { cmsForm, userCmsTongji });
            }
            else
            {
                cmsForm.label_tongji_all.Text = "新计划：" + userCmsTongji.have;
                cmsForm.label_tongji_have.Text = "已申请：" + userCmsTongji.all;
            }

        }

        internal static string apply_cms_taokouling_url(CmsForm cmsForm,string num_iid,string activity_id,string pid)
        {
            try
            {
                CmsUtil.update_user_agent_Handler(cmsForm);
                //LogUtil.log_call(cmsForm, "当前IE版本：[" + cmsForm.cmsForm.webBrowserQuanAlimama.Version.ToString() + "]");
                string uland_url = "http://uland.taobao.com/coupon/edetail?activityId=" + activity_id + "&pid=" + pid + "&itemId=" + num_iid + "&src=qhkj_dtkp&dx=";
                //string uland_url = "http://uland.taobao.com/coupon/edetail?activityId=602d4c4059ad4860a213a7da064a3f7b&itemId=540439530959&src=tkm_tkmwz";
                cmsForm.webBrowserQuanAlimama.Navigate(uland_url);
                LogUtil.log_call(cmsForm, "[uland_url]出错！" + uland_url);
                cmsForm.appBean.taokouling = null;
                //System.Threading.Timer timer = new System.Threading.Timer(new TimerCallback(timer_Elapsed), null, 0, 1000);
                int times = 0;
                while (times < 50 && String.IsNullOrEmpty(cmsForm.appBean.taokouling))
                {
                    Thread.Sleep(100);
                    times++;
                }
                if (!String.IsNullOrEmpty(cmsForm.appBean.taokouling))
                {
                    string coupon_link_tao_token = cmsForm.appBean.taokouling;
                    cmsForm.webBrowserQuanAlimama.Navigate("about:blank");
                    cmsForm.appBean.taokouling = null;
                    return coupon_link_tao_token;
                }
                cmsForm.webBrowserQuanAlimama.Navigate("about:blank");
            }
            catch (Exception exception)
            {
                cmsForm.webBrowserQuanAlimama.Navigate("about:blank");
                LogUtil.log_call(cmsForm, "[获取淘口令]出错！" + exception.ToString());
            }
            return null;
        }

        internal static void update_user_agent_Handler(Object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            if (cmsForm.webBrowserQuanAlimama.InvokeRequired)
            {
                update_user_agent_Handler d = new update_user_agent_Handler(CmsUtil.update_user_agent_Handler);
                cmsForm.Invoke(d, new object[] { cmsForm });
            }
            else
            {
                UserAgentHelper.AppendUserAgent("Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.75 Safari/537.36 QQBrowser/4.1.4132.400");
                UserAgentHelper.AppendUserAgent("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
                cmsForm.webBrowserQuanAlimama.ScriptErrorsSuppressed = true;
                cmsForm.webBrowserQuanAlimama.IsWebBrowserContextMenuEnabled = false;
                LogUtil.log_call(cmsForm, "[update_user_agent_Handler]");
            }

        }

        public static UserCmsItemBean get_user_cms_data_num_iid_user(CmsForm cmsForm)
        {
            UserCmsItemBean userCmsItemBean = null;
            UserCmsBean userCmsBean = cmsForm.appBean.userCmsBean_user;
            if (userCmsBean != null && userCmsBean.items != null
                && userCmsBean.items.Count > 0)
            {
                int weizhi = userCmsBean.weizhi;
                //LogUtil.log_cms_call(cmsForm, "weizhi----------------------------" + weizhi);
                if (userCmsBean.items.Count > weizhi)
                {
                    if (weizhi>0)
                    {
                        Thread.Sleep(1000);
                    }
                    userCmsItemBean = new UserCmsItemBean();
                    userCmsItemBean.app_id = userCmsBean.app_id;
                    userCmsItemBean.user_id = userCmsBean.user_id;

                    CmsPlanItem cmsPlanItem = (CmsPlanItem)userCmsBean.items[weizhi];

                    string num_iid = cmsPlanItem.num_iid;
                    string pid = cmsPlanItem.pid;

                    userCmsItemBean.num_iid = num_iid;
                    userCmsItemBean.pid = pid;
                    userCmsBean.weizhi = weizhi + 1;
                }
                userCmsBean.itemsTaoke = new ArrayList();
            }
            return userCmsItemBean;
        }

        public static UserCmsItemBean get_user_cms_data_num_iid_user_queue(CmsForm cmsForm)
        {
            UserCmsItemBean userCmsItemBean = null;
            UserCmsBean userCmsBean = cmsForm.appBean.userCmsBean_user;
            if (userCmsBean != null && userCmsBean.ListQueue != null
                && userCmsBean.ListQueue.Count > 0)
            {
                userCmsItemBean = new UserCmsItemBean();

                CmsPlanItem cmsPlanItem = userCmsBean.ListQueue.Dequeue();

                string num_iid = cmsPlanItem.num_iid;
                string pid = cmsPlanItem.pid;

                userCmsItemBean.num_iid = num_iid;
                userCmsItemBean.pid = pid;
                userCmsItemBean.app_id = cmsPlanItem.app_id;
                userCmsItemBean.user_id = cmsPlanItem.user_id;

                userCmsBean.itemsTaoke = new ArrayList();
            }
            return userCmsItemBean;
        }

        public static UserCmsItemBean get_user_cms_data_num_iid(CmsForm cmsForm)
        {
            UserCmsItemBean userCmsItemBean = null;
            UserCmsBean userCmsBean = cmsForm.appBean.userCmsBean;
            if (userCmsBean != null&&userCmsBean.items!=null
                &&userCmsBean.items.Count>0)
            {
                int weizhi = userCmsBean.weizhi;
                if (userCmsBean.items.Count > weizhi)
                {
                    userCmsItemBean = new UserCmsItemBean();
                    userCmsItemBean.app_id = userCmsBean.app_id;
                    userCmsItemBean.user_id = userCmsBean.user_id;

                    CmsPlanItem cmsPlanItem = (CmsPlanItem)userCmsBean.items[weizhi];

                    string num_iid = cmsPlanItem.num_iid;
                    string pid = cmsPlanItem.pid;

                    userCmsItemBean.num_iid = num_iid;
                    userCmsItemBean.pid = pid;
                    userCmsBean.weizhi = weizhi + 1;
                }

                if (
                        userCmsItemBean == null && (userCmsBean.itemsTaoke != null && userCmsBean.itemsTaoke.Count > 0)
                    || (userCmsBean.itemsTaoke != null && userCmsBean.itemsTaoke.Count > 30)
                    )
                {
                    //提交转化好的数据
                    LogUtil.log_cms_call(cmsForm, "提交缓存的转化数据----------------------------");
                    UserUtil.submit_taoke_items(cmsForm, userCmsBean.itemsTaoke);
                    userCmsBean.itemsTaoke = new ArrayList();
                }
            }
            if (userCmsItemBean==null) //
            {
                string out_log = "";
                UserUtil.query_user_cms_tongzhi(cmsForm,out out_log);
            }
            return userCmsItemBean;
        }

        public static void add_taoke_item(CmsForm cmsForm, AlimamaClick alimamaClick)
        {

            UserCmsBean userCmsBean = cmsForm.appBean.userCmsBean;
            if (userCmsBean== null)
            {
                userCmsBean = new UserCmsBean();
                cmsForm.appBean.userCmsBean = userCmsBean;
            }
            ArrayList item_taoke = userCmsBean.itemsTaoke;
            if (item_taoke == null)
            {
                item_taoke = new ArrayList();
                userCmsBean.itemsTaoke = item_taoke;
            }
            if (alimamaClick!=null)
            {
                item_taoke.Add(alimamaClick);
            }
        }

        internal static void apply_cms_url_alimama_login(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            try
            {
                while (cmsForm.appBean.apply_taoke_url_status)
                {
                    try
                    {
                        if (AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
                        {

                        }
                        else
                        {
                            cmsForm.appBean.alimama_login_status = false;
                            AlimamaLogin.login(cmsForm, 1);
                        }

                    }
                    catch (Exception exception)
                    {
                        //LogUtil.log_call(cmsForm, "" + exception.ToString());
                    }
                    Thread.Sleep(60000);
                }
            }
            catch (Exception exception)
            {
                //LogUtil.log_call(cmsForm,"[checkAutoLogin]出错！" + exception.ToString());
            }

        }

        internal static void apply_cms_url_user_KeepAlive(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            while(true){
                try
                {
                    if (cmsForm.clientSocket == null 
                        || !cmsForm.clientSocket.Connected
                        )
                    {
                        //int port = 65432;
                        //string host = "192.168.0.103";//服务器端ip地址
                        //host = "116.62.83.73";

                        IpBean ipBean = CmsUtil.get_ip(cmsForm);
                        if (ipBean != null)
                        {
                            IPAddress ip = IPAddress.Parse(ipBean.ip);
                            IPEndPoint ipe = new IPEndPoint(ip, ipBean.port);

                            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            clientSocket.Connect(ipe);
                            cmsForm.clientSocket = clientSocket;

                        }

                    }
                    //send message
                    string sendStr = "{\"app_id\":\"" + cmsForm .appBean.cms_app_id+ "\"}";
                    byte[] sendBytes = Encoding.UTF8.GetBytes(sendStr);
                    cmsForm.clientSocket.Send(sendBytes);
                    Thread.Sleep(10000);

                }
                catch (Exception exception)
                {
                    try
                    {
                        if (cmsForm.clientSocket!=null)
                        {
                            cmsForm.clientSocket.Close();
                        }
                    }
                    catch (Exception ex) { }
                    Thread.Sleep(3000);
                }
            }
        }

        internal static void apply_cms_url_user_Receive(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            while (true)
            {
                try
                {
                    if (cmsForm.clientSocket == null
                        || !cmsForm.clientSocket.Connected
                        )
                    {
                        //int port = 65432;
                        //string host = "192.168.0.103";//服务器端ip地址
                        //host = "116.62.83.73";

                        IpBean ipBean = CmsUtil.get_ip(cmsForm);
                        if (ipBean!=null)
                        {
                            IPAddress ip = IPAddress.Parse(ipBean.ip);
                            IPEndPoint ipe = new IPEndPoint(ip, ipBean.port);

                            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            clientSocket.Connect(ipe);
                            cmsForm.clientSocket = clientSocket;

                        }
                    }

                    //receive message
                    string recStr = "";
                    //byte[] recBytes = new byte[1024];
                    byte[] recBytes = new byte[512];
                    int bytes = cmsForm.clientSocket.Receive(recBytes, recBytes.Length, 0);
                    recStr += Encoding.UTF8.GetString(recBytes, 0, bytes);
                    LogUtil.log_cms_call(cmsForm, "recStr:" + recStr);
                    CmsUtil.add_queue(cmsForm, recStr);
                    //Console.WriteLine(recStr);
                }
                catch (Exception exception)
                {
                    try
                    {
                        if (cmsForm.clientSocket != null)
                        {
                            cmsForm.clientSocket.Close();
                        }
                    }
                    catch (Exception ex) { }
                    Thread.Sleep(1000);
                }
                Thread.Sleep(100);
            }
        }

        public static void add_queue(CmsForm cmsForm,String content){
            try
            {
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                //String user_taoke_url = "http://" + Constants.user_cms_data_url + "/" + app_id + "_.html";
                //String body = httpservice.get(user_taoke_url, null);
                //string code = StringUtil.subString(body, 0, "<data>", "</data>");

                if (!string.IsNullOrEmpty(content))
                {
                    //ArrayList itemList = new ArrayList();

                    JsonData jo = JsonMapper.ToObject(content);
                    JsonData itemsList = jo["items_pid"];
                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        JsonData jo_item = itemsList[i];
                        string num_iid = (string)jo_item["num_iid"];
                        string pid = (string)jo_item["pid"];

                        CmsPlanItem cmsPlanItem = new CmsPlanItem();
                        cmsPlanItem.num_iid = num_iid;
                        cmsPlanItem.pid = pid;
                        cmsPlanItem.app_id = app_id;
                        cmsPlanItem.user_id = "" + user_id;

                        cmsForm.appBean.userCmsBean_user.ListQueue.Enqueue(cmsPlanItem);  

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public static IpBean get_ip(CmsForm cmsForm)
        {
            IpBean ipBean = null;
            try
            {
                LogUtil.log_cms_call(cmsForm, "链接远程监控服务中...");
                HttpService httpservice = cmsForm.httpService;
                long user_id = cmsForm.appBean.user_id;
                string app_id = cmsForm.appBean.cms_app_id;
                String user_key = cmsForm.appBean.user_key;
                String user_name = cmsForm.appBean.user_name;
                String ip_url = "http://" + Constants.api_url + "/ip.php";
                String body = httpservice.get(ip_url, null);

                if (!string.IsNullOrEmpty(body))
                {
                    ipBean = new IpBean();
                    JsonData jo = JsonMapper.ToObject(body);
                    JsonData jo_item = jo["ip_bean"];
                    string ip = (string)jo_item["ip"];
                    int port = int.Parse((string)jo_item["port"]);
                    ip = "118.31.186.239";
                    ipBean.ip = ip;
                    ipBean.port = port;
                }
            }
            catch (Exception)
            {

            }
            return ipBean;
        }


        public static void add_queue_taoke_plan_url(CmsForm cmsForm, TaokeItem taokeItem)
        {
            cmsForm.appBean.listTaokeItemQueue.Enqueue(taokeItem);
        }

        internal static void submit_taoke_plan_url(object obj)
        {
            CmsForm cmsForm = (CmsForm)obj;
            while (true)
            {
                try
                {
                    if(cmsForm.appBean.listTaokeItemQueue.Count>0){
                        TaokeItem taokeItem = cmsForm.appBean.listTaokeItemQueue.Dequeue();
                        if (cmsForm.clientSocket == null
                            || !cmsForm.clientSocket.Connected
                            )
                        {
                            IpBean ipBean = CmsUtil.get_ip(cmsForm);
                            if (ipBean != null)
                            {
                                IPAddress ip = IPAddress.Parse(ipBean.ip);
                                IPEndPoint ipe = new IPEndPoint(ip, ipBean.port);

                                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                clientSocket.Connect(ipe);
                                cmsForm.clientSocket = clientSocket;
                            }
                        }
                        //send message
                        string sendStr = "{\"num_iid\":\"" + taokeItem.num_iid + "\""+
                            ",\"pid\":\"" + taokeItem.pid + "\"" +
                             ",\"url\":\"" + taokeItem.short_url + "\"" +
                              ",\"tao_token\":\"" + taokeItem.tao_token + "\"" +
                               ",\"market_create_date\":\"" + taokeItem.couponEffectiveStartTime + "\"" +
                                ",\"market_end_date\":\"" + taokeItem.couponEffectiveEndTime + "\"" +
                           "}";
                        byte[] sendBytes = Encoding.UTF8.GetBytes(sendStr);
                        cmsForm.clientSocket.Send(sendBytes);
                    }
                }
                catch (Exception exception)
                {
                    try
                    {
                        if (cmsForm.clientSocket != null)
                        {
                            cmsForm.clientSocket.Close();
                        }
                    }
                    catch (Exception ex) { }
                    Thread.Sleep(3000);
                }
                Thread.Sleep(100);
            }
        }

//        public static byte[] input2byte(Socket clientSocket)
//        {
//            BinaryFormatter serialzer = new BinaryFormatter();
//            MemoryStream memoryStream = new MemoryStream();
//            serialzer.Serialize(memoryStream, obj);
//            memoryStream.Position = 0;
//            BinaryFormatter deserialzer = new BinaryFormatter();
//            Object obj = deserialzer.Deserialize(memoryStream);
//            memoryStream.Close();

//        ByteArrayOutputStream swapStream = new ByteArrayOutputStream(); 
        
//        // 装饰流BufferedReader封装输入流（接收客户端的流）
//        BufferedInputStream bis = new BufferedInputStream(inStream);
//        DataInputStream dis = new DataInputStream(bis);
//        byte[] bytes = new byte[1]; // 一次读取一个byte
////        String ret = "";
//        while (dis.read(bytes) != -1) {
////            ret += bytesToHexString(bytes) + " ";
//            swapStream.write(bytes);
//            if (dis.available() == 0) { //一个请求
//                return swapStream.toByteArray();
//            }
//        }
//        return swapStream.toByteArray();
        
//    }  

    }
}
