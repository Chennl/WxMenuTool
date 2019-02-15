using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WxLibrary
{
   
    public class WxController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        [Route("wx/GetJsapiTicket")]
        [HttpGet]
        public Hashtable GetJsapiTicket(string url)
        {
            WxAppInfo wxAppInfo=WxchatHelper.GetWxAppInfo();
          //  string url = "http://www.ewushi.com/jssdk/index.html";
            return WxJsapiHelper.GetJSAPIParameters(wxAppInfo.AppID, wxAppInfo.AppSecret, url);
          //  return "tickect";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}