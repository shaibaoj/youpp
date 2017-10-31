using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 阿里妈妈登录
{
	public class UserAgentHelper
	{
		private const int int_0 = 268435457;

		private static string string_0;

		static UserAgentHelper()
		{
			UserAgentHelper.string_0 = null;
		}

		public UserAgentHelper()
		{
		}

		public static void AppendUserAgent(string appendUserAgent)
		{
			if (string.IsNullOrEmpty(UserAgentHelper.string_0))
			{
				UserAgentHelper.string_0 = UserAgentHelper.smethod_0();
			}
			UserAgentHelper.ChangeUserAgent(appendUserAgent);
		}

		public static void ChangeUserAgent(string userAgent)
		{
			UserAgentHelper.UrlMkSetSessionOption(268435457, userAgent, userAgent.Length, 0);
		}

		private static string smethod_0()
		{
			WebBrowser webBrowser = new WebBrowser();
			webBrowser.Navigate("about:blank");
			while (webBrowser.IsBusy)
			{
				Application.DoEvents();
			}
			object domWindow = webBrowser.Document.Window.DomWindow;
			Type type = domWindow.GetType();
			object obj = type.InvokeMember("navigator", BindingFlags.GetProperty, null, domWindow, new object[0]);
			Type type1 = obj.GetType();
			object obj1 = type1.InvokeMember("userAgent", BindingFlags.GetProperty, null, obj, new object[0]);
			return obj1.ToString();
		}

		[DllImport("urlmon.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		private static extern int UrlMkSetSessionOption(int int_1, string string_1, int int_2, int int_3);
	}
}