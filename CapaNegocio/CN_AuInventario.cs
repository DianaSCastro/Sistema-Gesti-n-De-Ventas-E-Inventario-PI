using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_AuInventario
    {

       
        
            private CD_AuInventario objCDAuditarM = new CD_AuInventario();

            public List<AuditarMovimientos> ObtenerMovimientos()
            {
            return objCDAuditarM.ObtenerMovimientos();
            }
        


    }
}
