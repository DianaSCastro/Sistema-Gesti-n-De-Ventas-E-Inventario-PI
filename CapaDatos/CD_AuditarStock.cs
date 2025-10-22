using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Transactions;

namespace CapaDatos
{
    public class CD_AuditarStock
    {
        public List<AuditarStock> ObtenerAuditorStock()
        {
            List<AuditarStock> lista = new List<AuditarStock>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "SELECT IdAuditoria, IdProducto, NombreProducto, StockActual, FechaAuditoria FROM AuditoriaStock";
                    SqlCommand command = new SqlCommand(consulta, oconexion);
                    oconexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(new AuditarStock
                        {
                            IdAuditoria = reader.GetInt32(0),
                            IdProducto = reader.GetInt32(1),
                            NombreProducto = reader.GetString(2),
                            StockActual = reader.GetInt32(3),
                            FechaAuditoria = reader.GetDateTime(4)
                        });
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al consultar auditoría: " + ex.Message);
                }
            }

            return lista;

        }
    }
}
