using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxLibrary
{
    public class JsapiTicket
    {
        public JsapiTicket()
        {
        }
        public long errcode { get; set; }
        public string errmsg { get; set; }
        public string ticket { get; set; }
        public long  expires_in { get; set; }
    }

}
