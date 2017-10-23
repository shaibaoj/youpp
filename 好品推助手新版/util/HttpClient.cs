using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace haopintui
{
    public class HttpClient : WebClient
    {
        // Cookie 容器
        private CookieContainer cookieContainer;
        // 是否支持自动跳转
        private bool allowAutoRedirect = true;

        /// <summary>
        /// 创建一个新的 WebClient 实例。
        /// </summary>
        public HttpClient()
        {
            this.cookieContainer = new CookieContainer();
        }

        // <summary>
        /// 创建一个新的 WebClient 实例。
        /// </summary>
        /// <param name="cookie">Cookie 容器</param>
        public HttpClient(CookieContainer cookies)
        {
            this.cookieContainer = cookies;
        }

        /// <summary>
        /// 页面是否允许自动跳转，302代码
        /// </summary>
        public bool AllowAutoRedirect
        {
            set { allowAutoRedirect = value; }
            get { return allowAutoRedirect; }
        }

        /// <summary>
        /// Cookie 容器
        /// </summary>
        public CookieContainer Cookies
        {
            get { return this.cookieContainer; }
            set { this.cookieContainer = value; }
        }

        /// <summary>
        /// 返回带有 Cookie 的 HttpWebRequest。
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                HttpWebRequest httpRequest = request as HttpWebRequest;
                httpRequest.AllowAutoRedirect = allowAutoRedirect;
                httpRequest.CookieContainer = cookieContainer;
            }
            return request;
        }
    }
}
