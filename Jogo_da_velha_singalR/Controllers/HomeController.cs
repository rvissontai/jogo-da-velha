using Microsoft.AspNet.SignalR;
using SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jogo_da_velha_singalR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<JogoHub>();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}