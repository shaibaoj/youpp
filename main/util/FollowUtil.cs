using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace haopintui.util
{
    public class FollowUtil
    {

        public static void load_item(CmsForm cmsForm, SendItem sendItem)
        {
            try
            {
                if (cmsForm.dataGridViewFollowSnd.InvokeRequired)
                {
                    load_item method = new load_item(FollowUtil.load_item);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, sendItem });
                }
                else
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    //cmsForm.dataGridViewFollowSnd.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");

                    DataGridViewTextBoxCell create_date_str = new DataGridViewTextBoxCell();
                    create_date_str.Value = sendItem.create_date_str;
                    create_date_str.Tag = sendItem;
                    dataGridViewRow.Cells.Add(create_date_str);
                    DataGridViewTextBoxCell from = new DataGridViewTextBoxCell();
                    from.Value = sendItem.from;
                    dataGridViewRow.Cells.Add(from);
                    DataGridViewTextBoxCell memo = new DataGridViewTextBoxCell();
                    memo.Value = sendItem.memo;
                    dataGridViewRow.Cells.Add(memo);
                    DataGridViewTextBoxCell status = new DataGridViewTextBoxCell();
                    status.Value = (sendItem.status == 0 ? "未发送" : "已发送");
                    dataGridViewRow.Cells.Add(status);

                    //DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
                    //row.Cells.Add(comboxcell);

                    //cmsForm.dataGridViewFollowSnd[0, i].Value = sendItem.create_date_str;
                    //cmsForm.dataGridViewFollowSnd[1, i].Value = sendItem.from;
                    //cmsForm.dataGridViewFollowSnd[2, i].Value = sendItem.memo;
                    //cmsForm.dataGridViewFollowSnd[3, i].Value = (sendItem.status == 0 ? "未发送" : "已发送");

                    //LogUtil.log_call(this, "sendItem.create_date:" + sendItem.create_date);
                    //this.dataGridViewFollowSnd[2, string0].Value = GClass13.smethod_15(arrayList26.string_2);
                    //this.dataGridViewFollowSnd[2, string0].Style.ForeColor = GClass13.smethod_16(arrayList26.string_2);
                    //cmsForm.dataGridViewFollowSnd[0, i].Tag = sendItem;

                    cmsForm.dataGridViewFollowSnd.Rows.Add(dataGridViewRow);

                    //string out_log = "";
                    //ArrayList follow_list = cmsForm.sendSqlUtil.query_send(0, out out_log);
                    //cmsForm.dataGridViewFollowSnd.Rows.Clear();
                    //if (follow_list != null && follow_list.Count > 0)
                    //{
                    //    int i = 0;
                    //    foreach (SendItem sendItem in follow_list)
                    //    {
                    //        DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    //        cmsForm.dataGridViewFollowSnd.Rows.Add(dataGridViewRow);
                    //        cmsForm.dataGridViewFollowSnd.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                    //        cmsForm.dataGridViewFollowSnd[0, i].Value = sendItem.create_date_str;
                    //        cmsForm.dataGridViewFollowSnd[1, i].Value = sendItem.from;
                    //        cmsForm.dataGridViewFollowSnd[2, i].Value = sendItem.memo;
                    //        cmsForm.dataGridViewFollowSnd[3, i].Value = (sendItem.status == 0 ? "未发送" : "已发送");
                    //        //LogUtil.log_call(this, "sendItem.create_date:" + sendItem.create_date);
                    //        //this.dataGridViewFollowSnd[2, string0].Value = GClass13.smethod_15(arrayList26.string_2);
                    //        //this.dataGridViewFollowSnd[2, string0].Style.ForeColor = GClass13.smethod_16(arrayList26.string_2);
                    //        cmsForm.dataGridViewFollowSnd[0, i].Tag = sendItem;
                    //        i++;
                    //    }
                    //}
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void load(CmsForm cmsForm)
        {
            try
            {
                string out_log = "";
                ArrayList follow_list = cmsForm.sendSqlUtil.query_send(0, out out_log);
                cmsForm.dataGridViewFollowSnd.Rows.Clear();
                if (follow_list != null && follow_list.Count > 0)
                {
                    int i = 0;
                    foreach (SendItem sendItem in follow_list)
                    {
                        DataGridViewRow dataGridViewRow = new DataGridViewRow();
                        cmsForm.dataGridViewFollowSnd.Rows.Add(dataGridViewRow);
                        cmsForm.dataGridViewFollowSnd.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                        cmsForm.dataGridViewFollowSnd[0, i].Value = sendItem.create_date_str;
                        cmsForm.dataGridViewFollowSnd[1, i].Value = sendItem.from;
                        cmsForm.dataGridViewFollowSnd[2, i].Value = sendItem.memo;
                        cmsForm.dataGridViewFollowSnd[3, i].Value = (sendItem.status == 0 ? "未发送" : "已发送");
                        //LogUtil.log_call(this, "sendItem.create_date:" + sendItem.create_date);
                        //this.dataGridViewFollowSnd[2, string0].Value = GClass13.smethod_15(arrayList26.string_2);
                        //this.dataGridViewFollowSnd[2, string0].Style.ForeColor = GClass13.smethod_16(arrayList26.string_2);
                        cmsForm.dataGridViewFollowSnd[0, i].Tag = sendItem;
                        i++;
                    }
                }
            }
            catch
            {
                
            }
        }

        public static void load_call(CmsForm cmsForm)
        {
            try
            {
                if (cmsForm.dataGridViewFollowSnd.InvokeRequired)
                {
                    load method = new load(FollowUtil.load_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm });
                }
                else
                {
                    FollowUtil.load(cmsForm);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


        public static void load_weibo(CmsForm cmsForm)
        {
            try
            {
                string out_log = "";
                ArrayList follow_list = cmsForm.sendSqlUtil.query_weibo(0, out out_log);
                cmsForm.dataGridView_weibo.Rows.Clear();
                if (follow_list != null && follow_list.Count > 0)
                {
                    int i = 0;
                    foreach (WeiboBean weiboBean in follow_list)
                    {
                        DataGridViewRow dataGridViewRow = new DataGridViewRow();
                        cmsForm.dataGridView_weibo.Rows.Add(dataGridViewRow);
                        cmsForm.dataGridView_weibo.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                        cmsForm.dataGridView_weibo[0, i].Value = weiboBean.user_name;
                        cmsForm.dataGridView_weibo[1, i].Value = (weiboBean.status == 0 ? "未登陆" : "已登陆");
                        cmsForm.dataGridView_weibo[0, i].Tag = weiboBean;
                        i++;
                    }
                }
                cmsForm.appBean.weibo_list = follow_list;
            }
            catch
            {

            }
        }

        public static void load_weibo_call(CmsForm cmsForm)
        {
            try
            {
                if (cmsForm.dataGridView_weibo.InvokeRequired)
                {
                    load method = new load(FollowUtil.load_weibo_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm });
                }
                else
                {
                    FollowUtil.load_weibo(cmsForm);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[load_weibo]出错：" + exception.ToString());
            }
        }

        public static void load_pid_call(CmsForm cmsForm,int qun_type)
        {
            try
            {
                if (cmsForm.dataGridView_fenqun_qq.InvokeRequired)
                {
                    load_qun_pid method = new load_qun_pid(FollowUtil.load_pid_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm,qun_type });
                }
                else
                {
                    FollowUtil.load_pid(cmsForm,qun_type);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[load_pid_qq]出错：" + exception.ToString());
            }
        }
        public static void load_pid(CmsForm cmsForm, int qun_type)
        {
            try
            {
                string out_log = "";
                ArrayList follow_list = cmsForm.sendSqlUtil.query_pid(qun_type, out out_log);
                if (qun_type==1)
                {
                    cmsForm.dataGridView_fenqun_qq.Rows.Clear();
                    if (follow_list != null && follow_list.Count > 0)
                    {
                        int i = 0;
                        foreach (PidBean pidBean in follow_list)
                        {
                            DataGridViewRow dataGridViewRow = new DataGridViewRow();
                            cmsForm.dataGridView_fenqun_qq.Rows.Add(dataGridViewRow);
                            cmsForm.dataGridView_fenqun_qq.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                            cmsForm.dataGridView_fenqun_qq[0, i].Value = pidBean.qun_name;
                            cmsForm.dataGridView_fenqun_qq[1, i].Value = pidBean.qun_pid;
                            cmsForm.dataGridView_fenqun_qq[0, i].Tag = pidBean;
                            i++;
                        }
                    }
                    cmsForm.appBean.pid_qq_list = follow_list;
                }
                else if (qun_type == 2)
                {
                    cmsForm.dataGridView_fenqun_weixin.Rows.Clear();
                    if (follow_list != null && follow_list.Count > 0)
                    {
                        int i = 0;
                        foreach (PidBean pidBean in follow_list)
                        {
                            DataGridViewRow dataGridViewRow = new DataGridViewRow();
                            cmsForm.dataGridView_fenqun_weixin.Rows.Add(dataGridViewRow);
                            cmsForm.dataGridView_fenqun_weixin.Rows[i].HeaderCell.Value = string.Concat(i + 1, "");
                            cmsForm.dataGridView_fenqun_weixin[0, i].Value = pidBean.qun_name;
                            cmsForm.dataGridView_fenqun_weixin[1, i].Value = pidBean.qun_pid;
                            cmsForm.dataGridView_fenqun_weixin[0, i].Tag = pidBean;
                            i++;
                        }
                    }
                    cmsForm.appBean.pid_weixin_list = follow_list;
                }
            }
            catch
            {

            }
        }

    }
}
