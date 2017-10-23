using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace haopintui.util
{
    public class ShortUrlUtil
    {

        public static string get_url(CmsForm cmsForm, string url)
        {

            HttpService httpservice = cmsForm.httpService;
            string datastr = String.Concat(
                  "url=" + url
            );
            String body = httpservice.post_http("http://dwz.cn/create.php", datastr, null);
            return body;
        }


    }
}
