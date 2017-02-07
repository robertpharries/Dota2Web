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

            DotaApiManage.MatchHistory.ApiAccess apia = new DotaApiManage.MatchHistory.ApiAccess(id);
            List<string> resList = apia.GetMatchIds();
            List<DotaApiManage.MatchDetails.ApiAccess> mdList = new List<DotaApiManage.MatchDetails.ApiAccess>();
            foreach (var mid in resList)
            {
                mdList.Add(new DotaApiManage.MatchDetails.ApiAccess(mid));
            }

            ViewBag.matchIds = resList;

            ViewBag.mdList = mdList;

            return View();
        }

        public ActionResult about()
        {
            return View();
        }
    }
}