using System;
using System.IO;
using System.Net;
using System.Text;

public class FtpUtil
{
    public static readonly FtpUtil gclass5_0 = new FtpUtil();

    public string[] method_0(string string_0, string string_1, string string_2)
    {
        StringBuilder builder = new StringBuilder();
        try
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_2));
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(string_0, string_1);
            request.Method = "NLST";
            request.UsePassive = false;
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            for (string str = reader.ReadLine(); str != null; str = reader.ReadLine())
            {
                builder.Append(str);
                builder.Append("\n");
            }
            builder.Remove(builder.ToString().LastIndexOf('\n'), 1);
            reader.Close();
            response.Close();
            return builder.ToString().Split(new char[] { '\n' });
        }
        catch (Exception)
        {
            return null;
        }
    }

    public void method_1(string string_0, string string_1, string string_2)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_2));
            request.Method = "MKD";
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(string_0, string_1);
            request.UsePassive = false;
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            string statusDescription = response.StatusDescription;
        }
        catch (Exception exception)
        {
            throw exception;
        }
    }

    public void method_2(string string_0, string string_1, string string_2, string string_3)
    {
        FileInfo info = new FileInfo(string_2);
        FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_3 + info.Name));
        request.Credentials = new NetworkCredential(string_0, string_1);
        request.UsePassive = false;
        request.KeepAlive = false;
        request.Method = "STOR";
        request.UseBinary = true;
        request.ContentLength = info.Length;
        int count = 0x800;
        byte[] buffer = new byte[0x800];
        FileStream stream = info.OpenRead();
        try
        {
            Stream requestStream = request.GetRequestStream();
            for (int i = stream.Read(buffer, 0, count); i != 0; i = stream.Read(buffer, 0, count))
            {
                requestStream.Write(buffer, 0, i);
            }
            requestStream.Close();
            stream.Close();
        }
        catch (Exception)
        {
        }
    }

    public void method_3(string string_0, string string_1, string string_2)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_2));
            request.Method = "RMD";
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(string_0, string_1);
            request.UsePassive = false;
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            string statusDescription = response.StatusDescription;
        }
        catch (Exception exception)
        {
            throw exception;
        }
    }

    public void method_4(string string_0, string string_1, string string_2, string string_3)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_2 + string_3));
            request.Method = "DELE";
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(string_0, string_1);
            request.UsePassive = false;
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            string statusDescription = response.StatusDescription;
        }
        catch (Exception exception)
        {
            throw exception;
        }
    }

    public void method_5(string string_0, string string_1, string string_2, string string_3, string string_4)
    {
        try
        {
            FileStream stream = new FileStream(string_3 + @"\" + string_4, FileMode.Create);
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri(string_2 + string_4));
            request.Method = "RETR";
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(string_0, string_1);
            request.UsePassive = false;
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            long contentLength = response.ContentLength;
            int count = 0x800;
            byte[] buffer = new byte[0x800];
            for (int i = responseStream.Read(buffer, 0, 0x800); i > 0; i = responseStream.Read(buffer, 0, count))
            {
                stream.Write(buffer, 0, i);
            }
            responseStream.Close();
            stream.Close();
            response.Close();
        }
        catch (Exception exception)
        {
            throw exception;
        }
    }
}

