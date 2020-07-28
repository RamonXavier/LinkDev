using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkDevRamon.Controllers
{
    public class TalentosController : Controller
    {
        // GET: Talentos
        public ActionResult CacaTalentos()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}