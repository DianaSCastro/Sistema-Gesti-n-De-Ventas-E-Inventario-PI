using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using System;

namespace CapaDatos
{
    public class CD_ReporteVentas
    {
        public List<ReporteVentas> ObtenerReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();
            string query = "SELECT * FROM vw_ReporteVentas";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ReporteVentas
                                {
                                    IdVenta = reader.GetInt32(0),
                                    FechaVenta = reader.GetDateTime(1),
                                    NombreEmpleado = reader.GetString(2),
                                    ProductosVendidos = reader.GetString(3),
                                    SubtotalVenta = reader.GetDecimal(4)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el reporte de ventas: " + ex.Message);
            }

            return lista;
        }
    }
}