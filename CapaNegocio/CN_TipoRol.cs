using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Rol
    {

        private CD_Rol objcd_TipoRol = new CD_Rol();


        public List<TipoRol> Listar()
        {
            return objcd_TipoRol.Listar();
        }
    }
}