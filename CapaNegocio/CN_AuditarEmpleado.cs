using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class CN_AuditarEmpleado
    {
        private CD_AuditarEmpleado objCDAuditarE = new CD_AuditarEmpleado();
        public List<AuditarEmpleados> ObtenerEmpleadosEliminados()
        {
            return objCDAuditarE.ObtenerEmpleadosEliminados();
        }

    }
}
