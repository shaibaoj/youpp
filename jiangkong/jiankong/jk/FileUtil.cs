using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace jk
{

    public class FileUtil
    {
        public static bool writeByteToFile(string fileName, byte[] strByte)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                FileStream fileStream = new FileStream(fileName, FileMode.Create);
                fileStream.Write(strByte, 0, strByte.Length);
                fileStream.Close();
                fileStream.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static byte[] readByteFile(string fileName)
        {
            long length = new FileInfo(fileName).Length;
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            byte[] buffer = new byte[length];
            fileStream.Read(buffer, 0, (int)length);
            fileStream.Close();
            fileStream.Dispose();
            return buffer;
        }

        public static bool writeToFile(string fileName, string content, Encoding encoding)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                FileStream fileStream = new FileStream(fileName, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter((Stream)fileStream, encoding);
                streamWriter.Write(content);
                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Dispose();
                fileStream.Close();
                fileStream.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool writeToFile(string fileName, string content)
        {
            return FileUtil.writeToFile(fileName, content, Encoding.GetEncoding("GB2312"));
        }

        public static bool appendToFile(string fileName, string content)
        {
            return FileUtil.appendToFile(fileName, content, Encoding.GetEncoding("GB2312"));
        }

        public static bool appendToFile(string fileName, string content, Encoding encoding)
        {
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter((Stream)fileStream, encoding);
                streamWriter.Write(content);
                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Dispose();
                fileStream.Close();
                fileStream.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string readFile(string fileName, Encoding encoding)
        {
            try
            {
                if (!File.Exists(fileName))
                    return "";
                StreamReader streamReader = new StreamReader(fileName, encoding);
                string str = streamReader.ReadToEnd();
                streamReader.Close();
                streamReader.Dispose();
                return str;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static string readFile(string fileName)
        {
            return FileUtil.readFile(fileName, Encoding.GetEncoding("GB2312"));
        }
    }
}
