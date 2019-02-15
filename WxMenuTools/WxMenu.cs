using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    class WxMenu
    {
        [JsonProperty("button")]
        public List<WxMenuItem> SunWxMenuItems { get; set; }
        //public WxMenu()
        //{
        //    SunWxMenuItems = new List<WxMenuItem>();
        //}
    }
}
