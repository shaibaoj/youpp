using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class CryptUtil
{
    public static byte[] smethod_0(string string_0)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(string_0);
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = (byte) ((bytes[i] - (i % 100)) - 100);
        }
        return bytes;
    }

    public static string smethod_1(byte[] byte_0, int int_0)
    {
        for (int i = 0; i < int_0; i++)
        {
            byte_0[i] = (byte) ((byte_0[i] + (i % 100)) + 100);
        }
        return Encoding.UTF8.GetString(byte_0, 0, int_0);
    }

    public static string encrypt(string string_0)
    {
        string s = "VavicApp";
        string str2 = "VavicApp";
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        byte[] rgbIV = Encoding.ASCII.GetBytes(str2);
        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        int keySize = provider.KeySize;
        MemoryStream stream = new MemoryStream();
        CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
        StreamWriter writer = new StreamWriter(stream2);
        writer.Write(string_0);
        writer.Flush();
        stream2.FlushFinalBlock();
        writer.Flush();
        return Convert.ToBase64String(stream.GetBuffer(), 0, (int) stream.Length);
    }

    public static string decrypt(string string_0)
    {
        byte[] buffer3;
        string s = "VavicApp";
        string str2 = "VavicApp";
        byte[] bytes = Encoding.ASCII.GetBytes(s);
        byte[] rgbIV = Encoding.ASCII.GetBytes(str2);
        try
        {
            buffer3 = Convert.FromBase64String(string_0);
        }
        catch (Exception exception)
        {
            return exception.ToString();
        }
        DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
        MemoryStream stream = new MemoryStream(buffer3);
        CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Read);
        StreamReader reader = new StreamReader(stream2);
        return reader.ReadToEnd();
    }
}

