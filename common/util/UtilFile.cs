using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class UtilFile
{
    public static void delete_dir(string dir_path)
    {
        foreach (string str in Directory.GetFiles(dir_path))
        {
            File.Delete(str);
        }
    }

    public static void copy_dir(string ori_dir_path, string to_dir_path)
    {
        if (!Directory.Exists(to_dir_path))
        {
            Directory.CreateDirectory(to_dir_path);
        }
        foreach (string str in Directory.GetDirectories(ori_dir_path))
        {
            copy_dir(str + @"\", to_dir_path + Path.GetFileName(str) + @"\");
        }
        foreach (string str2 in Directory.GetFiles(ori_dir_path))
        {
            File.Copy(str2, to_dir_path + Path.GetFileName(str2), true);
        }
    }

    public static string read_str(string string_0)
    {
        return read(string_0, Encoding.GetEncoding("GB2312"));
    }

    public static string get_file_md5(string file_path)
    {
        string str;
        try
        {
            if (File.Exists(file_path + "e"))
            {
                File.Delete(file_path + "e");
            }
            File.Copy(file_path, file_path + "e");
            FileStream inputStream = new FileStream(file_path + "e", FileMode.Open);
            byte[] buffer = new MD5CryptoServiceProvider().ComputeHash(inputStream);
            inputStream.Close();
            inputStream.Dispose();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString("x2"));
            }
            str = builder.ToString();
        }
        catch (Exception exception)
        {
            throw new Exception("GetMD5HashFromFile() fail,error:" + exception.Message);
        }
        finally
        {
            try
            {
                File.Delete(file_path + "e");
            }
            catch
            {
            }
        }
        return str;
    }

    public static bool write(string file_path, byte[] byte_0)
    {
        try
        {
            if (File.Exists(file_path))
            {
                File.Delete(file_path);
            }
            FileStream stream = new FileStream(file_path, FileMode.Create);
            stream.Write(byte_0, 0, byte_0.Length);
            stream.Close();
            stream.Dispose();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static byte[] read(string file_path)
    {
        FileInfo info = new FileInfo(file_path);
        long length = info.Length;
        FileStream stream = new FileStream(file_path, FileMode.Open);
        byte[] buffer = new byte[length];
        stream.Read(buffer, 0, (int) length);
        stream.Close();
        stream.Dispose();
        return buffer;
    }

    public static bool write(string file_path, string content, Encoding encoding)
    {
        try
        {
            if (File.Exists(file_path))
            {
                File.Delete(file_path);
            }
            FileStream stream = new FileStream(file_path, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, encoding);
            writer.Write(content);
            writer.Flush();
            writer.Close();
            writer.Dispose();
            stream.Close();
            stream.Dispose();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool write(string file_path, string content)
    {
        return write(file_path, content, Encoding.GetEncoding("GB2312"));
    }

    public static bool write_add(string file_path, string content)
    {
        return write_add(file_path, content, Encoding.GetEncoding("GB2312"));
    }

    public static bool write_add(string file_path, string string_1, Encoding encoding_0)
    {
        try
        {
            FileStream stream = new FileStream(file_path, FileMode.Append);
            StreamWriter writer = new StreamWriter(stream, encoding_0);
            writer.Write(string_1);
            writer.Flush();
            writer.Close();
            writer.Dispose();
            stream.Close();
            stream.Dispose();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static string read(string file_path, Encoding encoding)
    {
        try
        {
            if (!File.Exists(file_path))
            {
                return "";
            }
            StreamReader reader = new StreamReader(file_path, encoding);
            string str2 = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();
            return str2;
        }
        catch (Exception)
        {
            return "";
        }
    }
}

