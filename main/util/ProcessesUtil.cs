using com.haopintui;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace haopintui
{
    public class ProcessesUtil
    {
        public void kill(string processName)
        {
            processName = processName.Replace(".exe", "");
            foreach (Process process in Process.GetProcesses())
            {
                if (processName.Equals(process.ProcessName))
                {
                    process.Kill();
                    break;
                }
            }
        }

        private static void kill(string processName, out bool kill_boolean)
        {
            kill_boolean = false;
            if (processName != null && processName != "")
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

        public static void kill_all()
        {
            string processName = Constants.weixin_login_exe;
            bool kill_boolean = true;
            while (kill_boolean == true)
            {
                ProcessesUtil.kill(processName, out kill_boolean);
                Thread.Sleep(1000);
            }
            processName = Constants.qq_jiqiren_exe;
            kill_boolean = true;
            while (kill_boolean == true)
            {
                ProcessesUtil.kill(processName, out kill_boolean);
                Thread.Sleep(1000);
            }
            processName = Constants.qq_jiqiren_proxy_exe;
            kill_boolean = true;
            while (kill_boolean == true)
            {
                ProcessesUtil.kill(processName, out kill_boolean);
                Thread.Sleep(1000);
            }
        }

        public static Boolean isExist(string processName,int version)
        {
            processName = processName.Replace(".exe", "");
            foreach (Process process in Process.GetProcesses())
            {
                if (processName.Equals(process.ProcessName))
                {
                    return true;
                }
            }
            return false;
        }
        public static void check_Process()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("程序已经运行！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(Environment.ExitCode);
            }
        }

        public static ArrayList getWindows(CmsForm cmsForm, string className)
        {
            ArrayList arrayLists = new ArrayList();
            WindowInfo[] wndList = cmsForm.GetAllDesktopWindows();
            for (int i = wndList.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(wndList[i].szWindowName)
                    &&className.Equals(wndList[i].szClassName))
                {
                    arrayLists.Add(wndList[i].szWindowName);
                }
                //LogUtil.log_cms_call(cmsForm, string.Concat("", wndList[i].szWindowName, wndList[i].szClassName));
                //string follow_path = cmsForm.appBean.follow_path + @"\" + "aaaaa.txt";
                //UtilFile.write_add(follow_path, wndList[i].szWindowName + "::::" + wndList[i].szClassName + "/r/n");
            }


            return arrayLists;
        }

    }

}
