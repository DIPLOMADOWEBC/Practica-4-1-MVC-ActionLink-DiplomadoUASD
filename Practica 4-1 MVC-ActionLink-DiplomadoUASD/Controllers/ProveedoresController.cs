using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_4_1_MVC_ActionLink_DiplomadoUASD.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public ActionResult Listado()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }
    }
}