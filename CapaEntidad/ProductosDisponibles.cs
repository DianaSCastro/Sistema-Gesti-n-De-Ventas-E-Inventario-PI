using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProductosDisponibles
    {
        //public int IdProducto {  get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string NombreCategoria { get; set; }
        public int StockActual { get; set; }
        public decimal PrecioVenta { get; set; }
    }


}

