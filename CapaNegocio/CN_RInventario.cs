using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        private CD_Inventario objCDInventario = new CD_Inventario();

        public List<InventarioDT> CargarVistaInventario()
        {
            return objCDInventario.CargarVistaInventario();
        }


        public void ActualizarStock(string CodigoProducto, string TipoMovimiento, int Cantidad)
        {
            objCDInventario.ActualizarStock(CodigoProducto, TipoMovimiento, Cantidad);
        }


    }

}
