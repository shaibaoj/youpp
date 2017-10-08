using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

public class UploadUtil
{
    private ArrayList arrayList_0 = new ArrayList();
    private Encoding encoding_0 = Encoding.UTF8;
    private string string_0 = string.Empty;

    public UploadUtil()
    {
        string str = DateTime.Now.Ticks.ToString("x");
        this.string_0 = "---------------------------" + str;
    }

    private byte[] get_data()
    {
        int num = 0;
        int index = 0;
        string s = "--" + this.string_0 + "--\r\n";
        byte[] bytes = this.encoding_0.GetBytes(s);
        this.arrayList_0.Add(bytes);
        foreach (byte[] buffer2 in this.arrayList_0)
        {
            num += buffer2.Length;
        }
        byte[] array = new byte[num];
        foreach (byte[] buffer2 in this.arrayList_0)
        {
            buffer2.CopyTo(array, index);
            index += buffer2.Length;
        }
        return array;
    }

    public bool upload(string url, ref string out_log)
    {
        byte[] buffer2;
        WebClient client = new WebClient();
        client.Headers.Add("Content-Type", "multipart/form-data; boundary=" + this.string_0);
        byte[] data = this.get_data();
        try
        {
            buffer2 = client.UploadData(url, data);
            out_log = Encoding.UTF8.GetString(buffer2);
            return true;
        }
        catch (WebException exception)
        {
            Stream responseStream = exception.Response.GetResponseStream();
            buffer2 = new byte[exception.Response.ContentLength];
            responseStream.Read(buffer2, 0, buffer2.Length);
        }
        out_log = Encoding.UTF8.GetString(buffer2);
        return false;
    }

    public void add_field(string name, string value)
    {
        string s = string.Format("--" + this.string_0 + "\r\nContent-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}\r\n", name, value);
        this.arrayList_0.Add(this.encoding_0.GetBytes(s));
    }

    public void add_file(string field_name, string file_name, string file_type)
    {
        FileStream stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[stream.Length];
        stream.Read(buffer, 0, buffer.Length);
        stream.Close();
        int num = file_name.LastIndexOf(@"\");
        string str = file_name.Substring(num + 1);
        this.add_file(field_name, str, file_type, buffer);
    }

    public void add_file(string field_name, string file_name, string file_type, byte[] byte_0)
    {
        string s = "\r\n";
        string str3 = string.Format("--" + this.string_0 + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", field_name, file_name, file_type);
        byte[] bytes = this.encoding_0.GetBytes(str3);
        byte[] buffer2 = this.encoding_0.GetBytes(s);
        byte[] array = new byte[(bytes.Length + byte_0.Length) + buffer2.Length];
        bytes.CopyTo(array, 0);
        byte_0.CopyTo(array, bytes.Length);
        buffer2.CopyTo(array, (int) (bytes.Length + byte_0.Length));
        this.arrayList_0.Add(array);
    }

    public static string smethod_0(string url, string file_path)
    {
        HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        CookieContainer container = new CookieContainer();
        request.CookieContainer = container;
        request.AllowAutoRedirect = true;
        request.Method = "POST";
        string str = DateTime.Now.Ticks.ToString("X");
        request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + str;
        byte[] bytes = Encoding.UTF8.GetBytes("\r\n--" + str + "\r\n");
        byte[] buffer = Encoding.UTF8.GetBytes("\r\n--" + str + "--\r\n");
        int num2 = file_path.LastIndexOf(@"\");
        string str2 = file_path.Substring(num2 + 1);
        StringBuilder builder = new StringBuilder(string.Format("Content-Disposition:form-data;name=\"upfile\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n", str2));
        byte[] buffer3 = Encoding.UTF8.GetBytes(builder.ToString());
        FileStream stream = new FileStream(file_path, FileMode.Open, FileAccess.Read);
        byte[] buffer4 = new byte[stream.Length];
        stream.Read(buffer4, 0, buffer4.Length);
        stream.Close();
        Stream requestStream = request.GetRequestStream();
        requestStream.Write(bytes, 0, bytes.Length);
        requestStream.Write(buffer3, 0, buffer3.Length);
        requestStream.Write(buffer4, 0, buffer4.Length);
        requestStream.Write(buffer, 0, buffer.Length);
        requestStream.Close();
        HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
        return reader.ReadToEnd();
    }

}

