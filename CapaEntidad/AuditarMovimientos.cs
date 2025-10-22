using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public  class AuditarMovimientos
    {

        public int IdAuditoria { get; set; }
        public int IdMovimiento { get; set; }
        public int IdEmpleado{ get; set; }
        public int IdProducto { get; set; }

        
        
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; }
       


    }
}
