using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public string Index()
        {
            return "Este es mi controlador Home";
        }
        //[Authorize(Roles ="Admin")]
        //[OutputCache(Duration =10)]

        [ActionName("Hora")]
        public string HoraActual() {
            return CadenaHora();
        }

        [NonAction]
        public string CadenaHora() { 
        return "Son las "+ DateTime.Now.ToString("T");
        }
    }
}