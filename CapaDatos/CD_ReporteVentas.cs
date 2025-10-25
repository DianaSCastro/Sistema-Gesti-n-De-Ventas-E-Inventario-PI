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
            string query = "SELECT IdVenta, FechaVenta, NombreEmpleado, ProductosVendidos, SubtotalVenta FROM vw_ReporteVentas WHERE FechaVenta BETWEEN @FechaInicio AND @FechaFin";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        // 2. ✅ CORRECCIÓN: Añadir los parámetros al comando SQL
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date); // Usar solo la fecha
                                                                                       // Asegurar que el filtro incluya el final del día:
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date.AddDays(1).AddSeconds(-1));

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