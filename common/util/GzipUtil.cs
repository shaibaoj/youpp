using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;

public class GzipUtil
{
    public static Random random = new Random();
    public static string regex_str = "<[^>]*>";

    public static string randStr(int count)
    {
        string str = "";
        for (int i = 0; i < count; i++)
        {
            if (random.Next(0, 2) == 0)
            {
                str = str + ((char) random.Next(0x41, 0x5b));
            }
            else
            {
                str = str + ((char) random.Next(0x61, 0x7b));
            }
        }
        return str;
    }

    public static string html_to_text(string content)
    {
        return Regex.Replace(content, regex_str, "");
    }

    public static string zip_to_string(byte[] byte_0, Encoding encoding)
    {
        MemoryStream stream = new MemoryStream(byte_0);
        MemoryStream stream2 = new MemoryStream();
        int count = 0;
        GZipStream stream3 = new GZipStream(stream, CompressionMode.Decompress);
        byte[] buffer = new byte[0x3e8];
        while ((count = stream3.Read(buffer, 0, buffer.Length)) > 0)
        {
            stream2.Write(buffer, 0, count);
        }
        byte_0 = stream2.ToArray();
        return encoding.GetString(byte_0);
    }

    public static byte[] zip_to_byte(string content, Encoding encoding_0)
    {
        byte[] bytes = encoding_0.GetBytes(content);
        MemoryStream stream = new MemoryStream();
        GZipStream stream2 = new GZipStream(stream, CompressionMode.Compress, true);
        stream2.Write(bytes, 0, bytes.Length);
        stream2.Close();
        return stream.ToArray();
    }

    public static string smethod_4(string string_1)
    {
        string_1 = string_1.Replace("&nbsp;", "");
        while (string_1.Contains("&#"))
        {
            int startIndex = string_1.IndexOf("&#") + 2;
            int length = string_1.IndexOf(";", startIndex) - startIndex;
            string s = string_1.Substring(startIndex, length);
            string newValue = unicode_to_str(@"\u" + int.Parse(s).ToString("x8").Substring(4));
            string_1 = string_1.Replace("&#" + s + ";", newValue);
        }
        return string_1;
    }

    public static string unescape(string content)
    {
        StringBuilder builder = new StringBuilder();
        if (!string.IsNullOrEmpty(content))
        {
            string[] strArray = content.Split(new char[] { '%' });
            try
            {
                for (int i = 1; i < strArray.Length; i++)
                {
                    int num2 = Convert.ToInt32(strArray[i], 0x10);
                    builder.Append((char) num2);
                }
            }
            catch (FormatException)
            {
                return Regex.Unescape(content);
            }
        }
        return builder.ToString();
    }

    public static string str_to_unicode(string string_1)
    {
        StringBuilder builder = new StringBuilder();
        if (!string.IsNullOrEmpty(string_1))
        {
            for (int i = 0; i < string_1.Length; i++)
            {
                builder.Append(@"\u");
                builder.Append(((int) string_1[i]).ToString("x"));
            }
        }
        return builder.ToString();
    }

    public static string unicode_to_str(string content)
    {
        StringBuilder builder = new StringBuilder();
        if (!string.IsNullOrEmpty(content))
        {
            string[] strArray = content.Replace(@"\", "").Split(new char[] { 'u' });
            try
            {
                for (int i = 1; i < strArray.Length; i++)
                {
                    int num3 = Convert.ToInt32(strArray[i], 0x10);
                    builder.Append((char) num3);
                }
            }
            catch (FormatException)
            {
                return Regex.Unescape(content);
            }
        }
        return builder.ToString();
    }
}

