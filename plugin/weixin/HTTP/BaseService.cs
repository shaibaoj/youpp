using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Collections;
using System.Collections.Specialized;

namespace WeChat.NET.HTTP
{
    /// <summary>
    /// 访问http服务器类
    /// </summary>
    static class BaseService
    {
        /// <summary>
        /// 访问服务器时的cookies
        /// </summary>
        public static CookieContainer CookiesContainer;
        /// <summary>
        /// 向服务器发送get请求  返回服务器回复数据
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static byte[] SendGetRequest(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "get";

                if (CookiesContainer == null)
                {
                    CookiesContainer = new CookieContainer();
                }

                request.CookieContainer = CookiesContainer;  //启用cookie

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream response_stream = response.GetResponseStream();

                int count = (int)response.ContentLength;
                int offset = 0;
                byte[] buf = new byte[count];
                while (count > 0)  //读取返回数据
                {
                    int n = response_stream.Read(buf, offset, count);
                    if (n == 0) break;
                    count -= n;
                    offset += n;
                }
                return buf;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 向服务器发送post请求 返回服务器回复数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static byte[] SendPostRequest(string url, string body)
        {
            try
            {
                byte[] request_body = Encoding.UTF8.GetBytes(body);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "post";
                request.ContentLength = request_body.Length;

                Stream request_stream = request.GetRequestStream();

                request_stream.Write(request_body, 0, request_body.Length);

                if (CookiesContainer == null)
                {
                    CookiesContainer = new CookieContainer();
                }
                request.CookieContainer = CookiesContainer;  //启用cookie

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream response_stream = response.GetResponseStream();

                int count = (int)response.ContentLength;
                int offset = 0;
                byte[] buf = new byte[count];
                while (count > 0)  //读取返回数据
                {
                    int n = response_stream.Read(buf, offset, count);
                    if (n == 0) break;
                    count -= n;
                    offset += n;
                }
                return buf;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 获取指定cookie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Cookie GetCookie(string name)
        {
            List<Cookie> cookies = GetAllCookies(CookiesContainer);
            foreach (Cookie c in cookies)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }

        private static List<Cookie> GetAllCookies(CookieContainer cc)
        {
            List<Cookie> lstCookies = new List<Cookie>();

            Hashtable table = (Hashtable)cc.GetType().InvokeMember("m_domainTable",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.GetField |
                System.Reflection.BindingFlags.Instance, null, cc, new object[] { });

            foreach (object pathList in table.Values)
            {
                SortedList lstCookieCol = (SortedList)pathList.GetType().InvokeMember("m_list",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.GetField
                    | System.Reflection.BindingFlags.Instance, null, pathList, new object[] { });
                foreach (CookieCollection colCookies in lstCookieCol.Values)
                    foreach (Cookie c in colCookies) lstCookies.Add(c);
            }
            return lstCookies;
        }

        //public void ProcessRequest()
        //{
        //    //参考http://www.cnblogs.com/greenerycn/archive/2010/05/15/csharp_http_post.html  
        //    string filePath = "d:\\apple4.jpg";
        //    string fileName = "apple4.jpg";
        //    string postURL = "http://192.168.1.11/testhandler/accfile.ashx";

        //    // 边界符  
        //    var boundary = "---------------" + DateTime.Now.Ticks.ToString("x");
        //    var beginBoundary = Encoding.ASCII.GetBytes("--" + boundary + "\r\n");
        //    var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        //    // 最后的结束符  
        //    var endBoundary = Encoding.ASCII.GetBytes("--" + boundary + "--\r\n");

        //    // 文件参数头  
        //    const string filePartHeader =
        //        "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
        //         "Content-Type: application/octet-stream\r\n\r\n";
        //    var fileHeader = string.Format(filePartHeader, "file", fileName);
        //    var fileHeaderBytes = Encoding.UTF8.GetBytes(fileHeader);

        //    // 开始拼数据  
        //    var memStream = new MemoryStream();
        //    memStream.Write(beginBoundary, 0, beginBoundary.Length);

        //    // 文件数据  
        //    memStream.Write(fileHeaderBytes, 0, fileHeaderBytes.Length);
        //    var buffer = new byte[1024];
        //    int bytesRead; // =0  
        //    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
        //    {
        //        memStream.Write(buffer, 0, bytesRead);
        //    }
        //    fileStream.Close();

        //    // Key-Value数据  
        //    var stringKeyHeader = "\r\n--" + boundary +
        //                           "\r\nContent-Disposition: form-data; name=\"{0}\"" +
        //                           "\r\n\r\n{1}\r\n";

        //    Dictionary<string, string> stringDict = new Dictionary<string, string>();
        //    stringDict.Add("len", "500");
        //    stringDict.Add("wid", "300");
        //    //foreach (byte[] formitembytes in from string key in stringDict.Keys
        //    //        select string.Format(stringKeyHeader, key, stringDict[key]) into formitem
        //    //            select Encoding.UTF8.GetBytes(formitem))
        //    //{
        //    //    memStream.Write(formitembytes, 0, formitembytes.Length);
        //    //}

        //    // 写入最后的结束边界符  
        //    memStream.Write(endBoundary, 0, endBoundary.Length);

        //    //倒腾到tempBuffer?  
        //    memStream.Position = 0;
        //    var tempBuffer = new byte[memStream.Length];
        //    memStream.Read(tempBuffer, 0, tempBuffer.Length);
        //    memStream.Close();

        //    // 创建webRequest并设置属性  
        //    var webRequest = (HttpWebRequest)WebRequest.Create(postURL);
        //    webRequest.Method = "POST";
        //    webRequest.Timeout = 100000;
        //    webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
        //    webRequest.ContentLength = tempBuffer.Length;

        //    var requestStream = webRequest.GetRequestStream();
        //    requestStream.Write(tempBuffer, 0, tempBuffer.Length);
        //    requestStream.Close();

        //    var httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
        //    string responseContent;
        //    using (var httpStreamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("utf-8")))
        //    {
        //        responseContent = httpStreamReader.ReadToEnd();
        //    }

        //    httpWebResponse.Close();
        //    webRequest.Abort();

        //}


        /// <summary>
        /// HttpUploadFile
        /// </summary>
        /// <param name="url"></param>
        /// <param name="files"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HttpUploadFile(string url, string[] files, NameValueCollection data, Encoding encoding)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endbytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");

            //1.HttpWebRequest
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            if (CookiesContainer == null)
            {
                CookiesContainer = new CookieContainer();
            }
            request.CookieContainer = CookiesContainer;  //启用cookie

            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            request.KeepAlive = true;
            request.Credentials = CredentialCache.DefaultCredentials;

            using (Stream stream = request.GetRequestStream())
            {
                //1.1 key/value
                string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
                if (data != null)
                {
                    foreach (string key in data.Keys)
                    {
                        stream.Write(boundarybytes, 0, boundarybytes.Length);
                        string formitem = string.Format(formdataTemplate, key, data[key]);
                        byte[] formitembytes = encoding.GetBytes(formitem);
                        stream.Write(formitembytes, 0, formitembytes.Length);
                    }
                }

                //1.2 file
                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
                       headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
                //Content-Disposition: form-data; name="filename"; filename="好品推海报_02.png"

                //Content-Type: image/png
                byte[] buffer = new byte[4096];
                int bytesRead = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    stream.Write(boundarybytes, 0, boundarybytes.Length);
                    //string header = string.Format(headerTemplate, "file" + i, Path.GetFileName(files[i]));
                    string header = string.Format(headerTemplate, "filename", Path.GetFileName(files[i]));
                    byte[] headerbytes = encoding.GetBytes(header);
                    stream.Write(headerbytes, 0, headerbytes.Length);
                    using (FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    {
                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            stream.Write(buffer, 0, bytesRead);
                        }
                    }
                }

                //1.3 form end
                stream.Write(endbytes, 0, endbytes.Length);
            }
            //2.WebResponse
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                return stream.ReadToEnd();
            }
        }


        private static readonly Encoding DEFAULTENCODE = Encoding.UTF8;

        /// <summary>
        /// HttpUploadFile
        /// </summary>
        /// <param name="url"></param>
        /// <param name="file"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HttpUploadFile(string url, string file, NameValueCollection data)
        {
            return HttpUploadFile(url, file, data, DEFAULTENCODE);
        }

        /// <summary>
        /// HttpUploadFile
        /// </summary>
        /// <param name="url"></param>
        /// <param name="file"></param>
        /// <param name="data"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HttpUploadFile(string url, string file, NameValueCollection data, Encoding encoding)
        {
            return HttpUploadFile(url, new string[] { file }, data, encoding);
        }

        /// <summary>
        /// HttpUploadFile
        /// </summary>
        /// <param name="url"></param>
        /// <param name="files"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HttpUploadFile(string url, string[] files, NameValueCollection data)
        {
            return HttpUploadFile(url, files, data, DEFAULTENCODE);
        }
       

    }
}
