using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    public class WxMenuItem
    {

        [Newtonsoft.Json.JsonIgnore()]
        public string SelfCode { get; set; }

        [Newtonsoft.Json.JsonIgnore()]
        public string ParentCode { get; set; }

        [Newtonsoft.Json.JsonIgnore()]

        public int Level { get; set; }

        [Newtonsoft.Json.JsonIgnore()]

        public int Index { get; set; }

        [Newtonsoft.Json.JsonIgnore()]

        public string CreateDate { get; set; }
        [Newtonsoft.Json.JsonIgnore()]
        public string UpdateDate { get; set; }
        [JsonProperty("menu")]
        public string Menu { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("sub_button")]
        public List<WxMenuItem> SunWxMenuItems { get; set; }
    }
}
