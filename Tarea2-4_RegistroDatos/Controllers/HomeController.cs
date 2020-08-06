using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea2_4_RegistroDatos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CapturaDatosPersonas()
        {
            return View();
        }
        public ActionResult RegistroDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();

            Models.clsDatosPersonas datosPersonas = new Models.clsDatosPersonas();
            datosPersonas.RegistrarPersonas(nombre, cedula, telefono, correo);
            
            return View();
        }
        public ActionResult ReporteDatosPersonas()
        {
            Models.clsDatosPersonas datosPersonas = new Models.clsDatosPersonas();
            string TodasLasPersonas = datosPersonas.LeerPersonas();
            ViewData["RelacionPersonas"] = TodasLasPersonas;
            return View();
        }
    }
}