using System;
using System.Windows.Forms;
using 自动更新程序;

internal static class Class0
{
    [STAThread]
    private static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AutoUpdateForm(args));
    }
}

