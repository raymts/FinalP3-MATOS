using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Paciente
    {
        public int id { get; set; }
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Fecha_bd { get; set; }
        public String Tipo_sangre { get; set; }
        public String Seguro { get; set; }
    }
}