using System;
using System.Collections.Generic;
using System.Text;

namespace haopintui
{
    public class AlimamaAdUtil
    {
        public static void updAliPid(object cmsFormobj)
        {
            Object[] obj = ((Object[])cmsFormobj);
            CmsForm cmsForm = ((CmsForm)obj[0]);
            int zone_id = ((int)obj[1]);
            AdzoneBean adzoneBean = AlimamaUtil.query_AdzoneBean("29", cmsForm.appBean.taoke_cookie);
            cmsForm.adzoneBean = adzoneBean;
            cmsForm.appBean.member_id = adzoneBean.memberid;
            CmsUtil.view_cms_call(cmsForm, zone_id);
        }

    }
}
