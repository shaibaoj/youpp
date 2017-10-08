using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public static class StringUtil
{
    public static string login(HttpService httpservice, string url, string data)
    {
        int num2 = 0;
        while (true)
        {
            try
            {
                return httpservice.post_http(url, data,null);
            }
            catch (Exception exception)
            {
                string str2 = exception.ToString();
                if (!str2.Contains("System.Net.WebException") && !str2.Contains("System.IO.IOException"))
                {
                    throw exception;
                }
                num2++;
                if (num2 > 10)
                {
                    MessageBox.Show("已重试10次，服务器累成狗，等一会再试咯～～～(欢迎大牛来捐服务器费^-^)");
                    throw exception;
                }
                Thread.Sleep(0xbb8);
            }
        }
    }

    public static string smethod_1(string string_0, int int_0, string string_1, string string_2, string string_3)
    {
        string str = subString(string_0, int_0, string_1, string_2);
        string str2 = subString(string_0, int_0, string_1, string_3);
        if (str.Equals(""))
        {
            return str2;
        }
        if (!str2.Equals("") && (str.Length > str2.Length))
        {
            return str2;
        }
        return str;
    }

    public static string subString(string string_0, int int_0, string string_1, string string_2)
    {
        if (!string.IsNullOrEmpty(string_0))
        {        
            int startIndex = string_0.IndexOf(string_1, int_0) + string_1.Length;
            if (startIndex == (string_1.Length - 1))
            {
                return "";
            }
            int length = string_0.IndexOf(string_2, startIndex) - startIndex;
            if (string_0.IndexOf(string_2, startIndex) == -1)
            {
                length = string_0.Length - startIndex;
            }
            if (length == 0)
            {
                return "";
            }
            return string_0.Substring(startIndex, length);
        }
        return "";
    }

    public static string smethod_3(byte[] byte_0)
    {
        return byte_to_str(byte_0, Encoding.UTF8);
    }

    public static string byte_to_str(byte[] byte_0, Encoding encoding_0)
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
        return encoding_0.GetString(byte_0);
    }

    public static void smethod_5(string string_0, string string_1, string string_2)
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
        process.StandardInput.WriteLine("rasdial " + string_0 + " " + string_1 + " " + string_2);
        process.StandardInput.WriteLine("exit");
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
    }

    public static void smethod_6(int int_0)
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
        process.StandardInput.WriteLine("shutdown -s -t " + int_0);
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
    }

    public static void smethod_7(string string_0)
    {
        string path = Directory.GetCurrentDirectory() + @"\config";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string str2 = "\"" + path + "\\chgpcname.reg\"";
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
        process.StandardInput.AutoFlush = true;
        process.StandardInput.WriteLine("echo REGEDIT4 > " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName] >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName] >> " + str2);
        process.StandardInput.WriteLine("echo \"ComputerName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName] >> " + str2);
        process.StandardInput.WriteLine("echo \"ComputerName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\ControlSet002\Control\ComputerName\ComputerName] >> " + str2);
        process.StandardInput.WriteLine("echo \"ComputerName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters] >> " + str2);
        process.StandardInput.WriteLine("echo \"NV Hostname\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine("echo \"Hostname\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_USERS\S-1-5-18\Software\Microsoft\Windows\ShellNoRoam] >> " + str2);
        process.StandardInput.WriteLine("echo @=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\ComputerName\ActiveComputerName] >> " + str2);
        process.StandardInput.WriteLine("echo \"ComputerName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo echo [HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Tcpip\Parameters] >> " + str2);
        process.StandardInput.WriteLine("echo \"NV Hostname\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine("echo \"Hostname\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine(@"echo [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon] >> " + str2);
        process.StandardInput.WriteLine("echo \"DefaultDomainName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine("echo \"AltDefaultDomainName\"=\"" + string_0 + "\" >> " + str2);
        process.StandardInput.WriteLine("regedit /s " + str2);
        process.StandardInput.WriteLine("exit");
        process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        process.Close();
    }

}

