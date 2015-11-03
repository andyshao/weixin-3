using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeiXin.Commonality;

namespace WeiXin.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.appid = Tags.AppId;
            ViewBag.appsecret = Tags.AppSecret;
            ViewBag.token = Tags.Token;
            return View();
        }

        public JsonResult UploadImage()
        {
            return Json(Tags.Token,JsonRequestBehavior.AllowGet);
        }
       
    }
}
