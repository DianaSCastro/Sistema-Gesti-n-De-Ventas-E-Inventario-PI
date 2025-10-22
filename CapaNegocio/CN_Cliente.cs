using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente objCDCliente = new CD_Cliente();

        public string GuardarCliente(Cliente cliente, string accion)
        {
            return objCDCliente.GuardarCliente(cliente, accion);
        }

        

        public List<ClienteDTO> CargarVistaCliente()
        {
            return objCDCliente.CargarVistaCliente();
        }


        public string EditarCliente(Cliente cliente, string accion)
        {
            return objCDCliente.EditarCliente(cliente, accion);
        }
        public string EliminarCliente(Cliente cliente, string accion)
        {
            return objCDCliente.EliminarCliente(cliente, accion);
        }



    }
}
