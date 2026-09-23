using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1_POO.Controllers;
using T1_POO.Models;

namespace T1_POO.Controllers
{
    public class AdministrativoController : Controller
    {
        [HttpGet]
        public ActionResult RegistrarAdministrativo()
        {
            
            Administrativo administrativo = new Administrativo();
            return View(administrativo);
        }

       
        [HttpPost]
        
        public ActionResult RegistrarAdministrativo(Administrativo administrativo)
        {
                ViewBag.AniosServicio = administrativo.AñosServicio();

                ViewBag.SueldoBasico = administrativo.SueldoBasico();

                ViewBag.Escolaridad = administrativo.Escolaridad();

                ViewBag.Bonificacion = administrativo.Bonificacion();

                ViewBag.Incentivo = administrativo.Incentivo();

                ViewBag.MontoAPagar = administrativo.MontoAPagar();
            
            return View(administrativo);
        }
    }
}
