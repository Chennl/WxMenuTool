using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    class WxchatHelper
    {
        private static string Encryption(string express)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = "ac1efp2wxwork";//密匙容器的名称，保持加密解密一致才能解密成功
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
                byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
                return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
            }
        }

       
        //解密
        private static string Decryption(string ciphertext)
        {
            CspParameters param = new CspParameters();
            param.KeyContainerName = "ac1efp2wxwork";
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
            {
                byte[] encryptdata = Convert.FromBase64String(ciphertext);
                byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                return Encoding.Default.GetString(decryptdata);
            }
        }

        static string encryptKey = "Oyea";    //定义密钥 
        static string Encrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象   

            byte[] key = Encoding.Unicode.GetBytes(encryptKey); //定义字节数组，用来存储密钥    

            byte[] data = Encoding.Unicode.GetBytes(str);//定义字节数组，用来存储要加密的字符串  

            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      

            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);

            CStream.Write(data, 0, data.Length);  //向加密流中写入数据      

            CStream.FlushFinalBlock();              //释放加密流      

            return Convert.ToBase64String(MStream.ToArray());//返回加密后的字符串  
        }
        static string Decrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象    

            byte[] key = Encoding.Unicode.GetBytes(encryptKey); //定义字节数组，用来存储密钥    

            byte[] data = Convert.FromBase64String(str);//定义字节数组，用来存储要解密的字符串  

            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      

            //使用内存流实例化解密流对象       
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);

            CStream.Write(data, 0, data.Length);      //向解密流中写入数据     

            CStream.FlushFinalBlock();               //释放解密流      

            return Encoding.Unicode.GetString(MStream.ToArray());       //返回解密后的字符串  
        }  

        //public static String TOKEN = "7242609C8AEF41F88622A80AFCBE4E83";
        ////XCH:	wxe5c0f537d7c604c6
        ////      1ce3b5a1f9af31ba3668e8c2b4194a56
        //public static String APPID = "wx743b2ddda1bec8b8";
        //public static String APPSECRET = "76da573cba7fb93b7f2bb3a4e03540a9";
        /**
            * 用于获取当前与微信公众号交互的用户信息的接口（一般是用第一个接口地址）
        */
        public static String GET_WECHAT_USER_URL = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=ACCESS_TOKEN&openid=OPENID";
        public static String GetPageUsersUrl = "https://api.weixin.qq.com/sns/userinfo?access_token=ACCESS_TOKEN&openid=OPENID&lang=zh_CN";

        /**
             * 用于进行网页授权验证的接口URL，通过这个才可以得到opendID等字段信息
         */
        public static String GET_WEBAUTH_URL = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=APPID&secret=SECRET&code=CODE&grant_type=authorization_code";

        /**
             * 用于进行当点击按钮的时候，能够在网页授权之后获取到code，再跳转到自己设定的一个URL路径上的接口，这个主要是为了获取之后于
             * 获取openId的接口相结合
             * 注意：参数：toselfURL  表示的是当授权成功后，跳转到的自己设定的页面，所以这个要根据自己的需要进行修改
         */
        public static String Get_WEIXINPAGE_Code = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=APPID&redirect_uri=toselfURL&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect";
        /**
             * 获取access_token的URL
         */
        public static String ACCESS_TOKEN_URL = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=APPID&secret=APPSECRET";
    

        public static int SaveWxAppInfo(String wxName,String appID, String appSecret)
        {

            string sql = "UPDATE tb_wxappinfo  SET flag = 0";
           // appSecret = Encrypt(appSecret);
            SqliteHelper.ExecuteSql(sql);
            sql = "INSERT INTO tb_wxappinfo (wxname,appid,appsecret,flag) VALUES ('" + wxName + "','" + appID + "','" + appSecret + "',1)";
            return SqliteHelper.ExecuteSql(sql);
        }
        public static WxAppInfo GetWxAppInfo()
        {
 
           string  sql =  "select * from tb_wxappinfo where flag=1";
            DataSet ds = SqliteHelper.ExecuteDataSet(sql);
            DataTable dt = ds.Tables[0];
            WxAppInfo wxAppInfo = new WxAppInfo();
            if (dt.Rows.Count > 0)
            {
                wxAppInfo.AppID = dt.Rows[0]["appid"].ToString();
                wxAppInfo.AppSecret = dt.Rows[0]["appsecret"].ToString();
                wxAppInfo.WxName = dt.Rows[0]["wxname"].ToString();
            }
            else
            {
                wxAppInfo.AppID = "";
                wxAppInfo.AppSecret = "";
                wxAppInfo.WxName = "";
            }
            return wxAppInfo;
        }
        /// <summary>
        /// 根据当前日期 判断Access_Token 是否超期  如果超期返回新的Access_Token   否则返回之前的Access_Token
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string GetAccessToken()
        {
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
                expires_in_time =  new DateTime(1970, 1, 1);
            }


            if (DateTime.Now > expires_in_time)
            {
                AccessToken tmpAccessToken = GetAccessTokenOnline();
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

        public static string GetPage(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = null;
            if (postData.Length > 0) //有值代表创建菜单
            {
                data = encoding.GetBytes(postData);
            }
 
            try
            {
                // 设置参数
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                if (postData.Length > 0)
                {
                    request.Method = "POST"; //创建菜单
                }
                else
                {
                    request.Method = "GET"; //删除菜单
                }

                request.ContentType = "application/x-www-form-urlencoded";

                if (postData.Length > 0) //有值代表创建菜单
                {
                    request.ContentLength = data.Length;
                    outstream = request.GetRequestStream();
                    outstream.Write(data, 0, data.Length);
                    outstream.Close();
                }

                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                //Response.Write(err);
                //Response.End();
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取Access_token
        /// </summary>
        /// <returns></returns>
        private static AccessToken GetAccessTokenOnline() 
        {
            WxAppInfo wxAppInfo =   WxchatHelper.GetWxAppInfo();
            string appid = wxAppInfo.AppID;//"你自己微信公众测试号的appID"; //微信公众号appid
            string secret = wxAppInfo.AppSecret;// "你自己微信公众测试号的appsecret";  //微信公众号appsecret

            string strUrl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + secret;
            AccessToken token = new AccessToken();

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(strUrl);  //用GET形式请求指定的地址 
            req.Method = "GET";

            using (WebResponse wr = req.GetResponse())
            {
                //HttpWebResponse myResponse = (HttpWebResponse)req.GetResponse();  
                StreamReader reader = new StreamReader(wr.GetResponseStream(), Encoding.UTF8);
                string content = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                token = JsonHelper.ParseFromJson<AccessToken>(content);
            }
            return token;
        }

        public static string GetWxMenuOnline(){
            string access_token = GetAccessToken();
            string responseJson = GetPage("https://api.weixin.qq.com/cgi-bin/menu/get?access_token=" + access_token,"");
            return responseJson;
        }
        public static string CreateWxMenuOnline(string menuJsonText)
        {
            string access_token = GetAccessToken();
            string responseJson = GetPage("https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + access_token, menuJsonText);
            return responseJson;
        }
    }
}
