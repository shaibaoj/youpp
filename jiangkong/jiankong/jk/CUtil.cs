using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace jk
{
	public class CUtil
	{
		public static int FORM_MSG_TYPE_LOGINED;

		public static int FORM_MSG_TYPE_NOTOPEN;

		public static int FORM_MSG_TYPE_CHKTMOUT;

		public static int FORM_MSG_TYPE_CLOSENOTLOGINED;

		public static string QY_SEVER_HOST;

		public static string SEVER_HOST;

		static CUtil()
		{
			CUtil.FORM_MSG_TYPE_LOGINED = 1;
			CUtil.FORM_MSG_TYPE_NOTOPEN = 2;
			CUtil.FORM_MSG_TYPE_CHKTMOUT = 3;
			CUtil.FORM_MSG_TYPE_CLOSENOTLOGINED = 4;
			CUtil.QY_SEVER_HOST = "121.43.61.52";
			CUtil.SEVER_HOST = "www.smgz.com";
		}

		public CUtil()
		{
		}

		public static string parseHtmlGzip(byte[] byteArray, Encoding encoding)
		{
			MemoryStream memoryStream = new MemoryStream(byteArray);
			MemoryStream memoryStream1 = new MemoryStream();
			int num = 0;
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			byte[] numArray = new byte[1000];
			while (true)
			{
				int num1 = gZipStream.Read(numArray, 0, (int)numArray.Length);
				num = num1;
				if (num1 <= 0)
				{
					break;
				}
				memoryStream1.Write(numArray, 0, num);
			}
			byteArray = memoryStream1.ToArray();
			return encoding.GetString(byteArray);
		}
	}
}