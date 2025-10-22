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
    public class CN_Empleado
    {
        
        // Declaración única de la variable objCDEmpleado
        private CD_Empleado objCDEmpleado = new CD_Empleado();

        // Método para validar empleado
        public Empleado ValidarEmpleado(string Correo, string Contraseña, string NombreRol)
        {
            return objCDEmpleado.ValidarEmpleado(Correo, Contraseña, NombreRol);
        }

        private CD_Rol objCDRol = new CD_Rol();

        public List<TipoRol> ObtenerRoles()
        {
            return objCDRol.Listar();
        }

        public string GuardarEmpleado(Empleado empleado, string accion)
        {
            return objCDEmpleado.GuardarEmpleado(empleado, accion);
        }

        public List<EmpleadoDTO> CargarVistaEmpleados()
        {

            return objCDEmpleado.CargarVistaEmpleados();


        }

        public string EditarEmpleado(Empleado empleado, string accion)
        {
            return objCDEmpleado.EditarEmpleado(empleado, accion);
        }

        public string EliminarEmpleado(Empleado empleado, string accion)
        {
            return objCDEmpleado.EliminarEmpleado(empleado, accion);
        }


       






















        //public DataTable ObtenerEmpleados()
        //{
        //   return objCDEmpleado.EjecutarSP("SELECT");
        //}

        //public DataTable ObtenerEmpleadoPorId(int idEmpleado)
        //{
        //   return objCDEmpleado.EjecutarSP("SELECT", idEmpleado: idEmpleado);
        //}

        //public void InsertarEmpleado(string nombreEmpleado, string correo, string contraseña, int idRol, bool estado)
        //{
        //    objCDEmpleado.EjecutarSP("INSERT", nombreEmpleado: nombreEmpleado, correo: correo, contraseña: contraseña, idRol: idRol, estado: estado);
        //}

        //public void ActualizarEmpleado(int idEmpleado, string nombreEmpleado, string correo, string contraseña, int idRol, bool estado)
        //{
        //   objCDEmpleado.EjecutarSP("UPDATE", idEmpleado: idEmpleado, nombreEmpleado: nombreEmpleado, correo: correo, contraseña: contraseña, idRol: idRol, estado: estado);
        //}

        //public void EliminarEmpleado(int idEmpleado)
        //{
        //  objCDEmpleado.EjecutarSP("DELETE", idEmpleado: idEmpleado);
        //}
    }



}
