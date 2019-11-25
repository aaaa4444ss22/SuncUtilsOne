using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Sunc.Utils.One.Core.Utils
{
    /// <summary>
    /// http网络工具
    /// </summary>
    public class HttpUtil
    {
        private HttpUtil() { }
        //public static string Get(string url)
        //{
        //    return Get(url,null);
        //}

        public static string Get(string url, Dictionary<string, string> parms = null)
        {
            WebResponse response = GetWebResponse(url,parms);
            Stream stream = response.GetResponseStream();
            string body = new StreamReader(stream, Encoding.GetEncoding("utf-8"))
                .ReadToEnd();
            response.Close();
            return body;
        }
        public static WebResponse GetWebResponse(string url,Dictionary<string,string> parms = null)
        {
            if(parms != null)
            {
                url += "?";
                foreach (var item in parms)
                {
                    url += $"{item.Key}=${item.Value}&";
                }
                url = url.Substring(0, url.Length - 1);
            }
            WebRequest request = WebRequest.CreateHttp(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            return request.GetResponse();
        }



    }
}
