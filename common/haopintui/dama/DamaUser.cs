using System;
using System.Runtime.InteropServices;
using System.Text;

public class DamaUser
{
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern void uu_CheckApiSign(int int_0, string string_0, string string_1, string string_2, string string_3, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_getScore(string string_0, string string_1);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_login(string string_0, string string_1);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_pay(string string_0, string string_1, int int_0, string string_2);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_recognizeByCodeTypeAndBytes(byte[] byte_0, int int_0, int int_1, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_recognizeByCodeTypeAndPath(string string_0, int int_0, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_recognizeByCodeTypeAndUrl(string string_0, string string_1, int int_0, string string_2, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_reguser(string string_0, string string_1, int int_0, string string_2);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_reportError(int int_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern void uu_setSoftInfo(int int_0, string string_0);
    [DllImport(@"Plugin\UUWiseHelper_x64.dll")]
    public static extern int uu_SysCallOneParam(int int_0, int int_1);
}

