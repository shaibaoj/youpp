using haopintui.entity;
using haopintui.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace haopintui
{
    public class QqUtil
    {
        public static void send(CmsForm cmsForm, string content, string content_org, int user_type,int goods_type)
        {
            try
            {
                int i = 0;
                //LogUtil.log_call(cmsForm, "发送的群数目：" + cmsForm.appBean.qqqun_list.Count);
                if (cmsForm.appBean.qqqun_list.Count>0)
                {
                    string out_log = "";
                    //CommonUtil.clipboard(string.Concat(content, QqUtil.weiba(cmsForm, out out_log)), out out_log);
                    //LogUtil.log_call(cmsForm, out_log);
                    QqUtil.copy_content(cmsForm, string.Concat(content, QqUtil.weiba(cmsForm, out out_log)).ToString(), out out_log);
                    //CommonUtil.clipboard_brows(cmsForm,string.Concat(content, QqUtil.weiba(cmsForm, out out_log)), out out_log);
                    //LogUtil.log_call(cmsForm, out_log);
                }
                while(i<cmsForm.appBean.qqqun_list.Count){
                    if (!cmsForm.appBean.send_status && !cmsForm.appBean.qunfa_genfa_qunfa_status)
                    {
                        LogUtil.log_call(cmsForm,"群发被强制停止");
                        return;
                    }else{

                        string weiba = "";
                        string item = (string)cmsForm.appBean.qqqun_list[i];
                        string qq_pid = PidUtil.get_qq_pid_qun(cmsForm, item, cmsForm.appBean.member_id, out weiba);
                        if (!string.IsNullOrEmpty(qq_pid))
                        {
                            string content_send = "";
                            if (goods_type != 2)
                            {
                                ContentItem contentItem_qun = UrlUtil.parseContent(cmsForm, content_org, qq_pid, cmsForm.checkBox_qunfa_pid.Checked,false,user_type);
                                content_send = contentItem_qun.content_send;
                                content_send = UrlUtil.template_qq(cmsForm, contentItem_qun, qq_pid, cmsForm.checkBox_qunfa_pid.Checked, cmsForm.appBean.qq_template);

                            }
                            else {
                                ContentItem contentItem_qun = UrlHptUtil.parseContent(cmsForm, content_org, qq_pid, cmsForm.checkBox_qunfa_pid.Checked, false, user_type);
                                content_send = contentItem_qun.content_send;
                            }
                            string out_log = "";
                            QqUtil.copy_content(cmsForm, string.Concat(content_send, weiba).ToString(), out out_log);
                        }
                        else
                        {
                            string out_log = "";
                            QqUtil.copy_content(cmsForm, string.Concat(content, QqUtil.weiba(cmsForm, out out_log)).ToString(), out out_log);
                        }
					    IntPtr intPtr =CmsForm.FindWindow(null, item);
                        if (intPtr == IntPtr.Zero)
					    {
						    string str = string.Concat(cmsForm.appBean.qqquan_path, "\\", item, ".lnk");
						    if (!File.Exists(str))
						    {
							    goto Label1;
						    }
						    try
						    {
							    Process.Start(str);
						    }
						    catch
						    {
							   LogUtil.log_call(cmsForm,string.Concat("自动打开QQ群快捷方式有问题，请手动打开！【", str, "】"));
						    }
						    Thread.Sleep(1000);
						    intPtr = CmsForm.FindWindow(null, item);
						    if (intPtr == IntPtr.Zero)
						    {

						    }
					    }
                        StringBuilder stringBuilder = new StringBuilder(256);
					    CmsForm.GetClassName(intPtr, stringBuilder, 500);
					    if (!"ChatWnd".Equals(stringBuilder.ToString()))
					    {
						    CmsForm.SetForegroundWindow(intPtr);
                            try
                            {
                                Thread.Sleep(int.Parse(cmsForm.textBox_qunfa_qq_peizhi_zhantietimes.Text.Trim()));
                            }
                            catch (Exception)
                            {
                                Thread.Sleep(1000);
                            }
                            MouseUtil.paste();  //粘贴消息
                            try
                            {
                                Thread.Sleep(int.Parse(cmsForm.textBox_qunfa_qq_peizhi_fasong_times.Text.Trim()));
                            }
                            catch (Exception)
                            {                                
                                Thread.Sleep(1000);
                            }
                            if (cmsForm.radioButton_qunfa_qq_enter.Checked)
                            {
                                MouseUtil.enter(); // 回车
                            }
                            else
                            {
                                MouseUtil.ctrl_enter();
                                //MouseUtil.smethod_2();
                                //MouseUtil.smethod_3();
                                //MouseUtil.smethod_6(); //Ctrl+回车
                            }
                            try
                            {
                                Thread.Sleep(int.Parse(cmsForm.textBox_qunfa_qq_peizhi_qiehuan_times.Text.Trim()));
                            }
                            catch (Exception)
                            {
                                Thread.Sleep(1000);
                            }
                            if (cmsForm.checkBox_qunfa_qq_guanbi.Checked)
                            {
                                MouseUtil.close(); //关闭窗口
                                Thread.Sleep(100);
                            }
					    }
					    else
					    {
                            //this.method_149(intPtr);
					    }
                        Label1:
					    i = i + 1;
                    }
                }
            }
            catch (Exception)
            {
                 //out_log = "";
            }
        }

        public static void copy_content(CmsForm cmsForm,string content,out string out_log)
        {
            out_log = "";
            try
            {
                if (!cmsForm.InvokeRequired)
                {
                    //CommonUtil.clipboard("", out out_log);
                    int n=0;
                    bool flag = false;
                    while (n < 10 && !flag)
                    {
                        flag = CommonUtil.clipboard(content, out out_log);
                        n++;
                        if(!flag){
                            Thread.Sleep(1000);
                        }
                    }
                }
                else
                {
                    GDelegate69 gDelegate69 = new GDelegate69(QqUtil.copy_content);
                    object[] string96 = new object[] { cmsForm,content,out_log };
                    cmsForm.Invoke(gDelegate69, string96);
                    //cmsForm.BeginInvoke(gDelegate69, string96);
                }
            }
            catch (Exception exception)
            {
               out_log = string.Concat("[CopySndContent]出错：", exception.ToString());
            }
        }


        public static string weiba(CmsForm cmsForm,out string out_log)
	    {
            out_log="";
		    DateTime now;
		    string str;
		    try
		    {
			    string str1 = "";
			    if (!string.IsNullOrEmpty(cmsForm.textBox_qunfa_wieba_content.Text))
			    {
				    str1 = string.Concat("\n<BR><P>",cmsForm.textBox_qunfa_wieba_content.Text.Trim(), "</P>");
			    }
			    if (cmsForm.checkBox_qunfa_qq_str_times.Checked)
			    {
				    if (!str1.Equals(""))
				    {
					    now = DateTime.Now;
					    str1 = string.Concat(str1, "\n<BR><P>", now.ToString("yyyy年MM月dd日 HH:mm:ss"), "</P>");
				    }
				    else
				    {
					    now = DateTime.Now;
					    str1 = string.Concat("\n<BR><P>", now.ToString("yyyy年MM月dd日 HH:mm:ss"), "</P>");
				    }
			    }
			    if (cmsForm.checkBox_qunfa_qq_str_suiji.Checked)
			    {
				    str1 = (!str1.Equals("") ? string.Concat(str1, "\t<P>", GzipUtil.randStr(10), "</P>") : string.Concat("\n<BR><P>", GzipUtil.randStr(10), "</P>"));
			    }
			    str = str1;
		    }
		    catch (Exception exception)
		    {
			    out_log = string.Concat("[getRdmContent]出错：", exception.ToString());
			    str = "";
		    }
		    return str;
	    }

        public static void method_167(CmsForm cmsForm,out string out_log)
	    {
            out_log = "";
		    try
		    {
			    if (!cmsForm.InvokeRequired)
			    {
				    cmsForm.Visible = true;
				    cmsForm.WindowState = FormWindowState.Normal;
				    Thread.Sleep(100);
				    cmsForm.Activate();
				    Thread.Sleep(100);
				    cmsForm.tabControlMain.SelectedIndex = 1;
				    Thread.Sleep(100);
			    }
			    else
			    {
				    GDelegate74 gDelegate74 = new GDelegate74(QqUtil.method_167);
				    cmsForm.BeginInvoke(gDelegate74, new object[]{cmsForm,out_log});
			    }
		    }
		    catch (Exception exception)
		    {
			    out_log = string.Concat("[WindowNomal]出错：", exception.ToString());
		    }
	    }

	    public static void method_168(CmsForm cmsForm,out string out_log)
	    {
            out_log = "";
		    try
		    {
			    if (!cmsForm.InvokeRequired)
			    {
				    cmsForm.Visible = true;
				    cmsForm.WindowState = FormWindowState.Minimized;
			    }
			    else
			    {
				    GDelegate75 gDelegate75 = new GDelegate75(QqUtil.method_168);
				    cmsForm.BeginInvoke(gDelegate75, new object[]{cmsForm,out_log});
			    }
		    }
		    catch (Exception exception)
		    {
			    out_log = string.Concat("[WindowMin]出错：", exception.ToString());
		    }
	    }

         public static void method_156(CmsForm cmsForm)
        {
            try
            {
                //if (this.int_14 <= 0)
                //{
                //    this.int_14 = 300;
                //}
                //this.bool_12 = this.checkBoxFollowSend.Checked;
                //this.bool_13 = this.checkBoxUpHotShare.Checked;
                //this.bool_19 = true;
                //this.thread_1 = new Thread(new ThreadStart(this.method_157));
                //this.thread_1.SetApartmentState(ApartmentState.MTA);
                //this.thread_1.Start();
                //this.method_154(1, false);
                //this.method_154(2, true);
                //this.buttonLoadQQGrpList.Focus();
                //this.method_121();
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[startTask]出错：" + exception.ToString());
            }
        }

       

         	public void method_134()
	        {
                //this.method_154(1, true, "发送");
                //this.method_154(2, false, "");
                //this.method_154(3, false, "");
	        }


        public static void method_154(int int_28, bool bool_40, string string_96)
	    {
            //AliBridgeForm.GDelegate68 gDelegate68;
            //object[] int28;
            //try
            //{
            //    if (int_28 == 1)
            //    {
            //        if (!this.buttonSend.InvokeRequired)
            //        {
            //            this.buttonSend.Enabled = bool_40;
            //            this.buttonSend.Text = string_96;
            //        }
            //        else
            //        {
            //            gDelegate68 = new AliBridgeForm.GDelegate68(this.method_154);
            //            int28 = new object[] { int_28, bool_40, string_96 };
            //            base.BeginInvoke(gDelegate68, int28);
            //            return;
            //        }
            //    }
            //    else if (int_28 == 2)
            //    {
            //        if (!this.buttonPause.InvokeRequired)
            //        {
            //            this.buttonPause.Enabled = bool_40;
            //        }
            //        else
            //        {
            //            gDelegate68 = new AliBridgeForm.GDelegate68(this.method_154);
            //            int28 = new object[] { int_28, bool_40, string_96 };
            //            base.BeginInvoke(gDelegate68, int28);
            //            return;
            //        }
            //    }
            //    else if (int_28 == 3)
            //    {
            //        if (!this.buttonStop.InvokeRequired)
            //        {
            //            this.buttonStop.Enabled = bool_40;
            //        }
            //        else
            //        {
            //            gDelegate68 = new GDelegate68(this.method_154);
            //            int28 = new object[] { int_28, bool_40, string_96 };
            //            base.BeginInvoke(gDelegate68, int28);
            //            return;
            //        }
            //    }
            //}
            //catch (Exception exception)
            //{
            //    this.method_115(string.Concat("[BtnGrpSnd]出错：", exception.ToString()));
            //}
	    }

        public int method_252(CmsForm cmsForm,SendItem sendItem)
	    {
		    int num;
		    if (!cmsForm.checkBox_qunfa_pid.Checked)
		    {
			    cmsForm.appBean.send_content = sendItem.content;
		    }
		    else
		    {
                //this.string_70 = "";
                //cmsForm.appBean.send_content = this.method_257(sendItem.content);
                //if (cmsForm.appBean.send_content == null)
                //{
                //    this.remove_send(sendItem.num_iid);
                //    //᝚.ᜁ(string.Concat(this.string_68, "\\", gclass23_0.string_0, "\\2.txt"), "");
                //    num = 0;
                //    return num;
                //}
                //else if ("notlogin".Equals(this.appBean.send_content))
                //{
                //    this.method_260(1, true);
                //    this.method_260(2, false);
                //    num = -1;
                //    return num;
                //}
                //else if (!"lowestcms".Equals(this.appBean.send_content))
                //{
                //    if (!this.method_253(this.string_70))
                //    {
                //        num = 2;
                //        return num;
                //    }
                //    if (!"".Equals(this.string_70))
                //    {
                //        this.method_254(this.string_70);
                //    }
                //}
                //else
                //{
                //    num = 3;
                //    return num;
                //}
		    }
            //this.bool_34 = this.method_135(᜸.ᜄ(sendItem.string_1.Replace("<", " <").Replace(">", "> ")).Replace("&nbsp;", " "));
            //if (this.bool_34)
            //{
            //    try
            //    {
            //        ᝕ _u1755 = ᜤ.ᜅ(this.string_83);
            //        this.float_3 = (float)_u1755.ᜀ;
            //        if (_u1755.ᜁ >= this.int_22)
            //        {
            //            LogUtil.log_str(this, string.Concat("优惠券数量提醒！******", _u1755.ᜄ(), "******"));
            //        }
            //        else
            //        {
            //            LogUtil.log_str(this, string.Concat("优惠券数量不够，跳过发送！******", _u1755.ᜄ(), "******"));
            //            //᝚.ᜁ(string.Concat(this.string_68, "\\", sendItem.string_0, "\\2.txt"), "");
            //            this.remove_send(sendItem.num_iid);
            //            num = 1;
            //            return num;
            //        }
            //    }
            //    catch
            //    {
            //        this.method_115("没有查出来优惠券数量，但是继续发送！");
            //    }
            //}
            //this.int_11 = 0;
            //this.bool_20 = false;
            //if (!this.bool_32)
            //{
            //    this.method_148();
            //}
            //else
            //{
            //    this.method_150();
            //}
            ////᝚.ᜁ(string.Concat(this.string_68, "\\", gclass23_0.string_0, "\\1.txt"), "");
            //this.remove_send(sendItem.num_iid);
		    num = 0;
		    return num;
	    }

    }
}
