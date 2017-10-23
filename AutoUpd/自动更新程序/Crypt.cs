namespace 自动更新程序
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    public static class Crypt
    {
        public static string byteDecrypt(byte[] bytes, int size)
        {
            for (int i = 0; i < size; i++)
            {
                bytes[i] = (byte) ((bytes[i] + (i % 100)) + 100);
            }
            return Encoding.UTF8.GetString(bytes, 0, size);
        }

        public static byte[] byteEncrypt(string string_0)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(string_0);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte) ((bytes[i] - (i % 100)) - 100);
            }
            return bytes;
        }

        public static string decrypt(string data)
        {
            byte[] buffer3;
            string s = "VavicApp";
            string str2 = "VavicApp";
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            byte[] rgbIV = Encoding.ASCII.GetBytes(str2);
            try
            {
                buffer3 = Convert.FromBase64String(data);
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

        public static string encrypt(string data)
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
            writer.Write(data);
            writer.Flush();
            stream2.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(stream.GetBuffer(), 0, (int) stream.Length);
        }
    }
}

