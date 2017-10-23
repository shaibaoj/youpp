using System;
using System.Windows.Forms;
using 阿里妈妈登录;

internal static class Class0
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new AlimamaLoginForm(args));
	}
}