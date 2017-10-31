using com.haopintui;
using haopintui;
using mshtml;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;

public class CommonUtil
{

    public static int int_0 = 0;
    public static int int_1 = 1;
    public static int int_10 = 8;
    public static int int_11 = 9;
    public static int int_2 = 1;
    public static int int_3 = 2;
    public static int int_4 = 3;
    public static int int_5 = 4;
    public static int int_6 = 5;
    public static int int_7 = 5;
    public static int int_8 = 6;
    public static int int_9 = 7;
    public static string string_0 = Application.StartupPath;
    public static string string_1 = "taobaoqing";
    public static string string_2 = "taobaoqiang";
    public static string string_3 = "http://s.click.taobao.com/";
    public static string string_4 = "http://img.alicdn.com/tfscom/";
    public static string string_5 = "Version:1.0\r\nStartHTML:000000174\r\nEndHTML:{endhtml}\r\nStartFragment:000000285\r\nEndFragment:{endfregement}\r\nStartSelection:000000285\r\nEndSelection:{endfregement}\r\nSourceURL:about:blank\r\n<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN\">\r\n<HTML><HEAD></HEAD>\r\n<BODY><!--StartFragment-->{content}<!--EndFragment--></BODY></HTML>";
    public static string string_6 = "Version:1.0\r\nStartHTML:000000174\r\nEndHTML:{endhtml}\r\nStartFragment:000000290\r\nEndFragment:{endfregement}\r\nStartSelection:000000290\r\nEndSelection:{endfregement}\r\nSourceURL:about:blank\r\n<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.0 Transitional//EN\">\r\n\r\n<HTML><HEAD></HEAD>\r\n\r\n<BODY><!--StartFragment-->{content}<!--EndFragment--></BODY>\r\n</HTML>\r\n";
    public static string string_7 = "【抢券淘口令】#优惠券面额#元优惠券 #淘口令#\n复制这条消息，打开【手机淘宝】即可领取。";
    public static string string_8 = "【下单淘口令】#淘口令#\n复制这条消息，打开【手机淘宝】即可购买。";
    public static string string_9 = "领#优惠券面额#元券下单地址：#手淘短网址#\n复制这条信息，#淘口令# ，打开【手机淘宝】即可领券并下单";

    public static string remove_ali_trackid(string string_7)
    {
        if (string_7.Contains("ali_trackid="))
        {
            string oldValue = "&ali_trackid=" + StringUtil.subString(string_7, 0, "&ali_trackid=", "&");
            return string_7.Replace(oldValue, "");
        }
        return string_7;
    }

    public static string remove_pid(string string_7)
    {
        if (string_7.Contains("pid="))
        {
            string oldValue = "&pid=" +StringUtil.subString(string_7, 0, "&pid=", "&");
            return string_7.Replace(oldValue, "");
        }
        return string_7;
    }

    public static string smethod_10(int int_12)
    {
        string str = int_12 + "";
        while (str.Length < 9)
        {
            str = "0" + str;
        }
        return str;
    }

    public static string smethod_11(string string_7)
    {
        if ("1".Equals(string_7))
        {
            return "通用计划";
        }
        if ("2".Equals(string_7))
        {
            return "定向计划";
        }
        if ("3".Equals(string_7))
        {
            return "隐藏计划";
        }
        return "未知";
    }

    public static string smethod_12(string string_7)
    {
        if ("1".Equals(string_7))
        {
            return "否";
        }
        if ("3".Equals(string_7))
        {
            return "是";
        }
        return "-";
    }

    public static string smethod_13(string string_7)
    {
        if ("".Equals(string_7) || (string_7 == null))
        {
            return "未申请";
        }
        if ("1".Equals(string_7))
        {
            return "审核中";
        }
        if ("2".Equals(string_7))
        {
            return "已通过";
        }
        if ("3".Equals(string_7))
        {
            return "拒绝";
        }
        if ("4".Equals(string_7))
        {
            return "删除";
        }
        if ("5".Equals(string_7))
        {
            return "主动退出";
        }
        return "-";
    }

    public static Color smethod_14(string string_7)
    {
        if ("1".Equals(string_7))
        {
            return Color.Coral;
        }
        if ("2".Equals(string_7))
        {
            return Color.Green;
        }
        if ("3".Equals(string_7))
        {
            return Color.Red;
        }
        return Color.Black;
    }

    public static string smethod_15(string string_7)
    {
        if ("0".Equals(string_7))
        {
            return "未发送";
        }
        if ("1".Equals(string_7))
        {
            return "已发送";
        }
        if ("2".Equals(string_7))
        {
            return "已删除";
        }
        return "-";
    }

    public static Color smethod_16(string string_7)
    {
        if ("0".Equals(string_7))
        {
            return Color.Green;
        }
        if ("1".Equals(string_7))
        {
            return Color.Red;
        }
        if ("2".Equals(string_7))
        {
            return Color.Gray;
        }
        return Color.Black;
    }

    public static string smethod_17(int int_12)
    {
        if (int_12 == 0)
        {
            return "未";
        }
        if (int_12 == 1)
        {
            return "已";
        }
        return "不";
    }

    public static int smethod_18(string string_7)
    {
        if (string_7.Equals("未返现"))
        {
            return 0;
        }
        if (string_7.Equals("已返现"))
        {
            return 1;
        }
        return -1;
    }

    public static bool smethod_19(string string_7, out string string_8)
    {
        try
        {
            if (string_7.Contains("<IMG"))
            {
                Clipboard.Clear();
                int length = Encoding.UTF8.GetBytes(string_7).Length;
                string s = string_5.Replace(" -//W3C//DTD HTML", "-//W3C//DTD HTML").Replace("{content}", string_7).Replace("{endhtml}", smethod_10(0x13d + length)).Replace("{endfregement}", smethod_10(0x11d + length));
                MemoryStream data = new MemoryStream(Encoding.UTF8.GetBytes(s));
                Clipboard.SetData(DataFormats.Html, data);
            }
            else
            {
                Clipboard.Clear();
                string_7 = string_7.Replace("<BR>", "\n").Replace("<br>", "\n").Replace("<!--StartFragment -->\r\n", "<!--StartFragment -->");
                string str2 = smethod_20(string_7);
                Clipboard.SetData(DataFormats.Text, str2);
            }
            string_8 = "";
            return true;
        }
        catch (Exception exception)
        {
            string_8 = exception.ToString();
            return false;
        }
    }
    public static bool clipboard(string content, out string out_log)
    {
        bool flag;
        try
        {
            if (!content.Contains("<IMG"))
            {
                Clipboard.Clear();
                content = content.Replace("<BR>", "\n").Replace("<br>", "\n").Replace("<!--StartFragment -->\r\n", "<!--StartFragment -->");
                string str = CommonUtil.toText(content);
                Clipboard.SetData(DataFormats.Text, str);
            }
            else
            {
                Clipboard.Clear();
                int length = (int)Encoding.UTF8.GetBytes(content).Length;
                string str1 = CommonUtil.string_5.Replace(" -//W3C//DTD HTML", "-//W3C//DTD HTML").Replace("{content}", content);
                str1 = str1.Replace("{endhtml}", CommonUtil.smethod_10(317 + length));
                str1 = str1.Replace("{endfregement}", CommonUtil.smethod_10(285 + length));
                MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(str1));
                Clipboard.SetData(DataFormats.Html, memoryStream);
                //memoryStream.Close();

                //DataObject obj = new DataObject();
                //obj.SetData(DataFormats.Html, new System.IO.MemoryStream(Encoding.UTF8.GetBytes(str1)));
                ////Clipboard.SetDataObject(obj, true);
                //Clipboard.SetDataObject(obj, true, 100, 1);

            }
            out_log = "";
            flag = true;
        }
        catch (Exception exception)
        {
            out_log = exception.ToString();
            flag = false;
        }
        return flag;
    }

    public static string toText(string string_10)
    {
        return HttpUtility.HtmlDecode(Regex.Replace(string_10, "<[^>]+>", ""));
    }

    public static string smethod_2(string string_7)
    {
        if ((string_7 == null) || string_7.Trim().Equals(""))
        {
            return "";
        }
        return (string_7.Substring(0, 4) + "年" + string_7.Substring(5, 2) + "月" + string_7.Substring(8, 2) + "日 " + string_7.Substring(11, 2) + ":" + string_7.Substring(14, 2));
    }

    public static string smethod_20(string string_7)
    {
        return HttpUtility.HtmlDecode(Regex.Replace(string_7, "<[^>]+>", ""));
    }

    public static void smethod_21(string string_7)
    {
        int length = Encoding.UTF8.GetBytes(string_7).Length;
        string s = string_6.Replace("{content}", string_7).Replace("{endhtml}", smethod_10(0x145 + length)).Replace("{endfregement}", smethod_10(0x121 + length));
        MemoryStream data = new MemoryStream(Encoding.UTF8.GetBytes(s));
        Clipboard.SetData(DataFormats.Html, data);
    }

    public static string smethod_3(string string_7)
    {
        if ((string_7 == null) || string_7.Trim().Equals(""))
        {
            return "";
        }
        return (string_7.Substring(5, 2) + "月" + string_7.Substring(8, 2) + "日 " + string_7.Substring(11, 2) + ":" + string_7.Substring(14, 2));
    }

    public static string smethod_4(string string_7)
    {
        if ((string_7 == null) || string_7.Trim().Equals(""))
        {
            return "";
        }
        return (string_7.Substring(0, 4) + "年" + string_7.Substring(4, 2) + "月" + string_7.Substring(6, 2) + "日 " + string_7.Substring(8, 2) + ":" + string_7.Substring(10, 2));
    }

    public static string smethod_5(string string_7)
    {
        if ((string_7 == null) || string_7.Trim().Equals(""))
        {
            return "";
        }
        return (string_7.Substring(4, 2) + "月" + string_7.Substring(6, 2) + "日 " + string_7.Substring(8, 2) + ":" + string_7.Substring(10, 2));
    }

    public static Color parse_order_status_color(string string_7)
    {
        if (!string_7.Equals("11"))
        {
            if (string_7.Equals("12"))
            {
                return Color.Green;
            }
            if (string_7.Equals("13"))
            {
                return Color.Red;
            }
            if (string_7.Equals("14"))
            {
                return Color.Green;
            }
            if (string_7.Equals("3"))
            {
                return Color.Green;
            }
        }
        return Color.Black;
    }

    public static string parse_order_status_str(string string_7)
    {
        if (string_7.Equals("11"))
        {
            return "订单创建";
        }
        if (string_7.Equals("12"))
        {
            return "订单付款";
        }
        if (string_7.Equals("13"))
        {
            return "订单失效";
        }
        if (string_7.Equals("14"))
        {
            return "订单成功";
        }
        if (string_7.Equals("3"))
        {
            return "订单结算";
        }
        return string_7;
    }

    public static string parse_Order_status_sql(string string_7)
    {
        if (string_7.Equals("订单创建"))
        {
            return " and payStatus='11' ";
        }
        if (string_7.Equals("订单付款"))
        {
            return " and payStatus='12' ";
        }
        if (string_7.Equals("订单失效"))
        {
            return " and payStatus='13' ";
        }
        if (string_7.Equals("订单成功"))
        {
            return " and payStatus='14' ";
        }
        if (string_7.Equals("订单结算"))
        {
            return " and payStatus='3' ";
        }
        if (string_7.Equals("全部订单"))
        {
            return " ";
        }
        if (string_7.Equals("有效订单"))
        {
            return " and ( payStatus='12' or payStatus='14' or payStatus='3') ";
        }
        return string_7;
    }

    public static bool check_pay_status(string string_7, string string_8)
    {
        return ((string_8.Equals("订单创建") && string_7.Equals("11")) 
            || ((string_8.Equals("订单付款") && string_7.Equals("12")) 
            || ((string_8.Equals("订单失效") && string_7.Equals("13")) 
            || ((string_8.Equals("订单成功") && string_7.Equals("14")) 
            || ((string_8.Equals("订单结算") && string_7.Equals("3")) 
            || ((string_8.Equals("全部订单") || string_8.Trim().Equals("")) 
            || (string_8.Equals("有效订单") && ((string_7.Equals("12")
            || string_7.Equals("14")) || string_7.Equals("3")))))))));
    }


}

