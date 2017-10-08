using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace com.haopintui.util
{
    public class UserAgentHelper
    {
        private const int int_0 = 0x10000001;
        private static string string_0 = null;

        public static void AppendUserAgent(string appendUserAgent)
        {
            if (string.IsNullOrEmpty(string_0))
            {
                string_0 = smethod_0();
            }
            string userAgent = appendUserAgent;
            ChangeUserAgent(userAgent);
        }

        public static void ChangeUserAgent(string userAgent)
        {
            UrlMkSetSessionOption(0x10000001, userAgent, userAgent.Length, 0);
        }

        private static string smethod_0()
        {
            WebBrowser browser = new WebBrowser();
            browser.Navigate("about:blank");
            while (browser.IsBusy)
            {
                Application.DoEvents();
            }
            object domWindow = browser.Document.Window.DomWindow;
            object target = domWindow.GetType().InvokeMember("navigator", BindingFlags.GetProperty, null, domWindow, new object[0]);
            return target.GetType().InvokeMember("userAgent", BindingFlags.GetProperty, null, target, new object[0]).ToString();
        }

        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int int_1, string string_1, int int_2, int int_3);

    }
}
