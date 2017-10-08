using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class DamaUtil
{
    private bool bool_0 = false;
    private const int int_0 = 0x18629;
    private const int int_1 = 0x3ec;
    private const string string_0 = "06ada1d03089445faa6aba961823b1e1";

    public string method_0(string string_1, string string_2)
    {
        int num3;
        if (IntPtr.Size == 4)
        {
            DamaUser2.uu_setSoftInfo(0x18629, "06ada1d03089445faa6aba961823b1e1");
            if (DamaUser2.uu_login(string_1, string_2) > 0)
            {
                this.bool_0 = true;
                num3 = DamaUser2.uu_getScore(string_1, string_2);
                return ("登录成功！当前点数:[" + num3 + "]");
            }
            return "登录失败！";
        }
        DamaUser.uu_setSoftInfo(0x18629, "06ada1d03089445faa6aba961823b1e1");
        if (DamaUser.uu_login(string_1, string_2) > 0)
        {
            this.bool_0 = true;
            num3 = DamaUser.uu_getScore(string_1, string_2);
            return ("登录成功！当前点数:[" + num3 + "]");
        }
        return "登录失败！";
    }

    public static string recognition(Image image_0)
    {
        MemoryStream stream = new MemoryStream();
        image_0.Save(stream, ImageFormat.Jpeg);
        byte[] buffer = new byte[stream.Length];
        stream.Position = 0L;
        stream.Read(buffer, 0, buffer.Length);
        stream.Flush();
        StringBuilder builder = new StringBuilder(50);
        if (IntPtr.Size == 4)
        {
            DamaUser2.uu_recognizeByCodeTypeAndBytes(buffer, buffer.Length, 0x3ec, builder);
        }
        else
        {
            DamaUser.uu_recognizeByCodeTypeAndBytes(buffer, buffer.Length, 0x3ec, builder);
        }
        stream.Close();
        stream.Dispose();
        return builder.ToString().Split(new char[] { '_' })[1];
    }

    public string method_2(string string_1, int int_2, int int_3, string string_2)
    {
        if (string.IsNullOrEmpty(string_1))
        {
            return string_1;
        }
        if (string_1[0] == '-')
        {
            return string_1;
        }
        string[] strArray = string_1.Split(new char[] { '_' });
        string str2 = strArray[0];
        string str3 = strArray[1];
        string str5 = smethod_0(int_2.ToString() + string_2 + int_3.ToString() + str3.ToUpper()).ToUpper();
        if (str2.Equals(str5))
        {
            return str3;
        }
        return "结果校验不正确";
    }

    public static string smethod_0(string string_1)
    {
        MD5 md = MD5.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(string_1);
        byte[] buffer2 = md.ComputeHash(bytes);
        StringBuilder builder = new StringBuilder();
        foreach (byte num3 in buffer2)
        {
            builder.Append(num3.ToString("x2"));
        }
        return builder.ToString();
    }
}

