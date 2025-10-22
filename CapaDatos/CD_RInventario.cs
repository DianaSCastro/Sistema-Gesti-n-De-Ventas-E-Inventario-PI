using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Transactions;
using System.Collections;

namespace CapaDatos
{
    public class CD_Inventario
    {
        public List<InventarioDT> CargarVistaInventario()
        {
            List<InventarioDT> inventarios = new List<InventarioDT>();

            string query = "Select * FROM View_Inventario2";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InventarioDT inventario = new InventarioDT
                                {
                                    // Asignar los valores de las columnas
                                    IdInventario = reader.GetInt32(0), // IdInventario
                                    CodigoProducto = reader.GetString(1),
                                    NombreProducto = reader.GetString(2), // NombreProducto
                                    NombreCategoria = reader.GetString(3), // NombreCategoria
                                    FechaMovimiento = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                                    TipoMovimiento = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                    Cantidad = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                    StockActual = reader.IsDBNull(7) ? 0 : reader.GetInt32(7)
                                };

                                inventarios.Add(inventario);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Error SQL en CargarVistaInventario: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CargarVistaInventario: {ex.Message}");
            }

            // Ordenar por FechaMovimiento en orden descendente
            return inventarios.OrderByDescending(i => i.FechaMovimiento).ToList();
        }


        public void ActualizarStock(string CodigoProducto, string TipoMovimiento, int Cantidad)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("ActualizarStockCursor1", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                //cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                cmd.Parameters.AddWithValue("@TipoMovimiento", TipoMovimiento);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);

                oconexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
    



