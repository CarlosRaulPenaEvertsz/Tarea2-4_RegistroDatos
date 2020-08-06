using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace Tarea2_4_RegistroDatos.Models
{
    public class clsDatosPersonas
    {
        public void RegistrarPersonas(string nombre, string cedula, string telefono, string correo )
        {
            StreamWriter archivoPersonas = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/DatosPersonas.txt", true);
            archivoPersonas.WriteLine("<tr><td>" + nombre + "</td><td>" + cedula + "</td><td>" + telefono + "</td><td>" + correo + "</td></tr>");
            //archivo.WriteLine("Nombre:" + nombre + "<br>Cedula:" + cedula + "<br>Telefono:" + telefono + "<br>Email:" + correo + "<hr>");
            archivoPersonas.Close();
        }

        public string LeerPersonas()
        {
            StreamReader archivoPersonas = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/DatosPersonas.txt");
            string TodasLasPersonas = archivoPersonas.ReadToEnd();
            archivoPersonas.Close();
            return TodasLasPersonas;
        }



    }
}