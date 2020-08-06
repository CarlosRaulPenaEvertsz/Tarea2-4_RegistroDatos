using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace Tarea2_4_RegistroDatos.Models
{
    public class clsDatosClientes
    {
        public void RegistrarCliente(string nombre, string cedula, string telefono, string correo )
        {
            StreamWriter archivoClientes = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/DatosClientes.txt", true);
            archivoClientes.WriteLine("<tr><td>" + nombre + "</td><td>" + cedula + "</td><td>" + telefono + "</td><td>" + correo + "</td></tr>");
            //archivo.WriteLine("Nombre:" + nombre + "<br>Cedula:" + cedula + "<br>Telefono:" + telefono + "<br>Email:" + correo + "<hr>");
            archivoClientes.Close();
        }

        public string LeerClientes()
        {
            StreamReader archivoClientes = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/DatosClientes.txt");
            string TodosLosRegistros = archivoClientes.ReadToEnd();
            archivoClientes.Close();
            return TodosLosRegistros;
        }



    }
}