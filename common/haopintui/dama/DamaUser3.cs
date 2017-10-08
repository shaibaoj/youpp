using System;
using System.Runtime.InteropServices;
using System.Text;

public class GClass13
{
    public const int int_0 = 0;
    public const int int_1 = -1;
    public const int int_10 = -10;
    public const int int_11 = -11;
    public const int int_12 = -12;
    public const int int_13 = -100;
    public const int int_14 = -101;
    public const int int_15 = -102;
    public const int int_16 = -103;
    public const int int_17 = -104;
    public const int int_18 = -105;
    public const int int_19 = -106;
    public const int int_2 = -2;
    public const int int_20 = -107;
    public const int int_21 = -108;
    public const int int_22 = -109;
    public const int int_23 = -110;
    public const int int_24 = -111;
    public const int int_25 = -112;
    public const int int_26 = -201;
    public const int int_27 = -202;
    public const int int_28 = -203;
    public const int int_29 = -204;
    public const int int_3 = -3;
    public const int int_30 = -205;
    public const int int_31 = -206;
    public const int int_32 = -207;
    public const int int_33 = -208;
    public const int int_34 = -209;
    public const int int_35 = -210;
    public const int int_36 = -211;
    public const int int_37 = -301;
    public const int int_38 = -302;
    public const int int_39 = -303;
    public const int int_4 = -4;
    public const int int_40 = -304;
    public const int int_41 = -305;
    public const int int_42 = -306;
    public const int int_43 = -307;
    public const int int_44 = -308;
    public const int int_45 = -309;
    public const int int_5 = -5;
    public const int int_6 = -6;
    public const int int_7 = -7;
    public const int int_8 = -8;
    public const int int_9 = -9;

    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int ChangeInfo(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, int int_46);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int D2Balance(string string_0, string string_1, string string_2, ref uint uint_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int D2Buf(string string_0, string string_1, string string_2, byte[] byte_0, uint uint_0, ushort ushort_0, uint uint_1, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int D2File(string string_0, string string_1, string string_2, string string_3, ushort ushort_0, uint uint_0, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Decode(string string_0, string string_1, string string_2, byte byte_0, ushort ushort_0, uint uint_0, int int_46, ref uint uint_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeBuf(byte[] byte_0, uint uint_0, string string_0, byte byte_1, ushort ushort_0, uint uint_1, ref uint uint_2);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeBufSync(byte[] byte_0, uint uint_0, string string_0, ushort ushort_0, uint uint_1, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeFileSync(string string_0, ushort ushort_0, uint uint_0, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeSync(string string_0, string string_1, string string_2, ushort ushort_0, uint uint_0, StringBuilder stringBuilder_0, StringBuilder stringBuilder_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeWnd(string string_0, ref Dama_Struct gstruct0_0, byte byte_0, ushort ushort_0, uint uint_0, ref uint uint_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int DecodeWndSync(string string_0, ref Dama_Struct gstruct0_0, ushort ushort_0, uint uint_0, StringBuilder stringBuilder_0);
    [DllImport(@"Plugin\Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int GetOrigError();
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int GetResult(uint uint_0, uint uint_1, StringBuilder stringBuilder_0, uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Init(string string_0, string string_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Login(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, StringBuilder stringBuilder_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Login2(string string_0, string string_1);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Logoff();
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int QueryBalance(ref uint uint_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int ReadInfo(StringBuilder stringBuilder_0, StringBuilder stringBuilder_1, StringBuilder stringBuilder_2, StringBuilder stringBuilder_3, ref int int_46);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Recharge(string string_0, string string_1, ref uint uint_0);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int Register(string string_0, string string_1, string string_2, string string_3, string string_4, int int_46);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern int ReportResult(uint uint_0, int int_46);
    [DllImport(@"Plugin\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi)]
    public static extern void Uninit();
}

