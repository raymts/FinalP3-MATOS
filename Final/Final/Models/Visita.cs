using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Visita
    {
        public int Id { get; set; }
        public String Cedula { get; set; }
        public String Fecha { get; set; }
        public String Motivo { get; set; }
        public String Comentario { get; set; }
        public String Receta_medicamentos { get; set; }
        public String Fecha_sig { get; set; }
        public int Precio { get; set; }
    }
}