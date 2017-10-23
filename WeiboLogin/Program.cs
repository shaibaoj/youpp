using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using 阿里妈妈登录;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AlimamaLoginForm(args));
    }
}
