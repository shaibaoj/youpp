using com.haopintui;
using haopintui.entity;
using haopintui.util;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace haopintui
{
   public class WeixinUtil
    {
       public static void send(CmsForm cmsForm, string content, string content_img, ArrayList imgList, CouponContent couponContent, int url_type, int goods_type)
       {
            string out_log = "";
            GStruct0 gStruct0;
                try
                {
                    if (cmsForm.radioButton_fasong_weixin_fashi_houtai.Checked)
                    {
                        WeixinUtil.login(cmsForm);
                        WeixinUtil.send_houtai(cmsForm, content, content_img, imgList);
                        return;
                    }

                    if (cmsForm.appBean.weixin_list == null || cmsForm.appBean.weixin_list.Count==0)
                    {
                        LogUtil.log_call(cmsForm, "没有微信群！");
                        return;
                    }
                    //this.string_50 = this.method_151(cmsForm);
                    //᝚.ᜃ(this.string_50);
                    //ContentItem contentItem = WeixinUtil.get_weixin_content(cmsForm,content,out out_log);
                    //LogUtil.log_call(cmsForm, gClass27.content);
                    int i=0;
                    while (i < cmsForm.appBean.weixin_list.Count)
                    {
                        if (!cmsForm.appBean.send_status && !cmsForm.appBean.qunfa_genfa_qunfa_status)
                        {
                            out_log = "群发被强制停止";
                            return;
                        }
                        else
                        {
                            string item = (string)cmsForm.appBean.weixin_list[i];

                            string weiba_all = QqUtil.weiba(cmsForm, out out_log);
                            string weiba = "";
                            string weixin_pid = PidUtil.get_weixin_pid_qun(cmsForm, item, cmsForm.appBean.member_id, out weiba);
                            if (!string.IsNullOrEmpty(weixin_pid))
                            {
                                //if (goods_type != 2)
                                //{
                                //    ContentItem contentItem_qun = UrlUtil.parseContent(cmsForm, content_org, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, false, url_type);
                                //    UrlUtil.parseContent_weixin(cmsForm, contentItem_qun, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked);
                                //    UrlUtil.template_qq(cmsForm, contentItem_qun, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.weixin_template);

                                //    content = contentItem_qun.content_weixin;
                                //    content_img = contentItem_qun.content_weixin_img;
                                //    imgList = contentItem_qun.imgList;
                                //    weiba_all = weiba;
                                //}
                                //else {
                                //    ContentItem contentItem_qun = UrlHptUtil.parseContent(cmsForm, content_org, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, false, url_type);
                                //    UrlUtil.parseContent_weixin(cmsForm, contentItem_qun, weixin_pid, false);

                                //    content = contentItem_qun.content_send;
                                //    content = WeixinUtil.remove_img(content);

                                //    LogUtil.log_call(cmsForm, content);
                                //    content_img = contentItem_qun.content_weixin_img;
                                //    imgList = contentItem_qun.imgList;
                                //    weiba_all = weiba;
                                //}

                                //ContentItem contentItem_qun = UrlUtil.parseContent(cmsForm, content_org, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, false, url_type);
                                //UrlUtil.parseContent_weixin(cmsForm, contentItem_qun, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked);
                                //UrlUtil.template_qq(cmsForm, contentItem_qun, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.weixin_template);

                                LogUtil.log_call(cmsForm, "分群pid转化链接,pid:" + weixin_pid);

                                CouponContentSend couponContentSend = UrlUtil.template_qq(cmsForm, couponContent, weixin_pid, cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.weixin_template);

                                content = couponContentSend.content_weixin;
                                content_img = couponContentSend.content_weixin_img;
                                imgList = couponContentSend.imgList;
                                weiba_all = weiba;

                            }
                            else {
                                if (goods_type != 2)
                                {

                                }
                                else {                                 
                                    content = WeixinUtil.remove_img(content);
                                }
                            }

                            IntPtr intPtr = CmsForm.FindWindow(null, item);
                            if (intPtr == IntPtr.Zero)
                            {
                                out_log = string.Concat("微信群【", item, "】窗口没有打开，软件自动拖动微信群成为独立的窗口！");
                                CmsForm.EnumWindows(new GDelegate66(cmsForm.method_121), IntPtr.Zero);
                                if (!WeixinUtil.method_120(cmsForm.appBean.weixin_win_id))
                                {
                                    LogUtil.log_call(cmsForm, "微信没有打开！");
                                    goto Label2;
                                }
                                LogUtil.log_call(cmsForm, "微信已经打开！正在拖动。。。。");
                                CmsForm.ShowWindowAsync(cmsForm.appBean.weixin_win_id, GClass13.int_13);
                                Thread.Sleep(150);
                                CmsForm.SetForegroundWindow(cmsForm.appBean.weixin_win_id);
                                Thread.Sleep(150);
                                CmsForm.GetWindowRect(cmsForm.appBean.weixin_win_id, out gStruct0);
                                MouseUtil.smethod_9(cmsForm.appBean.weixin_win_id, gStruct0.int_0 + 100, gStruct0.int_1 + 25);
                                Thread.Sleep(200);
                                SendKeys.SendWait("{BACKSPACE}");
                                Thread.Sleep(200);
                                SendKeys.SendWait(item);
                                Thread.Sleep(200);
                                SendKeys.SendWait("{ENTER}");
                                Thread.Sleep(250);
                                MouseUtil.smethod_13(gStruct0.int_0 + 100, gStruct0.int_1 + 75, gStruct0.int_0 + 400);
                                Thread.Sleep(150);
                            }
                            intPtr = CmsForm.FindWindow(null, item);
                            if (intPtr != IntPtr.Zero)
                            {
                                CmsForm.ShowWindowAsync(intPtr, GClass13.int_13);
                                Thread.Sleep(150);
                                CmsForm.SetForegroundWindow(intPtr);
                                Thread.Sleep(150);
                                CmsForm.GetWindowRect(intPtr, out gStruct0);
                                MouseUtil.smethod_9(intPtr, gStruct0.int_2 - 60, gStruct0.int_3 - 70);
                                if (content_img != null && !"".Equals(content_img))
                                {
                                    //LogUtil.log_call(cmsForm, content_img);

                                    //CommonUtil.clipboard(content_img, out out_log);
                                    QqUtil.copy_content(cmsForm, content_img, out out_log);
                                    Thread.Sleep(1000);
                                    MouseUtil.paste();  //粘贴消息
                                    Thread.Sleep(1000);
                                    MouseUtil.enter(); // 回车
                                    Thread.Sleep(1000);
                                    LogUtil.log_call(cmsForm, "发送图片结束");
                                    try
                                    {
                                    Thread.Sleep(int.Parse(cmsForm.textBox_qunfa_weixin_fatu_times.Text.Trim()));
                                    }
                                    catch (Exception)
                                    {
                                        Thread.Sleep(1000);
                                    }
                                }
                                if ((content != null&&!content.Equals("")))
                                {
                                    //CommonUtil.clipboard(string.Concat(content, QqUtil.weiba(cmsForm, out out_log)), out out_log);
                                    QqUtil.copy_content(cmsForm, string.Concat(content, weiba_all), out out_log);
                                    Thread.Sleep(1000);
                                    MouseUtil.paste();  //粘贴消息
                                    Thread.Sleep(1000);
                                    MouseUtil.enter(); // 回车
                                    Thread.Sleep(1000);
                                }
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                LogUtil.log_call(cmsForm, string.Concat("微信群【", item, "】窗口没有打开，软件拖动失败，跳过跟发！"));
                            }
                        Label2:
                            i = i+1;
                        }
                    }
                    //this.bool_34 = false;
                    //this.string_76 = "";
                    //this.int_26 = 0;
                    if (!cmsForm.checkBox_qunfa_qq_zuixiaohua.Checked)
                    {
                        QqUtil.method_167(cmsForm, out out_log);
                    }
                    else
                    {
                        QqUtil.method_168(cmsForm, out out_log);
                    }
                    //QqUtil.method_156(cmsForm);
                    //QqUtil.method_134(cmsForm);
                    LogUtil.log_call(cmsForm, "微信群发完成！");
                }
                catch (Exception exception)
                {
                    LogUtil.log_call(cmsForm,string.Concat("[autoSendWeixin]出错：", exception.ToString()));
                }
                return;
        }

       	public static string method_151(CmsForm cmsForm)
	    {
		    string str = string.Concat(cmsForm.app_path, "\\qianyuweixinimg");
            cmsForm.appBean.qqquan_path = str;
		    if (!File.Exists(str))
		    {
			    Directory.CreateDirectory(str);
		    }
		    return str;
	    }

        public static ContentWeixin get_weixin_content(CmsForm cmsForm, string content, out string out_log)
	    {
           out_log = "";
		    DateTime now;
		    string str;
		    bool i;
		    object[] string50;
		    string str1;
		    int num;
		    int num1;
		    string str2;
		    string str3;
		    int num2;
		    string str4;
		    bool flag;
		    string content_img = "";
            ArrayList imgList = new ArrayList();
		    try
		    {
			    content = content.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
			    int num3 = 0;
			    while (true)
			    {
				    int num4 = content.IndexOf("<IMG", num3);
				    num3 = num4;
				    if (num4 == -1)
				    {
					    break;
				    }
				    int num5 = content.IndexOf("src", num3);
				    int num6 = content.IndexOf("SRC", num3);
				    int num7 = num5;
				    if (num7 == -1)
				    {
					    flag = false;
				    }
				    else
				    {
					    flag = (num7 <= num6 ? true : num6 == -1);
				    }
				    if (!flag)
				    {
					    num7 = num6;
				    }
				    int num8 = content.IndexOf("\"", num7) + 1;
				    string str6 = content.Substring(num8, content.IndexOf("\"", num8) - num8);
				    if (str6.StartsWith("file:///"))
				    {
					    string str7 = HttpUtility.UrlDecode(str6.Replace("file:///", "").Replace("/", "\\")).Replace("%20", " ");
					    string string501 = cmsForm.appBean.weixin_path_img;
                        if (!Directory.Exists(string501))
                        {
                            Directory.CreateDirectory(string501);
                        }
					    now = DateTime.Now;
					    str = string.Concat(string501, "\\", now.ToString("yyyyMMddHHmmssfff"), str7.Substring(str7.LastIndexOf(".")));
					    for (i = File.Exists(str); i; i = File.Exists(str))
					    {
						    string50 = new object[] { cmsForm.appBean.weixin_path_img, "\\", null, null, null };
						    now = DateTime.Now;
						    string50[2] = now.ToString("yyyyMMddHHmmss");
						    now = DateTime.Now;
						    string50[3] = int.Parse(now.ToString("fff")) + 1;
						    string50[4] = str7.Substring(str7.LastIndexOf("."));
						    str = string.Concat(string50);
					    }
					    try
					    {
						    File.Copy(str7, str);
						    str1 = string.Concat("file:///", str.Replace(" ", "%20").Replace("{", "%7B").Replace("}", "%7D").Replace("%", "%25").Replace("\\", "/"));
						    content_img = string.Concat(content_img, "<IMG src=\"", str1, "\">");
                            imgList.Add(str1);
						    num = content.IndexOf(">", num3);
						    num1 = content.IndexOf("<BR>", num + 1);
						    if (num1 != -1 && "".Equals(content.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
						    {
							    str2 = content.Substring(0, num + 1);
							    str3 = content.Substring(num1 + 4, content.Length - num1 - 4);
							    content = string.Concat(str2, str3);
						    }
						    num2 = num - num3;
						    str4 = content.Substring(num3, num2 + 1);
						    content = content.Replace(str4, "");
					    }
					    catch
					    {
						    num3++;
					    }
				    }
				    else if ((str6.StartsWith("http://") ? true : str6.StartsWith("https://")))
				    {
					    string string502 = cmsForm.appBean.weixin_path_img;
                        if (!Directory.Exists(string502))
                        {
                            Directory.CreateDirectory(string502);
                        }
					    now = DateTime.Now;
					    str = string.Concat(string502, "\\", now.ToString("yyyyMMddHHmmssfff"), ".jpg");
					    for (i = File.Exists(str); i; i = File.Exists(str))
					    {
						    string50 = new object[] { cmsForm.appBean.weixin_path_img, "\\", null, null, null };
						    now = DateTime.Now;
						    string50[2] = now.ToString("yyyyMMddHHmmss");
						    now = DateTime.Now;
						    string50[3] = int.Parse(now.ToString("fff")) + 1;
						    string50[4] = ".jpg";
						    str = string.Concat(string50);
					    }
					    (new WebClient()).DownloadFile(str6, str);
					    str1 = string.Concat("file:///", str.Replace(" ", "%20").Replace("{", "%7B").Replace("}", "%7D").Replace("%", "%25").Replace("\\", "/"));
					    content_img = string.Concat(content_img, "<IMG src=\"", str1, "\">");
                        imgList.Add(str1);
					    num = content.IndexOf(">", num3);
					    num1 = content.IndexOf("<BR>", num + 1);
					    if (num1 != -1 && "".Equals(content.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
					    {
						    str2 = content.Substring(0, num + 1);
						    str3 = content.Substring(num1 + 4, content.Length - num1 - 4);
						    content = string.Concat(str2, str3);
					    }
					    num2 = num - num3;
					    str4 = content.Substring(num3, num2 + 1);
					    content = content.Replace(str4, "");
				    }
			    }
		    }
		    catch (Exception exception)
		    {
			    out_log = string.Concat("[getWxSendContent]出错：", exception.ToString());
		    }
		    return new ContentWeixin()
		    {
			    content_weixin_img = content_img,
                content_weixin = content,
                imgList = imgList
		    };
	    }

       	public static bool method_120(IntPtr intptr_0)
	    {
		    bool flag;
		    int num = 0;
		    while (true)
		    {
			    if (intptr_0 != IntPtr.Zero)
			    {
				    flag = true;
				    break;
			    }
			    else
			    {
				    Thread.Sleep(100);
				    if (num > 50)
				    {
					    flag = false;
					    break;
				    }
				    else
				    {
					    num++;
				    }
			    }
		    }
		    return flag;
	    }

       const int WM_COPYDATA = 0x004A;

        //private struct COPYDATASTRUCT
        //{
        //    public IntPtr dwData;
        //    public int cbData;
        //    [MarshalAs(UnmanagedType.LPStr)]
        //    public string lpData;
        //}
 
       public static void sendForm(CmsForm cmsForm,string content){

            //发送内容Content
           string windowsName = "好品推微信群发";
           IntPtr handle = CmsForm.FindWindow(null, windowsName);
 
            if (handle != IntPtr.Zero)
            {
                byte[] s = Encoding.Default.GetBytes(content);
                int len = s.Length;
                haopintui.CmsForm.COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = content;
                cds.cbData = len + 1;
                CmsForm.SendMessage(handle, WM_COPYDATA, 0, ref cds);
                //CmsForm.PostMessage(handle, WM_COPYDATA, 0, ref cds);
            }
       
       }

       public static void login(CmsForm cmsForm)
       {
           try
           {
               if (Process.GetProcessesByName(Constants.weixin_login_exe_name).Length <= 0)
               {
                   LogUtil.log_call(cmsForm, "微信助手登陆。。。。请稍候！");

                   //FormUtil.set_formWindowState(cmsForm, FormWindowState.Minimized);
                   //LogUtil.log_call(cmsForm, "正在打开登录窗口。。。。");
                   //string str2 = " 0";
                   //if (!(cmsForm.appBean.uu_username.Equals("") || cmsForm.appBean.uu_pwd.Equals("")))
                   //{
                   //    str2 = " 1 " + cmsForm.appBean.uu_username + " " + cmsForm.appBean.uu_pwd;
                   //}
                   //string arguments = "\"" + cmsForm.Text + "\" " + str + " " + alimama_acc + " " + alimama_pwd + " " + str2;
                   string arguments = "";
                   try
                   {
                       Process.Start(cmsForm.app_path + @"\" + Constants.weixin_login_exe_name, arguments);
                   }
                   catch
                   {
                   }
               }
           }
           catch (Exception exception)
           {
               LogUtil.log_call(cmsForm, "[openWeixinForm]出错，" + exception.ToString());
           }
       }

       public static void send_houtai(CmsForm cmsForm, string content, string content_img,ArrayList imgList) {
           LogUtil.log_call(cmsForm, "开始微信后台发送商品！");

           content = content.Replace( "<BR>","\n");

           int count = 0;
           if(imgList!=null&&imgList.Count>0){
               count = imgList.Count;
           }

           JsonData jd = new JsonData();
           jd["content"] = content;
           jd["imgs"] = new JsonData();//**新添加一层关系时，需要再次 new** JsonData（）
           jd["imgs"]["count"] = "" + count;
           if (imgList != null && imgList.Count > 0)
           {
               jd["imgs"]["items"] = new JsonData();
               foreach (string key in imgList)
               {                   
                   JsonData jd_item = new JsonData();
                   jd_item["url"] = key;
                   jd["imgs"]["items"].Add(jd_item);
               }
           }
           string content_json = JsonMapper.ToJson(jd);

           //LogUtil.log_call(cmsForm, "content_json:" + content_json);

           WeixinUtil.sendForm(cmsForm, content_json);

       }


       public static string remove_img(string content)
       {
           string str;
           string str1;
           int num;
           int num1;
           string str2;
           string str3;
           int num2;
           string str4;
           bool flag;
           try
           {
               content = content.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
               int num3 = 0;
               while (true)
               {
                   int num4 = content.IndexOf("<IMG", num3);
                   num3 = num4;
                   if (num4 == -1)
                   {
                       break;
                   }
                   int num5 = content.IndexOf("src", num3);
                   int num6 = content.IndexOf("SRC", num3);
                   int num7 = num5;
                   if (num7 == -1)
                   {
                       flag = false;
                   }
                   else
                   {
                       flag = (num7 <= num6 ? true : num6 == -1);
                   }
                   if (!flag)
                   {
                       num7 = num6;
                   }
                   int num8 = content.IndexOf("\"", num7) + 1;
                   string str6 = content.Substring(num8, content.IndexOf("\"", num8) - num8);
                   if (str6.StartsWith("file:///"))
                   {
                       try
                       {
                           num = content.IndexOf(">", num3);
                           num1 = content.IndexOf("<BR>", num + 1);
                           if (num1 != -1 && "".Equals(content.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
                           {
                               str2 = content.Substring(0, num + 1);
                               str3 = content.Substring(num1 + 4, content.Length - num1 - 4);
                               content = string.Concat(str2, str3);
                           }
                           num2 = num - num3;
                           str4 = content.Substring(num3, num2 + 1);
                           content = content.Replace(str4, "");
                       }
                       catch
                       {
                           num3++;
                       }
                   }
                   else if ((str6.StartsWith("http://") ? true : str6.StartsWith("https://")))
                   {
                       num = content.IndexOf(">", num3);
                       num1 = content.IndexOf("<BR>", num + 1);
                       if (num1 != -1 && "".Equals(content.Substring(num + 1, num1 - num - 1).Replace(" ", "").Replace("&nbsp;", "").Replace("\r", "").Replace("\n", "")))
                       {
                           str2 = content.Substring(0, num + 1);
                           str3 = content.Substring(num1 + 4, content.Length - num1 - 4);
                           content = string.Concat(str2, str3);
                       }
                       num2 = num - num3;
                       str4 = content.Substring(num3, num2 + 1);
                       content = content.Replace(str4, "");
                   }
               }
           }
           catch (Exception exception)
           {
           }
           return content;
       }


    }
}
