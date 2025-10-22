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
    public class CD_Cliente
    {

        public string GuardarCliente(Cliente cliente, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ClientesCRUD", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente == 0 ? (object)DBNull.Value : cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", cliente.Correo);



                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Cliente guardado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al guardar cliente: " + ex.Message;
                }
            }

            return resultado;
        }

        public List<ClienteDTO> CargarVistaCliente()
        {
            List<ClienteDTO> clientes = new List<ClienteDTO>();
            string query = "SELECT IdCliente, NombreCliente, Correo, Telefono, FechaIngreso FROM Cliente";

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
                                ClienteDTO cliente = new ClienteDTO
                                {
                                    IdCliente = reader.GetInt32(0),
                                    NombreCliente = reader.GetString(1),
                                    Correo = reader.GetString(2),
                                    Telefono = reader.GetString(3),
                                    FechaIngreso = reader.GetDateTime(4).ToString("yyyy-MM-dd")  // Asegúrate de que la fecha se formatee correctamente
                                };

                                clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return clientes;
        }



        public string EditarCliente(Cliente cliente, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_ClientesCRUD", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente == 0 ? (object)DBNull.Value : cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", cliente.Correo);


                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = "Cliente actualizado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al actualizar datos del cliente: " + ex.Message;
                }
            }

            return resultado;
        }

        public string EliminarCliente(Cliente cliente, string accion)
        {
            string resultado = "";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_ClientesCRUD", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar todos los parámetros, aunque algunos pueden ser nulos
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente == 0 ? (object)DBNull.Value : cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", string.IsNullOrEmpty(cliente.NombreCliente) ? (object)DBNull.Value : cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(cliente.Correo) ? (object)DBNull.Value : cliente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(cliente.Telefono) ? (object)DBNull.Value : cliente.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", string.IsNullOrEmpty(cliente.FechaIngreso) ? (object)DBNull.Value : cliente.FechaIngreso);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = "Cliente eliminado correctamente.";
                }
                catch (Exception ex)
                {
                    resultado = "Error al eliminar los datos del cliente: " + ex.Message;
                }
            }

            return resultado;
        }








    }
}


