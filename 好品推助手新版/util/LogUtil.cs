using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace haopintui
{
    public class LogUtil
    {
        public static void log_str(CmsForm cmsForm,String content)
        {
            try
            {
                string text = cmsForm.richTextBoxLogs.Text;
                if (text.Length > 0x1388)
                {
                    cmsForm.richTextBoxLogs.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text.Substring(0, 0x7d0);
                }
                else
                {
                    cmsForm.richTextBoxLogs.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text;
                }
            }
            catch
            {
                LogUtil.log_call(cmsForm, content);
            }
        }

        public static void log_call(CmsForm cmsForm, String content)
        {
            try
            {
                if (cmsForm.richTextBoxLogs.InvokeRequired)
                {
                    log method = new log(LogUtil.log_call);
                    cmsForm.BeginInvoke(method, new object[] {cmsForm, content });
                }
                else
                {
                    LogUtil.log_str(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }

        public static void log_cms_str(CmsForm cmsForm, String content)
        {
            try
            {
                string text = cmsForm.richTextBoxCms.Text;
                //if (text.Length > 0x1388)
                //{
                //    cmsForm.richTextBoxCms.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text.Substring(0, 0x7d0);
                //}
                //else
                //{
                    cmsForm.richTextBoxCms.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text;
                //}
            }
            catch
            {
                LogUtil.log_cms_call(cmsForm, content);
            }
        }

        public static void log_cms_call(CmsForm cmsForm, String content)
        {
            try
            {
                if (cmsForm.richTextBoxCms.InvokeRequired)
                {
                    log method = new log(LogUtil.log_cms_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    LogUtil.log_cms_str(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


        public static void log_qun_str(CmsForm cmsForm, String content)
        {
            try
            {
                string text = cmsForm.richTextBox_qq_log.Text;
                if (text.Length > 0x1388)
                {
                    cmsForm.richTextBox_qq_log.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text.Substring(0, 0x7d0);
                }
                else
                {
                    cmsForm.richTextBox_qq_log.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text;
                }
            }
            catch
            {
                LogUtil.log_qun_call(cmsForm, content);
            }
        }

        public static void log_qun_call(CmsForm cmsForm, String content)
        {
            try
            {
                if (cmsForm.richTextBox_qq_log.InvokeRequired)
                {
                    log method = new log(LogUtil.log_qun_call);
                    cmsForm.BeginInvoke(method, new object[] { cmsForm, content });
                }
                else
                {
                    LogUtil.log_qun_str(cmsForm, content);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("[messageForThread]出错：" + exception.ToString());
            }
        }


    }
}
