using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;

public class HttpService
{
    public CookieContainer cookieContainer = new CookieContainer();

    public string post(string url, string data)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        request.Method = "POST";
        request.ContentType = "application/octet-stream";
        request.CookieContainer = this.cookieContainer;
        Stream requestStream = request.GetRequestStream();
        new StreamWriter(requestStream, Encoding.GetEncoding("utf-8"));
        byte[] buffer = CryptUtil.smethod_0(data);
        requestStream.Write(buffer, 0, buffer.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        response.Cookies = this.cookieContainer.GetCookies(response.ResponseUri);
        Stream responseStream = response.GetResponseStream();
        ArrayList list = new ArrayList();
        int num = -1;
        while ((num = responseStream.ReadByte()) != -1)
        {
            list.Add((byte) num);
        }
        int index = 0;
        byte[] buffer2 = new byte[list.Count];
        foreach (byte num3 in list)
        {
            buffer2[index] = num3;
            index++;
        }
        responseStream.Close();
        return CryptUtil.smethod_1(buffer2, index);
    }

    public string method_1(string url, string string_1)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        request.Method = "POST";
        request.ContentType = "application/octet-stream";
        request.CookieContainer = this.cookieContainer;
        Stream requestStream = request.GetRequestStream();
        new StreamWriter(requestStream, Encoding.GetEncoding("utf-8"));
        byte[] buffer = CryptUtil.smethod_0(string_1);
        requestStream.Write(buffer, 0, buffer.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        response.Cookies = this.cookieContainer.GetCookies(response.ResponseUri);
        Stream responseStream = response.GetResponseStream();
        ArrayList list = new ArrayList();
        int num = -1;
        while ((num = responseStream.ReadByte()) != -1)
        {
            list.Add((byte) num);
        }
        int index = 0;
        byte[] bytes = new byte[list.Count];
        foreach (byte num3 in list)
        {
            bytes[index] = num3;
            index++;
        }
        responseStream.Close();
        return Encoding.UTF8.GetString(bytes, 0, index);
    }

    public string get(string url, string data)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url + ((data == "") ? "" : "?") + data);
        request.Method = "GET";
        request.ContentType = "text/html;charset=UTF-8";
        Stream responseStream = ((HttpWebResponse) request.GetResponse()).GetResponseStream();
        StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
        string str = reader.ReadToEnd();
        reader.Close();
        responseStream.Close();
        return str;
    }

    public string method_3(string url, string string_1, string string_2)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        request.Method = "POST";
        request.ContentType = "application/octet-stream";
        request.CookieContainer = this.cookieContainer;
        Stream requestStream = request.GetRequestStream();
        new StreamWriter(requestStream, Encoding.GetEncoding("utf-8"));
        byte[] bytes = Encoding.UTF8.GetBytes(string_2);
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Close();
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        response.Cookies = this.cookieContainer.GetCookies(response.ResponseUri);
        Stream responseStream = response.GetResponseStream();
        ArrayList list = new ArrayList();
        int num = -1;
        while ((num = responseStream.ReadByte()) != -1)
        {
            list.Add((byte) num);
        }
        int index = 0;
        byte[] buffer2 = new byte[list.Count];
        foreach (byte num3 in list)
        {
            buffer2[index] = num3;
            index++;
        }
        responseStream.Close();
        return Encoding.UTF8.GetString(buffer2, 0, index);
    }

    public string post_http(string Url, string postDataStr, String cookie)
    {
        string str4 = "";
        try
        {
            WebClient client = new WebClient();
            //client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            //client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", Url);
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            byte[] buffer = client.UploadData(Url, "POST", Encoding.UTF8.GetBytes(postDataStr));
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = HttpService.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
        }
        catch (Exception)
        {
            
        }
        return str4;
    }

    public string post_http_cookie(string Url, string postDataStr, String cookie,out string out_cookie)
    {
        string str4 = "";
        out_cookie = "";
        try
        {
            WebClient client = new WebClient();
            //client.Headers.Add("Accept", "application/json, text/javascript, */*; q=0.01");
            //client.Headers.Add("Origin", "http://pub.alimama.com");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36");
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("Referer", Url);
            client.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            client.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            client.Headers.Add("Cookie", cookie);
            byte[] buffer = client.UploadData(Url, "POST", Encoding.UTF8.GetBytes(postDataStr));
            string str5 = client.ResponseHeaders["Content-Encoding"];

            out_cookie = client.ResponseHeaders[HttpResponseHeader.SetCookie];  

            if ("gzip".Equals(str5))
            {
                str4 = HttpService.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
            }
        }
        catch (Exception)
        {

        }
        return str4;
    }

    public static string zip_to_string(byte[] byte_0, Encoding encoding)
    {
        MemoryStream stream = new MemoryStream(byte_0);
        MemoryStream stream2 = new MemoryStream();
        int count = 0;
        GZipStream stream3 = new GZipStream(stream, CompressionMode.Decompress);
        byte[] buffer = new byte[0x3e8];
        while ((count = stream3.Read(buffer, 0, buffer.Length)) > 0)
        {
            stream2.Write(buffer, 0, count);
        }
        byte_0 = stream2.ToArray();
        return encoding.GetString(byte_0);
    }
}

