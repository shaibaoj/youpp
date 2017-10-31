using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace haopintui
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(MainUIThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MainUIUnhandledExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CmsForm());

            //MessageBox.Show(AlimamaUtil.smethod_65("1", "1", "1"), "未处理的异常:", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static void MainUIThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "线程异常:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MainUIUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString(), "未处理的异常:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }  

    }
}
