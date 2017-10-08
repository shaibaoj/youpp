using haopintui;
using haopintui.entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Windows.Forms;

public class AlimamaCodeUtil
{

    public static string code_url(CmsForm cmsForm, string url, string cookie)
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

    public static AlimamaQueryBean get_img_url(CmsForm cmsForm, string url, string cookie, out string sessionid)
    {
        sessionid = "";
        AlimamaQueryBean alimamaQueryBean = null;
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
                alimamaQueryBean = new AlimamaQueryBean();
                sessionid = StringUtil.subString(str4, 0, "sessionid: '", "'");
                if (!string.IsNullOrEmpty(sessionid))
                {
                    alimamaQueryBean.sessionid = sessionid;
                    alimamaQueryBean.img_url = "http://pin.aliyun.com/get_img?identity=sm-union-pub&sessionid=" + sessionid + "&type=number&t=1497692646342";
                    alimamaQueryBean.action = StringUtil.subString(str4, 0, "action: '", "'");
                    alimamaQueryBean.event_submit_do_unique = StringUtil.subString(str4, 0, "event_submit_do_unique: '", "'");
                    alimamaQueryBean.smPolicy = StringUtil.subString(str4, 0, "smPolicy: '", "'");
                    alimamaQueryBean.smApp = StringUtil.subString(str4, 0, "smApp: '", "'");
                    alimamaQueryBean.smReturn = StringUtil.subString(str4, 0, "smReturn: '", "'");
                    alimamaQueryBean.smCharset = StringUtil.subString(str4, 0, "smCharset: '", "'");
                    alimamaQueryBean.smTag = StringUtil.subString(str4, 0, "smTag: '", "'");
                    alimamaQueryBean.captcha = StringUtil.subString(str4, 0, "captcha: '", "'");
                    alimamaQueryBean.smSign = StringUtil.subString(str4, 0, "smSign: '", "'");

                    alimamaQueryBean.identity = StringUtil.subString(str4, 0, "identity: '", "'");

                    return alimamaQueryBean;
                }
            }
            return null;
        }
        catch (Exception exception)
        {
            return null;
        }

    }

    public static string down_img(CmsForm cmsForm, string img_url)
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

    public static string si_img(CmsForm cmsForm, string file_img, out string out_log)
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

            //LogUtil.log_cms_call(cmsForm, "file_img:" + file_img);
            //LogUtil.log_cms_call(cmsForm, "textResult:" + textResult.ToString());
            LogUtil.log_cms_call(cmsForm, "云端自动处理");

            if (System.IO.File.Exists(file_img))
            {
                System.IO.File.Delete(file_img);
            }
            return textResult.ToString();

        }
        catch (Exception exception)
        {
            //LogUtil.log_cms_call(cmsForm, exception.ToString());
            //out_log = exception.ToString();
            return "";
        }
    }

    public static bool check_code(CmsForm cmsForm, string img_code, string sessionid, string taoke_cookie)
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

    public static string submit_query_code(CmsForm cmsForm, AlimamaQueryBean alimamaQueryBean, string img_code, string taoke_cookie)
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
            string str2 = "http://pub.alimama.com/__x5__/query.htm?action={action}"
                +"&event_submit_do_unique={event_submit_do_unique}"
                + "&smPolicy={smPolicy}"
                + "&smApp={smApp}"
                + "&smReturn={smReturn}"
                + "&smCharset={smCharset}"
                + "&smTag={smTag}"
                + "&captcha={captcha}"
                + "&smSign={smSign}"
                + "&ua=116UW5TcyMNYQwiAiwQRHhBfEF8QXtHcklnMWc%3D%7CUm5Ockt%2FRX9CdkN3T3dJdCI%3D%7CU2xMHDJoMnoBZhhiD3RaelRtQ2NNCmMIJnAm%7CVGhXd1llXGhSaFVhVGBYYF9jVGlLcE1zTXFLf0RwRX5Dfkd8R2k%2F%7CVWldfS0TMww1DCwSMhxzDlN9K30%3D%7CVmhIGCcZOQQkGCcdKQk1AT4eIh0oFTUAPQAgHCMWKwsxDjFnMQ%3D%3D%7CV25OHjAePgE5DCwQKBU1DjAINWM1%7CWGFBET8RMQ42AyMfIBs7ATkBOmw6%7CWWBAED4QMAwxCDwcIB4%2BAT4DPgI5bzk%3D%7CWmNDEz0TMwYzCCgULBg4AD0INgs3YTc%3D%7CW2NDEz0TM2NZbVNzR3MlBToaNBo6Aj8KMQwzZTM%3D%7CXGVFFTsVNQ81ASEdIRg4Aj8HPgE6bDo%3D%7CXWVFFTsVNWVeZlx8QHhGEDAPLwEvDzMNOQA%2BCjRiNA%3D%3D%7CXmZGFjh4LGUCbgNAJl8jXnBQADwDPx8jHiJ0VGlJZ0lpVWxRbFBlUQdR%7CX2REFDp6LmcAbAFCJF0hXHJSalFxTGxQaVRoUWxZD1k%3D%7CQHtbCyVlMXgfcx5dO0I%2BQ21NdU5uU3NPdkt3T3dIHkg%3D%7CQXpaCiRkMHkech9cOkM%2FQmxMdE9vUnJOd0p2Q3ZNG00%3D%7CQnlZCSdnM3odcRxfOUA8QW9Pd0xsUXFNdEl2S3NLHUs%3D%7CQ3tbCyVlMUs3XThZJAoqekF6WmZfaz0dIAAuACAcJRskHCUaTBo%3D%7CRHxcDCJiNn8YdBlaPEU5RGpKGi8XNws2A1V1SGhGaEh0TXRAfkN5L3k%3D%7CRX1dDSNjN34ZdRhbPUQ4RWtLGy4WNgo3AlR0SWlHaUl1THVBeEx1I3U%3D%7CRn1dDSNjN34ZdRhbPUQ4RWtLfl5jQ39GfEd7T3UjdQ%3D%3D%7CR35Dfl5jQ3xcYFllRXtDeVlgQHxBYVV1QGBaekZ%2BXmZGekRkWGdHeEdnWGREe0ZmWm5OdFRvT3dXa1MF"
                + "&identity={identity}"
                + "&code={code}"
                + "&_ksTS={_ksTS}&callback=jsonp91";

            string address = str2
                .Replace("{action}", alimamaQueryBean.action)
                .Replace("{event_submit_do_unique}", alimamaQueryBean.event_submit_do_unique)
                .Replace("{smPolicy}", alimamaQueryBean.smPolicy)
                .Replace("{smApp}", alimamaQueryBean.smApp)
                .Replace("{smReturn}", HttpUtility.UrlEncode(alimamaQueryBean.smReturn))
                .Replace("{smCharset}", alimamaQueryBean.smCharset)
                .Replace("{smTag}", HttpUtility.UrlEncode(alimamaQueryBean.smTag))

                .Replace("{captcha}",HttpUtility.UrlEncode(alimamaQueryBean.captcha))
                .Replace("{smSign}",HttpUtility.UrlEncode(alimamaQueryBean.smSign))

                .Replace("{ua}", "")
                .Replace("{identity}", alimamaQueryBean.identity)
                .Replace("{_ksTS}", "")
                .Replace("{code}", img_code)
                ;
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
            //LogUtil.log_cms_call(cmsForm, "queryToken：" + str4);
            if (str4.Contains("\"queryToken\""))
            {
                string code_url = StringUtil.subString(str4, 0, "\"queryToken\":\"", "\"");
                return code_url;
            }
            return "";
        }
        catch (Exception exception)
        {
            return "";
        }
    }

    public static bool check_code(CmsForm cmsForm, int count, string code_url, string taoke_cookie, out string out_log, out string queryToken)
    {
        out_log = "";
        queryToken = "";
        count = count+1;
        code_url = AlimamaCodeUtil.code_url(cmsForm, code_url, taoke_cookie);
        if (!String.IsNullOrEmpty(code_url))
        {
            string out_log_img = "";
            string sessionid = "";
            AlimamaQueryBean alimamaQueryBean = AlimamaCodeUtil.get_img_url(cmsForm, code_url, taoke_cookie, out sessionid);
            string down_img_url = AlimamaCodeUtil.down_img(cmsForm, alimamaQueryBean.img_url);
            string img_text = AlimamaCodeUtil.si_img(cmsForm, down_img_url, out out_log_img);
            //out_log = img_text + ":" + down_img_url + ":" + out_log_img;
            if (!String.IsNullOrEmpty(img_text))
            {
                bool check_img = AlimamaCodeUtil.check_code(cmsForm, img_text, sessionid, taoke_cookie);
                if (check_img)
                {
                    queryToken = AlimamaCodeUtil.submit_query_code(cmsForm, alimamaQueryBean, img_text, taoke_cookie);
                    return true;
                }
                else
                {
                    if (count <= 5)
                    {
                        return AlimamaCodeUtil.check_code(cmsForm, count, code_url, taoke_cookie, out out_log, out queryToken);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else {
                if (count <= 5)
                {
                    return AlimamaCodeUtil.check_code(cmsForm, count, code_url, taoke_cookie, out out_log, out queryToken);
                }
                else
                {
                    return false;
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
