using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;



namespace CapaNegocio
{
    public class CN_RegistrarP
    {
        private CD_RegistrarP objCDRegistrarP = new CD_RegistrarP();

        public List<Producto> CargarProductos()
        {
            return objCDRegistrarP.CargarProductos();
        }
      

        public string GuardarProducto(Producto producto, string accion)
        {
            return objCDRegistrarP.GuardarProducto(producto, accion);
        }

        public string EditarProducto(Producto producto, string accion)
        {
            return objCDRegistrarP.EditarProducto(producto, accion);
        }

        public string EliminarProducto(Producto producto, string accion)
        {
            return objCDRegistrarP.EliminarProducto(producto, accion);
        }

       
    }
}
