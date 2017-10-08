using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeChat.NET;

namespace WeChat.NET
{
    public class LogUtil
    {
        public static void log_str(sendMainForm cmsForm, String content)
        {
            try
            {
                string text = cmsForm.richTextBoxCms.Text;
                if (text.Length > 0x1388)
                {
                    cmsForm.richTextBoxCms.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text.Substring(0, 0x7d0);
                }
                else
                {
                    cmsForm.richTextBoxCms.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + "----" + content + "\n" + text;
                }
            }
            catch
            {
                LogUtil.log_call(cmsForm, content);
            }
        }

        public static void log_call(sendMainForm cmsForm, String content)
        {
            try
            {
                if (cmsForm.richTextBoxCms.InvokeRequired)
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
        public static string GetMD5HashFromFile(string fileName)
         {
             try
             {
                 FileStream file = new FileStream(fileName, FileMode.Open);
                 System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                 byte[] retVal = md5.ComputeHash(file);
                 file.Close();
 
                StringBuilder sb = new StringBuilder();
                 for (int i = 0; i < retVal.Length; i++)
                 {
                     sb.Append(retVal[i].ToString("x2"));
                 }
                 return sb.ToString();
             }
             catch (Exception ex)
             {
                 throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
             }
         }

        public static long FileSize(string filePath)
        {
            long temp = 0;

            //判断当前路径所指向的是否为文件
            if (File.Exists(filePath) == false)
            {
                string[] str1 = Directory.GetFileSystemEntries(filePath);
                foreach (string s1 in str1)
                {
                    temp += FileSize(s1);
                }
            }
            else
            {

                //定义一个FileInfo对象,使之与filePath所指向的文件向关联,

                //以获取其大小
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            return temp;
        }

    }
}
