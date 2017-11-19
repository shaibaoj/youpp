using System;
using System.Runtime.InteropServices;
using System.Text;

namespace jk
{
	public class Wrapper
	{
		public Wrapper()
		{
		}

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void uu_CheckApiSign(int softId, string softKey, string guid, string fileMd5, string fileCrc, StringBuilder checkResult);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_getScore(string username, string password);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_login(string string_0, string string_1);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_pay(string username, string card, int softId, string softKey);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_recognizeByCodeTypeAndBytes(byte[] picContent, int codeLength, int codeType, StringBuilder result);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_recognizeByCodeTypeAndPath(string path, int codeType, StringBuilder result);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_recognizeByCodeTypeAndUrl(string string_0, string inCookie, int codeType, string cookieResult, StringBuilder result);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_reguser(string string_0, string string_1, int softid, string softkey);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_reportError(int codeid);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void uu_setSoftInfo(int softId, string softKey);

		[DllImport("Plugin\\UUWiseHelper.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int uu_SysCallOneParam(int repeatTime, int maxRepeat);
	}
}