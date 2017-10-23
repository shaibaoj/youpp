using haopintui.entity;
using mshtml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace haopintui.util
{
    public class ToolsUtil
    {
        public static void zhuanhua_copy_Click_call(CmsForm cmsForm, string content)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    zhuanhua_copy_Click method = new zhuanhua_copy_Click(ToolsUtil.zhuanhua_copy_Click_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    ToolsUtil.zhuanhua_copy_Click(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void zhuanhua_copy_Click(CmsForm cmsForm,string content)
        {
            try
            {
                content = UrlUtil.copyImgContent(cmsForm, content, null);
                content = UrlUtil.parseContentWenan(cmsForm, content);
                ContentItem contentItem = UrlUtil.parseContent(cmsForm, content,null, true,true,0);
                content = contentItem.content_send;
                string out_log;
                QqUtil.copy_content(cmsForm, content, out out_log);
                if (cmsForm.checkBox_tools_qingkong.Checked)
                {
                    ((IHTMLDocument2)cmsForm.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                }
                LogUtil.log_call(cmsForm, "转换拷贝完成！");

            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


        public static void zhuanhua_copy_Click_kouling_call(CmsForm cmsForm, string content)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    zhuanhua_copy_Click method = new zhuanhua_copy_Click(ToolsUtil.zhuanhua_copy_Click_kouling_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    ToolsUtil.zhuanhua_copy_Click_kouling(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void zhuanhua_copy_Click_kouling(CmsForm cmsForm, string content)
        {
            try
            {

                content = UrlUtil.copyImgContent(cmsForm, content, null);
                content = UrlUtil.parseContentWenan(cmsForm, content);
                ContentItem contentItem = UrlUtil.parseContent(cmsForm, content, null, true, true, 0);
                content = contentItem.content_send;

                string qq_com_pid = PidUtil.get_qq_com_pid_call(cmsForm, cmsForm.appBean.member_id);

                string weiba = UrlUtil.parseContent_kouling(cmsForm, contentItem, PidUtil.get_qq_com_pid_call(cmsForm, cmsForm.appBean.member_id), true);
                if (!string.IsNullOrEmpty(weiba))
                {
                    content = content + weiba;
                }
                string out_log;
                QqUtil.copy_content(cmsForm, content, out out_log);
                if (cmsForm.checkBox_tools_qingkong.Checked)
                {
                    ((IHTMLDocument2)cmsForm.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                }
                LogUtil.log_call(cmsForm, "转换拷贝完成！");

            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


        public static void tools_zhuanhua_tianjia_zhushou_call(CmsForm cmsForm, string content)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    zhuanhua_copy_Click method = new zhuanhua_copy_Click(ToolsUtil.tools_zhuanhua_tianjia_zhushou_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    ToolsUtil.tools_zhuanhua_tianjia_zhushou(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void tools_zhuanhua_tianjia_zhushou(CmsForm cmsForm, string content1)
        {
            try
            {

                SendItem sendItem = new SendItem();
                sendItem.from = "手工添加";
                sendItem.create_date_str = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string content = cmsForm.webBrowser_zhuanhua.Document.Body.InnerHtml;
                if (string.IsNullOrEmpty(content))
                {
                    LogUtil.log_call(cmsForm, "跟发内容不能为空！");
                    return;
                }

                content = UrlUtil.parseContentWenan(cmsForm, content);
                ContentItem contentItem = UrlUtil.parseContent(cmsForm, content, null, cmsForm.checkBox_qunfa_pid.Checked, true, 0);
                content = contentItem.content_send;

                if (!string.IsNullOrEmpty(content))
                {
                    content = UrlUtil.copyImgContent(cmsForm, content, sendItem.create_date_str);
                    sendItem.memo = CommonUtil.toText(content);
                    string follow_path = cmsForm.appBean.follow_path + @"\" + sendItem.create_date_str;
                    if (!Directory.Exists(follow_path))
                    {
                        Directory.CreateDirectory(follow_path);
                    }

                    UtilFile.write(string.Concat(follow_path, "\\content.html"), content, Encoding.GetEncoding("GB2312"));
                    ((IHTMLDocument2)cmsForm.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                    LogUtil.log_call(cmsForm, "添加跟发成功！");
                    string out_log = "";
                    cmsForm.sendSqlUtil.insert(sendItem, out out_log);
                    //cmsForm.load_follow(out out_log);
                    FollowUtil.load_call(cmsForm);
                }
                else
                {
                    LogUtil.log_call(cmsForm, "跟发内容不能为空！");
                }
                if (cmsForm.checkBox_tools_qingkong.Checked)
                {
                    ((IHTMLDocument2)cmsForm.webBrowser_zhuanhua.Document.DomDocument).body.innerHTML = "";
                }

            }
            catch (Exception exception)
            {
                //MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

    }
}
