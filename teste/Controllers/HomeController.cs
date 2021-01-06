using busines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             
            ViewBag.paginas = new Pagina().Lista();
            return View();
            //return teste;
        }

        public ActionResult novo()
        {
            return View();
        }
    }
}