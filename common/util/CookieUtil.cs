using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class CookieUtil
{
    [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
    public static extern bool InternetGetCookie(string string_0, string string_1, StringBuilder stringBuilder_0, ref int int_0);
    [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern bool InternetGetCookieEx(string string_0, string string_1, StringBuilder stringBuilder_0, ref int int_0, int int_1, object object_0);
    [DllImport("shell32.dll")]
    public static extern IntPtr ShellExecute(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, GEnum0 genum0_0);
    public static string smethod_0(string string_0)
    {
        int num = 0x100;
        StringBuilder builder = new StringBuilder(0x100);
        if (!InternetGetCookie(string_0, null, builder, ref num))
        {
            if (num < 0)
            {
                return null;
            }
            builder = new StringBuilder(num);
            if (!InternetGetCookie(string_0, null, builder, ref num))
            {
                return null;
            }
        }
        return builder.ToString();
    }

    public static string get_cookie(string url)
    {
        int num = 0x100;
        StringBuilder builder = new StringBuilder(0x100);
        if (!InternetGetCookieEx(url, null, builder, ref num, 0x2000, null))
        {
            if (num < 0)
            {
                return null;
            }
            builder = new StringBuilder(num);
            if (!InternetGetCookieEx(url, null, builder, ref num, 0x2000, null))
            {
                return null;
            }
        }
        return builder.ToString();
    }

    public static void smethod_2()
    {
        try
        {
            ShellExecute(IntPtr.Zero, "open", "rundll32.exe", " InetCpl.cpl,ClearMyTracksByProcess 255", "", GEnum0.const_0);
            foreach (string str in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache), "*", SearchOption.AllDirectories))
            {
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

    public enum GEnum0
    {
        const_0 = 0,
        const_1 = 1,
        const_10 = 8,
        const_11 = 9,
        const_12 = 10,
        const_13 = 11,
        const_14 = 11,
        const_2 = 1,
        const_3 = 2,
        const_4 = 3,
        const_5 = 3,
        const_6 = 4,
        const_7 = 5,
        const_8 = 6,
        const_9 = 7
    }
}

