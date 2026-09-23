using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1_POO.Models;

namespace T1_POO.Controllers
{
    public class EmpleadoController : Controller
    {
        [HttpGet]
        public ActionResult RegistrarEmpleado()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado empleado)
        {
            ViewBag.SueldoBasico = empleado.SueldoBasico();
            ViewBag.Escolaridad = empleado.Escolaridad();
            ViewBag.Bonificacion = empleado.Bonificacion();
            ViewBag.MontoAPagar = empleado.MontoAPagar();
            return View(empleado);
        }

        private static List<Empleado> planilla = new List<Empleado>
          {
          new Empleado
            {
            idEmpleado = "E001",
            nomapeEmpleado = "Carlos Carlin",
            categoriaEmpleado = "E1",
            nHijos = 2,
            tipoContrato = "INDEFINIDO"
          },
          new Empleado
           {
            idEmpleado = "E002",
            nomapeEmpleado = "Maria De las Casas",
            categoriaEmpleado = "E3",
            nHijos = 1,
            tipoContrato = "CONTRATADO"
          },

          new Empleado
          {
           idEmpleado = "E003",
           nomapeEmpleado = "Jose Luis Rodriguez",
           categoriaEmpleado = "E2",
           nHijos = 3,
           tipoContrato = "INDEFINIDO"
          },

          new Empleado
          {
           idEmpleado = "E004",
           nomapeEmpleado = "Juana de Arco",
           categoriaEmpleado = "E2",
           nHijos = 0,
           tipoContrato = "CONTRATADO"
          }
         };
        [HttpGet]
        public ActionResult Planilla()
        {
            ViewBag.Planilla = planilla;
            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult Planilla(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                planilla.Add(empleado);
                TempData["Mensaje"] =
                "El empleado fue agregado correctamente.";
                return RedirectToAction("Planilla");
            }
            ViewBag.Planilla = planilla;
            return View(empleado);
        }
    }
}

