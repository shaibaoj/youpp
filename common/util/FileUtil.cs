using System;
using System.IO;
using System.Net;

public class FileUtil
{
    public static void smethod_0(string url, string fileName)
    {
        if (System.IO.File.Exists(fileName))
        {
            System.IO.File.Delete(fileName);
        }
        WebClient client = new WebClient();
        try
        {
            client.DownloadFile(url, fileName);
        }
        catch
        {
            client.DownloadFile(url, fileName);
        }
    }
}

