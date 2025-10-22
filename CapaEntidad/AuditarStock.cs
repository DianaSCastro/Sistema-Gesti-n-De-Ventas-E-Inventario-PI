using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditarStock
    {

        public int IdAuditoria { get; set; }         // Identificador único
        public int IdProducto { get; set; }         // ID del producto
        public string NombreProducto { get; set; }  // Nombre del producto
        public int StockActual { get; set; }        // Stock actual del producto
        public DateTime FechaAuditoria { get; set; } // Fecha y hora de la auditoría


    }
}
