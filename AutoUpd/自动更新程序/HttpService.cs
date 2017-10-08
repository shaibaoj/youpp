namespace 自动更新程序
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Net;
    using System.Text;

    public class HttpService
    {
        public CookieContainer cookie = new CookieContainer();

        public string get(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(Url + ((postDataStr == "") ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            Stream responseStream = ((HttpWebResponse) request.GetResponse()).GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
            string str = reader.ReadToEnd();
            reader.Close();
            responseStream.Close();
            return str;
        }

        public string post(string Url, string postDataStr, Boolean cryptBoolean)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/octet-stream";
            request.CookieContainer = this.cookie;
            Stream requestStream = request.GetRequestStream();
            new StreamWriter(requestStream, Encoding.GetEncoding("utf-8"));
            byte[] buffer = null;
            if (cryptBoolean)
            {
                buffer = Crypt.byteEncrypt(postDataStr);
            }
            else {
                buffer = Encoding.UTF8.GetBytes(postDataStr);
            }
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            response.Cookies = this.cookie.GetCookies(response.ResponseUri);
            Stream responseStream = response.GetResponseStream();
            byte[] bytes = new byte[0xc350];
            int num = -1;
            int index = 0;
            while ((num = responseStream.ReadByte()) != -1)
            {
                bytes[index] = (byte) num;
                index++;
            }
            responseStream.Close();
            return Crypt.byteDecrypt(bytes, index);
        }

        public string postHotShare(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/octet-stream";
            request.CookieContainer = this.cookie;
            Stream requestStream = request.GetRequestStream();
            new StreamWriter(requestStream, Encoding.GetEncoding("utf-8"));
            byte[] buffer = Crypt.byteEncrypt(postDataStr);
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            response.Cookies = this.cookie.GetCookies(response.ResponseUri);
            Stream responseStream = response.GetResponseStream();
            byte[] bytes = new byte[0xc350];
            int num = -1;
            int index = 0;
            while ((num = responseStream.ReadByte()) != -1)
            {
                bytes[index] = (byte) num;
                index++;
            }
            responseStream.Close();
            return Encoding.UTF8.GetString(bytes, 0, index);
        }

        public string post_http(string Url, string postDataStr,String cookie)
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
            string str4 = "";
            string str5 = client.ResponseHeaders["Content-Encoding"];
            if ("gzip".Equals(str5))
            {
                str4 = HttpService.zip_to_string(buffer, Encoding.UTF8);
            }
            else
            {
                str4 = Encoding.UTF8.GetString(buffer);
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
}

