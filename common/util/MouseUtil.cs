using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public class MouseUtil
{
    public static uint uint_0 = 2;

    [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
    public static extern void keybd_event(byte byte_0, byte byte_1, uint uint_1, uint uint_2);

    public void method_0(IntPtr intptr_0, string string_0)
    {
        for (int i = 0; i < string_0.Length; i++)
        {
            Thread.Sleep(10);
            MouseUtil.SetForegroundWindow(intptr_0);
            SendKeys.SendWait(string_0.Substring(i, 1));
        }
    }

    public void method_1(IntPtr intptr_0, string string_0, int int_0, int int_1)
    {
        for (int i = 0; i < string_0.Length; i++)
        {
            Thread.Sleep(200);
            MouseUtil.SetForegroundWindow(intptr_0);
            MouseUtil.SetCursorPos(int_0, int_1);
            MouseUtil.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
            MouseUtil.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
            SendKeys.SendWait(string_0.Substring(i, 1));
        }
    }

    [DllImport("User32", CharSet = CharSet.None, ExactSpelling = false)]
    public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, IntPtr intptr_0);

    [DllImport("User32", CharSet = CharSet.None, ExactSpelling = false)]
    public static extern void SetCursorPos(int int_0, int int_1);

    [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false, SetLastError = true)]
    private static extern void SetForegroundWindow(IntPtr intptr_0);

    public static void ctrl_(byte byte_0)
    {
        MouseUtil.keybd_event(17, 0, 0, 0);
        MouseUtil.keybd_event(byte_0, 0, 0, 0);
        MouseUtil.keybd_event(17, 0, MouseUtil.uint_0, 0);
        MouseUtil.keybd_event(byte_0, 0, MouseUtil.uint_0, 0);
    }

    public static void ctrl_enter()
    {
        MouseUtil.ctrl_(13);
    }

    public static void smethod_10(string string_0, int int_0, IntPtr intptr_0, int int_1, int int_2)
    {
        for (int i = 0; i < string_0.Length; i++)
        {
            if (int_0 != 0)
            {
                Thread.Sleep(int_0);
            }
            MouseUtil.SetForegroundWindow(intptr_0);
            MouseUtil.SetCursorPos(int_1, int_2);
            MouseUtil.mouse_event(32770, int_1, int_2, 0, IntPtr.Zero);
            MouseUtil.mouse_event(32772, int_1, int_2, 0, IntPtr.Zero);
            MouseUtil.smethod_11(char.Parse(string_0.Substring(i, 1)));
        }
    }

    public static void smethod_11(char char_0)
    {
        byte num = MouseUtil.smethod_14(char_0);
        MouseUtil.keybd_event(num, 0, 0, 0);
        MouseUtil.keybd_event(num, 0, MouseUtil.uint_0, 0);
    }

    public static void smethod_12(int int_0, int int_1)
    {
        MouseUtil.SetCursorPos(int_0, int_1);
    }

    public static void smethod_13(int int_0, int int_1, int int_2)
    {
        MouseUtil.SetCursorPos(int_0, int_1);
        int int2 = (int_2 - int_0) / 9;
        MouseUtil.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
        for (int i = 0; i < int2 + 1; i++)
        {
            MouseUtil.SetCursorPos(int_0 + i * 9, int_1);
            Thread.Sleep(20);
        }
        MouseUtil.mouse_event(32772, int_2, int_1, 0, IntPtr.Zero);
    }

    public static byte smethod_14(char char_0)
    {
        byte num;
        switch (char_0)
        {
            case '*':
                {
                    num = 106;
                    break;
                }
            case '+':
                {
                    num = 107;
                    break;
                }
            case ',':
            case ':':
            case ';':
            case '<':
            case '=':
            case '>':
            case '?':
            case '@':
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
            case 'G':
            case 'H':
            case 'I':
            case 'J':
            case 'K':
            case 'L':
            case 'M':
            case 'N':
            case 'O':
            case 'P':
            case 'Q':
            case 'R':
            case 'S':
            case 'T':
            case 'U':
            case 'V':
            case 'W':
            case 'X':
            case 'Y':
            case 'Z':
            case '[':
            case '\\':
            case ']':
            case '\u005E':
            case '\u005F':
            case '\u0060':
                {
                    num = 0;
                    break;
                }
            case '-':
                {
                    num = 109;
                    break;
                }
            case '.':
                {
                    num = 110;
                    break;
                }
            case '/':
                {
                    num = 111;
                    break;
                }
            case '0':
                {
                    num = 96;
                    break;
                }
            case '1':
                {
                    num = 97;
                    break;
                }
            case '2':
                {
                    num = 98;
                    break;
                }
            case '3':
                {
                    num = 99;
                    break;
                }
            case '4':
                {
                    num = 100;
                    break;
                }
            case '5':
                {
                    num = 101;
                    break;
                }
            case '6':
                {
                    num = 102;
                    break;
                }
            case '7':
                {
                    num = 103;
                    break;
                }
            case '8':
                {
                    num = 104;
                    break;
                }
            case '9':
                {
                    num = 105;
                    break;
                }
            case 'a':
                {
                    num = 65;
                    break;
                }
            case 'b':
                {
                    num = 66;
                    break;
                }
            case 'c':
                {
                    num = 67;
                    break;
                }
            case 'd':
                {
                    num = 68;
                    break;
                }
            case 'e':
                {
                    num = 69;
                    break;
                }
            case 'f':
                {
                    num = 70;
                    break;
                }
            case 'g':
                {
                    num = 71;
                    break;
                }
            case 'h':
                {
                    num = 72;
                    break;
                }
            case 'i':
                {
                    num = 73;
                    break;
                }
            case 'j':
                {
                    num = 74;
                    break;
                }
            case 'k':
                {
                    num = 75;
                    break;
                }
            case 'l':
                {
                    num = 76;
                    break;
                }
            case 'm':
                {
                    num = 77;
                    break;
                }
            case 'n':
                {
                    num = 78;
                    break;
                }
            case 'o':
                {
                    num = 79;
                    break;
                }
            case 'p':
                {
                    num = 80;
                    break;
                }
            case 'q':
                {
                    num = 81;
                    break;
                }
            case 'r':
                {
                    num = 82;
                    break;
                }
            case 's':
                {
                    num = 83;
                    break;
                }
            case 't':
                {
                    num = 84;
                    break;
                }
            case 'u':
                {
                    num = 85;
                    break;
                }
            case 'v':
                {
                    num = 86;
                    break;
                }
            case 'w':
                {
                    num = 87;
                    break;
                }
            case 'x':
                {
                    num = 88;
                    break;
                }
            case 'y':
                {
                    num = 89;
                    break;
                }
            case 'z':
                {
                    num = 90;
                    break;
                }
            default:
                {
                    goto case '\u0060';
                }
        }
        return num;
    }

    public static void ctrl_a()
    {
        MouseUtil.ctrl_(65);
    }

    public static void ctrl_c()
    {
        MouseUtil.ctrl_(67);
    }

    public static void paste()
    {
        MouseUtil.ctrl_(86);
    }

    public static void enter()
    {
        MouseUtil.keybd_event(13, 0, 0, 0);
        MouseUtil.keybd_event(13, 0, MouseUtil.uint_0, 0);
    }

    public static void smethod_6()
    {
        MouseUtil.keybd_event(8, 0, 0, 0);
        MouseUtil.keybd_event(8, 0, MouseUtil.uint_0, 0);
    }

    public static void close()
    {
        MouseUtil.keybd_event(27, 0, 0, 0);
        MouseUtil.keybd_event(27, 0, MouseUtil.uint_0, 0);
    }

    public static void smethod_8(string string_0, int int_0)
    {
        for (int i = 0; i < string_0.Length; i++)
        {
            if (int_0 != 0)
            {
                Thread.Sleep(int_0);
            }
            MouseUtil.smethod_11(string_0.Substring(i, 1).ToCharArray()[0]);
        }
    }

    public static void smethod_9(IntPtr intptr_0, int int_0, int int_1)
    {
        MouseUtil.SetForegroundWindow(intptr_0);
        MouseUtil.SetCursorPos(int_0, int_1);
        MouseUtil.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
        MouseUtil.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
    }


    public enum GEnum1
    {
        const_0 = 1,
        const_1 = 2,
        const_2 = 4,
        const_3 = 8,
        const_4 = 16,
        const_5 = 32,
        const_6 = 64,
        const_7 = 2048,
        const_8 = 32768
    }
}

