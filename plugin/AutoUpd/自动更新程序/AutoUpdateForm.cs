namespace 自动更新程序
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading;
    using System.Web;
    using System.Windows.Forms;
    using System.Xml;
    using System.IO.Compression;
    using Ionic.Zip;

    public class AutoUpdateForm : Form
    {
        private IContainer icontainer = null;
        private int int_0 = 3;
        private RichTextBox richTextBox1;
        private string app_path = Application.StartupPath;
        private WebClient webClient = new WebClient();

        public AutoUpdateForm(string[] args)
        {
            this.InitializeComponent();
            //MessageBox.Show(Application.StartupPath + @"\好品推V1.zip");
            //this.unzip(Application.StartupPath + @"\好品推V1.zip", Application.StartupPath + @"\update", true);

            if ((args == null) || (args.Length == 0))
            {
                MessageBox.Show("版本：[V" + this.int_0 + "]，本程序自动更新，不需要手动打开！");
                Environment.Exit(-1);
            }
            if (args[0].Contains("CheckUpdVersion"))
            {
                Environment.Exit(this.int_0);
            }
            try
            {
                Hashtable hashtable = new Hashtable();
                foreach (string str in args[0].Split(new char[] { '&' }))
                {
                    hashtable.Add(str.Split(new char[] { '=' })[0], str.Split(new char[] { '=' })[1]);
                }
                string str4 = (string) hashtable["serverhost"];
                string str5 = (string) hashtable["softwarename"];
                int num4 = int.Parse((string) hashtable["curver"]);
                string text1 = (string) hashtable["xmlurl"];
                string str2 = (string) hashtable["processname"];
                HttpService service = new HttpService();
                string svcUrl = "http://" + str4 + "/software.php";
                //MessageBox.Show("版本：[V" + str5 + "]，本程序自动更新，不需要手动打开！");
                //MessageBox.Show("版本：[V" + this.postToSvc(service, svcUrl, "type=softwareverautoupd&softwarename=" + str5).Trim() + "]，本程序自动更新，不需要手动打开！");
                foreach (string str in this.postToSvc(service, svcUrl, "type=softwareverautoupd&curver=" + num4 + "&softwarename=" + str5).Trim().Split(new char[] { '&' }))
                {
                    hashtable.Add(str.Split(new char[] { '=' })[0], str.Split(new char[] { '=' })[1]);
                }
                int num2 = int.Parse((string) hashtable["version"]);
                int num3 = int.Parse((string) hashtable["updatetype"]);
                //MessageBox.Show("version:" + num2 + "");
                //MessageBox.Show("updatetype:" + num3 + "");
                //MessageBox.Show("num4:" + num4 + "");
                if (num2 > num4)
                {
                    bool kill_boolean = true;
                    while (kill_boolean==true)
                    {
                        this.kill(str2,out kill_boolean);
                        Thread.Sleep(1000);
                        //MessageBox.Show("kill:" + kill_boolean);
                    }
                    //this.kill(str2);
                    switch (num3)
                    {
                        case 1:
                        {
                            ShowUpdateForm form = new ShowUpdateForm();
                            form.Show();
                            string path = this.app_path + @"\config\update.xml";
                            form.labelDlFileName.Text = form.labelDlFileName.Text + "\nhttp://" + str4 + "/update/" + str5 + ".xml";
                            if (System.IO.File.Exists(path))
                            {
                                System.IO.File.Delete(path);
                            }
                            try
                            {
                                this.webClient.DownloadFile("http://" + str4 + "/update/" + str5 + ".xml", path);
                            }
                            catch
                            {
                                this.webClient.DownloadFile("http://" + str4 + "/update/" + str5 + ".xml", path);
                            }

                            XmlDocument document = new XmlDocument();
                            XmlReaderSettings settings = new XmlReaderSettings();
                            settings.IgnoreComments = true;

                            XmlReader reader2 = XmlReader.Create(path, settings);
                            document.Load(reader2); 
                            //MessageBox.Show("path099:" + path);

                            reader2.Close();

                            XmlNode node2 = document.DocumentElement.SelectSingleNode("filelist");
                            string sofeware_url = node2.Attributes["url"].Value;
                            string sourcepath = node2.Attributes["sourcepath"].Value;

                            XmlNodeList childNodes = node2.ChildNodes;
                            int num5 = 0;
                            foreach (XmlNode node in childNodes)
                            {

                                //MessageBox.Show("node.InnerText:" + node.InnerText);
                                string innerText = node.InnerText;
                                form.labelDlFileName.Text = "正在下载" + innerText.Substring(innerText.IndexOf("/") + 1);
                                form.progressBarAll.Value = (int) ((((float) (num5 + 1)) / ((float) childNodes.Count)) * 100f);
                                int num6 = int.Parse(node.Attributes["updateType"].Value);
                                string zip = null;
                                //MessageBox.Show("zip:" + node.Attributes["zip"]);
                                if (node.Attributes["zip"]!=null)
                                {
                                    zip = node.Attributes["zip"].Value;
                                }

                                if ((num6 == 1) || ((num6 == 0) && !System.IO.File.Exists(this.app_path + @"\" + innerText)))
                                {
                                    if (innerText.Contains("/"))
                                    {
                                        string str11 = innerText.Substring(0, innerText.LastIndexOf("/"));
                                        if (!Directory.Exists(this.app_path + @"\" + str11))
                                        {
                                            Directory.CreateDirectory(this.app_path + @"\" + str11);
                                        }
                                    }
                                    if (System.IO.File.Exists(this.app_path + @"\" + innerText))
                                    {
                                        System.IO.File.Delete(this.app_path + @"\" + innerText);
                                    }
                                    string uRL = sofeware_url + sourcepath + HttpUtility.UrlEncode(innerText, Encoding.UTF8);
                                    form.labelDlFileName.Text = form.labelDlFileName.Text + "\n" + uRL;
                                    try
                                    {
                                        DownloadFile(uRL, this.app_path + @"\" + innerText, form.progressBarFile, form.labelDlFile);
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            DownloadFile(uRL, this.app_path + @"\" + innerText, form.progressBarFile, form.labelDlFile);
                                        }
                                        catch
                                        {
                                            uRL = sofeware_url + sourcepath + HttpUtility.UrlEncode(innerText, Encoding.GetEncoding("GB2312"));
                                            try
                                            {
                                                DownloadFile(uRL, this.app_path + @"\" + innerText, form.progressBarFile, form.labelDlFile);
                                            }
                                            catch
                                            {
                                                DownloadFile(uRL, this.app_path + @"\" + innerText, form.progressBarFile, form.labelDlFile);
                                            }
                                        }
                                    }
                                    if (!string.IsNullOrEmpty(zip)
                                        &&zip =="zip"&&System.IO.File.Exists(this.app_path + @"\" + innerText)){
                                            this.unzip(this.app_path + @"\" + innerText, Application.StartupPath, true);
                                            System.IO.File.Delete(this.app_path + @"\" + innerText);
                                    }
                                }
                                num5++;
                            }
                            form.labelDlFileName.Text = "更新成功！";
                            System.IO.File.Delete(path);
                            form.Close();
                            StreamReader reader = new StreamReader(this.app_path + @"\注意事项.txt", Encoding.GetEncoding("GB2312"));
                            string str7 = reader.ReadToEnd();
                            reader.Close();
                            reader.Dispose();
                            new ShowSuccessForm(str7).ShowDialog();
                            Process.Start(str2);
                            Environment.Exit(0);
                            return;
                        }
                        case 2:
                        {
                            MessageBox.Show("本软件必须更新后才能运行，请下载最新版并且解压覆盖原来的程序！");
                            string fileName = (string) hashtable["downloadrul"];
                            Process.Start(fileName);
                            Environment.Exit(0);
                            break;
                        }
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer != null))
            {
                this.icontainer.Dispose();
            }
            base.Dispose(disposing);
        }

        public static void DownloadFile(string URL, string filename, ProgressBar prog, Label label1)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(URL);
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                long contentLength = response.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int) contentLength;
                }
                Stream responseStream = response.GetResponseStream();
                Stream stream2 = new FileStream(filename, FileMode.Create);
                long num3 = 0L;
                byte[] buffer = new byte[0x400];
                int count = responseStream.Read(buffer, 0, buffer.Length);
                //MessageBox.Show("filename:" + filename);

                while (count > 0)
                {
                    num3 = count + num3;
                    //Application.DoEvents();
                    stream2.Write(buffer, 0, count);
                    if (prog != null)
                    {
                        prog.Value = (int) num3;
                    }
                    count = responseStream.Read(buffer, 0, buffer.Length);
                    label1.Text = "当前下载进度" + ((int) ((((float) num3) / ((float) contentLength)) * 100f)).ToString() + "%";
                    Application.DoEvents();
                }

                //MessageBox.Show("filename1:" + filename);
                stream2.Close();
                responseStream.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new RichTextBox();
            base.SuspendLayout();
            this.richTextBox1.Location = new Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new Size(0x259, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x25e, 0xd6);
            base.Controls.Add(this.richTextBox1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "AutoUpdateForm";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "更新失败提示！";
            base.WindowState = FormWindowState.Minimized;
            base.ResumeLayout(false);
        }

        private void kill(string processName, out bool kill_boolean)
        {
            kill_boolean = false;
            if (processName != null && processName!="")
            {
                processName = processName.Replace(".exe", "");
                foreach (Process process in Process.GetProcesses())
                {
                    if (processName.Equals(process.ProcessName))
                    {

                        //MessageBox.Show("kill:111" + kill_boolean);
                        process.Kill();
                        kill_boolean = true;
                        break;
                    }
                }
            }
        }

        public string postToSvc(HttpService httpService_0, string svcUrl, string data)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    return httpService_0.post_http(svcUrl, data, null);
                }
                catch (Exception exception)
                {
                    string str2 = exception.ToString();
                    if (!str2.Contains("System.Net.WebException") && !str2.Contains("System.IO.IOException"))
                    {
                        throw exception;
                    }
                    num++;
                    if (num > 10)
                    {
                        MessageBox.Show("已重试10次，服务器累成狗，等一会再试咯～～～(欢迎大牛来捐服务器费^-^)");
                        throw exception;
                    }
                    Thread.Sleep(0xbb8);
                }
            }
        }
        private void unzip(string strZipPath, string strUnZipPath, bool overWrite)
        {
            //using (ZipFile zip = new ZipFile(strZipPath))
            //{
            //    zip.ExtractAll(strUnZipPath, ExtractExistingFileAction.OverwriteSilently);
            //}
            ZipUtil.Decompression(strZipPath, strUnZipPath, overWrite);

        }
    }
}

