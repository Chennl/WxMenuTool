using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    public class AccessToken
    {
        public AccessToken()
        {
        }
        string _access_token;
        string _expires_in;

        public string access_token
        {
            get { return _access_token; }
            set { _access_token = value; }
        }

        /// <summary>
        /// Token expires time，单位：秒
        /// </summary>
        public string expires_in
        {
            get { return _expires_in; }
            set { _expires_in = value; }
        }
    }

}
