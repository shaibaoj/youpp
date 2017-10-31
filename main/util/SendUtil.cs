using com.haopintui;
using haopintui.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

namespace haopintui.util
{
    public class SendUtil
    {
        public static string zhuan_pid(CmsForm cmsForm,string content)
	    {
		    string string81;
		    ArrayList arrayLists;
		    bool flag;
		    try
		    {
			    int num = 0;
			    while (!AlimamaUtil.check_login(cmsForm.appBean.taoke_cookie))
			    {
                    //if (this.bool_28)
                    //{
                    //    LogUtil.log_call(cmsForm, "阿里妈妈显示请求频繁，等待30秒再试！");
                    //    Thread.Sleep(30000);
                    //}
                    //else 
                    if (num >= 30)
				    {
					    LogUtil.log_call(cmsForm, "登录阿里妈妈失败！");
					    string81 = "notlogin";
					    return string81;
				    }
				    else
				    {
					    num++;
                        //this.method_8(true);
                        AlimamaLogin.login(cmsForm, 0);
					    Thread.Sleep(20000);
				    }
			    }
                //content = ᝛.ᜀ(content);
                //content = ᝛.ᜂ(content);
			    string str = SendUtil.method_307( cmsForm,content);
			    if (str != null)
			    {
				    content = str;
                    //this.string_80 = ᜸.ᜄ(content.Replace("<", " <").Replace(">", "> ")).Replace("&nbsp;", " ");
                    //this.string_81 = content;
                    //this.string_49 = this.string_81;
                    //this.arrayList_5 = new ArrayList();
                    //this.bool_34 = false;
                    //this.string_83 = "";
				    int num1 = 0;
				    arrayLists = null;
				    while (true)
				    {
                        //ArrayList arrayLists1 = this.method_324(this.string_80);
                        //arrayLists = arrayLists1;
                        //if (arrayLists1 != null)
                        //{
                        //    goto Label1;
                        //}
                        //if (num1 >= 3)
                        //{
                        //    break;
                        //}
                        //LogUtil.log_call(cmsForm, string.Concat("PID转换第【", num1 + 1, "】次失败，正在重试！"));
                        //Thread.Sleep(1000);
                        num1++;
				    }
				    LogUtil.log_call(cmsForm, "PID转换失败【3】次，跳过！");
				    string81 = null;
			    }
			    else
			    {
				    string81 = null;
			    }
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm, string.Concat("[changeFollowSndPid]出错：", exception.ToString()));
			    string81 = null;
		    }
		    return string81;
        Label1:
            //flag = (this.float_1 <= this.float_4 ? true : "".Equals(this.string_70));
            //if (flag)
            //{
            //    this.int_26 = this.method_325(arrayLists);
            //    this.string_81 = this.string_81.Replace("￥", "$");
            //    GClass30 gClass30 = null;
            //    this.bool_5 = false;
            //    if ((this.bool_3 ? false : !this.bool_6))
            //    {
            //        this.string_81 = this.method_317(arrayLists);
            //    }
            //    else
            //    {
            //        gClass30 = this.method_140(this.string_81);
            //        if (this.bool_6)
            //        {
            //            this.method_311(gClass30, arrayLists, this.int_26);
            //        }
            //        else if (!this.bool_5)
            //        {
            //            this.string_81 = this.method_317(arrayLists);
            //        }
            //        else
            //        {
            //            this.string_81 = gClass30.string_1.Replace("{couponItemUrl}", string.Concat("【领券下单地址】", this.method_315(gClass30)));
            //            if ((this.bool_32 || !this.bool_4 ? false : this.int_26 == 4))
            //            {
            //                this.string_81 = string.Concat(this.string_81, "<BR>复制这条消息，", gClass30.᜞_0.ᜀ, "，打开【手机淘宝】即可领券并下单");
            //            }
            //        }
            //    }
            //    string81 = this.string_81;
            //    return string81;
            //}
            //else
            //{
            //    string81 = "lowestcms";
            //    return string81;
            //}
            return "";
	    }

        public static string method_307(CmsForm cmsForm,string content)
	    {
		    string string96;
		    try
		    {
			    CouponBean couponBean = new CouponBean();
			    SendUtil.method_308(cmsForm,content, couponBean);
			    if (!"".Equals(couponBean.uland_url))
			    {
				    if (!SendUtil.method_138(cmsForm,couponBean.uland_url))
				    {
					    string str = StringUtil.subString(couponBean.uland_url, 0, "activityId=", "&");
					    string str1 = StringUtil.subString(couponBean.uland_url, 0, "itemId=", "&");
                        string out_log="";
					    ArrayList arrayLists =AlimamaUtil.smethod_17(str1, "1", out out_log);
					    if ((arrayLists == null ? false : arrayLists.Count != 0))
					    {
						    GoodsItem item = (GoodsItem)arrayLists[0];
						    string str2 = "优惠券：http://shop.m.taobao.com/shop/coupon.htm?activityId={activityId}&sellerId={sellerId}<BR>下单：http://item.taobao.com/item.htm?id={itemId}";
						    str2 = str2.Replace("{activityId}", str).Replace("{sellerId}", item.num_iid).Replace("{itemId}", str1);
						    content = couponBean.content.Replace("{couponItemUrl}", str2);
					    }
					    else
					    {
						    LogUtil.log_call(cmsForm,"2合1链接出错！");
						    string96 = null;
						    return string96;
					    }
				    }
				    else
				    {
					    string96 = content;
					    return string96;
				    }
			    }
			    string96 = content;
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm,string.Concat("[parseCouponItemContentUrl]出错：", exception.ToString()));
			    string96 = null;
		    }
		    return string96;
	    }

        public static void method_308(CmsForm cmsForm,string string_96, CouponBean couponBean)
	    {
		    try
		    {
			    string_96 = SendUtil.method_144(cmsForm,string_96);
			    string_96 = string_96.Replace("</span>", "</SPAN>").Replace("</div>", "</DIV>").Replace("<img", "<IMG").Replace("\n", "").Replace("\r", "").Replace("<br>", "\n").Replace("<BR>", "\n").Replace("<BR", "\n<BR").Replace("</DIV>", "\n").Replace("</SPAN>", "\n").Replace("</P>", "\n").Replace("</p>", "\n");
                //string_96 = ᜸.ᜄ(string_96);
			    SendUtil.method_309(cmsForm,SendUtil.method_142(string_96), couponBean, 3);
			    string_96 = SendUtil.method_143(cmsForm,string_96);
			    string_96 = string_96.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
			    string_96 = string_96.Replace("\n", "<BR>");
			    couponBean.content = string_96;
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm,string.Concat("[transCouponItemCmbToTwo]出错：", exception.ToString()));
		    }
	    }

	    public static void method_309(CmsForm cmsForm,string content, CouponBean couponBean, int int_28)
	    {
		    try
		    {
			    content = content.Replace("&nbsp;", " ").Replace("&amp;", "&");
			    foreach (Match match in (new Regex(Constants.regex_url)).Matches(content))
			    {
				    string str = match.Value.ToString();
				    if (!str.Contains("uland.taobao.com"))
				    {
					    string str1 = TaobaoUtil.get_redirect_url(str, str);
					    if (str1.Contains("uland.taobao.com"))
					    {
						    couponBean.uland_url = str1;
					    }
					    Thread.Sleep(200);
				    }
				    else
				    {
					    couponBean.uland_url = str;
				    }
			    }
		    }
		    catch (Exception exception1)
		    {
			    Exception exception = exception1;
			    if ((!exception.ToString().Contains("System.Net.WebException") ? true : int_28 >= 5))
			    {
				     LogUtil.log_call(cmsForm,string.Concat("[checkCouponAndItemCmbUrl]出错：", exception.ToString()));
			    }
			    else
			    {
				     LogUtil.log_call(cmsForm,"网络一时问题，正在重试。。。。");
				    Thread.Sleep(1200);
				    int_28++;
				    SendUtil.method_309(cmsForm,content, couponBean, int_28);
			    }
		    }
	    }

        public static string method_143(CmsForm cmsForm,string string_96)
	    {
		    string str;
		    try
		    {
			    bool flag = false;
			    StringBuilder stringBuilder = new StringBuilder();
			    string[] strArrays = string_96.Split(new char[] { '\n' });
			    for (int i = 0; i < (int)strArrays.Length; i++)
			    {
				    string str1 = strArrays[i];
				    if ((str1 == null ? false : !"".Equals(str1.Trim())))
				    {
					    if (!(str1.Contains("http://") || str1.Contains("https://") ? str1.Contains(".jpg") : true))
					    {
						    if (!flag)
						    {
							    stringBuilder.Append("{couponItemUrl}\n");
							    flag = true;
						    }
					    }
					    else if ((str1.Contains("优惠券地址") || str1.Contains("下单地址") ? false : !str1.Contains("下单链接")))
					    {
						    stringBuilder.Append(string.Concat(str1, "\n"));
					    }
				    }
			    }
			    string str2 = stringBuilder.ToString();
			    str = str2.Substring(0, str2.Length - 1);
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm,string.Concat("[removeEmptyAndHttpLineForCouponItemCmb]出错：", exception.ToString()));
			    str = null;
		    }
		    return str;
	    }

        public static string method_144(CmsForm cmsForm,string string_96)
	    {
		    string string96;
		    bool flag;
		    try
		    {
			    string_96 = string_96.Replace("<img", "<IMG").Replace("<br>", "<BR>").Replace("<div>", "<DIV>").Replace("</div>", "</DIV>");
			    int num = 0;
			    while (true)
			    {
				    int num1 = string_96.IndexOf("<IMG", num);
				    num = num1;
				    if (num1 == -1)
				    {
					    break;
				    }
				    string str = "";
				    int num2 = string_96.IndexOf("src", num);
				    int num3 = string_96.IndexOf("SRC", num);
				    int num4 = num2;
				    if (num4 == -1)
				    {
					    flag = false;
				    }
				    else
				    {
					    flag = (num4 <= num3 ? true : num3 == -1);
				    }
				    if (!flag)
				    {
					    num4 = num3;
				    }
				    int num5 = string_96.IndexOf("\"", num4) + 1;
				    string str1 = string_96.Substring(num5, string_96.IndexOf("\"", num5) - num5);
				    str = string.Concat("{image}", str1, "{/image}");
				    int num6 = string_96.IndexOf(">", num) - num;
				    string str2 = string_96.Substring(num, num6 + 1);
				    string_96 = string_96.Replace(str2, str);
			    }
			    string96 = string_96;
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm,string.Concat("[processImageTag]出错：", exception.ToString()));
			    string96 = null;
		    }
		    return string96;
	    }

        public static string method_142(string string_96)
	    {
		    string i;
		    int num = 0;
		    int num1 = 0;
		    for (i = string.Concat(string_96, ""); i.Contains("{image}"); i = i.Replace(i.Substring(num, num1), ""))
		    {
			    num = i.IndexOf("{image}");
			    num1 = i.IndexOf("{/image}") + 8 - num;
		    }
		    return i;
	    }

       public static bool method_138(CmsForm cmsForm,string content)
	    {
		    bool flag;
		    try
		    {
			    Regex regex = new Regex("mm_\\d+_\\d+_\\d+");
			    if ((content.Contains("ali_trackid") || content.Contains("pid=") ? regex.IsMatch(content) : false))
			    {
				    string value = regex.Match(content).Value;
				    if (cmsForm.appBean.alimama_login_status)
				    {
					    if (value.Equals(cmsForm.appBean.qq_com_pid))
					    {
						    flag = true;
						    return flag;
					    }
                         if (value.Equals(cmsForm.appBean.weixin_pid))
					    {
						    flag = true;
						    return flag;
					    }
				    }
                    //else if ((value.Equals(this.string_29) ? true : value.Equals(this.string_28)))
                    //{
                    //    flag = true;
                    //    return flag;
                    //}
			    }
			    flag = false;
		    }
		    catch (Exception exception)
		    {
			    LogUtil.log_call(cmsForm,string.Concat("[checkPid]出错：", exception.ToString()));
			    flag = false;
		    }
		    return flag;
	    }

       private ArrayList method_324(CmsForm cmsForm, string string_96)
       {
           ArrayList arrayLists = null;
           try
           {
               //this.string_78 = "";
               //this.string_79 = "";
               //this.float_2 = 0f;
               //this.float_3 = 0f;
               //this.float_4 = 0f;
               //this.string_75 = "";
               //this.string_76 = "";
               //this.string_77 = "";
               //ArrayList arrayLists1 = new ArrayList();
               //MatchCollection matchCollections = (new Regex(Constants.regex_url)).Matches(string_96);
               //int num = 1;
               //foreach (Match match in matchCollections)
               //{
               //    LogUtil.log_call(cmsForm, string.Concat("正在处理第【", num, "】个链接！"));
               //    UrlItem urlItem = new UrlItem()
               //    {
               //        string_1 = match.Value.ToString()
               //    };
               //    gClass25 = this.method_326(urlItem, this.radioButtonHiCms.Checked);
               //    if ((urlItem == null || urlItem.string_2 == null ? true : "".Equals(urlItem.string_2.Trim())))
               //    {
               //        if ((!this.checkBoxBatchConvert.Checked ? true : !this.bool_33))
               //        {
               //            arrayLists = null;
               //            return arrayLists;
               //        }
               //        else
               //        {
               //            urlItem = new GClass25()
               //            {
               //                string_1 = match.Value.ToString(),
               //                string_2 = string.Concat("***链接转换失败，原链接：【", urlItem.string_1, "】***")
               //            };
               //        }
               //    }
               //    arrayLists1.Add(urlItem);
               //    num++;
               //}
               //arrayLists = arrayLists1;
           }
           catch (Exception exception)
           {
               LogUtil.log_call(cmsForm, string.Concat("[parseUrl]出错！", exception.ToString()));
               arrayLists = null;
           }
           return arrayLists;
       }

        public void method_141(CmsForm cmsForm,string content)
        {
            try
            {
                //content = this.method_144(content);
                //content = content.Replace("</span>", "</SPAN>").Replace("</div>", "</DIV>").Replace("<img", "<IMG").Replace("\n", "").Replace("\r", "").Replace("<br>", "\n").Replace("<BR>", "\n").Replace("<BR", "\n<BR").Replace("</DIV>", "\n").Replace("</SPAN>", "\n").Replace("</P>", "\n").Replace("</p>", "\n");
                //content = ᜸.ᜄ(content);
                //this.method_145(this.method_142(content), gclass30_0, 3);
                //content = this.method_143(content);
                content = content.Replace("{image}", "<IMG src=\"").Replace("{/image}", "\">");
                content = content.Replace("\n", "<BR>");
                //gclass30_0.string_1 = content;
                //gclass30_0.string_0 = content.Replace("{couponItemUrl}<BR>", "").Replace("{couponItemUrl}", "");
            }
            catch (Exception exception)
            {
               LogUtil.log_call(cmsForm, string.Concat("[contentTransForCouponItemCmb]出错：", exception.ToString()));
            }
        }

    }
}
