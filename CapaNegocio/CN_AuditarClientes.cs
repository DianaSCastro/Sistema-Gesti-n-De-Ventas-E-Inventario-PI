using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_AuditarClientes
    {
        private CD_AuditarClientes objCDAuditarC = new CD_AuditarClientes();
        public List<AuditarClientesE> ObtenerClientesEliminados()
        {
            return objCDAuditarC.ObtenerClientesEliminados();
        }

    }
}
