using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVentas
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreEmpleado { get; set; }
        public string ProductosVendidos { get; set; }
        public decimal SubtotalVenta { get; set; }

        // Campos adicionales para el RDLC
        public DateTime FechaInicioPeriodo { get; set; } // Fecha inicial del periodo que se está consultando
        public DateTime FechaFinPeriodo { get; set; }    // Fecha final del periodo que se está consultando
        public DateTime FechaReporte { get; set; }       // Fecha en la que se genera el reporte

    }
}
