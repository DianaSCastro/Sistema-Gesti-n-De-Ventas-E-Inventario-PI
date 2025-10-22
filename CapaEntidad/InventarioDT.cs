using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class InventarioDT
    {
        public int IdInventario { get; set; }
        //public int IdProducto {  get; set; }
        public string CodigoProducto { get; set; } // Relación con Producto
        public string NombreProducto { get; set; } // Relación con Producto
        public string NombreCategoria { get; set; } // Relación con Categoria
        public DateTime FechaMovimiento { get; set; } // Relacionado con la fecha del movimiento
        public string TipoMovimiento { get; set; } // Entrada o Salida
        public int Cantidad { get; set; } // La cantidad que se mueve
        public int StockActual { get; set; } // El stock actual del producto

    }





}
