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
    public class CD_Venta
    {

        public List<ProductosDisponibles> ObtenerProductosDisponibles()
        {
            List<ProductosDisponibles> productos = new List<ProductosDisponibles>();  // Lista para almacenar los productos

            string query = "SELECT * FROM View_ProductosDis";  // Consulta a la vista

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))  // Abrir conexión
                {
                    oconexion.Open();
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterar sobre cada registro obtenido de la consulta
                            while (reader.Read())
                            {
                                // Crear el objeto producto con los datos obtenidos de cada fila
                                ProductosDisponibles producto = new ProductosDisponibles
                                {
                                    CodigoProducto = reader.GetString(0),  // Asegúrate de que el índice coincida con la columna
                                    NombreProducto = reader.GetString(1),
                                    Descripcion = reader.GetString(2),
                                    NombreCategoria = reader.GetString(3),
                                    StockActual = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),  // Manejo de valores nulos
                                    PrecioVenta = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5)   // Si el precio es decimal
                                };

                                productos.Add(producto);  // Añadir el producto a la lista
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());  // Para verificar cualquier excepción
            }

            return productos;  // Retorna la lista de productos
        }


        public decimal ProcesarVentaConCursor(List<OrdenDTO> orden, int idEmpleado, int? idCliente, string correoCliente)
        {
            decimal totalVenta = 0;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ProcesarVentaConCursor2", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Crear el parámetro de tabla
                        SqlParameter paramOrden = new SqlParameter("@Orden", SqlDbType.Structured)
                        {
                            TypeName = "dbo.OrdenTipo2", // Tipo de tabla definido en SQL Server
                            Value = CrearTablaOrden(orden)
                        };
                        cmd.Parameters.Add(paramOrden);

                        // Parámetros adicionales
                        cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        cmd.Parameters.AddWithValue("@IdCliente", (object)idCliente ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CorreoCliente", correoCliente);

                        // Parámetro de salida
                        SqlParameter paramTotalVenta = new SqlParameter("@TotalVenta", SqlDbType.Decimal)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramTotalVenta);

                        // Ejecutar el procedimiento
                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        // Obtener el total de la venta desde el parámetro de salida
                        totalVenta = paramTotalVenta.Value != DBNull.Value ? (decimal)paramTotalVenta.Value : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la venta en la capa de datos: " + ex.Message);
            }

            return totalVenta;
        }

      

        private DataTable CrearTablaOrden(List<OrdenDTO> orden)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CodigoProducto2", typeof(string));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Subtotal", typeof(decimal));

            foreach (var item in orden)
            {
                table.Rows.Add(item.CodigoProducto2, item.Cantidad, item.Subtotal2);
            }

            return table;
        }


        public bool VerificarStockSuficiente(string codigoProducto, int cantidadSolicitada)
        {
            bool stockSuficiente = false;

            using (var oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Aquí se realiza la consulta a la base de datos
                string query = "SELECT StockActual FROM Inventario WHERE IdProducto = (SELECT IdProducto FROM Producto WHERE CodigoProducto = @CodigoProducto)";
                using (var command = new SqlCommand(query, oconexion))
                {
                    // Definir el parámetro de entrada
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                    // Ejecutar la consulta y obtener el stock actual
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int stockActual = Convert.ToInt32(result);

                        // Comparar si el stock es suficiente
                        if (stockActual >= cantidadSolicitada)
                        {
                            stockSuficiente = true;
                        }
                    }
                }
            }

            return stockSuficiente;
        }
        //public int InsertarVenta(List<OrdenDTO> orden, int idEmpleado, int? idCliente, string correoCliente)
        //{
        //    int idVenta = 0;

        //    using (var oconexion = new SqlConnection(Conexion.cadena))
        //    {
        //        oconexion.Open();

        //        // Inserción de la venta
        //        string query = "INSERT INTO Ventas (IdEmpleado, IdCliente, CorreoCliente, FechaVenta) OUTPUT INSERTED.IdVenta VALUES (@IdEmpleado, @IdCliente, @CorreoCliente, GETDATE())";

        //        using (SqlCommand cmd = new SqlCommand(query, oconexion))
        //        {
        //            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
        //            cmd.Parameters.AddWithValue("@IdCliente", (object)idCliente ?? DBNull.Value); // Si idCliente es nulo, se pasa DBNull
        //            cmd.Parameters.AddWithValue("@CorreoCliente", correoCliente);

        //            // Obtener el ID de la venta recién insertada
        //            idVenta = (int)cmd.ExecuteScalar();  // Devuelve el valor del ID insertado
        //        }
        //    }

        //    return idVenta;  // Retornar el ID de la venta
        //}

        public int ObtenerUltimaVenta()
        {
            int idVenta = 0;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT TOP 1 IdVenta FROM Venta ORDER BY FechaVenta DESC";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();

                    var result = cmd.ExecuteScalar();
                    idVenta = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el último ID de venta: " + ex.Message);
            }
            return idVenta;
        }


        public Tickets ObtenerTicket(int idVenta)
        {
            Tickets ticket = null;
            string query = "SELECT * FROM Vista_Ticket WHERE IdVenta = @IdVenta";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    oconexion.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        ticket = new Tickets { Detalles = new List<DetalleVentas>() };

                        while (reader.Read())
                        {
                            ticket.IdVenta = reader.GetInt32(reader.GetOrdinal("IdVenta"));
                            ticket.FechaVenta = reader.GetDateTime(reader.GetOrdinal("FechaVenta"));
                            ticket.NombreCliente = reader.GetString(reader.GetOrdinal("NombreCliente"));
                            ticket.CorreoCliente = reader.GetString(reader.GetOrdinal("CorreoCliente"));
                            ticket.TotalVenta = reader.GetDecimal(reader.GetOrdinal("TotalVenta"));

                            ticket.Detalles.Add(new DetalleVentas
                            {
                                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                                NombreProducto = reader.GetString(reader.GetOrdinal("NombreProducto")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                PrecioVenta = reader.GetDecimal(reader.GetOrdinal("PrecioVenta")),
                                Subtotal = reader.GetDecimal(reader.GetOrdinal("Subtotal"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error en un log o mostrar un mensaje adecuado
                Console.WriteLine($"Error al obtener el ticket: {ex.Message}");
            }
            return ticket;
        }
    }










    //public int ObtenerStockDisponible(string codigoProducto)
    //{
    //    int stock = 0;


    //    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
    //    {
    //        string query = "SELECT StockActual FROM Inventario WHERE IdProducto = IdProducto";
    //        SqlCommand cmd = new SqlCommand(query, oconexion);
    //        cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

    //        try
    //        {
    //            oconexion.Open();
    //            stock = (int)cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene el stock disponible
    //        }
    //        catch (Exception ex)
    //        {
    //            // Manejo de excepciones, si es necesario
    //            throw new Exception("Error al consultar el stock: " + ex.Message);
    //        }
    //    }

    //    return stock;
}

        //public void ProcesarVenta(List<OrdenDTO> orden, int idEmpleado, int? idCliente, out decimal totalVenta)
        //{
        //    totalVenta = 0;



        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("ProcesarVentaConCursor2", oconexion))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                // Crear el parámetro de tabla
        //                SqlParameter paramOrden = new SqlParameter("@Orden", SqlDbType.Structured)
        //                {
        //                    TypeName = "dbo.OrdenTipo2", // Asegúrate de que coincida con tu tipo de tabla en SQL
        //                    Value = CrearTablaOrden(orden)
        //                };
        //                cmd.Parameters.Add(paramOrden);

        //                // Otros parámetros
        //                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
        //                cmd.Parameters.AddWithValue("@IdCliente", (object)idCliente ?? DBNull.Value);

        //                SqlParameter paramTotalVenta = new SqlParameter("@TotalVenta", SqlDbType.Decimal)
        //                {
        //                    Direction = ParameterDirection.Output
        //                };
        //                cmd.Parameters.Add(paramTotalVenta);

        //                // Ejecutar el comando
        //                oconexion.Open();
        //                cmd.ExecuteNonQuery();

        //                // Recuperar el total de la venta
        //                totalVenta = (decimal)paramTotalVenta.Value;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al procesar la venta: " + ex.Message);
        //    }
        //}

        // Método para convertir la lista OrdenDTO en un DataTable
        //    private DataTable CrearTablaOrden(List<OrdenDTO> orden)
        //    {
        //        DataTable table = new DataTable();
        //        table.Columns.Add("CodigoProducto", typeof(string));
        //        table.Columns.Add("Cantidad", typeof(int));
        //        table.Columns.Add("Subtotal", typeof(decimal));

        //        foreach (var item in orden)
        //        {
        //            if (string.IsNullOrWhiteSpace(item.CodigoProducto))
        //            {
        //                throw new Exception("Se encontró un producto sin un código válido.");
        //            }

        //            table.Rows.Add(item.CodigoProducto, item.Cantidad, item.Subtotal);
        //        }

        //        return table;
        //    }
        //}


    



            
