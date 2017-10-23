using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace com.haopintui.util
{
   public class AutoUpdateUtil
    {
       public static void call_update(String app_path) {
           WebClient webClient = new WebClient();
           if (!File.Exists(app_path + @"\" + Constants.auto_update_exe))
           {
               try
               {
                   webClient.DownloadFile(Constants.software_url + "/update/" + Constants.auto_update_exe, app_path + @"\" + Constants.auto_update_exe);
               }
               catch
               {
                   webClient.DownloadFile(Constants.software_url + "/update/" + Constants.auto_update_exe, app_path + @"\" + Constants.auto_update_exe);
               }
               //MessageBox.Show("[1]");
           }
           string arguments = string.Concat(new object[] { "serverhost=", Constants.api_url, "&softwarename=", Constants.product_code, "&curver=", Constants.version, "&processname=", Constants.main_exe });
           try
           {

               //MessageBox.Show("[" + app_path + @"\" + Constants.auto_update_exe + " " + arguments + "]");
               Process.Start(app_path + @"\" + Constants.auto_update_exe, arguments);
           }
           catch
           {
               //if (File.Exists(app_path + @"\" + Constants.auto_update_exe))
               //{
               //    File.Delete(app_path + @"\" + Constants.auto_update_exe);
               //}
               //try
               //{
               //    webClient.DownloadFile(Constants.software_url + "/update/" + Constants.auto_update_exe, app_path + @"\" + Constants.auto_update_exe);
               //}
               //catch
               //{
               //    webClient.DownloadFile(Constants.software_url + "/update/" + Constants.auto_update_exe, app_path + @"\" + Constants.auto_update_exe);
               //}
               //Process.Start(app_path + @"\" + Constants.auto_update_exe, arguments);
           }

       }

    }
}
