using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EmpleadoDTO
    {

        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string NombreRol { get; set; }
        public bool Estado { get; set; }
        
        // Propiedad calculada para mostrar el estado en texto
        public string EstadoTexto
        {
            get
            {
                return Estado ? "Activo" : "No Activo";
            }
        }

       public string FechaIngreso { get; set; }
    }
}
