using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Transactions;

namespace CapaDatos
{
    public class CD_TicketVenta
    {
        public class TicketData
        {
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
    }
}
