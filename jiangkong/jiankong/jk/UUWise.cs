using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace jk
{
	public class UUWise
	{
		private const int int_0 = 99881;

		private const string string_0 = "06ada1d03089445faa6aba961823b1e1";

		private const int int_1 = 1004;

		private bool bool_0 = false;

		public UUWise()
		{
		}

		public string CheckResult(string result, int softId, int codeId, string checkKey)
		{
			string str;
			if (string.IsNullOrEmpty(result))
			{
				str = result;
			}
			else if (result[0] != '-')
			{
				string[] strArrays = result.Split(new char[] { '\u005F' });
				string str1 = strArrays[0];
				string str2 = strArrays[1];
				str = (!str1.Equals(UUWise.MD5Encoding(string.Concat(softId.ToString(), checkKey, codeId.ToString(), str2.ToUpper())).ToUpper()) ? "结果校验不正确" : str2);
			}
			else
			{
				str = result;
			}
			return str;
		}

		public string login(string string_1, string string_2)
		{
			string str;
			int num;
			if (IntPtr.Size != 4)
			{
				Wrapper64.uu_setSoftInfo(99881, "06ada1d03089445faa6aba961823b1e1");
				if (Wrapper64.uu_login(string_1, string_2) <= 0)
				{
					str = "登录失败！";
				}
				else
				{
					this.bool_0 = true;
					num = Wrapper64.uu_getScore(string_1, string_2);
					str = string.Concat("登录成功！当前点数:[", num, "]");
				}
			}
			else
			{
				Wrapper.uu_setSoftInfo(99881, "06ada1d03089445faa6aba961823b1e1");
				if (Wrapper.uu_login(string_1, string_2) <= 0)
				{
					str = "登录失败！";
				}
				else
				{
					this.bool_0 = true;
					num = Wrapper.uu_getScore(string_1, string_2);
					str = string.Concat("登录成功！当前点数:[", num, "]");
				}
			}
			return str;
		}

		public static string MD5Encoding(string rawPass)
		{
			MD5 mD5 = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(rawPass);
			byte[] numArray = mD5.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] numArray1 = numArray;
			for (int i = 0; i < (int)numArray1.Length; i++)
			{
				byte num = numArray1[i];
				stringBuilder.Append(num.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		public string recogniseImg(Image image_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			image_0.Save(memoryStream, ImageFormat.Jpeg);
			byte[] numArray = new byte[checked((int)memoryStream.Length)];
			memoryStream.Position = (long)0;
			memoryStream.Read(numArray, 0, (int)numArray.Length);
			memoryStream.Flush();
			StringBuilder stringBuilder = new StringBuilder(50);
			if (IntPtr.Size != 4)
			{
				Wrapper64.uu_recognizeByCodeTypeAndBytes(numArray, (int)numArray.Length, 1004, stringBuilder);
			}
			else
			{
				Wrapper.uu_recognizeByCodeTypeAndBytes(numArray, (int)numArray.Length, 1004, stringBuilder);
			}
			memoryStream.Close();
			memoryStream.Dispose();
			string str = stringBuilder.ToString();
			char[] chrArray = new char[] { '\u005F' };
			return str.Split(chrArray)[1];
		}
	}
}