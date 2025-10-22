using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        //public int IdVenta { get; set; }                // Identificador único de la venta
        //public Empleado oEmpleado { get; set; }         // Empleado que realizó la venta
        //public Cliente oCliente { get; set; }           // Cliente que realizó la compra
        //public List<DetalleVenta> oDetalleVenta { get; set; } // Detalles de los productos vendidos
        //public decimal TotalVenta => oDetalleVenta.Sum(d => d.Subtotal); // Cálculo del total de la venta
        //public string FechaVenta { get; set; }      // Fecha en que se registró la venta



        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public int? IdCliente { get; set; }
        public decimal TotalVenta { get; set; }
        public DateTime FechaVenta { get; set; }
    }


}
