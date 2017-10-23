using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;

public class IpUtil
{
    public NetworkCredential networkCredential_0 = new NetworkCredential("admin", "admin1");
    public WebClient webClient_0 = new WebClient();

    public IpUtil()
    {
        this.webClient_0.Credentials = this.networkCredential_0;
    }

    public void method_0(bool bool_0)
    {
        if (bool_0)
        {
            this.method_1();
            Thread.Sleep(0x3a98);
            this.method_2();
            Thread.Sleep(0x7530);
        }
    }

    private void method_1()
    {
        this.webClient_0.DownloadData("http://172.168.1.253:80/userRpm/StatusRpm.htm?Disconnect=%B6%CF%20%CF%DF&wan=1");
    }

    private void method_2()
    {
        this.webClient_0.DownloadData("http://172.168.1.253/userRpm/StatusRpm.htm?Connect=%C1%AC%20%BD%D3&wan=1");
    }

    public bool method_3()
    {
        try
        {
            this.webClient_0.DownloadData("http://www.baidu.com");
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static string smethod_0(string string_0)
    {
        byte[] buffer;
        WebClient client = new WebClient();
        try
        {
            buffer = client.DownloadData(string_0);
        }
        catch (Exception)
        {
            return "0.0.0.0";
        }
        string str = Encoding.Default.GetString(buffer);
        return str.Substring(str.IndexOf("您的IP是：[") + 7, (str.IndexOf("] 来自") - str.IndexOf("您的IP是：[")) - 7);
    }

    public static string smethod_1()
    {
        return smethod_0("http://1111.ip138.com/ic.asp");
    }

    public static void smethod_2(string string_0, string string_1, string string_2, bool bool_0)
    {
        if (bool_0)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.AutoFlush = true;
            process.StandardInput.WriteLine("rasdial " + string_0 + " /disconnect");
            Thread.Sleep(500);
            process.StandardInput.WriteLine("rasdial " + string_0 + " " + string_1 + " " + string_2);
            Thread.Sleep(0x3e8);
            process.StandardInput.WriteLine("exit");
            process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();
        }
    }

    public static void smethod_3(string string_0)
    {
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
        process.StandardInput.AutoFlush = true;
        process.StandardInput.WriteLine("taskkill /F /IM " + string_0);
        Thread.Sleep(10);
        process.StandardInput.WriteLine("exit");
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
    }
}

