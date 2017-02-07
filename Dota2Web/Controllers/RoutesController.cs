using System.Web.Mvc;
using DotaApiManage;
using System.Collections.Generic;
using System;

namespace Dota2Web.Controllers
{
    public class RoutesController : Controller
    {
        public ActionResult search()
        {
            return View();
        }

        public ActionResult results(string id = "0")
        {
            ViewBag.id = id;

            ApiAccess apia = new ApiAccess(id);
            List<string> resList = apia.GetMatchIds();

            ViewBag.matchIds = resList;

            return View();
        }

        public ActionResult about()
        {
            return View();
        }
    }
}