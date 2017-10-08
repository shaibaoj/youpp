using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace haopintui
{
    public class FormUtil
    {
        public static void set_formWindowState(CmsForm cmsForm,FormWindowState formWindowState)
        {
            try
            {
                if (cmsForm.InvokeRequired)
                {
                    formWindowState method = new formWindowState(FormUtil.set_formWindowState);
                    cmsForm.BeginInvoke(method, new object[] {cmsForm, formWindowState });
                }
                else
                {
                    //cmsForm.WindowState = formWindowState;
                    if (formWindowState == FormWindowState.Normal)
                    {
                        cmsForm.Activate();
                        cmsForm.Show();
                    }
                    else if (formWindowState == FormWindowState.Minimized)
                    {
                        cmsForm.Hide();
                    }
                }
            }
            catch (Exception exception)
            {
                LogUtil.log_call(cmsForm, "[SetFormState]出错，" + exception.ToString());
            }
        }

    }
}
