using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class AlimamaCodeUtil
{

    public static string code_url(string url, string cookie)
    {
        try
        {
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/search/index.htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string str4 = "";
            byte[] buffer = client.DownloadData(url);
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }

            if (str4.Contains("\"url\":\"http"))
            {
                string code_url = StringUtil.subString(str4, 0, "\"url\":\"", "\"");

                return code_url;
            }
            return "";
        }
        catch (Exception exception)
        {
            return "";
        }
    }

    public static string get_img_url(string url, string cookie,out string sessionid)
    {
        sessionid = "";
        try
        {
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/search/index.htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            string str4 = "";
            byte[] buffer = client.DownloadData(url);
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }

            if (str4.Contains("sessionid: '"))
            {
                sessionid = StringUtil.subString(str4, 0, "sessionid: '", "'");
                if (!string.IsNullOrEmpty(sessionid))
                {
                    return "http://pin.aliyun.com/get_img?identity=sm-union-pub&sessionid=" + sessionid + "&type=number&t=1497692646342";
                }
                return "";
            }
            return "";
        }
        catch (Exception exception)
        {
            return "";
        }

    }

    public static string down_img(string img_url)
    {

        string code_path = string.Concat(Application.StartupPath, @"\\config\img_code\");
        DateTime now = DateTime.Now;
        string str4 = string.Concat(code_path, now.ToString("yyyyMMddHHmmssfff"), ".jpg");
        try
        {
            if (!Directory.Exists(code_path))
            {
                Directory.CreateDirectory(code_path);
            }
            (new WebClient()).DownloadFile(img_url, str4);
            return str4;
        }
        catch (Exception exception)
        {
            return "";
        }


    }

    public static string si_img(string file_img,out string out_log)
    {
        out_log = "";
        try
        {
            byte[] imgbuftemp = File.ReadAllBytes(Application.StartupPath + "\\51ocr.Templates");
            www_51ocr_com_InitOCR_2(imgbuftemp, imgbuftemp.Length);

            //预先分配空间
            StringBuilder textResult = new StringBuilder("0000000000", 80);

            byte[] imgbuf = File.ReadAllBytes(file_img);

            int nType = 1;

            if (file_img.ToLower().Contains(".bmp"))
            {
                nType = 1;
            }

            if (file_img.ToLower().Contains(".gif"))
            {
                nType = 2;
            }

            if (file_img.ToLower().Contains(".jpg") || file_img.ToLower().Contains(".jpeg"))
            {
                nType = 3;
            }

            if (file_img.ToLower().Contains("png"))
            {
                nType = 4;
            }

            //
            int i = www_51ocr_com_RECOG_2(imgbuf, imgbuf.Length, nType, textResult);
            return textResult.ToString();

        }
        catch (Exception exception)
        {
            out_log = exception.ToString();
            return "";
        }
    }

    public static bool check_code(string img_code, string sessionid, string taoke_cookie)
    {
        try
        {
            WebClient client = new WebClient();
            client.Headers.Clear();
            client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", "http://pub.alimama.com/promo/search/index.htm");
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", taoke_cookie);
            string str2 = "http://pin.aliyun.com/check_img?code={img_code}&identity=sm-union-pub&sessionid={sessionid}&delflag=0&type=default";
            string address = str2.Replace("{img_code}", img_code).Replace("{sessionid}", sessionid);
            string str4 = "";
            byte[] buffer = client.DownloadData(address);
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = GzipUtil.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
            if (str4.Contains("\"message\":\"SUCCESS"))
            {
                return true;
            }
            return false;
        }
        catch (Exception exception)
        {
            return false;
        }
    }

    public static bool check_code(int count, string code_url, string taoke_cookie,out string out_log)
    {
        out_log = "";
        count = count+1;
        code_url = AlimamaCodeUtil.code_url(code_url, taoke_cookie);
        if (!String.IsNullOrEmpty(code_url))
        {
            string out_log_img = "";
            string sessionid = "";
            String img_url = AlimamaCodeUtil.get_img_url(code_url, taoke_cookie, out sessionid);
            string down_img_url = AlimamaCodeUtil.down_img(img_url);
            string img_text = AlimamaCodeUtil.si_img(down_img_url, out out_log_img);
            out_log = img_text + ":" + down_img_url + ":" + out_log_img;
            if (!String.IsNullOrEmpty(img_text))
            {
                bool check_img = AlimamaCodeUtil.check_code(img_text, sessionid, taoke_cookie);
                if (check_img)
                {
                    return true;
                }
                else { 
                    if(count<=5){
                        return AlimamaCodeUtil.check_code(count, code_url, taoke_cookie, out out_log);
                    }else{
                        return false;
                    }
                }
            }
        }
        return false;
    }

    //调用51OCR.dll 中的函数 using System.Runtime.InteropServices;
    //初始化， 读入样本库文件, 仅需要调用一次， 单线程程序可不调用，DLL会使用默认样本库文件 51ocr.Templates 
    [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_InitOCR", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.StdCall)]
    public static extern int www_51ocr_com_InitOCR(string templatefile);

    //调用51OCR.dll 中的函数 using System.Runtime.InteropServices;
    //初始化， 读入样本库文件, 仅需要调用一次， 单线程程序可不调用，DLL会使用默认样本库文件 51ocr.Templates 
    [DllImport("51OCR.dll", EntryPoint = "_www_51ocr_com_InitOCR_2@8", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.StdCall)]
    public static extern int www_51ocr_com_InitOCR_2(byte[] imagebuf, int size);


    //[in] imagefile 文件名
    //[out] text 识别结果
    //返回 0 正常识别（可能返回空字符）；返回负数 异常状态(文件不存在，文件格式不对等)
    [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_RECOG_1", CharSet = CharSet.Ansi,
        CallingConvention = CallingConvention.StdCall)]
    public static extern int www_51ocr_com_RECOG_1(string imagefile, StringBuilder text);

    //[in] imagebuf 图像文件内存
    //[in] size  文件内存大小
    //[in] type  图像文件类型
    //CXIMAGE_FORMAT_BMP = 1,
    //CXIMAGE_FORMAT_GIF = 2, 
    //CXIMAGE_FORMAT_JPG = 3,
    //CXIMAGE_FORMAT_PNG = 4,
    //CXIMAGE_FORMAT_ICO = 5,
    //CXIMAGE_FORMAT_TIF = 6,
    //[out] text 识别结果
    //返回 0 正常识别（可能返回空字符）； 返回负数 异常状态(文件格式不对等)
    [DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_RECOG_2", CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall)]
    public static extern int www_51ocr_com_RECOG_2(byte[] imagebuf, int size, int type, StringBuilder text);



    //[in] cdkey dll调用密码
    //返回 0 
    //[DllImport("51OCR.dll", EntryPoint = "www_51ocr_com_SetCDKey", CharSet = CharSet.Ansi,
    //     CallingConvention = CallingConvention.StdCall)]
    //public static extern int www_51ocr_com_SetCDKey(string cdkey);

}
