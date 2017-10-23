using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

public class QQUtil
{
    public static Regex regex_0 = new Regex(@"\[face\d{1,3}\.\w*\]");
    public static string string_0 = Application.StartupPath;

    public static string smethod_0(string string_1)
    {
        try
        {
            string_1 = string_1.Replace("<img", "<IMG");
            for (int i = 0; (i = string_1.IndexOf("<IMG", i)) != -1; i++)
            {
                int length = (string_1.IndexOf("\">", i) - i) + 2;
                string oldValue = string_1.Substring(i, length);
                if (oldValue.Contains("sysface=\""))
                {
                    int startIndex = oldValue.IndexOf("sysface=\"") + 9;
                    int num5 = oldValue.IndexOf("\"", startIndex) - startIndex;
                    try
                    {
                        string str2 = smethod_2(int.Parse(oldValue.Substring(startIndex, num5)));
                        if (!"".Equals(str2))
                        {
                            string_1 = string_1.Replace(oldValue, " " + str2);
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return string_1;
        }
        catch
        {
        }
        return string_1;
    }

    public static string smethod_1(string string_1)
    {
        try
        {
            foreach (Match match in regex_0.Matches(string_1))
            {
                string str = match.Value.Replace("[face", "");
                string str3 = smethod_2(int.Parse(str.Substring(0, str.IndexOf("."))));
                if (!"".Equals(str3))
                {
                    string_1 = string_1.Replace(match.Value, " " + str3);
                }
            }
        }
        catch
        {
        }
        return string_1;
    }

    public static string smethod_2(int int_0)
    {
        switch (int_0)
        {
            case 0:
                return "/jy";

            case 1:
                return "/pz";

            case 2:
                return "/se";

            case 3:
                return "/fd";

            case 4:
                return "/dy";

            case 5:
                return "/ll";

            case 6:
                return "/hx";

            case 7:
                return "/bz";

            case 8:
                return "/shui";

            case 9:
                return "/dk";

            case 10:
                return "/gg";

            case 11:
                return "/fn";

            case 12:
                return "/tp";

            case 13:
                return "/cy";

            case 14:
                return "/wx";

            case 15:
                return "/ng";

            case 0x10:
                return "/kuk";

            case 0x12:
                return "/zk";

            case 0x13:
                return "/tuu";

            case 20:
                return "/tx";

            case 0x15:
                return "/ka";

            case 0x16:
                return "/baiy";

            case 0x17:
                return "/am";

            case 0x18:
                return "/jie";

            case 0x19:
                return "/kun";

            case 0x1a:
                return "/jk";

            case 0x1b:
                return "/lh";

            case 0x1c:
                return "/hanx";

            case 0x1d:
                return "/db";

            case 30:
                return "/fendou";

            case 0x1f:
                return "/zhm";

            case 0x20:
                return "/yiw";

            case 0x21:
                return "/xu";

            case 0x22:
                return "/yun";

            case 0x23:
                return "/zhem";

            case 0x24:
                return "/shuai";

            case 0x25:
                return "/kl";

            case 0x26:
                return "/qiao";

            case 0x27:
                return "/zj";

            case 0x29:
                return "/fad";

            case 0x2a:
                return "/aiq";

            case 0x2b:
                return "/tiao";

            case 0x2e:
                return "/zt";

            case 0x31:
                return "/yb";

            case 0x35:
                return "/dg";

            case 0x36:
                return "/shd";

            case 0x37:
                return "/zhd";

            case 0x38:
                return "/dao";

            case 0x39:
                return "/zq";

            case 0x3b:
                return "/bb";

            case 60:
                return "/kf";

            case 0x3d:
                return "/fan";

            case 0x3f:
                return "/mg";

            case 0x40:
                return "/dx";

            case 0x42:
                return "/xin";

            case 0x43:
                return "/xs";

            case 0x45:
                return "/lw";

            case 0x4a:
                return "/ty";

            case 0x4b:
                return "/yl";

            case 0x4c:
                return "/qiang";

            case 0x4d:
                return "/ruo";

            case 0x4e:
                return "/ws";

            case 0x4f:
                return "/shl";

            case 0x55:
                return "/fw";

            case 0x56:
                return "/oh";

            case 0x59:
                return "/xig";

            case 0x60:
                return "/lengh";

            case 0x61:
                return "/ch";

            case 0x62:
                return "/kb";

            case 0x63:
                return "/gz";

            case 100:
                return "/qd";

            case 0x65:
                return "/huaix";

            case 0x66:
                return "/zhh";

            case 0x67:
                return "/yhh";

            case 0x68:
                return "/hq";

            case 0x69:
                return "/bs";

            case 0x6a:
                return "/wq";

            case 0x6b:
                return "/kk";

            case 0x6c:
                return "/yx";

            case 0x6d:
                return "/qq";

            case 110:
                return "/xia";

            case 0x6f:
                return "/kel";

            case 0x70:
                return "/cd";

            case 0x71:
                return "/pj";

            case 0x72:
                return "/lq";

            case 0x73:
                return "/pp";

            case 0x74:
                return "/sa";

            case 0x75:
                return "/pch";

            case 0x76:
                return "/bq";

            case 0x77:
                return "/gy";

            case 120:
                return "/qt";

            case 0x79:
                return "/cj";

            case 0x7a:
                return "/aini";

            case 0x7b:
                return "/bu";

            case 0x7c:
                return "/hd";

            case 0x7d:
                return "/zhq";

            case 0x7e:
                return "/kt";

            case 0x7f:
                return "/ht";

            case 0x80:
                return "/tsh";

            case 0x81:
                return "/hsh";

            case 130:
                return "/jd";

            case 0x83:
                return "/jw";

            case 0x84:
                return "/xw";

            case 0x85:
                return "/zuotj";

            case 0x86:
                return "/youtj";

            case 0x88:
                return "/shx";

            case 0x89:
                return "/bp";

            case 0x8a:
                return "/dl";

            case 0x8b:
                return "/facai";

            case 140:
                return "/kg";

            case 0x8d:
                return "/gw";

            case 0x8e:
                return "/youjian";

            case 0x8f:
                return "/sq";

            case 0x90:
                return "/hc";

            case 0x91:
                return "/qidao";

            case 0x92:
                return "/baojin";

            case 0x93:
                return "/bangbangt";

            case 0x94:
                return "/hn";

            case 0x95:
                return "/xmian";

            case 150:
                return "/xj";

            case 0x97:
                return "/fj";

            case 0x98:
                return "/kch";

            case 0x99:
                return "/gtl";

            case 0x9a:
                return "/chx";

            case 0x9b:
                return "/gtr";

            case 0x9c:
                return "/duoyun";

            case 0x9e:
                return "/cp";

            case 0x9f:
                return "/xmao";

            case 160:
                return "/dengpao";

            case 0xa1:
                return "/fch";

            case 0xa2:
                return "/nzh";

            case 0xa3:
                return "/dasan";

            case 0xa4:
                return "/cq";

            case 0xa5:
                return "/zuanjie";

            case 0xa6:
                return "/shf";

            case 0xa7:
                return "/zhj";

            case 0xa8:
                return "/yao";

            case 0xa9:
                return "/shq";

            case 170:
                return "/qw";
        }
        return "";
    }

    public static string smethod_3(string string_1)
    {
        try
        {
            string_1 = string_1.Replace("<img", "<IMG");
            for (int i = 0; (i = string_1.IndexOf("<IMG", i)) != -1; i++)
            {
                int index = string_1.IndexOf("src", i);
                int num4 = string_1.IndexOf("SRC", i);
                int startIndex = index;
                if ((startIndex == -1) || ((startIndex > num4) && (num4 != -1)))
                {
                    startIndex = num4;
                }
                int num6 = string_1.IndexOf("\"", startIndex) + 1;
                string str = string_1.Substring(num6, string_1.IndexOf("\"", num6) - num6);
                if (str.StartsWith("file:///"))
                {
                    string str2 = HttpUtility.UrlDecode(str.Replace("file:///", "").Replace("/", @"\")).Replace("%20", " ");
                    string str3 = string_0 + @"\config\临时文件夹";
                    if (!System.IO.File.Exists(str3 + @"\ok.png"))
                    {
                        WebClient client = new WebClient();
                        client.DownloadFile("http://" + Config.user_url + "/update/config/ok.png", str3 + @"\ok.png");
                    }
                    if (!System.IO.File.Exists(str3 + @"\ng.png"))
                    {
                        new WebClient().DownloadFile("http://" + Config.user_url + "/update/config/ng.png", str3 + @"\ng.png");
                    }
                    bool flag = smethod_4(str3 + @"\ok.png", str2);
                    bool flag2 = smethod_4(str3 + @"\ng.png", str2);
                    if (flag || flag2)
                    {
                        int length = (string_1.IndexOf("\">", i) - i) + 2;
                        string_1 = string_1.Replace(string_1.Substring(i, length), "");
                    }
                }
            }
        }
        catch
        {
        }
        return string_1;
    }

    public static bool smethod_4(string string_1, string string_2)
    {
        FileInfo info = new FileInfo(string_1);
        FileInfo info2 = new FileInfo(string_2);
        if (info.Length != info2.Length)
        {
            return false;
        }
        return smethod_5(Image.FromFile(string_1), Image.FromFile(string_2));
    }

    public static bool smethod_5(Image image_0, Image image_1)
    {
        MemoryStream stream = new MemoryStream();
        MemoryStream stream2 = new MemoryStream();
        image_0.Save(stream, ImageFormat.Bmp);
        image_1.Save(stream2, ImageFormat.Bmp);
        byte[] buffer = stream.GetBuffer();
        byte[] buffer2 = stream2.GetBuffer();
        if (buffer.Length != buffer2.Length)
        {
            return false;
        }
        for (int i = 0; i < buffer.Length; i++)
        {
            if (buffer[i] != buffer2[i])
            {
                return false;
            }
        }
        return true;
    }
}

