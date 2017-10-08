using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

public class UpdateFile
{
    public static void smethod_0(string string_0, string string_1, string string_2, int int_0)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        if (!Directory.Exists(currentDirectory + @"\config"))
        {
            Directory.CreateDirectory(currentDirectory + @"\config");
        }
        HttpService class2 = new HttpService();
        int num2 = int.Parse(class2.post(string_0, "type=softwarever&softwarename=" + string_1));
        if (num2 > int_0)
        {
            UpdateForm form = new UpdateForm();
            form.Show();
            smethod_1("http://www.zhezhehui.cn/s/" + string_2 + ".exe", currentDirectory + @"\config\" + string_2 + ".exe", form.progressBar1, form.label1);
            form.Close();
            string path = currentDirectory + @"\config\update.cmd";
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding("GB2312"));
            writer.WriteLine("taskkill /f /im " + string_2 + ".exe");
            writer.WriteLine("copy \"" + currentDirectory + @"\config\" + string_2 + ".exe\" \"" + currentDirectory + @"\" + string_2 + ".exe\"");
            writer.WriteLine("del \"" + currentDirectory + @"\config\" + string_2 + ".exe\"");
            writer.WriteLine("ping -n 2 127.1>nul");
            writer.WriteLine("start \"\" \"" + currentDirectory + @"\" + string_2 + ".exe\"");
            writer.WriteLine("exit");
            writer.Flush();
            writer.Flush();
            writer.Close();
            writer.Dispose();
            stream.Close();
            stream.Dispose();
            Process.Start("\"" + path + "\"");
        }
        else if (int_0 > num2)
        {
            class2.post(string_0, string.Concat(new object[] { "type=updsoftwarever&softwarename=", string_1, "&version=", int_0 }));
        }
        if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
        {
            MessageBox.Show("程序已经运行！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Environment.Exit(Environment.ExitCode);
        }
    }

    public static void smethod_1(string string_0, string string_1, ProgressBar progressBar_0, Label label_0)
    {
        try
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(string_0);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            long contentLength = response.ContentLength;
            if (progressBar_0 != null)
            {
                progressBar_0.Maximum = (int) contentLength;
            }
            Stream responseStream = response.GetResponseStream();
            Stream stream2 = new FileStream(string_1, FileMode.Create);
            long num4 = 0L;
            byte[] buffer = new byte[0x400];
            int count = responseStream.Read(buffer, 0, buffer.Length);
            while (count > 0)
            {
                num4 = count + num4;
                Application.DoEvents();
                stream2.Write(buffer, 0, count);
                if (progressBar_0 != null)
                {
                    progressBar_0.Value = (int) num4;
                }
                count = responseStream.Read(buffer, 0, buffer.Length);
                label_0.Text = "当前下载进度" + ((int) ((((float) num4) / ((float) contentLength)) * 100f)).ToString() + "%";
                Application.DoEvents();
            }
            stream2.Close();
            responseStream.Close();
        }
        catch (Exception)
        {
            throw;
        }
    }
}

