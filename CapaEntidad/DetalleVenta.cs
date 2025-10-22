using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        //public int IdDetalleVenta { get; set; }
        //public Venta oVenta { get; set; }
        //public Producto oProducto { get; set; }       // Producto específico de la venta
        //public int Cantidad { get; set; }
        //public decimal PrecioVenta { get; set; }
        //public decimal Subtotal => Cantidad * PrecioVenta;  // Cálculo del subtotal

        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }

  


    }
}
