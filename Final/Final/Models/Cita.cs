using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Usuario { get; set; }
        public String Clave { get; set; }
        public String Tipo_consulta { get; set; }
        public String Doctor { get; set; }
        public String Fecha { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }
    }
}