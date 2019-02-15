using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WxLibrary
{
    public class HttpHelper
    {
        private static string HttpRequest(string url,string method)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);  //用GET形式请求指定的地址 
            req.Method = "GET";
            JsapiTicket jsapiTicket = new JsapiTicket();
            using (WebResponse wr = req.GetResponse())
            {
                //HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();  
                StreamReader reader = new StreamReader(wr.GetResponseStream(), Encoding.UTF8);
                string content = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                return content;
            }

        }

        public static string  Get(string url)
        {
            return HttpRequest( url, "GET");
        }


    }
}
