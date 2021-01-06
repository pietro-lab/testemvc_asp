using busines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;

namespace teste.Controllers
{
    public class PaginasController : Controller
    {
        // GET: Paginas
        public ActionResult Index()
        {
            ViewBag.paginas = new Pagina().Lista();
            return View();
        }
        public ActionResult novo()
        {
            return View();
        }
        [HttpPost]
        public void Criar()
        {
            var pagina = new Pagina();
            DateTime date;
            DateTime.TryParse(Request["data"], out date);   
            pagina.nome = Request["nome"];
            pagina.data = date;
            pagina.conteudo = Request["conteudo"];
            pagina.Save();
            Response.Redirect("/paginas");
        }
    }
}