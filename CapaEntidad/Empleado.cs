using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        
        public TipoRol oTipoRol { get; set; }
        public bool Estado { get; set; }
        public string FechaIngreso { get; set; }


      
    }
}
