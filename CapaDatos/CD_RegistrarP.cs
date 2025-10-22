using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_RegistrarP
    {
        public List<Producto> CargarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            string query = "Select * FROM View_RegistrarProducto;";

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
                                Producto producto = new Producto
                                {
                                    IdProducto = reader.GetInt32(0),
                                    NombreProducto = reader.GetString(1),
                                    Descripcion = reader.GetString(2),
                                    oCategoria = new Categoria
                                    {
                                        NombreCategoria = reader.GetString(3)
                                    },
                                    PrecioVenta = reader.GetDecimal(4),
                                    Estado = reader.GetBoolean(5),
                                    FechaRegistro = reader.GetDateTime(6).ToString("yyyy-MM-dd"),
                                    CodigoProducto = reader.GetString(7)
                                };
                                listaProductos.Add(producto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar productos: " + ex.Message);
            }

            return listaProductos;
        }

        public string GuardarProducto(Producto producto, string accion)
        {
            string resultado = "";
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GestionarProducto", oconexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto == 0 ? (object)DBNull.Value : producto.IdProducto);
                    cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@NombreCategoria", producto.oCategoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);
            

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Producto guardado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al guardar producto: " + ex.Message;
                }
            }

            return resultado;
        }

        public string EditarProducto(Producto producto, string accion)
        {
            string resultado = "";
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GestionarProducto", oconexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto == 0 ? (object)DBNull.Value : producto.IdProducto);
                    cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@NombreCategoria", producto.oCategoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Producto actualizado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al actualizar producto: " + ex.Message;
                }
            }

            return resultado;
        }


        public string EliminarProducto(Producto producto, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GestionarProducto", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Solo se necesitan estos parámetros para la acción 'Eliminar'
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);

                    // Abrir la conexión y ejecutar
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = "Producto eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al eliminar producto: " + ex.Message;
                }
            }

            return resultado;
        }

    }
}


