using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Receta
    {
        public int Id {get;set;}
        public int Id_paciente {get;set;}
        public int Id_doctor {get;set;}
        public String Fecha {get;set;}
        public String Medicamentos {get;set;}
        public String Descripcion {get;set;}
    }
}