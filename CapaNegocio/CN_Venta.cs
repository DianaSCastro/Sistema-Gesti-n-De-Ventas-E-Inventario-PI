using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCDVenta = new CD_Venta();

        public List<ProductosDisponibles> ObtenerProductosDisponibles()

        {
            return objCDVenta.ObtenerProductosDisponibles();
        }


        // Método para procesar la venta
        public decimal ProcesarVenta(List<OrdenDTO> orden, int idEmpleado, int? idCliente, string correoCliente)
        {
            decimal totalVenta = 0;
            string ticket;

            try
            {
                // Validar que la orden tenga productos
                if (orden == null || orden.Count == 0)
                {
                    throw new Exception("La orden no puede estar vacía.");
                }

                // Validar el correo si es obligatorio
                if (string.IsNullOrEmpty(correoCliente))
                {
                    throw new Exception("El correo del cliente no puede estar vacío.");
                }

                // Llamar al método de la capa de datos para procesar la venta
                totalVenta = objCDVenta.ProcesarVentaConCursor(orden, idEmpleado, idCliente, correoCliente);
              
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                throw new Exception("Error al procesar la venta en la capa de negocio: " + ex.Message);
            }


            return totalVenta;
        }


        public int ObtenerUltimaVenta()
        {
            try
            {
                return objCDVenta.ObtenerUltimaVenta(); // Llama al método en la capa de datos.
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la última venta: " + ex.Message);
            }
        }

        public string ObtenerTicketFormateado(int idVenta)
        {
            try
            {
                Tickets ticket = objCDVenta.ObtenerTicket(idVenta); // Recuperar ticket desde la base de datos
                return FormatearTicket(ticket); // Formatear para texto plano
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ticket: " + ex.Message);
            }
        }

        public string FormatearTicket(Tickets ticket)
        {
            if (ticket == null)
                return "No se pudo generar el ticket.";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("********** TICKET DE VENTA **********");
            sb.AppendLine($"ID Venta: {ticket.IdVenta}");
            sb.AppendLine($"Fecha: {ticket.FechaVenta}");
            sb.AppendLine($"Cliente: {ticket.NombreCliente}");
            sb.AppendLine($"Correo: {ticket.CorreoCliente}");
            sb.AppendLine("-------------------------------------");
            sb.AppendLine("PRODUCTOS:");
            foreach (var detalle in ticket.Detalles)
            {
                sb.AppendLine($"{detalle.NombreProducto} | Cant: {detalle.Cantidad} | P.U.: {detalle.PrecioVenta:C} | Subtotal: {detalle.Subtotal:C}");
            }
            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"TOTAL: {ticket.TotalVenta:C}");
            sb.AppendLine("*************************************");
            sb.AppendLine("¡Gracias por su compra!");

            return sb.ToString();
        }


        public bool VerificarStockSuficiente(string codigoProducto, int cantidadSolicitada)
        {
            return objCDVenta.VerificarStockSuficiente(codigoProducto, cantidadSolicitada);
        }



        //public int ObtenerStockDisponible(string codigoProducto)
        //{
        //    return objCDVenta.ObtenerStockDisponible(codigoProducto);
        //}

        //public bool VerificarStockSuficiente(string codigoProducto, int cantidadSolicitada)
        //{
        //    return objCDVenta.VerificarStockSuficiente(codigoProducto, cantidadSolicitada);
        //}
    }
}
