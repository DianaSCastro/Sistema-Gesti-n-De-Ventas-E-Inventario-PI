using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenDTO
    {
        //public int IdProducto { get; set; }// Identificador del producto (relacionado con la tabla Producto)
        public string CodigoProducto2 { get; set; }
        
        public string Producto { get; set; }// Nombre del producto (para mostrarlo en la interfaz de usuario, pero no se debe almacenar directamente en DetalleVenta por normalización

        public int Cantidad { get; set; }// Cantidad de unidades que el cliente desea comprar del producto
        public decimal Subtotal2 { get; set; }// Subtotal calculado para la cantidad de producto comprado (normalmente es Cantidad * PrecioVenta)

    }
}
