using haopintui.entity;
using mshtml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace haopintui.util
{
    public class QunfaUtil
    {
        public static void qunfa_shoudong_gengfa_call(CmsForm cmsForm, string content)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    zhuanhua_copy_Click method = new zhuanhua_copy_Click(QunfaUtil.qunfa_shoudong_gengfa_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    QunfaUtil.qunfa_shoudong_gengfa(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void qunfa_shoudong_gengfa(CmsForm cmsForm, string content1)
        {
            try
            {
                SendItem sendItem = new SendItem();
                sendItem.from = "手工添加";
                sendItem.create_date_str = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string content = cmsForm.webBrowser_send_content.Document.Body.InnerHtml;

                //ContentItem contentItem = UrlUtil.parseContent(this,content);
                //sendItem.num_iid = contentItem.num_iid;
                if (!string.IsNullOrEmpty(content))
                {
                    content = UrlUtil.copyImgContent(cmsForm, content, sendItem.create_date_str);
                    sendItem.memo = CommonUtil.toText(content);
                    string follow_path = cmsForm.appBean.follow_path + @"\" + sendItem.create_date_str;
                    if (!Directory.Exists(follow_path))
                    {
                        Directory.CreateDirectory(follow_path);
                    }

                    UtilFile.write(string.Concat(follow_path, "\\content_wenan.html"), UrlUtil.parseContentWenan(cmsForm, content), Encoding.GetEncoding("GB2312"));

                    UtilFile.write(string.Concat(follow_path, "\\content_img.html"), UrlUtil.parseImg(cmsForm, content), Encoding.GetEncoding("GB2312"));


                    UtilFile.write(string.Concat(follow_path, "\\content.html"), content, Encoding.GetEncoding("GB2312"));
                    ((IHTMLDocument2)cmsForm.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                    LogUtil.log_call(cmsForm, "添加跟发成功！");
                    string out_log = "";
                    cmsForm.sendSqlUtil.insert(sendItem, out out_log);
                    FollowUtil.load_call(cmsForm);
                }
                else
                {
                    LogUtil.log_call(cmsForm, "跟发内容不能为空！");
                }

            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


        public static void qunfa_shoudong_fasong_call(CmsForm cmsForm, string content)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    zhuanhua_copy_Click method = new zhuanhua_copy_Click(QunfaUtil.qunfa_shoudong_fasong_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    QunfaUtil.qunfa_shoudong_fasong(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void qunfa_shoudong_fasong(CmsForm cmsForm, string content)
        {
            try
            {
                //content = UrlUtil.parseContentWenan(cmsForm, content);
                //ContentItem contentItem = UrlUtil.parseContent(cmsForm, content,null, cmsForm.checkBox_qunfa_pid.Checked,true,0);
                //if ((contentItem.urlList == null || contentItem.urlList.Count == 0)
                //    && cmsForm.checkBox_qunfa_link.Checked)
                //{
                //    LogUtil.log_call(cmsForm, "没有连接，跳过发送！");
                //    ((IHTMLDocument2)cmsForm.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                //    return;
                //}

                //if (contentItem.status < 1)
                //{
                //    if (cmsForm.checkBox_qunfa_qq_boolean.Checked) //开启了qq发送
                //    {
                //        LogUtil.log_call(cmsForm, "开始qq群的发送！");

                //        string content_send = contentItem.content_send;
                //        content_send = UrlUtil.template_qq(cmsForm, contentItem, PidUtil.get_qq_com_pid_call(cmsForm, cmsForm.appBean.member_id), cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.qq_template);
                //        content_send = UrlUtil.copyImgContent(cmsForm, content_send, null);
                //        //if (this.checkBox_qunfa_qq_kouling_boolean.Checked == true)
                //        //{
                //        //    string kouling = UrlUtil.parseContent_kouling(this, contentItem, PidUtil.get_qq_com_pid(this, this.appBean.member_id), true);
                //        //    content_send = content_send + kouling;
                //        //}
                //        QqUtil.send(cmsForm, content_send, content, contentItem.url_type,1);

                //        //QqUtil.send(this, contentItem.content_send);
                //    }
                //    if (cmsForm.checkBox_qunfa_weixin_boolean.Checked) //开启了qq发送
                //    {
                //        UrlUtil.parseContent_weixin(cmsForm, contentItem,null, cmsForm.checkBox_qunfa_pid.Checked);
                //        UrlUtil.template_qq(cmsForm, contentItem, PidUtil.get_weixin_pid_call(cmsForm, cmsForm.appBean.member_id), cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.weixin_template);
                //        LogUtil.log_call(cmsForm, "开始微信群的发送！");
                //        WeixinUtil.send(cmsForm, contentItem.content_weixin, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, 1);
                //    }
                //    if (cmsForm.checkBox_qunfa_weibo_boolean.Checked) //开启了qq发送
                //    {
                //        UrlUtil.parseContent_weixin(cmsForm, contentItem, PidUtil.get_weibo_pid_call(cmsForm, cmsForm.appBean.member_id), cmsForm.checkBox_qunfa_pid.Checked);
                //        UrlUtil.template_qq(cmsForm, contentItem, PidUtil.get_weibo_pid_call(cmsForm, cmsForm.appBean.member_id), cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.weibo_template);
                //        LogUtil.log_call(cmsForm, "开始微博的发送！");
                //        WeiboUtil.send(cmsForm, contentItem.content_weixin, contentItem.content_weixin_img, contentItem.imgList, content, contentItem.url_type, 1);
                //    }
                //}
                //else if (contentItem.status == 1)
                //{
                //    LogUtil.log_call(cmsForm, "优惠券小于最低优惠券要求，跳过发送！");
                //}
                //else if (contentItem.status == 2)
                //{
                //    LogUtil.log_call(cmsForm, "佣金比例小于设置的最低比例，跳过发送！");
                //}
                //else if (contentItem.status == 2)
                //{
                //    LogUtil.log_call(cmsForm, "所发的链接转换失败，跳过发送！");
                //}
                //try
                //{
                //    ((IHTMLDocument2)cmsForm.webBrowser_send_content.Document.DomDocument).body.innerHTML = "";
                //}
                //catch (Exception exception)
                //{ }

            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "发动异常:" + exception.ToString());
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

    }
}
