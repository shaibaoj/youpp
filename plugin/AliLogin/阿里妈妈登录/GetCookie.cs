using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace 阿里妈妈登录
{
	public class GetCookie
	{
		public GetCookie()
		{
		}

		public static void clearIECookie()
		{
			try
			{
				GetCookie.ShellExecute(IntPtr.Zero, "open", "rundll32.exe", " InetCpl.cpl,ClearMyTracksByProcess 255", "", GetCookie.ShowCommands.SW_HIDE);
				string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), "*", SearchOption.AllDirectories);
				string[] strArrays = files;
				for (int i = 0; i < (int)strArrays.Length; i++)
				{
					string str = strArrays[i];
					try
					{
						File.Delete(str);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		public static string GetCookieString(string string_0)
		{
			string str;
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(256);
			if (!GetCookie.InternetGetCookieEx(string_0, null, stringBuilder, ref num, 8192, null))
			{
				if (num >= 0)
				{
					stringBuilder = new StringBuilder(num);
					if (GetCookie.InternetGetCookieEx(string_0, null, stringBuilder, ref num, 8192, null))
					{
						str = stringBuilder.ToString();
						return str;
					}
					str = null;
					return str;
				}
				else
				{
					str = null;
					return str;
				}
			}
			str = stringBuilder.ToString();
			return str;
		}

		public static string GetCookieString1(string string_0)
		{
			string str;
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(256);
			if (!GetCookie.InternetGetCookie(string_0, null, stringBuilder, ref num))
			{
				if (num >= 0)
				{
					stringBuilder = new StringBuilder(num);
					if (GetCookie.InternetGetCookie(string_0, null, stringBuilder, ref num))
					{
						str = stringBuilder.ToString();
						return str;
					}
					str = null;
					return str;
				}
				else
				{
					str = null;
					return str;
				}
			}
			str = stringBuilder.ToString();
			return str;
		}

		[DllImport("wininet.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
		public static extern bool InternetGetCookie(string lpszUrlName, string lbszCookieName, StringBuilder lpszCookieData, ref int lpdwSize);

		[DllImport("wininet.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
		private static extern bool InternetGetCookieEx(string string_0, string string_1, StringBuilder stringBuilder_0, ref int int_0, int int_1, object object_0);

		[DllImport("shell32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, GetCookie.ShowCommands nShowCmd);

		public enum ShowCommands
		{
			SW_HIDE = 0,
			SW_NORMAL = 1,
			SW_SHOWNORMAL = 1,
			SW_SHOWMINIMIZED = 2,
			SW_MAXIMIZE = 3,
			SW_SHOWMAXIMIZED = 3,
			SW_SHOWNOACTIVATE = 4,
			SW_SHOW = 5,
			SW_MINIMIZE = 6,
			SW_SHOWMINNOACTIVE = 7,
			SW_SHOWNA = 8,
			SW_RESTORE = 9,
			SW_SHOWDEFAULT = 10,
			SW_FORCEMINIMIZE = 11,
			SW_MAX = 11
		}
	}
}