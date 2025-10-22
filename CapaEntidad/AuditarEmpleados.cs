using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditarEmpleados
    {
            public int IdEmpleado { get; set; }
            public string NombreEmpleado { get; set; }
            public string Correo { get; set; }
            public int IdRol { get; set; }
            public bool Estado { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaEliminacion { get; set; }
        }

       

 }

