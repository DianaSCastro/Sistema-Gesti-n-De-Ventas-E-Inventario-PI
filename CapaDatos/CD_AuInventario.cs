using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_AuInventario
    {
        public List<AuditarMovimientos> ObtenerMovimientos()
        {
            List<AuditarMovimientos> movimientos = new List<AuditarMovimientos>();

            // Usamos un solo bloque using para la conexión
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                // Consulta SQL
                string query = @"
        SELECT 
            am.IdAuditoria, 
            am.IdMovimiento, 
            am.IdProducto, 
            p.NombreProducto, 
            am.TipoMovimiento, 
            am.Cantidad, 
            am.FechaMovimiento, 
            am.IdEmpleado 
        FROM 
            AuditoriaMovimientos am
        JOIN 
            Producto p ON am.IdProducto = p.IdProducto
        JOIN 
            Empleado e ON am.IdEmpleado = e.IdEmpleado
        WHERE 
            e.Estado = 1
        ORDER BY 
            am.FechaMovimiento DESC";
             
                SqlCommand command = new SqlCommand(query, oconexion);

                try
                {
                    oconexion.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        AuditarMovimientos movimiento = new AuditarMovimientos
                        {
                            IdAuditoria = reader.GetInt32(0),  
                            IdMovimiento = reader.GetInt32(1),
                            IdProducto = reader.GetInt32(2),
                            
                            TipoMovimiento = reader.GetString(4),
                            Cantidad = reader.GetInt32(5),
                            FechaMovimiento = reader.GetDateTime(6),
                            IdEmpleado = reader.GetInt32(7)
                        };
                        movimientos.Add(movimiento);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener movimientos: {ex.Message}");
                }
            }
            return movimientos;
        }
    }
}


