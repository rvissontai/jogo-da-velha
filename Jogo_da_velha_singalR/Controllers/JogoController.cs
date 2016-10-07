using Jogo_da_velha_singalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jogo_da_velha_singalR.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SalaDeEspera(JogadorViewModel model)
        {

            return View(model);
        }
    }
}