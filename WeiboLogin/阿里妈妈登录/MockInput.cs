using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace 阿里妈妈登录
{
	public class MockInput
	{
		public static uint KEYEVENTF_KEYUP;

		static MockInput()
		{
			MockInput.KEYEVENTF_KEYUP = 2;
		}

		public MockInput()
		{
		}

		public static void click(IntPtr hwnd, int int_0, int int_1)
		{
			MockInput.SetForegroundWindow(hwnd);
			MockInput.SetCursorPos(int_0, int_1);
			MockInput.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
			MockInput.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
		}

		public static void click(int int_0, int int_1)
		{
			MockInput.SetCursorPos(int_0, int_1);
			MockInput.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
			MockInput.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
		}

		public static byte getkeycode(char char_0)
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

		public static void input(string string_0, int sleepSec)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (sleepSec != 0)
				{
					Thread.Sleep(sleepSec);
				}
				MockInput.press_key(string_0.Substring(i, 1).ToCharArray()[0]);
			}
		}

		public static void inputAndClick(string string_0, int sleepSec, IntPtr hwnd, int int_0, int int_1)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (sleepSec != 0)
				{
					Thread.Sleep(sleepSec);
				}
				MockInput.SetForegroundWindow(hwnd);
				MockInput.SetCursorPos(int_0, int_1);
				MockInput.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
				MockInput.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
				MockInput.press_key(char.Parse(string_0.Substring(i, 1)));
			}
		}

		public static void Key_BackSpace()
		{
			MockInput.keybd_event(8, 0, 0, 0);
			MockInput.keybd_event(8, 0, MockInput.KEYEVENTF_KEYUP, 0);
		}

		public static void Key_Enter()
		{
			MockInput.keybd_event(13, 0, 0, 0);
			MockInput.keybd_event(13, 0, MockInput.KEYEVENTF_KEYUP, 0);
		}

		public static void Key_ESC()
		{
			MockInput.keybd_event(27, 0, 0, 0);
			MockInput.keybd_event(27, 0, MockInput.KEYEVENTF_KEYUP, 0);
		}

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void mouse_event(int dwFlags, int int_0, int int_1, int dwData, IntPtr dwExtraInfo);

		public static void mouseMove(int int_0, int int_1, int int_2)
		{
			MockInput.SetCursorPos(int_0, int_1);
			int int2 = (int_2 - int_0) / 9;
			MockInput.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
			for (int i = 0; i < int2 + 1; i++)
			{
				MockInput.SetCursorPos(int_0 + i * 9, int_1);
				Thread.Sleep(20);
			}
			MockInput.mouse_event(32772, int_2, int_1, 0, IntPtr.Zero);
		}

		public static void Multi_Ctrl_Any(byte byte_0)
		{
			MockInput.keybd_event(17, 0, 0, 0);
			MockInput.keybd_event(byte_0, 0, 0, 0);
			MockInput.keybd_event(17, 0, MockInput.KEYEVENTF_KEYUP, 0);
			MockInput.keybd_event(byte_0, 0, MockInput.KEYEVENTF_KEYUP, 0);
		}

		public static void MultiKey_Ctrl_A()
		{
			MockInput.Multi_Ctrl_Any(65);
		}

		public static void MultiKey_Ctrl_C()
		{
			MockInput.Multi_Ctrl_Any(67);
		}

		public static void MultiKey_Ctrl_Enter()
		{
			MockInput.Multi_Ctrl_Any(13);
		}

		public static void MultiKey_Ctrl_V()
		{
			MockInput.Multi_Ctrl_Any(86);
		}

		public static void press_key(char char_0)
		{
			byte num = MockInput.getkeycode(char_0);
			MockInput.keybd_event(num, 0, 0, 0);
			MockInput.keybd_event(num, 0, MockInput.KEYEVENTF_KEYUP, 0);
		}

		public void sendKey(IntPtr hwnd, string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Thread.Sleep(10);
				MockInput.SetForegroundWindow(hwnd);
				SendKeys.SendWait(string_0.Substring(i, 1));
			}
		}

		public void sendKeyPwd(IntPtr hwnd, string string_0, int int_0, int int_1)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				Thread.Sleep(200);
				MockInput.SetForegroundWindow(hwnd);
				MockInput.SetCursorPos(int_0, int_1);
				MockInput.mouse_event(32770, int_0, int_1, 0, IntPtr.Zero);
				MockInput.mouse_event(32772, int_0, int_1, 0, IntPtr.Zero);
				SendKeys.SendWait(string_0.Substring(i, 1));
			}
		}

		[DllImport("User32", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void SetCursorPos(int int_0, int int_1);

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		private static extern void SetForegroundWindow(IntPtr intptr_0);

		public enum MouseEventFlags
		{
			Move = 1,
			LeftDown = 2,
			LeftUp = 4,
			RightDown = 8,
			RightUp = 16,
			MiddleDown = 32,
			MiddleUp = 64,
			Wheel = 2048,
			Absolute = 32768
		}
	}
}