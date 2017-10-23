using System;
using System.Collections.Generic;
using System.Text;

namespace haopintui.util
{
    public class TimeUtil
    {

        public static bool is_fa(CmsForm cmsForm) {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            //LogUtil.log_call(cmsForm, "-" + cmsForm.appBean.qunfa_ds_s1
            //    + "-" + cmsForm.appBean.qunfa_ds_f1
            //    + "-" + cmsForm.appBean.qunfa_ds_s2
            //    + "-" + cmsForm.appBean.qunfa_ds_f2
            //    + "-" + hour
            //    + "-" + minute
            //    );

            if ((
                    hour>cmsForm.appBean.qunfa_ds_s1
                    ||(
                    hour == cmsForm.appBean.qunfa_ds_s1
                    && minute >= cmsForm.appBean.qunfa_ds_f1
                    )
                )
               &&(
               hour<cmsForm.appBean.qunfa_ds_s2
               ||(
               hour == cmsForm.appBean.qunfa_ds_s2
                && minute <= cmsForm.appBean.qunfa_ds_f2
               )
               )
                )
            {
               // LogUtil.log_call(cmsForm, "-" + true
               //);
                return true;  
            }

            return false;
        }

        public static string fa_time(CmsForm cmsForm) {
            return string.Concat(
                cmsForm.appBean.qunfa_ds_s1
                ,":"
                , cmsForm.appBean.qunfa_ds_f1
                , "--"
                , cmsForm.appBean.qunfa_ds_s2
                , ":"
                , cmsForm.appBean.qunfa_ds_f2
           );
        }

    }
}
