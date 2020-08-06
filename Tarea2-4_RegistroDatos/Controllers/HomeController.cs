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
        public ActionResult CapturaDatosClientes()
        {
            return View();
        }
        public ActionResult RegistroDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();

            Models.clsDatosClientes datosClientes = new Models.clsDatosClientes();
            datosClientes.RegistrarCliente(nombre, cedula, telefono, correo);
            
            return View();
        }
        public ActionResult ReporteDatosClientes()
        {
            Models.clsDatosClientes datosClientes = new Models.clsDatosClientes();
            string TodosLosClientes = datosClientes.LeerClientes();
            ViewData["RelacionClientes"] = TodosLosClientes;
            return View();
        }
    }
}