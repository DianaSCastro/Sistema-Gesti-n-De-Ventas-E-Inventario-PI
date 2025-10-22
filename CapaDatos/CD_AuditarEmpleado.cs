using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

using System.Transactions;


namespace CapaDatos
{
    public class CD_AuditarEmpleado
    {
            public List<AuditarEmpleados> ObtenerEmpleadosEliminados()
            {
                List<AuditarEmpleados> empleadosEliminados = new List<AuditarEmpleados>();

                // Usamos SqlConnection para acceder a la base de datos
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT IdEmpleado, NombreEmpleado, Correo, IdRol, Estado, FechaIngreso, FechaEliminacion FROM AuditoriaEmpleados";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                    AuditarEmpleados empleado = new AuditarEmpleados
                    {
                        IdEmpleado = reader.GetInt32(0),
                        NombreEmpleado = reader.GetString(1),
                        Correo = reader.GetString(2),
                        IdRol = reader.GetInt32(3),
                        Estado = reader.GetBoolean(4),
                        FechaIngreso = reader.GetDateTime(5),
                        FechaEliminacion = reader.GetDateTime(6)
                    };

                        empleadosEliminados.Add(empleado);
                    }
                }

                return empleadosEliminados;
            }
      }


}


