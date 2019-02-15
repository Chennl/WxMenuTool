using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WxLibrary
{
    public class WxJsapiHelper
    {
        public static string GetJsapiTicket(string accessToken)
        {

            string ticket = string.Empty;
            DateTime expires_in;
            string sql = "SELECT *  FROM tb_wxjsapiticket";
            DataSet ds = SqliteHelper.ExecuteDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ticket = ds.Tables[0].Rows[0]["ticket"].ToString();
                expires_in = Convert.ToDateTime(ds.Tables[0].Rows[0]["expires_in"].ToString());
            }
            else
            {
                expires_in = new DateTime(1970, 1, 1);
            }

            if (DateTime.Now > expires_in)
            {
                JsapiTicket jsapiTicket = GetJSAPITicketOnline(accessToken);
                DateTime refresh_expires_in_time = DateTime.Now.AddSeconds(jsapiTicket.expires_in);
                sql = "delete from tb_wxjsapiticket";
                SqliteHelper.ExecuteSql(sql);
                sql = "INSERT INTO tb_wxjsapiticket ( ticket,expires_in ) VALUES ('" + jsapiTicket.ticket + "','" + refresh_expires_in_time.ToString("yyyy-MM-dd HH:mm:ss") + "' )";
                SqliteHelper.ExecuteSql(sql);
                ticket = jsapiTicket.ticket;
            }

            return ticket;
        }
        /// <summary>
        /// 获取JSAPI_TICKET接口
        /// </summary>
        /// <param name="ticket">调用接口凭证</param>
        /// <returns>   /* "errcode":0,"errmsg":"ok","ticket":"bxLdikRXVbTPdHSM05e5u5sUoXNKd8-41ZO3MhKoyN5OfkWITDGgnr2fwJ0m9E8NYzWKVZvdVtaUgWvsdshFKA","expires_in":7200}</returns>
        private static JsapiTicket GetJSAPITicketOnline(string accessToken)
        {
            var url = string.Format("https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token={0}&type=jsapi", accessToken);

            JsapiTicket jsapiTicket = new JsapiTicket();
            string content = HttpHelper.Get(url);
            jsapiTicket = JsonHelper.ParseFromJson<JsapiTicket>(content);
            return jsapiTicket; 
        }

        /// <summary>
        /// 生成时间戳，标准北京时间，时区为东八区，自1970年1月1日 0点0分0秒以来的秒数
        /// </summary>
        /// <returns>时间戳</returns>
        private static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// 生成随机串，随机串包含字母或数字
        /// </summary>
        /// <returns>随机串</returns>
        private static string GetNonceStr()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
        /// <summary>
        /// 使用SHA1哈希加密算法生成签名
        /// </summary>
        /// <param name="rawstring">待处理的字符串</param>
        /// <returns></returns>
        private static string GetSignature(string rawstring)
        {
            //SHA1 sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            //byte[] bytes_sha1_in = System.Text.UTF8Encoding.Default.GetBytes(rawstring);
            //byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            //string signature = BitConverter.ToString(bytes_sha1_out);
            //signature = signature.Replace("-", "").ToLower();
            string signature =  GetSwcSHA1(rawstring);
            return signature;
            //数字签名校验地址  https://mp.weixin.qq.com/debug/cgi-bin/sandbox?t=jsapisign    


        }
        private static string GetSwcSHA1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }

        /// <summary>
        /// 获取JSSDK所需要的参数信息，返回Hashtable结合
        /// </summary>
        /// <param name="appId">微信AppID</param>
        /// <param name="jsTicket">根据Token获取到的JSSDK ticket</param>
        /// <param name="url">页面URL</param>
        /// <returns></returns>
        public static Hashtable GetParameters(string appId, string jsTicket, string url)
        {
            string timestamp = GetTimeStamp();
            string nonceStr = GetNonceStr();

            // 这里参数的顺序要按照 key 值 ASCII 码升序排序  
            string rawstring = "jsapi_ticket=" + jsTicket + "&noncestr=" + nonceStr + "&timestamp=" + timestamp + "&url=" + url + "";

            string signature = GetSignature(rawstring);
            Hashtable signPackage = new Hashtable();
            signPackage.Add("appid", appId);
            signPackage.Add("noncestr", nonceStr);
            signPackage.Add("timestamp", timestamp);
            signPackage.Add("url", url);
            signPackage.Add("signature", signature.ToLower());
            signPackage.Add("jsapi_ticket", jsTicket);
            signPackage.Add("rawstring", rawstring);
            return signPackage;
        }
        /// <summary>
        /// 获取用于JS-SDK的相关参数列表（该方法对accessToken和JSTicket都进行了指定时间的缓存处理，多次调用不会重复生成）
        /// 集合里面包括jsapi_ticket、noncestr、timestamp、url、signature、appid、rawstring
        /// </summary>
        /// <param name="appid">应用ID</param>
        /// <param name="appSecret">开发者凭据</param>
        /// <param name="url">页面URL</param>
        /// <returns></returns>
        public static Hashtable GetJSAPIParameters(string appid, string appSecret, string url)
        {
            string accessToken = GetAccessToken(appid, appSecret);
            string jsTicket = GetJsapiTicket(accessToken);
            return GetParameters(appid, jsTicket, url);
        }

        /// <summary>
        /// 获取Access_token
        /// </summary>
        /// <returns></returns>
        private static AccessToken GetAccessTokenOnline(string appid, string appSecret)
        {
            //WxAppInfo wxAppInfo = GetWxAppInfo();
            //string appid = wxAppInfo.AppID;//"你自己微信公众测试号的appID"; //微信公众号appid
            //string secret = wxAppInfo.AppSecret;// "你自己微信公众测试号的appsecret";  //微信公众号appsecret

            string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + appSecret;
            AccessToken token = new AccessToken();

            //HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(strUrl);  //用GET形式请求指定的地址 
            //req.Method = "GET";

            //using (WebResponse wr = req.GetResponse())
            //{
            //    //HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();  
            //    StreamReader reader = new StreamReader(wr.GetResponseStream(), Encoding.UTF8);
            //    string content = reader.ReadToEnd();
            //    reader.Close();
            //    reader.Dispose();
            //    token = JsonHelper.ParseFromJson<AccessToken>(content);
            //}
            string content = HttpHelper.Get(url);
            token = JsonHelper.ParseFromJson<AccessToken>(content);
            return token;
        }
        /// <summary>
        /// 根据当前日期 判断Access_Token 是否超期  如果超期返回新的Access_Token   否则返回之前的Access_Token
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns>{"access_token":"ACCESS_TOKEN","expires_in":7200}{</returns>
        public static string GetAccessToken(string appid, string appSecret)
        {
            //WxAppInfo wxAppInfo = GetWxAppInfo();
            string access_token = string.Empty;
            DateTime expires_in_time;
            string sql = "SELECT *  FROM tb_wxaccesstoken";
            DataSet ds = SqliteHelper.ExecuteDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                access_token = ds.Tables[0].Rows[0]["access_token"].ToString();
                expires_in_time = Convert.ToDateTime(ds.Tables[0].Rows[0]["expires_in"].ToString());
            }
            else
            {
                expires_in_time = new DateTime(1970, 1, 1);
            }


            if (DateTime.Now > expires_in_time)
            {
                AccessToken tmpAccessToken = GetAccessTokenOnline(appid, appSecret);
                DateTime refresh_expires_in_time = DateTime.Now.AddSeconds(int.Parse(tmpAccessToken.expires_in));
                sql = "delete from tb_wxaccesstoken";
                SqliteHelper.ExecuteSql(sql);
                sql = "INSERT INTO tb_wxaccesstoken ( access_token,expires_in ) VALUES ('" + tmpAccessToken.access_token + "','" + refresh_expires_in_time.ToString("yyyy-MM-dd HH:mm:ss") + "' )";
                SqliteHelper.ExecuteSql(sql);
                access_token = tmpAccessToken.access_token;
            }
            else
            {
            }
            return access_token;
        }
    }
       
}
