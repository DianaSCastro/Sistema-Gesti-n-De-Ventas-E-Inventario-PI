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
    public class CD_AuditarClientes
    {
        public List<AuditarClientesE> ObtenerClientesEliminados()
        {
            List<AuditarClientesE> clientesEliminados = new List<AuditarClientesE>();

            // Usamos SqlConnection para acceder a la base de datos
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT IdCliente, NombreCliente, Correo, Telefono, FechaEliminacion FROM ClientesEliminados";

                SqlCommand comando = new SqlCommand(query, conexion);
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    AuditarClientesE cliente = new AuditarClientesE
                    {
                        IdCliente = reader.GetInt32(0),
                        NombreCliente = reader.GetString(1),
                        Correo = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        FechaEliminacion = reader.GetDateTime(4)
                    };

                    clientesEliminados.Add(cliente);
                }
            }

            return clientesEliminados;
        }
    }


}






