using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    public class WxApiResponse
    {
        //{"errcode":0,"errmsg":"ok"}
        //{"errcode":40018,"errmsg":"invalid button name size"}
        long errcode { get; set; }
        string errmsg{ get; set; }
    }
}
