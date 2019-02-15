using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WxLibrary;

namespace Micodeapi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult JsapiDemo()
        {
           // string url = Request.Url.ToString();
            string url =  Request.Url.AbsoluteUri.Replace("http://","");
            WxAppInfo wxAppInfo = WxchatHelper.GetWxAppInfo();
            Hashtable config_data = WxJsapiHelper.GetJSAPIParameters(wxAppInfo.AppID, wxAppInfo.AppSecret, url);
            ViewBag.Title = "JSSDK Demo";
            ViewBag.appid = (string) config_data["appid"];
            ViewBag.timestamp = (string)config_data["timestamp"];
            ViewBag.noncestr = (string)config_data["noncestr"];
            ViewBag.signature = (string)config_data["signature"];
            ViewBag.jsapi_ticket = (string)config_data["jsapi_ticket"];
            ViewBag.url = (string)config_data["url"];
            return View();
 
        }

    }
}
