using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class InventarioDTO
    {
        public int IdInventario { get; set; }              // Identificador único de la entrada en el inventario
        public Producto oProducto { get; set; }

        public Categoria oCategoria { get; set; }
        public string FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; } // Indica si es una entrada o salida
        public int Cantidad { get; set; }
        public int StockActual { get; set; }






    }
}
