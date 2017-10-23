using com.haopintui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace haopintui
{
    public partial class ShowFwSndForm : Form
    {
        private string string_0 = (Directory.GetCurrentDirectory() + Constants.config_follow_path);
        public ShowFwSndForm(string string_1)
        {
            InitializeComponent();
            this.method_0();
            this.webBrowserFwSnd.Navigate(this.string_0 + @"\" + string_1 + @"\content.html");
        }

        private void method_0()
        {
            try
            {
                this.webBrowserFwSnd.ScriptErrorsSuppressed = true;
                this.webBrowserFwSnd.Navigate("about:blank");
                this.webBrowserFwSnd.IsWebBrowserContextMenuEnabled = false;
                this.webBrowserFwSnd.Document.ExecCommand("LiveResize", false, null);
                this.webBrowserFwSnd.Document.Body.InnerText = "";
            }
            catch (Exception)
            {
            }
        }

    }
}
